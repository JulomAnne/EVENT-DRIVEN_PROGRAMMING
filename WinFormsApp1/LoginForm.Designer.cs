namespace WinFormsApp1
{
    partial class LoginForm
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
            lblTitle = new Label();
            lblUsername = new Label();
            lblPass = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            GreenHeader = new Panel();
            btnLogin = new Button();
            lblInfo = new Label();
            GreenHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("PMingLiU-ExtB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(90, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(275, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "POS LOG IN SYSTEM";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(117, 147);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.Location = new Point(117, 212);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(86, 20);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(117, 170);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(237, 29);
            txtUser.TabIndex = 3;
            txtUser.Text = "###@gmail.com";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(117, 235);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(237, 29);
            txtPass.TabIndex = 4;
            // 
            // GreenHeader
            // 
            GreenHeader.BackColor = Color.MediumSeaGreen;
            GreenHeader.BorderStyle = BorderStyle.FixedSingle;
            GreenHeader.Controls.Add(lblTitle);
            GreenHeader.Location = new Point(12, 12);
            GreenHeader.Name = "GreenHeader";
            GreenHeader.Size = new Size(469, 66);
            GreenHeader.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Khaki;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("EuroRoman", 12F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnLogin.Location = new Point(273, 304);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(81, 35);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.FlatStyle = FlatStyle.Flat;
            lblInfo.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.IndianRed;
            lblInfo.ImageAlign = ContentAlignment.MiddleLeft;
            lblInfo.Location = new Point(117, 271);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 16);
            lblInfo.TabIndex = 7;
            lblInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(493, 450);
            Controls.Add(lblInfo);
            Controls.Add(btnLogin);
            Controls.Add(GreenHeader);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblPass);
            Controls.Add(lblUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            GreenHeader.ResumeLayout(false);
            GreenHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private Panel GreenHeader;
        private Button btnLogin;
        private Label lblInfo;
    }
}