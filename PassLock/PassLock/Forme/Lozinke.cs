﻿using System;
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
        #region Members
        Konekcija mojaKonekcija = new Konekcija();
        private string odabranaLozinka;
        private int idPodatak;
        #endregion

        #region Constructors
        public Lozinke()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void Lozinke_Load(object sender, EventArgs e)
        {
            mojaKonekcija.OtvoriKonekciju(Sesija.Putanja, Sesija.Lozinka);
            OsvjeziPodatke(mojaKonekcija.conn);
            mojaKonekcija.ZatvoriKonekciju();
            dgvPodaci.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dgvPodaci.Columns[2].DefaultCellStyle.ForeColor = Color.White;
            dgvPodaci.Columns[2].DefaultCellStyle.SelectionForeColor = Color.CornflowerBlue;

            PostaviContextMeniIteme();
        }
        private void dgvPodaci_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                odabranaLozinka = dgvPodaci.CurrentRow.Cells[2].Value.ToString();
                idPodatak = int.Parse(dgvPodaci.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception) { }
        }
        private void flatButtonOdjaviSe_Click(object sender, EventArgs e)
        {
            PassLockEkran pocetnaForma = new PassLockEkran();
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

                IzmjeniPodatak formaIzmjeni = new IzmjeniPodatak(mojPodatak);
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
            NoviPodatak noviPodatak = new NoviPodatak();
            noviPodatak.ShowDialog();

            mojaKonekcija.OtvoriKonekciju(Sesija.Putanja, Sesija.Lozinka);
            OsvjeziPodatke(mojaKonekcija.conn);
            mojaKonekcija.ZatvoriKonekciju();
        }
        private void flatButtonClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(odabranaLozinka);
        }

        private void flatButtonPromjenaLozinke_Click(object sender, EventArgs e)
        {
            PromjenaLozinkeBaze promjenaLozinkeBaze = new PromjenaLozinkeBaze();
            promjenaLozinkeBaze.Show();
        }

        private void checkBoxSakriLozinke_CheckedChanged(object sender, EventArgs e)
        {
            bool stanje = checkBoxSakriLozinke.Checked;
            if (stanje)
            {
                dgvPodaci.Columns[2].DefaultCellStyle.ForeColor = Color.White;
                dgvPodaci.Columns[2].DefaultCellStyle.SelectionForeColor = Color.CornflowerBlue;
            }
            else
            {
                dgvPodaci.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                dgvPodaci.Columns[2].DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }

        private void KopirajLozinku(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(odabranaLozinka);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Lozinke_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Sesija.ObrisiPodatkeOSesiji();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Private methods
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

        
        private void IzbrisiPodatak()
        {
            mojaKonekcija.OtvoriKonekciju(Sesija.Putanja, Sesija.Lozinka);
            try
            {
                //pokusaj pristupa podacima
                string sql1 = "SELECT * FROM podaci";
                SQLiteCommand command1 = new SQLiteCommand(sql1, mojaKonekcija.conn);
                command1.ExecuteNonQuery();
            }
            catch (SQLiteException)
            {
                MessageBox.Show("Greška kod pristupa podacima!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //enkripcija

            string sqlDelete = "DELETE FROM podaci WHERE id = " + idPodatak + ";";
            SQLiteCommand command = new SQLiteCommand(sqlDelete, mojaKonekcija.conn);
            command.ExecuteNonQuery();

            mojaKonekcija.ZatvoriKonekciju();
        }

        private void PostaviContextMeniIteme()
        {
            try
            {
                InicijalizirajContextMenuStrip(dgvPodaci);

                // Kopiraj lozinku
                var cmsKopirajLozinku = dgvPodaci.ContextMenuStrip.Items.Add("Kopiraj lozinku");
                cmsKopirajLozinku.Name = "KopirajLozinku";
                cmsKopirajLozinku.Click += new EventHandler(KopirajLozinku);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InicijalizirajContextMenuStrip(DataGridView grid)
        {
            try
            {
                if(grid.ContextMenuStrip == null)
                {
                    grid.ContextMenuStrip = new ContextMenuStrip();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
