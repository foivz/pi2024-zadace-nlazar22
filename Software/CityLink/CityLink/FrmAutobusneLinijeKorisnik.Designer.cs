namespace CityLink
{
    partial class FrmAutobusneLinijeKorisnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutobusneLinijeKorisnik));
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pI2324_nlazar22_DBDataSet = new CityLink.PI2324_nlazar22_DBDataSet();
            this.pI2324nlazar22DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autobusneLinijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autobusneLinijeTableAdapter = new CityLink.PI2324_nlazar22_DBDataSetTableAdapters.AutobusneLinijeTableAdapter();
            this.dgvPrikazKorisnik = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearch2 = new System.Windows.Forms.Label();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nlazar22_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324nlazar22DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusneLinijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazKorisnik)).BeginInit();
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
            this.label3.TabIndex = 6;
            this.label3.Text = "CityLink";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(358, 396);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(102, 35);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Odjava";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pI2324_nlazar22_DBDataSet
            // 
            this.pI2324_nlazar22_DBDataSet.DataSetName = "PI2324_nlazar22_DBDataSet";
            this.pI2324_nlazar22_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pI2324nlazar22DBDataSetBindingSource
            // 
            this.pI2324nlazar22DBDataSetBindingSource.DataSource = this.pI2324_nlazar22_DBDataSet;
            this.pI2324nlazar22DBDataSetBindingSource.Position = 0;
            // 
            // autobusneLinijeBindingSource
            // 
            this.autobusneLinijeBindingSource.DataMember = "AutobusneLinije";
            this.autobusneLinijeBindingSource.DataSource = this.pI2324nlazar22DBDataSetBindingSource;
            // 
            // autobusneLinijeTableAdapter
            // 
            this.autobusneLinijeTableAdapter.ClearBeforeFill = true;
            // 
            // dgvPrikazKorisnik
            // 
            this.dgvPrikazKorisnik.AllowUserToAddRows = false;
            this.dgvPrikazKorisnik.AllowUserToDeleteRows = false;
            this.dgvPrikazKorisnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazKorisnik.Location = new System.Drawing.Point(75, 113);
            this.dgvPrikazKorisnik.Name = "dgvPrikazKorisnik";
            this.dgvPrikazKorisnik.ReadOnly = true;
            this.dgvPrikazKorisnik.Size = new System.Drawing.Size(644, 265);
            this.dgvPrikazKorisnik.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 56);
            this.panel1.TabIndex = 17;
            // 
            // lblSearch2
            // 
            this.lblSearch2.AutoSize = true;
            this.lblSearch2.Location = new System.Drawing.Point(303, 77);
            this.lblSearch2.Name = "lblSearch2";
            this.lblSearch2.Size = new System.Drawing.Size(81, 13);
            this.lblSearch2.TabIndex = 27;
            this.lblSearch2.Text = "Mjesto dolaska:";
            // 
            // txtSearch2
            // 
            this.txtSearch2.Location = new System.Drawing.Point(389, 74);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(180, 20);
            this.txtSearch2.TabIndex = 26;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(692, 68);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(93, 32);
            this.btnPrikazi.TabIndex = 25;
            this.btnPrikazi.Text = "Prikaži sve linije";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(588, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 32);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Traži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(13, 76);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(81, 13);
            this.lblSearch.TabIndex = 23;
            this.lblSearch.Text = "Mjesto polaska:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(100, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 20);
            this.txtSearch.TabIndex = 22;
            // 
            // FrmAutobusneLinijeKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSearch2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch2);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvPrikazKorisnik);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAutobusneLinijeKorisnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autobusne linije";
            this.Load += new System.EventHandler(this.FrmAutobusneLinijeKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nlazar22_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324nlazar22DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusneLinijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazKorisnik)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.BindingSource pI2324nlazar22DBDataSetBindingSource;
        private PI2324_nlazar22_DBDataSet pI2324_nlazar22_DBDataSet;
        private System.Windows.Forms.BindingSource autobusneLinijeBindingSource;
        private PI2324_nlazar22_DBDataSetTableAdapters.AutobusneLinijeTableAdapter autobusneLinijeTableAdapter;
        private System.Windows.Forms.DataGridView dgvPrikazKorisnik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearch2;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}