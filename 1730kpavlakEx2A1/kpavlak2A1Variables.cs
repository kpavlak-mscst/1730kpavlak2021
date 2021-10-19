using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730kpavlakEx2A1
{
    public partial class kpavlak2A1Variables : Form
    {
        public kpavlak2A1Variables()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);

            decimal discountpercent = Convert.ToDecimal(txtDiscountpercent.Text);

            decimal discountamount = subtotal * discountpercent / 100;

            txtDiscountamount.Text = discountamount.ToString("0.00");

            decimal total = subtotal - discountamount;

            txtTotal.Text = total.ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
