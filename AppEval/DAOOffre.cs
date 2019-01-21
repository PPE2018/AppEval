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
        public static List<Offre> GetLesOffres()
        {
            List<Offre> listOffres = new List<Offre>();
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id_offre,libelle, lieu FROM offre_emplois", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Offre uneOffre= new Offre(reader.GetInt32(0),reader.GetString(1), reader.GetString(2));
                        listOffres.Add(uneOffre);
                    }
                conn.Close();
            }
            return listOffres;
        }
        public static DateTime GetDateLimiteByOffre(int id_offre)
        {
            DateTime uneDate= new DateTime();
            using(var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT date_limite FROM offre_emplois WHERE id_offre="+id_offre, conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        uneDate = reader.GetDateTime(0);
                       
                    }
                conn.Close();

            }

            return uneDate;
        }
    }
}
