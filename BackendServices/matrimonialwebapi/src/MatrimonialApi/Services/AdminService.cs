using AutoMapper;
using MatrimonialApi.Interface;
using MatrimonialApi.Models;
using MatrimonialApi.DBEntity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

/// <summary>
/// Service for managing admins.
/// </summary>
public class AdminService : IAdminService
{
    private readonly IAdminRepository _adminRepository; // Assuming an admin repository interface
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="AdminService"/> class.
    /// </summary>
    /// <param name="adminRepository">The admin repository.</param>
    /// <param name="mapper">The mapper.</param>
    public AdminService(IAdminRepository adminRepository, IMapper mapper)
    {
        _adminRepository = adminRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Adds an admin asynchronously.
    /// </summary>
    /// <param name="admin">The admin to add.</param>
    /// <returns>The added admin.</returns>
    public async Task<AdminDTO> AddAdminAsync(AdminDTO admin)
    {
        // Implement the logic to add an admin
        var adminEntity = _mapper.Map<CreateAdmin>(admin);
        var addedAdmin = await _adminRepository.AddAdminAsync(adminEntity);
        var adminDto=_mapper.Map<AdminDTO>(addedAdmin);
        return adminDto;

    }

    /// <summary>
    /// Retrieves all admins asynchronously.
    /// </summary>
    /// <returns>A collection of all admins.</returns>
    public async Task<IEnumerable<AdminDTO>> GetAllAdminsAsync()
    {
        // Implement the logic to retrieve all admins
        throw new NotImplementedException();
    }

    /// <summary>
    /// Retrieves a specific admin by ID asynchronously.
    /// </summary>
    /// <param name="adminId">The ID of the admin to retrieve.</param>
    /// <returns>The admin with the specified ID.</returns>
    public async Task<AdminDTO> GetAdminByIdAsync(string adminId)
    {
        // Implement the logic to retrieve a specific admin by ID
        throw new NotImplementedException();
    }

    /// <summary>
    /// Updates an admin asynchronously.
    /// </summary>
    /// <param name="adminId">The ID of the admin to update.</param>
    /// <param name="admin">The updated admin.</param>
    public async Task UpdateAdminAsync(string adminId, AdminDTO admin)
    {
        // Implement the logic to update an admin
        throw new NotImplementedException();
    }

    /// <summary>
    /// Deletes an admin asynchronously.
    /// </summary>
    /// <param name="adminId">The ID of the admin to delete.</param>
    public async Task DeleteAdminAsync(string adminId)
    {
        // Implement the logic to delete an admin
        throw new NotImplementedException();
    }
}
