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
            EURtoVNDButton = new Button();
            USDtoVNDButton = new Button();
            VNDtoEURButton = new Button();
            VNDtoUSDButton = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            TyGiaUSDLabel = new Label();
            TyGiaEURLabel = new Label();
            TyGiaUSDTextBox = new TextBox();
            TyGiaEURTextBox = new TextBox();
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
            // EURtoVNDButton
            // 
            EURtoVNDButton.Location = new Point(416, 124);
            EURtoVNDButton.Name = "EURtoVNDButton";
            EURtoVNDButton.Size = new Size(96, 25);
            EURtoVNDButton.TabIndex = 3;
            EURtoVNDButton.Text = "EURtoVND";
            EURtoVNDButton.UseVisualStyleBackColor = true;
            EURtoVNDButton.Click += EURtoVNDButton_Click;
            // 
            // USDtoVNDButton
            // 
            USDtoVNDButton.Location = new Point(301, 124);
            USDtoVNDButton.Name = "USDtoVNDButton";
            USDtoVNDButton.Size = new Size(96, 25);
            USDtoVNDButton.TabIndex = 4;
            USDtoVNDButton.Text = "USDtoVND";
            USDtoVNDButton.UseVisualStyleBackColor = true;
            USDtoVNDButton.Click += USDtoVNDButton_Click;
            // 
            // VNDtoEURButton
            // 
            VNDtoEURButton.Location = new Point(184, 124);
            VNDtoEURButton.Name = "VNDtoEURButton";
            VNDtoEURButton.Size = new Size(96, 25);
            VNDtoEURButton.TabIndex = 5;
            VNDtoEURButton.Text = "VNDtoEUR";
            VNDtoEURButton.UseVisualStyleBackColor = true;
            VNDtoEURButton.Click += VNDtoEURButton_Click;
            // 
            // VNDtoUSDButton
            // 
            VNDtoUSDButton.Location = new Point(71, 124);
            VNDtoUSDButton.Name = "VNDtoUSDButton";
            VNDtoUSDButton.Size = new Size(96, 25);
            VNDtoUSDButton.TabIndex = 6;
            VNDtoUSDButton.Text = "VNDtoUSD";
            VNDtoUSDButton.UseVisualStyleBackColor = true;
            VNDtoUSDButton.Click += VNDtoUSDButton_Click;
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
            // TyGiaUSDLabel
            // 
            TyGiaUSDLabel.AutoSize = true;
            TyGiaUSDLabel.Location = new Point(12, 9);
            TyGiaUSDLabel.Name = "TyGiaUSDLabel";
            TyGiaUSDLabel.Size = new Size(64, 15);
            TyGiaUSDLabel.TabIndex = 9;
            TyGiaUSDLabel.Text = "Tỷ giá USD";
            TyGiaUSDLabel.Visible = false;
            TyGiaUSDLabel.Click += label4_Click;
            // 
            // TyGiaEURLabel
            // 
            TyGiaEURLabel.AutoSize = true;
            TyGiaEURLabel.Location = new Point(12, 9);
            TyGiaEURLabel.Name = "TyGiaEURLabel";
            TyGiaEURLabel.Size = new Size(63, 15);
            TyGiaEURLabel.TabIndex = 10;
            TyGiaEURLabel.Text = "Tỷ giá EUR";
            TyGiaEURLabel.Visible = false;
            // 
            // TyGiaUSDTextBox
            // 
            TyGiaUSDTextBox.Location = new Point(12, 31);
            TyGiaUSDTextBox.Name = "TyGiaUSDTextBox";
            TyGiaUSDTextBox.Size = new Size(53, 23);
            TyGiaUSDTextBox.TabIndex = 11;
            TyGiaUSDTextBox.Text = "17861";
            TyGiaUSDTextBox.Visible = false;
            TyGiaUSDTextBox.TextChanged += TyGiaUSDTextBox_TextChanged;
            // 
            // TyGiaEURTextBox
            // 
            TyGiaEURTextBox.Location = new Point(12, 31);
            TyGiaEURTextBox.Name = "TyGiaEURTextBox";
            TyGiaEURTextBox.Size = new Size(53, 23);
            TyGiaEURTextBox.TabIndex = 12;
            TyGiaEURTextBox.Text = "27043";
            TyGiaEURTextBox.Visible = false;
            TyGiaEURTextBox.TextChanged += TyGiaEURTextBox_TextChanged;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 230);
            Controls.Add(TyGiaEURTextBox);
            Controls.Add(TyGiaUSDTextBox);
            Controls.Add(TyGiaEURLabel);
            Controls.Add(TyGiaUSDLabel);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(VNDtoUSDButton);
            Controls.Add(VNDtoEURButton);
            Controls.Add(USDtoVNDButton);
            Controls.Add(EURtoVNDButton);
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
        private Button EURtoVNDButton;
        private Button USDtoVNDButton;
        private Button VNDtoEURButton;
        private Button VNDtoUSDButton;
        private TextBox textBox2;
        private Label label3;
        private ErrorProvider errorProvider1;
        private Label TyGiaUSDLabel;
        private TextBox TyGiaEURTextBox;
        private TextBox TyGiaUSDTextBox;
        private Label TyGiaEURLabel;
    }
}
