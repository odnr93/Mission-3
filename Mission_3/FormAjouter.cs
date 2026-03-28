using System;
using System.Linq;
using System.Windows.Forms;

namespace Mission_3
{
    public partial class FormAjouter : Form
    {
        private gsbrapports2016Entities mesDonnees = new gsbrapports2016Entities();

        public FormAjouter()
        {
            InitializeComponent();
        }

        private void FormAjouter_Load(object sender, EventArgs e)
        {
            ChargerFamilles();
        }

        private void ChargerFamilles()
        {
            var laListe = mesDonnees.familles
                .Select(f => new {
                    Affichage = f.libelle,  // affiche le nom de la famille
                    LaValeur = f.id        // id caché pour la BDD
                })
                .OrderBy(f => f.Affichage)
                .ToList();

            comboBoxFamille.DataSource = laListe;
            comboBoxFamille.DisplayMember = "Affichage";
            comboBoxFamille.ValueMember = "LaValeur";
            comboBoxFamille.SelectedIndex = -1;
        }

        private string GenererIdUnique(string nomMedicament)
        {
            // Prend le nom complet + un chiffre (ex: ADIMOL → ADIMOL1, ADIMOL2...)
            string base_id = nomMedicament.Trim().ToUpper();
            string nouvelId;
            int compteur = 1;

            do
            {
                nouvelId = base_id + compteur.ToString();
                compteur++;
            }
            while (mesDonnees.medicaments.Any(m => m.id == nouvelId));

            return nouvelId;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (comboBoxFamille.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une famille.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNomMedicament.Text))
            {
                MessageBox.Show("Veuillez saisir un nom de médicament.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtComposition.Text))
            {
                MessageBox.Show("Veuillez saisir la composition.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEffets.Text))
            {
                MessageBox.Show("Veuillez saisir les effets.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContreIndications.Text))
            {
                MessageBox.Show("Veuillez saisir les contre-indications.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomMedicament = txtNomMedicament.Text.Trim().ToUpper();

            // Vérifier que le nom n'existe pas déjà
            bool nomExiste = mesDonnees.medicaments.Any(m => m.nomCommercial == nomMedicament);
            if (nomExiste)
            {
                MessageBox.Show("Ce médicament existe déjà.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Génération automatique de l'ID (ex: ADIMOL → ADIMOL1)
                string nouvelId = GenererIdUnique(nomMedicament);

                var nouveauMedicament = new medicament
                {
                    id = nouvelId,
                    nomCommercial = nomMedicament,
                    idFamille = comboBoxFamille.SelectedValue.ToString(),
                    composition = txtComposition.Text.Trim(),
                    effets = txtEffets.Text.Trim(),
                    contreIndications = txtContreIndications.Text.Trim()
                };

                mesDonnees.medicaments.Add(nouveauMedicament);
                mesDonnees.SaveChanges();

                MessageBox.Show("Médicament ajouté avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                comboBoxFamille.SelectedIndex = -1;
                txtNomMedicament.Text = "";
                txtComposition.Text = "";
                txtEffets.Text = "";
                txtContreIndications.Text = "";
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                string erreurs = "";
                foreach (var eve in ex.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        erreurs += "Champ : " + ve.PropertyName + " → " + ve.ErrorMessage + "\n";
                    }
                }
                MessageBox.Show(erreurs, "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                string msg = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Erreur : " + msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}