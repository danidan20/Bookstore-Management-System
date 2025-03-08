namespace BookHaven_Bookstore_Management_System.View.Staff
{
    partial class StaffCustomers
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
            panel4 = new Panel();
            cus_search_key = new TextBox();
            cus_search = new Button();
            panel3 = new Panel();
            customer_table = new DataGridView();
            panel2 = new Panel();
            btn_clear = new Button();
            cust_phonenumber = new TextBox();
            label5 = new Label();
            cust_email = new TextBox();
            label4 = new Label();
            cust_lastname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cust_firstname = new TextBox();
            label1 = new Label();
            cust_id = new TextBox();
            cus_delete = new Button();
            cus_update = new Button();
            cus_save = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customer_table).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 451);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Controls.Add(cus_search_key);
            panel4.Controls.Add(cus_search);
            panel4.Location = new Point(314, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(436, 37);
            panel4.TabIndex = 3;
            // 
            // cus_search_key
            // 
            cus_search_key.Location = new Point(147, 7);
            cus_search_key.Name = "cus_search_key";
            cus_search_key.Size = new Size(178, 23);
            cus_search_key.TabIndex = 3;
            // 
            // cus_search
            // 
            cus_search.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cus_search.Location = new Point(331, 4);
            cus_search.Name = "cus_search";
            cus_search.Size = new Size(93, 31);
            cus_search.TabIndex = 6;
            cus_search.Text = "Search";
            cus_search.UseVisualStyleBackColor = true;
            cus_search.Click += cus_search_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(customer_table);
            panel3.Location = new Point(312, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 383);
            panel3.TabIndex = 2;
            // 
            // customer_table
            // 
            customer_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customer_table.Location = new Point(3, -1);
            customer_table.Name = "customer_table";
            customer_table.Size = new Size(430, 381);
            customer_table.TabIndex = 0;
            customer_table.CellContentClick += customer_table_CellContentClick_1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(btn_clear);
            panel2.Controls.Add(cust_phonenumber);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cust_email);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cust_lastname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cust_firstname);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cust_id);
            panel2.Controls.Add(cus_delete);
            panel2.Controls.Add(cus_update);
            panel2.Controls.Add(cus_save);
            panel2.Location = new Point(11, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 426);
            panel2.TabIndex = 1;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_clear.Location = new Point(7, 389);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(285, 31);
            btn_clear.TabIndex = 16;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // cust_phonenumber
            // 
            cust_phonenumber.Location = new Point(5, 275);
            cust_phonenumber.Name = "cust_phonenumber";
            cust_phonenumber.Size = new Size(289, 23);
            cust_phonenumber.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(3, 253);
            label5.Name = "label5";
            label5.Size = new Size(110, 19);
            label5.TabIndex = 14;
            label5.Text = "Phone Number";
            // 
            // cust_email
            // 
            cust_email.Location = new Point(3, 214);
            cust_email.Name = "cust_email";
            cust_email.Size = new Size(289, 23);
            cust_email.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(5, 192);
            label4.Name = "label4";
            label4.Size = new Size(45, 19);
            label4.TabIndex = 12;
            label4.Text = "Email";
            // 
            // cust_lastname
            // 
            cust_lastname.Location = new Point(3, 153);
            cust_lastname.Name = "cust_lastname";
            cust_lastname.Size = new Size(289, 23);
            cust_lastname.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(3, 131);
            label3.Name = "label3";
            label3.Size = new Size(144, 19);
            label3.TabIndex = 10;
            label3.Text = "Customer Last name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(3, 70);
            label2.Name = "label2";
            label2.Size = new Size(146, 19);
            label2.TabIndex = 9;
            label2.Text = "Customer First name";
            // 
            // cust_firstname
            // 
            cust_firstname.Location = new Point(3, 92);
            cust_firstname.Name = "cust_firstname";
            cust_firstname.Size = new Size(289, 23);
            cust_firstname.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 7;
            label1.Text = "Customer ID";
            // 
            // cust_id
            // 
            cust_id.Location = new Point(3, 32);
            cust_id.Name = "cust_id";
            cust_id.Size = new Size(289, 23);
            cust_id.TabIndex = 6;
            // 
            // cus_delete
            // 
            cus_delete.BackColor = SystemColors.MenuText;
            cus_delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cus_delete.ForeColor = SystemColors.ButtonFace;
            cus_delete.Location = new Point(199, 352);
            cus_delete.Name = "cus_delete";
            cus_delete.Size = new Size(93, 31);
            cus_delete.TabIndex = 5;
            cus_delete.Text = "Delete";
            cus_delete.UseVisualStyleBackColor = false;
            cus_delete.Click += cus_delete_Click;
            // 
            // cus_update
            // 
            cus_update.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cus_update.Location = new Point(104, 352);
            cus_update.Name = "cus_update";
            cus_update.Size = new Size(90, 31);
            cus_update.TabIndex = 3;
            cus_update.Text = "Update";
            cus_update.UseVisualStyleBackColor = true;
            cus_update.Click += cus_update_Click;
            // 
            // cus_save
            // 
            cus_save.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cus_save.Location = new Point(7, 352);
            cus_save.Name = "cus_save";
            cus_save.Size = new Size(93, 31);
            cus_save.TabIndex = 4;
            cus_save.Text = "Save";
            cus_save.UseVisualStyleBackColor = true;
            cus_save.Click += cus_save_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(1, 7);
            label6.Name = "label6";
            label6.Size = new Size(140, 21);
            label6.TabIndex = 7;
            label6.Text = "Customer Details";
            // 
            // StaffCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 450);
            Controls.Add(panel1);
            Name = "StaffCustomers";
            Text = "StaffCustomers";
            Load += StaffCustomers_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customer_table).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button cus_update;
        private Button cus_save;
        private Button cus_delete;
        private HScrollBar cus_scroll_bar;
        private Panel panel3;
        private DataGridView customer_table;
        private Button cus_search;
        private TextBox cus_search_key;
        private Panel panel4;
        private Label label1;
        private TextBox cust_id;
        private TextBox cust_firstname;
        private Label label2;
        private Label label4;
        private TextBox cust_lastname;
        private Label label3;
        private TextBox cust_email;
        private Label label5;
        private TextBox cust_phonenumber;
        private Button btn_clear;
        private Label label6;
    }
}