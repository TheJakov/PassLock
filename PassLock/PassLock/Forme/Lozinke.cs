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

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM podaci",conn);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "Info");
            dataGridView1.DataSource = ds.Tables[0];

            conn.Clone();
        }
    }
}
