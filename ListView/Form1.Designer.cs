namespace ListView
{
    partial class DataGridView
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
            this.BTN_ADD_Click = new System.Windows.Forms.Button();
            this.BTN_CLEAR_Click = new System.Windows.Forms.Button();
            this.BTN_REMOVE2_Click = new System.Windows.Forms.Button();
            this.ListRecords = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BTN_ADD_Click
            // 
            this.BTN_ADD_Click.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_ADD_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ADD_Click.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD_Click.Location = new System.Drawing.Point(21, 405);
            this.BTN_ADD_Click.Name = "BTN_ADD_Click";
            this.BTN_ADD_Click.Size = new System.Drawing.Size(101, 48);
            this.BTN_ADD_Click.TabIndex = 1;
            this.BTN_ADD_Click.Text = "ADD";
            this.BTN_ADD_Click.UseVisualStyleBackColor = false;
            this.BTN_ADD_Click.Click += new System.EventHandler(this.BTN_ADD_Click_Click);
            // 
            // BTN_CLEAR_Click
            // 
            this.BTN_CLEAR_Click.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_CLEAR_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_CLEAR_Click.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLEAR_Click.Location = new System.Drawing.Point(137, 405);
            this.BTN_CLEAR_Click.Name = "BTN_CLEAR_Click";
            this.BTN_CLEAR_Click.Size = new System.Drawing.Size(101, 48);
            this.BTN_CLEAR_Click.TabIndex = 2;
            this.BTN_CLEAR_Click.Text = "CLEAR";
            this.BTN_CLEAR_Click.UseVisualStyleBackColor = false;
            this.BTN_CLEAR_Click.Click += new System.EventHandler(this.BTN_CLEAR_Click_Click);
            // 
            // BTN_REMOVE2_Click
            // 
            this.BTN_REMOVE2_Click.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_REMOVE2_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_REMOVE2_Click.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_REMOVE2_Click.Location = new System.Drawing.Point(253, 405);
            this.BTN_REMOVE2_Click.Name = "BTN_REMOVE2_Click";
            this.BTN_REMOVE2_Click.Size = new System.Drawing.Size(101, 48);
            this.BTN_REMOVE2_Click.TabIndex = 3;
            this.BTN_REMOVE2_Click.Text = "REMOVE";
            this.BTN_REMOVE2_Click.UseVisualStyleBackColor = false;
            this.BTN_REMOVE2_Click.Click += new System.EventHandler(this.BTN_REMOVE2_Click_Click);
            // 
            // ListRecords
            // 
            this.ListRecords.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListRecords.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRecords.FullRowSelect = true;
            this.ListRecords.GridLines = true;
            this.ListRecords.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListRecords.HideSelection = false;
            this.ListRecords.HoverSelection = true;
            this.ListRecords.Location = new System.Drawing.Point(12, 12);
            this.ListRecords.MultiSelect = false;
            this.ListRecords.Name = "ListRecords";
            this.ListRecords.Size = new System.Drawing.Size(562, 362);
            this.ListRecords.TabIndex = 5;
            this.ListRecords.UseCompatibleStateImageBehavior = false;
            this.ListRecords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NAME";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SECTION";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "GENDER";
            this.columnHeader3.Width = 80;
            // 
            // DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 479);
            this.Controls.Add(this.ListRecords);
            this.Controls.Add(this.BTN_REMOVE2_Click);
            this.Controls.Add(this.BTN_CLEAR_Click);
            this.Controls.Add(this.BTN_ADD_Click);
            this.Name = "DataGridView";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_ADD_Click;
        private System.Windows.Forms.Button BTN_CLEAR_Click;
        private System.Windows.Forms.Button BTN_REMOVE2_Click;
        private System.Windows.Forms.ListView ListRecords;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

