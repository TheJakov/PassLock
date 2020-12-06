using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassLock.Klase;

namespace PassLock.Forme
{
    public partial class NovaBaza : Form
    {
        public NovaBaza()
        {
            InitializeComponent();
        }
        private void flatButtonPotvrdi_Click(object sender, EventArgs e)
        {
            if (txtLozinka1.Text == txtLozinka2.Text && txtLozinka1.Text.Length>=8)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "File|*.db";
                saveFileDialog.Title = "Save an SQLite File";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    SQLiteConnection.CreateFile(saveFileDialog.FileName);

                    Sesija.Putanja = Path.GetFullPath(saveFileDialog.FileName).ToString();
                    Sesija.Lozinka = txtLozinka1.Text;

                    SQLiteConnection konekcija = new SQLiteConnection("Data Source=" + Sesija.Putanja + ";Version=3");
                    konekcija.SetPassword(txtLozinka1.Text);
                    konekcija.Open();

                    string sql = "CREATE TABLE podaci (id INTEGER PRIMARY KEY UNIQUE NOT NULL, naziv TEXT NOT NULL, lozinka TEXT NOT NULL)";

                    SQLiteCommand command = new SQLiteCommand(sql, konekcija);
                    command.ExecuteNonQuery();
                    konekcija.Close();

                    Lozinke formaLozinke = new Lozinke();
                    this.Hide();
                    formaLozinke.ShowDialog();
                    this.Close();
                }
            }
            else if(txtLozinka1.Text == txtLozinka2.Text && txtLozinka1.Text.Length < 8)
            {
                MessageBox.Show("Lozinka vam je slaba ! \n \n Treba sadržavati minimalno 8 znakova !", "Pozor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lozinke se ne podudaraju !", "Upozorenje !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLozinka1.Clear();
                txtLozinka2.Clear();
            }
        }
        private void flatButtonOdustani_Click(object sender, EventArgs e)
        {
            PassLockEkran pocetnaForma = new PassLockEkran();
            this.Hide();
            pocetnaForma.ShowDialog();
            this.Close();
        }
    }
}
