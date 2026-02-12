using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btn_CheckOut.Click += (sender, e) =>
            {
                int quantity;
                bool ValidQuantity = int.TryParse(txt_Quantity.Text, out quantity) && quantity > 0;
                bool SelectedDrinks = chk_Espresso.Checked || chk_Mocha.Checked || chk_Americano.Checked ||
                chk_Cappuccino.Checked || chk_Coffee.Checked || chk_Latte.Checked || chk_Frappe.Checked;
                bool DITO = rdb_DineIN.Checked || rdb_takeOUT.Checked;
                lbl_Status.Text = (ValidQuantity && SelectedDrinks && DITO) ? "Order Accepted" : "Invalid Order";
                txt_Message.Text = (ValidQuantity && SelectedDrinks && DITO)
                ? "Thank you for your order!" : "Please check your order details.";
            };
        }
    }
}