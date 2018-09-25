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
            {
                lblLength.Text = "Length (ft):";
                txtLength.Text = "0";
                txtWidth.Text = "0";
                txtWidth.Visible = true;
                lblWidth.Visible = true;
                txtHeight.Text = "0";
                txtHeight.Visible = true;
                lblHeight.Visible = true;
                txtTotal.Text = "";
            }  
        }

        private void rdArea_CheckedChanged(object sender, EventArgs e)
        {
            if (rdArea.Checked)
            {
                lblLength.Text = "Length (ft):";
                txtLength.Text = "0";
                txtWidth.Text = "0";
                txtWidth.Visible = true;
                lblWidth.Visible = true;
                txtHeight.Text = "0";
                txtHeight.Visible = false;
                lblHeight.Visible = false;
                txtTotal.Text = "";
            }
        }

        private void rdAreaOfCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAreaOfCircle.Checked)
            {
                lblLength.Text = "Radius (ft):";
                txtLength.Text = "0";
                txtWidth.Text = "0";
                txtWidth.Visible = false;
                lblWidth.Visible = false;
                txtHeight.Text = "0";
                txtHeight.Visible = false;
                lblHeight.Visible = false;
                txtTotal.Text = "";
            }
        }
    
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(txtLength.Text);
            double width = Convert.ToDouble(txtWidth.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            double total = 0d;


            if (rdArea.Checked)
                total = length * width;
            else if (rdVolume.Checked)
                total = length * width * height;
            else
                total = Math.PI * Math.Pow(length,2);

            if (rdArea.Checked)
                txtTotal.Text = Convert.ToString(total) + " sq. ft.";
            else if (rdVolume.Checked)
                txtTotal.Text = Convert.ToString(total) + " cubic ft.";
            else
                txtTotal.Text = Convert.ToString(total);
                
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
