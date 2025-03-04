using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven_Bookstore_Management_System.Utils
{
    public static class SessionManager
    {
        public static BookHaven_Bookstore_Management_System.Domain.User LoggedInUser { get; set; }
    }
}
