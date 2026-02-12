namespace Cafe_Menu
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
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.chk_Cappuccino = new System.Windows.Forms.CheckBox();
            this.chk_Mocha = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chk_Espresso = new System.Windows.Forms.CheckBox();
            this.chk_Americano = new System.Windows.Forms.CheckBox();
            this.chk_Latte = new System.Windows.Forms.CheckBox();
            this.chk_Coffee = new System.Windows.Forms.CheckBox();
            this.chk_Frappe = new System.Windows.Forms.CheckBox();
            this.rdb_DineIN = new System.Windows.Forms.RadioButton();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.rdb_takeOUT = new System.Windows.Forms.RadioButton();
            this.txt_Message = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_CheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CheckOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_CheckOut.Location = new System.Drawing.Point(341, 298);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(167, 48);
            this.btn_CheckOut.TabIndex = 0;
            this.btn_CheckOut.Text = "Check Order";
            this.btn_CheckOut.UseVisualStyleBackColor = false;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.Color.Cornsilk;
            this.txt_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.ForeColor = System.Drawing.Color.DeepPink;
            this.txt_Quantity.Location = new System.Drawing.Point(341, 124);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(167, 26);
            this.txt_Quantity.TabIndex = 1;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Quantity.Location = new System.Drawing.Point(337, 99);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(94, 24);
            this.lbl_Quantity.TabIndex = 2;
            this.lbl_Quantity.Text = "Quantity:";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbl_Header.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Header.Location = new System.Drawing.Point(9, 6);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(392, 54);
            this.lbl_Header.TabIndex = 3;
            this.lbl_Header.Text = "Order Checker";
            // 
            // chk_Cappuccino
            // 
            this.chk_Cappuccino.AutoSize = true;
            this.chk_Cappuccino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_Cappuccino.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Cappuccino.ForeColor = System.Drawing.Color.DeepPink;
            this.chk_Cappuccino.Location = new System.Drawing.Point(99, 216);
            this.chk_Cappuccino.Name = "chk_Cappuccino";
            this.chk_Cappuccino.Size = new System.Drawing.Size(147, 27);
            this.chk_Cappuccino.TabIndex = 4;
            this.chk_Cappuccino.Text = "Cappuccino";
            this.chk_Cappuccino.UseVisualStyleBackColor = true;
            // 
            // chk_Mocha
            // 
            this.chk_Mocha.AutoSize = true;
            this.chk_Mocha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_Mocha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Mocha.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.chk_Mocha.Location = new System.Drawing.Point(99, 151);
            this.chk_Mocha.Name = "chk_Mocha";
            this.chk_Mocha.Size = new System.Drawing.Size(94, 27);
            this.chk_Mocha.TabIndex = 5;
            this.chk_Mocha.Text = "Mocha";
            this.chk_Mocha.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "Drinks";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // chk_Espresso
            // 
            this.chk_Espresso.AutoSize = true;
            this.chk_Espresso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_Espresso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Espresso.ForeColor = System.Drawing.Color.MediumOrchid;
            this.chk_Espresso.Location = new System.Drawing.Point(99, 118);
            this.chk_Espresso.Name = "chk_Espresso";
            this.chk_Espresso.Size = new System.Drawing.Size(121, 27);
            this.chk_Espresso.TabIndex = 10;
            this.chk_Espresso.Text = "Espresso";
            this.chk_Espresso.UseVisualStyleBackColor = true;
            // 
            // chk_Americano
            // 
            this.chk_Americano.AutoSize = true;
            this.chk_Americano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_Americano.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Americano.ForeColor = System.Drawing.Color.Crimson;
            this.chk_Americano.Location = new System.Drawing.Point(99, 183);
            this.chk_Americano.Name = "chk_Americano";
            this.chk_Americano.Size = new System.Drawing.Size(135, 27);
            this.chk_Americano.TabIndex = 11;
            this.chk_Americano.Text = "Americano";
            this.chk_Americano.UseVisualStyleBackColor = true;
            // 
            // chk_Latte
            // 
            this.chk_Latte.AutoSize = true;
            this.chk_Latte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_Latte.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Latte.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.chk_Latte.Location = new System.Drawing.Point(99, 283);
            this.chk_Latte.Name = "chk_Latte";
            this.chk_Latte.Size = new System.Drawing.Size(127, 27);
            this.chk_Latte.TabIndex = 12;
            this.chk_Latte.Text = "Iced Latte";
            this.chk_Latte.UseVisualStyleBackColor = true;
            // 
            // chk_Coffee
            // 
            this.chk_Coffee.AutoSize = true;
            this.chk_Coffee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_Coffee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Coffee.ForeColor = System.Drawing.Color.Magenta;
            this.chk_Coffee.Location = new System.Drawing.Point(99, 250);
            this.chk_Coffee.Name = "chk_Coffee";
            this.chk_Coffee.Size = new System.Drawing.Size(129, 27);
            this.chk_Coffee.TabIndex = 13;
            this.chk_Coffee.Text = "Ice Coffee";
            this.chk_Coffee.UseVisualStyleBackColor = true;
            // 
            // chk_Frappe
            // 
            this.chk_Frappe.AutoSize = true;
            this.chk_Frappe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_Frappe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Frappe.ForeColor = System.Drawing.Color.MediumOrchid;
            this.chk_Frappe.Location = new System.Drawing.Point(99, 315);
            this.chk_Frappe.Name = "chk_Frappe";
            this.chk_Frappe.Size = new System.Drawing.Size(100, 27);
            this.chk_Frappe.TabIndex = 14;
            this.chk_Frappe.Text = "Frappe";
            this.chk_Frappe.UseVisualStyleBackColor = true;
            // 
            // rdb_DineIN
            // 
            this.rdb_DineIN.AutoSize = true;
            this.rdb_DineIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_DineIN.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_DineIN.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.rdb_DineIN.Location = new System.Drawing.Point(341, 162);
            this.rdb_DineIN.Name = "rdb_DineIN";
            this.rdb_DineIN.Size = new System.Drawing.Size(77, 21);
            this.rdb_DineIN.TabIndex = 15;
            this.rdb_DineIN.TabStop = true;
            this.rdb_DineIN.Text = "Dine In";
            this.rdb_DineIN.UseVisualStyleBackColor = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Status.Location = new System.Drawing.Point(338, 207);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(86, 18);
            this.lbl_Status.TabIndex = 16;
            this.lbl_Status.Text = "In Progress...";
            // 
            // rdb_takeOUT
            // 
            this.rdb_takeOUT.AutoSize = true;
            this.rdb_takeOUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_takeOUT.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_takeOUT.ForeColor = System.Drawing.Color.DarkOrchid;
            this.rdb_takeOUT.Location = new System.Drawing.Point(423, 162);
            this.rdb_takeOUT.Name = "rdb_takeOUT";
            this.rdb_takeOUT.Size = new System.Drawing.Size(87, 21);
            this.rdb_takeOUT.TabIndex = 17;
            this.rdb_takeOUT.TabStop = true;
            this.rdb_takeOUT.Text = "Take Out";
            this.rdb_takeOUT.UseVisualStyleBackColor = true;
            // 
            // txt_Message
            // 
            this.txt_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_Message.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_Message.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Message.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_Message.Location = new System.Drawing.Point(341, 226);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.ReadOnly = true;
            this.txt_Message.Size = new System.Drawing.Size(168, 56);
            this.txt_Message.TabIndex = 18;
            this.txt_Message.Text = ". . . . . . . . . . . . . . . . . .";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(553, 385);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.rdb_takeOUT);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.rdb_DineIN);
            this.Controls.Add(this.chk_Frappe);
            this.Controls.Add(this.chk_Coffee);
            this.Controls.Add(this.chk_Latte);
            this.Controls.Add(this.chk_Americano);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.chk_Espresso);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chk_Mocha);
            this.Controls.Add(this.chk_Cappuccino);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.btn_CheckOut);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.CheckBox chk_Cappuccino;
        private System.Windows.Forms.CheckBox chk_Mocha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chk_Espresso;
        private System.Windows.Forms.CheckBox chk_Americano;
        private System.Windows.Forms.CheckBox chk_Latte;
        private System.Windows.Forms.CheckBox chk_Coffee;
        private System.Windows.Forms.CheckBox chk_Frappe;
        private System.Windows.Forms.RadioButton rdb_DineIN;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.RadioButton rdb_takeOUT;
        private System.Windows.Forms.TextBox txt_Message;
    }
}

