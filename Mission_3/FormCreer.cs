using System;
using System.Linq;
using System.Windows.Forms;

namespace Mission_3
{
    public partial class FormCreer : Form
    {
        private gsbrapports2016Entities mesDonnees = new gsbrapports2016Entities();

        public FormCreer()
        {
            InitializeComponent();
        }

        private void FormCreer_Load(object sender, EventArgs e)
        {
            // Rien à charger au démarrage
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validation ID
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Veuillez saisir un ID.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation libellé
            if (string.IsNullOrWhiteSpace(txtLibelle.Text))
            {
                MessageBox.Show("Veuillez saisir un libellé.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nouvelId = txtId.Text.Trim().ToUpper();

            // Vérifier que l'ID n'existe pas déjà
            bool idExiste = mesDonnees.familles.Any(f => f.id == nouvelId);
            if (idExiste)
            {
                MessageBox.Show("Cet ID existe déjà. Veuillez en choisir un autre.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var nouvelleFamille = new famille
                {
                    id = nouvelId,
                    libelle = txtLibelle.Text.Trim()
                };

                mesDonnees.familles.Add(nouvelleFamille);
                mesDonnees.SaveChanges();

                MessageBox.Show("Famille ajoutée avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtId.Text = "";
                txtLibelle.Text = "";
            }
            catch (Exception ex)
            {
                string msg = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Erreur : " + msg, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}