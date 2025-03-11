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
using BookHaven_Bookstore_Management_System.Services.interfaces;
using BookHaven_Bookstore_Management_System.Utils;
using BookHaven_Bookstore_Management_System.View.Admin;
using BookHaven_Bookstore_Management_System.View.Staff;
using BookHaven_Bookstore_Management_System.View.StoreAdmin;
using Microsoft.Extensions.DependencyInjection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookHaven_Bookstore_Management_System.View
{
    public partial class Login : Form
    {
        private readonly IAuthService _authService;
        private readonly IServiceProvider _serviceProvider;
        public Login(IAuthService authService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _authService = authService;
            _serviceProvider = serviceProvider;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text.Trim();
            String password = HashPassword.Hashing(txtPassword.Text.Trim());
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Plese enter fill the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                User user = _authService.AuthenticateUser(username, password);
            if (user != null)
            {
                if (user.Role == Role.ADMIN)
                {
                    SessionManager.LoggedInUser = user;
                    AdminHome adminView = _serviceProvider.GetRequiredService<AdminHome>();
                    adminView.Show();
                    this.Hide();
                }
                else if (user.Role == Role.STAFF)
                {
                    SessionManager.LoggedInUser = user;
                    StaffHome staffView = _serviceProvider.GetRequiredService<StaffHome>();
                    staffView.Show();
                    this.Hide();
                }
                else if (user.Role == Role.STORE_ADMIN)
                {
                    SessionManager.LoggedInUser = user;
                    StoreAdminHome storeAdminView = _serviceProvider.GetRequiredService<StoreAdminHome>();
                    storeAdminView.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unknown user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
