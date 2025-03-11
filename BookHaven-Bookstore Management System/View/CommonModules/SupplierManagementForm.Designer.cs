namespace BookHaven_Bookstore_Management_System.View.CommonModules
{
    partial class SupplierManagementForm
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
            panel2 = new Panel();
            txtPricelbl = new Label();
            txtPrice = new TextBox();
            btnCreateOrder = new Button();
            txtQuantity = new TextBox();
            label4 = new Label();
            cmbBooks = new ComboBox();
            label3 = new Label();
            btnDeleteSupplier = new Button();
            btnUpdateSupplier = new Button();
            btnAddSupplier = new Button();
            txtSupplierId = new TextBox();
            label2 = new Label();
            txtContactInfo = new TextBox();
            label1 = new Label();
            txtSupplierName = new TextBox();
            txtSupplierNamelbl = new Label();
            dataGridViewSuppliers = new DataGridView();
            button1 = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridViewSuppliers);
            panel1.Location = new Point(-1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 447);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPricelbl);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(btnCreateOrder);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cmbBooks);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnDeleteSupplier);
            panel2.Controls.Add(btnUpdateSupplier);
            panel2.Controls.Add(btnAddSupplier);
            panel2.Controls.Add(txtSupplierId);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtContactInfo);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtSupplierName);
            panel2.Controls.Add(txtSupplierNamelbl);
            panel2.Location = new Point(6, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 395);
            panel2.TabIndex = 2;
            // 
            // txtPricelbl
            // 
            txtPricelbl.AutoSize = true;
            txtPricelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPricelbl.Location = new Point(209, 168);
            txtPricelbl.Name = "txtPricelbl";
            txtPricelbl.Size = new Size(48, 21);
            txtPricelbl.TabIndex = 15;
            txtPricelbl.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(209, 192);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(97, 23);
            txtPrice.TabIndex = 14;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreateOrder.Location = new Point(7, 318);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(294, 36);
            btnCreateOrder.TabIndex = 13;
            btnCreateOrder.Text = "Create Order";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(6, 251);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(303, 23);
            txtQuantity.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(7, 225);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 11;
            label4.Text = "Quantity";
            // 
            // cmbBooks
            // 
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(7, 192);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(196, 23);
            cmbBooks.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(6, 168);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 9;
            label3.Text = "Books";
            // 
            // btnDeleteSupplier
            // 
            btnDeleteSupplier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteSupplier.Location = new Point(207, 280);
            btnDeleteSupplier.Name = "btnDeleteSupplier";
            btnDeleteSupplier.Size = new Size(102, 32);
            btnDeleteSupplier.TabIndex = 8;
            btnDeleteSupplier.Text = "Delete Supplier";
            btnDeleteSupplier.UseVisualStyleBackColor = true;
            btnDeleteSupplier.Click += btnDeleteSupplier_Click_1;
            // 
            // btnUpdateSupplier
            // 
            btnUpdateSupplier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateSupplier.Location = new Point(97, 280);
            btnUpdateSupplier.Name = "btnUpdateSupplier";
            btnUpdateSupplier.Size = new Size(106, 32);
            btnUpdateSupplier.TabIndex = 7;
            btnUpdateSupplier.Text = "Update Supplier";
            btnUpdateSupplier.UseVisualStyleBackColor = true;
            btnUpdateSupplier.Click += btnUpdateSupplier_Click_1;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddSupplier.Location = new Point(3, 279);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(91, 32);
            btnAddSupplier.TabIndex = 6;
            btnAddSupplier.Text = "Add Supplier";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += button1_Click;
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(3, 30);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(303, 23);
            txtSupplierId.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 4;
            label2.Text = "Supplier ID";
            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(5, 138);
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(303, 23);
            txtContactInfo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(5, 116);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 2;
            label1.Text = "Contact Info";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(5, 84);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(303, 23);
            txtSupplierName.TabIndex = 1;
            // 
            // txtSupplierNamelbl
            // 
            txtSupplierNamelbl.AutoSize = true;
            txtSupplierNamelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtSupplierNamelbl.Location = new Point(5, 59);
            txtSupplierNamelbl.Name = "txtSupplierNamelbl";
            txtSupplierNamelbl.Size = new Size(124, 21);
            txtSupplierNamelbl.TabIndex = 0;
            txtSupplierNamelbl.Text = "Supplier Name";
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Location = new Point(325, 49);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.Size = new Size(474, 395);
            dataGridViewSuppliers.TabIndex = 0;
            dataGridViewSuppliers.CellClick += dataGridViewSuppliers_CellClick;
            dataGridViewSuppliers.CellContentClick += dataGridViewSuppliers_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(687, 9);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 3;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(6, 14);
            label5.Name = "label5";
            label5.Size = new Size(240, 23);
            label5.TabIndex = 16;
            label5.Text = "Supplier & Orders Management";
            // 
            // SupplierManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "SupplierManagementForm";
            Text = "SupplierManagementForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewSuppliers;
        private Panel panel2;
        private Label txtSupplierNamelbl;
        private TextBox txtSupplierName;
        private Label label1;
        private TextBox txtContactInfo;
        private TextBox txtSupplierId;
        private Label label2;
        private Button btnAddSupplier;
        private Button btnDeleteSupplier;
        private Button btnUpdateSupplier;
        private ComboBox cmbBooks;
        private Label label3;
        private TextBox txtQuantity;
        private Label label4;
        private Button btnCreateOrder;
        private Label txtPricelbl;
        private TextBox txtPrice;
        private Label label5;
        private Button button1;
    }
}