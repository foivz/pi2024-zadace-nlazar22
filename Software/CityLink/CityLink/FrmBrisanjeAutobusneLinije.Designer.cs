﻿namespace CityLink
{
    partial class FrmBrisanjeAutobusneLinije
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblLinijaID = new System.Windows.Forms.Label();
            this.txtLinijaID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(88, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "CityLink";
            // 
            // lblLinijaID
            // 
            this.lblLinijaID.AutoSize = true;
            this.lblLinijaID.Location = new System.Drawing.Point(93, 94);
            this.lblLinijaID.Name = "lblLinijaID";
            this.lblLinijaID.Size = new System.Drawing.Size(48, 13);
            this.lblLinijaID.TabIndex = 6;
            this.lblLinijaID.Text = "Linija ID:";
            // 
            // txtLinijaID
            // 
            this.txtLinijaID.Location = new System.Drawing.Point(154, 91);
            this.txtLinijaID.Name = "txtLinijaID";
            this.txtLinijaID.Size = new System.Drawing.Size(47, 20);
            this.txtLinijaID.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(96, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // FrmBrisanjeAutobusneLinije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 245);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtLinijaID);
            this.Controls.Add(this.lblLinijaID);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBrisanjeAutobusneLinije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brisanje autobusne linije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLinijaID;
        private System.Windows.Forms.TextBox txtLinijaID;
        private System.Windows.Forms.Button btnDelete;
    }
}