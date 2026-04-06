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
    public partial class FormListeDons : Form
    {
        private gsbrapports2016Entities mesDonnees;
        public FormListeDons(gsbrapports2016Entities mesDonnees, string idmed)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;

            // Médicaments de la famille AVEC au moins un don, triés par nb de dons décroissant
            var listeFiltree = mesDonnees.medicaments
                .Where(m => m.idFamille == idmed && m.offrirs.Any())
                .Select(m => new
                {
                    m.id,
                    m.nomCommercial,
                    m.idFamille,
                    m.composition,
                    m.effets,
                    m.contreIndications,
                    NbreDons = m.offrirs.Count()
                })
                .OrderByDescending(m => m.NbreDons)
                .ToList();

            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = listeFiltree;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
