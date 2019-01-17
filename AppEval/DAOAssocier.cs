using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AppEval
{
    public static class DAOAssocier
    {
        public static List<Associer> GetLesAssociations()
        {
            List<Associer> listAssociation = new List<Associer>();
            var connString = "Host=localhost;Port=4747;Username=openpg;Password=;Database=BddAppEval";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT coefficient, id_critere, id_offre FROM associer ORDER BY id_critere", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Associer uneAssociation = new Associer(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2));
                        listAssociation.Add(uneAssociation);
                    }
                conn.Close();
            }
            return listAssociation;
        }
    }
}
