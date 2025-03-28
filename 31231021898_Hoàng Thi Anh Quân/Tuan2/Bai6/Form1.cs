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
            NameTextBox.Focus();

            // Đảm bảo hình lớn hiển thị, hình nhỏ ẩn
            BigPictureBox.Visible = true;
            SmallPictureBox.Visible = false;

            // Thêm tooltip cho hình ảnh
            toolTip1.SetToolTip(BigPictureBox, "Click Me");
            toolTip1.SetToolTip(SmallPictureBox, "Click Me");
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = NameTextBox.Text + " : " + MessageTextBox.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MessageTextBox.Clear();
            NameTextBox.Clear();
        }

        private void VisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.Visible = VisibleCheckBox.Checked;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BigPictureBox_Click(object sender, EventArgs e)
        {
            BigPictureBox.Visible = false;
            SmallPictureBox.Visible = true;
        }

        private void SmallPictureBox_Click(object sender, EventArgs e)
        {
            SmallPictureBox.Visible = false;
            BigPictureBox.Visible = true;
        }

        private void RedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RedRadioButton.Checked)
            {
                MessageLabel.ForeColor = Color.Red;
            }
        }

        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (GreenRadioButton.Checked)
            {
                MessageLabel.ForeColor = Color.Green;
            }
        }

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (BlueRadioButton.Checked)
            {
                MessageLabel.ForeColor = Color.Blue;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GreenRadioButton_CheckedChanged(object sender, EventArgs e)
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
