using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
//using Amazon.Auth.AccessControlPolicy;
using MatrimonialApi.DBEntity;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace MatrimonialApi.Utilities
{
  /// <summary>
    /// Service for generating and managing JWT tokens.
    /// </summary>
    public class TokenService
    {
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenService"/> class.
        /// </summary>
        /// <param name="configuration">The configuration object.</param>
        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Generates a JWT token for the specified user.
        /// </summary>
        /// <param name="user">User Instance</param>
        /// <param name="userRole">The user role.</param>
        /// <returns>The generated JWT token.</returns>
        public string GenerateToken(User user, string userRole)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("role", userRole), // Add a new claim for user role
                    new Claim("email", user.Email)
                    //new Claim("department", "NeedToBeAdded")
                };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30), // Set the expiration time
                signingCredentials: credentials
                );
           
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}