namespace Bai2
{
    partial class frmBtap2
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
            NameTextBox = new TextBox();
            YearTextBox = new TextBox();
            ShowButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(233, 81);
            NameTextBox.Margin = new Padding(4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(324, 26);
            NameTextBox.TabIndex = 0;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            NameTextBox.Leave += NameTextBox_Leave;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(233, 147);
            YearTextBox.Margin = new Padding(4);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(334, 26);
            YearTextBox.TabIndex = 1;
            YearTextBox.TextChanged += YearTextBox_TextChanged;
            // 
            // ShowButton
            // 
            ShowButton.Location = new Point(67, 234);
            ShowButton.Margin = new Padding(4);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(96, 28);
            ShowButton.TabIndex = 2;
            ShowButton.Text = "&Show";
            ShowButton.UseVisualStyleBackColor = true;
            ShowButton.Click += ShowButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(296, 234);
            ClearButton.Margin = new Padding(4);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(96, 28);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(495, 233);
            ExitButton.Margin = new Padding(4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(96, 28);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 89);
            label1.Name = "label1";
            label1.Size = new Size(96, 18);
            label1.TabIndex = 5;
            label1.Text = "Your Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 155);
            label2.Name = "label2";
            label2.Size = new Size(109, 18);
            label2.TabIndex = 6;
            label2.Text = "Year of Birth:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBtap2
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(ShowButton);
            Controls.Add(YearTextBox);
            Controls.Add(NameTextBox);
            Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmBtap2";
            Text = "Quang Project";
            FormClosing += frmBtap2_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private TextBox YearTextBox;
        private Button ShowButton;
        private Button ClearButton;
        private Button ExitButton;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}
