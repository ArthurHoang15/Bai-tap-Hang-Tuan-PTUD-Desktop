namespace Bai3
{
    partial class Bai3
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
            HoTenLabel = new Label();
            HoText = new TextBox();
            TenText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            KetThucButton = new Button();
            HoTenButton = new Button();
            TenButton = new Button();
            HoButton = new Button();
            SuspendLayout();
            // 
            // HoTenLabel
            // 
            HoTenLabel.AutoSize = true;
            HoTenLabel.BorderStyle = BorderStyle.FixedSingle;
            HoTenLabel.Location = new Point(265, 36);
            HoTenLabel.Name = "HoTenLabel";
            HoTenLabel.Size = new Size(40, 17);
            HoTenLabel.TabIndex = 0;
            HoTenLabel.Text = "label1";
            HoTenLabel.DoubleClick += HoTenLabel_DoubleClick;
            // 
            // HoText
            // 
            HoText.Location = new Point(136, 87);
            HoText.Name = "HoText";
            HoText.Size = new Size(348, 23);
            HoText.TabIndex = 1;
            // 
            // TenText
            // 
            TenText.Location = new Point(133, 131);
            TenText.Name = "TenText";
            TenText.Size = new Size(348, 23);
            TenText.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 95);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Họ lót";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 139);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 4;
            label3.Text = "Tên";
            // 
            // KetThucButton
            // 
            KetThucButton.Location = new Point(190, 220);
            KetThucButton.Name = "KetThucButton";
            KetThucButton.Size = new Size(194, 22);
            KetThucButton.TabIndex = 5;
            KetThucButton.Text = "Thoát chương trình";
            KetThucButton.UseVisualStyleBackColor = true;
            KetThucButton.Click += KetThucButton_Click;
            // 
            // HoTenButton
            // 
            HoTenButton.Location = new Point(383, 176);
            HoTenButton.Name = "HoTenButton";
            HoTenButton.Size = new Size(98, 34);
            HoTenButton.TabIndex = 6;
            HoTenButton.Text = "Họ Và Tên";
            HoTenButton.UseVisualStyleBackColor = true;
            HoTenButton.Click += HoTenButton_Click;
            // 
            // TenButton
            // 
            TenButton.Location = new Point(234, 176);
            TenButton.Name = "TenButton";
            TenButton.Size = new Size(111, 34);
            TenButton.TabIndex = 7;
            TenButton.Text = "Tên";
            TenButton.UseVisualStyleBackColor = true;
            TenButton.Click += TenButton_Click;
            // 
            // HoButton
            // 
            HoButton.Location = new Point(92, 176);
            HoButton.Name = "HoButton";
            HoButton.Size = new Size(94, 34);
            HoButton.TabIndex = 8;
            HoButton.Text = "Họ lót";
            HoButton.UseVisualStyleBackColor = true;
            HoButton.Click += HoButton_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(HoButton);
            Controls.Add(TenButton);
            Controls.Add(HoTenButton);
            Controls.Add(KetThucButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TenText);
            Controls.Add(HoText);
            Controls.Add(HoTenLabel);
            Name = "Bai3";
            Text = "Form1";
            KeyDown += Bai3_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HoTenLabel;
        private TextBox HoText;
        private TextBox TenText;
        private Label label2;
        private Label label3;
        private Button KetThucButton;
        private Button HoTenButton;
        private Button TenButton;
        private Button HoButton;
    }
}
