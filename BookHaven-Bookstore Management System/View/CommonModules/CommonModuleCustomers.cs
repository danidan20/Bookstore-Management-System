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

namespace BookHaven_Bookstore_Management_System.View.CommonModules
{
    public partial class CommonModuleCustomers : Form
    {
        private readonly ICustomerService _customerService;

        public CommonModuleCustomers(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
            LoadCustomers();
            customer_table.CellClick += CustomerTable_CellClick;
            cust_id.Enabled = false;
        }

        private void LoadCustomers()
        {
            try
            {
                IEnumerable<Customer> customers = _customerService.GetAllCustomers();
                customer_table.DataSource = customers;
                customer_table.Columns["CustomerID"].HeaderText = "ID";
                customer_table.Columns["FirstName"].HeaderText = "First Name";
                customer_table.Columns["LastName"].HeaderText = "Last Name";
                customer_table.Columns["Email"].HeaderText = "Email";
                customer_table.Columns["PhoneNumber"].HeaderText = "Phone Number";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaffCustomers_Load(object sender, EventArgs e)
        {
        }

        private void customer_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cus_search_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = cus_search_key.Text.Trim();
                IEnumerable<Customer> customers = _customerService.SearchCustomers(searchTerm);
                customer_table.DataSource = customers;
                customer_table.Columns["CustomerID"].HeaderText = "ID";
                customer_table.Columns["FirstName"].HeaderText = "First Name";
                customer_table.Columns["LastName"].HeaderText = "Last Name";
                customer_table.Columns["Email"].HeaderText = "Email";
                customer_table.Columns["PhoneNumber"].HeaderText = "Phone Number";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customer_table_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void CustomerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = customer_table.Rows[e.RowIndex];

                if (selectedRow.Cells["CustomerID"].Value != null)
                {
                    cust_id.Text = selectedRow.Cells["CustomerID"].Value.ToString();
                }
                else
                {
                    cust_id.Text = "";
                }

                if (selectedRow.Cells["FirstName"].Value != null)
                {
                    cust_firstname.Text = selectedRow.Cells["FirstName"].Value.ToString();
                }
                else
                {
                    cust_firstname.Text = "";
                }

                if (selectedRow.Cells["LastName"].Value != null)
                {
                    cust_lastname.Text = selectedRow.Cells["LastName"].Value.ToString();
                }
                else
                {
                    cust_lastname.Text = "";
                }

                if (selectedRow.Cells["Email"].Value != null)
                {
                    cust_email.Text = selectedRow.Cells["Email"].Value.ToString();
                }
                else
                {
                    cust_email.Text = "";
                }

                if (selectedRow.Cells["PhoneNumber"].Value != null)
                {
                    cust_phonenumber.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                }
                else
                {
                    cust_phonenumber.Text = "";
                }
            }
        }

        private void cus_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cust_id.Text))
                {
                    MessageBox.Show("Please select a customer to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int customerId = Convert.ToInt32(cust_id.Text);
                string firstName = cust_firstname.Text.Trim();
                string lastName = cust_lastname.Text.Trim();
                string email = cust_email.Text.Trim();
                string phoneNumber = cust_phonenumber.Text.Trim();

                Customer updatedCustomer = new Customer
                {
                    CustomerID = customerId,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PhoneNumber = phoneNumber
                };

                //Example using update existing entity.
                var existingCustomer = _customerService.GetCustomerById(updatedCustomer.CustomerID);

                if (existingCustomer != null)
                {
                    existingCustomer.FirstName = updatedCustomer.FirstName;
                    existingCustomer.LastName = updatedCustomer.LastName;
                    existingCustomer.Email = updatedCustomer.Email;
                    existingCustomer.PhoneNumber = updatedCustomer.PhoneNumber;

                    _customerService.UpdateCustomer(existingCustomer);

                    MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoadCustomers();
                ClearTextBoxes();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Customer ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            cust_id.Text = "";
            cust_firstname.Text = "";
            cust_lastname.Text = "";
            cust_email.Text = "";
            cust_phonenumber.Text = "";
        }

        private void cus_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cust_firstname.Text) ||
                    string.IsNullOrWhiteSpace(cust_lastname.Text) ||
                    string.IsNullOrWhiteSpace(cust_email.Text) ||
                    string.IsNullOrWhiteSpace(cust_phonenumber.Text))
                {
                    MessageBox.Show("Please fill in all customer details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string firstName = cust_firstname.Text.Trim();
                string lastName = cust_lastname.Text.Trim();
                string email = cust_email.Text.Trim();
                string phoneNumber = cust_phonenumber.Text.Trim();

                Customer newCustomer = new Customer
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PhoneNumber = phoneNumber
                };

                _customerService.AddCustomer(newCustomer);

                MessageBox.Show("Customer saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCustomers();

                ClearTextBoxes();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cus_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cust_id.Text))
                {
                    MessageBox.Show("Please select a customer to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int customerId = Convert.ToInt32(cust_id.Text);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                _customerService.DeleteCustomer(customerId);

                MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCustomers();

                ClearTextBoxes();

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Customer ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}