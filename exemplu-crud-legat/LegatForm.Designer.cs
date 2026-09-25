namespace ExempluCrudLegat
{
    partial class LegatForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNumeP = new System.Windows.Forms.Label();
            this.txtNumeP = new System.Windows.Forms.TextBox();
            this.lblGenP = new System.Windows.Forms.Label();
            this.txtGenP = new System.Windows.Forms.TextBox();
            this.btnIncarca = new System.Windows.Forms.Button();
            this.btnAdaugaP = new System.Windows.Forms.Button();
            this.btnModificaP = new System.Windows.Forms.Button();
            this.btnStergeP = new System.Windows.Forms.Button();
            this.dgvPlaylists = new System.Windows.Forms.DataGridView();
            this.lblTitluM = new System.Windows.Forms.Label();
            this.txtTitluM = new System.Windows.Forms.TextBox();
            this.lblArtistM = new System.Windows.Forms.Label();
            this.txtArtistM = new System.Windows.Forms.TextBox();
            this.lblDurataM = new System.Windows.Forms.Label();
            this.txtDurataM = new System.Windows.Forms.TextBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.btnAdaugaM = new System.Windows.Forms.Button();
            this.btnModificaM = new System.Windows.Forms.Button();
            this.btnStergeM = new System.Windows.Forms.Button();
            this.dgvMelodii = new System.Windows.Forms.DataGridView();
            this.lblMuta = new System.Windows.Forms.Label();
            this.cmbMuta = new System.Windows.Forms.ComboBox();
            this.btnMuta = new System.Windows.Forms.Button();
            this.lblStare = new System.Windows.Forms.Label();
            this.lblAntetP = new System.Windows.Forms.Label();
            this.lblAntetM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMelodii)).BeginInit();
            this.SuspendLayout();

            this.lblAntetP.AutoSize = true;
            this.lblAntetP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblAntetP.Location = new System.Drawing.Point(12, 9);
            this.lblAntetP.Name = "lblAntetP";
            this.lblAntetP.Size = new System.Drawing.Size(66, 15);
            this.lblAntetP.Text = "Playlisturi";

            this.lblNumeP.AutoSize = true;
            this.lblNumeP.Location = new System.Drawing.Point(12, 34);
            this.lblNumeP.Name = "lblNumeP";
            this.lblNumeP.Size = new System.Drawing.Size(38, 13);
            this.lblNumeP.Text = "Nume:";

            this.txtNumeP.Location = new System.Drawing.Point(56, 31);
            this.txtNumeP.Name = "txtNumeP";
            this.txtNumeP.Size = new System.Drawing.Size(150, 20);
            this.txtNumeP.TabIndex = 0;

            this.lblGenP.AutoSize = true;
            this.lblGenP.Location = new System.Drawing.Point(216, 34);
            this.lblGenP.Name = "lblGenP";
            this.lblGenP.Size = new System.Drawing.Size(28, 13);
            this.lblGenP.Text = "Gen:";

            this.txtGenP.Location = new System.Drawing.Point(250, 31);
            this.txtGenP.Name = "txtGenP";
            this.txtGenP.Size = new System.Drawing.Size(120, 20);
            this.txtGenP.TabIndex = 1;

            this.btnIncarca.Location = new System.Drawing.Point(12, 60);
            this.btnIncarca.Name = "btnIncarca";
            this.btnIncarca.Size = new System.Drawing.Size(84, 26);
            this.btnIncarca.TabIndex = 2;
            this.btnIncarca.Text = "Incarca";
            this.btnIncarca.UseVisualStyleBackColor = true;
            this.btnIncarca.Click += new System.EventHandler(this.btnIncarca_Click);

            this.btnAdaugaP.Location = new System.Drawing.Point(102, 60);
            this.btnAdaugaP.Name = "btnAdaugaP";
            this.btnAdaugaP.Size = new System.Drawing.Size(84, 26);
            this.btnAdaugaP.TabIndex = 3;
            this.btnAdaugaP.Text = "Adauga";
            this.btnAdaugaP.UseVisualStyleBackColor = true;
            this.btnAdaugaP.Click += new System.EventHandler(this.btnAdaugaP_Click);

            this.btnModificaP.Location = new System.Drawing.Point(192, 60);
            this.btnModificaP.Name = "btnModificaP";
            this.btnModificaP.Size = new System.Drawing.Size(84, 26);
            this.btnModificaP.TabIndex = 4;
            this.btnModificaP.Text = "Modifica";
            this.btnModificaP.UseVisualStyleBackColor = true;
            this.btnModificaP.Click += new System.EventHandler(this.btnModificaP_Click);

            this.btnStergeP.Location = new System.Drawing.Point(282, 60);
            this.btnStergeP.Name = "btnStergeP";
            this.btnStergeP.Size = new System.Drawing.Size(84, 26);
            this.btnStergeP.TabIndex = 5;
            this.btnStergeP.Text = "Sterge";
            this.btnStergeP.UseVisualStyleBackColor = true;
            this.btnStergeP.Click += new System.EventHandler(this.btnStergeP_Click);

            this.dgvPlaylists.AllowUserToAddRows = false;
            this.dgvPlaylists.AllowUserToDeleteRows = false;
            this.dgvPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylists.Location = new System.Drawing.Point(12, 94);
            this.dgvPlaylists.MultiSelect = false;
            this.dgvPlaylists.Name = "dgvPlaylists";
            this.dgvPlaylists.ReadOnly = true;
            this.dgvPlaylists.RowHeadersVisible = false;
            this.dgvPlaylists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaylists.Size = new System.Drawing.Size(468, 250);
            this.dgvPlaylists.TabIndex = 6;
            this.dgvPlaylists.SelectionChanged += new System.EventHandler(this.dgvPlaylists_SelectionChanged);

            this.lblAntetM.AutoSize = true;
            this.lblAntetM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblAntetM.Location = new System.Drawing.Point(496, 9);
            this.lblAntetM.Name = "lblAntetM";
            this.lblAntetM.Size = new System.Drawing.Size(200, 15);
            this.lblAntetM.Text = "Melodii din playlistul selectat";

            this.lblTitluM.AutoSize = true;
            this.lblTitluM.Location = new System.Drawing.Point(496, 34);
            this.lblTitluM.Name = "lblTitluM";
            this.lblTitluM.Size = new System.Drawing.Size(30, 13);
            this.lblTitluM.Text = "Titlu:";

            this.txtTitluM.Location = new System.Drawing.Point(536, 31);
            this.txtTitluM.Name = "txtTitluM";
            this.txtTitluM.Size = new System.Drawing.Size(160, 20);
            this.txtTitluM.TabIndex = 7;

            this.lblArtistM.AutoSize = true;
            this.lblArtistM.Location = new System.Drawing.Point(706, 34);
            this.lblArtistM.Name = "lblArtistM";
            this.lblArtistM.Size = new System.Drawing.Size(33, 13);
            this.lblArtistM.Text = "Artist:";

            this.txtArtistM.Location = new System.Drawing.Point(745, 31);
            this.txtArtistM.Name = "txtArtistM";
            this.txtArtistM.Size = new System.Drawing.Size(140, 20);
            this.txtArtistM.TabIndex = 8;

            this.lblDurataM.AutoSize = true;
            this.lblDurataM.Location = new System.Drawing.Point(496, 65);
            this.lblDurataM.Name = "lblDurataM";
            this.lblDurataM.Size = new System.Drawing.Size(43, 13);
            this.lblDurataM.Text = "Durata:";

            this.txtDurataM.Location = new System.Drawing.Point(545, 62);
            this.txtDurataM.Name = "txtDurataM";
            this.txtDurataM.Size = new System.Drawing.Size(55, 20);
            this.txtDurataM.TabIndex = 9;

            this.lblFormat.AutoSize = true;
            this.lblFormat.ForeColor = System.Drawing.Color.Gray;
            this.lblFormat.Location = new System.Drawing.Point(604, 65);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(34, 13);
            this.lblFormat.Text = "mm:ss";

            this.btnAdaugaM.Location = new System.Drawing.Point(661, 60);
            this.btnAdaugaM.Name = "btnAdaugaM";
            this.btnAdaugaM.Size = new System.Drawing.Size(72, 26);
            this.btnAdaugaM.TabIndex = 10;
            this.btnAdaugaM.Text = "Adauga";
            this.btnAdaugaM.UseVisualStyleBackColor = true;
            this.btnAdaugaM.Click += new System.EventHandler(this.btnAdaugaM_Click);

            this.btnModificaM.Location = new System.Drawing.Point(739, 60);
            this.btnModificaM.Name = "btnModificaM";
            this.btnModificaM.Size = new System.Drawing.Size(76, 26);
            this.btnModificaM.TabIndex = 11;
            this.btnModificaM.Text = "Modifica";
            this.btnModificaM.UseVisualStyleBackColor = true;
            this.btnModificaM.Click += new System.EventHandler(this.btnModificaM_Click);

            this.btnStergeM.Location = new System.Drawing.Point(821, 60);
            this.btnStergeM.Name = "btnStergeM";
            this.btnStergeM.Size = new System.Drawing.Size(72, 26);
            this.btnStergeM.TabIndex = 12;
            this.btnStergeM.Text = "Sterge";
            this.btnStergeM.UseVisualStyleBackColor = true;
            this.btnStergeM.Click += new System.EventHandler(this.btnStergeM_Click);

            this.dgvMelodii.AllowUserToAddRows = false;
            this.dgvMelodii.AllowUserToDeleteRows = false;
            this.dgvMelodii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMelodii.Location = new System.Drawing.Point(496, 94);
            this.dgvMelodii.MultiSelect = false;
            this.dgvMelodii.Name = "dgvMelodii";
            this.dgvMelodii.ReadOnly = true;
            this.dgvMelodii.RowHeadersVisible = false;
            this.dgvMelodii.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMelodii.Size = new System.Drawing.Size(484, 250);
            this.dgvMelodii.TabIndex = 13;
            this.dgvMelodii.SelectionChanged += new System.EventHandler(this.dgvMelodii_SelectionChanged);

            this.lblMuta.AutoSize = true;
            this.lblMuta.Location = new System.Drawing.Point(496, 359);
            this.lblMuta.Name = "lblMuta";
            this.lblMuta.Size = new System.Drawing.Size(103, 13);
            this.lblMuta.Text = "Muta melodia in:";

            this.cmbMuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMuta.FormattingEnabled = true;
            this.cmbMuta.Location = new System.Drawing.Point(602, 356);
            this.cmbMuta.Name = "cmbMuta";
            this.cmbMuta.Size = new System.Drawing.Size(180, 21);
            this.cmbMuta.TabIndex = 14;

            this.btnMuta.Location = new System.Drawing.Point(792, 354);
            this.btnMuta.Name = "btnMuta";
            this.btnMuta.Size = new System.Drawing.Size(188, 26);
            this.btnMuta.TabIndex = 15;
            this.btnMuta.Text = "Muta melodia selectata";
            this.btnMuta.UseVisualStyleBackColor = true;
            this.btnMuta.Click += new System.EventHandler(this.btnMuta_Click);

            this.lblStare.AutoSize = true;
            this.lblStare.Location = new System.Drawing.Point(12, 396);
            this.lblStare.Name = "lblStare";
            this.lblStare.Size = new System.Drawing.Size(171, 13);
            this.lblStare.Text = "Apasa Incarca pentru a incepe.";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 424);
            this.Controls.Add(this.lblAntetP);
            this.Controls.Add(this.lblNumeP);
            this.Controls.Add(this.txtNumeP);
            this.Controls.Add(this.lblGenP);
            this.Controls.Add(this.txtGenP);
            this.Controls.Add(this.btnIncarca);
            this.Controls.Add(this.btnAdaugaP);
            this.Controls.Add(this.btnModificaP);
            this.Controls.Add(this.btnStergeP);
            this.Controls.Add(this.dgvPlaylists);
            this.Controls.Add(this.lblAntetM);
            this.Controls.Add(this.lblTitluM);
            this.Controls.Add(this.txtTitluM);
            this.Controls.Add(this.lblArtistM);
            this.Controls.Add(this.txtArtistM);
            this.Controls.Add(this.lblDurataM);
            this.Controls.Add(this.txtDurataM);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.btnAdaugaM);
            this.Controls.Add(this.btnModificaM);
            this.Controls.Add(this.btnStergeM);
            this.Controls.Add(this.dgvMelodii);
            this.Controls.Add(this.lblMuta);
            this.Controls.Add(this.cmbMuta);
            this.Controls.Add(this.btnMuta);
            this.Controls.Add(this.lblStare);
            this.Name = "LegatForm";
            this.Text = "Playlisturi si melodii - doua liste legate";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMelodii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblAntetP;
        private System.Windows.Forms.Label lblNumeP;
        private System.Windows.Forms.TextBox txtNumeP;
        private System.Windows.Forms.Label lblGenP;
        private System.Windows.Forms.TextBox txtGenP;
        private System.Windows.Forms.Button btnIncarca;
        private System.Windows.Forms.Button btnAdaugaP;
        private System.Windows.Forms.Button btnModificaP;
        private System.Windows.Forms.Button btnStergeP;
        private System.Windows.Forms.DataGridView dgvPlaylists;
        private System.Windows.Forms.Label lblAntetM;
        private System.Windows.Forms.Label lblTitluM;
        private System.Windows.Forms.TextBox txtTitluM;
        private System.Windows.Forms.Label lblArtistM;
        private System.Windows.Forms.TextBox txtArtistM;
        private System.Windows.Forms.Label lblDurataM;
        private System.Windows.Forms.TextBox txtDurataM;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Button btnAdaugaM;
        private System.Windows.Forms.Button btnModificaM;
        private System.Windows.Forms.Button btnStergeM;
        private System.Windows.Forms.DataGridView dgvMelodii;
        private System.Windows.Forms.Label lblMuta;
        private System.Windows.Forms.ComboBox cmbMuta;
        private System.Windows.Forms.Button btnMuta;
        private System.Windows.Forms.Label lblStare;
    }
}
