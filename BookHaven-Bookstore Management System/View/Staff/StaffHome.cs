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
using Microsoft.Extensions.DependencyInjection;

namespace BookHaven_Bookstore_Management_System.View.Staff
{
    public partial class StaffHome : Form
    {
        private StaffDashboard _dashboard;
        private StaffCustomers _customers;
        private StaffBook _inventory;

        private readonly IServiceProvider _serviceProvider;
        public StaffHome(ICustomerService customerService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            _serviceProvider = serviceProvider;
        }

        private void StaffHome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _dashboard = _serviceProvider.GetRequiredService<StaffDashboard>();
            LoadChildForm(_dashboard);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _customers = _serviceProvider.GetRequiredService<StaffCustomers>();
            LoadChildForm(_customers);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _inventory = _serviceProvider.GetRequiredService<StaffBook>();
            LoadChildForm(_inventory);
        }

        private void LoadChildForm(Form childForm)
        {
            staffPanelInject.Controls.Clear(); // Clear existing forms
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            staffPanelInject.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
