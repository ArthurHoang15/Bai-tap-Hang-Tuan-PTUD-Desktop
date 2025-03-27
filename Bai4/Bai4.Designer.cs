namespace Bai4
{
    partial class Bai4
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            btnEURtoVND = new Button();
            btnUSDtoVND = new Button();
            btnVNDtoEUR = new Button();
            btnVNDtoUSD = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            lblTyGiaUSD = new Label();
            lblTyGiaEUR = new Label();
            txtTyGiaUSD = new TextBox();
            txtTyGiaEUR = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(250, 26);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "ĐỔI TIỀN";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 79);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Tiền quy đổi:";
            // 
            // btnEURtoVND
            // 
            btnEURtoVND.Location = new Point(416, 124);
            btnEURtoVND.Name = "btnEURtoVND";
            btnEURtoVND.Size = new Size(96, 25);
            btnEURtoVND.TabIndex = 3;
            btnEURtoVND.Text = "EURtoVND";
            btnEURtoVND.UseVisualStyleBackColor = true;
            btnEURtoVND.Click += btnEURtoVND_Click;
            // 
            // btnUSDtoVND
            // 
            btnUSDtoVND.Location = new Point(301, 124);
            btnUSDtoVND.Name = "btnUSDtoVND";
            btnUSDtoVND.Size = new Size(96, 25);
            btnUSDtoVND.TabIndex = 4;
            btnUSDtoVND.Text = "USDtoVND";
            btnUSDtoVND.UseVisualStyleBackColor = true;
            btnUSDtoVND.Click += btnUSDtoVND_Click;
            // 
            // btnVNDtoEUR
            // 
            btnVNDtoEUR.Location = new Point(184, 124);
            btnVNDtoEUR.Name = "btnVNDtoEUR";
            btnVNDtoEUR.Size = new Size(96, 25);
            btnVNDtoEUR.TabIndex = 5;
            btnVNDtoEUR.Text = "VNDtoEUR";
            btnVNDtoEUR.UseVisualStyleBackColor = true;
            btnVNDtoEUR.Click += btnVNDtoEUR_Click;
            // 
            // btnVNDtoUSD
            // 
            btnVNDtoUSD.Location = new Point(71, 124);
            btnVNDtoUSD.Name = "btnVNDtoUSD";
            btnVNDtoUSD.Size = new Size(96, 25);
            btnVNDtoUSD.TabIndex = 6;
            btnVNDtoUSD.Text = "VNDtoUSD";
            btnVNDtoUSD.UseVisualStyleBackColor = true;
            btnVNDtoUSD.Click += btnVNDtoUSD_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 174);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(312, 23);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 182);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 8;
            label3.Text = "Kết quả:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblTyGiaUSD
            // 
            lblTyGiaUSD.AutoSize = true;
            lblTyGiaUSD.Location = new Point(12, 9);
            lblTyGiaUSD.Name = "lblTyGiaUSD";
            lblTyGiaUSD.Size = new Size(64, 15);
            lblTyGiaUSD.TabIndex = 9;
            lblTyGiaUSD.Text = "Tỷ giá USD";
            lblTyGiaUSD.Visible = false;
            lblTyGiaUSD.Click += label4_Click;
            // 
            // lblTyGiaEUR
            // 
            lblTyGiaEUR.AutoSize = true;
            lblTyGiaEUR.Location = new Point(12, 9);
            lblTyGiaEUR.Name = "lblTyGiaEUR";
            lblTyGiaEUR.Size = new Size(63, 15);
            lblTyGiaEUR.TabIndex = 10;
            lblTyGiaEUR.Text = "Tỷ giá EUR";
            lblTyGiaEUR.Visible = false;
            // 
            // txtTyGiaUSD
            // 
            txtTyGiaUSD.Location = new Point(12, 31);
            txtTyGiaUSD.Name = "txtTyGiaUSD";
            txtTyGiaUSD.Size = new Size(53, 23);
            txtTyGiaUSD.TabIndex = 11;
            txtTyGiaUSD.Text = "17861";
            txtTyGiaUSD.Visible = false;
            txtTyGiaUSD.TextChanged += txtTyGiaUSD_TextChanged;
            // 
            // txtTyGiaEUR
            // 
            txtTyGiaEUR.Location = new Point(12, 31);
            txtTyGiaEUR.Name = "txtTyGiaEUR";
            txtTyGiaEUR.Size = new Size(53, 23);
            txtTyGiaEUR.TabIndex = 12;
            txtTyGiaEUR.Text = "27043";
            txtTyGiaEUR.Visible = false;
            txtTyGiaEUR.TextChanged += txtTyGiaEUR_TextChanged;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 230);
            Controls.Add(txtTyGiaEUR);
            Controls.Add(txtTyGiaUSD);
            Controls.Add(lblTyGiaEUR);
            Controls.Add(lblTyGiaUSD);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(btnVNDtoUSD);
            Controls.Add(btnVNDtoEUR);
            Controls.Add(btnUSDtoVND);
            Controls.Add(btnEURtoVND);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Bai4";
            Text = "Form1";
            FormClosing += Bai4_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button btnEURtoVND;
        private Button btnUSDtoVND;
        private Button btnVNDtoEUR;
        private Button btnVNDtoUSD;
        private TextBox textBox2;
        private Label label3;
        private ErrorProvider errorProvider1;
        private Label lblTyGiaUSD;
        private TextBox txtTyGiaEUR;
        private TextBox txtTyGiaUSD;
        private Label lblTyGiaEUR;
    }
}
