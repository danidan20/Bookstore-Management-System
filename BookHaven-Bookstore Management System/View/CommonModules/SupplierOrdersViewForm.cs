using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Services.interfaces;

namespace BookHaven_Bookstore_Management_System.View.CommonModules
{
    public partial class SupplierOrdersViewForm : Form
    {
        private readonly ISupplierOrderService _supplierOrderService;
        private readonly ISupplierOrderItemService _supplierOrderItemService;
        private readonly IBookService _bookService;

        private List<SupplierOrder> _allOrders;

        public SupplierOrdersViewForm(ISupplierOrderService supplierOrderService, ISupplierOrderItemService supplierOrderItemService, IBookService bookService)
        {
            InitializeComponent();
            _supplierOrderService = supplierOrderService;
            _supplierOrderItemService = supplierOrderItemService;
            _bookService = bookService;
            LoadOrders();
            LoadFilterOptions();
        }

        private void LoadOrders()
        {
            _allOrders = _supplierOrderService.GetAllSupplierOrders();
            var orderData = _allOrders.Select(o => new
            {
                o.SupplierOrderID,
                SupplierName = o.Supplier?.SupplierName ?? "Unknown Supplier", 
                o.OrderDate,
                o.OrderStatus
            }).ToList();

            dataGridViewOrders.DataSource = orderData;
        }

        private void LoadFilterOptions()
        {
            cmbFilterStatus.Items.Add("All");
            cmbFilterStatus.Items.AddRange(_allOrders.Select(o => o.OrderStatus).Distinct().ToArray());
            cmbFilterStatus.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            var filteredOrders = _allOrders.AsQueryable();

            if (cmbFilterStatus.SelectedItem != null && cmbFilterStatus.SelectedItem.ToString() != "All")
            {
                filteredOrders = filteredOrders.Where(o => o.OrderStatus == cmbFilterStatus.SelectedItem.ToString());
            }

            if (!string.IsNullOrEmpty(txtFilterSupplier.Text))
            {
                filteredOrders = filteredOrders.Where(o => o.Supplier != null && o.Supplier.SupplierName.Contains(txtFilterSupplier.Text, StringComparison.OrdinalIgnoreCase));
            }

            dataGridViewOrders.DataSource = filteredOrders.Select(o => new
            {
                o.SupplierOrderID,
                SupplierName = o.Supplier != null ? o.Supplier.SupplierName : "Unknown Supplier", //Null check here also.
                o.OrderDate,
                o.OrderStatus
            }).ToList();
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void txtFilterSupplier_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnUpdateDetails_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                int orderId = (int)dataGridViewOrders.SelectedRows[0].Cells["SupplierOrderID"].Value;
                var order = _supplierOrderService.GetSupplierOrderById(orderId);

                if (order != null)
                {
                    UpdateOrderDetailsForm updateForm = new UpdateOrderDetailsForm(_supplierOrderService, _supplierOrderItemService, _bookService, order);
                    if (updateForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadOrders();
                        ApplyFilters();
                    }
                }
                else
                {
                    MessageBox.Show("Order not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an order to update.");
            }
        }
    }
}