using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace BD.MySQL
{
    class GestionBoutique
    {
        #region champs statiques

        public static MySqlConnection maConnexion = new MySqlConnection();
        public static MySqlCommand maCommandeSpecialRequete = new MySqlCommand();
        public static MySqlDataAdapter monRemplisseur = new MySqlDataAdapter();
        public static DataSet monJeuDeDonnees = new DataSet();
        public static string maRequete;
        public static string maChaine = "Server=localhost;Database=jenvrain_boutique; Uid=root;Pwd=";

        #endregion

        #region méthodes statiques

        public static void seConnecter()
        {
            if (maConnexion.State == ConnectionState.Closed)
            {
                maConnexion.ConnectionString = maChaine;
                maConnexion.Open();

                monJeuDeDonnees = new DataSet("client");
                monJeuDeDonnees.Clear();
                maCommandeSpecialRequete.CommandType = CommandType.Text;
                maCommandeSpecialRequete.Connection = maConnexion;
            }
        }


        public static DataTable Executer_Requete_Select(String callRequete)
        {
            GestionBoutique.seConnecter();

            GestionBoutique.maRequete = callRequete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.monRemplisseur.SelectCommand = GestionBoutique.maCommandeSpecialRequete;
            GestionBoutique.monRemplisseur.Fill(GestionBoutique.monJeuDeDonnees, callRequete);
            return GestionBoutique.monJeuDeDonnees.Tables[callRequete];
        }
        #endregion




        public static DataTable getLesTuplesByRequete(String texteRequete, string nomJeuDonnees)
        {
            GestionBoutique.seConnecter();

            GestionBoutique.maRequete = texteRequete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.monRemplisseur.SelectCommand = GestionBoutique.maCommandeSpecialRequete;
            GestionBoutique.monRemplisseur.Fill(GestionBoutique.monJeuDeDonnees, nomJeuDonnees);
            return GestionBoutique.monJeuDeDonnees.Tables[nomJeuDonnees];
        }

        public static DataTable getLesCategories()
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT * FROM Categorie", "toutesLesCategorie");
        }

        public static DataTable getLesFournisseurs()
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT * FROM fournisseur", "tousLesFournisseurs");
        }

        public static DataTable getLesProduits()
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT * FROM Produit", "tousLesProduits");
        }

        public static DataTable getLesLignesDeCommande()
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT * FROM LigneDeCommande", "toutesLesLignesDeCommande");
        }


      
    }
}
