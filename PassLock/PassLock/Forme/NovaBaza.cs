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

namespace PassLock.Forme
{
    public partial class NovaBaza : Form
    {
        public NovaBaza()
        {
            InitializeComponent();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            if (txtLozinka1.Text == txtLozinka2.Text)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "File|*.db";
                saveFileDialog.Title = "Save an SQLite File";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    SQLiteConnection.CreateFile(saveFileDialog.FileName);

                    string putanja = Path.GetFullPath(saveFileDialog.FileName).ToString();

                    SQLiteConnection konekcija = new SQLiteConnection("Data Source=" + putanja + ";Version=3");
                    konekcija.SetPassword(txtLozinka1.Text);
                    konekcija.Open();

                    string sql = "CREATE TABLE podaci (id INTEGER PRIMARY KEY UNIQUE NOT NULL, naziv TEXT NOT NULL, lozinka TEXT NOT NULL)";

                    SQLiteCommand command = new SQLiteCommand(sql, konekcija);
                    command.ExecuteNonQuery();
                    konekcija.Close();

                    Lozinke formaLozinke = new Lozinke(txtLozinka1.Text,putanja);
                    this.Hide();
                    formaLozinke.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Lozinke se ne podudaraju !", "Upozorenje !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLozinka1.Clear();
                txtLozinka2.Clear();
            }
        }
    }
}
