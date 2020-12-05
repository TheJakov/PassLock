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
        #region Members
        Konekcija mojaKonekcija = new Konekcija();
        Enkripcija enkriptor = new Enkripcija();
        Podatak mojPodatak;
        #endregion

        #region Constructors
        public IzmjeniPodatak()
        {
            InitializeComponent();
        }
        public IzmjeniPodatak(Podatak podatak)
        {
            InitializeComponent();
            mojPodatak = podatak;

            txtRedniBroj.Text = mojPodatak.RedniBroj.ToString();
            txtNaziv.Text = mojPodatak.Naziv;
            txtLozinka.Text = mojPodatak.Lozinka;
        }
        #endregion

        #region Events
        private void flatButtonPotvrdi_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text.Length > 0)
            {
                if (txtLozinka.Text.Length > 0)
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
                        txtNaziv.Clear();
                        txtLozinka.Clear();
                    }
                    string lozinkaUpdate = txtLozinka.Text;
                    if (checkBoxEnkriptiraj.Checked)
                    {
                        lozinkaUpdate = enkriptor.Enkriptiraj(txtLozinka.Text, 64);
                    }
                    string sqlUpdate = "UPDATE podaci " +
                         "SET naziv = '" + txtNaziv.Text + "', lozinka = '" + lozinkaUpdate + "' " +
                         "WHERE id = " + txtRedniBroj.Text + ";";
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

        private void flatButtonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
