using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLink
{
    public partial class FrmAutobusneLinijeKorisnik : Form
    {
        public FrmAutobusneLinijeKorisnik()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste se odjavili!", "Odjava", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            Close();
            
        }
    }
}
