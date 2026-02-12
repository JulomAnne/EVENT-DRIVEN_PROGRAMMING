namespace Simple_Lambda
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Shadow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Message
            // 
            this.txt_Message.BackColor = System.Drawing.Color.Cornsilk;
            this.txt_Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Message.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_Message.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Message.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_Message.Location = new System.Drawing.Point(115, 192);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.ReadOnly = true;
            this.txt_Message.Size = new System.Drawing.Size(167, 48);
            this.txt_Message.TabIndex = 24;
            this.txt_Message.Text = "In Progress...";
            this.txt_Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.Color.Cornsilk;
            this.txt_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txt_Quantity.Location = new System.Drawing.Point(115, 137);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(167, 32);
            this.txt_Quantity.TabIndex = 21;
            this.txt_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Header.Font = new System.Drawing.Font("Bodoni MT", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.LightCoral;
            this.lbl_Header.Location = new System.Drawing.Point(0, 32);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lbl_Header.Size = new System.Drawing.Size(413, 42);
            this.lbl_Header.TabIndex = 23;
            this.lbl_Header.Text = "Order Checker";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_CheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CheckOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut.ForeColor = System.Drawing.Color.Chocolate;
            this.btn_CheckOut.Location = new System.Drawing.Point(209, 259);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(167, 48);
            this.btn_CheckOut.TabIndex = 20;
            this.btn_CheckOut.Text = "Check Order";
            this.btn_CheckOut.UseVisualStyleBackColor = false;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Quantity.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Quantity.ForeColor = System.Drawing.Color.MistyRose;
            this.lbl_Quantity.Location = new System.Drawing.Point(148, 123);
            this.lbl_Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(112, 29);
            this.lbl_Quantity.TabIndex = 25;
            this.lbl_Quantity.Text = "Quantity:";
            // 
            // lbl_Shadow
            // 
            this.lbl_Shadow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Shadow.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Shadow.Font = new System.Drawing.Font("Bodoni MT", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shadow.ForeColor = System.Drawing.Color.MistyRose;
            this.lbl_Shadow.Location = new System.Drawing.Point(0, 0);
            this.lbl_Shadow.Name = "lbl_Shadow";
            this.lbl_Shadow.Padding = new System.Windows.Forms.Padding(8, 32, 0, 0);
            this.lbl_Shadow.Size = new System.Drawing.Size(413, 94);
            this.lbl_Shadow.TabIndex = 26;
            this.lbl_Shadow.Text = "Order Checker";
            this.lbl_Shadow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 345);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.btn_CheckOut);
            this.Controls.Add(this.lbl_Shadow);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Shadow;
    }
}

