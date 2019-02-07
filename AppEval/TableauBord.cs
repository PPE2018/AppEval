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
    public partial class TableauBord : Form
    {
        int idCand;
        public TableauBord()
        {
            InitializeComponent();
            //foreach (KeyValuePair<string, double> c in DAOEvaluation.AfficherTableauBord(idCand))
            //{
            //    dataGridViewTableauBord.Rows.Add(c.Key, c.Value);

            //}
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void dataGridViewTableauBord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
