namespace InfoSec4
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
            this.label1 = new System.Windows.Forms.Label();
            this.InitialTextTB = new System.Windows.Forms.TextBox();
            this.SignatureTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SignedTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SignButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial text";
            // 
            // InitialTextTB
            // 
            this.InitialTextTB.Location = new System.Drawing.Point(113, 43);
            this.InitialTextTB.Name = "InitialTextTB";
            this.InitialTextTB.Size = new System.Drawing.Size(321, 23);
            this.InitialTextTB.TabIndex = 1;
            // 
            // SignatureTB
            // 
            this.SignatureTB.Location = new System.Drawing.Point(113, 108);
            this.SignatureTB.Name = "SignatureTB";
            this.SignatureTB.Size = new System.Drawing.Size(321, 23);
            this.SignatureTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Signature";
            // 
            // SignedTB
            // 
            this.SignedTB.Location = new System.Drawing.Point(113, 168);
            this.SignedTB.Name = "SignedTB";
            this.SignedTB.Size = new System.Drawing.Size(321, 23);
            this.SignedTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Signed text";
            // 
            // SignButton
            // 
            this.SignButton.Location = new System.Drawing.Point(46, 215);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(388, 23);
            this.SignButton.TabIndex = 6;
            this.SignButton.Text = "Sign";
            this.SignButton.UseVisualStyleBackColor = true;
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(46, 256);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(388, 23);
            this.SendButton.TabIndex = 7;
            this.SendButton.Text = "Send to second app";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 315);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SignButton);
            this.Controls.Add(this.SignedTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SignatureTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InitialTextTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox InitialTextTB;
        private TextBox SignatureTB;
        private Label label2;
        private TextBox SignedTB;
        private Label label3;
        private Button SignButton;
        private Button SendButton;
    }
}