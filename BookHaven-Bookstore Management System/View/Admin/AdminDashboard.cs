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
using BookHaven_Bookstore_Management_System.Services.interfaces;

namespace BookHaven_Bookstore_Management_System.View.Admin
{
    public partial class AdminDashboard : Form
    {
        private readonly IBookService _bookService;
        private readonly ICustomerService _customerService;
        private readonly ISupplierService _supplierService;
        private readonly ISupplierOrderService _supplierOrderService;
        private readonly IOrderService _orderService; // Assuming you have an Order service
        private readonly IUserService _userService; // Assuming you have an UserService

        public AdminDashboard(IBookService bookService, ICustomerService customerService, ISupplierService supplierService, ISupplierOrderService supplierOrderService, IOrderService orderService, IUserService userService)
        {
            InitializeComponent();
            _bookService = bookService;
            _customerService = customerService;
            _supplierService = supplierService;
            _supplierOrderService = supplierOrderService;
            _orderService = orderService;
            _userService = userService;
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                int bookCount = _bookService.GetAllBooks().Count();
                lblBookCount.Text = $"Books: {bookCount}";

                int customerCount = _customerService.GetAllCustomers().Count();
                lblCustomerCount.Text = $"Customers: {customerCount}";

                int supplierCount = _supplierService.GetAllSuppliers().Count();
                lblSupplierCount.Text = $"Suppliers: {supplierCount}";

                decimal totalSales = _orderService.GetAllOrders().Sum(o => o.TotalAmount); // Assuming you have TotalAmount in Order
                lblTotalSales.Text = $"Total Sales: {totalSales:C}";

                int completedSupplierOrders = _supplierOrderService.GetAllSupplierOrders().Count(o => o.OrderStatus == "Received"); // Assuming "Received" for completed
                lblCompletedSupplierOrders.Text = $"Completed Orders: {completedSupplierOrders}";

                int lowStockCount = _bookService.GetAllBooks().Count(b => b.StockQuantity < 10);
                lblLowStockCount.Text = $"Low Stock: {lowStockCount}";

                int staffCount = _userService.GetAllUsers().Count(u => u.Role == Role.STAFF);
                lblStaffCount.Text = $"Staff: {staffCount}";

                int storeAdminCount = _userService.GetAllUsers().Count(u => u.Role == Role.STORE_ADMIN);
                lblStoreAdminCount.Text = $"Store Admins: {storeAdminCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
    }
}
