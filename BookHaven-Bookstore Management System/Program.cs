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
using BookHaven_Bookstore_Management_System.View.Admin;
using BookHaven_Bookstore_Management_System.View.StoreAdmin;
using BookHaven_Bookstore_Management_System.View.CommonModules;

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
                    services.AddScoped<IOrderService, OrderService>();
                    services.AddScoped<IOrderItemService, OrderItemService>();
                    services.AddScoped<ISupplierService, SupplierService>();
                    services.AddScoped<ISupplierOrderService, SupplierOrderService>();
                    services.AddScoped<ISupplierOrderItemService, SupplierOrderItemService>();

                    // Repo service Dependency Injections
                    services.AddScoped<IUserRepository, UserRepositoryImpl>();
                    services.AddScoped<IAuthRepository, AuthRepository>();
                    services.AddScoped<ICustomerRepository, CustomerRepository>();
                    services.AddScoped<IBookRepository, BookRepository>();
                    services.AddScoped<IOrderItemRepository, OrderItemRepository>();
                    services.AddScoped<IOrderRepository, OrderRepository>();
                    services.AddScoped<ISupplierRepository, SupplierRepository>();
                    services.AddScoped<ISupplierOrderRepository, SupplierOrderRepository>();
                    services.AddScoped<ISupplierOrderItemRepository, SupplierOrderItemRepository>();

                    // Form registrations
                    services.AddTransient<CommonModuleCustomers>();
                    services.AddTransient<StaffHome>();
                    services.AddTransient<CommonModuleBook>();
                    services.AddTransient<Pos>();
                    services.AddTransient<StaffOrders>();

                    services.AddTransient<AdminHome>();
                    services.AddTransient<AdminOrders>();
                    services.AddTransient<AdminOrderUpdateForm>();
                    services.AddTransient< SupplierManagementForm > ();
                    services.AddTransient<SupplierOrdersViewForm>();
                    services.AddTransient<UpdateOrderDetailsForm>();

                    services.AddTransient<StoreAdminHome>();
                    services.AddTransient<Login>();
                })
                .Build();

            var serviceProvider = host.Services;
            DatabaseSeeder.Seed(serviceProvider);
            Application.Run(serviceProvider.GetRequiredService<Login>());
        }
    }
}