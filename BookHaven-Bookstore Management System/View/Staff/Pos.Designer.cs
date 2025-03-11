namespace BookHaven_Bookstore_Management_System.View.Staff
{
    partial class Pos
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
            btnCreateOrder = new Button();
            groupBox3 = new GroupBox();
            comboPaymentStatus = new ComboBox();
            label7 = new Label();
            comDeliveryStatus = new ComboBox();
            label6 = new Label();
            lblTotal = new Label();
            txtDiscount = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btnRemoveItem = new Button();
            dataGridViewOrderItems = new DataGridView();
            groupBox1 = new GroupBox();
            btnAddItem = new Button();
            txtQuantity = new TextBox();
            label4 = new Label();
            comboBoxBooks = new ComboBox();
            label3 = new Label();
            Customer = new GroupBox();
            txtDeliveryAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxCustomers = new ComboBox();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).BeginInit();
            groupBox1.SuspendLayout();
            Customer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCreateOrder);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(Customer);
            panel1.Location = new Point(2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 441);
            panel1.TabIndex = 0;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreateOrder.Location = new Point(479, 399);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(307, 29);
            btnCreateOrder.TabIndex = 7;
            btnCreateOrder.Text = "Create Order";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboPaymentStatus);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(comDeliveryStatus);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(lblTotal);
            groupBox3.Controls.Add(txtDiscount);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(10, 307);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 127);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order Summary";
            // 
            // comboPaymentStatus
            // 
            comboPaymentStatus.FormattingEnabled = true;
            comboPaymentStatus.Location = new Point(85, 89);
            comboPaymentStatus.Name = "comboPaymentStatus";
            comboPaymentStatus.Size = new Size(184, 29);
            comboPaymentStatus.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 92);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 5;
            label7.Text = "Payment";
            // 
            // comDeliveryStatus
            // 
            comDeliveryStatus.FormattingEnabled = true;
            comDeliveryStatus.Location = new Point(356, 38);
            comDeliveryStatus.Name = "comDeliveryStatus";
            comDeliveryStatus.Size = new Size(211, 29);
            comDeliveryStatus.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(275, 41);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 3;
            label6.Text = "Delivery";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(597, 41);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(68, 21);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "lblTotal";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(85, 41);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(184, 29);
            txtDiscount.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 41);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 0;
            label5.Text = "Discount";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRemoveItem);
            groupBox2.Controls.Add(dataGridViewOrderItems);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(10, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 124);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Items";
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(12, 49);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(257, 44);
            btnRemoveItem.TabIndex = 1;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click_1;
            // 
            // dataGridViewOrderItems
            // 
            dataGridViewOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderItems.Location = new Point(281, 20);
            dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            dataGridViewOrderItems.Size = new Size(480, 98);
            dataGridViewOrderItems.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddItem);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxBooks);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(10, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 86);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Selection";
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(686, 31);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 37);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "Add";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click_1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(424, 35);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(241, 29);
            txtQuantity.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 36);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 2;
            label4.Text = "Quantity";
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new Point(85, 36);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new Size(227, 29);
            comboBoxBooks.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 36);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 0;
            label3.Text = "Book";
            // 
            // Customer
            // 
            Customer.Controls.Add(txtDeliveryAddress);
            Customer.Controls.Add(label1);
            Customer.Controls.Add(label2);
            Customer.Controls.Add(comboBoxCustomers);
            Customer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Customer.Location = new Point(10, 8);
            Customer.Name = "Customer";
            Customer.Size = new Size(776, 71);
            Customer.TabIndex = 3;
            Customer.TabStop = false;
            Customer.Text = "Customer Information";
            // 
            // txtDeliveryAddress
            // 
            txtDeliveryAddress.Location = new Point(486, 28);
            txtDeliveryAddress.Name = "txtDeliveryAddress";
            txtDeliveryAddress.Size = new Size(241, 29);
            txtDeliveryAddress.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(400, 33);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 2;
            label2.Text = "Address";
            // 
            // comboBoxCustomers
            // 
            comboBoxCustomers.FormattingEnabled = true;
            comboBoxCustomers.Location = new Point(85, 29);
            comboBoxCustomers.Name = "comboBoxCustomers";
            comboBoxCustomers.Size = new Size(227, 29);
            comboBoxCustomers.TabIndex = 1;
            // 
            // Pos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Pos";
            Text = "Pos";
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Customer.ResumeLayout(false);
            Customer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBoxCustomers;
        private GroupBox Customer;
        private Label label2;
        private TextBox txtDeliveryAddress;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtQuantity;
        private Label label4;
        private ComboBox comboBoxBooks;
        private Button btnAddItem;
        private GroupBox groupBox2;
        private DataGridView dataGridViewOrderItems;
        private Button btnRemoveItem;
        private GroupBox groupBox3;
        private TextBox txtDiscount;
        private Label label5;
        private Label lblTotal;
        private Button btnCreateOrder;
        private Label label6;
        private ComboBox comDeliveryStatus;
        private ComboBox comboPaymentStatus;
        private Label label7;
    }
}