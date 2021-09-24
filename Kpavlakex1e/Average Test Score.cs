using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpavlakex1e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTest1Results.Text = "0";
            txtTest2Results.Text = "0";
            txtTest3Results.Text = "0";
            txtAverage.Text = ("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = (

                 (Convert.ToDecimal(txtTest1Results.Text) +
                 Convert.ToDecimal(txtTest2Results.Text) +
                 Convert.ToDecimal(txtTest3Results.Text)) / 3
                 ).ToString("0.00");
            
        }
    }
}
