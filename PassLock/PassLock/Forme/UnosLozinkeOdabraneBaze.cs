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
            string lozinka= txtLozinka1.Text;
            if(lozinka.Length!=0)
            {
                //ne znam cemu sluzi page size
                string dataSource = @"Data Source="+putanja+";Version=3;Page Size=1024;Password="+lozinka+";";
                SQLiteConnection conn = new SQLiteConnection(dataSource);
                conn.Open();

                /* 
                 Ne znam kako drugacije provjeriti jel sifra dobra ili ne pa tako radim. 
                 Na conn.Open(); ne provjeri jel sifra dobra ili ne
                 */

                try
                {
                    //provjera dali se rusi ili ne hahahah
                    string sql = "SELECT * FROM podaci";
                    SQLiteCommand command = new SQLiteCommand(sql, conn);
                    command.ExecuteNonQuery();                    
                  
                    //Testni podaci za dgv
                    //Moze se izbrisat
                    string sql2 = "INSERT INTO podaci(naziv,lozinka) values('test','test')";
                    SQLiteCommand command2 = new SQLiteCommand(sql2, conn);
                    command2.ExecuteNonQuery();

                    conn.Close();

                    //prosljeđivanje putanje do datoteke i lozinke
                    Lozinke novaForma = new Lozinke(lozinka,putanja);
                    novaForma.ShowDialog();
                }
                catch(SQLiteException ex)
                {
                    MessageBox.Show("Krivu lozinku ste upisali!", "Upozorenje");
                }                
            }
            else
            {
                MessageBox.Show("Morate lozinku upisati!","Upozorenje");
            }
        }
    }
}
