namespace PassLock
{
    partial class Lozinke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lozinke));
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.flatButtonClipboard = new PassLock.Klase.FlatButton();
            this.flatButtonDodaj = new PassLock.Klase.FlatButtonYes();
            this.flatButtonIzmjeni = new PassLock.Klase.FlatButton();
            this.flatButtonNoIzbrisi = new PassLock.Klase.FlatButtonNo();
            this.flatButtonOdjaviSe = new PassLock.Klase.FlatButtonNo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flatButtonPromjenaLozinke = new PassLock.Klase.FlatButton();
            this.checkBoxSakriLozinke = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.AllowUserToAddRows = false;
            this.dgvPodaci.AllowUserToDeleteRows = false;
            this.dgvPodaci.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Location = new System.Drawing.Point(213, 70);
            this.dgvPodaci.MultiSelect = false;
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.ReadOnly = true;
            this.dgvPodaci.RowTemplate.Height = 24;
            this.dgvPodaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPodaci.Size = new System.Drawing.Size(809, 470);
            this.dgvPodaci.TabIndex = 0;
            this.dgvPodaci.SelectionChanged += new System.EventHandler(this.dgvPodaci_SelectionChanged);
            // 
            // flatButtonClipboard
            // 
            this.flatButtonClipboard.BorderThickness = 2F;
            this.flatButtonClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flatButtonClipboard.Location = new System.Drawing.Point(23, 82);
            this.flatButtonClipboard.Name = "flatButtonClipboard";
            this.flatButtonClipboard.Size = new System.Drawing.Size(156, 49);
            this.flatButtonClipboard.TabIndex = 20;
            this.flatButtonClipboard.Text = "KOPIRAJ LOZINKU";
            this.flatButtonClipboard.Click += new System.EventHandler(this.flatButtonClipboard_Click);
            // 
            // flatButtonDodaj
            // 
            this.flatButtonDodaj.BorderThickness = 2F;
            this.flatButtonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flatButtonDodaj.Location = new System.Drawing.Point(23, 151);
            this.flatButtonDodaj.Name = "flatButtonDodaj";
            this.flatButtonDodaj.Size = new System.Drawing.Size(156, 49);
            this.flatButtonDodaj.TabIndex = 19;
            this.flatButtonDodaj.Text = "DODAJ";
            this.flatButtonDodaj.Click += new System.EventHandler(this.flatButtonDodaj_Click);
            // 
            // flatButtonIzmjeni
            // 
            this.flatButtonIzmjeni.BorderThickness = 2F;
            this.flatButtonIzmjeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flatButtonIzmjeni.Location = new System.Drawing.Point(23, 220);
            this.flatButtonIzmjeni.Name = "flatButtonIzmjeni";
            this.flatButtonIzmjeni.Size = new System.Drawing.Size(156, 49);
            this.flatButtonIzmjeni.TabIndex = 18;
            this.flatButtonIzmjeni.Text = "IZMJENI";
            this.flatButtonIzmjeni.Click += new System.EventHandler(this.flatButtonIzmjeni_Click);
            // 
            // flatButtonNoIzbrisi
            // 
            this.flatButtonNoIzbrisi.BorderThickness = 2F;
            this.flatButtonNoIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flatButtonNoIzbrisi.Location = new System.Drawing.Point(23, 491);
            this.flatButtonNoIzbrisi.Name = "flatButtonNoIzbrisi";
            this.flatButtonNoIzbrisi.Size = new System.Drawing.Size(156, 49);
            this.flatButtonNoIzbrisi.TabIndex = 17;
            this.flatButtonNoIzbrisi.Text = "IZBRIŠI";
            this.flatButtonNoIzbrisi.Click += new System.EventHandler(this.flatButtonNoIzbrisi_Click);
            // 
            // flatButtonOdjaviSe
            // 
            this.flatButtonOdjaviSe.BorderThickness = 2F;
            this.flatButtonOdjaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flatButtonOdjaviSe.Location = new System.Drawing.Point(896, 25);
            this.flatButtonOdjaviSe.Name = "flatButtonOdjaviSe";
            this.flatButtonOdjaviSe.Size = new System.Drawing.Size(126, 39);
            this.flatButtonOdjaviSe.TabIndex = 16;
            this.flatButtonOdjaviSe.Text = "ODJAVI SE";
            this.flatButtonOdjaviSe.Click += new System.EventHandler(this.flatButtonOdjaviSe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-374, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1059, 581);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // flatButtonPromjenaLozinke
            // 
            this.flatButtonPromjenaLozinke.BorderThickness = 2F;
            this.flatButtonPromjenaLozinke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flatButtonPromjenaLozinke.Location = new System.Drawing.Point(764, 25);
            this.flatButtonPromjenaLozinke.Name = "flatButtonPromjenaLozinke";
            this.flatButtonPromjenaLozinke.Size = new System.Drawing.Size(126, 39);
            this.flatButtonPromjenaLozinke.TabIndex = 22;
            this.flatButtonPromjenaLozinke.Text = "PROMIJENI LOZINKU";
            this.flatButtonPromjenaLozinke.Click += new System.EventHandler(this.flatButtonPromjenaLozinke_Click);
            // 
            // checkBoxSakriLozinke
            // 
            this.checkBoxSakriLozinke.AutoSize = true;
            this.checkBoxSakriLozinke.BackColor = System.Drawing.Color.DarkTurquoise;
            this.checkBoxSakriLozinke.Checked = true;
            this.checkBoxSakriLozinke.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSakriLozinke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSakriLozinke.Location = new System.Drawing.Point(213, 42);
            this.checkBoxSakriLozinke.Name = "checkBoxSakriLozinke";
            this.checkBoxSakriLozinke.Size = new System.Drawing.Size(162, 22);
            this.checkBoxSakriLozinke.TabIndex = 23;
            this.checkBoxSakriLozinke.Text = "SAKRIJ LOZINKE";
            this.checkBoxSakriLozinke.UseVisualStyleBackColor = false;
            this.checkBoxSakriLozinke.CheckedChanged += new System.EventHandler(this.checkBoxSakriLozinke_CheckedChanged);
            // 
            // Lozinke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 565);
            this.Controls.Add(this.checkBoxSakriLozinke);
            this.Controls.Add(this.flatButtonPromjenaLozinke);
            this.Controls.Add(this.flatButtonClipboard);
            this.Controls.Add(this.flatButtonDodaj);
            this.Controls.Add(this.flatButtonIzmjeni);
            this.Controls.Add(this.flatButtonNoIzbrisi);
            this.Controls.Add(this.flatButtonOdjaviSe);
            this.Controls.Add(this.dgvPodaci);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1052, 612);
            this.MinimumSize = new System.Drawing.Size(1052, 612);
            this.Name = "Lozinke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moji podaci";
            this.Load += new System.EventHandler(this.Lozinke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPodaci;
        private Klase.FlatButtonNo flatButtonOdjaviSe;
        private Klase.FlatButtonNo flatButtonNoIzbrisi;
        private Klase.FlatButton flatButtonIzmjeni;
        private Klase.FlatButtonYes flatButtonDodaj;
        private Klase.FlatButton flatButtonClipboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Klase.FlatButton flatButtonPromjenaLozinke;
        private System.Windows.Forms.CheckBox checkBoxSakriLozinke;
    }
}