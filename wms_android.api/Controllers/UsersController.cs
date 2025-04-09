using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wms_android.shared.Data;
using wms_android.shared.Interfaces;
using wms_android.shared.Models;
using Microsoft.AspNetCore.Authorization;
using System;

namespace wms_android.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly AppDbContext _context;

        public UsersController(IUserService userService, AppDbContext context)
        {
            _userService = userService;
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        [AllowAnonymous] // For testing; consider adding authorization in production
        public async Task<ActionResult<IEnumerable<dynamic>>> GetUsers()
        {
            try
            {
                // Get all users with their roles
                var users = await _userService.GetUsersAsync();
                
                // Format the response with branch information
                var formattedUsers = new List<dynamic>();
                
                foreach (var user in users)
                {
                    // Try to get branch information using raw SQL since we don't have a UserBranch DbSet
                    // This query handles potential schema differences between wms_web and wms_android.api
                    var branchInfo = new
                    {
                        Name = "Unknown", // Default value
                        Address = "",
                        Phone = "",
                        Email = ""
                    };
                    
                    try
                    {
                        // Try query for UserBranches and Branches tables
                        // We use FromSqlRaw to execute a SQL query directly
                        var sql = @"
                            SELECT b.name, b.address, b.phone, b.email 
                            FROM ""UserBranches"" ub 
                            JOIN ""Branches"" b ON ub.branch_id = b.id 
                            WHERE ub.user_id = @userId";
                        
                        using (var command = _context.Database.GetDbConnection().CreateCommand())
                        {
                            command.CommandText = sql;
                            var parameter = command.CreateParameter();
                            parameter.ParameterName = "userId";
                            parameter.Value = user.Id;
                            command.Parameters.Add(parameter);
                            
                            if (command.Connection.State != System.Data.ConnectionState.Open)
                                await command.Connection.OpenAsync();
                            
                            using (var reader = await command.ExecuteReaderAsync())
                            {
                                if (await reader.ReadAsync())
                                {
                                    branchInfo = new
                                    {
                                        Name = reader["name"].ToString(),
                                        Address = reader["address"].ToString(),
                                        Phone = reader["phone"].ToString(),
                                        Email = reader["email"].ToString()
                                    };
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log the error but continue processing users
                        Console.WriteLine($"Error fetching branch for user {user.Id}: {ex.Message}");
                    }
                    
                    // Add the user with branch info to our result list
                    formattedUsers.Add(new
                    {
                        user.Id,
                        user.Username,
                        user.Email,
                        user.CreatedAt,
                        Role = new
                        {
                            user.Role.Id,
                            user.Role.Name,
                            user.Role.Description
                        },
                        Branch = branchInfo
                    });
                }

                return Ok(formattedUsers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/Users/{id}
        [HttpGet("{id}")]
        [AllowAnonymous] // For testing; consider adding authorization in production
        public async Task<ActionResult<dynamic>> GetUser(int id)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(id);

                if (user == null)
                {
                    return NotFound($"User with ID {id} not found");
                }

                // Try to get branch information
                var branchInfo = new
                {
                    Name = "Unknown", // Default value
                    Address = "",
                    Phone = "",
                    Email = ""
                };
                
                try
                {
                    // Use raw SQL to query for branch info
                    var sql = @"
                        SELECT b.name, b.address, b.phone, b.email 
                        FROM ""UserBranches"" ub 
                        JOIN ""Branches"" b ON ub.branch_id = b.id 
                        WHERE ub.user_id = @userId";
                    
                    using (var command = _context.Database.GetDbConnection().CreateCommand())
                    {
                        command.CommandText = sql;
                        var parameter = command.CreateParameter();
                        parameter.ParameterName = "userId";
                        parameter.Value = user.Id;
                        command.Parameters.Add(parameter);
                        
                        if (command.Connection.State != System.Data.ConnectionState.Open)
                            await command.Connection.OpenAsync();
                        
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                branchInfo = new
                                {
                                    Name = reader["name"].ToString(),
                                    Address = reader["address"].ToString(),
                                    Phone = reader["phone"].ToString(),
                                    Email = reader["email"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log the error but continue
                    Console.WriteLine($"Error fetching branch for user {user.Id}: {ex.Message}");
                }

                var formattedUser = new
                {
                    user.Id,
                    user.Username,
                    user.Email,
                    user.CreatedAt,
                    Role = new
                    {
                        user.Role.Id,
                        user.Role.Name,
                        user.Role.Description
                    },
                    Branch = branchInfo
                };

                return Ok(formattedUser);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/Users/byRole/{roleName}
        [HttpGet("byRole/{roleName}")]
        [AllowAnonymous] // For testing; consider adding authorization in production
        public async Task<ActionResult<IEnumerable<dynamic>>> GetUsersByRole(string roleName)
        {
            try
            {
                // Get all users
                var users = await _userService.GetUsersAsync();
                
                // Filter by role name
                var filteredUsers = users.Where(u => u.Role.Name.Equals(roleName, StringComparison.OrdinalIgnoreCase)).ToList();
                
                // Format the response
                var formattedUsers = new List<dynamic>();
                
                foreach (var user in filteredUsers)
                {
                    // Try to get branch information
                    var branchInfo = new
                    {
                        Name = "Unknown", // Default value
                        Address = "",
                        Phone = "",
                        Email = ""
                    };
                    
                    try
                    {
                        // Use raw SQL to query for branch info
                        var sql = @"
                            SELECT b.name, b.address, b.phone, b.email 
                            FROM ""UserBranches"" ub 
                            JOIN ""Branches"" b ON ub.branch_id = b.id 
                            WHERE ub.user_id = @userId";
                        
                        using (var command = _context.Database.GetDbConnection().CreateCommand())
                        {
                            command.CommandText = sql;
                            var parameter = command.CreateParameter();
                            parameter.ParameterName = "userId";
                            parameter.Value = user.Id;
                            command.Parameters.Add(parameter);
                            
                            if (command.Connection.State != System.Data.ConnectionState.Open)
                                await command.Connection.OpenAsync();
                            
                            using (var reader = await command.ExecuteReaderAsync())
                            {
                                if (await reader.ReadAsync())
                                {
                                    branchInfo = new
                                    {
                                        Name = reader["name"].ToString(),
                                        Address = reader["address"].ToString(),
                                        Phone = reader["phone"].ToString(),
                                        Email = reader["email"].ToString()
                                    };
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log the error but continue
                        Console.WriteLine($"Error fetching branch for user {user.Id}: {ex.Message}");
                    }
                    
                    // Add the user with branch info to our result list
                    formattedUsers.Add(new
                    {
                        user.Id,
                        user.Username,
                        user.Email,
                        user.CreatedAt,
                        Role = new
                        {
                            user.Role.Id,
                            user.Role.Name,
                            user.Role.Description
                        },
                        Branch = branchInfo
                    });
                }

                return Ok(formattedUsers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/Users/byBranch/{branchName}
        [HttpGet("byBranch/{branchName}")]
        [AllowAnonymous] // For testing; consider adding authorization in production
        public async Task<ActionResult<IEnumerable<dynamic>>> GetUsersByBranch(string branchName)
        {
            try
            {
                Console.WriteLine($"Searching for users in branch: {branchName}");
                
                // Get all users with their roles
                var users = await _userService.GetUsersAsync();
                var formattedUsers = new List<dynamic>();
                
                // Process each user
                foreach (var user in users)
                {
                    // Try to get branch information for this user
                    var branchInfo = new
                    {
                        Name = "Unknown", // Default value
                        Address = "",
                        Phone = "",
                        Email = ""
                    };
                    
                    try
                    {
                        // Use raw SQL to get the branch info
                        var sql = @"
                            SELECT b.name, b.address, b.phone, b.email 
                            FROM ""UserBranches"" ub 
                            JOIN ""Branches"" b ON ub.branch_id = b.id 
                            WHERE ub.user_id = @userId";
                        
                        using (var command = _context.Database.GetDbConnection().CreateCommand())
                        {
                            command.CommandText = sql;
                            var parameter = command.CreateParameter();
                            parameter.ParameterName = "userId";
                            parameter.Value = user.Id;
                            command.Parameters.Add(parameter);
                            
                            if (command.Connection.State != System.Data.ConnectionState.Open)
                                await command.Connection.OpenAsync();
                            
                            using (var reader = await command.ExecuteReaderAsync())
                            {
                                if (await reader.ReadAsync())
                                {
                                    string branchNameFromDb = reader["name"].ToString();
                                    
                                    // Check if this branch matches the search criteria
                                    if (branchNameFromDb.Contains(branchName, StringComparison.OrdinalIgnoreCase))
                                    {
                                        Console.WriteLine($"Found user {user.Username} in branch: {branchNameFromDb}");
                                        
                                        branchInfo = new
                                        {
                                            Name = branchNameFromDb,
                                            Address = reader["address"].ToString(),
                                            Phone = reader["phone"].ToString(),
                                            Email = reader["email"].ToString()
                                        };
                                        
                                        // Add this user to the results
                                        formattedUsers.Add(new
                                        {
                                            user.Id,
                                            user.Username,
                                            user.Email,
                                            user.CreatedAt,
                                            Role = new
                                            {
                                                user.Role.Id,
                                                user.Role.Name,
                                                user.Role.Description
                                            },
                                            Branch = branchInfo
                                        });
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log the error but continue
                        Console.WriteLine($"Error fetching branch for user {user.Id}: {ex.Message}");
                    }
                }
                
                // Return result
                if (!formattedUsers.Any())
                {
                    return NotFound($"No users found in branch '{branchName}'");
                }
                
                return Ok(formattedUsers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/Users/branch-test
        [HttpGet("branch-test")]
        [AllowAnonymous]
        public async Task<ActionResult<string>> TestBranches()
        {
            try
            {
                // Get all branches for testing
                var branches = new List<string>();
                
                try
                {
                    // Use raw SQL to get all branches
                    var sql = @"SELECT ""Name"" FROM ""Branches""";
                    
                    using (var command = _context.Database.GetDbConnection().CreateCommand())
                    {
                        command.CommandText = sql;
                        
                        if (command.Connection.State != System.Data.ConnectionState.Open)
                            await command.Connection.OpenAsync();
                        
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                string branchName = reader["Name"].ToString();
                                branches.Add(branchName);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    return $"Error fetching branches: {ex.Message}";
                }
                
                return Ok($"Found {branches.Count} branches: {string.Join(", ", branches)}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
} 