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
                saveFileDialog.Filter = "SQLite file|*.sqlite";
                saveFileDialog.Title = "Save an SQLite File";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    SQLiteConnection.CreateFile(saveFileDialog.FileName);

                    this.Text = Path.GetFullPath(saveFileDialog.FileName).ToString();

                    SQLiteConnection konekcija = new SQLiteConnection("Data Source=" + Path.GetFullPath(saveFileDialog.FileName).ToString() + ";Version=3");
                    konekcija.SetPassword(txtLozinka1.Text);
                    konekcija.Open();

                    string sql = "CREATE TABLE podaci (id INTEGER PRIMARY KEY UNIQUE NOT NULL, naziv TEXT NOT NULL, lozinka TEXT NOT NULL)";

                    SQLiteCommand command = new SQLiteCommand(sql, konekcija);
                    command.ExecuteNonQuery();
                    konekcija.Close();

                    Lozinke formaLozinke = new Lozinke();
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
