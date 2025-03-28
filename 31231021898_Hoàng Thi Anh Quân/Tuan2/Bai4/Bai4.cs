namespace Bai4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void VNDtoUSDButton_Click(object sender, EventArgs e)
        {
            double vnd = double.Parse(textBox1.Text);
            double tyGia = double.Parse(TyGiaUSDTextBox.Text);
            TyGiaEURTextBox.Visible = false;
            TyGiaEURLabel.Visible = false;
            TyGiaUSDTextBox.Visible = true;
            TyGiaUSDLabel.Visible = true;
            textBox2.Text = Math.Round(vnd / tyGia).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Đây không phải là một số hợp lệ");
                VNDtoUSDButton.Enabled = false;
                VNDtoEURButton.Enabled = false;
                USDtoVNDButton.Enabled = false;
                EURtoVNDButton.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                VNDtoUSDButton.Enabled = true;
                VNDtoEURButton.Enabled = true;
                USDtoVNDButton.Enabled = true;
                EURtoVNDButton.Enabled = true;
            }
        }

        private void VNDtoEURButton_Click(object sender, EventArgs e)
        {
            double vnd = double.Parse(textBox1.Text);
            double tyGia = double.Parse(TyGiaEURTextBox.Text);
            TyGiaEURTextBox.Visible = true;
            TyGiaEURLabel.Visible = true;
            TyGiaUSDTextBox.Visible = false;
            TyGiaUSDLabel.Visible = false;
            textBox2.Text = Math.Round(vnd / tyGia).ToString();
        }

        private void USDtoVNDButton_Click(object sender, EventArgs e)
        {
            double usd = double.Parse(textBox1.Text);
            double tyGia = double.Parse(TyGiaUSDTextBox.Text);
            TyGiaEURTextBox.Visible = false;
            TyGiaEURLabel.Visible = false;
            TyGiaUSDTextBox.Visible = true;
            TyGiaUSDLabel.Visible = true;
            textBox2.Text = Math.Round(tyGia * usd).ToString();
        }

        private void EURtoVNDButton_Click(object sender, EventArgs e)
        {
            double eur = double.Parse(textBox1.Text);
            double tyGia = double.Parse(TyGiaEURTextBox.Text);
            TyGiaEURTextBox.Visible = true;
            TyGiaEURLabel.Visible = true;
            TyGiaUSDTextBox.Visible = false;
            TyGiaUSDLabel.Visible = false;
            textBox2.Text = Math.Round(tyGia * eur).ToString();
        }

        private void Bai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Muốn tắt thiệt k ba?", "yo",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TyGiaEURTextBox_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Đây không phải là một số hợp lệ");
                VNDtoEURButton.Enabled = false;
                EURtoVNDButton.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                VNDtoEURButton.Enabled = true;
                EURtoVNDButton.Enabled = true;
            }
        }

        private void TyGiaUSDTextBox_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Đây không phải là một số hợp lệ");
                VNDtoUSDButton.Enabled = false;
                USDtoVNDButton.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                VNDtoUSDButton.Enabled = true;
                USDtoVNDButton.Enabled = true;
            }
        }
    }
}
