using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AppEval
{
    public static class DAOOffre
    {
        public static List<Offre> GetLesOffres(int unIdOffre)
        {

            List<Offre> listOffres = new List<Offre>();
            var connString = "Host=localhost;Port=4747;Username=openpg;Password=;Database=BddAppEval";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT  libelle, lieu FROM offre_emplois WHERE id_offre= "+unIdOffre, conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Offre uneOffre= new Offre(reader.GetString(0), reader.GetString(1));
                        listOffres.Add(uneOffre);
                    }
                conn.Close();
            }
            return listOffres;
        }
    }
}
