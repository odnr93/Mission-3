using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission_3
{
    public partial class FrmListeMed : Form
    {
        private gsbrapports2016Entities mesDonnees;
        public FrmListeMed(gsbrapports2016Entities mesDonnees,string idmed)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;

            var listeFiltree = mesDonnees.medicaments
                                         .Where(m => m.idFamille == idmed)
                                         .ToList();
            dataGridView1.DataSource = listeFiltree; 
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormModifier3 formModifier = new FormModifier3();
            formModifier.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSupprimer formSupprimer = new FormSupprimer();
            formSupprimer.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
