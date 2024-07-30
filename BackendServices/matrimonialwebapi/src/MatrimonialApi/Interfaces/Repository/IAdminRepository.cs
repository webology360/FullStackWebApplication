using MatrimonialApi.DBEntity;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MatrimonialApi.Interface
{
    /// <summary>
    /// Admin Repository Interface
    /// </summary>
    public interface IAdminRepository
    {
        /// <summary>
        /// Adds a new admin asynchronously.
        /// </summary>
        /// <param name="admin">The admin to add.</param>
        /// <returns>The added admin.</returns>
        Task<CreateAdmin> AddAdminAsync(CreateAdmin admin);

        /// <summary>
        /// Retrieves all admins asynchronously.
        /// </summary>
        /// <returns>A collection of all admins.</returns>
        Task<IEnumerable<CreateAdmin>> GetAllAdminsAsync();

        /// <summary>
        /// Retrieves an admin by ID asynchronously.
        /// </summary>
        /// <param name="adminId">The ID of the admin to retrieve.</param>
        /// <returns>The retrieved admin.</returns>
        Task<CreateAdmin> GetAdminByIdAsync(string adminId);

        /// <summary>
        /// Updates an admin asynchronously.
        /// </summary>
        /// <param name="adminId">The ID of the admin to update.</param>
        /// <param name="admin">The updated admin.</param>
        Task UpdateAdminAsync(string adminId, CreateAdmin admin);

        /// <summary>
        /// Deletes an admin asynchronously.
        /// </summary>
        /// <param name="adminId">The ID of the admin to delete.</param>
        Task DeleteAdminAsync(string adminId);
    }
}