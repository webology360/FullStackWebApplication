﻿using System.Threading.Tasks;
using MatrimonialApi.Models;
using System.Collections.Generic;


namespace MatrimonialApi.Interface
{
    /// <summary>
    /// Represents the interface for the User service.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Adds a new User asynchronously.
        /// </summary>
        /// <param name="User">The User to add.</param>
        /// <returns>The created User.</returns>
        Task<UserDTO> AddUserAsync(UserDTO User);

        /// <summary>
        /// Gets all Users asynchronously.
        /// </summary>
        /// <returns>A collection of all Users.</returns>
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();

        /// <summary>
        /// Gets an User by ID asynchronously.
        /// </summary>
        /// <param name="UserId">The ID of the User.</param>
        /// <returns>The User with the specified ID.</returns>
        Task<UserDTO> GetUserByIdAsync(string UserId);

        /// <summary>
        /// Updates an User asynchronously.
        /// </summary>
        /// <param name="UserId">The ID of the User to update.</param>
        /// <param name="User">The updated User.</param>
        Task UpdateUserAsync(string UserId, UserDTO User);

        /// <summary>
        /// Deletes an User asynchronously.
        /// </summary>
        /// <param name="UserId">The ID of the User to delete.</param>
        Task DeleteUserAsync(string UserId);
    }
}