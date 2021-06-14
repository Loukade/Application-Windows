namespace Jenvrain_Boutique
{
    partial class FrmASMClient
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
            this.dgvASMClient = new System.Windows.Forms.DataGridView();
            this.btnPremier = new System.Windows.Forms.Button();
            this.BtnPrecedant = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtBoxIDClient = new System.Windows.Forms.TextBox();
            this.txtBoxNomClient = new System.Windows.Forms.TextBox();
            this.txtPrenomClient = new System.Windows.Forms.TextBox();
            this.txtBoxRueClient = new System.Windows.Forms.TextBox();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.lblIdClient = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenomClient = new System.Windows.Forms.Label();
            this.lblAdRueClient = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASMClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvASMClient
            // 
            this.dgvASMClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvASMClient.Location = new System.Drawing.Point(290, 12);
            this.dgvASMClient.Name = "dgvASMClient";
            this.dgvASMClient.Size = new System.Drawing.Size(481, 281);
            this.dgvASMClient.TabIndex = 0;
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(12, 343);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(43, 36);
            this.btnPremier.TabIndex = 1;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.BtnPremier_Click);
            // 
            // BtnPrecedant
            // 
            this.BtnPrecedant.Location = new System.Drawing.Point(74, 343);
            this.BtnPrecedant.Name = "BtnPrecedant";
            this.BtnPrecedant.Size = new System.Drawing.Size(43, 36);
            this.BtnPrecedant.TabIndex = 2;
            this.BtnPrecedant.Text = "<";
            this.BtnPrecedant.UseVisualStyleBackColor = true;
            this.BtnPrecedant.Click += new System.EventHandler(this.BtnPrecedant_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(140, 343);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(43, 36);
            this.btnSuivant.TabIndex = 3;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.BtnSuivant_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(210, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // txtBoxIDClient
            // 
            this.txtBoxIDClient.Location = new System.Drawing.Point(74, 29);
            this.txtBoxIDClient.Name = "txtBoxIDClient";
            this.txtBoxIDClient.Size = new System.Drawing.Size(136, 20);
            this.txtBoxIDClient.TabIndex = 5;
            // 
            // txtBoxNomClient
            // 
            this.txtBoxNomClient.Location = new System.Drawing.Point(74, 71);
            this.txtBoxNomClient.Name = "txtBoxNomClient";
            this.txtBoxNomClient.Size = new System.Drawing.Size(136, 20);
            this.txtBoxNomClient.TabIndex = 6;
            // 
            // txtPrenomClient
            // 
            this.txtPrenomClient.Location = new System.Drawing.Point(74, 114);
            this.txtPrenomClient.Name = "txtPrenomClient";
            this.txtPrenomClient.Size = new System.Drawing.Size(136, 20);
            this.txtPrenomClient.TabIndex = 7;
            // 
            // txtBoxRueClient
            // 
            this.txtBoxRueClient.Location = new System.Drawing.Point(74, 156);
            this.txtBoxRueClient.Name = "txtBoxRueClient";
            this.txtBoxRueClient.Size = new System.Drawing.Size(136, 20);
            this.txtBoxRueClient.TabIndex = 8;
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.Location = new System.Drawing.Point(74, 234);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(136, 20);
            this.txtBoxVille.TabIndex = 9;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(74, 193);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(136, 20);
            this.txtCodePostal.TabIndex = 10;
            // 
            // lblIdClient
            // 
            this.lblIdClient.AutoSize = true;
            this.lblIdClient.Location = new System.Drawing.Point(2, 29);
            this.lblIdClient.Name = "lblIdClient";
            this.lblIdClient.Size = new System.Drawing.Size(18, 13);
            this.lblIdClient.TabIndex = 11;
            this.lblIdClient.Text = "ID";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(2, 71);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 12;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenomClient
            // 
            this.lblPrenomClient.AutoSize = true;
            this.lblPrenomClient.Location = new System.Drawing.Point(2, 114);
            this.lblPrenomClient.Name = "lblPrenomClient";
            this.lblPrenomClient.Size = new System.Drawing.Size(43, 13);
            this.lblPrenomClient.TabIndex = 13;
            this.lblPrenomClient.Text = "Prenom";
            // 
            // lblAdRueClient
            // 
            this.lblAdRueClient.AutoSize = true;
            this.lblAdRueClient.Location = new System.Drawing.Point(2, 156);
            this.lblAdRueClient.Name = "lblAdRueClient";
            this.lblAdRueClient.Size = new System.Drawing.Size(68, 13);
            this.lblAdRueClient.TabIndex = 14;
            this.lblAdRueClient.Text = "Adresse Rue";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(2, 193);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(64, 13);
            this.lblCodePostal.TabIndex = 15;
            this.lblCodePostal.Text = "Code Postal";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(2, 234);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 16;
            this.lblVille.Text = "Ville";
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(473, 343);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(43, 36);
            this.btnAjout.TabIndex = 17;
            this.btnAjout.Text = "+";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(545, 343);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(61, 36);
            this.btnSuppr.TabIndex = 18;
            this.btnSuppr.Text = "Suprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.BtnSuppr_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(632, 343);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(43, 36);
            this.btnModif.TabIndex = 19;
            this.btnModif.Text = "Modif";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(314, 402);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(165, 36);
            this.btnFermer.TabIndex = 20;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // FrmASMClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCodePostal);
            this.Controls.Add(this.lblAdRueClient);
            this.Controls.Add(this.lblPrenomClient);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblIdClient);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.txtBoxVille);
            this.Controls.Add(this.txtBoxRueClient);
            this.Controls.Add(this.txtPrenomClient);
            this.Controls.Add(this.txtBoxNomClient);
            this.Controls.Add(this.txtBoxIDClient);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.BtnPrecedant);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.dgvASMClient);
            this.Name = "FrmASMClient";
            this.Text = "Ajout/Supr/Modif";
            this.Load += new System.EventHandler(this.FrmASMClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvASMClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvASMClient;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button BtnPrecedant;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtBoxIDClient;
        private System.Windows.Forms.TextBox txtBoxNomClient;
        private System.Windows.Forms.TextBox txtPrenomClient;
        private System.Windows.Forms.TextBox txtBoxRueClient;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.Label lblIdClient;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenomClient;
        private System.Windows.Forms.Label lblAdRueClient;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnFermer;
    }
}