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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonOtvoriBazu = new System.Windows.Forms.Button();
            this.buttonNovaBaza = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOtvoriBazu
            // 
            this.buttonOtvoriBazu.Location = new System.Drawing.Point(108, 98);
            this.buttonOtvoriBazu.Name = "buttonOtvoriBazu";
            this.buttonOtvoriBazu.Size = new System.Drawing.Size(103, 28);
            this.buttonOtvoriBazu.TabIndex = 3;
            this.buttonOtvoriBazu.Text = "Otvori bazu";
            this.buttonOtvoriBazu.UseVisualStyleBackColor = true;
            this.buttonOtvoriBazu.Click += new System.EventHandler(this.buttonOtvoriBazu_Click);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(59, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 275);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonNovaBaza);
            this.Controls.Add(this.buttonOtvoriBazu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(339, 322);
            this.MinimumSize = new System.Drawing.Size(339, 322);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOtvoriBazu;
        private System.Windows.Forms.Button buttonNovaBaza;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

