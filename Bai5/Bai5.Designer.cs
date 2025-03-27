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
            lblNhapTen = new Label();
            txtNhapTen = new TextBox();
            grpFont = new GroupBox();
            chkUnderline = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            grpColor = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            lblLapTrinh = new Label();
            txtLapTrinh = new TextBox();
            btnThoat = new Button();
            grpFont.SuspendLayout();
            grpColor.SuspendLayout();
            SuspendLayout();
            // 
            // lblNhapTen
            // 
            lblNhapTen.AutoSize = true;
            lblNhapTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhapTen.Location = new Point(25, 19);
            lblNhapTen.Name = "lblNhapTen";
            lblNhapTen.Size = new Size(61, 15);
            lblNhapTen.TabIndex = 0;
            lblNhapTen.Text = "Nhập tên:";
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(90, 16);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(260, 23);
            txtNhapTen.TabIndex = 1;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // grpFont
            // 
            grpFont.BackColor = Color.Green;
            grpFont.Controls.Add(chkUnderline);
            grpFont.Controls.Add(chkItalic);
            grpFont.Controls.Add(chkBold);
            grpFont.Location = new Point(215, 75);
            grpFont.Name = "grpFont";
            grpFont.Size = new Size(143, 126);
            grpFont.TabIndex = 2;
            grpFont.TabStop = false;
            grpFont.Text = "Font";
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Font = new Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            chkUnderline.Location = new Point(6, 97);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(134, 17);
            chkUnderline.TabIndex = 2;
            chkUnderline.Text = "Gạch chân Underline";
            chkUnderline.UseVisualStyleBackColor = true;
            chkUnderline.CheckedChanged += chkFontStyle_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkItalic.Location = new Point(6, 61);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(104, 21);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkFontStyle_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkBold.Location = new Point(6, 23);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(88, 21);
            chkBold.TabIndex = 0;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkFontStyle_CheckedChanged;
            // 
            // grpColor
            // 
            grpColor.BackColor = Color.FromArgb(0, 192, 192);
            grpColor.Controls.Add(radBlack);
            grpColor.Controls.Add(radBlue);
            grpColor.Controls.Add(radGreen);
            grpColor.Controls.Add(radRed);
            grpColor.Location = new Point(34, 75);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(135, 126);
            grpColor.TabIndex = 3;
            grpColor.TabStop = false;
            grpColor.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBlack.Location = new Point(6, 97);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(58, 21);
            radBlack.TabIndex = 4;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radColor_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBlue.ForeColor = Color.FromArgb(0, 0, 192);
            radBlue.Location = new Point(6, 72);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(53, 21);
            radBlue.TabIndex = 4;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radColor_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radGreen.ForeColor = Color.FromArgb(0, 192, 0);
            radGreen.Location = new Point(6, 47);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(62, 21);
            radGreen.TabIndex = 4;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radColor_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radRed.ForeColor = Color.FromArgb(192, 0, 0);
            radRed.Location = new Point(6, 22);
            radRed.Name = "radRed";
            radRed.Size = new Size(49, 21);
            radRed.TabIndex = 4;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radColor_CheckedChanged;
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.AutoSize = true;
            lblLapTrinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLapTrinh.Location = new Point(6, 224);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(80, 15);
            lblLapTrinh.TabIndex = 4;
            lblLapTrinh.Text = "Lập trình bởi:";
            // 
            // txtLapTrinh
            // 
            txtLapTrinh.Location = new Point(92, 216);
            txtLapTrinh.Name = "txtLapTrinh";
            txtLapTrinh.Size = new Size(186, 23);
            txtLapTrinh.TabIndex = 5;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(290, 213);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(82, 36);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(btnThoat);
            Controls.Add(txtLapTrinh);
            Controls.Add(lblLapTrinh);
            Controls.Add(grpColor);
            Controls.Add(grpFont);
            Controls.Add(txtNhapTen);
            Controls.Add(lblNhapTen);
            Name = "Bai5";
            Text = "Form1";
            Load += Bai5_Load;
            KeyDown += Bai5_KeyDown;
            KeyPress += Bai5_KeyPress;
            grpFont.ResumeLayout(false);
            grpFont.PerformLayout();
            grpColor.ResumeLayout(false);
            grpColor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhapTen;
        private TextBox txtNhapTen;
        private GroupBox grpFont;
        private CheckBox checkBox4;
        private CheckBox chkUnderline;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private GroupBox grpColor;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private Label lblLapTrinh;
        private TextBox txtLapTrinh;
        private Button btnThoat;
    }
}
