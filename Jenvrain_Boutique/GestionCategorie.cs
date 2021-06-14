using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD.MySQL;
using System.Data;
using System.Data.SqlClient;

namespace GestCategorie
{
    class GestionCategorie
    {
        public static DataTable getLesCategories()
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT * FROM categorie", "toutesLesCategorie");
        }
    }
}
