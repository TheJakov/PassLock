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
    public partial class IzmjeniPodatak : Form
    {
        Konekcija mojaKonekcija = new Konekcija();
        private string lozinka;
        private string putanja;
        Podatak mojPodatak;
        public IzmjeniPodatak()
        {
            InitializeComponent();
        }
        public IzmjeniPodatak(string lozinka, string putanja, Podatak podatak)
        {
            InitializeComponent();
            this.lozinka = lozinka;
            this.putanja = putanja;
            mojPodatak = podatak;

            txtRedniBroj.Text = mojPodatak.RedniBroj.ToString();
            txtNaziv.Text = mojPodatak.Naziv;
            txtLozinka.Text = mojPodatak.Lozinka;
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text.Length > 0)
            {
                if (txtLozinka.Text.Length > 0)
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
                    string sqlUpdate = "UPDATE podaci " +
                         "SET naziv = '" + txtNaziv.Text + "', lozinka = '" + txtLozinka.Text + "' " +
                         "WHERE id = "+txtRedniBroj.Text+";";
                    SQLiteCommand command = new SQLiteCommand(sqlUpdate, mojaKonekcija.conn);
                    command.ExecuteNonQuery();

                    mojaKonekcija.ZatvoriKonekciju();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Neispravan unos lozinke !", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Neispravan unos naziva podatka !", "Pažnja!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
