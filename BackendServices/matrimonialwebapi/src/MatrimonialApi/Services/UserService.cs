using AutoMapper;
using MatrimonialApi.Interface;
using MatrimonialApi.Models;
using MatrimonialApi.DBEntity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MatrimonialApi.Utilities;

/// <summary>
/// Service for managing Users.
/// </summary>
public class UserService : IUserService
{
    private readonly IUserRepository _UserRepository; // Assuming an User repository interface
    private readonly IMapper _mapper;
    private readonly IPasswordHasher<User> _passwordHasher;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserService"/> class.
    /// </summary>
    /// <param name="UserRepository">The User repository.</param>
    /// <param name="mapper">The mapper.</param>
    /// <param name="passwordHasher">The password hasher.</param>
    public UserService(IUserRepository UserRepository, IMapper mapper, IPasswordHasher<User> passwordHasher)
    {
        _UserRepository = UserRepository;
        _mapper = mapper;
        _passwordHasher = passwordHasher;
    }

    /// <summary>
    /// Adds an User asynchronously.
    /// </summary>
    /// <param name="User">The User to add.</param>
    /// <returns>The added User.</returns>
    public async Task<UserDTO> AddUserAsync(UserDTO User)
    {
        // Implement the logic to add an User
        var UserEntity = _mapper.Map<User>(User);
        //var firstTimePassword = RandomStringGenerator.GenerateRandomString();
        //var firstTimePassword = "Welcome@123";
        //UserEntity.Password = _passwordHasher.HashPassword(UserEntity, firstTimePassword);
        var addedUser = await _UserRepository.AddUserAsync(UserEntity);
        var UserDto = _mapper.Map<UserDTO>(addedUser);
        return UserDto;

    }

    /// <summary>
    /// Retrieves all Users asynchronously.
    /// </summary>
    /// <returns>A collection of all Users.</returns>
    public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
    {
        // Implement the logic to retrieve all Users
        var users = await _UserRepository.GetAllUsersAsync();
        var userDTOs = _mapper.Map<IEnumerable<UserDTO>>(users);
        return userDTOs;
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
    public async Task UpdateUserAsync(string UserId, UserDTO User)
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
