using MatrimonialApi.DBEntity;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MatrimonialApi.Interface
{
    /// <summary>
    /// User Repository Interface
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Adds a new User asynchronously.
        /// </summary>
        /// <param name="User">The User to add.</param>
        /// <returns>The added User.</returns>
        Task<User> AddUserAsync(User User);

        /// <summary>
        /// Retrieves all Users asynchronously.
        /// </summary>
        /// <returns>A collection of all Users.</returns>
        Task<IEnumerable<User>> GetAllUsersAsync();

        /// <summary>
        /// Retrieves an User by ID asynchronously.
        /// </summary>
        /// <param name="UserId">The ID of the User to retrieve.</param>
        /// <returns>The retrieved User.</returns>
        Task<User> GetUserByIdAsync(string UserId);

        /// <summary>
        /// Updates an User asynchronously.
        /// </summary>
        /// <param name="UserId">The ID of the User to update.</param>
        /// <param name="User">The updated User.</param>
        Task UpdateUserAsync(string UserId, User User);

        /// <summary>
        /// Deletes an User asynchronously.
        /// </summary>
        /// <param name="UserId">The ID of the User to delete.</param>
        Task DeleteUserAsync(string UserId);
    }
}