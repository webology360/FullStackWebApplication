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
using Microsoft.AspNetCore.Identity;
using MatrimonialApi.DBEntity;
using System.Threading.Tasks;

namespace MatrimonialApi.Controllers
{
    /// <summary>
    /// Represents the API controller for user login.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LoginApi : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginApi"/> class.
        /// </summary>
        /// <param name="userManager">The user manager.</param>
        /// <param name="signInManager">The sign-in manager.</param>
        /// <param name="configuration">The configuration object.</param>
        public LoginApi(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        /// <summary>
        /// Logs in the user and generates a JWT token.
        /// </summary>
        /// <param name="login">The login model containing the user credentials.</param>
        /// <returns>The generated JWT token.</returns>
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO login)
        {
            var user = await _userManager.FindByNameAsync(login.Username);
            if (user == null)
            {
                return BadRequest("Invalid username or password.");
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, login.Password, lockoutOnFailure: false);
            if (!result.Succeeded)
            {
                return BadRequest("Invalid username or password.");
            }

            var tokenService = new TokenService(_configuration);
            var tokenString = tokenService.GenerateToken(user.UserName, UserRole.SuperAdmin.GetDisplayName().ToLower());
            return Ok(new { Token = tokenString });
        }
    }
}
