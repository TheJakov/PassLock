using PassLock.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassLock.Forme
{
    public partial class PromjenaLozinkeBaze : Form
    {
        #region Members
        Konekcija mojaKonekcija = new Konekcija();
        #endregion

        #region Constructors
        public PromjenaLozinkeBaze()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void flatButtonPotvrdi_Click(object sender, EventArgs e)
        {
            if (txtLozinka1.Text == txtLozinka2.Text && txtLozinka1.Text.Length>=8)
            {
                if (MessageBox.Show("Želite li stvarno promijeniti lozinku ?", "Pozor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mojaKonekcija.OtvoriKonekciju(Sesija.Putanja, Sesija.Lozinka);
                    mojaKonekcija.PromjenaLozinke(txtLozinka1.Text.ToString());
                    mojaKonekcija.ZatvoriKonekciju();
                    MessageBox.Show("Uspješno izmijenjena lozinka !","Obavijest");
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
            this.Close();
        }
        #endregion
    }
}
