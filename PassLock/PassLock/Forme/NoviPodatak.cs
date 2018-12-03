using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassLock.Forme;
using PassLock.Klase;

namespace PassLock.Forme
{
    public partial class NoviPodatak : Form
    {
        Konekcija mojaKonekcija = new Konekcija();

        private string lozinka;
        private string putanja;
        private int duljinaLozinke = 64;
        public NoviPodatak()
        {
            InitializeComponent();
        }
        public NoviPodatak(string lozinka, string putanja)
        {
            InitializeComponent();
            this.lozinka = lozinka;
            this.putanja = putanja;
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            mojaKonekcija.OtvoriKonekciju(putanja, lozinka);
            try
            {
                //pokusaj pristupa podacima
                string sql1 = "SELECT * FROM podaci";
                SQLiteCommand command1 = new SQLiteCommand(sql1, mojaKonekcija.conn);
                command1.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Greška kod pristupa podacima!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNaziv.Clear();
                txtLozinka.Clear();
            }

            string kriptiranaLozinka = Enkriptiraj(txtLozinka.Text);
            string sql = "INSERT INTO podaci(naziv,lozinka) values('"+txtNaziv.Text+"','"+kriptiranaLozinka+"')";
            SQLiteCommand command = new SQLiteCommand(sql, mojaKonekcija.conn);
            command.ExecuteNonQuery();

            mojaKonekcija.ZatvoriKonekciju();
            this.Close();
        }

        public string Enkriptiraj(string lozinka)
        {

            string obradbeniPodatak = lozinka + DateTime.Now.ToString();
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(obradbeniPodatak));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                string finalLozinka = builder.ToString().Substring(0, duljinaLozinke);
                return finalLozinka;
            }
        }

        private void trackBarDuljinaLozinke_ValueChanged(object sender, EventArgs e)
        {
            labelDuljinaZnakova.Text = trackBarDuljinaLozinke.Value.ToString();
            duljinaLozinke = trackBarDuljinaLozinke.Value;
        }
    }
}
