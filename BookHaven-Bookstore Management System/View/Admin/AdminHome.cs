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
using BookHaven_Bookstore_Management_System.Services.impl;
using BookHaven_Bookstore_Management_System.Services.interfaces;
using BookHaven_Bookstore_Management_System.Utils;
using BookHaven_Bookstore_Management_System.View.Staff;
using BookHaven_Bookstore_Management_System.View.CommonModules;
using Microsoft.Extensions.DependencyInjection;

namespace BookHaven_Bookstore_Management_System.View.Admin
{
    public partial class AdminHome : Form
    {
        private SupplierManagementForm _supplierManagement;
        private CommonModuleCustomers _customers;
        private CommonModuleBook _inventory;
        private AdminDashboard _dashboard;
        private UserManagementForm _userManagement;
        private ReportingAnalyticsForm _reportAnalytics;
        private Orders _orders;

        private readonly IServiceProvider _serviceProvider;
        public AdminHome(ICustomerService customerService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            _serviceProvider = serviceProvider;
            _dashboard = _serviceProvider.GetRequiredService<AdminDashboard>();
            LoadChildForm(_dashboard);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _dashboard = _serviceProvider.GetRequiredService<AdminDashboard>();
            LoadChildForm(_dashboard);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _customers = _serviceProvider.GetRequiredService<CommonModuleCustomers>();
            LoadChildForm(_customers);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _inventory = _serviceProvider.GetRequiredService<CommonModuleBook>();
            LoadChildForm(_inventory);
        }

        private void LoadChildForm(Form childForm)
        {
            staffPanelInject.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            staffPanelInject.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //_pos = _serviceProvider.GetRequiredService<Pos>();
            //LoadChildForm(_pos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _orders = _serviceProvider.GetRequiredService<Orders>();
            LoadChildForm(_orders);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SessionManager.LoggedInUser = null;
            Login loginForm = _serviceProvider.GetRequiredService<Login>();
            loginForm.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _supplierManagement = _serviceProvider.GetRequiredService<SupplierManagementForm>();
            LoadChildForm(_supplierManagement);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            _userManagement = _serviceProvider.GetRequiredService<UserManagementForm>();
            LoadChildForm(_userManagement);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _reportAnalytics = _serviceProvider.GetRequiredService<ReportingAnalyticsForm>();
            LoadChildForm(_reportAnalytics);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _orders = _serviceProvider.GetRequiredService<Orders>();
            LoadChildForm(_orders);
        }
    }
}
