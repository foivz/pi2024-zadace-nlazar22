﻿namespace CityLink
{
    partial class FrmAutobusneLinijeZaposlenik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutobusneLinijeZaposlenik));
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodajAutobusnuLiniju = new System.Windows.Forms.Button();
            this.btnObrisiAutobusnuLiniju = new System.Windows.Forms.Button();
            this.btnAzurirajAutobusnuLiniju = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.autobusneLinijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI2324_nlazar22_DBDataSet = new CityLink.PI2324_nlazar22_DBDataSet();
            this.autobusneLinijeTableAdapter = new CityLink.PI2324_nlazar22_DBDataSetTableAdapters.AutobusneLinijeTableAdapter();
            this.dgvPrikazZaposlenik = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.lblSearch2 = new System.Windows.Forms.Label();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.autobusneLinijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nlazar22_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazZaposlenik)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(342, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "CityLink";
            // 
            // btnDodajAutobusnuLiniju
            // 
            this.btnDodajAutobusnuLiniju.Location = new System.Drawing.Point(145, 349);
            this.btnDodajAutobusnuLiniju.Name = "btnDodajAutobusnuLiniju";
            this.btnDodajAutobusnuLiniju.Size = new System.Drawing.Size(120, 35);
            this.btnDodajAutobusnuLiniju.TabIndex = 6;
            this.btnDodajAutobusnuLiniju.Text = "Dodaj autobusnu liniju";
            this.btnDodajAutobusnuLiniju.UseVisualStyleBackColor = true;
            this.btnDodajAutobusnuLiniju.Click += new System.EventHandler(this.btnDodajAutobusnuLiniju_Click);
            // 
            // btnObrisiAutobusnuLiniju
            // 
            this.btnObrisiAutobusnuLiniju.Location = new System.Drawing.Point(347, 349);
            this.btnObrisiAutobusnuLiniju.Name = "btnObrisiAutobusnuLiniju";
            this.btnObrisiAutobusnuLiniju.Size = new System.Drawing.Size(121, 35);
            this.btnObrisiAutobusnuLiniju.TabIndex = 7;
            this.btnObrisiAutobusnuLiniju.Text = "Obriši autobusnu liniju";
            this.btnObrisiAutobusnuLiniju.UseVisualStyleBackColor = true;
            this.btnObrisiAutobusnuLiniju.Click += new System.EventHandler(this.btnObrisiAutobusnuLiniju_Click);
            // 
            // btnAzurirajAutobusnuLiniju
            // 
            this.btnAzurirajAutobusnuLiniju.Location = new System.Drawing.Point(540, 349);
            this.btnAzurirajAutobusnuLiniju.Name = "btnAzurirajAutobusnuLiniju";
            this.btnAzurirajAutobusnuLiniju.Size = new System.Drawing.Size(126, 35);
            this.btnAzurirajAutobusnuLiniju.TabIndex = 8;
            this.btnAzurirajAutobusnuLiniju.Text = "Ažuriraj autobusnu liniju";
            this.btnAzurirajAutobusnuLiniju.UseVisualStyleBackColor = true;
            this.btnAzurirajAutobusnuLiniju.Click += new System.EventHandler(this.btnAzurirajAutobusnuLiniju_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(357, 394);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(102, 35);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Odjava";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(102, 68);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 20);
            this.txtSearch.TabIndex = 10;
//            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 71);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(81, 13);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Mjesto polaska:";
 //           this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(590, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Traži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // autobusneLinijeBindingSource
            // 
            this.autobusneLinijeBindingSource.DataMember = "AutobusneLinije";
            this.autobusneLinijeBindingSource.DataSource = this.pI2324_nlazar22_DBDataSet;
            // 
            // pI2324_nlazar22_DBDataSet
            // 
            this.pI2324_nlazar22_DBDataSet.DataSetName = "PI2324_nlazar22_DBDataSet";
            this.pI2324_nlazar22_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autobusneLinijeTableAdapter
            // 
            this.autobusneLinijeTableAdapter.ClearBeforeFill = true;
            // 
            // dgvPrikazZaposlenik
            // 
            this.dgvPrikazZaposlenik.AllowUserToAddRows = false;
            this.dgvPrikazZaposlenik.AllowUserToDeleteRows = false;
            this.dgvPrikazZaposlenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazZaposlenik.Location = new System.Drawing.Point(78, 103);
            this.dgvPrikazZaposlenik.Name = "dgvPrikazZaposlenik";
            this.dgvPrikazZaposlenik.ReadOnly = true;
            this.dgvPrikazZaposlenik.Size = new System.Drawing.Size(643, 234);
            this.dgvPrikazZaposlenik.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 56);
            this.panel1.TabIndex = 18;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(694, 63);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(93, 32);
            this.btnPrikazi.TabIndex = 19;
            this.btnPrikazi.Text = "Prikaži sve linije";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // lblSearch2
            // 
            this.lblSearch2.AutoSize = true;
            this.lblSearch2.Location = new System.Drawing.Point(305, 72);
            this.lblSearch2.Name = "lblSearch2";
            this.lblSearch2.Size = new System.Drawing.Size(81, 13);
            this.lblSearch2.TabIndex = 21;
            this.lblSearch2.Text = "Mjesto dolaska:";
 //           this.lblSearch2.Click += new System.EventHandler(this.lblSearch2_Click);
            // 
            // txtSearch2
            // 
            this.txtSearch2.Location = new System.Drawing.Point(391, 69);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(180, 20);
            this.txtSearch2.TabIndex = 20;
            // 
            // FrmAutobusneLinijeZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSearch2);
            this.Controls.Add(this.txtSearch2);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPrikazZaposlenik);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAzurirajAutobusnuLiniju);
            this.Controls.Add(this.btnObrisiAutobusnuLiniju);
            this.Controls.Add(this.btnDodajAutobusnuLiniju);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAutobusneLinijeZaposlenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autobusne linije";
            this.Load += new System.EventHandler(this.FrmAutobusneLinijeZaposlenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autobusneLinijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nlazar22_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazZaposlenik)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajAutobusnuLiniju;
        private System.Windows.Forms.Button btnObrisiAutobusnuLiniju;
        private System.Windows.Forms.Button btnAzurirajAutobusnuLiniju;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private PI2324_nlazar22_DBDataSet pI2324_nlazar22_DBDataSet;
        private System.Windows.Forms.BindingSource autobusneLinijeBindingSource;
        private PI2324_nlazar22_DBDataSetTableAdapters.AutobusneLinijeTableAdapter autobusneLinijeTableAdapter;
        private System.Windows.Forms.DataGridView dgvPrikazZaposlenik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label lblSearch2;
        private System.Windows.Forms.TextBox txtSearch2;
    }
}