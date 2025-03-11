using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Services.interfaces;
using BookHaven_Bookstore_Management_System.Utils; // Assuming HashPassword is in Utilities

namespace BookHaven_Bookstore_Management_System.View.Admin
{
    public partial class UserManagementForm : Form
    {
        private readonly IUserService _userService;

        public UserManagementForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            InitializeData();
            txtUserID.Enabled = false;
        }

        private void InitializeData()
        {
            LoadUsers();
            LoadRolesIntoComboBox();
            dataGridViewUsers.CellClick += DataGridViewUsers_CellClick;
        }

        private void LoadUsers()
        {
            try
            {
                var users = _userService.GetAllUsers().Where(u => u.Role == Role.STAFF || u.Role == Role.STORE_ADMIN).Select(u => new
                {
                    u.UserID,
                    u.Username,
                    u.RealName,
                    u.Email,
                    Role = u.Role.ToString()
                }).ToList();

                dataGridViewUsers.DataSource = users;
                ConfigureDataGridViewColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRolesIntoComboBox()
        {
            comboRole.DataSource = new List<Role> { Role.STAFF, Role.STORE_ADMIN };
            comboRole.DisplayMember = "ToString";
        }

        private void ConfigureDataGridViewColumns()
        {
            if (dataGridViewUsers.Columns.Count > 0)
            {
                dataGridViewUsers.Columns["UserID"].HeaderText = "User ID";
                dataGridViewUsers.Columns["Username"].HeaderText = "Username";
                dataGridViewUsers.Columns["RealName"].HeaderText = "Real Name";
                dataGridViewUsers.Columns["Email"].HeaderText = "Email";
                dataGridViewUsers.Columns["Role"].HeaderText = "Role";
            }
        }

        private void DataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedRow = dataGridViewUsers.Rows[e.RowIndex];
            txtUserID.Text = selectedRow.Cells["UserID"].Value?.ToString() ?? "";
            txtUsername.Text = selectedRow.Cells["Username"].Value?.ToString() ?? "";
            txtRealName.Text = selectedRow.Cells["RealName"].Value?.ToString() ?? "";
            txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString() ?? "";

            if (selectedRow.Cells["Role"].Value != null)
            {
                comboRole.SelectedItem = Enum.Parse(typeof(Role), selectedRow.Cells["Role"].Value.ToString());
            }
        }

        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInput() || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all required fields, including password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string hashedPassword = HashPassword.Hashing(txtPassword.Text.Trim());

                var newUser = new User
                {
                    Username = txtUsername.Text.Trim(),
                    PasswordHash = hashedPassword,
                    Role = (Role)comboRole.SelectedItem,
                    RealName = txtRealName.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                _userService.AddUser(newUser);
                MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateUser_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInput() || string.IsNullOrWhiteSpace(txtUserID.Text)) return;

            try
            {
                int userId = int.Parse(txtUserID.Text.Trim());
                var existingUser = _userService.GetUserById(userId);

                if (existingUser == null)
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                existingUser.Username = txtUsername.Text.Trim();
                existingUser.Role = (Role)comboRole.SelectedItem;
                existingUser.RealName = txtRealName.Text.Trim();
                existingUser.Email = txtEmail.Text.Trim();

                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    string hashedPassword = HashPassword.Hashing(txtPassword.Text.Trim());
                    existingUser.PasswordHash = hashedPassword;
                }

                _userService.UpdateUser(existingUser);
                MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text)) return;

            try
            {
                int userId = int.Parse(txtUserID.Text.Trim());
                _userService.DeleteUser(userId);
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || comboRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void RefreshData()
        {
            LoadUsers();
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txtUserID.Text = "";
            txtUsername.Text = "";
            txtRealName.Text = "";
            txtEmail.Text = "";
            comboRole.SelectedIndex = -1;
            txtPassword.Text = "";
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}