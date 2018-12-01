using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data.SqlClient;

namespace PassLock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "PassLock";
        }

        private void buttonNovaBaza_Click(object sender, EventArgs e)
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
                konekcija.Open();

                string sql = "CREATE TABLE podaci (id INTEGER PRIMARY KEY UNIQUE NOT NULL, naziv TEXT NOT NULL, lozinka TEXT NOT NULL)";

                SQLiteCommand command = new SQLiteCommand(sql, konekcija);
                command.ExecuteNonQuery();
                konekcija.Close();
            }
        }
    }
}
