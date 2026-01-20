using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void BTN_ADD_Click_Click(object sender, EventArgs e)
        {
            ListViewItem Records1 = new ListViewItem("Kris Anne J. Ybañez");
            Records1.SubItems.Add("IT401P");
            Records1.SubItems.Add("Girl");
            ListRecords.Items.Add(Records1);
        }

        private void BTN_CLEAR_Click_Click(object sender, EventArgs e)
        {
            ListRecords.Items.Clear();
        }

        private void BTN_REMOVE2_Click_Click(object sender, EventArgs e)
        {
            if (ListRecords.SelectedItems.Count > 0)
            {
                ListRecords.Items.Remove(ListRecords.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("PLEASE SELECT AN ITEM TO REMOVE",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}