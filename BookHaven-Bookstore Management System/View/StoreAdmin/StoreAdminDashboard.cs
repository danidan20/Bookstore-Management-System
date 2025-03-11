using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven_Bookstore_Management_System.Services.interfaces;

namespace BookHaven_Bookstore_Management_System.View.StoreAdmin
{
    public partial class StoreAdminDashboard : Form
    {
        private readonly IBookService _bookService;
        private readonly ISupplierService _supplierService;
        private readonly ISupplierOrderService _supplierOrderService;

        public StoreAdminDashboard(IBookService bookService, ISupplierService supplierService, ISupplierOrderService supplierOrderService)
        {
            InitializeComponent();
            _bookService = bookService;
            _supplierService = supplierService;
            _supplierOrderService = supplierOrderService;
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                int totalBooks = _bookService.GetAllBooks().Count();
                lblTotalBooks.Text = $"Total Books: {totalBooks}";

                int lowStockBooks = _bookService.GetAllBooks().Count(b => b.StockQuantity < 10);
                lblLowStockBooks.Text = $"Low Stock Books: {lowStockBooks}";

                int totalSuppliers = _supplierService.GetAllSuppliers().Count();
                lblTotalSuppliers.Text = $"Total Suppliers: {totalSuppliers}";

                 int pendingOrders = _supplierOrderService.GetAllSupplierOrders().Count(o => o.OrderStatus == "Pending");
                lblPendingOrders.Text = $"Pending Orders: {pendingOrders}";

                int completedOrders = _supplierOrderService.GetAllSupplierOrders().Count(o => o.OrderStatus == "Received"); 
                lblCompletedOrders.Text = $"Completed Orders: {completedOrders}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StoreAdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
    }
}
