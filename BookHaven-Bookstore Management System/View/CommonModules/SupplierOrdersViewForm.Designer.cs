namespace BookHaven_Bookstore_Management_System.View.CommonModules
{
    partial class SupplierOrdersViewForm
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
            label2 = new Label();
            label1 = new Label();
            btnUpdateDetails = new Button();
            txtFilterSupplier = new TextBox();
            cmbFilterStatus = new ComboBox();
            dataGridViewOrders = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridViewOrders);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 452);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnUpdateDetails);
            panel2.Controls.Add(txtFilterSupplier);
            panel2.Controls.Add(cmbFilterStatus);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(792, 64);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(241, 14);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 4;
            label2.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 3;
            label1.Text = "Order Status";
            // 
            // btnUpdateDetails
            // 
            btnUpdateDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdateDetails.Location = new Point(617, 17);
            btnUpdateDetails.Name = "btnUpdateDetails";
            btnUpdateDetails.Size = new Size(160, 34);
            btnUpdateDetails.TabIndex = 2;
            btnUpdateDetails.Text = "Update Details";
            btnUpdateDetails.UseVisualStyleBackColor = true;
            btnUpdateDetails.Click += btnUpdateDetails_Click_1;
            // 
            // txtFilterSupplier
            // 
            txtFilterSupplier.Location = new Point(238, 38);
            txtFilterSupplier.Name = "txtFilterSupplier";
            txtFilterSupplier.Size = new Size(161, 23);
            txtFilterSupplier.TabIndex = 1;
            txtFilterSupplier.TextChanged += txtFilterSupplier_TextChanged;
            // 
            // cmbFilterStatus
            // 
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.Location = new Point(8, 38);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(193, 23);
            cmbFilterStatus.TabIndex = 0;
            cmbFilterStatus.SelectedIndexChanged += cmbFilterStatus_SelectedIndexChanged;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(3, 73);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(792, 376);
            dataGridViewOrders.TabIndex = 0;
            // 
            // SupplierOrdersViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "SupplierOrdersViewForm";
            Text = "SupplierOrdersViewForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewOrders;
        private ComboBox cmbFilterStatus;
        private TextBox txtFilterSupplier;
        private Button btnUpdateDetails;
        private Label label2;
        private Label label1;
    }
}