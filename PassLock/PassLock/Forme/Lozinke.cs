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

namespace PassLock
{
    public partial class Lozinke : Form
    {
        private string lozinka;
        private string putanja;
        public Lozinke()
        {
            InitializeComponent();
        }
        public Lozinke(string lozinka, string putanja)
        {
            InitializeComponent();
            this.lozinka = lozinka;
            this.putanja = putanja;
        }

        private void Lozinke_Load(object sender, EventArgs e)
        {
            //testni prikaz
            string dataSource = @"Data Source=" + putanja + ";Version=3;Page Size=1024;Password=" + lozinka + ";";
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            conn.Open();

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

            conn.Close();
        }

        private void buttonOdjava_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForma = new Form1();
            this.Hide();
            pocetnaForma.ShowDialog();
            this.Close();
        }
    }
}
