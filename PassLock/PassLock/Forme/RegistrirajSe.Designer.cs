namespace PassLock
{
    partial class RegistrirajSe
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
            this.labelNaslovRegistacija = new System.Windows.Forms.Label();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.buttonRegistrirajKorisnika = new System.Windows.Forms.Button();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNaslovRegistacija
            // 
            this.labelNaslovRegistacija.AutoSize = true;
            this.labelNaslovRegistacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaslovRegistacija.Location = new System.Drawing.Point(108, 56);
            this.labelNaslovRegistacija.Name = "labelNaslovRegistacija";
            this.labelNaslovRegistacija.Size = new System.Drawing.Size(152, 29);
            this.labelNaslovRegistacija.TabIndex = 0;
            this.labelNaslovRegistacija.Text = "Registracija";
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(95, 133);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(179, 22);
            this.textBoxKorisnickoIme.TabIndex = 1;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(95, 183);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(179, 22);
            this.textBoxLozinka.TabIndex = 2;
            this.textBoxLozinka.UseSystemPasswordChar = true;
            // 
            // buttonRegistrirajKorisnika
            // 
            this.buttonRegistrirajKorisnika.Location = new System.Drawing.Point(126, 234);
            this.buttonRegistrirajKorisnika.Name = "buttonRegistrirajKorisnika";
            this.buttonRegistrirajKorisnika.Size = new System.Drawing.Size(117, 27);
            this.buttonRegistrirajKorisnika.TabIndex = 3;
            this.buttonRegistrirajKorisnika.Text = "Registriraj se";
            this.buttonRegistrirajKorisnika.UseVisualStyleBackColor = true;
            this.buttonRegistrirajKorisnika.Click += new System.EventHandler(this.buttonRegistrirajKorisnika_Click);
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.Location = new System.Drawing.Point(92, 113);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(103, 17);
            this.labelKorisnickoIme.TabIndex = 4;
            this.labelKorisnickoIme.Text = "Korisničko ime:";
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Location = new System.Drawing.Point(92, 163);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(61, 17);
            this.labelLozinka.TabIndex = 5;
            this.labelLozinka.Text = "Lozinka:";
            // 
            // RegistrirajSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 348);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.labelKorisnickoIme);
            this.Controls.Add(this.buttonRegistrirajKorisnika);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textBoxKorisnickoIme);
            this.Controls.Add(this.labelNaslovRegistacija);
            this.Name = "RegistrirajSe";
            this.Text = "RegistrirajSe";
            this.Leave += new System.EventHandler(this.RegistrirajSe_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaslovRegistacija;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Button buttonRegistrirajKorisnika;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.Label labelLozinka;
    }
}