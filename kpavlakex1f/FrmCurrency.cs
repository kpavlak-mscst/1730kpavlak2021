using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kpavlakex1f
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnAustralia.Text + ":";
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.717976";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();

        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.717976";
            lblCurrency.Text = btnAustralia.Text;
            txtTotalUSD.Text = ("0.00");
            txtUSDollars.Text = ("0.00");
            txtCurrency.Text = ("0.00");
            txtCurrency.Focus();
            txtCurrency.SelectAll();
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.013";
            txtCurrency.Text = ("0.00");
            txtCurrency.Focus();
            txtCurrency.SelectAll();
            lblCurrency.Text = btnBhutan.Text;
        }

        private void btnCostaRica_Click(object sender, EventArgs e)
        {
            btnCostaRica.BackgroundImage = picCostaRica.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.0016";
            txtCurrency.Text = ("0.00");
            txtCurrency.Focus();
            txtCurrency.SelectAll();
            lblCurrency.Text = btnCostaRica.Text;
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            btnEuro.BackgroundImage = picEuro.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            txtRate.Text = "1.16";
            txtCurrency.Text = ("0.00");
            txtCurrency.Focus();
            txtCurrency.SelectAll();
            lblCurrency.Text = btnEuro.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (Convert.ToDecimal(txtCurrency.Text) *
                Convert.ToDecimal(txtRate.Text)).ToString("0.00");

        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void txtCurrency_Click(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + "+" + txtTotalUSD.Text;
            txtTotalUSD.Text = (Convert.ToDecimal(txtTotalUSD.Text) +
                Convert.ToDecimal(txtUSDollars.Text)).ToString("0.00");
        }

        private void txtTotalUSD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblCurrency.Text = (":");
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnAustralia.Text + lblCurrency.Text;
            txtTotalUSD.Text = ("0.00");
            txtUSDollars.Text = ("0.00");
            txtRate.Text = ("0.717976");
            lblEquation.Text = ("");
            txtCurrency.Text = ("0.00");
            txtCurrency.Focus();
            txtCurrency.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
