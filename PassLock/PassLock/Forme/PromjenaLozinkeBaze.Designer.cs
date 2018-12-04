namespace PassLock.Forme
{
    partial class PromjenaLozinkeBaze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromjenaLozinkeBaze));
            this.flatButtonOdustani = new PassLock.Klase.FlatButtonNo();
            this.flatButtonPotvrdi = new PassLock.Klase.FlatButtonYes();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLozinka2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLozinka1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flatButtonOdustani
            // 
            this.flatButtonOdustani.BorderThickness = 2F;
            this.flatButtonOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flatButtonOdustani.Location = new System.Drawing.Point(95, 231);
            this.flatButtonOdustani.Name = "flatButtonOdustani";
            this.flatButtonOdustani.Size = new System.Drawing.Size(126, 39);
            this.flatButtonOdustani.TabIndex = 20;
            this.flatButtonOdustani.Text = "ODUSTANI";
            this.flatButtonOdustani.Click += new System.EventHandler(this.flatButtonOdustani_Click);
            // 
            // flatButtonPotvrdi
            // 
            this.flatButtonPotvrdi.BorderThickness = 2F;
            this.flatButtonPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flatButtonPotvrdi.Location = new System.Drawing.Point(286, 231);
            this.flatButtonPotvrdi.Name = "flatButtonPotvrdi";
            this.flatButtonPotvrdi.Size = new System.Drawing.Size(126, 39);
            this.flatButtonPotvrdi.TabIndex = 21;
            this.flatButtonPotvrdi.Text = "POTVRDI";
            this.flatButtonPotvrdi.Click += new System.EventHandler(this.flatButtonPotvrdi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ponovite novu lozinku:";
            // 
            // txtLozinka2
            // 
            this.txtLozinka2.Location = new System.Drawing.Point(95, 163);
            this.txtLozinka2.Name = "txtLozinka2";
            this.txtLozinka2.Size = new System.Drawing.Size(317, 22);
            this.txtLozinka2.TabIndex = 24;
            this.txtLozinka2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Upišite novu lozinku:";
            // 
            // txtLozinka1
            // 
            this.txtLozinka1.Location = new System.Drawing.Point(95, 83);
            this.txtLozinka1.Name = "txtLozinka1";
            this.txtLozinka1.Size = new System.Drawing.Size(317, 22);
            this.txtLozinka1.TabIndex = 22;
            this.txtLozinka1.UseSystemPasswordChar = true;
            // 
            // PromjenaLozinkeBaze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLozinka2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLozinka1);
            this.Controls.Add(this.flatButtonPotvrdi);
            this.Controls.Add(this.flatButtonOdustani);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(533, 387);
            this.MinimumSize = new System.Drawing.Size(533, 387);
            this.Name = "PromjenaLozinkeBaze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena lozinke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Klase.FlatButtonNo flatButtonOdustani;
        private Klase.FlatButtonYes flatButtonPotvrdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLozinka2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLozinka1;
    }
}