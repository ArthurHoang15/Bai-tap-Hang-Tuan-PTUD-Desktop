namespace Module_1
{
    partial class Bai1
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
            btnClickMe = new Button();
            SuspendLayout();
            // 
            // btnClickMe
            // 
            btnClickMe.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClickMe.ForeColor = Color.Red;
            btnClickMe.Location = new Point(276, 161);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(271, 98);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click Me";
            btnClickMe.UseVisualStyleBackColor = true;
            btnClickMe.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClickMe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClickMe;
    }
}
