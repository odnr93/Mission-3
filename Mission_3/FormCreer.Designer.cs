namespace Mission_3
{
    partial class FormCreer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdSelectionne = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter une famille";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID de la famille :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Libellé de la famille :";
            // 
            // lblIdSelectionne
            // 
            this.lblIdSelectionne.AutoSize = true;
            this.lblIdSelectionne.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblIdSelectionne.Location = new System.Drawing.Point(44, 135);
            this.lblIdSelectionne.Name = "lblIdSelectionne";
            this.lblIdSelectionne.Size = new System.Drawing.Size(0, 16);
            this.lblIdSelectionne.TabIndex = 2;
            this.lblIdSelectionne.Visible = false;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(44, 190);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(280, 22);
            this.txtLibelle.TabIndex = 1;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(110, 240);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(150, 45);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(47, 108);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(277, 22);
            this.txtId.TabIndex = 4;
            // 
            // FormCreer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdSelectionne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.btnAjouter);
            this.Name = "FormCreer";
            this.Text = "Ajouter une famille";
            this.Load += new System.EventHandler(this.FormCreer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdSelectionne;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtId;
    }
}