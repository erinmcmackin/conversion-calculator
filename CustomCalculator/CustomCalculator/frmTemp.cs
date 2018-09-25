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
    public partial class frmTemp : Form
    {
        public frmTemp()
        {
            InitializeComponent();
        }

        private void frmTemp_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Found validation method on page 203 (Chapter 7) of Murach's C#2015
            decimal checkTemp;
            if (!(Decimal.TryParse(txtOrigTemp.Text, out checkTemp)))
            {
                MessageBox.Show("Temperature must be a numeric value", "Entry Error");
                txtOrigTemp.Focus();
            }
            else
            {
                decimal origTemp = Convert.ToDecimal(txtOrigTemp.Text);
                decimal calcTemp = 0;

                if (radioCel1.Checked == true)
                {
                    if (radioCel2.Checked == true)
                    {
                        calcTemp = origTemp;
                    }
                    else if (radioFahr2.Checked == true)
                    {
                        calcTemp = Math.Round((origTemp * 1.8m) + 32);
                    }
                    else if (radioKel2.Checked == true)
                    {
                        calcTemp = Math.Round(origTemp + 273m);
                    }
                }
                else if (radioFahr1.Checked == true)
                {
                    if (radioCel2.Checked == true)
                    {
                        calcTemp = Math.Round((origTemp - 32) * .5556m);
                    }
                    else if (radioFahr2.Checked == true)
                    {
                        calcTemp = origTemp;
                    }
                    else if (radioKel2.Checked == true)
                    {
                        calcTemp = Math.Round((origTemp + 459.67m) * .5556m);
                    }
                }
                else if (radioKel1.Checked == true)
                {
                    if (radioCel2.Checked == true)
                    {
                        calcTemp = Math.Round(origTemp - 273m);
                    }
                    else if (radioFahr2.Checked == true)
                    {
                        calcTemp = Math.Round((origTemp * 1.8m) - 459.67m);
                    }
                    else if (radioKel2.Checked == true)
                    {
                        calcTemp = origTemp;
                    }
                }

                // Insert calculated new teperature into Converted Temp field
                txtConvTemp.Text = calcTemp.ToString();
                // Move cursor back to Original Temp fied
                txtOrigTemp.Focus();
            }


        }

        private void btnMenuReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
