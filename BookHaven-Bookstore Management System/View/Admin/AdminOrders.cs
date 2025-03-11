// StaffOrders.cs
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Domain.Enums;
using BookHaven_Bookstore_Management_System.Services.impl;
using BookHaven_Bookstore_Management_System.Services.interfaces;
using BookHaven_Bookstore_Management_System.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookHaven_Bookstore_Management_System.View.Admin
{
    public partial class AdminOrders : Form
    {
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;
        private readonly IBookService _bookService;
        private readonly IOrderItemService _orderItemService;
        private List<Order> _allOrders;

        public AdminOrders(IOrderItemService orderItemService, IOrderService orderService, IBookService bookService, ICustomerService customerService)
        {
            InitializeComponent();
            _orderService = orderService;
            _bookService = bookService;
            _customerService = customerService;
            _orderItemService = orderItemService;
            InitializeForm();
        }

        private void InitializeForm()
        {
            LoadCustomers();
            LoadDeliveryStatuses();
            LoadPaymentStatuses();
            LoadOrders();
            dataGridViewOrders.CellContentDoubleClick += OnOrderCellDoubleClick;
        }

        private void LoadCustomers() => LoadComboBoxData(comCustomers, _customerService.GetAllCustomers(), "FullName", "CustomerID");
        private void LoadDeliveryStatuses() => LoadComboBoxData(comDeliveryStatus, Enum.GetValues(typeof(DeliveryStatus)).Cast<object>().ToList());
        private void LoadPaymentStatuses() => LoadComboBoxData(comPaymentStatus, Enum.GetValues(typeof(PaymentStatus)).Cast<object>().ToList());

        private void LoadComboBoxData(ComboBox comboBox, object dataSource, string displayMember = null, string valueMember = null)
        {
            comboBox.DataSource = dataSource;
            if (displayMember != null) comboBox.DisplayMember = displayMember;
            if (valueMember != null) comboBox.ValueMember = valueMember;
            comboBox.SelectedIndex = -1;
        }

        private void LoadOrders()
        {
            try { _allOrders = _orderService.GetAllOrders(); DisplayOrders(_allOrders); }
            catch (Exception ex) { ShowErrorMessage($"Error loading orders: {ex.Message}"); }
        }

        private void DisplayOrders(List<Order> orders) => dataGridViewOrders.DataSource = orders?.Select(MapOrderToDisplay).ToList();

        private object MapOrderToDisplay(Order o) => new
        {
            o.OrderID,
            o.Customer?.FullName,
            o.Customer?.Email,
            o.Customer?.PhoneNumber,
            o.OrderDate,
            o.TotalAmount,
            o.Discount,
            o.DeliveryAddress,
            o.DeliveryStatus,
            o.PaymentStatus
        };

        private void OnOrderCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsValidOrderCell(e, out int orderId)) LoadOrderDetails(orderId);
            else ShowErrorMessage("Invalid Order ID.");
        }

        private bool IsValidOrderCell(DataGridViewCellEventArgs e, out int orderId)
        {
            orderId = 0;
            return e.RowIndex >= 0 && e.RowIndex < dataGridViewOrders.Rows.Count &&
                   dataGridViewOrders.Rows[e.RowIndex].Cells["OrderID"].Value != null &&
                   int.TryParse(dataGridViewOrders.Rows[e.RowIndex].Cells["OrderID"].Value.ToString(), out orderId);
        }

        private void LoadOrderDetails(int orderId)
        {
            try
            {
                var order = _orderService.GetOrderById(orderId);
                if (order != null) OpenOrderUpdateForm(order);
                else ShowErrorMessage("Order not found.");
            }
            catch (Exception ex) { ShowErrorMessage($"Error retrieving order details: {ex.Message}"); }
        }

        private void OpenOrderUpdateForm(Order order)
        {
            try
            {
                AdminOrderUpdateForm updateForm = new AdminOrderUpdateForm(_orderService, _bookService, _customerService, _orderItemService, order); updateForm.ShowDialog(); LoadOrders();
            }
            catch (Exception ex) { ShowErrorMessage($"Error showing order details: {ex.Message}"); }
        }

        private void RefreshData()
        {
            LoadOrders();
            txtSearch.Clear();
            comCustomers.SelectedIndex = -1;
            comDeliveryStatus.SelectedIndex = -1;
            comPaymentStatus.SelectedIndex = -1;
        }

        private void FilterOrders()
        {
            var filteredOrders = string.IsNullOrWhiteSpace(txtSearch.Text)
                ? _allOrders
                : _allOrders.Where(o =>
                    o.OrderID.ToString().Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                    o.Customer?.FullName?.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) == true ||
                    o.Customer?.Email?.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) == true ||
                    o.Customer?.PhoneNumber?.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) == true ||
                    o.DeliveryAddress?.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) == true ||
                    o.DeliveryStatus.ToString().Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) == true ||
                    o.PaymentStatus.ToString().Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) == true
                ).ToList();
            DisplayOrders(filteredOrders);
        }

        private void DeleteSelectedOrder()
        {
            if (IsValidOrderSelection(out int orderId) && ConfirmDelete())
            {
                try { _orderService.DeleteOrder(orderId); ShowSuccessMessage("Order deleted successfully."); LoadOrders(); }
                catch (Exception ex) { ShowErrorMessage($"Error deleting order: {ex.Message}"); }
            }
        }

        private bool IsValidOrderSelection(out int orderId)
        {
            orderId = 0;
            return dataGridViewOrders.SelectedRows.Count > 0 &&
                   dataGridViewOrders.SelectedRows[0].Cells["OrderID"].Value != null &&
                   int.TryParse(dataGridViewOrders.SelectedRows[0].Cells["OrderID"].Value.ToString(), out orderId);
        }

        private bool ConfirmDelete() => MessageBox.Show("Are you sure you want to delete the selected order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        private void UpdateSelectedOrder()
        {
            if (IsValidOrderSelection(out int orderId)) LoadOrderDetails(orderId);
            else ShowErrorMessage("Please select an order to update.");
        }

        private void ShowErrorMessage(string message) => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        private void ShowSuccessMessage(string message) => MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void FilterOrdersByDeliveryStatus() => FilterOrdersByComboBoxSelection(comDeliveryStatus, o => o.DeliveryStatus);
        private void FilterOrdersByCustomer() => FilterOrdersByComboBoxSelection(comCustomers, o => o.CustomerID);
        private void FilterOrdersByPaymentStatus() => FilterOrdersByComboBoxSelection(comPaymentStatus, o => o.PaymentStatus);

        private void FilterOrdersByComboBoxSelection<T>(ComboBox comboBox, Func<Order, T> selector)
        {
            if (comboBox.SelectedItem is T selectedValue && _allOrders != null)
                DisplayOrders(_allOrders.Where(o => selector(o).Equals(selectedValue)).ToList());
            else if (_allOrders != null) DisplayOrders(_allOrders);
        }

        // Event Handlers
        private void txtSearch_TextChanged(object sender, EventArgs e) => FilterOrders();
        private void comDeliveryStatus_SelectedIndexChanged(object sender, EventArgs e) => FilterOrdersByDeliveryStatus();
        private void comCustomers_SelectedIndexChanged(object sender, EventArgs e) => FilterOrdersByCustomer();
        private void comPaymentStatus_SelectedIndexChanged(object sender, EventArgs e) => FilterOrdersByPaymentStatus();
        private void btnDeleteOrder_Click(object sender, EventArgs e) => DeleteSelectedOrder();
        private void btnUpdateOrder_Click(object sender, EventArgs e) => UpdateSelectedOrder();

        private void btnRefresh_Click_1(object sender, EventArgs e) => RefreshData();
        private void PrintOrderReceipt(int orderId)
        {
            try
            {
                var order = _orderService.GetOrderById(orderId);
                if (order == null)
                {
                    ShowErrorMessage("Order not found.");
                    return;
                }

                var customer = _customerService.GetCustomerById(order.CustomerID);
                if (customer == null)
                {
                    ShowErrorMessage("Customer not found.");
                    return;
                }
                var orderItems = _orderItemService.GetOrderItemsWithBooksByOrderId(orderId);
                order.OrderItems = orderItems;

                ReceiptGenerator receiptGenerator = new ReceiptGenerator(order, customer);
                receiptGenerator.PrintReceipt();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error printing receipt: {ex.Message}");
            }
        }
        private void tbl_print_Click(object sender, EventArgs e)
        {
            if (IsValidOrderSelection(out int orderId))
            {
                PrintOrderReceipt(orderId);
            }
            else
            {
                ShowErrorMessage("Please select an order to print a receipt.");
            }
        }
    }
}