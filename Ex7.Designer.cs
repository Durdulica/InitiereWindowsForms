namespace InitiereWindowsForms
{
    partial class Ex7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex7));
            this.btnColt2 = new System.Windows.Forms.Button();
            this.btnColt1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnColt2
            // 
            resources.ApplyResources(this.btnColt2, "btnColt2");
            this.btnColt2.Name = "btnColt2";
            this.btnColt2.UseVisualStyleBackColor = true;
            // 
            // btnColt1
            // 
            resources.ApplyResources(this.btnColt1, "btnColt1");
            this.btnColt1.Name = "btnColt1";
            this.btnColt1.UseVisualStyleBackColor = true;
            this.btnColt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // Adapter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnColt1);
            this.Controls.Add(this.btnColt2);
            this.Name = "Adapter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColt2;
        private System.Windows.Forms.Button btnColt1;
        private System.Windows.Forms.TextBox textBox1;
    }
}