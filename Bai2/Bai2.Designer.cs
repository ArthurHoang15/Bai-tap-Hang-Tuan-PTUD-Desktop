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
            textBoxName = new TextBox();
            textBoxYear = new TextBox();
            btnShow = new Button();
            btnClear = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(233, 81);
            textBoxName.Margin = new Padding(4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(324, 26);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.Leave += textBoxName_Leave;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(233, 147);
            textBoxYear.Margin = new Padding(4);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(334, 26);
            textBoxYear.TabIndex = 1;
            textBoxYear.TextChanged += textBoxYear_TextChanged;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(67, 234);
            btnShow.Margin = new Padding(4);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(96, 28);
            btnShow.TabIndex = 2;
            btnShow.Text = "&Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(296, 234);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 28);
            btnClear.TabIndex = 3;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(495, 233);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 28);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
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
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnShow);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxName);
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

        private TextBox textBoxName;
        private TextBox textBoxYear;
        private Button btnShow;
        private Button btnClear;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}
