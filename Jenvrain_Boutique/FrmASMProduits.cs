using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestProduits;
using GestCategorie;
using GestFournisseur;


namespace Jenvrain_Boutique
{
    public partial class FrmASMProduits : Form
    {
        DataTable mesProduits = GestionProduits.getLesProduits();
        DataTable mesProduitsDG = GestionProduits.getLesProduitsDG();
        int position = 0;
        public FrmASMProduits()
        {
            InitializeComponent();
 
        }

        private void FrmASMProduits_Load(object sender, EventArgs e)
        {
            RafraichirInterface();
            dgvASMProduit.DataSource = mesProduitsDG;
            cBoxFournisseur.DataSource = GestionFournisseurs.getLesFournisseurs();
            cBoxFournisseur.DisplayMember = "nomFournisseur";
            cBoxFournisseur.ValueMember = "idFournisseur";

            cBoxCategorie.DataSource = GestionCategorie.getLesCategories();
            cBoxCategorie.DisplayMember = "libelleCategorie";
            cBoxCategorie.ValueMember = "idCategorie";
        }

        public void RafraichirInterface()
        {
            if (position > -1)
            {
                txtBoxIDProduit.Text = mesProduits.Rows[position].ItemArray[0].ToString();
                TxboxLibelleProduit.Text = mesProduits.Rows[position].ItemArray[1].ToString();
                TxtBoxPrxHT.Text = mesProduits.Rows[position].ItemArray[2].ToString();
                TxtBoxQteStock.Text = mesProduits.Rows[position].ItemArray[3].ToString();
                cBoxCategorie.SelectedValue = mesProduits.Rows[position].ItemArray[4].ToString();
                cBoxFournisseur.SelectedValue = mesProduits.Rows[position].ItemArray[5].ToString();

            }

        }

        private void btnPremier_Click_1(object sender, EventArgs e)
        {
            if (position < GestionProduits.getNBProduits() + 1)
            {
                position = 0;
                RafraichirInterface();
            }
        }

        private void BtnPrecedant_Click_1(object sender, EventArgs e)
        {
            if (position < GestionProduits.getNBProduits() + 1)
            {
                position--;
                RafraichirInterface();
            }
        }

        private void btnSuivant_Click_1(object sender, EventArgs e)
        {
            if (position < GestionProduits.getNBProduits() - 1)
            {
                position++;
                RafraichirInterface();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (position < GestionProduits.getNBProduits() - 1)
            {
                position = GestionProduits.getNBProduits() - 1;
                RafraichirInterface();

            }
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (btnAjout.Text == "+")
            {
                btnAjout.Text = "Ajouter";
                TxboxLibelleProduit.Text = "";
                TxtBoxPrxHT.Text = "";
                TxtBoxQteStock.Text = "";
                cBoxCategorie.Text = "";
                cBoxFournisseur.Text = "";
                txtBoxIDProduit.Text = Convert.ToString(GestionProduits.getNBProduits() + 1);
            }
            else
            {
                if (TxboxLibelleProduit.Text != "" && TxtBoxPrxHT.Text != "" && TxtBoxQteStock.Text  != "" && cBoxCategorie.Text != "" && cBoxFournisseur.Text != "")
                {
                    GestionProduits.add(Convert.ToInt32(txtBoxIDProduit.Text), TxboxLibelleProduit.Text, Convert.ToInt32(TxtBoxPrxHT.Text), Convert.ToInt32(TxtBoxQteStock.Text), Convert.ToInt32(cBoxCategorie.SelectedValue), Convert.ToInt32(cBoxFournisseur.SelectedValue));
                    btnAjout.Text = "Ajouter";
                    MessageBox.Show(" Produit Ajouté");
                    mesProduitsDG.Clear();
                    dgvASMProduit.DataSource = null;
                    mesProduits = GestionProduits.getLesProduitsDG();
                    dgvASMProduit.DataSource = mesProduits;
                    RafraichirInterface();
                }

            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Etes vous sur de vouloir suprimer le Produit", "'Suppression'", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rep == DialogResult.Yes)
            {
                int c = Convert.ToInt32(txtBoxIDProduit.Text);
                GestionProduits.suppr(Convert.ToInt32(txtBoxIDProduit.Text));
                position = 0;
                mesProduitsDG.Clear();
                dgvASMProduit.DataSource = null;
                mesProduits = GestionProduits.getLesProduitsDG();
                dgvASMProduit.DataSource = mesProduits;
                RafraichirInterface();
            }
        }

        private void btnModif_Click_1(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(txtBoxIDProduit.Text);
            GestionProduits.Modif(c, TxboxLibelleProduit.Text, Convert.ToInt32(TxtBoxPrxHT.Text), Convert.ToInt32(TxtBoxQteStock.Text), Convert.ToInt32(cBoxCategorie.SelectedValue), Convert.ToInt32(cBoxFournisseur.SelectedValue)); ;
            MessageBox.Show("Client(e) modifié ! ", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mesProduitsDG.Clear();
            mesProduitsDG = GestionProduits.getLesProduitsDG();
            RafraichirInterface();
        }
    }
}
