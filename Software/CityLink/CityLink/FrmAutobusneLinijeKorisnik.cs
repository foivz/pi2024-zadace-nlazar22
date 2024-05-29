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

        public void ShowAutobusneLinije()
        {
            List<AutobusnaLinija> autobusneLinije = AutobusneLinijeRepozitorij.GetAutobusneLinije();
            dgvPrikazKorisnik.DataSource = autobusneLinije;
            dgvPrikazKorisnik.Columns["LinijaId"].DisplayIndex = 0;
            dgvPrikazKorisnik.Columns["MjestoPolaska"].DisplayIndex = 1;
            dgvPrikazKorisnik.Columns["MjestoDolaska"].DisplayIndex = 2;
            dgvPrikazKorisnik.Columns["VrijemePolaska"].DisplayIndex = 3;
            dgvPrikazKorisnik.Columns["VrijemeDolaska"].DisplayIndex = 4;
            dgvPrikazKorisnik.Columns["BrojStanica"].DisplayIndex = 5;
        }


        private void FrmAutobusneLinijeKorisnik_Load(object sender, EventArgs e)
        {
            ShowAutobusneLinije();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string pretrazivanje = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(pretrazivanje))
            {
                ShowAutobusneLinije();
                return;
            }

            List<AutobusnaLinija> rezultatiPretrage = AutobusneLinijeRepozitorij.PretraziAutobusneLinije(pretrazivanje);

            if (rezultatiPretrage.Count == 0)
            {
                MessageBox.Show("Nema rezultata za navedeni kriterij pretrage.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvPrikazKorisnik.DataSource = rezultatiPretrage;
            }
        }

    }
}
