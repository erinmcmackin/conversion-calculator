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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnLinear_Click(object sender, EventArgs e)
        {
            var formLinear = new frmLinear();
            formLinear.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            var formVolume = new frmVolume();
            formVolume.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formAreaVolCalc = new frmAreaVolCalc();
            formAreaVolCalc.Show();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            var formTemp = new frmTemp();
            formTemp.Show();
        }
    }
}
