using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jenvrain_Boutique;
using GestCommande;
using GestClient;
using GestCategorie;
using GestProduits;
namespace Jenvrain_Boutique
{
    public partial class FrmGestionClients : Form
    {
        DataTable mesclients = GestionClient.getLesClients();
        int position = 0;
        public FrmGestionClients()
        {
            InitializeComponent();
            dgvAMSClient.DataSource = GestionClient.getLesClientsDG();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {

            if (position < GestionClient.getNBClients() + 1)
            {
                position--;
                RafraichirInterface();
            }
        }
        public void RafraichirInterface()
        {
            if (position > -1)
            {
                textBoxId.Text = mesclients.Rows[position].ItemArray[0].ToString();
                textBoxNom.Text = mesclients.Rows[position].ItemArray[1].ToString();
                textBoxPrenom.Text = mesclients.Rows[position].ItemArray[2].ToString();
                textBoxAdresse.Text = mesclients.Rows[position].ItemArray[3].ToString();
                textBoxCodePostal.Text = mesclients.Rows[position].ItemArray[4].ToString();
                textBoxVille.Text = mesclients.Rows[position].ItemArray[5].ToString();

            }
        }
            private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text == "Ajouter")
            {
                btnAjouter.Text = "+";
                textBoxNom.Text = "";
                textBoxAdresse.Text = "";
                textBoxVille.Text = "";
                textBoxCodePostal.Text = "";
                textBoxPrenom.Text = "";
                textBoxId.Text = Convert.ToString(GestionClient.getNBClients() + 1);
            }
            else
            {
                if (textBoxNom.Text != "" && textBoxPrenom.Text != "" && textBoxAdresse.Text != "" && textBoxCodePostal.Text != "" && textBoxVille.Text != "")
                {
                    GestionClient.add(Convert.ToInt32(textBoxId.Text), textBoxNom.Text, textBoxPrenom.Text, textBoxAdresse.Text, Convert.ToInt32(textBoxCodePostal.Text), textBoxVille.Text,checkBox2.Checked,checkBox1.Checked);
                    btnAjouter.Text = "+";
                    MessageBox.Show(" Client Ajouté");
                    mesclients.Clear();
                    dgvAMSClient.DataSource = null;
                    mesclients = GestionClient.getLesClients();
                    dgvAMSClient.DataSource = mesclients;
                    if (checkBox1.Checked == true)
                    {
                        FrmGestionInternaute formulaire = new FrmGestionInternaute(Convert.ToInt32(textBoxId.Text));
                        formulaire.Show();
                    }
                    if (checkBox2.Checked == true)
                    {
                        FrmGestionEmployes formulaire = new FrmGestionEmployes(Convert.ToInt32(textBoxId.Text));
                        formulaire.Show();
                    }

                }
                RafraichirInterface();
            }

        
            
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            dgvAMSClient.DataSource = null;
            RafraichirInterface();
            Close();
        }

        private void FrmGestionClients_Load(object sender, EventArgs e)
        {
            
            RafraichirInterface();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {

            if (position < GestionClient.getNBClients() - 1)
            {
                position++;
                RafraichirInterface();
            }

        }

        private void btnPremier_Click(object sender, EventArgs e)
        {

            if (position < GestionClient.getNBClients() + 1)
            {
                position = 0;
                RafraichirInterface();
            }
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {

            if (position < GestionClient.getNBClients() - 1)
            {
                position = GestionClient.getNBClients() - 1;
                RafraichirInterface();

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Etes vous sur de vouloir suprimer le client", "'Suppression'", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rep == DialogResult.Yes)
            {
                int c = Convert.ToInt32(textBoxId.Text);
                try
                {
                    GestionPS.PSDeleteInternauteById(Convert.ToInt32(c));
                    GestionPS.PSDeleteEmployes(Convert.ToInt32(c));
                }
                catch
                {
                    MessageBox.Show("Erreur");
                }
                GestionClient.suppr(Convert.ToInt32(textBoxId.Text));
                
                position = 0;
                mesclients.Clear();
                dgvAMSClient.DataSource = null;
                mesclients = GestionClient.getLesClients();
                dgvAMSClient.DataSource = mesclients;
                RafraichirInterface();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBoxId.Text);
            GestionClient.Modif(c, textBoxNom.Text, textBoxPrenom.Text, textBoxAdresse.Text, Convert.ToInt32(textBoxCodePostal.Text), textBoxVille.Text);
            MessageBox.Show(" Client Modifié");
            mesclients.Clear();
            dgvAMSClient.DataSource = null;
            mesclients = GestionClient.getLesClients();
            dgvAMSClient.DataSource = mesclients;
            RafraichirInterface();
            if (checkBox1.Checked == true)
            {
                FrmGestionInternaute formulaire = new FrmGestionInternaute(Convert.ToInt32(textBoxId.Text));
                formulaire.Show();
            }
            if (checkBox2.Checked == true)
            {
                FrmGestionEmployes formulaire = new FrmGestionEmployes(Convert.ToInt32(textBoxId.Text));
                formulaire.Show();
            }
        }
    }
}