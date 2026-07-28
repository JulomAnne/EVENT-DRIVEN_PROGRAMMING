namespace WinFormsApp1
{
    partial class DashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OtherHeader = new Panel();
            label1 = new Label();
            lblTitle = new Label();
            panel1 = new Panel();
            btnLogout = new Button();
            btnReports = new Button();
            btnCustomers = new Button();
            btnSales = new Button();
            btnProducts = new Button();
            btnDashboard = new Button();
            OtherHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // OtherHeader
            // 
            OtherHeader.BackColor = Color.DarkSeaGreen;
            OtherHeader.Controls.Add(label1);
            OtherHeader.Controls.Add(lblTitle);
            OtherHeader.Location = new Point(12, 9);
            OtherHeader.Name = "OtherHeader";
            OtherHeader.Size = new Size(469, 84);
            OtherHeader.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 55);
            label1.Name = "label1";
            label1.Size = new Size(215, 17);
            label1.TabIndex = 7;
            label1.Text = "Welcome, Administrator!";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("PMingLiU-ExtB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(72, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(324, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "POINT OF SALE SYSTEM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(btnSales);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnDashboard);
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(107, 336);
            panel1.TabIndex = 7;
            // 
            // btnLogout
            // 
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.BackColor = Color.Gray;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Romantic", 12F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnLogout.Location = new Point(11, 286);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(85, 33);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReports.BackColor = Color.DarkGray;
            btnReports.FlatStyle = FlatStyle.Popup;
            btnReports.Font = new Font("Romantic", 12F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnReports.Location = new Point(11, 229);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(85, 33);
            btnReports.TabIndex = 9;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            btnCustomers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCustomers.BackColor = Color.Silver;
            btnCustomers.FlatStyle = FlatStyle.Popup;
            btnCustomers.Font = new Font("Romantic", 12F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnCustomers.Location = new Point(11, 173);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(85, 33);
            btnCustomers.TabIndex = 9;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnSales
            // 
            btnSales.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSales.BackColor = Color.Gainsboro;
            btnSales.FlatStyle = FlatStyle.Popup;
            btnSales.Font = new Font("Romantic", 12F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnSales.Location = new Point(11, 119);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(85, 33);
            btnSales.TabIndex = 9;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProducts.BackColor = Color.WhiteSmoke;
            btnProducts.FlatStyle = FlatStyle.Popup;
            btnProducts.Font = new Font("Romantic", 12F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnProducts.Location = new Point(11, 66);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(85, 33);
            btnProducts.TabIndex = 9;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDashboard.BackColor = SystemColors.ButtonHighlight;
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Romantic", 12F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnDashboard.Location = new Point(11, 12);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(85, 33);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(493, 450);
            Controls.Add(panel1);
            Controls.Add(OtherHeader);
            Name = "DashboardForm";
            Text = "Form1";
            Load += Form1_Load;
            OtherHeader.ResumeLayout(false);
            OtherHeader.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel OtherHeader;
        private Label lblTitle;
        private Label label1;
        private Panel panel1;
        private Button btnProducts;
        private Button btnDashboard;
        private Button btnSales;
        private Button btnLogout;
        private Button btnReports;
        private Button btnCustomers;
    }
}
