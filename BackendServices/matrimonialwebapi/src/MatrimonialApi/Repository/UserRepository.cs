using MatrimonialApi.DBEntity;
using MatrimonialApi.Interface;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrimonialApi.Repository
{
    /// <summary>
    /// Represents a repository for managing users.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _users;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="database">The MongoDB database.</param>
        public UserRepository(IMongoDatabase database)
        {
            _users = database.GetCollection<User>("User");
        }

        /// <summary>
        /// Adds a new user asynchronously.
        /// </summary>
        /// <param name="user">The user to add.</param>
        /// <returns>The created user.</returns>
        public async Task<User> AddUserAsync(User user)
        {
            await _users.InsertOneAsync(user);
            return user;
        }

        /// <summary>
        /// Gets all users asynchronously.
        /// </summary>
        /// <returns>The list of created users.</returns>
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            var users = await _users.Find(_ => true).ToListAsync();
            return users;
        }

        /// <summary>
        /// Gets a user by ID asynchronously.
        /// </summary>
        /// <param name="UserName">The ID of the user.</param>
        /// <returns>The user with the specified ID.</returns>
        public async Task<User> GetUserByIdAsync(string UserName)
        {
            var user = await _users.Find(u => u.UserName == UserName).FirstOrDefaultAsync();
            return user;
        }

        /// <summary>
        /// Updates a user asynchronously.
        /// </summary>
        /// <param name="UserName">The ID of the user to update.</param>
        /// <param name="user">The updated user.</param>
        public async Task UpdateUserAsync(string UserName, User user)
        {
            await _users.ReplaceOneAsync(u => u.UserName == UserName, user);
        }

        /// <summary>
        /// Deletes a user asynchronously.
        /// </summary>
        /// <param name="UserName">The ID of the user to delete.</param>
        public async Task DeleteUserAsync(string UserName)
        {
            await _users.DeleteOneAsync(u => u.UserName == UserName);
        }
    }
}
