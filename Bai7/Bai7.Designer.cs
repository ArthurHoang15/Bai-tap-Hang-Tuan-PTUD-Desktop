namespace Bai7
{
    partial class Bai7
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
            lblName = new Label();
            txtName = new TextBox();
            picOn = new PictureBox();
            toolTip1 = new ToolTip(components);
            picOff = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblWtfIsThis = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOff).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(43, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(91, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 23);
            txtName.TabIndex = 1;
            txtName.Text = "Jack";
            // 
            // picOn
            // 
            picOn.Image = Image.FromFile("Resources/on.png");
            picOn.Location = new Point(111, 54);
            picOn.Name = "picOn";
            picOn.Size = new Size(153, 160);
            picOn.TabIndex = 2;
            picOn.TabStop = false;
            toolTip1.SetToolTip(picOn, "Click me to Turn OFF the Light!");
            picOn.Click += picOn_Click;
            // 
            // picOff
            // 
            picOff.Enabled = false;
            picOff.Image = Image.FromFile("Resources/off.png");
            picOff.Location = new Point(111, 54);
            picOff.Name = "picOff";
            picOff.Size = new Size(153, 160);
            picOff.TabIndex = 3;
            picOff.TabStop = false;
            toolTip1.SetToolTip(picOff, "Click me to Turn ON the Light!");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 229);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 4;
            label1.Text = "Quentin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 229);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "Designed by:";
            // 
            // lblWtfIsThis
            // 
            lblWtfIsThis.AutoSize = true;
            lblWtfIsThis.Location = new Point(292, 121);
            lblWtfIsThis.Name = "lblWtfIsThis";
            lblWtfIsThis.Size = new Size(38, 15);
            lblWtfIsThis.TabIndex = 6;
            lblWtfIsThis.Text = "label3";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(293, 221);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(61, 28);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(btnExit);
            Controls.Add(lblWtfIsThis);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picOn);
            Controls.Add(picOff);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "Bai7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private PictureBox picOn;
        private ToolTip toolTip1;
        private PictureBox picOff;
        private Label label1;
        private Label label2;
        private Label lblWtfIsThis;
        private Button btnExit;
    }
}
