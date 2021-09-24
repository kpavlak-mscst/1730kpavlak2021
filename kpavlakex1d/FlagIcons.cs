﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kpavlakex1d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                Convert.ToDecimal(txtAmountAustralia.Text) *
                Convert.ToDecimal(txtRateAustralia.Text)
                ).ToString("0.00");
        }

        private void bhutanTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (
                Convert.ToDecimal(txtAmountBhutan.Text) *
                Convert.ToDecimal(txtRateBhutan.Text)
                ).ToString("0.00");
        }

        private void costaricaTextChanged(object sender, EventArgs e)
        {
            txtUSDCostaRica.Text = (
               Convert.ToDecimal(txtAmountCostaRica.Text) *
                Convert.ToDecimal(txtRateCostaRica.Text)
               ).ToString("0.00");
        }

        private void euroTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
             Convert.ToDecimal(txtAmountEuro.Text) *
                Convert.ToDecimal(txtRateAustralia.Text)
              ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDAustralia.Text) +
                Convert.ToDecimal(txtUSDBhutan.Text) +
                Convert.ToDecimal(txtUSDCostaRica.Text) +
                Convert.ToDecimal(txtUSDEuro.Text)
                ).ToString("0.00");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.72";
            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.01";
            txtAmountCostaRica.Text = "0.00";
            txtRateCostaRica.Text = "0.002";
            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.17";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
