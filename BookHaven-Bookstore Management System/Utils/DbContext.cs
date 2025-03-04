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

        // Add other DbSet properties for your entities (Books, Customers, etc.)

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entities here (e.g., relationships, keys)
            base.OnModelCreating(modelBuilder);
        }
    }
}
