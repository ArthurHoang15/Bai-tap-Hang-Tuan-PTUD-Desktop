namespace Bai8
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Đây không phải là một số hợp lệ!");
                btnCal.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                btnCal.Enabled = true;
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Đây không phải là một số hợp lệ!");
                btnCal.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                btnCal.Enabled = true;
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text), b = double.Parse(txtB.Text);
            if (a == 0)
            {
                if (b == 0)
                    txtResult.Text = "Vô số nghiệm";
                else
                    txtResult.Text = "Vô nghiệm";
            }
            else
            {
                double x = -b / a;
                txtResult.Text = "Nghiệm x = " + x.ToString("F2");
            }

            btnDel.Enabled = true;
            btnCal.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtResult.Text = "";
            txtA.Focus();
            btnDel.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Muốn thoát thiệt k ní?",
                                          "ayyo",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Bai8_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Bai8_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Muốn thoát thiệt k ní?", "ayyo",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
