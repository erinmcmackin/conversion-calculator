using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCalculator
{
    public partial class frmAreaVolCalc : Form
    {
        public frmAreaVolCalc()
        {
            InitializeComponent();
        }

        private void rdVolume_CheckedChanged(object sender, EventArgs e)
        {
            if (rdVolume.Checked)
                txtHeight.ReadOnly = false;
                txtHeight.Text = "0";
                txtHeight.Visible = true;
                lblHeight.Visible = true;
                
        }

        private void rdArea_CheckedChanged(object sender, EventArgs e)
        {
            if (rdArea.Checked)
                txtHeight.ReadOnly = true;
                txtHeight.Text = "0";
                txtHeight.Visible = false;
                lblHeight.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal length = Convert.ToDecimal(txtLength.Text);
            decimal width = Convert.ToDecimal(txtWidth.Text);
            decimal height = Convert.ToDecimal(txtHeight.Text);
            decimal total = 0m;


            if (rdArea.Checked)
            {
                total = length * width;
            }
            else
            { 
                total = length * width * height;
            }

            if (rdArea.Checked)
            {
                txtTotal.Text = Convert.ToString(total) + " sq. ft.";
            }
            else
            {
                txtTotal.Text = Convert.ToString(total) + " cubic ft.";
            }
        }

        private void btnClearInputs_Click(object sender, EventArgs e)
        {
            txtLength.Text = "0";
            txtWidth.Text = "0";
            txtHeight.Text = "0";
            txtTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
