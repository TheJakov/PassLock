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
            this.buttonPrijaviSe = new System.Windows.Forms.Button();
            this.buttonNovaBaza = new System.Windows.Forms.Button();
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
            // buttonPrijaviSe
            // 
            this.buttonPrijaviSe.Location = new System.Drawing.Point(108, 98);
            this.buttonPrijaviSe.Name = "buttonPrijaviSe";
            this.buttonPrijaviSe.Size = new System.Drawing.Size(103, 28);
            this.buttonPrijaviSe.TabIndex = 3;
            this.buttonPrijaviSe.Text = "Otvori bazu";
            this.buttonPrijaviSe.UseVisualStyleBackColor = true;
            // 
            // buttonNovaBaza
            // 
            this.buttonNovaBaza.Location = new System.Drawing.Point(110, 150);
            this.buttonNovaBaza.Name = "buttonNovaBaza";
            this.buttonNovaBaza.Size = new System.Drawing.Size(103, 28);
            this.buttonNovaBaza.TabIndex = 4;
            this.buttonNovaBaza.Text = "Nova baza";
            this.buttonNovaBaza.UseVisualStyleBackColor = true;
            this.buttonNovaBaza.Click += new System.EventHandler(this.buttonNovaBaza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 271);
            this.Controls.Add(this.buttonNovaBaza);
            this.Controls.Add(this.buttonPrijaviSe);
            this.Controls.Add(this.labelaNaslov);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelaNaslov;
        private System.Windows.Forms.Button buttonPrijaviSe;
        private System.Windows.Forms.Button buttonNovaBaza;
    }
}

