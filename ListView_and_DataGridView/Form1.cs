using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_and_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem item in lvRecords.Items)
            {
                if (item.Text == txtID.Text)
                {
                    MessageBox.Show("A student with this ID already exists.", "Duplicate ID",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            ListViewItem lvItem = new ListViewItem(txtID.Text);
            lvItem.SubItems.Add(txtName.Text);
            lvItem.SubItems.Add(txtCourse.Text);
            lvRecords.Items.Add(lvItem);

            DataGV1.Rows.Add(txtID.Text, txtName.Text, txtCourse.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtID.Clear();
            txtCourse.Clear();
            txtName.Focus();
            if (lvRecords.SelectedIndices.Count == 0 && DataGV1.SelectedRows.Count == 0)
            { return; }
            int index = -1;
            if (lvRecords.SelectedIndices.Count > 0)
            {
                index = lvRecords.SelectedIndices[0];
            }
            else
            {
                index = DataGV1.SelectedRows[0].Index;
            }

            if (index >= 0)
            {
                lvRecords.Items.RemoveAt(index);
                if (index < DataGV1.Rows.Count && !DataGV1.Rows[index].IsNewRow)
                {
                    DataGV1.Rows.RemoveAt(index);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtID.Clear();
            txtCourse.Clear();
            lvRecords.Items.Clear();
            DataGV1.Rows.Clear();
            txtName.Focus();
        }
    }
}