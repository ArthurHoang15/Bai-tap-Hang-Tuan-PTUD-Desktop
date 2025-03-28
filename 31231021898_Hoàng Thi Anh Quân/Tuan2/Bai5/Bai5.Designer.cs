namespace Bai5
{
    partial class Bai5
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NhapTenLabel = new Label();
            NhapTenTextBox = new TextBox();
            FontGroupBox = new GroupBox();
            UnderlineCheckBox = new CheckBox();
            ItalicCheckBox = new CheckBox();
            BoldCheckBox = new CheckBox();
            ColorGroupBox = new GroupBox();
            BlackRadioButton = new RadioButton();
            BlueRadioButton = new RadioButton();
            GreenRadioButton = new RadioButton();
            RedRadioButton = new RadioButton();
            LapTrinhLabel = new Label();
            LapTrinhTextBox = new TextBox();
            ThoatButton = new Button();
            FontGroupBox.SuspendLayout();
            ColorGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // NhapTenLabel
            // 
            NhapTenLabel.AutoSize = true;
            NhapTenLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NhapTenLabel.Location = new Point(25, 19);
            NhapTenLabel.Name = "NhapTenLabel";
            NhapTenLabel.Size = new Size(61, 15);
            NhapTenLabel.TabIndex = 0;
            NhapTenLabel.Text = "Nhập tên:";
            // 
            // NhapTenTextBox
            // 
            NhapTenTextBox.Location = new Point(90, 16);
            NhapTenTextBox.Name = "NhapTenTextBox";
            NhapTenTextBox.Size = new Size(260, 23);
            NhapTenTextBox.TabIndex = 1;
            NhapTenTextBox.TextChanged += NhapTenTextBox_TextChanged;
            // 
            // FontGroupBox
            // 
            FontGroupBox.BackColor = Color.Green;
            FontGroupBox.Controls.Add(UnderlineCheckBox);
            FontGroupBox.Controls.Add(ItalicCheckBox);
            FontGroupBox.Controls.Add(BoldCheckBox);
            FontGroupBox.Location = new Point(215, 75);
            FontGroupBox.Name = "FontGroupBox";
            FontGroupBox.Size = new Size(143, 126);
            FontGroupBox.TabIndex = 2;
            FontGroupBox.TabStop = false;
            FontGroupBox.Text = "Font";
            // 
            // UnderlineCheckBox
            // 
            UnderlineCheckBox.AutoSize = true;
            UnderlineCheckBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            UnderlineCheckBox.Location = new Point(6, 97);
            UnderlineCheckBox.Name = "UnderlineCheckBox";
            UnderlineCheckBox.Size = new Size(134, 17);
            UnderlineCheckBox.TabIndex = 2;
            UnderlineCheckBox.Text = "Gạch chân Underline";
            UnderlineCheckBox.UseVisualStyleBackColor = true;
            UnderlineCheckBox.CheckedChanged += chkFontStyle_CheckedChanged;
            // 
            // ItalicCheckBox
            // 
            ItalicCheckBox.AutoSize = true;
            ItalicCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ItalicCheckBox.Location = new Point(6, 61);
            ItalicCheckBox.Name = "ItalicCheckBox";
            ItalicCheckBox.Size = new Size(104, 21);
            ItalicCheckBox.TabIndex = 1;
            ItalicCheckBox.Text = "Nghiêng Italic";
            ItalicCheckBox.UseVisualStyleBackColor = true;
            ItalicCheckBox.CheckedChanged += chkFontStyle_CheckedChanged;
            // 
            // BoldCheckBox
            // 
            BoldCheckBox.AutoSize = true;
            BoldCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BoldCheckBox.Location = new Point(6, 23);
            BoldCheckBox.Name = "BoldCheckBox";
            BoldCheckBox.Size = new Size(88, 21);
            BoldCheckBox.TabIndex = 0;
            BoldCheckBox.Text = "Đậm Bold";
            BoldCheckBox.UseVisualStyleBackColor = true;
            BoldCheckBox.CheckedChanged += chkFontStyle_CheckedChanged;
            // 
            // ColorGroupBox
            // 
            ColorGroupBox.BackColor = Color.FromArgb(0, 192, 192);
            ColorGroupBox.Controls.Add(BlackRadioButton);
            ColorGroupBox.Controls.Add(BlueRadioButton);
            ColorGroupBox.Controls.Add(GreenRadioButton);
            ColorGroupBox.Controls.Add(RedRadioButton);
            ColorGroupBox.Location = new Point(34, 75);
            ColorGroupBox.Name = "ColorGroupBox";
            ColorGroupBox.Size = new Size(135, 126);
            ColorGroupBox.TabIndex = 3;
            ColorGroupBox.TabStop = false;
            ColorGroupBox.Text = "Color";
            // 
            // BlackRadioButton
            // 
            BlackRadioButton.AutoSize = true;
            BlackRadioButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BlackRadioButton.Location = new Point(6, 97);
            BlackRadioButton.Name = "BlackRadioButton";
            BlackRadioButton.Size = new Size(58, 21);
            BlackRadioButton.TabIndex = 4;
            BlackRadioButton.TabStop = true;
            BlackRadioButton.Text = "Black";
            BlackRadioButton.UseVisualStyleBackColor = true;
            BlackRadioButton.CheckedChanged += radColor_CheckedChanged;
            // 
            // BlueRadioButton
            // 
            BlueRadioButton.AutoSize = true;
            BlueRadioButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BlueRadioButton.ForeColor = Color.FromArgb(0, 0, 192);
            BlueRadioButton.Location = new Point(6, 72);
            BlueRadioButton.Name = "BlueRadioButton";
            BlueRadioButton.Size = new Size(53, 21);
            BlueRadioButton.TabIndex = 4;
            BlueRadioButton.TabStop = true;
            BlueRadioButton.Text = "Blue";
            BlueRadioButton.UseVisualStyleBackColor = true;
            BlueRadioButton.CheckedChanged += radColor_CheckedChanged;
            // 
            // GreenRadioButton
            // 
            GreenRadioButton.AutoSize = true;
            GreenRadioButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GreenRadioButton.ForeColor = Color.FromArgb(0, 192, 0);
            GreenRadioButton.Location = new Point(6, 47);
            GreenRadioButton.Name = "GreenRadioButton";
            GreenRadioButton.Size = new Size(62, 21);
            GreenRadioButton.TabIndex = 4;
            GreenRadioButton.TabStop = true;
            GreenRadioButton.Text = "Green";
            GreenRadioButton.UseVisualStyleBackColor = true;
            GreenRadioButton.CheckedChanged += radColor_CheckedChanged;
            // 
            // RedRadioButton
            // 
            RedRadioButton.AutoSize = true;
            RedRadioButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RedRadioButton.ForeColor = Color.FromArgb(192, 0, 0);
            RedRadioButton.Location = new Point(6, 22);
            RedRadioButton.Name = "RedRadioButton";
            RedRadioButton.Size = new Size(49, 21);
            RedRadioButton.TabIndex = 4;
            RedRadioButton.TabStop = true;
            RedRadioButton.Text = "Red";
            RedRadioButton.UseVisualStyleBackColor = true;
            RedRadioButton.CheckedChanged += radColor_CheckedChanged;
            // 
            // LapTrinhLabel
            // 
            LapTrinhLabel.AutoSize = true;
            LapTrinhLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LapTrinhLabel.Location = new Point(6, 224);
            LapTrinhLabel.Name = "LapTrinhLabel";
            LapTrinhLabel.Size = new Size(80, 15);
            LapTrinhLabel.TabIndex = 4;
            LapTrinhLabel.Text = "Lập trình bởi:";
            // 
            // LapTrinhTextBox
            // 
            LapTrinhTextBox.Location = new Point(92, 216);
            LapTrinhTextBox.Name = "LapTrinhTextBox";
            LapTrinhTextBox.Size = new Size(186, 23);
            LapTrinhTextBox.TabIndex = 5;
            // 
            // ThoatButton
            // 
            ThoatButton.Location = new Point(290, 213);
            ThoatButton.Name = "ThoatButton";
            ThoatButton.Size = new Size(82, 36);
            ThoatButton.TabIndex = 6;
            ThoatButton.Text = "Thoát";
            ThoatButton.UseVisualStyleBackColor = true;
            ThoatButton.Click += ThoatButton_Click;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(ThoatButton);
            Controls.Add(LapTrinhTextBox);
            Controls.Add(LapTrinhLabel);
            Controls.Add(ColorGroupBox);
            Controls.Add(FontGroupBox);
            Controls.Add(NhapTenTextBox);
            Controls.Add(NhapTenLabel);
            Name = "Bai5";
            Text = "Form1";
            Load += Bai5_Load;
            KeyDown += Bai5_KeyDown;
            KeyPress += Bai5_KeyPress;
            FontGroupBox.ResumeLayout(false);
            FontGroupBox.PerformLayout();
            ColorGroupBox.ResumeLayout(false);
            ColorGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NhapTenLabel;
        private TextBox NhapTenTextBox;
        private GroupBox FontGroupBox;
        private CheckBox UnderlineCheckBox;
        private CheckBox ItalicCheckBox;
        private CheckBox BoldCheckBox;
        private GroupBox ColorGroupBox;
        private RadioButton BlackRadioButton;
        private RadioButton BlueRadioButton;
        private RadioButton GreenRadioButton;
        private RadioButton RedRadioButton;
        private Label LapTrinhLabel;
        private TextBox LapTrinhTextBox;
        private Button ThoatButton;
    }
}
