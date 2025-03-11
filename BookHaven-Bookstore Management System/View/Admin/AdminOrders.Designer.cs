
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Services.impl;
using BookHaven_Bookstore_Management_System.Services.interfaces;

namespace BookHaven_Bookstore_Management_System.View.Admin
{
    partial class AdminOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            comPaymentStatus = new ComboBox();
            comDeliveryStatus = new ComboBox();
            btnDeleteOrder = new Button();
            btnUpdateOrder = new Button();
            comCustomers = new ComboBox();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            dataGridViewOrders = new DataGridView();
            tbl_print = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbl_print);
            panel1.Controls.Add(comPaymentStatus);
            panel1.Controls.Add(comDeliveryStatus);
            panel1.Controls.Add(btnDeleteOrder);
            panel1.Controls.Add(btnUpdateOrder);
            panel1.Controls.Add(comCustomers);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(dataGridViewOrders);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 451);
            panel1.TabIndex = 0;
            // 
            // comPaymentStatus
            // 
            comPaymentStatus.FormattingEnabled = true;
            comPaymentStatus.Location = new Point(477, 48);
            comPaymentStatus.Name = "comPaymentStatus";
            comPaymentStatus.Size = new Size(225, 23);
            comPaymentStatus.TabIndex = 7;
            comPaymentStatus.SelectedIndexChanged += comPaymentStatus_SelectedIndexChanged;
            // 
            // comDeliveryStatus
            // 
            comDeliveryStatus.FormattingEnabled = true;
            comDeliveryStatus.Location = new Point(246, 48);
            comDeliveryStatus.Name = "comDeliveryStatus";
            comDeliveryStatus.Size = new Size(225, 23);
            comDeliveryStatus.TabIndex = 6;
            comDeliveryStatus.SelectedIndexChanged += comDeliveryStatus_SelectedIndexChanged;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeleteOrder.Location = new Point(707, 8);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(80, 31);
            btnDeleteOrder.TabIndex = 5;
            btnDeleteOrder.Text = "Delete";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnUpdateOrder
            // 
            btnUpdateOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdateOrder.Location = new Point(593, 8);
            btnUpdateOrder.Name = "btnUpdateOrder";
            btnUpdateOrder.Size = new Size(108, 31);
            btnUpdateOrder.TabIndex = 4;
            btnUpdateOrder.Text = "To Update";
            btnUpdateOrder.UseVisualStyleBackColor = true;
            // 
            // comCustomers
            // 
            comCustomers.FormattingEnabled = true;
            comCustomers.Location = new Point(11, 48);
            comCustomers.Name = "comCustomers";
            comCustomers.Size = new Size(229, 23);
            comCustomers.TabIndex = 3;
            comCustomers.SelectedIndexChanged += comCustomers_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtSearch.Location = new Point(11, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(229, 25);
            txtSearch.TabIndex = 2;
            txtSearch.Text = "Search";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRefresh.Location = new Point(511, 8);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(76, 31);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(3, 77);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(784, 371);
            dataGridViewOrders.TabIndex = 0;
            dataGridViewOrders.CellMouseDoubleClick += dataGridViewOrders_CellContentDoubleClick;
            // 
            // tbl_print
            // 
            tbl_print.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tbl_print.Location = new Point(366, 8);
            tbl_print.Name = "tbl_print";
            tbl_print.Size = new Size(139, 31);
            tbl_print.TabIndex = 8;
            tbl_print.Text = "Print Reciept";
            tbl_print.UseVisualStyleBackColor = true;
            tbl_print.Click += tbl_print_Click;
            // 
            // StaffOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "StaffOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffOrders";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
        }

        private void dataGridViewOrders_CellContentDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewOrders.Rows.Count &&
                 dataGridViewOrders.Rows[e.RowIndex].Cells["OrderID"].Value != null &&
                 int.TryParse(dataGridViewOrders.Rows[e.RowIndex].Cells["OrderID"].Value.ToString(), out int orderId))
            {
                LoadOrderItems(orderId);
            }
        }
        private void LoadOrderItems(int orderId)

        {

            try

            {

                var order = _orderService.GetOrderById(orderId);

                if (order != null) ShowOrderDetails(order);

            }

            catch (Exception ex)

            {

                MessageBox.Show($"Error loading order items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void ShowOrderDetails(Order order)
        {
            try
            {
                AdminOrderUpdateForm updateForm = new AdminOrderUpdateForm(_orderService, _bookService, _customerService, _orderItemService, order);
                updateForm.ShowDialog();
                dataGridViewOrders.ClearSelection();
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewOrders;
        private Button btnRefresh;
        private TextBox txtSearch;
        private ComboBox comboBox1;
        private Button btnDeleteOrder;
        private Button btnUpdateOrder;
        private ComboBox comCustomers;
        private ComboBox comDeliveryStatus;
        private ComboBox comPaymentStatus;
        private Button tbl_print;
    }
}