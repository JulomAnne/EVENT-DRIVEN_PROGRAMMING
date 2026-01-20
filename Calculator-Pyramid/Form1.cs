using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YBAÑEZ_LAB1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Length.Clear();
            txt_Width.Clear();
            txt_Height.Clear();
            txt_ResultBase.Clear();
            txt_ResultVol.Clear();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Retrieve inputs
                double length = double.Parse(txt_Length.Text);
                double width = double.Parse(txt_Width.Text);
                double height = double.Parse(txt_Height.Text);

                //Calculation
                double Base = length * width;
                double Volume = (length * width * height) / 3;

                //Display Results
                txt_ResultBase.Text = $"{Base}";
                txt_ResultVol.Text = $"{Volume}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
