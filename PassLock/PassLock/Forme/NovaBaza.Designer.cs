namespace PassLock.Forme
{
    partial class NovaBaza
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
            this.txtLozinka1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLozinka2 = new System.Windows.Forms.TextBox();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLozinka1
            // 
            this.txtLozinka1.Location = new System.Drawing.Point(21, 59);
            this.txtLozinka1.Name = "txtLozinka1";
            this.txtLozinka1.Size = new System.Drawing.Size(258, 22);
            this.txtLozinka1.TabIndex = 0;
            this.txtLozinka1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upišite željenu lozinku:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ponovno upišite željenu lozinku:";
            // 
            // txtLozinka2
            // 
            this.txtLozinka2.Location = new System.Drawing.Point(21, 119);
            this.txtLozinka2.Name = "txtLozinka2";
            this.txtLozinka2.Size = new System.Drawing.Size(258, 22);
            this.txtLozinka2.TabIndex = 2;
            this.txtLozinka2.UseSystemPasswordChar = true;
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPotvrdi.Location = new System.Drawing.Point(125, 172);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(126, 39);
            this.buttonPotvrdi.TabIndex = 4;
            this.buttonPotvrdi.Text = "POTVRDI";
            this.buttonPotvrdi.UseVisualStyleBackColor = false;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // NovaBaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 223);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLozinka2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLozinka1);
            this.Name = "NovaBaza";
            this.Text = "NovaBaza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLozinka1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLozinka2;
        private System.Windows.Forms.Button buttonPotvrdi;
    }
}