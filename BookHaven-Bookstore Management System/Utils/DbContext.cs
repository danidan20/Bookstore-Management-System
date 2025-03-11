using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookHaven_Bookstore_Management_System.Utils
{
    public class BookHavenDbContext : DbContext
    {
        public BookHavenDbContext(DbContextOptions<BookHavenDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierOrder> SupplierOrders { get; set; }
        public DbSet<SupplierOrderItem> SupplierOrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderID);

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.OrderItemID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<SupplierOrder>()
                .HasOne(so => so.Supplier)
                .WithMany(s => s.SupplierOrders)
                .HasForeignKey(so => so.SupplierID);

            modelBuilder.Entity<SupplierOrderItem>()
                .HasOne(soi => soi.SupplierOrder)
                .WithMany(so => so.SupplierOrderItems)
                .HasForeignKey(soi => soi.SupplierOrderID);

            //modelBuilder.Entity<SupplierOrderItem>()
            //   .HasOne(soi => soi.Book)
            //   .WithMany()
            //   .HasForeignKey(soi => soi.BookID);

            modelBuilder.Entity<Book>().HasIndex(b => b.ISBN);
            modelBuilder.Entity<Customer>().HasIndex(c => c.Email);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                    .EnableSensitiveDataLogging();
            }
        }
    }
}