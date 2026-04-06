using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mission_3
{
    public partial class FormSelectionnerDons : Form
    {
        private gsbrapports2016Entities mesDonnees = new gsbrapports2016Entities();
        public FormSelectionnerDons()
        {
            InitializeComponent();
        }

        private void comboBoxDons_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormSelectionnerDons_Load(object sender, EventArgs e)
        {
            var mesDonnees = new gsbrapports2016Entities();
            // 2. Récupération + Fusion
            // Rappel : Ici le 'var' est OBLIGATOIRE à cause du new { }
            var laListe = mesDonnees.familles
                .Select(f => new
                {
                    Affichage = f.libelle,
                    LaValeur = f.id
                })
                .ToList();
            // 3. Liaison
            this.comboBoxDons.DataSource = laListe;
            this.comboBoxDons.DisplayMember = "Affichage";
            this.comboBoxDons.ValueMember = "LaValeur";
        }



        private void Valider_Click(object sender, EventArgs e)
        {
            if (this.comboBoxDons.SelectedValue != null)
            {
                string idSelectionne = comboBoxDons.SelectedValue.ToString();
                //MessageBox.Show(this.comboBox1.SelectedValue.ToString());
                gsbrapports2016Entities mesDonnees = new gsbrapports2016Entities();
                FormListeDons form3 = new FormListeDons(mesDonnees, this.comboBoxDons.SelectedValue.ToString());
                form3.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
