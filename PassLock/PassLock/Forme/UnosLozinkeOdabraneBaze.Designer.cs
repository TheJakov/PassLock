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
            this.txtLozinka1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPotvrdi.Location = new System.Drawing.Point(200, 168);
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
            // txtLozinka1
            // 
            this.txtLozinka1.Location = new System.Drawing.Point(102, 98);
            this.txtLozinka1.Name = "txtLozinka1";
            this.txtLozinka1.Size = new System.Drawing.Size(317, 22);
            this.txtLozinka1.TabIndex = 5;
            this.txtLozinka1.UseSystemPasswordChar = true;
            // 
            // UnosLozinkeOdabraneBaze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 330);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLozinka1);
            this.Name = "UnosLozinkeOdabraneBaze";
            this.Text = "UnosLozinkeOdabraneBaze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPotvrdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLozinka1;
    }
}