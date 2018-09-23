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
    public partial class frmVolume : Form
    {
        public frmVolume()
        {
            InitializeComponent();
        }

        private void btnSelectVolumeUnits_Click(object sender, EventArgs e)
        {
            ctxMenuVolumeUnits.Show(btnSelectVolumeUnits, 0, btnSelectVolumeUnits.Height);
        }

        private void flOzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedVolumeUnit = "fluid ounces";

            txtVolumeUnit.Text = selectedVolumeUnit;
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedVolumeUnit = "cups";

            txtVolumeUnit.Text = selectedVolumeUnit;
        }

        private void ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedVolumeUnit = "pints";

            txtVolumeUnit.Text = selectedVolumeUnit;
        }

        private void qtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedVolumeUnit = "quarts";

            txtVolumeUnit.Text = selectedVolumeUnit;
        }

        private void galToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedVolumeUnit = "gallons";

            txtVolumeUnit.Text = selectedVolumeUnit;
        }

        private void mLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedVolumeUnit = "milliliters";

            txtVolumeUnit.Text = selectedVolumeUnit;
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedVolumeUnit = "liters";

            txtVolumeUnit.Text = selectedVolumeUnit;
        }

        private void btnVolumeConvert_Click(object sender, EventArgs e)
        {
            decimal inputVolumeValue = Convert.ToDecimal(txtVolumeValue.Text);

            decimal calculatedFluidOunces = inputVolumeValue ;

            if (txtVolumeUnit.Text == "fluid ounces")
            {
                calculatedFluidOunces = inputVolumeValue;
            }
            else if (txtVolumeUnit.Text == "cups")
            {
                calculatedFluidOunces = inputVolumeValue * 8;
            }
            else if (txtVolumeUnit.Text == "pints")
            {
                calculatedFluidOunces = inputVolumeValue * 16;
            }
            else if (txtVolumeUnit.Text == "quarts")
            {
                calculatedFluidOunces = inputVolumeValue * 32;
            }
            else if (txtVolumeUnit.Text == "gallons")
            {
                calculatedFluidOunces = inputVolumeValue * 128;
            }
            else if (txtVolumeUnit.Text == "milliliters")
            {
                calculatedFluidOunces = inputVolumeValue / 29.57m;
            }
            else if (txtVolumeUnit.Text == "liters")
            {
                calculatedFluidOunces = inputVolumeValue / .02957m;
            }

            decimal calculatedCups = calculatedFluidOunces / 8;

            decimal calculatedPints = calculatedFluidOunces / 16;

            decimal calculatedQuarts = calculatedFluidOunces / 32;

            decimal calculatedGallons = calculatedFluidOunces / 128;

            decimal calculatedMilliLiters = calculatedFluidOunces * 29.57m;

            decimal calculatedLiters = calculatedFluidOunces * .02957m;

            txtFluidOunce.Text = calculatedFluidOunces.ToString("0.####");

            txtCup.Text = calculatedCups.ToString("0.####");

            txtPint.Text = calculatedPints.ToString("0.####");

            txtQuart.Text = calculatedQuarts.ToString("0.####");

            txtGallon.Text = calculatedGallons.ToString("0.####");

            txtMilliLiter.Text = calculatedMilliLiters.ToString("0.####");

            txtLiter.Text = calculatedLiters.ToString("0.####");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
