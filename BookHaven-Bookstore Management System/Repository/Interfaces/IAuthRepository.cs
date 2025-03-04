using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;

namespace BookHaven_Bookstore_Management_System.Repository.Interfaces
{
    public interface IAuthRepository
    {
        User AuthenticateUser(string username, string password);
        void RegisterUser(User user);
        bool IsUsernameTaken(string username);
    }
}
