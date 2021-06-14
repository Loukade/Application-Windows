using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD.MySQL;
using System.Data;
using System.Data.SqlClient;

namespace  GestProduits
{
    class GestionProduits
    {

        public static object Selection { get; private set; }

        public static DataTable getLesProduits()
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT * FROM produit", "tousLesProduits");
        }
        public static DataTable getLesProduitsLibelle()
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT idProduit, LibelleProduit FROM produit", "tousLesProduits");
        }
        public static DataTable getLesProduitsbyCommande(string LibCat)
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT distinct(libelleProduit), idProduit FROM produit,categorie  where produit.idCat = categorie.idCategorie and LibelleCategorie =" + LibCat, "tousLesProduitsBycom");
        }
        public static DataTable getLesProduitsCommande()
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT CONCAT(libelleProduit , '-' , prixHTProduit,'€') as PrixProduit, idProduit FROM categorie,produit", "tousLesProduitsCommande");
        }
        public static DataTable getLesProduitsDG()
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT idProduit,libelleProduit,prixHTProduit,qteStockProduit,nomFournisseur,libelleCategorie FROM produit,categorie,fournisseur where produit.idCat = categorie.idCategorie and produit.idFourn = fournisseur.idFournisseur ", "tousLesProduitsDG");
        }

        public static int getNBProduits()
        {
            GestionBoutique.maCommandeSpecialRequete.CommandText = "SELECT Count(*) FROM produit";
            return Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
        }

        public static void add(int idProduit, string libelleProduit, int prixHTProduit, int qteStockProduit, int idCategorie, int idFournisseur)
        {
            GestionBoutique.maRequete = "insert into produit values( " + idProduit + ",'" + libelleProduit + "','" + prixHTProduit + "','" + qteStockProduit + "','" + idCategorie + "','" + idFournisseur + "')";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }

        public static void suppr(int idProduit)
        {
            GestionBoutique.maRequete = "delete from produit where idProduit =" + idProduit;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }

        public static void Modif(int id, string libelleProduit, int prixHTProduit, int qteStockProduit, int idFourn, int idCat)
        {
            GestionBoutique.maRequete = "Update produit set libelleProduit ='" + libelleProduit + "', prixHTProduit='" + prixHTProduit + "', qteStockProduit ='" + qteStockProduit + "', idFourn ='" + idFourn + "', idCat ='" + idCat + "' where idProduit  =" + id;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }
    }
}
    

