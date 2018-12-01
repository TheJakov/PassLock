namespace PassLock
{
    partial class Form1
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
            this.labelaNaslov = new System.Windows.Forms.Label();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.buttonPrijaviSe = new System.Windows.Forms.Button();
            this.buttonRegistrirajSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelaNaslov
            // 
            this.labelaNaslov.AutoSize = true;
            this.labelaNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaNaslov.Location = new System.Drawing.Point(105, 34);
            this.labelaNaslov.Name = "labelaNaslov";
            this.labelaNaslov.Size = new System.Drawing.Size(106, 25);
            this.labelaNaslov.TabIndex = 0;
            this.labelaNaslov.Text = "PassLock";
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(92, 85);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(131, 22);
            this.textBoxKorisnickoIme.TabIndex = 1;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(92, 113);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(131, 22);
            this.textBoxLozinka.TabIndex = 2;
            // 
            // buttonPrijaviSe
            // 
            this.buttonPrijaviSe.Location = new System.Drawing.Point(108, 141);
            this.buttonPrijaviSe.Name = "buttonPrijaviSe";
            this.buttonPrijaviSe.Size = new System.Drawing.Size(103, 28);
            this.buttonPrijaviSe.TabIndex = 3;
            this.buttonPrijaviSe.Text = "Prijavi se";
            this.buttonPrijaviSe.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrirajSe
            // 
            this.buttonRegistrirajSe.Location = new System.Drawing.Point(108, 190);
            this.buttonRegistrirajSe.Name = "buttonRegistrirajSe";
            this.buttonRegistrirajSe.Size = new System.Drawing.Size(103, 28);
            this.buttonRegistrirajSe.TabIndex = 4;
            this.buttonRegistrirajSe.Text = "Registriraj se";
            this.buttonRegistrirajSe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 253);
            this.Controls.Add(this.buttonRegistrirajSe);
            this.Controls.Add(this.buttonPrijaviSe);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textBoxKorisnickoIme);
            this.Controls.Add(this.labelaNaslov);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelaNaslov;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Button buttonPrijaviSe;
        private System.Windows.Forms.Button buttonRegistrirajSe;
    }
}

