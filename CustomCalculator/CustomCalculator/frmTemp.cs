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

                }
                else if (radioFahr2.Checked == true)
                {

                }
                else if (radioKel2.Checked == true)
                {

                }
            }
            else if (radioFahr1.Checked == true)
            {
                if (radioCel2.Checked == true)
                {

                }
                else if (radioFahr2.Checked == true)
                {

                }
                else if (radioKel2.Checked == true)
                {

                }
            }
            else if (radioKel1.Checked == true)
            {
                if (radioCel2.Checked == true)
                {

                }
                else if (radioFahr2.Checked == true)
                {

                }
                else if (radioKel2.Checked == true)
                {

                }
            }

        }
    }
}
