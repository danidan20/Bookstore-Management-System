using BookHaven_Bookstore_Management_System.Repository.Implmentation;
using BookHaven_Bookstore_Management_System.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BookHaven_Bookstore_Management_System.View;
using BookHaven_Bookstore_Management_System.Utils;
using BookHaven_Bookstore_Management_System.Services.impl;
using BookHaven_Bookstore_Management_System.Services.interfaces;
using BookHaven_Bookstore_Management_System.View.Staff;

namespace BookHaven_Bookstore_Management_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    var configuration = context.Configuration;

                    services.AddDbContext<BookHavenDbContext>(options =>
                        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

                    // Service Dependency Injection
                    services.AddScoped<IAuthService, AuthService>();
                    services.AddScoped<ICustomerService, CustomerService>();
                    services.AddScoped<IBookService, BookService>();

                    // Repo service Dependency Injections
                    services.AddScoped<IUserRepository, UserRepositoryImpl>();
                    services.AddScoped<IAuthRepository, AuthRepository>();
                    services.AddScoped<ICustomerRepository, CustomerRepository>();
                    services.AddScoped<IBookRepository, BookRepository>();

                    // Form registrations
                    services.AddScoped<Login>();
                    services.AddScoped<StaffHome>();
                    services.AddScoped<StaffCustomers>();
                    services.AddScoped<StaffBook>();
                })
                .Build();

            var serviceProvider = host.Services;
            DatabaseSeeder.Seed(serviceProvider);
            Application.Run(serviceProvider.GetRequiredService<Login>());
        }
    }
}