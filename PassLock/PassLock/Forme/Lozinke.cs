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
            dgvPodaci.Columns[2].DefaultCellStyle.ForeColor = Color.White;
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
        private void IzbrisiPodatak()
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
            }
            //enkripcija

            string sqlDelete = "DELETE FROM podaci WHERE id = " + idPodatak + ";";
            SQLiteCommand command = new SQLiteCommand(sqlDelete, mojaKonekcija.conn);
            command.ExecuteNonQuery();

            mojaKonekcija.ZatvoriKonekciju();
        }

        private void flatButtonOdjaviSe_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForma = new Form1();
            this.Hide();
            pocetnaForma.ShowDialog();
            this.Close();
        }

        private void flatButtonNoIzbrisi_Click(object sender, EventArgs e)
        {
            string nazivLozinke;
            if (int.TryParse(dgvPodaci.CurrentRow.Cells[0].Value.ToString(), out idPodatak))
            {
                nazivLozinke = dgvPodaci.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show("Želite li stvarno obrisati lozinku sa sifrom: " + idPodatak + " i nazivom " + nazivLozinke + " ?", "Pozor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IzbrisiPodatak();
                    OsvjeziPodatke(mojaKonekcija.conn);
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali niti jednu lozinku !", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void flatButtonIzmjeni_Click(object sender, EventArgs e)
        {
            Podatak mojPodatak = new Podatak();
            int rBr;
            if (int.TryParse(dgvPodaci.CurrentRow.Cells[0].Value.ToString(), out rBr))
            {
                mojPodatak.RedniBroj = rBr;
                mojPodatak.Naziv = dgvPodaci.CurrentRow.Cells[1].Value.ToString();
                mojPodatak.Lozinka = dgvPodaci.CurrentRow.Cells[2].Value.ToString();

                IzmjeniPodatak formaIzmjeni = new IzmjeniPodatak(lozinka, putanja, mojPodatak);
                formaIzmjeni.ShowDialog();
                OsvjeziPodatke(mojaKonekcija.conn);
            }
            else
            {
                MessageBox.Show("Niste odabrali niti jednu lozinku !", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void flatButtonDodaj_Click(object sender, EventArgs e)
        {
            NoviPodatak noviPodatak = new NoviPodatak(lozinka, putanja);
            noviPodatak.ShowDialog();

            mojaKonekcija.OtvoriKonekciju(putanja, lozinka);
            OsvjeziPodatke(mojaKonekcija.conn);
            mojaKonekcija.ZatvoriKonekciju();
        }
        private void flatButtonClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(odabranaLozinka);
        }

        private void flatButtonPromjenaLozinke_Click(object sender, EventArgs e)
        {
            PromjenaLozinkeBaze promjenaLozinkeBaze = new PromjenaLozinkeBaze(putanja,lozinka);
            promjenaLozinkeBaze.Show();
        }

        private void checkBoxSakriLozinke_CheckedChanged(object sender, EventArgs e)
        {
            bool stanje = checkBoxSakriLozinke.Checked;
            if (stanje)
            {
                dgvPodaci.Columns[2].DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                dgvPodaci.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}
