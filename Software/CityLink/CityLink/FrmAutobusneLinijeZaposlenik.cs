using CityLink.Klase;
using CityLink.Repozitoriji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

namespace CityLink
{
    public partial class FrmAutobusneLinijeZaposlenik : Form
    {
        public FrmAutobusneLinijeZaposlenik()
        {
            InitializeComponent();
        }

        private void btnDodajAutobusnuLiniju_Click(object sender, EventArgs e)
        {
            FrmDodavanjeAutobusneLinije frmDodavanjeAutobusneLinije = new FrmDodavanjeAutobusneLinije(this);
            frmDodavanjeAutobusneLinije.ShowDialog();
        }

        private void btnObrisiAutobusnuLiniju_Click(object sender, EventArgs e)
        {
            FrmBrisanjeAutobusneLinije frmBrisanjeAutobusneLinije = new FrmBrisanjeAutobusneLinije(this);
            frmBrisanjeAutobusneLinije.ShowDialog();
        }

        private void btnAzurirajAutobusnuLiniju_Click(object sender, EventArgs e)
        {
            FrmAzuriranjeAutobusneLinije frmAzuriranjeAutobusneLinije = new FrmAzuriranjeAutobusneLinije();
            frmAzuriranjeAutobusneLinije.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste se odjavili!", "Odjava", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            Close();
        }

        public void ShowAutobusneLinije()
        {
            List<AutobusnaLinija> autobusneLinije = AutobusneLinijeRepozitorij.GetAutobusneLinije();
            dgvPrikazZaposlenik.DataSource = autobusneLinije;
            dgvPrikazZaposlenik.Columns["LinijaId"].DisplayIndex = 0;
            dgvPrikazZaposlenik.Columns["MjestoPolaska"].DisplayIndex = 1;
            dgvPrikazZaposlenik.Columns["MjestoDolaska"].DisplayIndex = 2;
            dgvPrikazZaposlenik.Columns["VrijemePolaska"].DisplayIndex = 3;
            dgvPrikazZaposlenik.Columns["VrijemeDolaska"].DisplayIndex = 4;
            dgvPrikazZaposlenik.Columns["BrojStanica"].DisplayIndex = 5;
        }

        private void FrmAutobusneLinijeZaposlenik_Load(object sender, EventArgs e)
        {
            ShowAutobusneLinije();
        }
    }
}
