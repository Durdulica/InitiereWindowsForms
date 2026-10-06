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
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnEx4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEstToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEx7 = new System.Windows.Forms.Button();
            this.btnEx9 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEx3
            // 
            this.btnEx3.Location = new System.Drawing.Point(34, 72);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(142, 41);
            this.btnEx3.TabIndex = 2;
            this.btnEx3.Text = "Ex3";
            this.btnEx3.UseVisualStyleBackColor = true;
            this.btnEx3.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEx4
            // 
            this.btnEx4.Location = new System.Drawing.Point(34, 119);
            this.btnEx4.Name = "btnEx4";
            this.btnEx4.Size = new System.Drawing.Size(142, 39);
            this.btnEx4.TabIndex = 4;
            this.btnEx4.Text = "Ex4";
            this.btnEx4.UseVisualStyleBackColor = true;
            this.btnEx4.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tEstToolStripMenuItem1});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // tEstToolStripMenuItem1
            // 
            this.tEstToolStripMenuItem1.Name = "tEstToolStripMenuItem1";
            this.tEstToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tEstToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.tEstToolStripMenuItem1.Text = "TEst";
            this.tEstToolStripMenuItem1.Click += new System.EventHandler(this.tEstToolStripMenuItem1_Click);
            // 
            // btnEx7
            // 
            this.btnEx7.Location = new System.Drawing.Point(34, 164);
            this.btnEx7.Name = "btnEx7";
            this.btnEx7.Size = new System.Drawing.Size(142, 39);
            this.btnEx7.TabIndex = 6;
            this.btnEx7.Text = "Ex7";
            this.btnEx7.UseVisualStyleBackColor = true;
            this.btnEx7.Click += new System.EventHandler(this.btnAdapter_Click);
            // 
            // btnEx9
            // 
            this.btnEx9.Location = new System.Drawing.Point(35, 209);
            this.btnEx9.Name = "btnEx9";
            this.btnEx9.Size = new System.Drawing.Size(141, 35);
            this.btnEx9.TabIndex = 7;
            this.btnEx9.Text = "Ex9";
            this.btnEx9.UseVisualStyleBackColor = true;
            this.btnEx9.Click += new System.EventHandler(this.btnEx9_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEx9);
            this.Controls.Add(this.btnEx7);
            this.Controls.Add(this.btnEx4);
            this.Controls.Add(this.btnEx3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "App";
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnEx4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEstToolStripMenuItem1;
        private System.Windows.Forms.Button btnEx7;
        private System.Windows.Forms.Button btnEx9;
    }
}