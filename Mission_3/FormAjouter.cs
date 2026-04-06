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

        // Au chargement du formulaire
        private void FormAjouter_Load(object sender, EventArgs e)
        {
            ChargerFamilles();
        }

        // Remplit le ComboBox avec les familles de médicaments
        private void ChargerFamilles()
        {
            var familles = mesDonnees.familles
                .OrderBy(f => f.libelle)
                .Select(f => new { Affichage = f.libelle, LaValeur = f.id })
                .ToList();

            comboBoxFamille.DataSource = familles;
            comboBoxFamille.DisplayMember = "Affichage";
            comboBoxFamille.ValueMember = "LaValeur";
            comboBoxFamille.SelectedIndex = -1;
        }

        // Génère un ID unique : DOLIPRANE → DOLIPRANE1, DOLIPRANE2...
        private string GenererIdUnique(string nom)
        {
            int compteur = 1;
            string id;

            do
            {
                id = nom + compteur;
                compteur++;
            }
            while (mesDonnees.medicaments.Any(m => m.id == id));

            return id;
        }

        // Retourne un message d'erreur si un champ est vide, sinon null
        private string ValiderChamps()
        {
            if (comboBoxFamille.SelectedValue == null) return "Veuillez sélectionner une famille.";
            if (string.IsNullOrWhiteSpace(txtNomMedicament.Text)) return "Veuillez saisir un nom.";
            if (string.IsNullOrWhiteSpace(txtComposition.Text)) return "Veuillez saisir la composition.";
            if (string.IsNullOrWhiteSpace(txtEffets.Text)) return "Veuillez saisir les effets.";
            if (string.IsNullOrWhiteSpace(txtContreIndications.Text)) return "Veuillez saisir les contre-indications.";
            return null;
        }

        // Vide tous les champs après un ajout réussi
        private void ReinitialisierFormulaire()
        {
            comboBoxFamille.SelectedIndex = -1;
            txtNomMedicament.Text = "";
            txtComposition.Text = "";
            txtEffets.Text = "";
            txtContreIndications.Text = "";
        }

        // Clic sur le bouton "Ajouter"
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // 1. Validation des champs
            string erreur = ValiderChamps();
            if (erreur != null)
            {
                MessageBox.Show(erreur, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nom = txtNomMedicament.Text.Trim().ToUpper();

            // 2. Vérifier que le médicament n'existe pas déjà
            if (mesDonnees.medicaments.Any(m => m.nomCommercial == nom))
            {
                MessageBox.Show("Ce médicament existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Créer et sauvegarder le médicament
            try
            {
                var medicament = new medicament
                {
                    id = GenererIdUnique(nom),
                    nomCommercial = nom,
                    idFamille = comboBoxFamille.SelectedValue.ToString(),
                    composition = txtComposition.Text.Trim(),
                    effets = txtEffets.Text.Trim(),
                    contreIndications = txtContreIndications.Text.Trim()
                };

                mesDonnees.medicaments.Add(medicament);
                mesDonnees.SaveChanges();

                MessageBox.Show("Médicament ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReinitialisierFormulaire();
            }
            catch (Exception ex)
            {
                string msg = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Erreur : " + msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}