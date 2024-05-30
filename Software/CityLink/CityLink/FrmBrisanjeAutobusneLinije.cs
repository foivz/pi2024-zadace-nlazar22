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

namespace CityLink
{
    public partial class FrmBrisanjeAutobusneLinije : Form
    {
        private FrmAutobusneLinijeZaposlenik _frmAutobusneLinijeZaposlenik;

        public FrmBrisanjeAutobusneLinije()
        {
        }

        public FrmBrisanjeAutobusneLinije(FrmAutobusneLinijeZaposlenik frmAutobusneLinijeZaposlenik)
        {
            InitializeComponent();
            _frmAutobusneLinijeZaposlenik = frmAutobusneLinijeZaposlenik;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLinijaId.Text, out int linijaId))
            {
                MessageBox.Show("Unesite valjanu numeričku vrijednost za ID linije.", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!AutobusneLinijeRepozitorij.PostojiAutobusnaLinijaSaId(linijaId))
            {
                MessageBox.Show("Autobusna linija s navedenim ID-om ne postoji.", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AutobusneLinijeRepozitorij.ObrisiAutobusnuLiniju(linijaId);

            _frmAutobusneLinijeZaposlenik.ShowAutobusneLinije();
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
