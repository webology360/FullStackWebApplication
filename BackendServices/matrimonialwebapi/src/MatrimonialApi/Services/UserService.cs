using AutoMapper;
using MatrimonialApi.Interface;
using MatrimonialApi.Models;
using MatrimonialApi.DBEntity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MatrimonialApi.Utilities;
using Microsoft.Extensions.Configuration;
using MatrimonialApi.Enum;
using System.Net.Http;
using System.Net;

/// <summary>
/// Service for managing Users.
/// </summary>
public class UserService : IUserService
{
    //private readonly IUserRepository _UserRepository; // Assuming an User repository interface
    private readonly IPasswordHasher<User> _passwordHasher;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserService"/> class.
    /// </summary>
    /// <param name="userManager">The User repository.</param>
    /// <param name="mapper">The mapper.</param>
    /// <param name="passwordHasher">The password hasher.</param>
    /// <param name="configuration">The configuration.</param>
    public UserService(UserManager<User> userManager, IMapper mapper, IPasswordHasher<User> passwordHasher, IConfiguration configuration)
    {
        _mapper = mapper;
        _userManager = userManager;
        _passwordHasher = passwordHasher;
        _configuration = configuration;
    }

    /// <summary>
    /// Adds an User asynchronously.
    /// </summary>
    /// <param name="user">The User to add.</param>
    /// <returns>The added User.</returns>
    public async Task<IdentityResult> AddUserAsync(UserDTO user)
    {
        try
        {
            if(!Enum.TryParse(typeof(UserRole), user.Role.ToLower(), out var role))
            {
                var errorMessage = "Invalid role";
                var statusCode = HttpStatusCode.BadRequest;
                throw new HttpRequestException(errorMessage, null,statusCode);
            }
            //user.Role.ToLower()==
            var userEntity = _mapper.Map<User>(user);
            userEntity.UserName= user.EmailId;
            userEntity.Email = user.EmailId;
            //userEntity.Role = user.Role;
            var password =_passwordHasher.HashPassword(userEntity,_configuration["DefaultUserPassword"]);
            var addedUser = await _userManager.CreateAsync(userEntity, password);
            if(addedUser.Succeeded)
            {
                await _userManager.AddToRoleAsync(userEntity, user.Role);
            }
            
            //var UserDto = _mapper.Map<UserDTO>(addedUser);
            return addedUser;
        }
        catch (Exception )
        {
                throw ;
        }

    }

    /// <summary>
    /// Retrieves all Users asynchronously.
    /// </summary>
    /// <returns>A collection of all Users.</returns>
    public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
    {
        // Implement the logic to retrieve all Users
        //var users = await _userManager.get;
        //var userDTOs = _mapper.Map<IEnumerable<UserDTO>>(users);
        //return userDTOs;
        throw new NotImplementedException();
    }

    /// <summary>
    /// Retrieves a specific User by ID asynchronously.
    /// </summary>
    /// <param name="UserId">The ID of the User to retrieve.</param>
    /// <returns>The User with the specified ID.</returns>
    public async Task<UserDTO> GetUserByIdAsync(string UserId)
    {
        // Implement the logic to retrieve a specific User by ID
        throw new NotImplementedException();
    }

    /// <summary>
    /// Updates an User asynchronously.
    /// </summary>
    /// <param name="UserId">The ID of the User to update.</param>
    /// <param name="User">The updated User.</param>
    public async Task<UserDTO> UpdateUserAsync(string UserId, UserDTO User)
    {
        // Implement the logic to update an User
        throw new NotImplementedException();
    }

    /// <summary>
    /// Deletes an User asynchronously.
    /// </summary>
    /// <param name="UserId">The ID of the User to delete.</param>
    public async Task DeleteUserAsync(string UserId)
    {
        // Implement the logic to delete an User
        throw new NotImplementedException();
    }
}
