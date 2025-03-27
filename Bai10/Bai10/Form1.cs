namespace Baitap10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenImageViewer_Click(object sender, EventArgs e)
        {
            ImageViewerForm form = new ImageViewerForm();
            form.Show();
        }

        private void buttonOpenFontSelector_Click(object sender, EventArgs e)
        {
            FontSelectorForm form = new FontSelectorForm();
            form.Show();
        }
    }
}
