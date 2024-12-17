//using MatrimonialApi.Interface;
//using MongoDB.Driver;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using MatrimonialApi.DBEntity;
//using System.Linq;
//using System;

//namespace MatrimonialApi.Repository
//{

    /// <summary>
    /// Represents the interface for the admin service.
    /// </summary>
    //public class AdminRepository : IAdminRepository
    //{
    //    private readonly IMongoCollection<CreateAdmin> _admins;


        /// <summary>
        /// Initializes a new instance of the <see cref="AdminRepository"/> class.
        /// </summary>
        /// <param name="database">The MongoDB database.</param>
        //public AdminRepository(IMongoDatabase database)
        //{
        //    _admins = database.GetCollection<CreateAdmin>("Admin");

        //}

        /// <summary>
        /// Adds a new admin asynchronously.
        /// </summary>
        /// <param name="createAdmin">The admin to add.</param>
        /// <returns>The created admin.</returns>
        //public async Task<CreateAdmin> AddAdminAsync(CreateAdmin createAdmin)
        //{
        //    await _admins.InsertOneAsync(createAdmin);
        //    return createAdmin;
        //}

        /// <summary>
        /// Gets all admins asynchronously.
        /// </summary>
        /// <returns>The list of created admins.</returns>
        //public async Task<IEnumerable<CreateAdmin>> GetAllAdminsAsync()
        //{
        //    var admins = await _admins.Find(_ => true).ToListAsync();
        //    var createdAdmins = admins.Select(admin => admin);
        //    return createdAdmins;
        //}

        /// <summary>
        /// Gets an admin by ID asynchronously.
        /// </summary>
        /// <param name="adminId">The ID of the admin.</param>
        /// <returns>The created admin.</returns>
        //public async Task<CreateAdmin> GetAdminByIdAsync(string adminId)
        //{
        //    var admin = await _admins.Find(a => a.Id == adminId).FirstOrDefaultAsync();
        //    return admin;
        //}

        /// <summary>
        /// Updates an admin asynchronously.
        /// </summary>
        /// <param name="adminId">The ID of the admin to update.</param>
        /// <param name="admin">The updated admin.</param>
        //public async Task UpdateAdminAsync(string adminId, CreateAdmin admin)
        //{
        //    await _admins.ReplaceOneAsync(a => a.Id == adminId, admin);
        //}

        /// <summary>
        /// Deletes an admin asynchronously.
        /// </summary>
        /// <param name="adminId">The ID of the admin to delete.</param>
        //public async Task DeleteAdminAsync(string adminId)
        //{
        //    await _admins.DeleteOneAsync(a => a.Id == adminId);
        //}
    //}

//}