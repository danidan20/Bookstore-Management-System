namespace BookHaven_Bookstore_Management_System.View.Admin
{
    partial class UserManagementForm
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
            panel3 = new Panel();
            txtPassword = new TextBox();
            label5 = new Label();
            btnClear = new Button();
            btnDeleteUser = new Button();
            btnUpdateUser = new Button();
            btnAddUser = new Button();
            comboRole = new ComboBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtRealName = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            lable3 = new Label();
            panel2 = new Panel();
            dataGridViewUsers = new DataGridView();
            txtUserID = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 448);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnDeleteUser);
            panel3.Controls.Add(btnUpdateUser);
            panel3.Controls.Add(btnAddUser);
            panel3.Controls.Add(comboRole);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtRealName);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lable3);
            panel3.Controls.Add(txtUserID);
            panel3.Location = new Point(3, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(373, 399);
            panel3.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(5, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(362, 23);
            txtPassword.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(5, 213);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 14;
            label5.Text = "Password";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.Location = new Point(8, 365);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(359, 31);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeleteUser.Location = new Point(240, 323);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(130, 36);
            btnDeleteUser.TabIndex = 12;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click_1;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdateUser.Location = new Point(104, 323);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(130, 36);
            btnUpdateUser.TabIndex = 11;
            btnUpdateUser.Text = "Update User";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click_1;
            // 
            // btnAddUser
            // 
            btnAddUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddUser.Location = new Point(8, 323);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(90, 36);
            btnAddUser.TabIndex = 10;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click_1;
            // 
            // comboRole
            // 
            comboRole.FormattingEnabled = true;
            comboRole.Location = new Point(8, 292);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(359, 23);
            comboRole.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(5, 268);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 8;
            label4.Text = "User Role";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(5, 182);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(362, 23);
            txtEmail.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(5, 158);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // txtRealName
            // 
            txtRealName.Location = new Point(5, 131);
            txtRealName.Name = "txtRealName";
            txtRealName.Size = new Size(362, 23);
            txtRealName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(5, 107);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 4;
            label2.Text = "Real Name";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(8, 80);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(362, 23);
            txtUsername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(8, 56);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // lable3
            // 
            lable3.AutoSize = true;
            lable3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lable3.Location = new Point(5, 4);
            lable3.Name = "lable3";
            lable3.Size = new Size(63, 21);
            lable3.TabIndex = 1;
            lable3.Text = "User Id";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewUsers);
            panel2.Location = new Point(379, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 402);
            panel2.TabIndex = 0;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(3, 3);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(413, 396);
            dataGridViewUsers.TabIndex = 0;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(8, 30);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(362, 23);
            txtUserID.TabIndex = 0;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewUsers;
        private Panel panel3;
        private Label lable3;
        private TextBox txtUsername;
        private Label label1;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtRealName;
        private Label label2;
        private ComboBox comboRole;
        private Button btnUpdateUser;
        private Button btnAddUser;
        private Button btnDeleteUser;
        private Button btnClear;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtUserID;
    }
}