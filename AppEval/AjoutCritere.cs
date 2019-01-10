using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEval
{
    public partial class AjoutCritere : Form
    {
        public AjoutCritere()
        {
            InitializeComponent();
            Passerelle.Connexion();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            

            // Insert some data
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO data (some_field) VALUES (@p)";
                cmd.Parameters.AddWithValue("p", "Hello world");
                cmd.ExecuteNonQuery();
            }
        }
    }
}
