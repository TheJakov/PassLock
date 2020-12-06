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
            this.lblUpisiteLozinku = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.trackBarDuljinaLozinke = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDuljinaZnakova = new System.Windows.Forms.Label();
            this.checkBoxEnkriptiraj = new System.Windows.Forms.CheckBox();
            this.flatButtonPotvrdi = new PassLock.Kontrole.FlatButtonYes();
            this.flatButtonOdustani = new PassLock.Kontrole.FlatButtonNo();
            this.lblOpcionalnoLozinka = new System.Windows.Forms.Label();
            this.lblObavezno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDuljinaLozinke)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpisiteLozinku
            // 
            this.lblUpisiteLozinku.AutoSize = true;
            this.lblUpisiteLozinku.BackColor = System.Drawing.Color.Transparent;
            this.lblUpisiteLozinku.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpisiteLozinku.Location = new System.Drawing.Point(53, 95);
            this.lblUpisiteLozinku.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpisiteLozinku.Name = "lblUpisiteLozinku";
            this.lblUpisiteLozinku.Size = new System.Drawing.Size(218, 22);
            this.lblUpisiteLozinku.TabIndex = 8;
            this.lblUpisiteLozinku.Text = "Dio sjemena za enkripciju:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(57, 119);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(2);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(239, 20);
            this.txtLozinka.TabIndex = 7;
            this.txtLozinka.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(57, 54);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(239, 20);
            this.txtNaziv.TabIndex = 5;
            // 
            // trackBarDuljinaLozinke
            // 
            this.trackBarDuljinaLozinke.Location = new System.Drawing.Point(57, 202);
            this.trackBarDuljinaLozinke.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarDuljinaLozinke.Maximum = 64;
            this.trackBarDuljinaLozinke.Minimum = 1;
            this.trackBarDuljinaLozinke.Name = "trackBarDuljinaLozinke";
            this.trackBarDuljinaLozinke.Size = new System.Drawing.Size(238, 45);
            this.trackBarDuljinaLozinke.TabIndex = 12;
            this.trackBarDuljinaLozinke.Value = 64;
            this.trackBarDuljinaLozinke.ValueChanged += new System.EventHandler(this.trackBarDuljinaLozinke_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Duljina lozinke:";
            // 
            // labelDuljinaZnakova
            // 
            this.labelDuljinaZnakova.AutoSize = true;
            this.labelDuljinaZnakova.BackColor = System.Drawing.Color.Transparent;
            this.labelDuljinaZnakova.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuljinaZnakova.Location = new System.Drawing.Point(177, 169);
            this.labelDuljinaZnakova.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDuljinaZnakova.Name = "labelDuljinaZnakova";
            this.labelDuljinaZnakova.Size = new System.Drawing.Size(30, 22);
            this.labelDuljinaZnakova.TabIndex = 14;
            this.labelDuljinaZnakova.Text = "64";
            // 
            // checkBoxEnkriptiraj
            // 
            this.checkBoxEnkriptiraj.AutoSize = true;
            this.checkBoxEnkriptiraj.Checked = true;
            this.checkBoxEnkriptiraj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnkriptiraj.Location = new System.Drawing.Point(57, 143);
            this.checkBoxEnkriptiraj.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnkriptiraj.Name = "checkBoxEnkriptiraj";
            this.checkBoxEnkriptiraj.Size = new System.Drawing.Size(115, 17);
            this.checkBoxEnkriptiraj.TabIndex = 18;
            this.checkBoxEnkriptiraj.Text = "Enkriptiraj SHA256";
            this.checkBoxEnkriptiraj.UseVisualStyleBackColor = true;
            this.checkBoxEnkriptiraj.CheckedChanged += new System.EventHandler(this.checkBoxEnkriptiraj_CheckedChanged);
            // 
            // flatButtonPotvrdi
            // 
            this.flatButtonPotvrdi.BorderThickness = 2F;
            this.flatButtonPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flatButtonPotvrdi.Location = new System.Drawing.Point(246, 255);
            this.flatButtonPotvrdi.Margin = new System.Windows.Forms.Padding(2);
            this.flatButtonPotvrdi.Name = "flatButtonPotvrdi";
            this.flatButtonPotvrdi.Size = new System.Drawing.Size(94, 32);
            this.flatButtonPotvrdi.TabIndex = 16;
            this.flatButtonPotvrdi.Text = "POTVRDI";
            this.flatButtonPotvrdi.Click += new System.EventHandler(this.flatButtonPotvrdi_Click);
            // 
            // flatButtonOdustani
            // 
            this.flatButtonOdustani.BorderThickness = 2F;
            this.flatButtonOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flatButtonOdustani.Location = new System.Drawing.Point(103, 255);
            this.flatButtonOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.flatButtonOdustani.Name = "flatButtonOdustani";
            this.flatButtonOdustani.Size = new System.Drawing.Size(94, 32);
            this.flatButtonOdustani.TabIndex = 15;
            this.flatButtonOdustani.Text = "ODUSTANI";
            this.flatButtonOdustani.Click += new System.EventHandler(this.flatButtonOdustani_Click);
            // 
            // lblOpcionalnoLozinka
            // 
            this.lblOpcionalnoLozinka.AutoSize = true;
            this.lblOpcionalnoLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcionalnoLozinka.Location = new System.Drawing.Point(310, 122);
            this.lblOpcionalnoLozinka.Name = "lblOpcionalnoLozinka";
            this.lblOpcionalnoLozinka.Size = new System.Drawing.Size(92, 13);
            this.lblOpcionalnoLozinka.TabIndex = 19;
            this.lblOpcionalnoLozinka.Text = "(Opcionalno polje)";
            // 
            // lblObavezno
            // 
            this.lblObavezno.AutoSize = true;
            this.lblObavezno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObavezno.Location = new System.Drawing.Point(310, 57);
            this.lblObavezno.Name = "lblObavezno";
            this.lblObavezno.Size = new System.Drawing.Size(87, 13);
            this.lblObavezno.TabIndex = 20;
            this.lblObavezno.Text = "(Obavezno polje)";
            // 
            // NoviPodatak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 341);
            this.Controls.Add(this.lblObavezno);
            this.Controls.Add(this.lblOpcionalnoLozinka);
            this.Controls.Add(this.checkBoxEnkriptiraj);
            this.Controls.Add(this.flatButtonPotvrdi);
            this.Controls.Add(this.flatButtonOdustani);
            this.Controls.Add(this.labelDuljinaZnakova);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarDuljinaLozinke);
            this.Controls.Add(this.lblUpisiteLozinku);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(449, 380);
            this.MinimumSize = new System.Drawing.Size(449, 380);
            this.Name = "NoviPodatak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi podatak";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDuljinaLozinke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUpisiteLozinku;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TrackBar trackBarDuljinaLozinke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDuljinaZnakova;
        private Kontrole.FlatButtonNo flatButtonOdustani;
        private Kontrole.FlatButtonYes flatButtonPotvrdi;
        private System.Windows.Forms.CheckBox checkBoxEnkriptiraj;
        private System.Windows.Forms.Label lblOpcionalnoLozinka;
        private System.Windows.Forms.Label lblObavezno;
    }
}