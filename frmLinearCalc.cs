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
    public partial class frmLinearCalc : Form
    {
        public frmLinearCalc()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal inputLinCalc1 = Convert.ToDecimal(txtLinCalcInput1.Text);

            decimal inputLinCalc2 = Convert.ToDecimal(txtLinCalcInput2.Text);

            decimal convertedInches1 = inputLinCalc1;

            decimal convertedInches2 = inputLinCalc2;

            decimal calculatedResultInches = convertedInches1 + convertedInches2;

            decimal calculatedResult = calculatedResultInches;

            //Start of conversion code for Linear Input 1

            if (txtLinCalcInput1Unit.Text == "inches") 
            {
                convertedInches1 = inputLinCalc1;
            }
            else if (txtLinCalcInput1Unit.Text == "feet")
            {
                convertedInches1 = inputLinCalc1 * 12;
            }
            else if (txtLinCalcInput1Unit.Text == "yards")
            {
                convertedInches1 = inputLinCalc1 * 36;
            }
            else if (txtLinCalcInput1Unit.Text == "miles")
            {
                convertedInches1 = inputLinCalc1 * 63360;
            }
            else if (txtLinCalcInput1Unit.Text == "millimeters")
            {
                convertedInches1 = inputLinCalc1 / 25.4m;
            }
            else if (txtLinCalcInput1Unit.Text == "centimeters")
            {
                convertedInches1 = inputLinCalc1 / 2.54m;
            }
            else if (txtLinCalcInput1Unit.Text == "meters")
            {
                convertedInches1 = inputLinCalc1 / .0254m;
            }
            else if (txtLinCalcInput1Unit.Text == "kilometers")
            {
                convertedInches1 = inputLinCalc1 / .0000254m;
            }
            
            //Start of conversion code for Linear Input 2

            if (txtLinCalcInput2Unit.Text == "inches")
            {
                convertedInches2 = inputLinCalc2;
            }
            else if (txtLinCalcInput2Unit.Text == "feet")
            {
                convertedInches2 = inputLinCalc2 * 12;
            }
            else if (txtLinCalcInput2Unit.Text == "yards")
            {
                convertedInches2 = inputLinCalc2 * 36;
            }
            else if (txtLinCalcInput2Unit.Text == "miles")
            {
                convertedInches2 = inputLinCalc2 * 63360;
            }
            else if (txtLinCalcInput2Unit.Text == "millimeters")
            {
                convertedInches2 = inputLinCalc2 / 25.4m;
            }
            else if (txtLinCalcInput2Unit.Text == "centimeters")
            {
                convertedInches2 = inputLinCalc2 / 2.54m;
            }
            else if (txtLinCalcInput2Unit.Text == "meters")
            {
                convertedInches2 = inputLinCalc2 / .0254m;
            }
            else if (txtLinCalcInput2Unit.Text == "kilometers")
            {
                convertedInches2 = inputLinCalc2 / .0000254m;
            }

            //Start of calculation code

            if (txtLinCalcOperator.Text == "+")
            {
                calculatedResultInches = convertedInches1 + convertedInches2;
            }
            else if (txtLinCalcOperator.Text == "-")
            {
                calculatedResultInches = convertedInches1 - convertedInches2;
            }
            else if (txtLinCalcOperator.Text == "x")
            {
                calculatedResultInches = convertedInches1 * convertedInches2;
            }
            else if (txtLinCalcOperator.Text == "/")
            {
                calculatedResultInches = convertedInches1 / convertedInches2;
            }

            //Start of conversion code for results

            if (txtLCalcResultUnit.Text == "inches" || txtLCalcResultUnit.Text == "(inches)") 
            {
                calculatedResult = calculatedResultInches;
            }
            else if (txtLCalcResultUnit.Text == "feet")
            {
                calculatedResult = calculatedResultInches /12;
            }
            else if (txtLCalcResultUnit.Text == "yards")
            {
                calculatedResult = calculatedResultInches / 35;
            }
            else if (txtLCalcResultUnit.Text == "miles")
            {
                calculatedResult = calculatedResultInches / 63360;
            }
            else if (txtLCalcResultUnit.Text == "millimeters")
            {
                calculatedResult = calculatedResultInches * 25.4m;
            }
            else if (txtLCalcResultUnit.Text == "centimeters")
            {
                calculatedResult = calculatedResultInches * 2.54m;
            }
            else if (txtLCalcResultUnit.Text == "meters")
            {
                calculatedResult = calculatedResultInches * .0254m;
            }
            else if (txtLCalcResultUnit.Text == "kilometers")
            {
                calculatedResult = calculatedResultInches * .0000254m;
            }

            txtLCalcResult.Text = calculatedResult.ToString("0.####");
        }

        private void btnSelectLinCalcInput1Unit_Click(object sender, EventArgs e)
        {
            ctxMenuUnits1.Show(btnSelectLinCalcInput1Unit, 0, btnSelectLinCalcInput1Unit.Height);
        }

        private void btnSelectLinCalcInput2Unit_Click(object sender, EventArgs e)
        {
            ctxMenuUnits2.Show(btnSelectLinCalcInput2Unit, 0, btnSelectLinCalcInput2Unit.Height);
        }

        private void btnSelectLCalcResultUnit_Click(object sender, EventArgs e)
        {
            ctxMenuUnitsResult.Show(btnSelectLCalcResultUnit, 0, btnSelectLCalcResultUnit.Height);
        }

        private void btnSelectLinCalcOperator_Click(object sender, EventArgs e)
        {
            ctxMenuOperation.Show(btnSelectLinCalcOperator, 0, btnSelectLinCalcOperator.Height);
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit1 = "inches";

            txtLinCalcInput1Unit.Text = selectedUnit1;
        }

        private void ftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit1 = "feet";

            txtLinCalcInput1Unit.Text = selectedUnit1;
        }

        private void ydToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit1 = "yards";

            txtLinCalcInput1Unit.Text = selectedUnit1;
        }

        private void miToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit1 = "miles";

            txtLinCalcInput1Unit.Text = selectedUnit1;
        }

        private void mmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit1 = "millimeters";

            txtLinCalcInput1Unit.Text = selectedUnit1;
        }

        private void cmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit1 = "centimeters";

            txtLinCalcInput1Unit.Text = selectedUnit1;
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit1 = "meters";

            txtLinCalcInput1Unit.Text = selectedUnit1;
        }

        private void kmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedUnit1 = "kilometers";

            txtLinCalcInput1Unit.Text = selectedUnit1;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string selectedUnit2 = "inches";

            txtLinCalcInput2Unit.Text = selectedUnit2;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string selectedUnit2 = "feet";

            txtLinCalcInput2Unit.Text = selectedUnit2;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string selectedUnit2 = "yards";

            txtLinCalcInput2Unit.Text = selectedUnit2;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string selectedUnit2 = "miles";

            txtLinCalcInput2Unit.Text = selectedUnit2;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            string selectedUnit2 = "millimeters";

            txtLinCalcInput2Unit.Text = selectedUnit2;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            string selectedUnit2 = "centimeters";

            txtLinCalcInput2Unit.Text = selectedUnit2;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            string selectedUnit2 = "meters";

            txtLinCalcInput2Unit.Text = selectedUnit2;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            string selectedUnit2 = "kilometers";

            txtLinCalcInput2Unit.Text = selectedUnit2;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            string selectedUnit3 = "inches";

            txtLCalcResultUnit.Text = selectedUnit3;

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            string selectedUnit3 = "feet";

            txtLCalcResultUnit.Text = selectedUnit3;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            string selectedUnit3 = "yards";

            txtLCalcResultUnit.Text = selectedUnit3;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            string selectedUnit3 = "miles";

            txtLCalcResultUnit.Text = selectedUnit3;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            string selectedUnit3 = "millimeters";

            txtLCalcResultUnit.Text = selectedUnit3;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            string selectedUnit3 = "centimeters";

            txtLCalcResultUnit.Text = selectedUnit3;
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            string selectedUnit3 = "meters";

            txtLCalcResultUnit.Text = selectedUnit3;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            string selectedUnit3 = "kilometers";

            txtLCalcResultUnit.Text = selectedUnit3;
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            string selectedOperator = "+";

            txtLinCalcOperator.Text = selectedOperator;
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            string selectedOperator = "-";

            txtLinCalcOperator.Text = selectedOperator;
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedOperator = "x";

            txtLinCalcOperator.Text = selectedOperator;
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            string selectedOperator = "/";

            txtLinCalcOperator.Text = selectedOperator;
        }

        private void btnReturnLinConvert_Click(object sender, EventArgs e)
        {
            this.Close();
            var formMenu = new frmMenu();
            formMenu.Show();
        }

        private void btnReturnLinConvert_Click_1(object sender, EventArgs e)
        {
            this.Close();
            var formLinear = new frmLinear();
            formLinear.Show();
        }
    }
}
