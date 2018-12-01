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
            Forme.NovaBaza novaBaza = new Forme.NovaBaza(); 
            novaBaza.ShowDialog();
            this.Close();
        }
    }
}
