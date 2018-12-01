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

namespace PassLock
{
    public partial class Form1 : Form
    {
        private SQLiteConnection sQLiteConnection;

        public Form1()
        {
            InitializeComponent();
            this.Text = "PassLock";

            string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\PassLockDB.db";
            sQLiteConnection = new SQLiteConnection("Data Source=" + path);
            sQLiteConnection.Open();
        }

        private void buttonRegistrirajSe_Click(object sender, EventArgs e)
        {
            RegistrirajSe registrirajSe = new RegistrirajSe();
            registrirajSe.ShowDialog();
        }

        private void buttonPrijaviSe_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = sQLiteConnection;

            string korisnickoIme = textBoxKorisnickoIme.Text;
            string lozinka = textBoxLozinka.Text;

            cmd.CommandText = "SELECT * FROM korisnik WHERE korime='" + korisnickoIme + "' AND lozinka='" + lozinka+"'";

            int brojRedova;
            string test = "";
            SQLiteDataReader reader = cmd.ExecuteReader();

            this.Text = test;
            sQLiteConnection.Close();
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            sQLiteConnection.Close();
        }
    }
}
