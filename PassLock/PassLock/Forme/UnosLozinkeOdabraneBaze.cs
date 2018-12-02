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

namespace PassLock.Forme
{
    public partial class UnosLozinkeOdabraneBaze : Form
    {
        private string putanja;
        public UnosLozinkeOdabraneBaze(string putanja)
        {
            InitializeComponent();
            this.putanja = putanja;
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            string lozinka = txtLozinka.Text;
            if(lozinka.Length!=0)
            {
                string dataSource = @"Data Source="+putanja+";Version=3;Page Size=4096;Password="+lozinka+";";
                SQLiteConnection conn = new SQLiteConnection(dataSource);
                conn.Open();

                try
                {
                    //pokusaj pristupa podacima
                    string sql = "SELECT * FROM podaci";
                    SQLiteCommand command = new SQLiteCommand(sql, conn);
                    command.ExecuteNonQuery();                    
                    conn.Close();

                    Lozinke novaForma = new Lozinke(lozinka,putanja);
                    this.Hide();
                    novaForma.ShowDialog();
                    this.Close();
                }
                catch(SQLiteException ex)
                {
                    MessageBox.Show("Krivu lozinku ste upisali!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLozinka.Clear();
                }                
            }
            else
            {
                MessageBox.Show("Morate lozinku upisati!","Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLozinka.Clear();
            }
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForma = new Form1();
            this.Hide();
            pocetnaForma.ShowDialog();
            this.Close();
        }
    }
}
