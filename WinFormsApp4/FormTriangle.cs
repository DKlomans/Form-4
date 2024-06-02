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
    public partial class FormTriangle : Form
    {
        public FormTriangle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double baseLength = double.Parse(txtBase.Text);
            double height = double.Parse(txtHeight.Text);

            double area = 0.5 * baseLength * height;
            double hypotenuse = Math.Sqrt(Math.Pow(baseLength, 2) + Math.Pow(height, 2));
            double perimeter = baseLength + height + hypotenuse;

            lblResult.Text = $"Area: {area}\nPerimeter: {perimeter}";
        }
    }

}
