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
    public partial class frmLinear : Form
    {
        public frmLinear()
        {
            InitializeComponent();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            ctxMenuUnits.Show(btnUnit, 0, btnUnit.Height);
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit = "inches";

            txtLinearUnit.Text = selectedUnit;
        }

        private void ftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit = "feet";

            txtLinearUnit.Text = selectedUnit;
        }

        private void ydToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit = "yards";

            txtLinearUnit.Text = selectedUnit;
        }

        private void miToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit = "miles";

            txtLinearUnit.Text = selectedUnit;
        }

        private void mmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit = "millimeters";

            txtLinearUnit.Text = selectedUnit;
        }

        private void cmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit = "centimeters";

            txtLinearUnit.Text = selectedUnit;
        }

        private void meterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit = "meters";

            txtLinearUnit.Text = selectedUnit;
        }

        private void kmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit = "kilometers";

            txtLinearUnit.Text = selectedUnit;
        }

         private void btnConvert_Click(object sender, EventArgs e)
        {
            decimal inputLinearValue = Convert.ToDecimal(txtLinearValue.Text);

            decimal calculatedInches = inputLinearValue ;

            if (txtLinearUnit.Text == "inches")
            {
                calculatedInches = inputLinearValue;
            }
            else if (txtLinearUnit.Text == "feet")
            {
                calculatedInches = inputLinearValue * 12;
            }
            else if (txtLinearUnit.Text == "yards")
            {
                calculatedInches = inputLinearValue * 36;
            }
            else if (txtLinearUnit.Text == "miles")
            {
                calculatedInches = inputLinearValue * 63360;
            }
            else if (txtLinearUnit.Text == "millimeters")
            {
                calculatedInches = inputLinearValue / 25.4m;
            }
            else if (txtLinearUnit.Text == "centimeters")
            {
                calculatedInches = inputLinearValue / 2.54m;
            }
            else if (txtLinearUnit.Text == "meters")
            {
                calculatedInches = inputLinearValue / .0254m;
            }
            else if (txtLinearUnit.Text == "kilometers")
            {
                calculatedInches = inputLinearValue / .0000254m;
            }

            decimal calculatedFeet = calculatedInches / 12;

            decimal calculatedYards = calculatedInches / 36;

            decimal calculatedMiles = calculatedInches / 63360;

            decimal calculatedMilliMeters = calculatedInches * 25.4m;

            decimal calculatedCentiMeters = calculatedInches * 2.54m;

            decimal calculatedMeters = calculatedInches * .0254m;

            decimal calculatedKiloMeters = calculatedInches * .0000254m;
             
            txtInch.Text = calculatedInches.ToString("0.####");

            txtFoot.Text = calculatedFeet.ToString("0.####");

            txtYard.Text = calculatedYards.ToString("0.####");

            txtMile.Text = calculatedMiles.ToString("0.####");

            txtMilliMeter.Text = calculatedMilliMeters.ToString("0.####");

            txtCentiMeter.Text = calculatedCentiMeters.ToString("0.####");

            txtMeter.Text = calculatedMeters.ToString("0.####");

            txtKiloMeter.Text = calculatedKiloMeters.ToString("0.####");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
