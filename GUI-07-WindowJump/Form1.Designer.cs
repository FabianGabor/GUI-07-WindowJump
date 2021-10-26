namespace GUI_07_WindowJump
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTopLeft = new System.Windows.Forms.Button();
            this.buttonTopRight = new System.Windows.Forms.Button();
            this.buttonBottomLeft = new System.Windows.Forms.Button();
            this.buttonBottomRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTopLeft
            // 
            this.buttonTopLeft.Location = new System.Drawing.Point(12, 12);
            this.buttonTopLeft.Name = "buttonTopLeft";
            this.buttonTopLeft.Size = new System.Drawing.Size(300, 300);
            this.buttonTopLeft.TabIndex = 0;
            this.buttonTopLeft.Text = "Top Left";
            this.buttonTopLeft.UseVisualStyleBackColor = true;
            this.buttonTopLeft.Click += new System.EventHandler(this.buttonTopLeft_Click);
            // 
            // buttonTopRight
            // 
            this.buttonTopRight.Location = new System.Drawing.Point(318, 12);
            this.buttonTopRight.Name = "buttonTopRight";
            this.buttonTopRight.Size = new System.Drawing.Size(300, 300);
            this.buttonTopRight.TabIndex = 1;
            this.buttonTopRight.Text = "Top Right";
            this.buttonTopRight.UseVisualStyleBackColor = true;
            this.buttonTopRight.Click += new System.EventHandler(this.buttonTopRight_Click);
            // 
            // buttonBottomLeft
            // 
            this.buttonBottomLeft.Location = new System.Drawing.Point(12, 318);
            this.buttonBottomLeft.Name = "buttonBottomLeft";
            this.buttonBottomLeft.Size = new System.Drawing.Size(300, 300);
            this.buttonBottomLeft.TabIndex = 2;
            this.buttonBottomLeft.Text = "Bottom Left";
            this.buttonBottomLeft.UseVisualStyleBackColor = true;
            this.buttonBottomLeft.Click += new System.EventHandler(this.buttonBottomLeft_Click);
            // 
            // buttonBottomRight
            // 
            this.buttonBottomRight.Location = new System.Drawing.Point(320, 318);
            this.buttonBottomRight.Name = "buttonBottomRight";
            this.buttonBottomRight.Size = new System.Drawing.Size(300, 300);
            this.buttonBottomRight.TabIndex = 3;
            this.buttonBottomRight.Text = "Bottom Right";
            this.buttonBottomRight.UseVisualStyleBackColor = true;
            this.buttonBottomRight.Click += new System.EventHandler(this.buttonBottomRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 625);
            this.Controls.Add(this.buttonBottomRight);
            this.Controls.Add(this.buttonBottomLeft);
            this.Controls.Add(this.buttonTopRight);
            this.Controls.Add(this.buttonTopLeft);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Jumper";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonBottomLeft;

        private System.Windows.Forms.Button buttonBottomRight;

        private System.Windows.Forms.Button buttonBottom;

        private System.Windows.Forms.Button buttonTopRight;

        private System.Windows.Forms.Button buttonTopLeft;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        #endregion
    }
}