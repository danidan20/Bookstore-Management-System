using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Services.interfaces;

namespace BookHaven_Bookstore_Management_System.View.CommonModules
{
    public partial class SupplierManagementForm : Form
    {
        private readonly ISupplierService _supplierService;
        private readonly ISupplierOrderService _supplierOrderService;
        private readonly IBookService _bookService;
        private List<Supplier> _allSuppliers;

        public SupplierManagementForm(ISupplierService supplierService, ISupplierOrderService supplierOrderService, IBookService bookService)
        {
            InitializeComponent();
            _supplierService = supplierService;
            _supplierOrderService = supplierOrderService;
            _bookService = bookService;
            LoadSuppliers();
            LoadBooks();
        }

        private void LoadSuppliers()
        {
            _allSuppliers = _supplierService.GetAllSuppliers();
            dataGridViewSuppliers.DataSource = _allSuppliers;
        }

        private void LoadBooks()
        {
            var allBooks = _bookService.GetAllBooks();
            cmbBooks.DataSource = allBooks;
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "BookID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newSupplier = new Supplier
            {
                SupplierName = txtSupplierName.Text,
                ContactInfo = txtContactInfo.Text
            };

            _supplierService.AddSupplier(newSupplier);
            LoadSuppliers();
            ClearSupplierFields();
        }

        private void btnUpdateSupplier_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                var selectedSupplier = (Supplier)dataGridViewSuppliers.SelectedRows[0].DataBoundItem;
                selectedSupplier.SupplierName = txtSupplierName.Text;
                selectedSupplier.ContactInfo = txtContactInfo.Text;
                _supplierService.UpdateSupplier(selectedSupplier);
                LoadSuppliers();
                ClearSupplierFields();
            }
        }

        private void btnDeleteSupplier_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                var selectedSupplier = (Supplier)dataGridViewSuppliers.SelectedRows[0].DataBoundItem;
                _supplierService.DeleteSupplier(selectedSupplier.SupplierID);
                LoadSuppliers();
                ClearSupplierFields();
            }
        }

        private void dataGridViewSuppliers_CellContentClick(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                var selectedSupplier = (Supplier)dataGridViewSuppliers.SelectedRows[0].DataBoundItem;
                txtSupplierName.Text = selectedSupplier.SupplierName;
                txtContactInfo.Text = selectedSupplier.ContactInfo;
            }
        }

        private void ClearSupplierFields()
        {
            txtSupplierName.Clear();
            txtContactInfo.Clear();
            txtSupplierId.Clear();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count == 0 || cmbBooks.SelectedItem == null || !int.TryParse(txtQuantity.Text, out int quantity) || !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please select a supplier, book, enter a valid quantity, and a valid price.");
                return;
            }

            var selectedSupplier = (Supplier)dataGridViewSuppliers.SelectedRows[0].DataBoundItem;
            var selectedBook = (Book)cmbBooks.SelectedItem;

            var supplierOrder = new SupplierOrder
            {
                SupplierID = selectedSupplier.SupplierID,
                OrderDate = DateTime.Now,
                OrderStatus = "Pending"
            };

            var orderItems = new List<SupplierOrderItem>
    {
        new SupplierOrderItem
        {
            BookID = selectedBook.BookID,
            Quantity = quantity,
            Price = price
        }
    };

            try
            {
                _supplierOrderService.CreateSupplierOrder(supplierOrder, orderItems);
                MessageBox.Show($"Order placed for {quantity} of '{selectedBook.Title}' at LKR {price} each, from {selectedSupplier.SupplierName}.");
                txtQuantity.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error placing order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                var selectedSupplier = (Supplier)dataGridViewSuppliers.SelectedRows[0].DataBoundItem;
                txtSupplierName.Text = selectedSupplier.SupplierName;
                txtContactInfo.Text = selectedSupplier.ContactInfo;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadSuppliers();
        }
    }
}