namespace PassLock.Forme
{
    partial class IzmjeniPodatak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmjeniPodatak));
            this.label2 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRedniBroj = new System.Windows.Forms.TextBox();
            this.checkBoxEnkriptiraj = new System.Windows.Forms.CheckBox();
            this.flatButtonPotvrdi = new PassLock.Klase.FlatButtonYes();
            this.flatButtonOdustani = new PassLock.Klase.FlatButtonNo();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Upišite novu lozinku:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(47, 189);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(472, 22);
            this.txtLozinka.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(47, 121);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(317, 22);
            this.txtNaziv.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Redni broj:";
            // 
            // txtRedniBroj
            // 
            this.txtRedniBroj.Location = new System.Drawing.Point(47, 59);
            this.txtRedniBroj.Name = "txtRedniBroj";
            this.txtRedniBroj.ReadOnly = true;
            this.txtRedniBroj.Size = new System.Drawing.Size(317, 22);
            this.txtRedniBroj.TabIndex = 13;
            // 
            // checkBoxEnkriptiraj
            // 
            this.checkBoxEnkriptiraj.AutoSize = true;
            this.checkBoxEnkriptiraj.Location = new System.Drawing.Point(47, 217);
            this.checkBoxEnkriptiraj.Name = "checkBoxEnkriptiraj";
            this.checkBoxEnkriptiraj.Size = new System.Drawing.Size(149, 21);
            this.checkBoxEnkriptiraj.TabIndex = 17;
            this.checkBoxEnkriptiraj.Text = "Enkriptiraj SHA256";
            this.checkBoxEnkriptiraj.UseVisualStyleBackColor = true;
            // 
            // flatButtonPotvrdi
            // 
            this.flatButtonPotvrdi.BorderThickness = 2F;
            this.flatButtonPotvrdi.Location = new System.Drawing.Point(316, 265);
            this.flatButtonPotvrdi.Name = "flatButtonPotvrdi";
            this.flatButtonPotvrdi.Size = new System.Drawing.Size(126, 39);
            this.flatButtonPotvrdi.TabIndex = 18;
            this.flatButtonPotvrdi.Text = "POTVRDI";
            this.flatButtonPotvrdi.Click += new System.EventHandler(this.flatButtonPotvrdi_Click);
            // 
            // flatButtonOdustani
            // 
            this.flatButtonOdustani.BorderThickness = 2F;
            this.flatButtonOdustani.Location = new System.Drawing.Point(128, 265);
            this.flatButtonOdustani.Name = "flatButtonOdustani";
            this.flatButtonOdustani.Size = new System.Drawing.Size(126, 39);
            this.flatButtonOdustani.TabIndex = 19;
            this.flatButtonOdustani.Text = "ODUSTANI";
            this.flatButtonOdustani.Click += new System.EventHandler(this.flatButtonOdustani_Click);
            // 
            // IzmjeniPodatak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 383);
            this.Controls.Add(this.flatButtonOdustani);
            this.Controls.Add(this.flatButtonPotvrdi);
            this.Controls.Add(this.checkBoxEnkriptiraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRedniBroj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(581, 430);
            this.MinimumSize = new System.Drawing.Size(581, 430);
            this.Name = "IzmjeniPodatak";
            this.Text = "Izmjeni podatak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRedniBroj;
        private System.Windows.Forms.CheckBox checkBoxEnkriptiraj;
        private Klase.FlatButtonYes flatButtonPotvrdi;
        private Klase.FlatButtonNo flatButtonOdustani;
    }
}