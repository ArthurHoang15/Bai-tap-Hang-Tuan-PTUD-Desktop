namespace Baitap10
{
    partial class FontSelectorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            InputLabel = new Label();
            InputTextBox = new TextBox();
            TimesNewRomanRadioButton = new RadioButton();
            radioButtonArial = new RadioButton();
            TahomaRadioButton = new RadioButton();
            CourierNewRadioButton = new RadioButton();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // InputLabel
            // 
            InputLabel.AutoSize = true;
            InputLabel.Location = new Point(33, 38);
            InputLabel.Margin = new Padding(5, 0, 5, 0);
            InputLabel.Name = "InputLabel";
            InputLabel.Size = new Size(127, 25);
            InputLabel.TabIndex = 0;
            InputLabel.Text = "Nhập văn bản:";
            // 
            // InputTextBox
            // 
            InputTextBox.ForeColor = Color.Blue;
            InputTextBox.Location = new Point(33, 77);
            InputTextBox.Margin = new Padding(5, 6, 5, 6);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(414, 31);
            InputTextBox.TabIndex = 1;
            InputTextBox.Text = "WHAT FONT IS THIS?";
            // 
            // TimesNewRomanRadioButton
            // 
            TimesNewRomanRadioButton.AutoSize = true;
            TimesNewRomanRadioButton.Location = new Point(33, 135);
            TimesNewRomanRadioButton.Margin = new Padding(5, 6, 5, 6);
            TimesNewRomanRadioButton.Name = "TimesNewRomanRadioButton";
            TimesNewRomanRadioButton.Size = new Size(184, 29);
            TimesNewRomanRadioButton.TabIndex = 2;
            TimesNewRomanRadioButton.Text = "Times New Roman";
            TimesNewRomanRadioButton.UseVisualStyleBackColor = true;
            TimesNewRomanRadioButton.Click += RadioButton_CheckedChanged;
            // 
            // radioButtonArial
            // 
            radioButtonArial.AutoSize = true;
            radioButtonArial.Location = new Point(33, 173);
            radioButtonArial.Margin = new Padding(5, 6, 5, 6);
            radioButtonArial.Name = "radioButtonArial";
            radioButtonArial.Size = new Size(72, 29);
            radioButtonArial.TabIndex = 3;
            radioButtonArial.Text = "Arial";
            radioButtonArial.UseVisualStyleBackColor = true;
            radioButtonArial.Click += RadioButton_CheckedChanged;
            // 
            // TahomaRadioButton
            // 
            TahomaRadioButton.AutoSize = true;
            TahomaRadioButton.Checked = true;
            TahomaRadioButton.Location = new Point(33, 212);
            TahomaRadioButton.Margin = new Padding(5, 6, 5, 6);
            TahomaRadioButton.Name = "TahomaRadioButton";
            TahomaRadioButton.Size = new Size(99, 29);
            TahomaRadioButton.TabIndex = 4;
            TahomaRadioButton.TabStop = true;
            TahomaRadioButton.Text = "Tahoma";
            TahomaRadioButton.UseVisualStyleBackColor = true;
            TahomaRadioButton.Click += RadioButton_CheckedChanged;
            // 
            // CourierNewRadioButton
            // 
            CourierNewRadioButton.AutoSize = true;
            CourierNewRadioButton.Location = new Point(33, 250);
            CourierNewRadioButton.Margin = new Padding(5, 6, 5, 6);
            CourierNewRadioButton.Name = "CourierNewRadioButton";
            CourierNewRadioButton.Size = new Size(134, 29);
            CourierNewRadioButton.TabIndex = 5;
            CourierNewRadioButton.Text = "Courier New";
            CourierNewRadioButton.UseVisualStyleBackColor = true;
            CourierNewRadioButton.Click += RadioButton_CheckedChanged;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(33, 308);
            ExitButton.Margin = new Padding(5, 6, 5, 6);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(125, 44);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Thoát";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // FontSelectorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 385);
            Controls.Add(ExitButton);
            Controls.Add(CourierNewRadioButton);
            Controls.Add(TahomaRadioButton);
            Controls.Add(radioButtonArial);
            Controls.Add(TimesNewRomanRadioButton);
            Controls.Add(InputTextBox);
            Controls.Add(InputLabel);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FontSelectorForm";
            Text = "frmFont";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.RadioButton TimesNewRomanRadioButton;
        private System.Windows.Forms.RadioButton radioButtonArial;
        private System.Windows.Forms.RadioButton TahomaRadioButton;
        private System.Windows.Forms.RadioButton CourierNewRadioButton;
        private System.Windows.Forms.Button ExitButton;
    }
}