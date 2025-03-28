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
    public partial class ImageViewerForm : Form
    {
        public ImageViewerForm()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            // Thiết lập bộ lọc cho các file ảnh
            openFileDialogPicture.Filter = "Image Files (BMP, GIF, JPEG, etc.)|" +
                "*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.tif;*.tiff|" +
                "BMP Files (*.bmp)|*.bmp|" +
                "GIF Files (*.gif)|*.gif|" +
                "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "PNG Files (*.png)|*.png|" +
                "TIF Files (*.tif;*.tiff)|*.tif;*.tiff|" +
                "All Files (*.*)|*.*";

            if (openFileDialogPicture.ShowDialog() == DialogResult.OK)
            {
                // Lấy thông tin file
                FileInfo file = new FileInfo(openFileDialogPicture.FileName);
                SizeLabel.Text = $"File Size: {file.Length} Bytes";
                DateModifiedLabel.Text = $"Date Last Modified: {file.LastWriteTime.ToLongDateString()}";
                DateAccessedLabel.Text = $"Date Last Accessed: {file.LastAccessTime.ToLongDateString()}";

                // Tải ảnh vào PictureBox
                pictureBoxImage.Image = new Bitmap(openFileDialogPicture.FileName);
            }
        }
    }
}
