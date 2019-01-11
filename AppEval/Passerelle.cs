using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AppEval
{
    public static class Passerelle
    {
        public static void AjoutCritere(Critere unCritere, Associer uneAssociation)
        {
            var connString = "Host=localhost;Port=4747;Username=openpg;Password=;Database=BddAppEval";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                // Insert some data
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO critere (id_critere, libelle_critere) VALUES (DEFAULT, '" + unCritere.GetLibelle() + "')";
                    cmd.ExecuteNonQuery();
                }

                int id = -1;
                using (var cmd2 = new NpgsqlCommand("SELECT id_critere FROM critere ORDER BY id_critere", conn))
                using (var reader = cmd2.ExecuteReader())
                while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                using (var cmd3 = new NpgsqlCommand())
                {
                    cmd3.Connection = conn;
                    //Id de l'offre à changer
                    cmd3.CommandText = "INSERT INTO associer (id_critere, id_offre, coefficient) VALUES ("+ id +", 1," + uneAssociation.GetCoeff() + ")";
                    cmd3.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public static List<Critere> GetLesCriteres()
        {
            List<Critere> listCritere = new List<Critere>();
            var connString = "Host=localhost;Port=4747;Username=openpg;Password=;Database=BddAppEval";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT libelle_critere, id_critere FROM critere", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Critere unCritere = new Critere(reader.GetString(0), reader.GetInt32(1));
                        listCritere.Add(unCritere);
                    }
                conn.Close();
            }
            return listCritere;
        }
    }
}
