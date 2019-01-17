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
    public partial class Evaluation : Form
    {
        public Evaluation()
        {
            InitializeComponent();
            foreach(KeyValuePair<string, int> kvp in DAOCritere.GetCritereCoeff())
            {
                tableauEvaluation.Rows.Add(kvp.Key, kvp.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0; i < tableauEvaluation.RowCount; i++)
            {
                for (int n = 0; n < tableauEvaluation.ColumnCount; n++)
                {
                    Console.WriteLine(tableauEvaluation[n, i].Value);
                }
            }
        }
    }
}
