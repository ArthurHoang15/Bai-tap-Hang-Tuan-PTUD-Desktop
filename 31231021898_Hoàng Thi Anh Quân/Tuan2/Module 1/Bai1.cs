namespace Module_1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked.");
        }

        private void FormSimpleEvent_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi , Welcome to C# 2010 programming!");
        }

        private void FormSimpleEvent_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Form was clicked.");
        }
    }
}
