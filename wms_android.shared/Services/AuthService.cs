using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using wms_android.shared.Interfaces;
using wms_android.shared.Models.Auth;

namespace wms_android.shared.Services
{
    public class AuthService : IAuthService
    {
        private readonly JwtConfig _jwtConfig;
        private readonly IUserService _userService;

        public AuthService(IOptions<JwtConfig> jwtConfig, IUserService userService)
        {
            _jwtConfig = jwtConfig.Value;
            _userService = userService;
        }

        public async Task<string> GenerateJwtTokenAsync(string username, string password)
        {
            if (!await ValidateCredentialsAsync(username, password))
            {
                throw new InvalidOperationException("Invalid credentials");
            }

            var user = await _userService.GetUserByUsernameAsync(username);
            if (user == null)
            {
                throw new InvalidOperationException("User not found");
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role?.Name ?? "User")
            };

            var secretBytes = Encoding.UTF8.GetBytes(_jwtConfig.Secret ?? string.Empty);
            var key = new SymmetricSecurityKey(secretBytes);
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwtConfig.Issuer,
                audience: _jwtConfig.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddDays(_jwtConfig.ExpiryInDays),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> ValidateTokenAsync(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var secretBytes = Encoding.UTF8.GetBytes(_jwtConfig.Secret ?? string.Empty);
                var key = new SymmetricSecurityKey(secretBytes);

                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = key,
                    ValidateIssuer = true,
                    ValidIssuer = _jwtConfig.Issuer,
                    ValidateAudience = true,
                    ValidAudience = _jwtConfig.Audience,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> ValidateCredentialsAsync(string username, string password)
        {
            var user = await _userService.GetUserByUsernameAsync(username);
            if (user == null)
            {
                return false;
            }

            // In a real application, you would hash the password and compare hashes
            // For now, we'll do a simple comparison
            return user.Password == password;
        }
    }
}