namespace Jenvrain_Boutique
{
    partial class FrmListeCommande
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
            this.dgvListeCommande = new System.Windows.Forms.DataGridView();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnSupCommande = new System.Windows.Forms.Button();
            this.btnModCommande = new System.Windows.Forms.Button();
            this.btnAjCommande = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.cBoxClient = new System.Windows.Forms.ComboBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.txtBoxNum = new System.Windows.Forms.TextBox();
            this.grpListeComande = new System.Windows.Forms.GroupBox();
            this.grpBut = new System.Windows.Forms.GroupBox();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedant = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCommande)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.grpListeComande.SuspendLayout();
            this.grpBut.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListeCommande
            // 
            this.dgvListeCommande.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvListeCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeCommande.Location = new System.Drawing.Point(66, 48);
            this.dgvListeCommande.Name = "dgvListeCommande";
            this.dgvListeCommande.RowHeadersWidth = 45;
            this.dgvListeCommande.Size = new System.Drawing.Size(480, 179);
            this.dgvListeCommande.TabIndex = 0;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnSupCommande);
            this.grpInfo.Controls.Add(this.btnModCommande);
            this.grpInfo.Controls.Add(this.btnAjCommande);
            this.grpInfo.Controls.Add(this.lblClient);
            this.grpInfo.Controls.Add(this.lblDate);
            this.grpInfo.Controls.Add(this.lblNum);
            this.grpInfo.Controls.Add(this.cBoxClient);
            this.grpInfo.Controls.Add(this.txtBoxDate);
            this.grpInfo.Controls.Add(this.txtBoxNum);
            this.grpInfo.Location = new System.Drawing.Point(67, 25);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(614, 176);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Information de commande";
            // 
            // btnSupCommande
            // 
            this.btnSupCommande.Location = new System.Drawing.Point(414, 122);
            this.btnSupCommande.Name = "btnSupCommande";
            this.btnSupCommande.Size = new System.Drawing.Size(158, 23);
            this.btnSupCommande.TabIndex = 8;
            this.btnSupCommande.Text = "Supprimer une Commande";
            this.btnSupCommande.UseVisualStyleBackColor = true;
            this.btnSupCommande.Click += new System.EventHandler(this.btnSupCommande_Click);
            // 
            // btnModCommande
            // 
            this.btnModCommande.Location = new System.Drawing.Point(414, 67);
            this.btnModCommande.Name = "btnModCommande";
            this.btnModCommande.Size = new System.Drawing.Size(158, 42);
            this.btnModCommande.TabIndex = 7;
            this.btnModCommande.Text = "Consulter une Commande";
            this.btnModCommande.UseVisualStyleBackColor = true;
            this.btnModCommande.Click += new System.EventHandler(this.btnModCommande_Click);
            // 
            // btnAjCommande
            // 
            this.btnAjCommande.Location = new System.Drawing.Point(414, 33);
            this.btnAjCommande.Name = "btnAjCommande";
            this.btnAjCommande.Size = new System.Drawing.Size(158, 23);
            this.btnAjCommande.TabIndex = 6;
            this.btnAjCommande.Text = "Ajouter une Commande";
            this.btnAjCommande.UseVisualStyleBackColor = true;
            this.btnAjCommande.Click += new System.EventHandler(this.btnAjCommande_Click_1);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(17, 132);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(39, 13);
            this.lblClient.TabIndex = 5;
            this.lblClient.Text = "Client :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(17, 79);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date :";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(17, 41);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(50, 13);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Numéro :";
            // 
            // cBoxClient
            // 
            this.cBoxClient.FormattingEnabled = true;
            this.cBoxClient.Location = new System.Drawing.Point(107, 124);
            this.cBoxClient.Name = "cBoxClient";
            this.cBoxClient.Size = new System.Drawing.Size(174, 21);
            this.cBoxClient.TabIndex = 2;
            this.cBoxClient.SelectedIndexChanged += new System.EventHandler(this.cBoxClient_SelectedIndexChanged);
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(107, 79);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(174, 20);
            this.txtBoxDate.TabIndex = 1;
            // 
            // txtBoxNum
            // 
            this.txtBoxNum.Location = new System.Drawing.Point(107, 35);
            this.txtBoxNum.Name = "txtBoxNum";
            this.txtBoxNum.Size = new System.Drawing.Size(174, 20);
            this.txtBoxNum.TabIndex = 0;
            // 
            // grpListeComande
            // 
            this.grpListeComande.Controls.Add(this.dgvListeCommande);
            this.grpListeComande.Location = new System.Drawing.Point(67, 335);
            this.grpListeComande.Name = "grpListeComande";
            this.grpListeComande.Size = new System.Drawing.Size(614, 250);
            this.grpListeComande.TabIndex = 2;
            this.grpListeComande.TabStop = false;
            this.grpListeComande.Text = "Récapitulatif des Commandes";
            // 
            // grpBut
            // 
            this.grpBut.Controls.Add(this.btnDernier);
            this.grpBut.Controls.Add(this.btnSuivant);
            this.grpBut.Controls.Add(this.btnPrecedant);
            this.grpBut.Controls.Add(this.btnPremier);
            this.grpBut.Location = new System.Drawing.Point(67, 227);
            this.grpBut.Name = "grpBut";
            this.grpBut.Size = new System.Drawing.Size(614, 77);
            this.grpBut.TabIndex = 2;
            this.grpBut.TabStop = false;
            this.grpBut.Text = "Rechercher une Commande";
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(523, 20);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(71, 37);
            this.btnDernier.TabIndex = 12;
            this.btnDernier.Text = ">>";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(385, 19);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(71, 37);
            this.btnSuivant.TabIndex = 11;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedant
            // 
            this.btnPrecedant.Location = new System.Drawing.Point(154, 19);
            this.btnPrecedant.Name = "btnPrecedant";
            this.btnPrecedant.Size = new System.Drawing.Size(71, 37);
            this.btnPrecedant.TabIndex = 10;
            this.btnPrecedant.Text = "<";
            this.btnPrecedant.UseVisualStyleBackColor = true;
            this.btnPrecedant.Click += new System.EventHandler(this.btnPrecedant_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(20, 19);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(71, 37);
            this.btnPremier.TabIndex = 9;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(284, 591);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(144, 37);
            this.btnFermer.TabIndex = 13;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmListeCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(741, 637);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.grpBut);
            this.Controls.Add(this.grpListeComande);
            this.Controls.Add(this.grpInfo);
            this.Name = "FrmListeCommande";
            this.Text = "Liste commande";
            this.Load += new System.EventHandler(this.FrmListeCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCommande)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpListeComande.ResumeLayout(false);
            this.grpBut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListeCommande;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.GroupBox grpBut;
        private System.Windows.Forms.GroupBox grpListeComande;
        private System.Windows.Forms.Button btnSupCommande;
        private System.Windows.Forms.Button btnModCommande;
        private System.Windows.Forms.Button btnAjCommande;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ComboBox cBoxClient;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.TextBox txtBoxNum;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedant;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnFermer;
    }
}