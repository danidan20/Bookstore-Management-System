namespace BookHaven_Bookstore_Management_System.View.Admin
{
    partial class ReportingAnalyticsForm
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
            btnGenerateReport = new Button();
            cmbReportType = new ComboBox();
            sd = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dataGridViewReport = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGenerateReport);
            panel1.Controls.Add(cmbReportType);
            panel1.Controls.Add(sd);
            panel1.Controls.Add(dtpEndDate);
            panel1.Controls.Add(dtpStartDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 449);
            panel1.TabIndex = 0;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGenerateReport.Location = new Point(10, 242);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(344, 35);
            btnGenerateReport.TabIndex = 7;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(10, 191);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(344, 23);
            cmbReportType.TabIndex = 6;
            // 
            // sd
            // 
            sd.AutoSize = true;
            sd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            sd.Location = new Point(10, 160);
            sd.Name = "sd";
            sd.Size = new Size(101, 21);
            sd.TabIndex = 5;
            sd.Text = "Report Type";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(10, 116);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(344, 23);
            dtpEndDate.TabIndex = 4;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(10, 44);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(344, 23);
            dtpStartDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(10, 85);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "End Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 1;
            label1.Text = "Start Date";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewReport);
            panel2.Location = new Point(360, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 435);
            panel2.TabIndex = 0;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Location = new Point(3, 3);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.Size = new Size(428, 432);
            dataGridViewReport.TabIndex = 0;
            // 
            // ReportingAnalyticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ReportingAnalyticsForm";
            Text = "ReportingAnalyticsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewReport;
        private DateTimePicker dtpStartDate;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpEndDate;
        private ComboBox cmbReportType;
        private Label sd;
        private Button btnGenerateReport;
    }
}