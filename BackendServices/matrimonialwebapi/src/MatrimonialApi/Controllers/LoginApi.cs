using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text;
using System;
using MatrimonialApi.DTO;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using MatrimonialApi.Utilities;
using MatrimonialApi.Enum;
using Microsoft.OpenApi.Extensions;

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
            TokenService tokenService  = new TokenService(_configuration);
            var tokenString = tokenService.GenerateToken(login.Username, UserRole.SuperAdmin.GetDisplayName());
            return Ok(new { Token = tokenString });
        }
    }
}
