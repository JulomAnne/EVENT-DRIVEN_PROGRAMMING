namespace DataGridView
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
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_ADD2 = new System.Windows.Forms.Button();
            this.BTN_CLEAR2 = new System.Windows.Forms.Button();
            this.BTN_REMOVE2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGV
            // 
            this.DataGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataGV.Location = new System.Drawing.Point(12, 12);
            this.DataGV.Name = "DataGV";
            this.DataGV.RowHeadersWidth = 62;
            this.DataGV.Size = new System.Drawing.Size(519, 290);
            this.DataGV.TabIndex = 0;
            this.DataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Description";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PRICE";
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "UNIT";
            this.Column3.MinimumWidth = 12;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // BTN_ADD2
            // 
            this.BTN_ADD2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTN_ADD2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_ADD2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ADD2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD2.Location = new System.Drawing.Point(12, 341);
            this.BTN_ADD2.Name = "BTN_ADD2";
            this.BTN_ADD2.Size = new System.Drawing.Size(102, 45);
            this.BTN_ADD2.TabIndex = 4;
            this.BTN_ADD2.Text = "ADD";
            this.BTN_ADD2.UseVisualStyleBackColor = false;
            // 
            // BTN_CLEAR2
            // 
            this.BTN_CLEAR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_CLEAR2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_CLEAR2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_CLEAR2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLEAR2.Location = new System.Drawing.Point(149, 341);
            this.BTN_CLEAR2.Name = "BTN_CLEAR2";
            this.BTN_CLEAR2.Size = new System.Drawing.Size(102, 45);
            this.BTN_CLEAR2.TabIndex = 5;
            this.BTN_CLEAR2.Text = "CLEAR";
            this.BTN_CLEAR2.UseVisualStyleBackColor = false;
            this.BTN_CLEAR2.Click += new System.EventHandler(this.BTN_CLEAR2_Click);
            // 
            // BTN_REMOVE2
            // 
            this.BTN_REMOVE2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BTN_REMOVE2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_REMOVE2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_REMOVE2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_REMOVE2.Location = new System.Drawing.Point(284, 341);
            this.BTN_REMOVE2.Name = "BTN_REMOVE2";
            this.BTN_REMOVE2.Size = new System.Drawing.Size(102, 45);
            this.BTN_REMOVE2.TabIndex = 6;
            this.BTN_REMOVE2.Text = "REMOVE";
            this.BTN_REMOVE2.UseVisualStyleBackColor = false;
            this.BTN_REMOVE2.Click += new System.EventHandler(this.BTN_REMOVE2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 405);
            this.Controls.Add(this.BTN_REMOVE2);
            this.Controls.Add(this.BTN_CLEAR2);
            this.Controls.Add(this.BTN_ADD2);
            this.Controls.Add(this.DataGV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button BTN_ADD2;
        private System.Windows.Forms.Button BTN_CLEAR2;
        private System.Windows.Forms.Button BTN_REMOVE2;
    }
}

