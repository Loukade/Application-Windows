namespace Jenvrain_Boutique
{
    partial class FrmStart
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutSupprModifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutSuprModifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.commandeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeClientToolStripMenuItem,
            this.ajoutSupprModifToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // listeClientToolStripMenuItem
            // 
            this.listeClientToolStripMenuItem.Name = "listeClientToolStripMenuItem";
            this.listeClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeClientToolStripMenuItem.Text = "Liste Client";
            this.listeClientToolStripMenuItem.Click += new System.EventHandler(this.ListeClientToolStripMenuItem_Click);
            // 
            // ajoutSupprModifToolStripMenuItem
            // 
            this.ajoutSupprModifToolStripMenuItem.Name = "ajoutSupprModifToolStripMenuItem";
            this.ajoutSupprModifToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajoutSupprModifToolStripMenuItem.Text = "Ajout/Suppr/Modif";
            this.ajoutSupprModifToolStripMenuItem.Click += new System.EventHandler(this.AjoutSupprModifToolStripMenuItem_Click);
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeProduitToolStripMenuItem,
            this.ajoutSuprModifToolStripMenuItem});
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.produitToolStripMenuItem.Text = "Produit";
            // 
            // listeProduitToolStripMenuItem
            // 
            this.listeProduitToolStripMenuItem.Name = "listeProduitToolStripMenuItem";
            this.listeProduitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeProduitToolStripMenuItem.Text = "Liste Produit";
            this.listeProduitToolStripMenuItem.Click += new System.EventHandler(this.ListeProduitToolStripMenuItem_Click);
            // 
            // ajoutSuprModifToolStripMenuItem
            // 
            this.ajoutSuprModifToolStripMenuItem.Name = "ajoutSuprModifToolStripMenuItem";
            this.ajoutSuprModifToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajoutSuprModifToolStripMenuItem.Text = "Ajout/Suppr/Modif";
            this.ajoutSuprModifToolStripMenuItem.Click += new System.EventHandler(this.ajoutSuprModifToolStripMenuItem_Click);
            // 
            // commandeToolStripMenuItem
            // 
            this.commandeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeCommandeToolStripMenuItem});
            this.commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            this.commandeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.commandeToolStripMenuItem.Text = "Commande";
            // 
            // listeCommandeToolStripMenuItem
            // 
            this.listeCommandeToolStripMenuItem.Name = "listeCommandeToolStripMenuItem";
            this.listeCommandeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeCommandeToolStripMenuItem.Text = "Liste Commande";
            this.listeCommandeToolStripMenuItem.Click += new System.EventHandler(this.ListeCommandeToolStripMenuItem_Click);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 621);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmStart";
            this.Text = "Boutique";
            this.Load += new System.EventHandler(this.FrmStart_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutSupprModifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutSuprModifToolStripMenuItem;
    }
}

