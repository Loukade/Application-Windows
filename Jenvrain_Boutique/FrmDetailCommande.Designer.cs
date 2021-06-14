namespace Jenvrain_Boutique
{
    partial class FrmDetailCommande
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
            this.grpBoxInfoCom = new System.Windows.Forms.GroupBox();
            this.txtBoxClient = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtBoxDateCom = new System.Windows.Forms.TextBox();
            this.txtBoxNumCom = new System.Windows.Forms.TextBox();
            this.grpBoxListProduit = new System.Windows.Forms.GroupBox();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.btnAjoutCom = new System.Windows.Forms.Button();
            this.cBoxCat = new System.Windows.Forms.ComboBox();
            this.cBoxProd = new System.Windows.Forms.ComboBox();
            this.txtBoxQuant = new System.Windows.Forms.TextBox();
            this.grpBoxRecap = new System.Windows.Forms.GroupBox();
            this.dgvRecap = new System.Windows.Forms.DataGridView();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.grpBoxInfoCom.SuspendLayout();
            this.grpBoxListProduit.SuspendLayout();
            this.grpBoxRecap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecap)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxInfoCom
            // 
            this.grpBoxInfoCom.Controls.Add(this.txtBoxClient);
            this.grpBoxInfoCom.Controls.Add(this.lblDate);
            this.grpBoxInfoCom.Controls.Add(this.lblNum);
            this.grpBoxInfoCom.Controls.Add(this.lblClient);
            this.grpBoxInfoCom.Controls.Add(this.txtBoxDateCom);
            this.grpBoxInfoCom.Controls.Add(this.txtBoxNumCom);
            this.grpBoxInfoCom.Location = new System.Drawing.Point(24, 27);
            this.grpBoxInfoCom.Name = "grpBoxInfoCom";
            this.grpBoxInfoCom.Size = new System.Drawing.Size(724, 153);
            this.grpBoxInfoCom.TabIndex = 0;
            this.grpBoxInfoCom.TabStop = false;
            this.grpBoxInfoCom.Text = "Information de Commande";
            // 
            // txtBoxClient
            // 
            this.txtBoxClient.Enabled = false;
            this.txtBoxClient.Location = new System.Drawing.Point(464, 38);
            this.txtBoxClient.Name = "txtBoxClient";
            this.txtBoxClient.Size = new System.Drawing.Size(166, 20);
            this.txtBoxClient.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(23, 93);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date :";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(23, 41);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(50, 13);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "Numéro :";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(402, 41);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(39, 13);
            this.lblClient.TabIndex = 3;
            this.lblClient.Text = "Client :";
            // 
            // txtBoxDateCom
            // 
            this.txtBoxDateCom.Enabled = false;
            this.txtBoxDateCom.Location = new System.Drawing.Point(100, 86);
            this.txtBoxDateCom.Name = "txtBoxDateCom";
            this.txtBoxDateCom.Size = new System.Drawing.Size(166, 20);
            this.txtBoxDateCom.TabIndex = 1;
            // 
            // txtBoxNumCom
            // 
            this.txtBoxNumCom.Enabled = false;
            this.txtBoxNumCom.Location = new System.Drawing.Point(100, 42);
            this.txtBoxNumCom.Name = "txtBoxNumCom";
            this.txtBoxNumCom.Size = new System.Drawing.Size(166, 20);
            this.txtBoxNumCom.TabIndex = 0;
            // 
            // grpBoxListProduit
            // 
            this.grpBoxListProduit.Controls.Add(this.lblQuant);
            this.grpBoxListProduit.Controls.Add(this.lblCat);
            this.grpBoxListProduit.Controls.Add(this.lblProd);
            this.grpBoxListProduit.Controls.Add(this.btnAjoutCom);
            this.grpBoxListProduit.Controls.Add(this.cBoxCat);
            this.grpBoxListProduit.Controls.Add(this.cBoxProd);
            this.grpBoxListProduit.Controls.Add(this.txtBoxQuant);
            this.grpBoxListProduit.Location = new System.Drawing.Point(24, 204);
            this.grpBoxListProduit.Name = "grpBoxListProduit";
            this.grpBoxListProduit.Size = new System.Drawing.Size(724, 153);
            this.grpBoxListProduit.TabIndex = 1;
            this.grpBoxListProduit.TabStop = false;
            this.grpBoxListProduit.Text = "Liste des Produits";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(23, 120);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(53, 13);
            this.lblQuant.TabIndex = 8;
            this.lblQuant.Text = "Quantité :";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(18, 29);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(58, 13);
            this.lblCat.TabIndex = 7;
            this.lblCat.Text = "Catégorie :";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(30, 74);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(46, 13);
            this.lblProd.TabIndex = 6;
            this.lblProd.Text = "Produit :";
            // 
            // btnAjoutCom
            // 
            this.btnAjoutCom.Location = new System.Drawing.Point(562, 19);
            this.btnAjoutCom.Name = "btnAjoutCom";
            this.btnAjoutCom.Size = new System.Drawing.Size(124, 114);
            this.btnAjoutCom.TabIndex = 4;
            this.btnAjoutCom.Text = "Ajouter à la Commande";
            this.btnAjoutCom.UseVisualStyleBackColor = true;
            this.btnAjoutCom.Click += new System.EventHandler(this.btnAjoutCom_Click);
            // 
            // cBoxCat
            // 
            this.cBoxCat.FormattingEnabled = true;
            this.cBoxCat.Location = new System.Drawing.Point(183, 26);
            this.cBoxCat.Name = "cBoxCat";
            this.cBoxCat.Size = new System.Drawing.Size(182, 21);
            this.cBoxCat.TabIndex = 4;
            this.cBoxCat.SelectedIndexChanged += new System.EventHandler(this.cBoxCat_SelectedIndexChanged);
            // 
            // cBoxProd
            // 
            this.cBoxProd.FormattingEnabled = true;
            this.cBoxProd.Location = new System.Drawing.Point(183, 71);
            this.cBoxProd.Name = "cBoxProd";
            this.cBoxProd.Size = new System.Drawing.Size(182, 21);
            this.cBoxProd.TabIndex = 3;
            this.cBoxProd.SelectedIndexChanged += new System.EventHandler(this.cBoxProd_SelectedIndexChanged);
            // 
            // txtBoxQuant
            // 
            this.txtBoxQuant.Location = new System.Drawing.Point(183, 113);
            this.txtBoxQuant.Name = "txtBoxQuant";
            this.txtBoxQuant.Size = new System.Drawing.Size(182, 20);
            this.txtBoxQuant.TabIndex = 1;
            // 
            // grpBoxRecap
            // 
            this.grpBoxRecap.Controls.Add(this.dgvRecap);
            this.grpBoxRecap.Location = new System.Drawing.Point(24, 384);
            this.grpBoxRecap.Name = "grpBoxRecap";
            this.grpBoxRecap.Size = new System.Drawing.Size(724, 206);
            this.grpBoxRecap.TabIndex = 1;
            this.grpBoxRecap.TabStop = false;
            this.grpBoxRecap.Text = "Récapitulatif des produits de la Commande";
            // 
            // dgvRecap
            // 
            this.dgvRecap.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvRecap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecap.Location = new System.Drawing.Point(26, 30);
            this.dgvRecap.Name = "dgvRecap";
            this.dgvRecap.Size = new System.Drawing.Size(660, 150);
            this.dgvRecap.TabIndex = 0;
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(185, 610);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(156, 36);
            this.btnPdf.TabIndex = 2;
            this.btnPdf.Text = "Imprimer Format PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(402, 610);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(156, 36);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmDetailCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(801, 658);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.grpBoxRecap);
            this.Controls.Add(this.grpBoxListProduit);
            this.Controls.Add(this.grpBoxInfoCom);
            this.Name = "FrmDetailCommande";
            this.Text = "FrmDetailCommande";
            this.Load += new System.EventHandler(this.FrmDetailCommande_Load);
            this.grpBoxInfoCom.ResumeLayout(false);
            this.grpBoxInfoCom.PerformLayout();
            this.grpBoxListProduit.ResumeLayout(false);
            this.grpBoxListProduit.PerformLayout();
            this.grpBoxRecap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxInfoCom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtBoxDateCom;
        private System.Windows.Forms.TextBox txtBoxNumCom;
        private System.Windows.Forms.GroupBox grpBoxListProduit;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.ComboBox cBoxCat;
        private System.Windows.Forms.ComboBox cBoxProd;
        private System.Windows.Forms.TextBox txtBoxQuant;
        private System.Windows.Forms.GroupBox grpBoxRecap;
        private System.Windows.Forms.DataGridView dgvRecap;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TextBox txtBoxClient;
        private System.Windows.Forms.Button btnAjoutCom;
    }
}