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
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.buttonOdjava = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonKopirajLozinku = new System.Windows.Forms.Button();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.buttonIzmjeni = new System.Windows.Forms.Button();
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
            // buttonOdjava
            // 
            this.buttonOdjava.BackColor = System.Drawing.Color.Coral;
            this.buttonOdjava.Location = new System.Drawing.Point(896, 16);
            this.buttonOdjava.Name = "buttonOdjava";
            this.buttonOdjava.Size = new System.Drawing.Size(126, 42);
            this.buttonOdjava.TabIndex = 11;
            this.buttonOdjava.Text = "ODJAVI SE";
            this.buttonOdjava.UseVisualStyleBackColor = false;
            this.buttonOdjava.Click += new System.EventHandler(this.buttonOdjava_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDodaj.Location = new System.Drawing.Point(23, 150);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(156, 49);
            this.buttonDodaj.TabIndex = 12;
            this.buttonDodaj.Text = "DODAJ";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonKopirajLozinku
            // 
            this.buttonKopirajLozinku.BackColor = System.Drawing.Color.Transparent;
            this.buttonKopirajLozinku.Location = new System.Drawing.Point(23, 83);
            this.buttonKopirajLozinku.Name = "buttonKopirajLozinku";
            this.buttonKopirajLozinku.Size = new System.Drawing.Size(156, 49);
            this.buttonKopirajLozinku.TabIndex = 13;
            this.buttonKopirajLozinku.Text = "KOPIRAJ LOZINKU";
            this.buttonKopirajLozinku.UseVisualStyleBackColor = false;
            this.buttonKopirajLozinku.Click += new System.EventHandler(this.buttonKopirajLozinku_Click);
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.BackColor = System.Drawing.Color.Tomato;
            this.buttonIzbrisi.Location = new System.Drawing.Point(23, 491);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(156, 49);
            this.buttonIzbrisi.TabIndex = 14;
            this.buttonIzbrisi.Text = "IZBRIŠI";
            this.buttonIzbrisi.UseVisualStyleBackColor = false;
            this.buttonIzbrisi.Click += new System.EventHandler(this.buttonIzbrisi_Click);
            // 
            // buttonIzmjeni
            // 
            this.buttonIzmjeni.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonIzmjeni.Location = new System.Drawing.Point(23, 215);
            this.buttonIzmjeni.Name = "buttonIzmjeni";
            this.buttonIzmjeni.Size = new System.Drawing.Size(156, 49);
            this.buttonIzmjeni.TabIndex = 15;
            this.buttonIzmjeni.Text = "IZMJENI";
            this.buttonIzmjeni.UseVisualStyleBackColor = false;
            this.buttonIzmjeni.Click += new System.EventHandler(this.buttonIzmjeni_Click);
            // 
            // Lozinke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 565);
            this.Controls.Add(this.buttonIzmjeni);
            this.Controls.Add(this.buttonIzbrisi);
            this.Controls.Add(this.buttonKopirajLozinku);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonOdjava);
            this.Controls.Add(this.dgvPodaci);
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
        private System.Windows.Forms.Button buttonOdjava;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonKopirajLozinku;
        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.Button buttonIzmjeni;
    }
}