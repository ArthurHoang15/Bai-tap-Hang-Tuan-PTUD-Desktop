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
            InstructionLabel = new Label();
            BrowseButton = new Button();
            groupBoxFileStats = new GroupBox();
            DateAccessedLabel = new Label();
            DateModifiedLabel = new Label();
            SizeLabel = new Label();
            panelImage = new Panel();
            pictureBoxImage = new PictureBox();
            openFileDialogPicture = new OpenFileDialog();
            groupBoxFileStats.SuspendLayout();
            panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // InstructionLabel
            // 
            InstructionLabel.AutoSize = true;
            InstructionLabel.Location = new Point(33, 38);
            InstructionLabel.Margin = new Padding(5, 0, 5, 0);
            InstructionLabel.Name = "InstructionLabel";
            InstructionLabel.Size = new Size(280, 25);
            InstructionLabel.TabIndex = 0;
            InstructionLabel.Text = "Click button to open a picture file:";
            // 
            // BrowseButton
            // 
            BrowseButton.Location = new Point(33, 96);
            BrowseButton.Margin = new Padding(5, 6, 5, 6);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(125, 44);
            BrowseButton.TabIndex = 1;
            BrowseButton.Text = "Browse...";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // groupBoxFileStats
            // 
            groupBoxFileStats.Controls.Add(DateAccessedLabel);
            groupBoxFileStats.Controls.Add(DateModifiedLabel);
            groupBoxFileStats.Controls.Add(SizeLabel);
            groupBoxFileStats.Location = new Point(33, 154);
            groupBoxFileStats.Margin = new Padding(5, 6, 5, 6);
            groupBoxFileStats.Name = "groupBoxFileStats";
            groupBoxFileStats.Padding = new Padding(5, 6, 5, 6);
            groupBoxFileStats.Size = new Size(417, 192);
            groupBoxFileStats.TabIndex = 2;
            groupBoxFileStats.TabStop = false;
            groupBoxFileStats.Text = "FILE STATISTICS";
            // 
            // DateAccessedLabel
            // 
            DateAccessedLabel.AutoSize = true;
            DateAccessedLabel.Location = new Point(17, 115);
            DateAccessedLabel.Margin = new Padding(5, 0, 5, 0);
            DateAccessedLabel.Name = "DateAccessedLabel";
            DateAccessedLabel.Size = new Size(167, 25);
            DateAccessedLabel.TabIndex = 2;
            DateAccessedLabel.Text = "Date Last Accessed:";
            // 
            // DateModifiedLabel
            // 
            DateModifiedLabel.AutoSize = true;
            DateModifiedLabel.Location = new Point(17, 77);
            DateModifiedLabel.Margin = new Padding(5, 0, 5, 0);
            DateModifiedLabel.Name = "DateModifiedLabel";
            DateModifiedLabel.Size = new Size(166, 25);
            DateModifiedLabel.TabIndex = 1;
            DateModifiedLabel.Text = "Date Last Modified:";
            // 
            // SizeLabel
            // 
            SizeLabel.AutoSize = true;
            SizeLabel.Location = new Point(17, 38);
            SizeLabel.Margin = new Padding(5, 0, 5, 0);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(78, 25);
            SizeLabel.TabIndex = 0;
            SizeLabel.Text = "File Size:";
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
            Controls.Add(BrowseButton);
            Controls.Add(InstructionLabel);
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

        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.GroupBox groupBoxFileStats;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label DateModifiedLabel;
        private System.Windows.Forms.Label DateAccessedLabel;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogPicture;
    }
}