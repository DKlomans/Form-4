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
    public partial class FormCircle : Form
    {
        public FormCircle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtRadius.Text, out double radius))
            {

                double circumference = 2 * Math.PI * radius;
                double area = Math.PI * Math.Pow(radius, 2);


                lblResult.Text = $"Circumference: {circumference:N2}\nArea: {area:N2}";
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the radius.");
            }
        }

        private void FormCircle_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
