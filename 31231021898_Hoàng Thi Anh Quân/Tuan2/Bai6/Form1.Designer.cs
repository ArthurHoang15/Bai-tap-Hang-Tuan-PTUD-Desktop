namespace Bai_6
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            label3 = new Label();
            NameTextBox = new TextBox();
            MessageTextBox = new TextBox();
            RedRadioButton = new RadioButton();
            GreenRadioButton = new RadioButton();
            BlueRadioButton = new RadioButton();
            VisibleCheckBox = new CheckBox();
            SmallPictureBox = new PictureBox();
            BigPictureBox = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            MessageLabel = new Label();
            DisplayButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            toolTip1 = new ToolTip(components);
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)SmallPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BigPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 67);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 128);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 0;
            label3.Text = "Message";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(115, 67);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(627, 26);
            NameTextBox.TabIndex = 1;
            // 
            // MessageTextBox
            // 
            MessageTextBox.Location = new Point(115, 128);
            MessageTextBox.Margin = new Padding(3, 4, 3, 4);
            MessageTextBox.Name = "MessageTextBox";
            MessageTextBox.Size = new Size(627, 26);
            MessageTextBox.TabIndex = 2;
            // 
            // RedRadioButton
            // 
            RedRadioButton.AutoSize = true;
            RedRadioButton.ForeColor = Color.Red;
            RedRadioButton.Location = new Point(64, 46);
            RedRadioButton.Margin = new Padding(3, 4, 3, 4);
            RedRadioButton.Name = "RedRadioButton";
            RedRadioButton.Size = new Size(50, 23);
            RedRadioButton.TabIndex = 3;
            RedRadioButton.Text = "Red";
            RedRadioButton.UseVisualStyleBackColor = true;
            RedRadioButton.CheckedChanged += RedRadioButton_CheckedChanged;
            // 
            // GreenRadioButton
            // 
            GreenRadioButton.AutoSize = true;
            GreenRadioButton.ForeColor = Color.Green;
            GreenRadioButton.Location = new Point(64, 77);
            GreenRadioButton.Margin = new Padding(3, 4, 3, 4);
            GreenRadioButton.Name = "GreenRadioButton";
            GreenRadioButton.Size = new Size(64, 23);
            GreenRadioButton.TabIndex = 3;
            GreenRadioButton.Text = "Green";
            GreenRadioButton.UseVisualStyleBackColor = true;
            GreenRadioButton.CheckedChanged += GreenRadioButton_CheckedChanged;
            // 
            // BlueRadioButton
            // 
            BlueRadioButton.AutoSize = true;
            BlueRadioButton.ForeColor = Color.Blue;
            BlueRadioButton.Location = new Point(64, 113);
            BlueRadioButton.Margin = new Padding(3, 4, 3, 4);
            BlueRadioButton.Name = "BlueRadioButton";
            BlueRadioButton.Size = new Size(53, 23);
            BlueRadioButton.TabIndex = 3;
            BlueRadioButton.Text = "Blue";
            BlueRadioButton.UseVisualStyleBackColor = true;
            BlueRadioButton.CheckedChanged += radioBlue_CheckedChanged;
            // 
            // VisibleCheckBox
            // 
            VisibleCheckBox.AutoSize = true;
            VisibleCheckBox.Location = new Point(427, 260);
            VisibleCheckBox.Margin = new Padding(3, 4, 3, 4);
            VisibleCheckBox.Name = "VisibleCheckBox";
            VisibleCheckBox.Size = new Size(123, 23);
            VisibleCheckBox.TabIndex = 5;
            VisibleCheckBox.Text = "Message visible";
            VisibleCheckBox.UseVisualStyleBackColor = true;
            VisibleCheckBox.CheckedChanged += VisibleCheckBox_CheckedChanged;
            // 
            // SmallPictureBox
            // 
            SmallPictureBox.Image = (Image)resources.GetObject("SmallPictureBox.Image");
            SmallPictureBox.Location = new Point(434, 308);
            SmallPictureBox.Margin = new Padding(3, 4, 3, 4);
            SmallPictureBox.Name = "SmallPictureBox";
            SmallPictureBox.Size = new Size(98, 57);
            SmallPictureBox.TabIndex = 9;
            SmallPictureBox.TabStop = false;
            SmallPictureBox.Visible = false;
            // 
            // BigPictureBox
            // 
            BigPictureBox.Image = (Image)resources.GetObject("BigPictureBox.Image");
            BigPictureBox.Location = new Point(416, 294);
            BigPictureBox.Margin = new Padding(3, 4, 3, 4);
            BigPictureBox.Name = "BigPictureBox";
            BigPictureBox.Size = new Size(135, 115);
            BigPictureBox.TabIndex = 10;
            BigPictureBox.TabStop = false;
            BigPictureBox.Click += BigPictureBox_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MessageLabel
            // 
            MessageLabel.BackColor = Color.Pink;
            MessageLabel.Location = new Point(14, 512);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(917, 47);
            MessageLabel.TabIndex = 4;
            MessageLabel.Click += label4_Click;
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(96, 39);
            DisplayButton.Margin = new Padding(3, 4, 3, 4);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(65, 29);
            DisplayButton.TabIndex = 5;
            DisplayButton.Text = "Display";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(96, 72);
            ClearButton.Margin = new Padding(3, 4, 3, 4);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(65, 29);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(96, 106);
            ExitButton.Margin = new Padding(3, 4, 3, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(65, 29);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(RedRadioButton);
            groupBox1.Controls.Add(GreenRadioButton);
            groupBox1.Controls.Add(BlueRadioButton);
            groupBox1.Location = new Point(14, 294);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(251, 161);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(ClearButton);
            groupBox2.Controls.Add(DisplayButton);
            groupBox2.Controls.Add(ExitButton);
            groupBox2.Location = new Point(672, 294);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(229, 161);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(NameTextBox);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(MessageTextBox);
            groupBox3.Location = new Point(67, 27);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(766, 204);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Input name and message";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 570);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(MessageLabel);
            Controls.Add(BigPictureBox);
            Controls.Add(SmallPictureBox);
            Controls.Add(VisibleCheckBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Message Formatter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)SmallPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BigPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox NameTextBox;
        private TextBox MessageTextBox;
        private RadioButton RedRadioButton;
        private RadioButton GreenRadioButton;
        private RadioButton BlueRadioButton;
        private CheckBox VisibleCheckBox;
        private PictureBox SmallPictureBox;
        private PictureBox BigPictureBox;
        private ErrorProvider errorProvider1;
        private Label MessageLabel;
        private Button ExitButton;
        private Button ClearButton;
        private Button DisplayButton;
        private ToolTip toolTip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
