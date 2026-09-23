namespace InitiereWindowsForms
{
    partial class Adapter
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
            this.btnColt2 = new System.Windows.Forms.Button();
            this.btnColt1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnColt2
            // 
            this.btnColt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColt2.Location = new System.Drawing.Point(660, 374);
            this.btnColt2.Name = "btnColt2";
            this.btnColt2.Size = new System.Drawing.Size(109, 42);
            this.btnColt2.TabIndex = 0;
            this.btnColt2.Text = "Colt2";
            this.btnColt2.UseVisualStyleBackColor = true;
            // 
            // btnColt1
            // 
            this.btnColt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColt1.Location = new System.Drawing.Point(-4, 375);
            this.btnColt1.Name = "btnColt1";
            this.btnColt1.Size = new System.Drawing.Size(109, 41);
            this.btnColt1.TabIndex = 1;
            this.btnColt1.Text = "Colt1";
            this.btnColt1.UseVisualStyleBackColor = true;
            this.btnColt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 242);
            this.textBox1.TabIndex = 2;
            // 
            // Adapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(771, 416);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnColt1);
            this.Controls.Add(this.btnColt2);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Adapter";
            this.Text = "Adapter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColt2;
        private System.Windows.Forms.Button btnColt1;
        private System.Windows.Forms.TextBox textBox1;
    }
}