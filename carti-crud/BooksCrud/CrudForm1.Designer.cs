namespace BooksCrud
{
    partial class CrudForm1
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
            this.lblNume = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblVarsta = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnIncarca = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblStare = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNume.Location = new System.Drawing.Point(12, 9);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(45, 17);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmail.Location = new System.Drawing.Point(12, 34);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblVarsta
            // 
            this.lblVarsta.AutoSize = true;
            this.lblVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVarsta.Location = new System.Drawing.Point(12, 60);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(49, 17);
            this.lblVarsta.TabIndex = 3;
            this.lblVarsta.Text = "Varsta";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(110, 8);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(159, 20);
            this.txtNume.TabIndex = 0;
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(110, 59);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(83, 20);
            this.txtVarsta.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 34);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // btnIncarca
            // 
            this.btnIncarca.Location = new System.Drawing.Point(320, 8);
            this.btnIncarca.Name = "btnIncarca";
            this.btnIncarca.Size = new System.Drawing.Size(105, 26);
            this.btnIncarca.TabIndex = 4;
            this.btnIncarca.Text = "Incarca";
            this.btnIncarca.UseVisualStyleBackColor = true;
            this.btnIncarca.Click += new System.EventHandler(this.btnIncarca_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(6, 145);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(514, 277);
            this.dgvUsers.TabIndex = 9;
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(320, 104);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(105, 26);
            this.btnSterge.TabIndex = 7;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(320, 72);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(105, 26);
            this.btnModifica.TabIndex = 6;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(320, 40);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(105, 26);
            this.btnAdauga.TabIndex = 5;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lblStare
            // 
            this.lblStare.AutoSize = true;
            this.lblStare.Location = new System.Drawing.Point(12, 117);
            this.lblStare.Name = "lblStare";
            this.lblStare.Size = new System.Drawing.Size(0, 13);
            this.lblStare.TabIndex = 13;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(110, 85);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(159, 20);
            this.txtParola.TabIndex = 3;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblParola.Location = new System.Drawing.Point(12, 85);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(49, 17);
            this.lblParola.TabIndex = 14;
            this.lblParola.Text = "Parola";
            // 
            // CrudForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 434);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblStare);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnIncarca);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtVarsta);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblVarsta);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNume);
            this.Name = "CrudForm1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnIncarca;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblStare;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblParola;
    }
}

