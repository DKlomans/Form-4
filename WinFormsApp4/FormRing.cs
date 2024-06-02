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
    public partial class FormRing : Form
    {
        public FormRing()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double outerRadius = double.Parse(txtOuterRadius.Text);
            double innerRadius = double.Parse(txtInnerRadius.Text);

            double outerArea = Math.PI * Math.Pow(outerRadius, 2);
            double innerArea = Math.PI * Math.Pow(innerRadius, 2);
            double ringArea = outerArea - innerArea;

            lblResult.Text = $"Ring Area: {ringArea}";
        }
    }

}
