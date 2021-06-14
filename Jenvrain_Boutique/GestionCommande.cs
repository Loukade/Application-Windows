using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD.MySQL;

namespace GestCommande
{
    class GestionCommande
    {
        public static DataTable getLesCommande()
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT * FROM Commande", "toutesLesCommande");
        }

        public static DataTable getLesDetailCommande()
        {
            return GestionBoutique.getLesTuplesByRequete("Select  libelleCategorie, libelleProduit  from categorie, produit where produit.idCat = Categorie.idCategorie group by idCategorie", "TouslesDetailCommandes");
        }

        public static DataTable getLesDetailCommandeCB(string libelleCat)
        {
            return GestionBoutique.getLesTuplesByRequete("Select  idProduit ,libelleProduit from produit,categorie  where Produit.IdCat = Categorie.idCategorie and libelleCategorie =" + libelleCat + " ", "TouslesDetailCommandesCB");
        }
        public static DataTable getLesDetailCommandeDG(int idcomm)
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT produit.idproduit, libelleproduit, prixhtproduit, quantitecom,(prixhtproduit * quantitecom) AS MontantLigneHT FROM produit, lignedecommande WHERE produit.idProduit= lignedecommande.idProduit AND idcommande = " + idcomm, "TousLesDetailsCommandesDG");
        }

        public static DataTable getLesCommandesDG()
        {
            return GestionBoutique.getLesTuplesByRequete("Select  commande.idCommande ,dateCommande , CONCAT(prenomClient , ' ' , nomClient) as Client , sum(prixHTProduit*1.2*quantiteCom) as PrixTTC from client, commande , produit , lignedecommande  where client.idClient = commande.idCli and lignedecommande.idCommande = commande.idCommande and lignedecommande.idProduit = produit.idProduit group by idCommande", "TouslesCommandesDG");
        }
        public static int getNBCommandes()
        {
            GestionBoutique.maCommandeSpecialRequete.CommandText = "SELECT Count(*) FROM Commande";
            return Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
        }
        public static void Add(int idCommande, string DateCommande, int idCli)
        {
            GestionBoutique.maRequete = "insert into Commande values( " + idCommande + ",'" + DateCommande + "','" + idCli + "')";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }
        public static void AddLigneCommande(int idCommande, int idProduit, int Quantité)
        {
            GestionBoutique.maRequete = "insert into lignedecommande values( " + idCommande + ",'" + idProduit + "','" + Quantité + "')";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }

        public static void supprL(int idCommande)
        {
            GestionBoutique.maRequete = "delete from lignedecommande where idCommande =" + idCommande;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }
        public static void suppr(int idCommande)
        {
            supprL(idCommande);
            GestionBoutique.maRequete = "delete from commande where idCommande =" + idCommande;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }


        public static void Modif(int idCommande, string DateCommande, int idCli)
        {
            GestionBoutique.maRequete = "Update Commande set dateCommande ='" + DateCommande + "', idCli='" + idCli + "' where idCommande  =" + idCommande;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }


    }
}
