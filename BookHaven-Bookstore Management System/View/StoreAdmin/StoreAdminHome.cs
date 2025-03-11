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
using BookHaven_Bookstore_Management_System.View.StoreAdmin;
using BookHaven_Bookstore_Management_System.View.CommonModules;
using Microsoft.Extensions.DependencyInjection;

namespace BookHaven_Bookstore_Management_System.View.StoreAdmin
{
    public partial class StoreAdminHome : Form
    {
        private SupplierManagementForm _supplierManagement;
        private CommonModuleBook _inventory;
        private SupplierOrdersViewForm _supplierOrdersViewForm;

        private readonly IServiceProvider _serviceProvider;
        public StoreAdminHome(ICustomerService customerService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            _serviceProvider = serviceProvider;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_dashboard = _serviceProvider.GetRequiredService<StaffDashboard>();
            //LoadChildForm(_dashboard);
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

        private void button3_Click(object sender, EventArgs e)
        {
            _supplierOrdersViewForm = _serviceProvider.GetRequiredService<SupplierOrdersViewForm>();
            LoadChildForm(_supplierOrdersViewForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _inventory = _serviceProvider.GetRequiredService<CommonModuleBook>();
            LoadChildForm(_inventory);
        }
    }
}
