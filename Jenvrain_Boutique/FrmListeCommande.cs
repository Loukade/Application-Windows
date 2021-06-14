using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestCommande;
using GestClient;



namespace Jenvrain_Boutique
{
    public partial class FrmListeCommande : Form
    {
        DataTable mescommandes = GestionPS.PSGetLesCommandes();
        DataTable mescommandesDG = GestionCommande.getLesCommandesDG();
        int position = 0;

        public FrmListeCommande()
        {
            InitializeComponent();
        }

        public void RafraichirInterface()
        {
            if (position > -1)
            {
                txtBoxNum.Text = mescommandes.Rows[position].ItemArray[0].ToString();
                txtBoxDate.Text = mescommandes.Rows[position].ItemArray[1].ToString();
                cBoxClient.SelectedValue = mescommandes.Rows[position].ItemArray[2].ToString();
            }

        }
        private void FrmListeCommande_Load(object sender, EventArgs e)
        {
            RafraichirInterface();
            dgvListeCommande.DataSource = mescommandesDG;
            cBoxClient.DataSource = GestionPS.PSGetLesClients();
            cBoxClient.DisplayMember = "nomClient";
            cBoxClient.ValueMember = "idClient";
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            if (position < GestionCommande.getNBCommandes() + 1)
            {
                position = 0;
                RafraichirInterface();
            }
        }

        private void btnPrecedant_Click(object sender, EventArgs e)
        {
            if (position < GestionCommande.getNBCommandes() + 1)
            {
                position--;
                RafraichirInterface();
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (position < GestionCommande.getNBCommandes() - 1)
            {
                position++;
                RafraichirInterface();
            }
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            if (position < GestionCommande.getNBCommandes() - 1)
            {
                position = GestionCommande.getNBCommandes() - 1;
                RafraichirInterface();
            }
        }


        private void btnAjCommande_Click_1(object sender, EventArgs e)
        {
            if (btnAjCommande.Text == "Ajouter une Commande")
            {
                btnAjCommande.Text = "Ajouter";
                txtBoxDate.Text = "";
                cBoxClient.Text = "";
                txtBoxNum.Text = Convert.ToString(GestionCommande.getNBCommandes() + 1);

            }
            else
            {

                if (txtBoxDate.Text != "" && cBoxClient.Text != "")
                {
                    btnAjCommande.Text = "Ajouter";
                    MessageBox.Show(" Commande Ajouté");
                    FrmDetailCommande formulaire = new FrmDetailCommande(Convert.ToInt32(txtBoxNum.Text), txtBoxDate.Text, cBoxClient.Text);
                    formulaire.Show();
                    GestionCommande.Add(Convert.ToInt32(txtBoxNum.Text), txtBoxDate.Text, Convert.ToInt32(cBoxClient.SelectedValue));
                    mescommandesDG.Clear();
                    mescommandesDG = GestionCommande.getLesCommandesDG();
                    RafraichirInterface();
                    dgvListeCommande.DataSource = mescommandesDG;

                }

            }
        }
   
        private void btnSupCommande_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Etes vous sur de vouloir suprimer le Produit", "'Suppression'", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rep == DialogResult.Yes)
            {
                int c = Convert.ToInt32(txtBoxNum.Text);
                GestionPS.PSDeleteCommandeById(Convert.ToInt32(c));
                position = 0;
                mescommandesDG.Clear();
                mescommandesDG = GestionCommande.getLesCommandesDG();
                RafraichirInterface();
                dgvListeCommande.DataSource = mescommandesDG;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
            mescommandesDG.Clear();
        }

        private void btnModCommande_Click(object sender, EventArgs e)
        {
            FrmDetailCommande formulaire = new FrmDetailCommande(Convert.ToInt32(txtBoxNum.Text), txtBoxDate.Text, cBoxClient.Text);
            formulaire.Show();
        }

        private void cBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}