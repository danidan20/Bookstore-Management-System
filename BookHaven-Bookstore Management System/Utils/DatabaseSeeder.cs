using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookHaven_Bookstore_Management_System.Utils
{
    public class DatabaseSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<BookHavenDbContext>();

                context.Database.Migrate();

                SeedAdminStaffUsers(context);
            }
        }

        private static void SeedAdminStaffUsers(BookHavenDbContext context)
        {
            // Admin User
            if (!context.Users.Any(u => u.Username == "BH_Admin"))
            {
                var adminUser = new User
                {
                    Username = "BH_Admin",
                    PasswordHash = HashPassword.Hashing("admin"),
                    Role = Role.ADMIN,
                    RealName = "BookHaven Admin",
                    Email = "bh_admin@example.com"
                };
                context.Users.Add(adminUser);
            }

            // Staff User
            if (!context.Users.Any(u => u.Username == "BH_Staff"))
            {
                var staffUser = new User
                {
                    Username = "BH_Staff",
                    PasswordHash = HashPassword.Hashing("staff"), 
                    Role = Role.STAFF,
                    RealName = "BookHaven Staff",
                    Email = "bh_staff@example.com"
                };
                context.Users.Add(staffUser);
            }

            context.SaveChanges();
        }
    }
}
