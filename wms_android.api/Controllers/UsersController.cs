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
                // Get all users with their roles and branches using the direct relationship
                var users = await _context.Users
                    .Include(u => u.Role)
                    .Include(u => u.Branch)
                    .ToListAsync();
                
                // Format the response with branch information
                var formattedUsers = users.Select(user => new
                {
                    user.Id,
                    user.Username,
                    user.Email,
                    user.FirstName,
                    user.LastName,
                    user.CreatedAt,
                    Role = new
                    {
                        user.Role.Id,
                        user.Role.Name,
                        user.Role.Description
                    },
                    Branch = user.Branch != null ? new
                    {
                        Id = (int?)user.Branch.Id,
                        Name = user.Branch.Name,
                        Address = user.Branch.Address,
                        Phone = user.Branch.Phone,
                        Email = user.Branch.Email
                    } : new
                    {
                        Id = (int?)null,
                        Name = (string?)null,
                        Address = (string?)null,
                        Phone = (string?)null,
                        Email = (string?)null
                    }
                }).ToList();

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
                // Get user with role and branch using direct relationship
                var user = await _context.Users
                    .Include(u => u.Role)
                    .Include(u => u.Branch)
                    .FirstOrDefaultAsync(u => u.Id == id);

                if (user == null)
                {
                    return NotFound($"User with ID {id} not found");
                }

                // Format the response
                var userResponse = new
                {
                    user.Id,
                    user.Username,
                    user.Email,
                    user.FirstName,
                    user.LastName,
                    user.CreatedAt,
                    Role = new
                    {
                        user.Role.Id,
                        user.Role.Name,
                        user.Role.Description
                    },
                    Branch = user.Branch != null ? new
                    {
                        Id = (int?)user.Branch.Id,
                        Name = user.Branch.Name,
                        Address = user.Branch.Address,
                        Phone = user.Branch.Phone,
                        Email = user.Branch.Email
                    } : new
                    {
                        Id = (int?)null,
                        Name = (string?)null,
                        Address = (string?)null,
                        Phone = (string?)null,
                        Email = (string?)null
                    }
                };

                return Ok(userResponse);
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
                // Get users by role with their branches using direct relationship
                var users = await _context.Users
                    .Include(u => u.Role)
                    .Include(u => u.Branch)
                    .Where(u => u.Role.Name.Equals(roleName, StringComparison.OrdinalIgnoreCase))
                    .ToListAsync();
                
                // Format the response
                var formattedUsers = users.Select(user => new
                {
                    user.Id,
                    user.Username,
                    user.Email,
                    user.FirstName,
                    user.LastName,
                    user.CreatedAt,
                    Role = new
                    {
                        user.Role.Id,
                        user.Role.Name,
                        user.Role.Description
                    },
                    Branch = user.Branch != null ? new
                    {
                        Id = (int?)user.Branch.Id,
                        Name = user.Branch.Name,
                        Address = user.Branch.Address,
                        Phone = user.Branch.Phone,
                        Email = user.Branch.Email
                    } : new
                    {
                        Id = (int?)null,
                        Name = "Unknown",
                        Address = "",
                        Phone = "",
                        Email = ""
                    }
                }).ToList();

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
                
                // Get users by branch using direct relationship
                var users = await _context.Users
                    .Include(u => u.Role)
                    .Include(u => u.Branch)
                    .Where(u => u.Branch != null && u.Branch.Name.Contains(branchName, StringComparison.OrdinalIgnoreCase))
                    .ToListAsync();
                
                if (!users.Any())
                {
                    return NotFound($"No users found in branch '{branchName}'");
                }
                
                // Format the response
                var formattedUsers = users.Select(user => new
                {
                    user.Id,
                    user.Username,
                    user.Email,
                    user.FirstName,
                    user.LastName,
                    user.CreatedAt,
                    Role = new
                    {
                        user.Role.Id,
                        user.Role.Name,
                        user.Role.Description
                    },
                    Branch = new
                    {
                        Id = (int?)user.Branch.Id,
                        Name = user.Branch.Name,
                        Address = user.Branch.Address,
                        Phone = user.Branch.Phone,
                        Email = user.Branch.Email
                    }
                }).ToList();
                
                Console.WriteLine($"Found {formattedUsers.Count} users in branch: {branchName}");
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
                // Get all branches using EF Core
                var branches = await _context.Branches
                    .Select(b => b.Name)
                    .ToListAsync();
                
                return Ok($"Found {branches.Count} branches: {string.Join(", ", branches)}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST: api/Users
        [HttpPost]
        [AllowAnonymous] // Only admins can create users
        public async Task<ActionResult<User>> CreateUser([FromBody] UserCreateDto userDto)
        {
            if (userDto == null)
            {
                return BadRequest("User data is required.");
            }

            try
            {
                CreatePasswordHash(userDto.Password, out byte[] passwordHash, out byte[] passwordSalt);

                var user = new User
                {
                    Username = userDto.Username,
                    Email = userDto.Email,
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    RoleId = userDto.RoleId,
                    BranchId = userDto.BranchId > 0 ? userDto.BranchId : (int?)null, // Assign branch directly
                    CreatedAt = DateTime.UtcNow
                };

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // PUT: api/Users/{id}
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")] // Only admins can update users
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UserUpdateDto userDto)
        {
            try
            {
                if (id != userDto.Id)
                {
                    return BadRequest("ID mismatch");
                }

                var existingUser = await _userService.GetUserByIdAsync(id);
                if (existingUser == null)
                {
                    return NotFound($"User with ID {id} not found");
                }

                // Update user properties
                existingUser.Username = userDto.Username;
                existingUser.Email = userDto.Email;
                existingUser.FirstName = userDto.FirstName;
                existingUser.LastName = userDto.LastName;
                existingUser.RoleId = userDto.RoleId;
                existingUser.BranchId = userDto.BranchId > 0 ? userDto.BranchId : (int?)null; // Update branch assignment

                // If password is provided, update it
                if (!string.IsNullOrEmpty(userDto.Password))
                {
                    byte[] passwordHash, passwordSalt;
                    CreatePasswordHash(userDto.Password, out passwordHash, out passwordSalt);
                    existingUser.PasswordHash = passwordHash;
                    existingUser.PasswordSalt = passwordSalt;
                }

                await _userService.UpdateUserAsync(existingUser);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // PUT: api/Users/{id}/change-password
        [HttpPut("{id}/change-password")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ChangePassword(int id, [FromBody] ChangePasswordDto passwordDto)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(id);
                if (user == null)
                {
                    return NotFound($"User with ID {id} not found");
                }

                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(passwordDto.NewPassword, out passwordHash, out passwordSalt);
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;

                await _userService.UpdateUserAsync(user);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // DELETE: api/Users/{id}
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(id);
                if (user == null)
                {
                    return NotFound($"User with ID {id} not found");
                }

                // Prevent deleting the current user
                var currentUserId = User.FindFirst("userId")?.Value;
                if (currentUserId != null && int.Parse(currentUserId) == id)
                {
                    return BadRequest("Cannot delete your own account");
                }

                await _userService.DeleteUserAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // PUT: api/Users/{id}/activate
        [HttpPut("{id}/activate")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ActivateUser(int id)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(id);
                if (user == null)
                {
                    return NotFound($"User with ID {id} not found");
                }

                // Add IsActive property if it doesn't exist in the User model
                // This is a placeholder - you might need to add this property to your User model
                // user.IsActive = true;
                
                await _userService.UpdateUserAsync(user);
                return Ok(new { message = "User activated successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // PUT: api/Users/{id}/deactivate
        [HttpPut("{id}/deactivate")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeactivateUser(int id)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(id);
                if (user == null)
                {
                    return NotFound($"User with ID {id} not found");
                }

                // Prevent deactivating the current user
                var currentUserId = User.FindFirst("userId")?.Value;
                if (currentUserId != null && int.Parse(currentUserId) == id)
                {
                    return BadRequest("Cannot deactivate your own account");
                }

                // Add IsActive property if it doesn't exist in the User model
                // This is a placeholder - you might need to add this property to your User model
                // user.IsActive = false;
                
                await _userService.UpdateUserAsync(user);
                return Ok(new { message = "User deactivated successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }

    public class UserCreateDto
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public int RoleId { get; set; }
        public int BranchId { get; set; }
    }

    public class UserUpdateDto
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public int RoleId { get; set; }
        public int BranchId { get; set; }
    }

    public class ChangePasswordDto
    {
        public string? NewPassword { get; set; }
    }
} 