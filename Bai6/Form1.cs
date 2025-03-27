namespace Bai_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đặt con trỏ vào ô Name khi form vừa load
            txtName.Focus();

            // Đảm bảo hình lớn hiển thị, hình nhỏ ẩn
            picBig.Visible = true;
            picSmall.Visible = false;

            // Thêm tooltip cho hình ảnh
            toolTip1.SetToolTip(picBig, "Click Me");
            toolTip1.SetToolTip(picSmall, "Click Me");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + " : " + txtMessage.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            txtName.Clear();
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkVisible.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picSmall.Visible = false;
            picBig.Visible = true;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lblMessage.ForeColor = Color.Green;
            }
        }

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lblMessage.ForeColor = Color.Blue;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
