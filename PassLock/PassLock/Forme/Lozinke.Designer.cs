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
            this.flatButtonDodaj = new PassLock.Klase.FlatButtonYes();
            this.flatButtonIzmjeni = new PassLock.Klase.FlatButton();
            this.flatButtonNoIzbrisi = new PassLock.Klase.FlatButtonNo();
            this.flatButtonOdjaviSe = new PassLock.Klase.FlatButtonNo();
            this.flatButtonClipboard = new PassLock.Klase.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.AllowUserToAddRows = false;
            this.dgvPodaci.AllowUserToDeleteRows = false;
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
            // flatButtonDodaj
            // 
            this.flatButtonDodaj.BorderThickness = 2F;
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
            this.flatButtonOdjaviSe.Location = new System.Drawing.Point(896, 25);
            this.flatButtonOdjaviSe.Name = "flatButtonOdjaviSe";
            this.flatButtonOdjaviSe.Size = new System.Drawing.Size(126, 39);
            this.flatButtonOdjaviSe.TabIndex = 16;
            this.flatButtonOdjaviSe.Text = "ODJAVI SE";
            this.flatButtonOdjaviSe.Click += new System.EventHandler(this.flatButtonOdjaviSe_Click);
            // 
            // flatButtonClipboard
            // 
            this.flatButtonClipboard.BorderThickness = 2F;
            this.flatButtonClipboard.Location = new System.Drawing.Point(23, 82);
            this.flatButtonClipboard.Name = "flatButtonClipboard";
            this.flatButtonClipboard.Size = new System.Drawing.Size(156, 49);
            this.flatButtonClipboard.TabIndex = 20;
            this.flatButtonClipboard.Text = "KOPIRAJ LOZINKU";
            this.flatButtonClipboard.Click += new System.EventHandler(this.flatButtonClipboard_Click);
            // 
            // Lozinke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 565);
            this.Controls.Add(this.flatButtonClipboard);
            this.Controls.Add(this.flatButtonDodaj);
            this.Controls.Add(this.flatButtonIzmjeni);
            this.Controls.Add(this.flatButtonNoIzbrisi);
            this.Controls.Add(this.flatButtonOdjaviSe);
            this.Controls.Add(this.dgvPodaci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1052, 612);
            this.MinimumSize = new System.Drawing.Size(1052, 612);
            this.Name = "Lozinke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moji podaci";
            this.Load += new System.EventHandler(this.Lozinke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPodaci;
        private Klase.FlatButtonNo flatButtonOdjaviSe;
        private Klase.FlatButtonNo flatButtonNoIzbrisi;
        private Klase.FlatButton flatButtonIzmjeni;
        private Klase.FlatButtonYes flatButtonDodaj;
        private Klase.FlatButton flatButtonClipboard;
    }
}