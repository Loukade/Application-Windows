using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD.MySQL;
using System.Data;

namespace Jenvrain_Boutique
{
    class GestionPS
    {
        public static DataTable PSGetLesCommandes()
        {
            return GestionBoutique.Executer_Requete_Select("Call PSGetLesCommandes ");
        }
        public static DataTable PSDeleteCommandeById(int idCom)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSDeleteCommandeById(" +idCom +")");
        }
        public static DataTable PSGetLaCommandeById(int idCom)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSGetLaCommandeById(" + idCom + ")");
        }
        public static DataTable PSGetLesClients()
        {
            return GestionBoutique.Executer_Requete_Select("Call PSGetLesClients");
        }
        public static DataTable PSGetLesCategories()
        {
            return GestionBoutique.Executer_Requete_Select("Call PSGetLesCategories");
        }
        public static DataTable PSGetLesProduitsByCategorie(int idCat)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSGetLesProduitsByCategorie(" + idCat + ")");
        }
        public static DataTable PSGetLesProduitsByCommande(int idCom)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSGetLesProduitsByCommande(" + idCom + ")");
        }

        public static DataTable PSInsertProduitByCommande(int idCom, int idProd, int quant)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSInsertProduitByCommande(" + idCom + "," + idProd + "," + quant +")");
        }
        public static DataTable PSDeleteProduitByCommande(int idCom)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSDeleteProduitByCommande(" + idCom + ")");
        }

        public static DataTable PSGetMontantHTByCommande(int idCom)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSGetMontantHTByCommande(" + idCom + ")");
        }

        public static DataTable PSInsertClientInternaute(int idCli, string nomCli, string prenomCli, string AdCli, int CpCli, string VilleCli)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSInsertClientInternaute(" + idCli + "," +  nomCli + "," +  prenomCli + "," + AdCli + "," +  CpCli + "," + VilleCli + ")");
        }

        public static DataTable PSGetLesClientsEmploye()
        {
            return GestionBoutique.Executer_Requete_Select("Call PSGetLesClientsEmploye");
        }

        public static DataTable PSInsertClientEmploye(int idCli, string nomCli, string prenomCli, string AdCli, int CpCli, string VilleCli)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSInsertClientEmploye(" + idCli + "," + nomCli + "," + prenomCli + "," + AdCli + "," + CpCli + "," + VilleCli + ")");
        }

        public static DataTable PSDeleteInternauteById(int idClient)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSDeleteInternauteById(" + idClient + ")");
        }

        public static DataTable PSInsertInternaute(int idCli, string login, string mdp, string dateInscription)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSInsertInternaute(" + idCli + ",'" + login + "','" + mdp + "','" + dateInscription + "')");
        }

        public static DataTable PSGetLesInternautes()
        {
            return GestionBoutique.Executer_Requete_Select("Call PSGetLesInternautes");
        }
        public static DataTable PSGetLesEmployes()
        {
            return GestionBoutique.Executer_Requete_Select("Call PSGetLesEmployes");
        }

        public static DataTable PSUpdateInternaute(int idCli, string login, string mdp, string dateInscription)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSUpdateInternaute(" + idCli + ",'" + login + "','" + mdp + "','" + dateInscription + "')");
        }
        public static DataTable PSUpdateEmployes(int idCli, string DateEmbauche, string poste, int salaire)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSUpdateEmployes(" + idCli + ",'" + DateEmbauche + "','" + poste + "'," + salaire + ")");
        }
        
        public static DataTable PSDeleteEmployes(int idClient)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSDeleteEmployes(" + idClient + ")");
        }
        public static DataTable PSInsertEmployes(int idCli, string DateEmbauche, string poste, int salaire)
        {
            return GestionBoutique.Executer_Requete_Select("Call PSInsertEmployes(" + idCli + ",'" + DateEmbauche + "','" + poste + "'," + salaire + ")");
        }
    }
}