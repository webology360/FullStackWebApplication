using MatrimonialApi.DBEntity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

public class DbInitializer
{
    public static async Task Initialize(IServiceProvider serviceProvider, UserManager<User> userManager)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<Role>>();

        string[] roleNames = { "Admin", "SuperAdmin", "MidAdmin", "User" };
        IdentityResult roleResult;

        foreach (var roleName in roleNames)
        {
            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                roleResult = await roleManager.CreateAsync(new Role { Name = roleName});
            }
        }

        var adminUser = new User
        {
            UserName = "admin@webology360.com",
            Email = "admin@webology360.com"
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
