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
    public partial class FrmGestionInternaute : Form
    {
        //DataTable mesClients = GestionPS.PSGetLesClients();
        DataTable mesClientsDG = GestionPS.PSGetLesInternautes();
        int position = 0;

        public FrmGestionInternaute(int idCli)
        {
            InitializeComponent();
            textBoxId.Text = Convert.ToString(idCli);

        }
        public void RafraichirInterface()
        {
            if (position > -1)
            {
                textBoxId.Text = mesClientsDG.Rows[position].ItemArray[0].ToString();
                textBoxLogin.Text = mesClientsDG.Rows[position].ItemArray[1].ToString();
                textBoxMDP.Text = mesClientsDG.Rows[position].ItemArray[2].ToString();
                textBoxDateInscription.Text = mesClientsDG.Rows[position].ItemArray[3].ToString();
            }

        }

        private void FrmGestionInternaute_Load(object sender, EventArgs e)
        {
            
            dgvInternaute.DataSource = mesClientsDG;
            //cBoxClient.DataSource = GestionPS.PSGetLesClientsInternaute();
            //cBoxClient.DisplayMember = "nomClient";
            //cBoxClient.ValueMember = "idClient";
        }
     
        private void btnAjCommande_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBoxId.Text);
            GestionPS.PSUpdateInternaute(c, textBoxLogin.Text, textBoxMDP.Text, textBoxDateInscription.Text); 
            MessageBox.Show("Client(e) modifié ! ", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mesClientsDG.Clear();
            mesClientsDG = GestionPS.PSGetLesInternautes();
            RafraichirInterface();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPremier_Click_1(object sender, EventArgs e)
        {
            if (position < GestionClient.getNBClientsInternaute() + 1)
            {
                position = 0;
                RafraichirInterface();
            }
        }

        private void btnPrecedent_Click_1(object sender, EventArgs e)
        {
            if (position < GestionClient.getNBClientsInternaute() + 1)
            {
                position--;
                RafraichirInterface();
            }
        }

        private void btnSuivant_Click_1(object sender, EventArgs e)
        {
            if (position < GestionClient.getNBClientsInternaute() - 1)
            {
                position++;
                RafraichirInterface();
            }
        }

        private void btnDernier_Click_1(object sender, EventArgs e)
        {
            if (position < GestionClient.getNBClientsInternaute() - 1)
            {
                position = GestionClient.getNBClientsInternaute() - 1;
                RafraichirInterface();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

                if (textBoxId.Text != "" && textBoxLogin.Text != "" && textBoxMDP.Text != "" && textBoxDateInscription.Text != "")
                {
                    btnAjouter.Text = "Ajouter";
                   

                        GestionPS.PSInsertInternaute(Convert.ToInt32(textBoxId.Text), textBoxLogin.Text, textBoxMDP.Text, textBoxDateInscription.Text);
                        

                    MessageBox.Show(" Internaute Ajouté");
                    mesClientsDG.Clear();
                    mesClientsDG = GestionPS.PSGetLesInternautes();
                    RafraichirInterface();
                    dgvInternaute.DataSource = mesClientsDG;

                }

            }
        

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Etes vous sur de vouloir suprimer le Client", "'Suppression'", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rep == DialogResult.Yes)
            {
                int c = Convert.ToInt32(textBoxId.Text);
                try
                {
                    GestionPS.PSDeleteInternauteById(Convert.ToInt32(c));
                }
                catch
                {
                    MessageBox.Show("Erreur");
                }
                GestionClient.suppr(Convert.ToInt32(textBoxId.Text));
                position = 0;
                mesClientsDG.Clear();
                mesClientsDG = GestionPS.PSGetLesInternautes();
                RafraichirInterface();
                dgvInternaute.DataSource = mesClientsDG;
            }
        }


    }
}