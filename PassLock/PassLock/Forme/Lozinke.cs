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

namespace PassLock
{
    public partial class Lozinke : Form
    {
        Konekcija mojaKonekcija = new Konekcija();

        private string lozinka;
        private string putanja;

        private string odabranaLozinka;
        private int idPodatak;

        public Lozinke()
        {
            InitializeComponent();
        }
        public Lozinke(string lozinka, string putanja)
        {
            InitializeComponent();
            this.lozinka = lozinka;
            this.putanja = putanja;
        }

        private void Lozinke_Load(object sender, EventArgs e)
        {
            mojaKonekcija.OtvoriKonekciju(putanja, lozinka);
            OsvjeziPodatke(mojaKonekcija.conn);
            mojaKonekcija.ZatvoriKonekciju();
        }

        private void buttonOdjava_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForma = new Form1();
            this.Hide();
            pocetnaForma.ShowDialog();
            this.Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            NoviPodatak noviPodatak = new NoviPodatak(lozinka, putanja);
            noviPodatak.ShowDialog();

            mojaKonekcija.OtvoriKonekciju(putanja, lozinka);
            OsvjeziPodatke(mojaKonekcija.conn);
            mojaKonekcija.ZatvoriKonekciju();
        }

        private void OsvjeziPodatke(SQLiteConnection conn)
        {
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM podaci", conn);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "Info");
            dgvPodaci.DataSource = ds.Tables[0];
            dgvPodaci.Columns[0].HeaderText = "Redni broj";
            dgvPodaci.Columns[0].Width = 89;
            dgvPodaci.Columns[1].HeaderText = "Naziv";
            dgvPodaci.Columns[1].Width = 139;
            dgvPodaci.Columns[2].HeaderText = "Lozinka";
            dgvPodaci.Columns[2].Width = 336;
        }

        private void dgvPodaci_SelectionChanged(object sender, EventArgs e)
        {
            odabranaLozinka = dgvPodaci.CurrentRow.Cells[2].Value.ToString();
            idPodatak = int.Parse(dgvPodaci.CurrentRow.Cells[0].Value.ToString());

        }
    }
}
