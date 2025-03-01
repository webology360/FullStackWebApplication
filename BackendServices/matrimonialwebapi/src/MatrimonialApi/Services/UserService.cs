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
using System.Security.Claims;
using System.Linq;
using FluentValidation;

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
    private readonly IValidator<UserDTO> _validator;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserService"/> class.
    /// </summary>
    /// <param name="userManager">The User repository.</param>
    /// <param name="mapper">The mapper.</param>
    /// <param name="passwordHasher">The password hasher.</param>
    /// <param name="configuration">The configuration.</param>
    public UserService(UserManager<User> userManager, IMapper mapper, IPasswordHasher<User> passwordHasher, IConfiguration configuration, IValidator<UserDTO> validator)
    {
        _mapper = mapper;
        _userManager = userManager;
        _passwordHasher = passwordHasher;
        _configuration = configuration;
        _validator = validator;
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
            var validationResult = await _validator.ValidateAsync(user);
            if (!validationResult.IsValid)
            {
                var errors = string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage));
                throw new HttpRequestException(errors, null, HttpStatusCode.BadRequest);
            }

            if (!Enum.TryParse(typeof(UserRole), user.Role.ToLower(), out var role))
            {
                var errorMessage = "Invalid role";
                var statusCode = HttpStatusCode.BadRequest;
                throw new HttpRequestException(errorMessage, null,statusCode);
            }
            //user.Role.ToLower()==
            var userEntity = _mapper.Map<User>(user);
            userEntity.UserName= user.Email;
            userEntity.Email = user.Email;
            //userEntity.Role = user.Role;
            //var password =_passwordHasher.HashPassword(userEntity,_configuration["DefaultUserPassword"]);
            var password=_configuration["DefaultUserPassword"];
            var addedUser = await _userManager.CreateAsync(userEntity, password);
            if(addedUser.Succeeded)
            {
                //For storing role it can be stored in in seperate role value or with claims, both serve different purposes
                // For role based authorization use role value, for role based access control use claims (there could be multiple claims for a user)
                // There can me multiple use cases where we can use role value or claims
                    await _userManager.AddToRoleAsync(userEntity, user.Role);
                await _userManager.AddClaimAsync(userEntity, new System.Security.Claims.Claim("role", user.Role));
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
    public async Task<IList<UserDTO>> GetAllUsersAsync(string role)
    {
            Claim claim = new Claim("role", role.ToLower());
            var users = await _userManager.GetUsersForClaimAsync(claim);

            var UserDTOs = _mapper.Map<IList<UserDTO>>(users);
            foreach (var user in users)
            {
                var userDTO = UserDTOs.FirstOrDefault(u => u.Id == user.Id.ToString());
                if (userDTO != null)
                {
                    var claims = await _userManager.GetClaimsAsync(user);
                    var roleClaim = claims.FirstOrDefault(c => c.Type == "role");
                    if (roleClaim != null)
                    {
                        userDTO.Role = roleClaim.Value;
                    }
                }
            }
        return UserDTOs;
        
    }

    /// <summary>
    /// Retrieves a specific User by ID asynchronously.
    /// </summary>
    /// <param name="UserId">The ID of the User to retrieve.</param>
    /// <returns>The User with the specified ID.</returns>
    public async Task<UserDTO> GetUserByIdAsync(string UserId)
    {
        // Implement the logic to retrieve a specific User by ID
       var user=await _userManager.FindByIdAsync(UserId);
       var userDTO = _mapper.Map<UserDTO>(user);
       userDTO.Role = user.Claims.Find(x => x.ClaimType == "role").ClaimValue;
       return userDTO;
    }


    /// <summary>
    /// Updates a specific User asynchronously.
    /// </summary>
    /// <param name="UserId">The ID of the User to update.</param>
    /// <param name="User">The updated User information.</param>
    /// <returns>The updated User.</returns>

    public async Task<UserDTO> UpdateUserAsync(string UserId, UserDTO User)
    {
        var userEntity = await _userManager.FindByIdAsync(UserId);
        if (userEntity == null)
        {
            // User not found, handle the error
            throw new Exception("User not found");
        }

        // Update the user entity with the values from UserDTO
       var updatedUser=_mapper.Map(User, userEntity);

        // Save the changes to the database
        var result = await _userManager.UpdateAsync(updatedUser);
        if (!result.Succeeded)
        {
            // Failed to update the user, handle the error
            throw new Exception("Failed to update user");
        }

        // Map the updated user entity back to UserDTO
        var updatedUserDTO = _mapper.Map<UserDTO>(userEntity);

        return updatedUserDTO;
    }

    /// <summary>
    /// Deletes an User asynchronously.
    /// </summary>
    /// <param name="UserId">The ID of the User to delete.</param>
    public async Task<IdentityResult> DeleteUserAsync(string UserId)
    {
       return await _userManager.DeleteAsync(await _userManager.FindByIdAsync(UserId));
    }
}
