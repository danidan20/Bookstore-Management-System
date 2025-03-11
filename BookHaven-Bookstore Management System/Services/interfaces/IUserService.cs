using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;

namespace BookHaven_Bookstore_Management_System.Services.interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User GetUserById(int userId);
        User GetUserByUsername(string username);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
    }
}
