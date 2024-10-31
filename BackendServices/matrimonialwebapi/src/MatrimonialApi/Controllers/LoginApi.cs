using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text;
using System;
using MatrimonialApi.DTO;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;

namespace MatrimonialApi.Controllers
{
    /// <summary>
    /// Represents the API controller for user login.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LoginApi : ControllerBase
    {
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginApi"/> class.
        /// </summary>
        /// <param name="configuration">The configuration object.</param>
        public LoginApi(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Logs in the user and generates a JWT token.
        /// </summary>
        /// <param name="login">The login model containing the user credentials.</param>
        /// <returns>The generated JWT token.</returns>
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO login)
        {
            // Validate the user credentials (this is just a demo, so we'll skip this step)

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                            new Claim(ClaimTypes.Name, login.Username)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return Ok(new { Token = tokenString });
        }
    }
}
