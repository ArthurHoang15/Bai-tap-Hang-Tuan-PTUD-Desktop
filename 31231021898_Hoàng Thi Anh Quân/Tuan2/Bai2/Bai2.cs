namespace Bai2
{
    public partial class frmBtap2 : Form
    {
        public frmBtap2()
        {
            InitializeComponent();
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "This is not a valid number");
                
                ShowButton.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                ShowButton.Enabled = true;
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My name is: " + NameTextBox.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(YearTextBox.Text);
            s = s + "Age: " + age.ToString();
            MessageBox.Show(s, "Result");
        }

        private void frmBtap2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you really want to close?", "Ex1",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "You must enter Your Name");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Clear();
            YearTextBox.Clear();

            NameTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
