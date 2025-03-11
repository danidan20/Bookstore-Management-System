namespace BookHaven_Bookstore_Management_System.View.CommonModules
{
    partial class CommonModuleBook
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
            btn_clear = new Button();
            txtQuantity = new TextBox();
            label5 = new Label();
            txtISBN = new TextBox();
            label4 = new Label();
            txtAuthor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            cus_delete = new Button();
            panel2 = new Panel();
            comboGenre = new ComboBox();
            txtPrice = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtBookId = new TextBox();
            cus_update = new Button();
            cus_save = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            book_search_key = new TextBox();
            cus_search = new Button();
            panel3 = new Panel();
            dataGridViewBooks = new DataGridView();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_clear.Location = new Point(7, 392);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(137, 31);
            btn_clear.TabIndex = 16;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click_1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(5, 237);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(289, 23);
            txtQuantity.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(3, 215);
            label5.Name = "label5";
            label5.Size = new Size(66, 19);
            label5.TabIndex = 14;
            label5.Text = "Quantity";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(3, 188);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(289, 23);
            txtISBN.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(5, 166);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 12;
            label4.Text = "ISBN";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(3, 134);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(289, 23);
            txtAuthor.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(3, 112);
            label3.Name = "label3";
            label3.Size = new Size(94, 19);
            label3.TabIndex = 10;
            label3.Text = "Book Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(3, 60);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 9;
            label2.Text = "Book Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(3, 82);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(289, 23);
            txtTitle.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 7;
            label1.Text = "Book ID";
            // 
            // cus_delete
            // 
            cus_delete.BackColor = SystemColors.MenuText;
            cus_delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cus_delete.ForeColor = SystemColors.ButtonFace;
            cus_delete.Location = new Point(199, 359);
            cus_delete.Name = "cus_delete";
            cus_delete.Size = new Size(93, 31);
            cus_delete.TabIndex = 5;
            cus_delete.Text = "Delete";
            cus_delete.UseVisualStyleBackColor = false;
            cus_delete.Click += cus_delete_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboGenre);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btn_clear);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtISBN);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTitle);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtBookId);
            panel2.Controls.Add(cus_delete);
            panel2.Controls.Add(cus_update);
            panel2.Controls.Add(cus_save);
            panel2.Location = new Point(11, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 426);
            panel2.TabIndex = 1;
            // 
            // comboGenre
            // 
            comboGenre.FormattingEnabled = true;
            comboGenre.Location = new Point(6, 289);
            comboGenre.Name = "comboGenre";
            comboGenre.Size = new Size(285, 23);
            comboGenre.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(4, 335);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(289, 23);
            txtPrice.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(2, 313);
            label8.Name = "label8";
            label8.Size = new Size(43, 19);
            label8.TabIndex = 19;
            label8.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(2, 266);
            label7.Name = "label7";
            label7.Size = new Size(49, 19);
            label7.TabIndex = 17;
            label7.Text = "Genre";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(3, 32);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(289, 23);
            txtBookId.TabIndex = 6;
            // 
            // cus_update
            // 
            cus_update.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cus_update.Location = new Point(104, 359);
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
            cus_save.Location = new Point(7, 359);
            cus_save.Name = "cus_save";
            cus_save.Size = new Size(93, 31);
            cus_save.TabIndex = 4;
            cus_save.Text = "Save";
            cus_save.UseVisualStyleBackColor = true;
            cus_save.Click += cus_save_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 451);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Controls.Add(book_search_key);
            panel4.Controls.Add(cus_search);
            panel4.Location = new Point(314, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(436, 37);
            panel4.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(3, 11);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 8;
            label6.Text = "Inventory";
            // 
            // book_search_key
            // 
            book_search_key.Location = new Point(147, 7);
            book_search_key.Name = "book_search_key";
            book_search_key.Size = new Size(178, 23);
            book_search_key.TabIndex = 3;
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
            panel3.Controls.Add(dataGridViewBooks);
            panel3.Location = new Point(312, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 383);
            panel3.TabIndex = 2;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(3, -1);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.Size = new Size(430, 381);
            dataGridViewBooks.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(150, 392);
            button1.Name = "button1";
            button1.Size = new Size(141, 31);
            button1.TabIndex = 22;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StaffBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "StaffBook";
            Text = "StaffInventory";
            Load += StaffBook_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_clear;
        private TextBox txtQuantity;
        private Label label5;
        private TextBox txtISBN;
        private Label label4;
        private TextBox txtAuthor;
        private Label label3;
        private Label label2;
        private TextBox txtTitle;
        private Label label1;
        private Button cus_delete;
        private Panel panel2;
        private TextBox txtBookId;
        private Button cus_update;
        private Button cus_save;
        private Panel panel1;
        private Panel panel4;
        private TextBox book_search_key;
        private Button cus_search;
        private Panel panel3;
        private DataGridView dataGridViewBooks;
        private Label label6;
        private Label label7;
        private TextBox txtPrice;
        private Label label8;
        private ComboBox comboGenre;
        private Button button1;
    }
}