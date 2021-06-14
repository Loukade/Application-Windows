using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD.MySQL;
using System.Data;
using System.Data.SqlClient;

namespace GestFournisseur
{
    class GestionFournisseurs
    {
        public static DataTable getLesFournisseurs()
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT * FROM fournisseur", "toutLesFournisseurs");
        }
    }
}
