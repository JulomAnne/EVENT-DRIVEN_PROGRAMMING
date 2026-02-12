using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Lambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_Header.Parent = pictureBox1;
            lbl_Shadow.Parent = pictureBox1;
            lbl_Quantity.Parent = pictureBox1;
            lbl_Header.BackColor = Color.Transparent;
            lbl_Shadow.BackColor = Color.Transparent;
            lbl_Quantity.BackColor = Color.Transparent;

            //LAMBDA FUNCTION
            btn_CheckOut.Click += (sender, e) =>
            {
                int quantity;
                bool ValidQuantity = int.TryParse(txt_Quantity.Text, out quantity) && quantity > 0;
                txt_Message.Text = (ValidQuantity) ? "Order Accepted! ^^" : "Invalid Order! OnO";
                txt_Quantity.Clear();
            };
        }
    }
}