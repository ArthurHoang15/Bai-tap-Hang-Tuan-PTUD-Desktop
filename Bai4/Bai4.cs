namespace Bai4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnVNDtoUSD_Click(object sender, EventArgs e)
        {
            double vnd = double.Parse(textBox1.Text);
            double tyGia = double.Parse(txtTyGiaUSD.Text);
            txtTyGiaEUR.Visible = false;
            lblTyGiaEUR.Visible = false;
            txtTyGiaUSD.Visible = true;
            lblTyGiaUSD.Visible = true;
            textBox2.Text = Math.Round(vnd / tyGia).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Đây không phải là một số hợp lệ");
                btnVNDtoUSD.Enabled = false;
                btnVNDtoEUR.Enabled = false;
                btnUSDtoVND.Enabled = false;
                btnEURtoVND.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                btnVNDtoUSD.Enabled = true;
                btnVNDtoEUR.Enabled = true;
                btnUSDtoVND.Enabled = true;
                btnEURtoVND.Enabled = true;
            }
        }

        private void btnVNDtoEUR_Click(object sender, EventArgs e)
        {
            double vnd = double.Parse(textBox1.Text);
            double tyGia = double.Parse(txtTyGiaEUR.Text);
            txtTyGiaEUR.Visible = true;
            lblTyGiaEUR.Visible = true;
            txtTyGiaUSD.Visible = false;
            lblTyGiaUSD.Visible = false;
            textBox2.Text = Math.Round(vnd / tyGia).ToString();
        }

        private void btnUSDtoVND_Click(object sender, EventArgs e)
        {
            double usd = double.Parse(textBox1.Text);
            double tyGia = double.Parse(txtTyGiaUSD.Text);
            txtTyGiaEUR.Visible = false;
            lblTyGiaEUR.Visible = false;
            txtTyGiaUSD.Visible = true;
            lblTyGiaUSD.Visible = true;
            textBox2.Text = Math.Round(tyGia / usd).ToString();
        }

        private void btnEURtoVND_Click(object sender, EventArgs e)
        {
            double eur = double.Parse(textBox1.Text);
            double tyGia = double.Parse(txtTyGiaEUR.Text);
            txtTyGiaEUR.Visible = true;
            lblTyGiaEUR.Visible = true;
            txtTyGiaUSD.Visible = false;
            lblTyGiaUSD.Visible = false;
            textBox2.Text = Math.Round(tyGia / eur).ToString();
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

        private void txtTyGiaEUR_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Đây không phải là một số hợp lệ");
                btnVNDtoEUR.Enabled = false;
                btnEURtoVND.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                btnVNDtoEUR.Enabled = true;
                btnEURtoVND.Enabled = true;
            }
        }

        private void txtTyGiaUSD_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Đây không phải là một số hợp lệ");
                btnVNDtoUSD.Enabled = false;
                btnUSDtoVND.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                btnVNDtoUSD.Enabled = true;
                btnUSDtoVND.Enabled = true;
            }
        }
    }
}
