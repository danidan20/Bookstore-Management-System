using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Repository.Interfaces;

namespace BookHaven_Bookstore_Management_System.View.Admin
{
    public partial class AdminHome : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthRepository _authRepository;
        private User _loggedInUser;
        public AdminHome()
        {
            InitializeComponent();
            
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }


    }
}
