namespace Bai5
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void NhapTenTextBox_TextChanged(object sender, EventArgs e)
        {
            LapTrinhTextBox.Text = NhapTenTextBox.Text;
        }

        private void Bai5_Load(object sender, EventArgs e)
        {
            RedRadioButton.Checked = true;
            NhapTenTextBox.Focus();
        }

        private void Bai5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Bai5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ThoatButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
            {
                switch (r.Name)
                {
                    case "RedRadioButton":
                        LapTrinhTextBox.ForeColor = Color.Red;
                        NhapTenLabel.ForeColor = Color.Red;
                        break;
                    case "GreenRadioButton":
                        LapTrinhTextBox.ForeColor = Color.Green;
                        NhapTenLabel.ForeColor = Color.Green;
                        break;
                    case "BlueRadioButton":
                        LapTrinhTextBox.ForeColor = Color.Blue;
                        NhapTenLabel.ForeColor = Color.Blue;
                        break;
                    case "BlackRadioButton":
                        LapTrinhTextBox.ForeColor = Color.Black;
                        NhapTenLabel.ForeColor = Color.Black;
                        break;
                }
            }
        }

        private void chkFontStyle_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;
            if (BoldCheckBox.Checked) style |= FontStyle.Bold;
            if (ItalicCheckBox.Checked) style |= FontStyle.Italic;
            if (UnderlineCheckBox.Checked) style |= FontStyle.Underline;

            LapTrinhTextBox.Font = new Font(LapTrinhTextBox.Font.Name, LapTrinhTextBox.Font.Size, style);
            NhapTenLabel.Font = new Font(NhapTenLabel.Font.Name, NhapTenLabel.Font.Size, style);
        }
    }
}
