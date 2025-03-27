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
            txtName = new TextBox();
            txtMessage = new TextBox();
            radRed = new RadioButton();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            chkVisible = new CheckBox();
            picSmall = new PictureBox();
            picBig = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            lblMessage = new Label();
            btnDisplay = new Button();
            btnClear = new Button();
            btnExit = new Button();
            toolTip1 = new ToolTip(components);
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picSmall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 53);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 101);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 0;
            label3.Text = "Message";
            // 
            // txtName
            // 
            txtName.Location = new Point(101, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(549, 23);
            txtName.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(101, 101);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(549, 23);
            txtMessage.TabIndex = 2;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(56, 36);
            radRed.Name = "radRed";
            radRed.Size = new Size(45, 19);
            radRed.TabIndex = 3;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(56, 61);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(56, 19);
            radGreen.TabIndex = 3;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(56, 89);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(48, 19);
            radBlue.TabIndex = 3;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            // 
            // chkVisible
            // 
            chkVisible.AutoSize = true;
            chkVisible.Location = new Point(374, 205);
            chkVisible.Name = "chkVisible";
            chkVisible.Size = new Size(108, 19);
            chkVisible.TabIndex = 5;
            chkVisible.Text = "Message visible";
            chkVisible.UseVisualStyleBackColor = true;
            // 
            // picSmall
            // 
            picSmall.Image = (Image)resources.GetObject("picSmall.Image");
            picSmall.Location = new Point(380, 243);
            picSmall.Name = "picSmall";
            picSmall.Size = new Size(86, 45);
            picSmall.TabIndex = 9;
            picSmall.TabStop = false;
            picSmall.Visible = false;
            // 
            // picBig
            // 
            picBig.Image = (Image)resources.GetObject("picBig.Image");
            picBig.Location = new Point(364, 232);
            picBig.Name = "picBig";
            picBig.Size = new Size(118, 91);
            picBig.TabIndex = 10;
            picBig.TabStop = false;
            picBig.Click += picBig_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.Pink;
            lblMessage.Location = new Point(12, 404);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(802, 37);
            lblMessage.TabIndex = 4;
            lblMessage.Click += label4_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(84, 31);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(57, 23);
            btnDisplay.TabIndex = 5;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(84, 57);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(57, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(84, 84);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(57, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(radRed);
            groupBox1.Controls.Add(radGreen);
            groupBox1.Controls.Add(radBlue);
            groupBox1.Location = new Point(12, 232);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 127);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnDisplay);
            groupBox2.Controls.Add(btnExit);
            groupBox2.Location = new Point(588, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 127);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtName);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtMessage);
            groupBox3.Location = new Point(59, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(670, 161);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Input name and message";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblMessage);
            Controls.Add(picBig);
            Controls.Add(picSmall);
            Controls.Add(chkVisible);
            Name = "Form1";
            Text = "Message Formatter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picSmall).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBig).EndInit();
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
        private TextBox txtName;
        private TextBox txtMessage;
        private RadioButton radRed;
        private RadioButton radGreen;
        private RadioButton radBlue;
        private CheckBox chkVisible;
        private PictureBox picSmall;
        private PictureBox picBig;
        private ErrorProvider errorProvider1;
        private Label lblMessage;
        private Button btnExit;
        private Button btnClear;
        private Button btnDisplay;
        private ToolTip toolTip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
