using BookHaven_Bookstore_Management_System.Repository.Implmentation;
using BookHaven_Bookstore_Management_System.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BookHaven_Bookstore_Management_System.View;
using BookHaven_Bookstore_Management_System.Utils;

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

                    //Repo service Dependency Injections
                    services.AddScoped<IUserRepository, UserRepositoryImpl>();
                    services.AddScoped<IAuthRepository, AuthRepository>();
                    services.AddScoped<Login>();
                })
                .Build();

            var serviceProvider = host.Services;
            DatabaseSeeder.Seed(serviceProvider);
            // Run Login Form
            Application.Run(serviceProvider.GetRequiredService<Login>());
        }
    }
}