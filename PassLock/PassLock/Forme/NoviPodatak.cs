using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
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
            //enkripcija

            string sql = "INSERT INTO podaci(naziv,lozinka) values('"+txtNaziv.Text+"','"+txtLozinka.Text+"')";
            SQLiteCommand command = new SQLiteCommand(sql, mojaKonekcija.conn);
            command.ExecuteNonQuery();

            mojaKonekcija.ZatvoriKonekciju();
            this.Close();
        }
    }
}
