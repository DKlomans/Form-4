using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FormEquation : Form
    {
        public FormEquation()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double y = 0;

            if (x < 0)
                y = Math.Pow(x, 3) + 3 * x;
            else if (x == 0)
                y = 2 * x - 5;
            else if (x <= 5)
                y = Math.Pow(x, 4) + 3 * Math.Pow(x, 2) - 1;
            else if (x <= 10)
                y = Math.Pow((x * 5 - x), 2);
            else
                y = Math.Pow(4 * x + 1, 3);

            lblResult.Text = "Result: " + y.ToString();
        }
    }

}
