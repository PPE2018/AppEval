using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AppEval
{
    public static class DAOConnectOdoo
    {
        public static List<string> GetNomRH()
        {
            List<string> lesNoms = new List<string>();
            using (var conn = new NpgsqlConnection(Connexion.ConnectOdoo()))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT hr_employee.name FROM hr_employee INNER JOIN hr_department ON hr_employee.department_id = hr_department.id", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        lesNoms.Add(reader.GetString(0));
                    }
                conn.Close();
            }
            return lesNoms;
        }

        public static bool estDRH(string nomRH)
        {
            bool drh = false;
            int id_dep = 0;
            using (var conn = new NpgsqlConnection(Connexion.ConnectOdoo()))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT department_id FROM hr_employee WHERE name = '" + nomRH + "'", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        id_dep = reader.GetInt32(0);
                    }
                conn.Close();
                conn.Open();
                string nom_dep = "";
                using (var cmd = new NpgsqlCommand("SELECT name FROM hr_department WHERE id = " + id_dep, conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        nom_dep = reader.GetString(0);
                    }
                if (nom_dep == "DRH")
                {
                    drh = true;
                }
                conn.Close();
            }
            return drh;
        }
    }
}
