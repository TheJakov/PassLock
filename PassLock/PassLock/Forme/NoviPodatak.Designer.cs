namespace PassLock.Forme
{
    partial class NoviPodatak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoviPodatak));
            this.label2 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.trackBarDuljinaLozinke = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDuljinaZnakova = new System.Windows.Forms.Label();
            this.flatButtonOdustani = new PassLock.Klase.FlatButtonNo();
            this.flatButtonPotvrdi = new PassLock.Klase.FlatButtonYes();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDuljinaLozinke)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Upišite željenu lozinku:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(101, 146);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(317, 22);
            this.txtLozinka.TabIndex = 7;
            this.txtLozinka.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(101, 66);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(317, 22);
            this.txtNaziv.TabIndex = 5;
            // 
            // trackBarDuljinaLozinke
            // 
            this.trackBarDuljinaLozinke.Location = new System.Drawing.Point(101, 234);
            this.trackBarDuljinaLozinke.Maximum = 64;
            this.trackBarDuljinaLozinke.Minimum = 1;
            this.trackBarDuljinaLozinke.Name = "trackBarDuljinaLozinke";
            this.trackBarDuljinaLozinke.Size = new System.Drawing.Size(317, 56);
            this.trackBarDuljinaLozinke.TabIndex = 12;
            this.trackBarDuljinaLozinke.Value = 64;
            this.trackBarDuljinaLozinke.ValueChanged += new System.EventHandler(this.trackBarDuljinaLozinke_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Duljina lozinke:";
            // 
            // labelDuljinaZnakova
            // 
            this.labelDuljinaZnakova.AutoSize = true;
            this.labelDuljinaZnakova.BackColor = System.Drawing.Color.Transparent;
            this.labelDuljinaZnakova.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuljinaZnakova.Location = new System.Drawing.Point(261, 193);
            this.labelDuljinaZnakova.Name = "labelDuljinaZnakova";
            this.labelDuljinaZnakova.Size = new System.Drawing.Size(36, 26);
            this.labelDuljinaZnakova.TabIndex = 14;
            this.labelDuljinaZnakova.Text = "64";
            // 
            // flatButtonOdustani
            // 
            this.flatButtonOdustani.BorderThickness = 2F;
            this.flatButtonOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flatButtonOdustani.Location = new System.Drawing.Point(101, 314);
            this.flatButtonOdustani.Name = "flatButtonOdustani";
            this.flatButtonOdustani.Size = new System.Drawing.Size(126, 39);
            this.flatButtonOdustani.TabIndex = 15;
            this.flatButtonOdustani.Text = "ODUSTANI";
            this.flatButtonOdustani.Click += new System.EventHandler(this.flatButtonOdustani_Click);
            // 
            // flatButtonPotvrdi
            // 
            this.flatButtonPotvrdi.BorderThickness = 2F;
            this.flatButtonPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flatButtonPotvrdi.Location = new System.Drawing.Point(292, 314);
            this.flatButtonPotvrdi.Name = "flatButtonPotvrdi";
            this.flatButtonPotvrdi.Size = new System.Drawing.Size(126, 39);
            this.flatButtonPotvrdi.TabIndex = 16;
            this.flatButtonPotvrdi.Text = "POTVRDI";
            this.flatButtonPotvrdi.Click += new System.EventHandler(this.flatButtonPotvrdi_Click);
            // 
            // NoviPodatak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.flatButtonPotvrdi);
            this.Controls.Add(this.flatButtonOdustani);
            this.Controls.Add(this.labelDuljinaZnakova);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarDuljinaLozinke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 459);
            this.MinimumSize = new System.Drawing.Size(550, 459);
            this.Name = "NoviPodatak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi podatak";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDuljinaLozinke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TrackBar trackBarDuljinaLozinke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDuljinaZnakova;
        private Klase.FlatButtonNo flatButtonOdustani;
        private Klase.FlatButtonYes flatButtonPotvrdi;
    }
}