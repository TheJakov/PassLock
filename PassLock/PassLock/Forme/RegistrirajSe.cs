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
using System.Reflection;
using System.IO;

namespace PassLock
{
    public partial class RegistrirajSe : Form 
    {
        SQLiteConnection sQLiteConnection;
        public RegistrirajSe()
        {
            InitializeComponent();
            this.Text = "Registracija";

            string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\PassLockDB.db";
            sQLiteConnection = new SQLiteConnection("Data Source="+path);
            sQLiteConnection.Open();
        }

        private void buttonRegistrirajKorisnika_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = sQLiteConnection;            

            string korisnickoIme = textBoxKorisnickoIme.Text;
            string lozinka = textBoxLozinka.Text;

            cmd.CommandText= "INSERT INTO korisnik(korime,lozinka) VALUES('" + korisnickoIme + "','" + lozinka + "')";

            cmd.ExecuteNonQuery();

            sQLiteConnection.Close();


            this.Close();
        }

        private void RegistrirajSe_Leave(object sender, EventArgs e)
        {
            sQLiteConnection.Close();
        }
    }
}
