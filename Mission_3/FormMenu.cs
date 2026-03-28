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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModifier3 formModifier = new FormModifier3();
            formModifier.Show();
        }

        private void selectionezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectionner formSelectionner = new FormSelectionner();
            formSelectionner.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupprimer formSupprimer = new FormSupprimer();
            formSupprimer.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouter formAjouter = new FormAjouter();
            formAjouter.Show();
        }

        private void creerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreer formCreer = new FormCreer();
            formCreer.Show();
        }
    }
}
