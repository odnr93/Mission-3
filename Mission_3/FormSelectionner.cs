using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Mission_3
{
    public partial class FormSelectionner : Form
    {
        private gsbrapports2016Entities mesDonnees = new gsbrapports2016Entities();

        public FormSelectionner()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedValue != null)
            {
                string idSelectionne = comboBox1.SelectedValue.ToString();
                //MessageBox.Show(this.comboBox1.SelectedValue.ToString());
                gsbrapports2016Entities mesDonnees = new gsbrapports2016Entities();
                FrmListeMed form3 = new FrmListeMed( mesDonnees,this.comboBox1.SelectedValue.ToString());
                form3.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
            this.comboBox1.DataSource = laListe;
            this.comboBox1.DisplayMember = "Affichage";
            this.comboBox1.ValueMember = "LaValeur";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
