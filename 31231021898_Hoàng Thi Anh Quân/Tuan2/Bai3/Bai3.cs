namespace Bai3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HoButton_Click(object sender, EventArgs e)
        {
            HoTenLabel.Text = HoText.Text;
        }

        private void TenButton_Click(object sender, EventArgs e)
        {
            HoTenLabel.Text = TenText.Text;
        }

        private void HoTenButton_Click(object sender, EventArgs e)
        {
            HoTenLabel.Text = HoText.Text + " " + TenText.Text;
        }

        private void HoTenLabel_DoubleClick(object sender, EventArgs e)
        {
            HoTenLabel.Text = "";
        }

        private void Bai3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HoTenButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                KetThucButton.PerformClick();
            }
        }

        private void KetThucButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
