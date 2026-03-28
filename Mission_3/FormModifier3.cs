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
    public partial class FormModifier3 : Form
    {
        private gsbrapports2016Entities mesDonnees = new gsbrapports2016Entities();

        public FormModifier3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null) return;

            string idFamille = comboBox2.SelectedValue.ToString();

            try
            {
                // 1. Modifier le libellé de la famille
                var famille = mesDonnees.familles
                    .FirstOrDefault(f => f.id == idFamille);

                if (famille != null && !string.IsNullOrWhiteSpace(txtLibelle.Text))
                    famille.libelle = txtLibelle.Text;

                // 2. Modifier les médicaments depuis le DataGridView
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    string idMed = row.Cells["id"].Value?.ToString();
                    if (string.IsNullOrEmpty(idMed)) continue;

                    // ⚠️ On va chercher le VRAI objet suivi par Entity Framework
                    var med = mesDonnees.medicaments
                        .FirstOrDefault(m => m.id == idMed);

                    if (med != null)
                    {
                        // On écrase ses valeurs avec ce qui est dans le tableau
                        med.nomCommercial = row.Cells["nomCommercial"].Value?.ToString();
                        med.idFamille = row.Cells["idFamille"].Value?.ToString();
                        med.composition = row.Cells["composition"].Value?.ToString();
                        med.effets = row.Cells["effets"].Value?.ToString();
                        med.contreIndications = row.Cells["contreIndications"].Value?.ToString();
                    }
                }

                // 3. ✅ Envoie TOUT en base de données
                mesDonnees.SaveChanges();

                MessageBox.Show("Modifications enregistrées avec succès !",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null) return;

            string idFamille = comboBox2.SelectedValue.ToString();

            // Afficher le libellé actuel de la famille dans le TextBox
            var famille = mesDonnees.familles
                .FirstOrDefault(f => f.id == idFamille);

            if (famille != null)
                txtLibelle.Text = famille.libelle;

            // Charger les médicaments liés à cette famille
            var medsLies = mesDonnees.medicaments
                .Where(m => m.idFamille == idFamille)
                .Select(m => new MedicamentModif  // ← classe réelle, plus anonyme
                {
                    id = m.id,
                    nomCommercial = m.nomCommercial,
                    idFamille = m.idFamille,
                    composition = m.composition,
                    effets = m.effets,
                    contreIndications = m.contreIndications
                })
                .ToList();

            dataGridView1.DataSource = medsLies;

            // Rendre toutes les colonnes modifiables sauf ID
            dataGridView1.ReadOnly = false;  // ← débloquer
            dataGridView1.Columns["id"].ReadOnly = true;   // ← sauf l'ID
            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["nomCommercial"].HeaderText = "Nom Commercial";
            dataGridView1.Columns["idFamille"].HeaderText = "ID Famille";
            dataGridView1.Columns["composition"].HeaderText = "Composition";
            dataGridView1.Columns["effets"].HeaderText = "Effets";
            dataGridView1.Columns["contreIndications"].HeaderText = "Contre-indications";
        }

        private void FormModifier3_Load(object sender, EventArgs e)
        {
            var mesDonnees = new gsbrapports2016Entities();

            // 2. Récupération + Fusion
            // Rappel : Ici le 'var' est OBLIGATOIRE à cause du new { }
            var laListe = mesDonnees.familles
                .Select(f => new {
                    Affichage = f.libelle,
                    LaValeur = f.id
                })
                .ToList();

            // 3. Liaison
            this.comboBox2.DataSource = laListe;
            this.comboBox2.DisplayMember = "Affichage";
            this.comboBox2.ValueMember = "LaValeur";
        }

        public class MedicamentModif
        {
            public string id { get; set; }
            public string idFamille { get; set; }
            public string nomCommercial { get; set; }
            public string composition { get; set; }
            public string effets { get; set; }
            public string contreIndications { get; set; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
