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
using GestCategorie;
using GestProduits;

namespace Jenvrain_Boutique
{
    public partial class FrmDetailCommande : Form
    {
        public FrmDetailCommande(int com, string date,string Client)
        {
            InitializeComponent();
            txtBoxNumCom.Text = Convert.ToString(com);
            txtBoxDateCom.Text = date;
            txtBoxClient.Text = Client;
        }
        DataTable mesDetailCommande = GestionCommande.getLesDetailCommande();


        int position = 0;
       
        private void FrmDetailCommande_Load(object sender, EventArgs e)
        {
            DataTable mesDetailCommandeDG = GestionCommande.getLesDetailCommandeDG(Convert.ToInt32(txtBoxNumCom.Text));
            dgvRecap.DataSource = mesDetailCommandeDG;
            cBoxCat.DataSource = GestionPS.PSGetLesCategories();
            cBoxCat.DisplayMember = "libelleCategorie";
            cBoxCat.ValueMember = "idCategorie";
        RafraichirInterface();    


        }

        public void RafraichirInterface()
        {
            if (position > -1)
            {
                cBoxCat.DisplayMember = mesDetailCommande.Rows[position].ItemArray[0].ToString();
                cBoxProd.DisplayMember = mesDetailCommande.Rows[position].ItemArray[1].ToString();

            }


        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAjoutCom_Click(object sender, EventArgs e)
        {

            if (btnAjoutCom.Text == "Ajouter à la Commande")
            {
                try
                {

                    GestionPS.PSInsertProduitByCommande(Convert.ToInt32(txtBoxNumCom.Text), Convert.ToInt32(cBoxProd.SelectedValue), Convert.ToInt32(txtBoxQuant.Text));
                    btnAjoutCom.Text = "Ajouter";
                    MessageBox.Show(" Commande Ajouté");
                    mesDetailCommande.Clear();
                    dgvRecap.DataSource = null;
                    mesDetailCommande = GestionCommande.getLesDetailCommandeDG(Convert.ToInt32(txtBoxNumCom.Text));
                    RafraichirInterface();
                    dgvRecap.DataSource = mesDetailCommande;
                }
                catch (Exception Ex)
                {
                    string messageErreur = Ex.Message  ;

                    MessageBox.Show(messageErreur);
                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void cBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cBoxProd.DataSource = GestionPS.PSGetLesProduitsByCategorie(Convert.ToInt32(cBoxCat.SelectedValue));
                //cBoxProd.DataSource = GestionProduits.getLesProduitsLibelle();
                //cBoxProd.DisplayMember = "tousLesProduits";
                cBoxProd.DisplayMember = "LibelleProduit";
                cBoxProd.ValueMember = "idProduit";
            }
            catch (Exception ex)
            {
                string messageErreur = ex.Message + "Erreur";

                MessageBox.Show(messageErreur);
            }
        }

        private void cBoxProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

