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

namespace CityLink
{
    public partial class FrmDodavanjeAutobusneLinije : Form
    {
        public FrmDodavanjeAutobusneLinije()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajAutobusnuLiniju();
            Close();
        }

        private void DodajAutobusnuLiniju()
        {
            int linijaId = int.Parse(txtLinijaId.Text);
            string mjestoPolaska = txtMjestoPolaska.Text;
            string mjestoDolaska = txtMjestoDolaska.Text;
            string vrijemePolaska = txtVrijemePolaska.Text;
            string vrijemeDolaska = txtVrijemeDolaska.Text;
            int brojStanica = int.Parse(txtBrojStanica.Text);

            AutobusnaLinija novaLinija = new AutobusnaLinija(linijaId, mjestoPolaska, mjestoDolaska, vrijemePolaska, vrijemeDolaska, brojStanica);
            AutobusneLinijeRepozitorij.DodajAutobusnuLiniju(novaLinija);
        }
    }
}
