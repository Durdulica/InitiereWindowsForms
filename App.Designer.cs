namespace InitiereWindowsForms
{
    partial class App
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
            this.txtTilu = new System.Windows.Forms.TextBox();
            this.Ex1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTilu
            // 
            this.txtTilu.Location = new System.Drawing.Point(306, 27);
            this.txtTilu.Name = "txtTilu";
            this.txtTilu.Size = new System.Drawing.Size(104, 20);
            this.txtTilu.TabIndex = 0;
            this.txtTilu.Text = "Titlu";
            this.txtTilu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTilu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ex1
            // 
            this.Ex1.Location = new System.Drawing.Point(34, 72);
            this.Ex1.Name = "Ex1";
            this.Ex1.Size = new System.Drawing.Size(142, 41);
            this.Ex1.TabIndex = 1;
            this.Ex1.Text = "Ex1";
            this.Ex1.UseVisualStyleBackColor = true;
            this.Ex1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(303, 72);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "label1";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ex1);
            this.Controls.Add(this.txtTilu);
            this.Name = "App";
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTilu;
        private System.Windows.Forms.Button Ex1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl;
    }
}