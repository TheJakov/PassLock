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
        #region Members
        Konekcija mojaKonekcija = new Konekcija();
        Enkripcija enkriptor = new Enkripcija();

        private int duljinaLozinke = 64;
        #endregion

        #region Constructors
        public NoviPodatak()
        {
            InitializeComponent();
            checkBoxEnkriptiraj.Checked = true;
        }
        #endregion

        #region Events
        private void trackBarDuljinaLozinke_ValueChanged(object sender, EventArgs e)
        {
            labelDuljinaZnakova.Text = trackBarDuljinaLozinke.Value.ToString();
            duljinaLozinke = trackBarDuljinaLozinke.Value;
        }

        private void flatButtonPotvrdi_Click(object sender, EventArgs e)
        {
            if (!ValidirajUnos())
                return;

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

            string lozinkaZaSpremiti;
            if (checkBoxEnkriptiraj.Checked)
                lozinkaZaSpremiti = enkriptor.Enkriptiraj(txtLozinka.Text, duljinaLozinke);
            else
                lozinkaZaSpremiti = txtLozinka.Text;

            string sql = "INSERT INTO podaci(naziv,lozinka) values('" + txtNaziv.Text + "','" + lozinkaZaSpremiti + "')";
            SQLiteCommand command = new SQLiteCommand(sql, mojaKonekcija.conn);
            command.ExecuteNonQuery();

            mojaKonekcija.ZatvoriKonekciju();
            this.Close();
        }

        private void flatButtonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void checkBoxEnkriptiraj_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxEnkriptiraj.Checked)
                {
                    label3.Enabled = true;
                    labelDuljinaZnakova.Enabled = true;
                    trackBarDuljinaLozinke.Enabled = true;

                    lblUpisiteLozinku.Text = "Dio sjemena za enkripciju:";
                    lblOpcionalnoLozinka.Text = "(Opcionalno polje)";
                }
                else
                {
                    label3.Enabled = false;
                    labelDuljinaZnakova.Enabled = false;
                    trackBarDuljinaLozinke.Enabled = false;

                    lblUpisiteLozinku.Text = "Upišite željenu lozinku:";
                    lblOpcionalnoLozinka.Text = "(Obavezno polje)";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Private methods
        private bool ValidirajUnos()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNaziv.Text))
                {
                    MessageBox.Show("Naziv je obavezno polje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!checkBoxEnkriptiraj.Checked)
                {
                    if (string.IsNullOrWhiteSpace(txtLozinka.Text))
                    {
                        MessageBox.Show("Lozinka je obavezno polje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
