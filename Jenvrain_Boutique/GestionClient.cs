using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD.MySQL;
using System.Data;
using System.Data.SqlClient;

namespace GestClient
{
    class GestionClient
    {

  
        public static object Selection { get; private set; }

        public static DataTable getLesClients()
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT * FROM Client", "tousLesClient");
        }
        public static DataTable getLesClientsInternaute()
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT * FROM Internaute", "tousLesClientInternaute");
        }
        public static DataTable getLesClientsDG()
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT * FROM Client", "tousLesClientDG");
        }
        public static int getNBClients()
        {
            GestionBoutique.maCommandeSpecialRequete.CommandText = "SELECT Count(*) FROM Client";
            return Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
        }
        public static int getNBClientsInternaute()
        {
            GestionBoutique.maCommandeSpecialRequete.CommandText = "SELECT Count(*) FROM Internaute";
            return Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
        }
        public static void add(int idClient, string nomClient, string prenomClient,string adRueClient,int adCpClient,string adVilleClient,bool Employe, bool internaute)
        {
             GestionBoutique.maRequete = "insert into Client values( "+ idClient + ",'" + nomClient + "','" + prenomClient + "','" + adRueClient + "'," + adCpClient + ",'" + adVilleClient + "'," + Employe + "," + internaute + ")";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }
        public static void addInternaute (string login, string MDP)
        {
            GestionBoutique.maRequete = "insert into Internaute values( " + login + ",'" + MDP + "')";
        }

        public static void suppr(int idClient)
        {
            GestionBoutique.maRequete = "delete from Client where idClient ="  + idClient;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }

        public static void Modif(int id, string nomclient, string prenomClient, string adRueClient, int adCpClient, string adVilleClient)
        {
            GestionBoutique.maRequete = "Update client set nomclient ='" + nomclient + "', prenomClient='" + prenomClient + "', adRueClient ='" + adRueClient + "', adCpClient =" + adCpClient + ", adVilleClient ='" + adVilleClient + "' where idClient  =" + id;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();

        }

       
    }
    }
