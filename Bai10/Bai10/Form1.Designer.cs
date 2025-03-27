namespace Baitap10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            buttonOpenImageViewer = new Button();
            buttonOpenFontSelector = new Button();
            SuspendLayout();
            // 
            // buttonOpenImageViewer
            // 
            buttonOpenImageViewer.Location = new Point(83, 96);
            buttonOpenImageViewer.Margin = new Padding(5, 6, 5, 6);
            buttonOpenImageViewer.Name = "buttonOpenImageViewer";
            buttonOpenImageViewer.Size = new Size(333, 58);
            buttonOpenImageViewer.TabIndex = 0;
            buttonOpenImageViewer.Text = "Open Image Viewer";
            buttonOpenImageViewer.UseVisualStyleBackColor = true;
            buttonOpenImageViewer.Click += buttonOpenImageViewer_Click;
            // 
            // buttonOpenFontSelector
            // 
            buttonOpenFontSelector.Location = new Point(83, 192);
            buttonOpenFontSelector.Margin = new Padding(5, 6, 5, 6);
            buttonOpenFontSelector.Name = "buttonOpenFontSelector";
            buttonOpenFontSelector.Size = new Size(333, 58);
            buttonOpenFontSelector.TabIndex = 1;
            buttonOpenFontSelector.Text = "Open Font Selector";
            buttonOpenFontSelector.UseVisualStyleBackColor = true;
            buttonOpenFontSelector.Click += buttonOpenFontSelector_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 385);
            Controls.Add(buttonOpenFontSelector);
            Controls.Add(buttonOpenImageViewer);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Main Form";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonOpenImageViewer;
        private System.Windows.Forms.Button buttonOpenFontSelector;
    }
}
