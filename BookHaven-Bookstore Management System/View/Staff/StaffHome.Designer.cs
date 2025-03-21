﻿namespace BookHaven_Bookstore_Management_System.View.Staff
{
    partial class StaffHome
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
            staffPanelInject = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(staffPanelInject);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 524);
            panel1.TabIndex = 0;
            // 
            // staffPanelInject
            // 
            staffPanelInject.Location = new Point(206, 40);
            staffPanelInject.Name = "staffPanelInject";
            staffPanelInject.Size = new Size(787, 481);
            staffPanelInject.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Menu;
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Location = new Point(3, 37);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 484);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 41);
            panel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.Location = new Point(0, 3);
            button1.Name = "button1";
            button1.Size = new Size(194, 35);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button2.Location = new Point(3, 50);
            button2.Name = "button2";
            button2.Size = new Size(194, 35);
            button2.TabIndex = 1;
            button2.Text = "Orders";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button3.Location = new Point(3, 91);
            button3.Name = "button3";
            button3.Size = new Size(194, 35);
            button3.TabIndex = 2;
            button3.Text = "Customers";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button4.Location = new Point(3, 132);
            button4.Name = "button4";
            button4.Size = new Size(194, 35);
            button4.TabIndex = 3;
            button4.Text = "Books";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button5.Location = new Point(3, 173);
            button5.Name = "button5";
            button5.Size = new Size(194, 35);
            button5.TabIndex = 4;
            button5.Text = "POS";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button6.Location = new Point(3, 214);
            button6.Name = "button6";
            button6.Size = new Size(194, 35);
            button6.TabIndex = 5;
            button6.Text = "Log out";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 34);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(4, 2);
            label1.Name = "label1";
            label1.Size = new Size(186, 28);
            label1.TabIndex = 0;
            label1.Text = "BookHaven - Staff";
            // 
            // StaffHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 525);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StaffHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffHome";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel staffPanelInject;
    }
}