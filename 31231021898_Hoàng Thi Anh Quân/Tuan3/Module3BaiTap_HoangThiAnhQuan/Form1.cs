using System.Windows.Forms;

namespace Module3BaiTap_HoangThiAnhQuan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút "Load Folder"
        private void loadFolderButton_Click(object sender, EventArgs e)
        {
            // Tạo một FolderBrowserDialog để chọn thư mục
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;

            // Hiển thị dialog và kiểm tra kết quả
            var res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                // Lấy đường dẫn thư mục được chọn
                string path = dialog.SelectedPath;
                string[] files = Directory.GetFiles(path);

                // Xóa các control cũ trong FlowLayoutPanel (nếu có)
                flowLayoutPanel1.Controls.Clear();

                // Duyệt qua từng file trong thư mục
                foreach (var file in files)
                {
                    // Kiểm tra định dạng file (chỉ lấy .jpg và .png)
                    if (file.EndsWith(".jpg") || file.EndsWith(".png"))
                    {
                        // Tạo một PictureBox mới để hiển thị hình ảnh thu nhỏ
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = new System.Drawing.Bitmap(file); // Tải hình ảnh
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Căn chỉnh hình ảnh
                        pictureBox.Tag = file; // Lưu đường dẫn file vào Tag
                        pictureBox.Size = new System.Drawing.Size(100, 100); // Kích thước thumbnail

                        // Gắn sự kiện Click cho PictureBox thu nhỏ
                        pictureBox.Click += PictureBox_Click;

                        // Thêm PictureBox vào FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(pictureBox);
                    }
                }
            }
        }

        // Sự kiện khi nhấn vào một PictureBox thu nhỏ
        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                // Lấy đường dẫn hình ảnh từ Tag
                string imgPath = pictureBox.Tag.ToString();

                // Hiển thị hình ảnh trong PictureBox chính
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new System.Drawing.Bitmap(imgPath);

                // Cập nhật thông tin trên Label
                label1.Text = $"File {imgPath} is loaded.";
            }
        }
    }
}
