namespace Mission_3
{
    partial class FormAjouter
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelFamille = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelComposition = new System.Windows.Forms.Label();
            this.labelEffets = new System.Windows.Forms.Label();
            this.labelContreIndic = new System.Windows.Forms.Label();
            this.comboBoxFamille = new System.Windows.Forms.ComboBox();
            this.txtNomMedicament = new System.Windows.Forms.TextBox();
            this.txtComposition = new System.Windows.Forms.TextBox();
            this.txtEffets = new System.Windows.Forms.TextBox();
            this.txtContreIndications = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTitre.Location = new System.Drawing.Point(150, 15);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(200, 23);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Ajouter un medicament";
            // 
            // labelFamille
            // 
            this.labelFamille.AutoSize = true;
            this.labelFamille.Location = new System.Drawing.Point(20, 60);
            this.labelFamille.Name = "labelFamille";
            this.labelFamille.Size = new System.Drawing.Size(57, 16);
            this.labelFamille.TabIndex = 1;
            this.labelFamille.Text = "Famille :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(20, 105);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(145, 16);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nouveau Medicament :";
            // 
            // labelComposition
            // 
            this.labelComposition.AutoSize = true;
            this.labelComposition.Location = new System.Drawing.Point(20, 150);
            this.labelComposition.Name = "labelComposition";
            this.labelComposition.Size = new System.Drawing.Size(88, 16);
            this.labelComposition.TabIndex = 3;
            this.labelComposition.Text = "Composition :";
            // 
            // labelEffets
            // 
            this.labelEffets.AutoSize = true;
            this.labelEffets.Location = new System.Drawing.Point(20, 220);
            this.labelEffets.Name = "labelEffets";
            this.labelEffets.Size = new System.Drawing.Size(46, 16);
            this.labelEffets.TabIndex = 4;
            this.labelEffets.Text = "Effets :";
            // 
            // labelContreIndic
            // 
            this.labelContreIndic.AutoSize = true;
            this.labelContreIndic.Location = new System.Drawing.Point(20, 290);
            this.labelContreIndic.Name = "labelContreIndic";
            this.labelContreIndic.Size = new System.Drawing.Size(120, 16);
            this.labelContreIndic.TabIndex = 5;
            this.labelContreIndic.Text = "Contre-indications :";
            // 
            // comboBoxFamille
            // 
            this.comboBoxFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFamille.FormattingEnabled = true;
            this.comboBoxFamille.Location = new System.Drawing.Point(180, 57);
            this.comboBoxFamille.Name = "comboBoxFamille";
            this.comboBoxFamille.Size = new System.Drawing.Size(220, 24);
            this.comboBoxFamille.TabIndex = 0;
            // 
            // txtNomMedicament
            // 
            this.txtNomMedicament.Location = new System.Drawing.Point(180, 102);
            this.txtNomMedicament.Name = "txtNomMedicament";
            this.txtNomMedicament.Size = new System.Drawing.Size(220, 22);
            this.txtNomMedicament.TabIndex = 1;
            // 
            // txtComposition
            // 
            this.txtComposition.Location = new System.Drawing.Point(180, 147);
            this.txtComposition.Multiline = true;
            this.txtComposition.Name = "txtComposition";
            this.txtComposition.Size = new System.Drawing.Size(220, 55);
            this.txtComposition.TabIndex = 2;
            // 
            // txtEffets
            // 
            this.txtEffets.Location = new System.Drawing.Point(180, 217);
            this.txtEffets.Multiline = true;
            this.txtEffets.Name = "txtEffets";
            this.txtEffets.Size = new System.Drawing.Size(220, 55);
            this.txtEffets.TabIndex = 3;
            // 
            // txtContreIndications
            // 
            this.txtContreIndications.Location = new System.Drawing.Point(180, 287);
            this.txtContreIndications.Multiline = true;
            this.txtContreIndications.Name = "txtContreIndications";
            this.txtContreIndications.Size = new System.Drawing.Size(220, 19);
            this.txtContreIndications.TabIndex = 4;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(175, 365);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 35);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 425);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.labelFamille);
            this.Controls.Add(this.comboBoxFamille);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.txtNomMedicament);
            this.Controls.Add(this.labelComposition);
            this.Controls.Add(this.txtComposition);
            this.Controls.Add(this.labelEffets);
            this.Controls.Add(this.txtEffets);
            this.Controls.Add(this.labelContreIndic);
            this.Controls.Add(this.txtContreIndications);
            this.Controls.Add(this.btnAjouter);
            this.Name = "FormAjouter";
            this.Text = "Ajouter";
            this.Load += new System.EventHandler(this.FormAjouter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelFamille;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelComposition;
        private System.Windows.Forms.Label labelEffets;
        private System.Windows.Forms.Label labelContreIndic;
        private System.Windows.Forms.ComboBox comboBoxFamille;
        private System.Windows.Forms.TextBox txtNomMedicament;
        private System.Windows.Forms.TextBox txtComposition;
        private System.Windows.Forms.TextBox txtEffets;
        private System.Windows.Forms.TextBox txtContreIndications;
        private System.Windows.Forms.Button btnAjouter;
    }
}