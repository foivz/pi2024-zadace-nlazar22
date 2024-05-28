using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CityLink
{
    public partial class FrmLogin : Form
    {
        string username1 = "zaposlenik";
        string username2 = "korisnik";
        string lozinka1 = "test1";
        string lozinka2 = "test2";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Unesite korisničko ime!", "Pogreška",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Unesite lozinku!", "Pogreška",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool provjeraPrijave = false;

                if (txtUsername.Text == username1 && txtPassword.Text == lozinka1)
                {
                    provjeraPrijave = true;
                }
                else if (txtUsername.Text == username2 && txtPassword.Text == lozinka2)
                {
                    provjeraPrijave = true;
                }

                if (provjeraPrijave)
                {
                    MessageBox.Show("Uspješno ste se prijavili!", "Prijavljeni ste",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Netočni podaci!", "Pogreška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
