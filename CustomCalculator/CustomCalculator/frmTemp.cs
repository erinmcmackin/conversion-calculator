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
            decimal origTemp = Convert.ToDecimal(txtOrigTemp.Text);
            decimal calcTemp = 0;

            if (radioCel1.Checked == true)
            {
                if (radioCel2.Checked == true)
                {
                    calcTemp = origTemp;
                    txtConvTemp.Text = calcTemp.ToString();
                }
                else if (radioFahr2.Checked == true)
                {
                    calcTemp = Math.Round((origTemp * 1.8m) + 32);
                    txtConvTemp.Text = calcTemp.ToString();
                }
                else if (radioKel2.Checked == true)
                {
                    calcTemp = Math.Round(origTemp + 273m);
                    txtConvTemp.Text = calcTemp.ToString();
                }
            }
            else if (radioFahr1.Checked == true)
            {
                if (radioCel2.Checked == true)
                {
                    calcTemp = Math.Round((origTemp - 32) * .5556m);
                    txtConvTemp.Text = calcTemp.ToString();
                }
                else if (radioFahr2.Checked == true)
                {
                    calcTemp = origTemp;
                    txtConvTemp.Text = calcTemp.ToString();
                }
                else if (radioKel2.Checked == true)
                {
                    calcTemp = Math.Round((origTemp + 459.67m) * .5556m);
                    txtConvTemp.Text = calcTemp.ToString();
                }
            }
            else if (radioKel1.Checked == true)
            {
                if (radioCel2.Checked == true)
                {
                    calcTemp = Math.Round(origTemp - 273m);
                    txtConvTemp.Text = calcTemp.ToString();
                }
                else if (radioFahr2.Checked == true)
                {
                    calcTemp = Math.Round((origTemp * 1.8m) - 459.67m);
                    txtConvTemp.Text = calcTemp.ToString();
                }
                else if (radioKel2.Checked == true)
                {
                    calcTemp = origTemp;
                    txtConvTemp.Text = calcTemp.ToString();
                }
            }

        }
    }
}
