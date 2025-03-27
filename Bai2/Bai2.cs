namespace Bai2
{
    public partial class frmBtap2 : Form
    {
        public frmBtap2()
        {
            InitializeComponent();
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "This is not a valid number");
                btnShow.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                btnShow.Enabled = true;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My name is: " + textBoxName.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(textBoxYear.Text);
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

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxYear.Clear();

            textBoxName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
