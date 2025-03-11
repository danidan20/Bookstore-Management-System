using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Services.interfaces;

namespace BookHaven_Bookstore_Management_System.View.CommonModules
{
    public partial class UpdateOrderDetailsForm : Form
    {
        private readonly ISupplierOrderService _supplierOrderService;
        private readonly ISupplierOrderItemService _supplierOrderItemService;
        private readonly IBookService _bookService;
        private readonly SupplierOrder _order;
        private List<SupplierOrderItem> _orderItems;

        public UpdateOrderDetailsForm(ISupplierOrderService supplierOrderService, ISupplierOrderItemService supplierOrderItemService, IBookService bookService, SupplierOrder order)
        {
            InitializeComponent();
            _supplierOrderService = supplierOrderService;
            _supplierOrderItemService = supplierOrderItemService;
            _bookService = bookService;
            _order = order;
            LoadOrderDetails();
            LoadBooks();
        }

        private void LoadOrderDetails()
        {
            //_orderItems = _supplierOrderItemService.GetAllSupplierOrderItems().Where(item => item.SupplierOrderID == _order.SupplierOrderID).ToList();
            _orderItems = _supplierOrderItemService.GetSupplierOrderItemsByOrderId(_order.SupplierOrderID);
            dataGridViewOrderItems.DataSource = _orderItems.Select(item => new
            {
                item.SupplierOrderItemID,
                item.Book.Title,
                item.Quantity,
                item.Price
            }).ToList();
            cmbOrderStatus.Items.AddRange(new[] { "Pending", "Shipped", "Received", "Cancelled" });
            cmbOrderStatus.SelectedItem = _order.OrderStatus;
        }

        private void LoadBooks()
        {
            var books = _bookService.GetAllBooks();
            cmbBook.DataSource = books;
            cmbBook.DisplayMember = "Title";
            cmbBook.ValueMember = "BookID";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbBook.SelectedItem != null && int.TryParse(txtQuantity.Text, out int quantity) && decimal.TryParse(txtPrice.Text, out decimal price))
            {
                var book = (Book)cmbBook.SelectedItem;
                var newItem = new SupplierOrderItem
                {
                    SupplierOrderID = _order.SupplierOrderID,
                    BookID = book.BookID,
                    Quantity = quantity,
                    Price = price
                };
                _supplierOrderItemService.AddSupplierOrderItem(newItem);
                LoadOrderDetails();
            }
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderItems.SelectedRows.Count > 0 && int.TryParse(txtQuantity.Text, out int quantity) && decimal.TryParse(txtPrice.Text, out decimal price))
            {
                var selectedItem = _orderItems[dataGridViewOrderItems.SelectedRows[0].Index];
                selectedItem.Quantity = quantity;
                selectedItem.Price = price;
                _supplierOrderItemService.UpdateSupplierOrderItem(selectedItem);
                LoadOrderDetails();
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderItems.SelectedRows.Count > 0)
            {
                var selectedItem = _orderItems[dataGridViewOrderItems.SelectedRows[0].Index];
                _supplierOrderItemService.DeleteSupplierOrderItem(selectedItem.SupplierOrderItemID);
                LoadOrderDetails();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbOrderStatus.SelectedItem != null)
            {
                _order.OrderStatus = cmbOrderStatus.SelectedItem.ToString();
                _supplierOrderService.UpdateSupplierOrder(_order);
                if (_order.OrderStatus == "Received")
                {
                    try
                    {
                      _supplierOrderService.ReceiveOrder(_order.SupplierOrderID);
                        MessageBox.Show("Order received and inventory updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error receiving order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}