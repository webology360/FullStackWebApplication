using MatrimonialApi.DBEntity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Initializes the database with default data.
/// </summary>
public class DbInitializer
{
    /// <summary>
    /// Initializes the database with default data.
    /// </summary>
    /// <param name="serviceProvider">The service provider.</param>
    /// <param name="userManager">The user manager.</param>
    public static async Task Initialize(IServiceProvider serviceProvider, UserManager<User> userManager)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<Role>>();

        string[] roleNames = { "Admin", "SuperAdmin", "MidAdmin"};
        IdentityResult roleResult;

        foreach (var roleName in roleNames)
        {
            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                roleResult = await roleManager.CreateAsync(new Role { Name = roleName });
            }
        }

        var adminUser = new User
        {
            UserName = "admin@webology360.com",
            Email = "admin@webology360.com",
            FirstName = "Admin",
            LastName = "Admin",
            IsActive = true,
            IsSuperAdmin = true,
            CreatedDateTime = DateTime.UtcNow,
            AccountLocked = false,
        };

        string adminPassword = "Welcome@123";
        var user = await userManager.FindByEmailAsync("admin@webology360.com");

        if (user == null)
        {
            var createAdminUser = await userManager.CreateAsync(adminUser, adminPassword);
            if (createAdminUser.Succeeded)
            {
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }
    }
}
