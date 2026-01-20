namespace YBAÑEZ_LAB1._2
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
            this.lbl_Length = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.txt_Length = new System.Windows.Forms.TextBox();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.txt_ResultBase = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_BaseFormula = new System.Windows.Forms.Label();
            this.lbl_VolumeFormula = new System.Windows.Forms.Label();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_Base = new System.Windows.Forms.Label();
            this.lbl_Volume = new System.Windows.Forms.Label();
            this.txt_ResultVol = new System.Windows.Forms.TextBox();
            this.lbl_BaseResult = new System.Windows.Forms.Label();
            this.lbl_VolResult = new System.Windows.Forms.Label();
            this.pic_polycule = new System.Windows.Forms.PictureBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_polycule)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Length
            // 
            this.lbl_Length.AccessibleName = "lbl_Length";
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Length.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Length.Location = new System.Drawing.Point(20, 138);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(84, 23);
            this.lbl_Length.TabIndex = 0;
            this.lbl_Length.Text = "Length:";
            // 
            // lbl_Width
            // 
            this.lbl_Width.AccessibleName = "lbl_Width";
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Width.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Width.Location = new System.Drawing.Point(28, 183);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(76, 23);
            this.lbl_Width.TabIndex = 1;
            this.lbl_Width.Text = "Width:";
            // 
            // txt_Length
            // 
            this.txt_Length.AccessibleName = "txt_Length";
            this.txt_Length.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Length.Location = new System.Drawing.Point(110, 138);
            this.txt_Length.Name = "txt_Length";
            this.txt_Length.Size = new System.Drawing.Size(149, 26);
            this.txt_Length.TabIndex = 2;
            // 
            // txt_Width
            // 
            this.txt_Width.AccessibleName = "txt_Width";
            this.txt_Width.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Width.Location = new System.Drawing.Point(110, 183);
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(149, 26);
            this.txt_Width.TabIndex = 3;
            // 
            // txt_ResultBase
            // 
            this.txt_ResultBase.AccessibleName = "txt_ResultBase";
            this.txt_ResultBase.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ResultBase.Location = new System.Drawing.Point(19, 359);
            this.txt_ResultBase.Name = "txt_ResultBase";
            this.txt_ResultBase.ReadOnly = true;
            this.txt_ResultBase.Size = new System.Drawing.Size(149, 26);
            this.txt_ResultBase.TabIndex = 5;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AccessibleName = "lbl_Result";
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Result.Location = new System.Drawing.Point(137, 322);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(99, 29);
            this.lbl_Result.TabIndex = 4;
            this.lbl_Result.Text = "Result:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.AccessibleName = "btn_Clear";
            this.btn_Clear.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Monospac821 BT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Clear.Location = new System.Drawing.Point(437, 425);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(120, 38);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_BaseFormula
            // 
            this.lbl_BaseFormula.AccessibleName = "lbl_BaseFormula";
            this.lbl_BaseFormula.AutoSize = true;
            this.lbl_BaseFormula.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BaseFormula.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_BaseFormula.Location = new System.Drawing.Point(52, 15);
            this.lbl_BaseFormula.Name = "lbl_BaseFormula";
            this.lbl_BaseFormula.Size = new System.Drawing.Size(168, 63);
            this.lbl_BaseFormula.TabIndex = 7;
            this.lbl_BaseFormula.Text = "AB=lw";
            // 
            // lbl_VolumeFormula
            // 
            this.lbl_VolumeFormula.AccessibleName = "lbl_VolumeFormula";
            this.lbl_VolumeFormula.AutoSize = true;
            this.lbl_VolumeFormula.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VolumeFormula.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_VolumeFormula.Location = new System.Drawing.Point(290, 15);
            this.lbl_VolumeFormula.Name = "lbl_VolumeFormula";
            this.lbl_VolumeFormula.Size = new System.Drawing.Size(222, 63);
            this.lbl_VolumeFormula.TabIndex = 9;
            this.lbl_VolumeFormula.Text = "V=lwh/3";
            // 
            // txt_Height
            // 
            this.txt_Height.AccessibleName = "txt_Height";
            this.txt_Height.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Height.Location = new System.Drawing.Point(110, 227);
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(149, 26);
            this.txt_Height.TabIndex = 11;
            // 
            // lbl_Height
            // 
            this.lbl_Height.AccessibleName = "lbl_Height";
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Height.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Height.Location = new System.Drawing.Point(28, 227);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(81, 23);
            this.lbl_Height.TabIndex = 10;
            this.lbl_Height.Text = "Height:";
            // 
            // lbl_Base
            // 
            this.lbl_Base.AccessibleName = "lbl_Base";
            this.lbl_Base.AutoSize = true;
            this.lbl_Base.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Base.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Base.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Base.Location = new System.Drawing.Point(59, 78);
            this.lbl_Base.Name = "lbl_Base";
            this.lbl_Base.Size = new System.Drawing.Size(142, 21);
            this.lbl_Base.TabIndex = 12;
            this.lbl_Base.Text = "(Base Formula)";
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.AccessibleName = "lbl_Volume";
            this.lbl_Volume.AutoSize = true;
            this.lbl_Volume.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Volume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Volume.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Volume.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Volume.Location = new System.Drawing.Point(317, 78);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(164, 21);
            this.lbl_Volume.TabIndex = 13;
            this.lbl_Volume.Text = "(Volume Formula)";
            // 
            // txt_ResultVol
            // 
            this.txt_ResultVol.AccessibleName = "txt_ResultVol";
            this.txt_ResultVol.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ResultVol.Location = new System.Drawing.Point(207, 359);
            this.txt_ResultVol.Name = "txt_ResultVol";
            this.txt_ResultVol.ReadOnly = true;
            this.txt_ResultVol.Size = new System.Drawing.Size(149, 26);
            this.txt_ResultVol.TabIndex = 14;
            // 
            // lbl_BaseResult
            // 
            this.lbl_BaseResult.AccessibleName = "lbl_BaseResult";
            this.lbl_BaseResult.AutoSize = true;
            this.lbl_BaseResult.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BaseResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_BaseResult.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BaseResult.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_BaseResult.Location = new System.Drawing.Point(29, 388);
            this.lbl_BaseResult.Name = "lbl_BaseResult";
            this.lbl_BaseResult.Size = new System.Drawing.Size(124, 13);
            this.lbl_BaseResult.TabIndex = 15;
            this.lbl_BaseResult.Text = "(Base Result)";
            // 
            // lbl_VolResult
            // 
            this.lbl_VolResult.AccessibleName = "lbl_VolResult";
            this.lbl_VolResult.AutoSize = true;
            this.lbl_VolResult.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VolResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_VolResult.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VolResult.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_VolResult.Location = new System.Drawing.Point(210, 388);
            this.lbl_VolResult.Name = "lbl_VolResult";
            this.lbl_VolResult.Size = new System.Drawing.Size(142, 13);
            this.lbl_VolResult.TabIndex = 16;
            this.lbl_VolResult.Text = "(Volume Result)";
            // 
            // pic_polycule
            // 
            this.pic_polycule.AccessibleName = "pic_polycule";
            this.pic_polycule.Image = ((System.Drawing.Image)(resources.GetObject("pic_polycule.Image")));
            this.pic_polycule.Location = new System.Drawing.Point(301, 112);
            this.pic_polycule.Name = "pic_polycule";
            this.pic_polycule.Size = new System.Drawing.Size(256, 233);
            this.pic_polycule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_polycule.TabIndex = 17;
            this.pic_polycule.TabStop = false;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.AccessibleName = "btn_Calculate";
            this.btn_Calculate.BackColor = System.Drawing.Color.Yellow;
            this.btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calculate.Font = new System.Drawing.Font("Monospac821 BT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.Location = new System.Drawing.Point(252, 425);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(120, 38);
            this.btn_Calculate.TabIndex = 18;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(593, 488);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.pic_polycule);
            this.Controls.Add(this.lbl_VolResult);
            this.Controls.Add(this.lbl_BaseResult);
            this.Controls.Add(this.txt_ResultVol);
            this.Controls.Add(this.lbl_Volume);
            this.Controls.Add(this.lbl_Base);
            this.Controls.Add(this.txt_Height);
            this.Controls.Add(this.lbl_Height);
            this.Controls.Add(this.lbl_VolumeFormula);
            this.Controls.Add(this.lbl_BaseFormula);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.txt_ResultBase);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.txt_Width);
            this.Controls.Add(this.txt_Length);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.lbl_Length);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_polycule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.TextBox txt_Length;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.TextBox txt_ResultBase;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_BaseFormula;
        private System.Windows.Forms.Label lbl_VolumeFormula;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label lbl_Base;
        private System.Windows.Forms.Label lbl_Volume;
        private System.Windows.Forms.TextBox txt_ResultVol;
        private System.Windows.Forms.Label lbl_BaseResult;
        private System.Windows.Forms.Label lbl_VolResult;
        private System.Windows.Forms.PictureBox pic_polycule;
        private System.Windows.Forms.Button btn_Calculate;
    }
}

