using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Domain.Enums;
using BookHaven_Bookstore_Management_System.Services.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookHaven_Bookstore_Management_System.View.CommonModules
{
    public partial class Pos : Form
    {
        private readonly IOrderService _orderService;
        private readonly IBookService _bookService;
        private readonly ICustomerService _customerService;
        private readonly List<OrderItem> _orderItems = new List<OrderItem>();
        private Order _currentOrder;

        public Pos(IOrderService orderService, IBookService bookService, ICustomerService customerService, Order order = null)
        {
            InitializeComponent();
            _orderService = orderService;
            _bookService = bookService;
            _customerService = customerService;
            _currentOrder = order; 

            InitializeData();
            InitializeDeliveryStatusComboBox();
            InitializePaymentStatusComboBox();
        }

        private void InitializeDeliveryStatusComboBox()
        {
            comDeliveryStatus.DataSource = Enum.GetValues(typeof(DeliveryStatus));
            comDeliveryStatus.SelectedItem = DeliveryStatus.DELIVERY;
        }

        private void InitializePaymentStatusComboBox()
        {
            comboPaymentStatus.DataSource = Enum.GetValues(typeof(PaymentStatus));
            comboPaymentStatus.SelectedItem = PaymentStatus.Pending;
        }

        private void InitializeData()
        {
            LoadCustomers();
            LoadBooks();
            UpdateOrderItemsGrid();
        }

        private void LoadCustomers()
        {
            var customers = _customerService.GetAllCustomers();
            comboBoxCustomers.DataSource = customers;
            comboBoxCustomers.DisplayMember = "FullName";
            comboBoxCustomers.ValueMember = "CustomerID";
        }

        private void LoadBooks()
        {
            var books = _bookService.GetAllBooks();
            comboBoxBooks.DataSource = books;
            comboBoxBooks.DisplayMember = "Title";
            comboBoxBooks.ValueMember = "BookID";
        }

        private void AddItem()
        {
            if (comboBoxBooks.SelectedItem is not Book book || !int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please select a book and enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (book.StockQuantity < quantity)
            {
                MessageBox.Show($"Insufficient stock for {book.Title}. Available: {book.StockQuantity}", "Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingItem = _orderItems.FirstOrDefault(oi => oi.Book.BookID == book.BookID);
            if (existingItem != null)
            {
                if (book.StockQuantity < existingItem.Quantity + quantity)
                {
                    MessageBox.Show($"Insufficient stock for {book.Title}. Available: {book.StockQuantity}", "Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existingItem.Quantity += quantity;
            }
            else
            {
                _orderItems.Add(new OrderItem { Book = book, Quantity = quantity, Price = book.Price });
            }

            UpdateOrderItemsGrid();
        }

        private void UpdateOrderItemsGrid()
        {
            dataGridViewOrderItems.DataSource = _orderItems.Select(oi => new
            {
                oi.Book.Title,
                oi.Quantity,
                oi.Price,
                Subtotal = oi.Price * oi.Quantity
            }).ToList();

            UpdateTotalAmount();
        }

        private void UpdateTotalAmount()
        {
            decimal total = _orderItems.Sum(oi => oi.Price * oi.Quantity);
            decimal discount = decimal.TryParse(txtDiscount.Text, out decimal d) ? d : 0;
            lblTotal.Text = $"Total: LKR {total - discount:F2}";
        }

        private void CreateOrder()
        {
            if (comboBoxCustomers.SelectedItem == null || _orderItems.Count == 0)
            {
                MessageBox.Show("Please select a customer and add items to the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int customerId = (int)comboBoxCustomers.SelectedValue;
            decimal discount = decimal.TryParse(txtDiscount.Text, out decimal d) ? d : 0;
            DeliveryStatus deliveryStatus = (DeliveryStatus)comDeliveryStatus.SelectedItem;
            PaymentStatus paymentStatus = (PaymentStatus)comboPaymentStatus.SelectedItem;

            try
            {
                var order = _orderService.CreateOrder(customerId, _orderItems, txtDeliveryAddress.Text, discount, paymentStatus); //Added paymentStatus
                order.DeliveryStatus = deliveryStatus;
                _orderService.UpdateOrder(order);

                MessageBox.Show("Order created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (DbUpdateException dbEx)
            {
                HandleDatabaseError(dbEx);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleDatabaseError(DbUpdateException dbEx)
        {
            string errorMessage = dbEx.InnerException?.Message ?? dbEx.Message;
            MessageBox.Show($"Database Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RemoveSelectedItem()
        {
            if (dataGridViewOrderItems.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewOrderItems.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < _orderItems.Count)
                {
                    _orderItems.RemoveAt(selectedIndex);
                    UpdateOrderItemsGrid();
                }
            }
        }

        private void ClearForm()
        {
            _orderItems.Clear();
            UpdateOrderItemsGrid();
            txtQuantity.Clear();
            txtDiscount.Clear();
            txtDeliveryAddress.Clear();
            comboBoxCustomers.SelectedIndex = -1;
            comboBoxBooks.SelectedIndex = -1;
            comboBoxBooks.Focus();
            lblTotal.Text = "Total: LKR 0.00";
            comDeliveryStatus.SelectedItem = DeliveryStatus.DELIVERY;
            comboPaymentStatus.SelectedItem = PaymentStatus.Pending;
        }

        private void btnAddItem_Click_1(object sender, EventArgs e) => AddItem();
        private void btnCreateOrder_Click_1(object sender, EventArgs e) => CreateOrder();
        private void txtDiscount_TextChanged(object sender, EventArgs e) => UpdateTotalAmount();
        private void btnRemoveItem_Click_1(object sender, EventArgs e) => RemoveSelectedItem();
    }
}