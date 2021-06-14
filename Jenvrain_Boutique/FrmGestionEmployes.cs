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
    public partial class FrmGestionEmployes : Form
    {
        int position = 0;
        DataTable mesClientsDG = GestionPS.PSGetLesEmployes();
        public FrmGestionEmployes(int idCli)
        {

            InitializeComponent();
            textBoxNumEmploye.Text = Convert.ToString(idCli);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmGestionEmployes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mesClientsDG;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void RafraichirInterface()
        {
            if (position > -1)
            {
                textBoxNumEmploye.Text = mesClientsDG.Rows[position].ItemArray[0].ToString();
                textBoxDateEmbauche.Text = mesClientsDG.Rows[position].ItemArray[1].ToString();
                textBoxPoste.Text = mesClientsDG.Rows[position].ItemArray[2].ToString();
                textBoxSalaire.Text = mesClientsDG.Rows[position].ItemArray[3].ToString();
            }

        }
        private void btnSuivant_Click(object sender, EventArgs e)
        {

            if (position < GestionClient.getNBClientsInternaute() - 1)
            {
                position++;
                RafraichirInterface();
            }
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (position < GestionClient.getNBClientsInternaute() + 1)
            {
                position--;
                RafraichirInterface();
            }
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {

            if (position < GestionClient.getNBClientsInternaute() - 1)
            {
                position = GestionClient.getNBClientsInternaute() - 1;
                RafraichirInterface();
            }
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {

            if (position < GestionClient.getNBClientsInternaute() + 1)
            {
                position = 0;
                RafraichirInterface();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Etes vous sur de vouloir suprimer le Client", "'Suppression'", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rep == DialogResult.Yes)
            {
                int c = Convert.ToInt32(textBoxNumEmploye.Text);
                try
                {
                    GestionPS.PSDeleteEmployes(Convert.ToInt32(c));
                }
                catch
                {
                    MessageBox.Show("Erreur");
                }
                GestionClient.suppr(Convert.ToInt32(textBoxNumEmploye.Text));
                position = 0;
                mesClientsDG.Clear();
                mesClientsDG = GestionPS.PSGetLesInternautes();
                RafraichirInterface();
                dataGridView1.DataSource = mesClientsDG;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxNumEmploye.Text != "" && textBoxDateEmbauche.Text != "" && textBoxPoste.Text != "" && textBoxSalaire.Text != "")
            {
                btnAjouter.Text = "Ajouter";


                GestionPS.PSInsertEmployes(Convert.ToInt32(textBoxNumEmploye.Text), textBoxDateEmbauche.Text, textBoxPoste.Text, Convert.ToInt32(textBoxSalaire.Text));


                MessageBox.Show(" Employé Ajouté");
                mesClientsDG.Clear();
                mesClientsDG = GestionPS.PSGetLesEmployes();
                RafraichirInterface();
                dataGridView1.DataSource = mesClientsDG;

            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

                int c = Convert.ToInt32(textBoxNumEmploye.Text);
                GestionPS.PSUpdateEmployes(c, textBoxDateEmbauche.Text, textBoxPoste.Text, Convert.ToInt32(textBoxSalaire.Text));
                MessageBox.Show("Client(e) modifié ! ", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mesClientsDG.Clear();
                mesClientsDG = GestionPS.PSGetLesEmployes();
                RafraichirInterface();
            
        }

       
    }
}
