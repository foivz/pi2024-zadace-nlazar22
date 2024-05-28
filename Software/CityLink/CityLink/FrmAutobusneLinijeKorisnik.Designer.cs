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
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pI2324_nlazar22_DBDataSet = new CityLink.PI2324_nlazar22_DBDataSet();
            this.pI2324nlazar22DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autobusneLinijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autobusneLinijeTableAdapter = new CityLink.PI2324_nlazar22_DBDataSetTableAdapters.AutobusneLinijeTableAdapter();
            this.dgvPrikazKorisnik = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nlazar22_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324nlazar22DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusneLinijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazKorisnik)).BeginInit();
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(402, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 32);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Traži";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(67, 73);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(121, 13);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Pretraži autobusnu liniju:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(194, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 20);
            this.txtSearch.TabIndex = 13;
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
            this.dgvPrikazKorisnik.Location = new System.Drawing.Point(73, 113);
            this.dgvPrikazKorisnik.Name = "dgvPrikazKorisnik";
            this.dgvPrikazKorisnik.ReadOnly = true;
            this.dgvPrikazKorisnik.Size = new System.Drawing.Size(644, 265);
            this.dgvPrikazKorisnik.TabIndex = 16;
            // 
            // FrmAutobusneLinijeKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPrikazKorisnik);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label3);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.BindingSource pI2324nlazar22DBDataSetBindingSource;
        private PI2324_nlazar22_DBDataSet pI2324_nlazar22_DBDataSet;
        private System.Windows.Forms.BindingSource autobusneLinijeBindingSource;
        private PI2324_nlazar22_DBDataSetTableAdapters.AutobusneLinijeTableAdapter autobusneLinijeTableAdapter;
        private System.Windows.Forms.DataGridView dgvPrikazKorisnik;
    }
}