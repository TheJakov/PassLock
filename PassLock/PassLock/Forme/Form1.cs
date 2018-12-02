using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data.SqlClient;
using PassLock.Klase;
using PassLock.Forme;

namespace PassLock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "PassLock";
        }

        private void buttonNovaBaza_Click(object sender, EventArgs e)
        {
            Forme.NovaBaza novaBaza = new Forme.NovaBaza();
            this.Hide();
            novaBaza.ShowDialog();
            this.Close();
        }
        
        private void buttonOtvoriBazu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "File|*.db";
            openFileDialog1.Title = "Select file";
  
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string putanja = Path.GetFullPath(openFileDialog1.FileName).ToString();

                Forme.UnosLozinkeOdabraneBaze novaForma = new Forme.UnosLozinkeOdabraneBaze(putanja);
                this.Hide();
                novaForma.ShowDialog();
                this.Close();
                
            }
        }
    }
}
