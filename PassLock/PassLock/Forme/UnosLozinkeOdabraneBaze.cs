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
    public partial class UnosLozinkeOdabraneBaze : Form
    {
        #region Members
        Konekcija mojaKonekcija = new Konekcija();
        #endregion

        #region Constructors
        public UnosLozinkeOdabraneBaze()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void flatButtonPotvrdi_Click(object sender, EventArgs e)
        {
            Sesija.Lozinka = txtLozinka.Text;
            if (Sesija.Lozinka.Length != 0)
            {
                mojaKonekcija.OtvoriKonekciju(Sesija.Putanja, Sesija.Lozinka);
                try
                {
                    //pokusaj pristupa podacima
                    string sql = "SELECT * FROM podaci";
                    SQLiteCommand command = new SQLiteCommand(sql, mojaKonekcija.conn);
                    command.ExecuteNonQuery();
                    mojaKonekcija.conn.Close();

                    Lozinke novaForma = new Lozinke();
                    this.Hide();
                    novaForma.ShowDialog();
                    this.Close();
                }
                catch (SQLiteException)
                {
                    MessageBox.Show("Krivu lozinku ste upisali!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLozinka.Clear();
                }
            }
            else
            {
                MessageBox.Show("Morate lozinku upisati!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLozinka.Clear();
            }
        }

        private void flatButtonOdustani_Click(object sender, EventArgs e)
        {
            PassLockEkran pocetnaForma = new PassLockEkran();
            this.Hide();
            pocetnaForma.ShowDialog();
            this.Close();
        }
        #endregion
    }
}
