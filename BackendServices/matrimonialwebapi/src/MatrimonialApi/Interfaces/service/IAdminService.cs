using System.Threading.Tasks;
using MatrimonialApi.Models;
using System.Collections.Generic;

/// <summary>
/// Represents the interface for the admin service.
/// </summary>
public interface IAdminService
{
    /// <summary>
    /// Adds a new admin asynchronously.
    /// </summary>
    /// <param name="admin">The admin to add.</param>
    /// <returns>The created admin.</returns>
    Task<CreatedAdmin> AddAdminAsync(Admin admin);

    /// <summary>
    /// Gets all admins asynchronously.
    /// </summary>
    /// <returns>A collection of all admins.</returns>
    Task<IEnumerable<CreatedAdmin>> GetAllAdminsAsync();

    /// <summary>
    /// Gets an admin by ID asynchronously.
    /// </summary>
    /// <param name="adminId">The ID of the admin.</param>
    /// <returns>The admin with the specified ID.</returns>
    Task<CreatedAdmin> GetAdminByIdAsync(string adminId);

    /// <summary>
    /// Updates an admin asynchronously.
    /// </summary>
    /// <param name="adminId">The ID of the admin to update.</param>
    /// <param name="admin">The updated admin.</param>
    Task UpdateAdminAsync(string adminId, Admin admin);

    /// <summary>
    /// Deletes an admin asynchronously.
    /// </summary>
    /// <param name="adminId">The ID of the admin to delete.</param>
    Task DeleteAdminAsync(string adminId);
}
