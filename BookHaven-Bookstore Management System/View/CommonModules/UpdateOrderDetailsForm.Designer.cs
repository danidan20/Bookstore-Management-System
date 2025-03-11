namespace BookHaven_Bookstore_Management_System.View.CommonModules
{
    partial class UpdateOrderDetailsForm
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            btnDeleteItem = new Button();
            btnUpdateItem = new Button();
            btnAddItem = new Button();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            cmbBook = new ComboBox();
            cmbOrderStatus = new ComboBox();
            dataGridViewOrderItems = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridViewOrderItems);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 453);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnDeleteItem);
            panel2.Controls.Add(btnUpdateItem);
            panel2.Controls.Add(btnAddItem);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(cmbBook);
            panel2.Controls.Add(cmbOrderStatus);
            panel2.Location = new Point(7, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(789, 196);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(623, 12);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 12;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(371, 12);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 11;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(176, 12);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 10;
            label2.Text = "Book";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 9;
            label1.Text = "Status";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.Location = new Point(380, 159);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 34);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.Location = new Point(164, 159);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeleteItem.Location = new Point(371, 88);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(160, 34);
            btnDeleteItem.TabIndex = 6;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdateItem.Location = new Point(176, 88);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(181, 34);
            btnUpdateItem.TabIndex = 5;
            btnUpdateItem.Text = "Update Item";
            btnUpdateItem.UseVisualStyleBackColor = true;
            btnUpdateItem.Click += btnUpdateItem_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddItem.Location = new Point(6, 88);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(160, 34);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(623, 36);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(159, 23);
            txtPrice.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(371, 36);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(225, 23);
            txtQuantity.TabIndex = 2;
            // 
            // cmbBook
            // 
            cmbBook.FormattingEnabled = true;
            cmbBook.Location = new Point(176, 36);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(181, 23);
            cmbBook.TabIndex = 1;
            // 
            // cmbOrderStatus
            // 
            cmbOrderStatus.FormattingEnabled = true;
            cmbOrderStatus.Location = new Point(6, 36);
            cmbOrderStatus.Name = "cmbOrderStatus";
            cmbOrderStatus.Size = new Size(159, 23);
            cmbOrderStatus.TabIndex = 0;
            // 
            // dataGridViewOrderItems
            // 
            dataGridViewOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderItems.Location = new Point(7, 214);
            dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            dataGridViewOrderItems.Size = new Size(789, 231);
            dataGridViewOrderItems.TabIndex = 0;
            // 
            // UpdateOrderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "UpdateOrderDetailsForm";
            Text = "UpdateOrderDetailsForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewOrderItems;
        private Panel panel2;
        private ComboBox cmbBook;
        private ComboBox cmbOrderStatus;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button btnUpdateItem;
        private Button btnAddItem;
        private Button btnDeleteItem;
        private Button btnCancel;
        private Button btnSave;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
    }
}