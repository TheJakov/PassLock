namespace PassLock.Forme
{
    partial class UnosLozinkeOdabraneBaze
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
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPotvrdi.Location = new System.Drawing.Point(102, 166);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(126, 39);
            this.buttonPotvrdi.TabIndex = 9;
            this.buttonPotvrdi.Text = "POTVRDI";
            this.buttonPotvrdi.UseVisualStyleBackColor = false;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Upišite lozinku:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(102, 98);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(317, 22);
            this.txtLozinka.TabIndex = 5;
            this.txtLozinka.UseSystemPasswordChar = true;
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.BackColor = System.Drawing.Color.Coral;
            this.buttonOdustani.Location = new System.Drawing.Point(293, 166);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(126, 39);
            this.buttonOdustani.TabIndex = 10;
            this.buttonOdustani.Text = "ODUSTANI";
            this.buttonOdustani.UseVisualStyleBackColor = false;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // UnosLozinkeOdabraneBaze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 330);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLozinka);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(533, 377);
            this.MinimumSize = new System.Drawing.Size(533, 377);
            this.Name = "UnosLozinkeOdabraneBaze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otvori postojeću bazu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPotvrdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button buttonOdustani;
    }
}