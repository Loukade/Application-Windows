using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jenvrain_Boutique
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {
            //dgvtest.DataSource = GestionBoutique.getLesProduits();
            //dataGridView1.DataSource = GestionBoutique.getLesCategories();
            //dataGridView2.DataSource = GestionBoutique.getLesFournisseurs();
            //dataGridView3.DataSource = GestionBoutique.getLesLignesDeCommande();


        }

        private void ListeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeClient formulaire = new FrmListeClient();
            formulaire.Show();
        }

        private void ListeProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeProduits formulaire = new FrmListeProduits();
            formulaire.Show();
        }

        private void ListeCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeCommande formulaire = new FrmListeCommande();
            formulaire.Show();
        }

        private void AjoutSupprModifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionClients formulaire = new FrmGestionClients();
            formulaire.Show();
        }

        private void ajoutSuprModifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmASMProduits formulaire = new FrmASMProduits();
            formulaire.Show();
        }

      
    }
}
