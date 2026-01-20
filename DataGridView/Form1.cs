using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DataGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGV.Rows.Add("MANGO", "120", "KG");
            DataGV.Rows.Add("GRAPES", "120", "KG");
            DataGV.Rows.Add("APPLE", "20", "PCS");
        }

        private void BTN_CLEAR2_Click(object sender, EventArgs e)
        {
            DataGV.Rows.Clear();
        }

        private void BTN_REMOVE2_Click(object sender, EventArgs e)
        {
            if (DataGV.SelectedRows.Count > 0)
            {
                DataGV.Rows.Remove(DataGV.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Please Select A Row To Remove",
                                "!Error Message!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}