﻿namespace SoldierTrack.Web.Common.Extensions
{
    using Data.Models;
    using Microsoft.AspNetCore.Identity;

    using static Common.Constants.WebConstants;

    public static class WebApp
    {
        public static async Task CreateAdminRoleAsync(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();

            var userManager = scope
                .ServiceProvider
                .GetRequiredService<UserManager<Athlete>>();

            var roleManager = scope
                .ServiceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();

            var roleAlreadyExists = await roleManager.RoleExistsAsync(AdminRoleName);

            if (userManager != null &&
                roleManager != null &&
               !roleAlreadyExists)
            {
                var role = new IdentityRole(AdminRoleName);
                await roleManager.CreateAsync(role);

                var admin = await userManager.FindByEmailAsync(AdminEmail);

                if (admin == null)
                {
                    admin = new Athlete()
                    {
                        FirstName = AdminRoleName,
                        LastName = AdminRoleName,
                        UserName = AdminEmail,
                        Email = AdminEmail
                    };

                    await userManager.CreateAsync(admin, AdminPassword);
                }

                if (role.Name != null)
                {
                    await userManager.AddToRoleAsync(admin, role.Name);
                }
            }
        }

        public static void MapDefaultAreaRoute(this IEndpointRouteBuilder endpoints)
        {
             endpoints.MapControllerRoute(
                  name: "Areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
        }
    }
}
