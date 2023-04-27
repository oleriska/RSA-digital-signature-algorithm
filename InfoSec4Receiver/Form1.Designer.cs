namespace InfoSec4Receiver
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
            this.InitialTextTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SignatureTB = new System.Windows.Forms.TextBox();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EncryptedTextTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InitialTextTB
            // 
            this.InitialTextTB.Location = new System.Drawing.Point(137, 16);
            this.InitialTextTB.Name = "InitialTextTB";
            this.InitialTextTB.Size = new System.Drawing.Size(321, 23);
            this.InitialTextTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Received text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Signature";
            // 
            // SignatureTB
            // 
            this.SignatureTB.Location = new System.Drawing.Point(137, 83);
            this.SignatureTB.Name = "SignatureTB";
            this.SignatureTB.Size = new System.Drawing.Size(321, 23);
            this.SignatureTB.TabIndex = 2;
            // 
            // VerifyButton
            // 
            this.VerifyButton.Location = new System.Drawing.Point(31, 132);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(427, 23);
            this.VerifyButton.TabIndex = 4;
            this.VerifyButton.Text = "Verify signature";
            this.VerifyButton.UseVisualStyleBackColor = true;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Encrypted text";
            // 
            // EncryptedTextTB
            // 
            this.EncryptedTextTB.Location = new System.Drawing.Point(137, 50);
            this.EncryptedTextTB.Name = "EncryptedTextTB";
            this.EncryptedTextTB.Size = new System.Drawing.Size(321, 23);
            this.EncryptedTextTB.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 191);
            this.Controls.Add(this.EncryptedTextTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VerifyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignatureTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InitialTextTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox InitialTextTB;
        private Label label1;
        private Label label2;
        public TextBox SignatureTB;
        private Button VerifyButton;
        private Label label3;
        private TextBox EncryptedTextTB;
    }
}