using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Domain.Enums;
using BookHaven_Bookstore_Management_System.Services.impl;
using BookHaven_Bookstore_Management_System.Services.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookHaven_Bookstore_Management_System.View.Admin
{
    public partial class AdminOrderUpdateForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly IOrderItemService _orderItemService;
        private readonly IBookService _bookService;
        private readonly ICustomerService _customerService;
        private readonly List<OrderItem> _orderItems = new List<OrderItem>();
        private Order _currentOrder;
        private readonly bool _isUpdateMode;

        public AdminOrderUpdateForm(IOrderService orderService, IBookService bookService, ICustomerService customerService, IOrderItemService orderItemService, Order order = null)
        {
            InitializeComponent();
            _orderService = orderService;
            _bookService = bookService;
            _customerService = customerService;
            _currentOrder = order;
            _isUpdateMode = order != null;
            _orderItemService = orderItemService;
            InitializeForm();
        }

        private void InitializeForm()
        {
            InitializeComboBoxes();
            LoadData();
            if (_isUpdateMode) LoadOrderData();
        }

        private void InitializeComboBoxes()
        {
            LoadComboBox(comDeliveryStatus, Enum.GetValues(typeof(DeliveryStatus)).Cast<object>().ToList(), DeliveryStatus.DELIVERY);
            LoadComboBox(comboPaymentStatus, Enum.GetValues(typeof(PaymentStatus)).Cast<object>().ToList(), PaymentStatus.Pending);
        }

        private void LoadComboBox(ComboBox comboBox, List<object> dataSource, object selectedItem = null)
        {
            comboBox.DataSource = dataSource;
            if (selectedItem != null) comboBox.SelectedItem = selectedItem;
        }

        private void LoadData()
        {
            LoadCustomers();
            LoadBooks();
            UpdateOrderItemsGrid();
        }

        private void LoadCustomers() => LoadComboBox(comboBoxCustomers, _customerService.GetAllCustomers().Cast<object>().ToList(), "FullName", "CustomerID");
        private void LoadBooks() => LoadComboBox(comboBoxBooks, _bookService.GetAllBooks().Cast<object>().ToList(), "Title", "BookID");

        private void LoadComboBox(ComboBox comboBox, List<object> dataSource, string displayMember, string valueMember)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        private void LoadOrderData()
        {
            if (_currentOrder == null) return;

            comboBoxCustomers.SelectedValue = _currentOrder.CustomerID;
            txtDeliveryAddress.Text = _currentOrder.DeliveryAddress;
            txtDiscount.Text = _currentOrder.Discount.ToString();
            comDeliveryStatus.SelectedItem = _currentOrder.DeliveryStatus;
            comboPaymentStatus.SelectedItem = _currentOrder.PaymentStatus;

            _orderItems.AddRange(_orderItemService.GetOrderItemsWithBooksByOrderId(_currentOrder.OrderID)); 

            UpdateOrderItemsGrid();
        }

        private void AddItem()
        {
            if (!ValidateItemSelection(out Book book, out int quantity) || !ValidateStock(book, quantity)) return;
            UpdateOrderItemList(book, quantity);
            UpdateOrderItemsGrid();
        }

        private bool ValidateItemSelection(out Book book, out int quantity)
        {
            book = comboBoxBooks.SelectedItem as Book;
            if (book == null || !int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                ShowErrorMessage("Please select a book and enter a valid quantity.");
                quantity = 0;
                return false;
            }
            return true;
        }
        private bool ValidateStock(Book book, int quantity)
        {
            var existingItem = _orderItems.FirstOrDefault(oi => oi.Book.BookID == book.BookID);
            int currentQuantity = existingItem?.Quantity ?? 0;
            if (book.StockQuantity < currentQuantity + quantity)
            {
                ShowWarningMessage($"Insufficient stock for {book.Title}. Available: {book.StockQuantity}");
                return false;
            }
            return true;
        }

        private void UpdateOrderItemList(Book book, int quantity)
        {
            var existingItem = _orderItems.FirstOrDefault(oi => oi.Book.BookID == book.BookID);
            if (existingItem != null) existingItem.Quantity += quantity;
            else _orderItems.Add(new OrderItem { Book = book, Quantity = quantity, Price = book.Price });
        }

        private void UpdateOrderItemsGrid()
        {
            dataGridViewOrderItems.DataSource = _orderItems.Select(oi => new { oi.Book.Title, oi.Quantity, oi.Price, Subtotal = oi.Price * oi.Quantity }).ToList();
            UpdateTotalAmount();
        }

        private void UpdateTotalAmount()
        {
            decimal total = _orderItems.Sum(oi => oi.Price * oi.Quantity);
            decimal discount = decimal.TryParse(txtDiscount.Text, out decimal d) ? d : 0;
            lblTotal.Text = $"Total: LKR {total - discount:F2}";
        }
        private bool ValidateDiscount()
        {
            if (string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                return true; // Empty discount is considered valid (no discount)
            }

            if (decimal.TryParse(txtDiscount.Text, out decimal discount))
            {
                if (discount < 0)
                {
                    ShowErrorMessage("Discount cannot be negative.");
                    return false;
                }
                return true; // Valid discount
            }
            else
            {
                ShowErrorMessage("Invalid discount format. Please enter a valid number.");
                return false; // Invalid discount format
            }
        }
        private void SaveOrder()
        {
            if (!ValidateOrderData() || !ValidateDiscount()) return;

            int customerId = (int)comboBoxCustomers.SelectedValue;
            decimal discount = decimal.TryParse(txtDiscount.Text, out decimal d) ? d : 0;
            DeliveryStatus deliveryStatus = (DeliveryStatus)comDeliveryStatus.SelectedItem;
            PaymentStatus paymentStatus = (PaymentStatus)comboPaymentStatus.SelectedItem;

            try
            {
                if (_isUpdateMode)
                {
                    UpdateExistingOrder(customerId, discount, deliveryStatus, paymentStatus);
                }
                else
                {
                    CreateNewOrder(customerId, discount, deliveryStatus, paymentStatus);
                }

                ShowSuccessMessage($"Order {(_isUpdateMode ? "updated" : "created")} successfully!");
                ClearForm();
            }
            catch (DbUpdateException dbEx)
            {
                HandleDatabaseError(dbEx);
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"General Error: {ex.Message}");
            }
        }
        private bool ValidateOrderData()
        {
            if (comboBoxCustomers.SelectedItem == null || _orderItems.Count == 0)
            {
                ShowErrorMessage("Please select a customer and add items to the order.");
                return false;
            }
            return true;
        }
        private void CreateNewOrder(int customerId, decimal discount, DeliveryStatus deliveryStatus, PaymentStatus paymentStatus)
        {
            var order = _orderService.CreateOrder(customerId, _orderItems, txtDeliveryAddress.Text, discount, paymentStatus);
            order.DeliveryStatus = deliveryStatus;
            _orderService.UpdateOrder(order);
        }
        private void UpdateExistingOrder(int customerId, decimal discount, DeliveryStatus deliveryStatus, PaymentStatus paymentStatus)
        {
            if (_currentOrder == null) return;

            _currentOrder.CustomerID = customerId;
            _currentOrder.DeliveryAddress = txtDeliveryAddress.Text;
            _currentOrder.Discount = discount;
            _currentOrder.DeliveryStatus = deliveryStatus;
            _currentOrder.PaymentStatus = paymentStatus;
            _currentOrder.OrderItems.Clear();
            _currentOrder.OrderItems = _orderItems;

            _orderService.UpdateOrder(_currentOrder);
        }

        private void HandleDatabaseError(DbUpdateException dbEx)
        {
            string errorMessage = dbEx.InnerException?.Message ?? dbEx.Message;
            Console.WriteLine($"Database Error: {errorMessage}");
            ShowErrorMessage($"Database Error: {errorMessage}");
        }

        private void RemoveSelectedItem()
        {
            if (dataGridViewOrderItems.SelectedRows.Count <= 0) return;
            int selectedIndex = dataGridViewOrderItems.SelectedRows[0].Index;
            if (selectedIndex >= 0 && selectedIndex < _orderItems.Count)
            {
                _orderItems.RemoveAt(selectedIndex);
                UpdateOrderItemsGrid();
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

        private void ShowErrorMessage(string message) => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        private void ShowWarningMessage(string message) => MessageBox.Show(message, "Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        private void ShowSuccessMessage(string message) => MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            SaveOrder();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            RemoveSelectedItem();
        }
    }
}