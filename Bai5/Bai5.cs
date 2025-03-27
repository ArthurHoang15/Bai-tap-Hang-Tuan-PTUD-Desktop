namespace Bai5
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Text = txtNhapTen.Text;
        }

        private void Bai5_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            txtNhapTen.Focus();
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

        private void btnThoat_Click(object sender, EventArgs e)
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
                    case "radRed":
                        txtLapTrinh.ForeColor = Color.Red;
                        lblNhapTen.ForeColor = Color.Red;
                        break;
                    case "radGreen":
                        txtLapTrinh.ForeColor = Color.Green;
                        lblNhapTen.ForeColor = Color.Green;
                        break;
                    case "radBlue":
                        txtLapTrinh.ForeColor = Color.Blue;
                        lblNhapTen.ForeColor = Color.Blue;
                        break;
                    case "radBlack":
                        txtLapTrinh.ForeColor = Color.Black;
                        lblNhapTen.ForeColor = Color.Black;
                        break;
                }
            }
        }

        private void chkFontStyle_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;
            if (chkBold.Checked) style |= FontStyle.Bold;
            if (chkItalic.Checked) style |= FontStyle.Italic;
            if (chkUnderline.Checked) style |= FontStyle.Underline;

            txtLapTrinh.Font = new Font(txtLapTrinh.Font.Name, txtLapTrinh.Font.Size, style);
            lblNhapTen.Font = new Font(lblNhapTen.Font.Name, lblNhapTen.Font.Size, style);
        }
    }
}
