namespace Bai8
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void ATextBox_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Đây không phải là một số hợp lệ!");
                CalculateButton.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                CalculateButton.Enabled = true;
            }
        }

        private void BTextBox_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Đây không phải là một số hợp lệ!");
                CalculateButton.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                CalculateButton.Enabled = true;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double a = double.Parse(ATextBox.Text), b = double.Parse(BTextBox.Text);
            if (a == 0)
            {
                if (b == 0)
                    ResultTextBox.Text = "Vô số nghiệm";
                else
                    ResultTextBox.Text = "Vô nghiệm";
            }
            else
            {
                double x = -b / a;
                ResultTextBox.Text = "Nghiệm x = " + x.ToString("F2");
            }

            DeleteButton.Enabled = true;
            CalculateButton.Enabled = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ATextBox.Text = "";
            BTextBox.Text = "";
            ResultTextBox.Text = "";
            ATextBox.Focus();
            DeleteButton.Enabled = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
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
