namespace Bai8
{
    partial class Bai8
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblA = new Label();
            lblB = new Label();
            lblResult = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtResult = new TextBox();
            btnExit = new Button();
            btnDel = new Button();
            btnCal = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(255, 128, 0);
            lblTitle.Location = new Point(136, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(204, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PHƯƠNG TRÌNH: AX+B=0";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA.Location = new Point(52, 71);
            lblA.Name = "lblA";
            lblA.Size = new Size(62, 20);
            lblA.TabIndex = 1;
            lblA.Text = "Nhập A:";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblB.Location = new Point(52, 112);
            lblB.Name = "lblB";
            lblB.Size = new Size(61, 20);
            lblB.TabIndex = 2;
            lblB.Text = "Nhập B:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(26, 156);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(85, 20);
            lblResult.TabIndex = 3;
            lblResult.Text = "Nghiệm PT:";
            // 
            // txtA
            // 
            txtA.Location = new Point(119, 68);
            txtA.Name = "txtA";
            txtA.Size = new Size(262, 23);
            txtA.TabIndex = 4;
            txtA.TextChanged += txtA_TextChanged;
            // 
            // txtB
            // 
            txtB.Location = new Point(119, 109);
            txtB.Name = "txtB";
            txtB.Size = new Size(262, 23);
            txtB.TabIndex = 5;
            txtB.TextChanged += txtB_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(117, 153);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(262, 23);
            txtResult.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(325, 203);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(78, 25);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDel
            // 
            btnDel.Enabled = false;
            btnDel.Location = new Point(226, 203);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(78, 25);
            btnDel.TabIndex = 8;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnCal
            // 
            btnCal.Enabled = false;
            btnCal.Location = new Point(119, 203);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(78, 25);
            btnCal.TabIndex = 9;
            btnCal.Text = "Tính";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Bai8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(btnCal);
            Controls.Add(btnDel);
            Controls.Add(btnExit);
            Controls.Add(txtResult);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblResult);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(lblTitle);
            Name = "Bai8";
            Text = "Form1";
            FormClosing += Bai8_FormClosing;
            FormClosed += Bai8_FormClosed;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblA;
        private Label lblB;
        private Label lblResult;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtResult;
        private Button btnExit;
        private Button btnDel;
        private Button btnCal;
        private ErrorProvider errorProvider1;
    }
}
