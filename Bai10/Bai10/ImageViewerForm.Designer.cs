namespace Baitap10
{
    partial class ImageViewerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelInstruction = new Label();
            btnBrowse = new Button();
            groupBoxFileStats = new GroupBox();
            lblDateAccessed = new Label();
            lblDateModified = new Label();
            lblSize = new Label();
            panelImage = new Panel();
            pictureBoxImage = new PictureBox();
            openFileDialogPicture = new OpenFileDialog();
            groupBoxFileStats.SuspendLayout();
            panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // labelInstruction
            // 
            labelInstruction.AutoSize = true;
            labelInstruction.Location = new Point(33, 38);
            labelInstruction.Margin = new Padding(5, 0, 5, 0);
            labelInstruction.Name = "labelInstruction";
            labelInstruction.Size = new Size(280, 25);
            labelInstruction.TabIndex = 0;
            labelInstruction.Text = "Click button to open a picture file:";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(33, 96);
            btnBrowse.Margin = new Padding(5, 6, 5, 6);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(125, 44);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // groupBoxFileStats
            // 
            groupBoxFileStats.Controls.Add(lblDateAccessed);
            groupBoxFileStats.Controls.Add(lblDateModified);
            groupBoxFileStats.Controls.Add(lblSize);
            groupBoxFileStats.Location = new Point(33, 154);
            groupBoxFileStats.Margin = new Padding(5, 6, 5, 6);
            groupBoxFileStats.Name = "groupBoxFileStats";
            groupBoxFileStats.Padding = new Padding(5, 6, 5, 6);
            groupBoxFileStats.Size = new Size(417, 192);
            groupBoxFileStats.TabIndex = 2;
            groupBoxFileStats.TabStop = false;
            groupBoxFileStats.Text = "FILE STATISTICS";
            // 
            // lblDateAccessed
            // 
            lblDateAccessed.AutoSize = true;
            lblDateAccessed.Location = new Point(17, 115);
            lblDateAccessed.Margin = new Padding(5, 0, 5, 0);
            lblDateAccessed.Name = "lblDateAccessed";
            lblDateAccessed.Size = new Size(167, 25);
            lblDateAccessed.TabIndex = 2;
            lblDateAccessed.Text = "Date Last Accessed:";
            // 
            // lblDateModified
            // 
            lblDateModified.AutoSize = true;
            lblDateModified.Location = new Point(17, 77);
            lblDateModified.Margin = new Padding(5, 0, 5, 0);
            lblDateModified.Name = "lblDateModified";
            lblDateModified.Size = new Size(166, 25);
            lblDateModified.TabIndex = 1;
            lblDateModified.Text = "Date Last Modified:";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(17, 38);
            lblSize.Margin = new Padding(5, 0, 5, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(78, 25);
            lblSize.TabIndex = 0;
            lblSize.Text = "File Size:";
            // 
            // panelImage
            // 
            panelImage.AutoScroll = true;
            panelImage.Controls.Add(pictureBoxImage);
            panelImage.Location = new Point(33, 365);
            panelImage.Margin = new Padding(5, 6, 5, 6);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(667, 577);
            panelImage.TabIndex = 3;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(0, 0);
            pictureBoxImage.Margin = new Padding(5, 6, 5, 6);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(100, 50);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // openFileDialogPicture
            // 
            openFileDialogPicture.FileName = "openFileDialogPicture";
            // 
            // ImageViewerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 962);
            Controls.Add(panelImage);
            Controls.Add(groupBoxFileStats);
            Controls.Add(btnBrowse);
            Controls.Add(labelInstruction);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ImageViewerForm";
            Text = "StepByStep 2_8";
            groupBoxFileStats.ResumeLayout(false);
            groupBoxFileStats.PerformLayout();
            panelImage.ResumeLayout(false);
            panelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBoxFileStats;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDateModified;
        private System.Windows.Forms.Label lblDateAccessed;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogPicture;
    }
}