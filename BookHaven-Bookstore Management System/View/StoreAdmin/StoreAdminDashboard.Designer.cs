namespace BookHaven_Bookstore_Management_System.View.StoreAdmin
{
    partial class StoreAdminDashboard
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
            panel6 = new Panel();
            lblCompletedOrders = new Label();
            panel5 = new Panel();
            lblPendingOrders = new Label();
            panel4 = new Panel();
            lblTotalSuppliers = new Label();
            panel3 = new Panel();
            lblLowStockBooks = new Label();
            panel2 = new Panel();
            lblTotalBooks = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 444);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDark;
            panel6.Controls.Add(lblCompletedOrders);
            panel6.Location = new Point(11, 220);
            panel6.Name = "panel6";
            panel6.Size = new Size(331, 69);
            panel6.TabIndex = 2;
            // 
            // lblCompletedOrders
            // 
            lblCompletedOrders.AutoSize = true;
            lblCompletedOrders.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCompletedOrders.Location = new Point(14, 19);
            lblCompletedOrders.Name = "lblCompletedOrders";
            lblCompletedOrders.Size = new Size(70, 28);
            lblCompletedOrders.TabIndex = 0;
            lblCompletedOrders.Text = "label1";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.Controls.Add(lblPendingOrders);
            panel5.Location = new Point(384, 120);
            panel5.Name = "panel5";
            panel5.Size = new Size(331, 69);
            panel5.TabIndex = 2;
            // 
            // lblPendingOrders
            // 
            lblPendingOrders.AutoSize = true;
            lblPendingOrders.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblPendingOrders.Location = new Point(14, 19);
            lblPendingOrders.Name = "lblPendingOrders";
            lblPendingOrders.Size = new Size(70, 28);
            lblPendingOrders.TabIndex = 0;
            lblPendingOrders.Text = "label1";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Controls.Add(lblTotalSuppliers);
            panel4.Location = new Point(11, 120);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 69);
            panel4.TabIndex = 1;
            // 
            // lblTotalSuppliers
            // 
            lblTotalSuppliers.AutoSize = true;
            lblTotalSuppliers.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotalSuppliers.Location = new Point(14, 19);
            lblTotalSuppliers.Name = "lblTotalSuppliers";
            lblTotalSuppliers.Size = new Size(70, 28);
            lblTotalSuppliers.TabIndex = 0;
            lblTotalSuppliers.Text = "label1";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(lblLowStockBooks);
            panel3.Location = new Point(384, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 69);
            panel3.TabIndex = 1;
            // 
            // lblLowStockBooks
            // 
            lblLowStockBooks.AutoSize = true;
            lblLowStockBooks.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblLowStockBooks.Location = new Point(14, 19);
            lblLowStockBooks.Name = "lblLowStockBooks";
            lblLowStockBooks.Size = new Size(70, 28);
            lblLowStockBooks.TabIndex = 0;
            lblLowStockBooks.Text = "label1";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(lblTotalBooks);
            panel2.Location = new Point(11, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(331, 69);
            panel2.TabIndex = 0;
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.AutoSize = true;
            lblTotalBooks.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotalBooks.Location = new Point(14, 19);
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(70, 28);
            lblTotalBooks.TabIndex = 0;
            lblTotalBooks.Text = "label1";
            // 
            // StoreAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "StoreAdminDashboard";
            Text = "StoreAdminDashboard";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblTotalBooks;
        private Panel panel3;
        private Label lblLowStockBooks;
        private Panel panel4;
        private Label lblTotalSuppliers;
        private Panel panel5;
        private Label lblPendingOrders;
        private Panel panel6;
        private Label lblCompletedOrders;
    }
}