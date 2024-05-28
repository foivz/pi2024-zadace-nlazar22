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
    public partial class FrmAutobusneLinijeZaposlenik : Form
    {
        public FrmAutobusneLinijeZaposlenik()
        {
            InitializeComponent();
        }

        private void btnDodajAutobusnuLiniju_Click(object sender, EventArgs e)
        {
            FrmDodavanjeAutobusneLinije frmDodavanjeAutobusneLinije = new FrmDodavanjeAutobusneLinije();
            frmDodavanjeAutobusneLinije.ShowDialog();
        }

        private void btnObrisiAutobusnuLiniju_Click(object sender, EventArgs e)
        {
            FrmBrisanjeAutobusneLinije frmBrisanjeAutobusneLinije = new FrmBrisanjeAutobusneLinije();
            frmBrisanjeAutobusneLinije.ShowDialog();
        }

        private void btnAzurirajAutobusnuLiniju_Click(object sender, EventArgs e)
        {
            FrmAzuriranjeAutobusneLinije frmAzuriranjeAutobusneLinije = new FrmAzuriranjeAutobusneLinije();
            frmAzuriranjeAutobusneLinije.ShowDialog();
        }
    }
}
