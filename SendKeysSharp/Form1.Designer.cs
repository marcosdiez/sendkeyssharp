namespace SendKeysSharp
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
            this.go_button = new System.Windows.Forms.Button();
            this.txt_main = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // go_button
            // 
            this.go_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.go_button.Location = new System.Drawing.Point(0, 238);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(284, 23);
            this.go_button.TabIndex = 1;
            this.go_button.Text = "Type !";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.go_button_Click);
            // 
            // txt_main
            // 
            this.txt_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_main.Location = new System.Drawing.Point(12, 12);
            this.txt_main.Multiline = true;
            this.txt_main.Name = "txt_main";
            this.txt_main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_main.Size = new System.Drawing.Size(260, 208);
            this.txt_main.TabIndex = 0;
            this.txt_main.Text = "Put your text here, push the button below and it will be typed in the previous fo" +
    "cused window!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_main);
            this.Controls.Add(this.go_button);
            this.Name = "Form1";
            this.Text = "SendKeysSharp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button go_button;
        private System.Windows.Forms.TextBox txt_main;
    }
}

