﻿using CityLink.Klase;
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
        private Zaposlenik zaposlenik = new Zaposlenik();
        private Korisnik korisnik = new Korisnik();

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
                if (txtUsername.Text == zaposlenik.Username && txtPassword.Text == zaposlenik.Password)
                {
                    MessageBox.Show("Uspješno ste se prijavili!", "Prijava",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmAutobusneLinijeZaposlenik frmAutobusneLinijeZaposlenik = new FrmAutobusneLinijeZaposlenik();
                    Hide();
                    frmAutobusneLinijeZaposlenik.ShowDialog();
                    Close();
                }
                else if (txtUsername.Text == korisnik.Username && txtPassword.Text == korisnik.Password)
                {
                    MessageBox.Show("Uspješno ste se prijavili!", "Prijava",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmAutobusneLinijeKorisnik frmAutobusneLinijeKorisnik = new FrmAutobusneLinijeKorisnik();
                    Hide();
                    frmAutobusneLinijeKorisnik.ShowDialog();
                    Close();
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
