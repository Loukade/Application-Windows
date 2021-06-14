namespace Jenvrain_Boutique
{
    partial class FrmASMProduits
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
            this.dgvASMProduit = new System.Windows.Forms.DataGridView();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.BtnPrecedant = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.txtBoxIDProduit = new System.Windows.Forms.TextBox();
            this.TxboxLibelleProduit = new System.Windows.Forms.TextBox();
            this.TxtBoxPrxHT = new System.Windows.Forms.TextBox();
            this.lblIdProduit = new System.Windows.Forms.Label();
            this.lblLabelleProduit = new System.Windows.Forms.Label();
            this.lblPrxHT = new System.Windows.Forms.Label();
            this.cBoxCategorie = new System.Windows.Forms.ComboBox();
            this.cBoxFournisseur = new System.Windows.Forms.ComboBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblFournisseur = new System.Windows.Forms.Label();
            this.TxtBoxQteStock = new System.Windows.Forms.TextBox();
            this.lblQteStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASMProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvASMProduit
            // 
            this.dgvASMProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvASMProduit.Location = new System.Drawing.Point(294, 12);
            this.dgvASMProduit.Name = "dgvASMProduit";
            this.dgvASMProduit.Size = new System.Drawing.Size(481, 281);
            this.dgvASMProduit.TabIndex = 1;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(303, 402);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(165, 36);
            this.btnFermer.TabIndex = 21;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click_1);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(12, 348);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(43, 36);
            this.btnPremier.TabIndex = 22;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click_1);
            // 
            // BtnPrecedant
            // 
            this.BtnPrecedant.Location = new System.Drawing.Point(72, 348);
            this.BtnPrecedant.Name = "BtnPrecedant";
            this.BtnPrecedant.Size = new System.Drawing.Size(43, 36);
            this.BtnPrecedant.TabIndex = 23;
            this.BtnPrecedant.Text = "<";
            this.BtnPrecedant.UseVisualStyleBackColor = true;
            this.BtnPrecedant.Click += new System.EventHandler(this.BtnPrecedant_Click_1);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(147, 348);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(43, 36);
            this.btnSuivant.TabIndex = 24;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(206, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 36);
            this.button4.TabIndex = 25;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(489, 348);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(43, 36);
            this.btnAjout.TabIndex = 26;
            this.btnAjout.Text = "+";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(565, 348);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(61, 36);
            this.btnSuppr.TabIndex = 27;
            this.btnSuppr.Text = "Suprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(656, 348);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(43, 36);
            this.btnModif.TabIndex = 28;
            this.btnModif.Text = "Modif";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click_1);
            // 
            // txtBoxIDProduit
            // 
            this.txtBoxIDProduit.Location = new System.Drawing.Point(93, 27);
            this.txtBoxIDProduit.Name = "txtBoxIDProduit";
            this.txtBoxIDProduit.Size = new System.Drawing.Size(136, 20);
            this.txtBoxIDProduit.TabIndex = 29;
            // 
            // TxboxLibelleProduit
            // 
            this.TxboxLibelleProduit.Location = new System.Drawing.Point(93, 80);
            this.TxboxLibelleProduit.Name = "TxboxLibelleProduit";
            this.TxboxLibelleProduit.Size = new System.Drawing.Size(136, 20);
            this.TxboxLibelleProduit.TabIndex = 30;
            // 
            // TxtBoxPrxHT
            // 
            this.TxtBoxPrxHT.Location = new System.Drawing.Point(93, 124);
            this.TxtBoxPrxHT.Name = "TxtBoxPrxHT";
            this.TxtBoxPrxHT.Size = new System.Drawing.Size(136, 20);
            this.TxtBoxPrxHT.TabIndex = 31;
            // 
            // lblIdProduit
            // 
            this.lblIdProduit.AutoSize = true;
            this.lblIdProduit.Location = new System.Drawing.Point(0, 30);
            this.lblIdProduit.Name = "lblIdProduit";
            this.lblIdProduit.Size = new System.Drawing.Size(24, 13);
            this.lblIdProduit.TabIndex = 32;
            this.lblIdProduit.Text = "ID :";
            // 
            // lblLabelleProduit
            // 
            this.lblLabelleProduit.AutoSize = true;
            this.lblLabelleProduit.Location = new System.Drawing.Point(0, 83);
            this.lblLabelleProduit.Name = "lblLabelleProduit";
            this.lblLabelleProduit.Size = new System.Drawing.Size(43, 13);
            this.lblLabelleProduit.TabIndex = 33;
            this.lblLabelleProduit.Text = "Libelle :";
            // 
            // lblPrxHT
            // 
            this.lblPrxHT.AutoSize = true;
            this.lblPrxHT.Location = new System.Drawing.Point(-2, 127);
            this.lblPrxHT.Name = "lblPrxHT";
            this.lblPrxHT.Size = new System.Drawing.Size(45, 13);
            this.lblPrxHT.TabIndex = 34;
            this.lblPrxHT.Text = "PrixHT :";
            // 
            // cBoxCategorie
            // 
            this.cBoxCategorie.FormattingEnabled = true;
            this.cBoxCategorie.Location = new System.Drawing.Point(93, 221);
            this.cBoxCategorie.Name = "cBoxCategorie";
            this.cBoxCategorie.Size = new System.Drawing.Size(136, 21);
            this.cBoxCategorie.TabIndex = 35;
            // 
            // cBoxFournisseur
            // 
            this.cBoxFournisseur.FormattingEnabled = true;
            this.cBoxFournisseur.Location = new System.Drawing.Point(93, 272);
            this.cBoxFournisseur.Name = "cBoxFournisseur";
            this.cBoxFournisseur.Size = new System.Drawing.Size(136, 21);
            this.cBoxFournisseur.TabIndex = 36;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(-3, 224);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(58, 13);
            this.lblCategorie.TabIndex = 37;
            this.lblCategorie.Text = "Categorie :";
            // 
            // lblFournisseur
            // 
            this.lblFournisseur.AutoSize = true;
            this.lblFournisseur.Location = new System.Drawing.Point(0, 275);
            this.lblFournisseur.Name = "lblFournisseur";
            this.lblFournisseur.Size = new System.Drawing.Size(67, 13);
            this.lblFournisseur.TabIndex = 38;
            this.lblFournisseur.Text = "Fournisseur :";
            // 
            // TxtBoxQteStock
            // 
            this.TxtBoxQteStock.Location = new System.Drawing.Point(93, 174);
            this.TxtBoxQteStock.Name = "TxtBoxQteStock";
            this.TxtBoxQteStock.Size = new System.Drawing.Size(136, 20);
            this.TxtBoxQteStock.TabIndex = 39;
            // 
            // lblQteStock
            // 
            this.lblQteStock.AutoSize = true;
            this.lblQteStock.Location = new System.Drawing.Point(0, 177);
            this.lblQteStock.Name = "lblQteStock";
            this.lblQteStock.Size = new System.Drawing.Size(58, 13);
            this.lblQteStock.TabIndex = 40;
            this.lblQteStock.Text = "QteStock :";
            // 
            // FrmASMProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQteStock);
            this.Controls.Add(this.TxtBoxQteStock);
            this.Controls.Add(this.lblFournisseur);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.cBoxFournisseur);
            this.Controls.Add(this.cBoxCategorie);
            this.Controls.Add(this.lblPrxHT);
            this.Controls.Add(this.lblLabelleProduit);
            this.Controls.Add(this.lblIdProduit);
            this.Controls.Add(this.TxtBoxPrxHT);
            this.Controls.Add(this.TxboxLibelleProduit);
            this.Controls.Add(this.txtBoxIDProduit);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.BtnPrecedant);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.dgvASMProduit);
            this.Name = "FrmASMProduits";
            this.Text = "FrmASMProduits";
            this.Load += new System.EventHandler(this.FrmASMProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvASMProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvASMProduit;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button BtnPrecedant;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.TextBox txtBoxIDProduit;
        private System.Windows.Forms.TextBox TxboxLibelleProduit;
        private System.Windows.Forms.TextBox TxtBoxPrxHT;
        private System.Windows.Forms.Label lblIdProduit;
        private System.Windows.Forms.Label lblLabelleProduit;
        private System.Windows.Forms.Label lblPrxHT;
        private System.Windows.Forms.ComboBox cBoxCategorie;
        private System.Windows.Forms.ComboBox cBoxFournisseur;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblFournisseur;
        private System.Windows.Forms.TextBox TxtBoxQteStock;
        private System.Windows.Forms.Label lblQteStock;
    }
}