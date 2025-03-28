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
            ClickMeButton = new Button();
            SuspendLayout();
            // 
            // btnClickMe
            // 
            ClickMeButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClickMeButton.ForeColor = Color.Red;
            ClickMeButton.Location = new Point(276, 161);
            ClickMeButton.Name = "ClickMeButton";
            ClickMeButton.Size = new Size(271, 98);
            ClickMeButton.TabIndex = 0;
            ClickMeButton.Text = "Click Me";
            ClickMeButton.UseVisualStyleBackColor = true;
            ClickMeButton.Click += button1_Click;
            // 
            // FormSimpleEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClickMeButton);
            Name = "FormSimpleEvent";
            Text = "FormSimpleEvent";
            Load += FormSimpleEvent_Load;
            MouseClick += FormSimpleEvent_MouseClick;
            ResumeLayout(false);
        }

        #endregion

        private Button ClickMeButton;
    }
}
