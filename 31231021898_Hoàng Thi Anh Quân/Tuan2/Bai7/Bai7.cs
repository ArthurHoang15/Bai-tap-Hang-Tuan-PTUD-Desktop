namespace Bai7
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void picOn_Click(object sender, EventArgs e)
        {
            picOn.Visible = false;
            picOff.Visible = true;
            lblWtfIsThis.Text = txtName.Text + " Turn Off the Light, please!”";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
