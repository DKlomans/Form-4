namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEquation_Click(object sender, EventArgs e)
        {
            var form = new FormEquation();
            form.Show();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            var form = new FormCircle();
            form.Show();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            var form = new FormTriangle();
            form.Show();
        }

        private void btnRing_Click(object sender, EventArgs e)
        {
            var form = new FormRing();
            form.Show();
        }
    }

}
