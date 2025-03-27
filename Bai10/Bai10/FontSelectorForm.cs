using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap10
{
    public partial class FontSelectorForm : Form
    {
        public FontSelectorForm()
        {
            InitializeComponent();

            // Thiết lập thuộc tính ban đầu cho TextBox
            textBoxInput.Text = "WHAT FONT IS THIS?";
            textBoxInput.ForeColor = Color.Blue;
            textBoxInput.Font = new Font("Tahoma", 12, FontStyle.Bold);

            // Gắn sự kiện CheckedChanged cho các radio button
            radioButtonTimesNewRoman.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonArial.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonTahoma.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonCourierNew.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                string fontName = rb.Text;
                textBoxInput.Font = new Font(fontName, 12, FontStyle.Bold);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
