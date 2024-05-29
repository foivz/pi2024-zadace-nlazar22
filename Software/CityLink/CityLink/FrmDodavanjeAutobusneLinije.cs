﻿using CityLink.Klase;
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

        private FrmAutobusneLinijeZaposlenik _frmAutobusneLinijeZaposlenik;

        public FrmDodavanjeAutobusneLinije(FrmAutobusneLinijeZaposlenik frmAutobusneLinijeZaposlenik)
        {
            InitializeComponent();
            _frmAutobusneLinijeZaposlenik = frmAutobusneLinijeZaposlenik;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajAutobusnuLiniju();
        }

        private void DodajAutobusnuLiniju()
        {
            if (string.IsNullOrWhiteSpace(txtLinijaId.Text) || string.IsNullOrWhiteSpace(txtMjestoPolaska.Text) ||
                string.IsNullOrWhiteSpace(txtMjestoDolaska.Text) || string.IsNullOrWhiteSpace(txtVrijemePolaska.Text) ||
                string.IsNullOrWhiteSpace(txtVrijemeDolaska.Text) || string.IsNullOrWhiteSpace(txtBrojStanica.Text))
            {
                MessageBox.Show("Morate ispuniti sve podatke!", "Pogreška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtLinijaId.Text, out int linijaId))
            {
                MessageBox.Show("Neispravan format za LinijaId!", "Pogreška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtBrojStanica.Text, out int brojStanica))
            {
                MessageBox.Show("Neispravan format za Broj Stanica!", "Pogreška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (AutobusneLinijeRepozitorij.PostojiAutobusnaLinijaSaId(linijaId))
            {
                MessageBox.Show("Linija sa istim ID već postoji!", "Pogreška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mjestoPolaska = txtMjestoPolaska.Text;
            string mjestoDolaska = txtMjestoDolaska.Text;
            string vrijemePolaska = txtVrijemePolaska.Text;
            string vrijemeDolaska = txtVrijemeDolaska.Text;

            AutobusnaLinija novaLinija = new AutobusnaLinija(linijaId, mjestoPolaska, mjestoDolaska, vrijemePolaska, vrijemeDolaska, brojStanica);
            AutobusneLinijeRepozitorij.DodajAutobusnuLiniju(novaLinija);

            _frmAutobusneLinijeZaposlenik.ShowAutobusneLinije();

            Close();
        }
    }
}
