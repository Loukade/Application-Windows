using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestClient;

namespace Jenvrain_Boutique
{
    public partial class FrmASMClient : Form
    {
        DataTable mesclients = GestionClient.getLesClients();
        int position = 0;
        public FrmASMClient()
        {
            InitializeComponent();
            dgvASMClient.DataSource = GestionClient.getLesClientsDG();
        }

        private void FrmASMClient_Load(object sender, EventArgs e)
        {


            RafraichirInterface();
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RafraichirInterface()
        {
            if (position > -1)
            {
                txtBoxIDClient.Text = mesclients.Rows[position].ItemArray[0].ToString();
                txtBoxNomClient.Text = mesclients.Rows[position].ItemArray[1].ToString();
                txtPrenomClient.Text = mesclients.Rows[position].ItemArray[2].ToString();
                txtBoxRueClient.Text = mesclients.Rows[position].ItemArray[3].ToString();
                txtCodePostal.Text = mesclients.Rows[position].ItemArray[4].ToString();
                txtBoxVille.Text = mesclients.Rows[position].ItemArray[5].ToString();

            }

        }
        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            if (position < GestionClient.getNBClients() - 1)
            {
                position++;
                RafraichirInterface();
            }

        }

        private void BtnPrecedant_Click(object sender, EventArgs e)
        {
            if (position < GestionClient.getNBClients() + 1)
            {
                position--;
                RafraichirInterface();
            }
        }

        private void BtnPremier_Click(object sender, EventArgs e)
        {
            if (position < GestionClient.getNBClients() + 1)
            {
                position = 0 ;
                RafraichirInterface();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (position < GestionClient.getNBClients() - 1)
            {
                position = GestionClient.getNBClients() - 1;              
                    RafraichirInterface();
                
            }
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            if (btnAjout.Text == "+")
            {
                btnAjout.Text = "Ajouter";
                txtBoxNomClient.Text = "";
                txtBoxRueClient.Text = "";
                txtBoxVille.Text = "";
                txtCodePostal.Text = "";
                txtPrenomClient.Text = "";
                txtBoxIDClient.Text = Convert.ToString(GestionClient.getNBClients() + 1);
            }
            else
            {
                if (txtBoxNomClient.Text != "" && txtPrenomClient.Text != "" && txtBoxRueClient.Text != "" && txtCodePostal.Text != "" && txtBoxVille.Text != "")
                {
                    //GestionClient.add(Convert.ToInt32(txtBoxIDClient.Text), txtBoxNomClient.Text, txtPrenomClient.Text, txtBoxRueClient.Text, Convert.ToInt32(txtCodePostal.Text), txtBoxVille.Text);
                    //btnAjout.Text = "Ajouter";
                    //MessageBox.Show(" Client Ajouté");
                    //mesclients.Clear();
                    dgvASMClient.DataSource = null;
                    mesclients = GestionClient.getLesClients();
                    dgvASMClient.DataSource = mesclients;
                    RafraichirInterface();
                }

            }
            
        }

        private void BtnSuppr_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Etes vous sur de vouloir suprimer le client", "'Suppression'",  MessageBoxButtons.YesNo , MessageBoxIcon.Information);
                if (rep == DialogResult.Yes)
                {
                int c = Convert.ToInt32(txtBoxIDClient.Text);
                GestionClient.suppr(Convert.ToInt32(txtBoxIDClient.Text));
                position = 0;
                    mesclients.Clear();
                    dgvASMClient.DataSource = null;
                    mesclients = GestionClient.getLesClients();
                    dgvASMClient.DataSource = mesclients;
                    RafraichirInterface();
                }
            }

        private void BtnModif_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(txtBoxIDClient.Text);
            GestionClient.Modif(c, txtBoxNomClient.Text,txtPrenomClient.Text,txtBoxRueClient.Text, Convert.ToInt32(txtCodePostal.Text),txtBoxVille.Text);
                MessageBox.Show(" Client Modifié");
                mesclients.Clear();
                dgvASMClient.DataSource = null;
                mesclients = GestionClient.getLesClients();
                dgvASMClient.DataSource = mesclients;
                RafraichirInterface();
            
        }
    }
}
