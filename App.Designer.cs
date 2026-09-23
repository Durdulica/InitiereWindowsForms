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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEstToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdapter = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTilu
            // 
            this.txtTilu.Location = new System.Drawing.Point(306, 27);
            this.txtTilu.Name = "txtTilu";
            this.txtTilu.Size = new System.Drawing.Size(104, 20);
            this.txtTilu.TabIndex = 1;
            this.txtTilu.Text = "Titlu";
            this.txtTilu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTilu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ex1
            // 
            this.Ex1.Location = new System.Drawing.Point(34, 72);
            this.Ex1.Name = "Ex1";
            this.Ex1.Size = new System.Drawing.Size(142, 41);
            this.Ex1.TabIndex = 2;
            this.Ex1.Text = "Ex1";
            this.Ex1.UseVisualStyleBackColor = true;
            this.Ex1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(325, 72);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(33, 13);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Label";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            this.lbl.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Formular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            // btnAdapter
            // 
            this.btnAdapter.Location = new System.Drawing.Point(34, 277);
            this.btnAdapter.Name = "btnAdapter";
            this.btnAdapter.Size = new System.Drawing.Size(141, 39);
            this.btnAdapter.TabIndex = 6;
            this.btnAdapter.Text = "Adaptare";
            this.btnAdapter.UseVisualStyleBackColor = true;
            this.btnAdapter.Click += new System.EventHandler(this.btnAdapter_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdapter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ex1);
            this.Controls.Add(this.txtTilu);
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

        private System.Windows.Forms.TextBox txtTilu;
        private System.Windows.Forms.Button Ex1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEstToolStripMenuItem1;
        private System.Windows.Forms.Button btnAdapter;
    }
}