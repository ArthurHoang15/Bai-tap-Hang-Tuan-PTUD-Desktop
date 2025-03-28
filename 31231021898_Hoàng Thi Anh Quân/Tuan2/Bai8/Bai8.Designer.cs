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
            TitleLabel = new Label();
            ALabel = new Label();
            BLabel = new Label();
            ResultLabel = new Label();
            ATextBox = new TextBox();
            BTextBox = new TextBox();
            ResultTextBox = new TextBox();
            ExitButton = new Button();
            DeleteButton = new Button();
            CalculateButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.FromArgb(255, 128, 0);
            TitleLabel.Location = new Point(136, 27);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(204, 21);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "PHƯƠNG TRÌNH: AX+B=0";
            // 
            // ALabel
            // 
            ALabel.AutoSize = true;
            ALabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ALabel.Location = new Point(52, 71);
            ALabel.Name = "ALabel";
            ALabel.Size = new Size(62, 20);
            ALabel.TabIndex = 1;
            ALabel.Text = "Nhập A:";
            // 
            // BLabel
            // 
            BLabel.AutoSize = true;
            BLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BLabel.Location = new Point(52, 112);
            BLabel.Name = "BLabel";
            BLabel.Size = new Size(61, 20);
            BLabel.TabIndex = 2;
            BLabel.Text = "Nhập B:";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultLabel.Location = new Point(26, 156);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(85, 20);
            ResultLabel.TabIndex = 3;
            ResultLabel.Text = "Nghiệm PT:";
            // 
            // ATextBox
            // 
            ATextBox.Location = new Point(119, 68);
            ATextBox.Name = "ATextBox";
            ATextBox.Size = new Size(262, 23);
            ATextBox.TabIndex = 4;
            ATextBox.TextChanged += ATextBox_TextChanged;
            // 
            // BTextBox
            // 
            BTextBox.Location = new Point(119, 109);
            BTextBox.Name = "BTextBox";
            BTextBox.Size = new Size(262, 23);
            BTextBox.TabIndex = 5;
            BTextBox.TextChanged += BTextBox_TextChanged;
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(117, 153);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.ReadOnly = true;
            ResultTextBox.Size = new Size(262, 23);
            ResultTextBox.TabIndex = 6;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(325, 203);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(78, 25);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Thoát";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Enabled = false;
            DeleteButton.Location = new Point(226, 203);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(78, 25);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Xóa";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.Enabled = false;
            CalculateButton.Location = new Point(119, 203);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(78, 25);
            CalculateButton.TabIndex = 9;
            CalculateButton.Text = "Tính";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
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
            Controls.Add(CalculateButton);
            Controls.Add(DeleteButton);
            Controls.Add(ExitButton);
            Controls.Add(ResultTextBox);
            Controls.Add(BTextBox);
            Controls.Add(ATextBox);
            Controls.Add(ResultLabel);
            Controls.Add(BLabel);
            Controls.Add(ALabel);
            Controls.Add(TitleLabel);
            Name = "Bai8";
            Text = "Form1";
            FormClosing += Bai8_FormClosing;
            FormClosed += Bai8_FormClosed;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label ALabel;
        private Label BLabel;
        private Label ResultLabel;
        private TextBox ATextBox;
        private TextBox BTextBox;
        private TextBox ResultTextBox;
        private Button ExitButton;
        private Button DeleteButton;
        private Button CalculateButton;
        private ErrorProvider errorProvider1;
    }
}
