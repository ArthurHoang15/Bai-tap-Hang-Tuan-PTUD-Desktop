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
            lblHoTen = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnKetThuc = new Button();
            btnHoTen = new Button();
            btnTen = new Button();
            btnHo = new Button();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.BorderStyle = BorderStyle.FixedSingle;
            lblHoTen.Location = new Point(265, 36);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(40, 17);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "label1";
            lblHoTen.DoubleClick += lblHoTen_DoubleClick;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(136, 87);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(348, 23);
            txtHo.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(133, 131);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(348, 23);
            txtTen.TabIndex = 2;
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
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(190, 220);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(194, 22);
            btnKetThuc.TabIndex = 5;
            btnKetThuc.Text = "Thoát chương trình";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(383, 176);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(98, 34);
            btnHoTen.TabIndex = 6;
            btnHoTen.Text = "Họ Và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(234, 176);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(111, 34);
            btnTen.TabIndex = 7;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(92, 176);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(94, 34);
            btnHo.TabIndex = 8;
            btnHo.Text = "Họ lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(btnHo);
            Controls.Add(btnTen);
            Controls.Add(btnHoTen);
            Controls.Add(btnKetThuc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(lblHoTen);
            Name = "Bai3";
            Text = "Form1";
            KeyDown += Bai3_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private TextBox txtHo;
        private TextBox txtTen;
        private Label label2;
        private Label label3;
        private Button btnKetThuc;
        private Button btnHoTen;
        private Button btnTen;
        private Button btnHo;
    }
}
