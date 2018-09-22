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
            decimal inputValue = Convert.ToDecimal(txtLinearValue.Text);

            decimal calculatedInches = inputValue ;

            if (txtLinearUnit.Text == "inches")
            {
                calculatedInches = inputValue;
            }
            else if (txtLinearUnit.Text == "feet")
            {
                calculatedInches = inputValue * 12;
            }
            else if (txtLinearUnit.Text == "yards")
            {
                calculatedInches = inputValue * 36;
            }
            else if (txtLinearUnit.Text == "miles")
            {
                calculatedInches = inputValue * 63360;
            }
            else if (txtLinearUnit.Text == "millimeters")
            {
                calculatedInches = inputValue / 25.4m;
            }
            else if (txtLinearUnit.Text == "centimeters")
            {
                calculatedInches = inputValue / 2.54m;
            }
            else if (txtLinearUnit.Text == "meters")
            {
                calculatedInches = inputValue / .0254m;
            }
            else if (txtLinearUnit.Text == "kilometers")
            {
                calculatedInches = inputValue / .0000254m;
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
