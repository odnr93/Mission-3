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
    public partial class FormSupprimer : Form
    {
        private gsbrapports2016Entities mesDonnees;

        public FormSupprimer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormSupprimer_Load(object sender, EventArgs e)
        {
            mesDonnees = new gsbrapports2016Entities();

            // Récupération des médicaments
            var laListe = mesDonnees.medicaments
                .Select(m => new {
                    Affichage = m.nomCommercial,
                    LaValeur = m.id
                })
                .ToList();

            // Liaison avec la ComboBox
            this.comboBox2.DataSource = laListe;
            this.comboBox2.DisplayMember = "Affichage";
            this.comboBox2.ValueMember = "LaValeur";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vérifier qu'un médicament est sélectionné
            if (comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un médicament.",
                    "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Demander confirmation avant suppression
            DialogResult reponse = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer le médicament : " + comboBox2.Text + " ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (reponse == DialogResult.Yes)
            {
                try
                {
                    // Récupérer l'id du médicament sélectionné
                    string idMedicament = comboBox2.SelectedValue.ToString();

                    // Trouver le médicament dans la base
                    var medicamentASupprimer = mesDonnees.medicaments
                        .FirstOrDefault(m => m.id == idMedicament);

                    if (medicamentASupprimer != null)
                    {
                        // Supprimer le médicament
                        mesDonnees.medicaments.Remove(medicamentASupprimer);
                        mesDonnees.SaveChanges();

                        MessageBox.Show("Médicament supprimé avec succès !",
                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Rafraîchir la ComboBox
                        var laListe = mesDonnees.medicaments
                            .Select(m => new {
                                Affichage = m.nomCommercial,
                                LaValeur = m.id
                            })
                            .ToList();

                        this.comboBox2.DataSource = laListe;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}