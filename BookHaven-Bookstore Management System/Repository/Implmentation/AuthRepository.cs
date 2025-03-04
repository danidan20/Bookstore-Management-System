using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Repository.Interfaces;
using BookHaven_Bookstore_Management_System.Utils;

namespace BookHaven_Bookstore_Management_System.Repository.Implmentation
{
    public class AuthRepository : IAuthRepository
    {
        private readonly BookHavenDbContext _context;

        public AuthRepository(BookHavenDbContext context)
        {
            _context = context;
        }

        public User AuthenticateUser(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username);

            if (user != null && VerifyPassword(password, user.PasswordHash))
            {
                return user;
            }

            return null;
        }

        public void RegisterUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public bool IsUsernameTaken(string username)
        {
            return _context.Users.Any(u => u.Username == username);
        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            // IMPORTANT: Replace this with your actual password verification logic.
            // You should use a secure hashing algorithm (like BCrypt or Argon2) to compare passwords.
            // This example is for demonstration purposes only and is not secure.
            return hashedPassword == password; // Replace with proper hashing check!
        }
    }
}
