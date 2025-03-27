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
            labelInput = new Label();
            textBoxInput = new TextBox();
            radioButtonTimesNewRoman = new RadioButton();
            radioButtonArial = new RadioButton();
            radioButtonTahoma = new RadioButton();
            radioButtonCourierNew = new RadioButton();
            btnExit = new Button();
            SuspendLayout();
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(33, 38);
            labelInput.Margin = new Padding(5, 0, 5, 0);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(127, 25);
            labelInput.TabIndex = 0;
            labelInput.Text = "Nhập văn bản:";
            // 
            // textBoxInput
            // 
            textBoxInput.ForeColor = Color.Blue;
            textBoxInput.Location = new Point(33, 77);
            textBoxInput.Margin = new Padding(5, 6, 5, 6);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(414, 31);
            textBoxInput.TabIndex = 1;
            textBoxInput.Text = "WHAT FONT IS THIS?";
            // 
            // radioButtonTimesNewRoman
            // 
            radioButtonTimesNewRoman.AutoSize = true;
            radioButtonTimesNewRoman.Location = new Point(33, 135);
            radioButtonTimesNewRoman.Margin = new Padding(5, 6, 5, 6);
            radioButtonTimesNewRoman.Name = "radioButtonTimesNewRoman";
            radioButtonTimesNewRoman.Size = new Size(184, 29);
            radioButtonTimesNewRoman.TabIndex = 2;
            radioButtonTimesNewRoman.Text = "Times New Roman";
            radioButtonTimesNewRoman.UseVisualStyleBackColor = true;
            radioButtonTimesNewRoman.Click += RadioButton_CheckedChanged;
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
            // radioButtonTahoma
            // 
            radioButtonTahoma.AutoSize = true;
            radioButtonTahoma.Checked = true;
            radioButtonTahoma.Location = new Point(33, 212);
            radioButtonTahoma.Margin = new Padding(5, 6, 5, 6);
            radioButtonTahoma.Name = "radioButtonTahoma";
            radioButtonTahoma.Size = new Size(99, 29);
            radioButtonTahoma.TabIndex = 4;
            radioButtonTahoma.TabStop = true;
            radioButtonTahoma.Text = "Tahoma";
            radioButtonTahoma.UseVisualStyleBackColor = true;
            radioButtonTahoma.Click += RadioButton_CheckedChanged;
            // 
            // radioButtonCourierNew
            // 
            radioButtonCourierNew.AutoSize = true;
            radioButtonCourierNew.Location = new Point(33, 250);
            radioButtonCourierNew.Margin = new Padding(5, 6, 5, 6);
            radioButtonCourierNew.Name = "radioButtonCourierNew";
            radioButtonCourierNew.Size = new Size(134, 29);
            radioButtonCourierNew.TabIndex = 5;
            radioButtonCourierNew.Text = "Courier New";
            radioButtonCourierNew.UseVisualStyleBackColor = true;
            radioButtonCourierNew.Click += RadioButton_CheckedChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(33, 308);
            btnExit.Margin = new Padding(5, 6, 5, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(125, 44);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FontSelectorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 385);
            Controls.Add(btnExit);
            Controls.Add(radioButtonCourierNew);
            Controls.Add(radioButtonTahoma);
            Controls.Add(radioButtonArial);
            Controls.Add(radioButtonTimesNewRoman);
            Controls.Add(textBoxInput);
            Controls.Add(labelInput);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FontSelectorForm";
            Text = "frmFont";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.RadioButton radioButtonTimesNewRoman;
        private System.Windows.Forms.RadioButton radioButtonArial;
        private System.Windows.Forms.RadioButton radioButtonTahoma;
        private System.Windows.Forms.RadioButton radioButtonCourierNew;
        private System.Windows.Forms.Button btnExit;
    }
}