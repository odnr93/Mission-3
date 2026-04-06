namespace Mission_3
{
    partial class FormSelectionnerDons
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxDons = new System.Windows.Forms.ComboBox();
            this.ValiderDons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDons
            // 
            this.comboBoxDons.FormattingEnabled = true;
            this.comboBoxDons.Location = new System.Drawing.Point(191, 155);
            this.comboBoxDons.Name = "comboBoxDons";
            this.comboBoxDons.Size = new System.Drawing.Size(316, 24);
            this.comboBoxDons.TabIndex = 0;
            this.comboBoxDons.SelectedIndexChanged += new System.EventHandler(this.comboBoxDons_SelectedIndexChanged);
            // 
            // ValiderDons
            // 
            this.ValiderDons.Location = new System.Drawing.Point(318, 296);
            this.ValiderDons.Name = "ValiderDons";
            this.ValiderDons.Size = new System.Drawing.Size(75, 23);
            this.ValiderDons.TabIndex = 1;
            this.ValiderDons.Text = "Valider";
            this.ValiderDons.UseVisualStyleBackColor = true;
            this.ValiderDons.Click += new System.EventHandler(this.Valider_Click);
            // 
            // FormSelectionnerDons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ValiderDons);
            this.Controls.Add(this.comboBoxDons);
            this.Name = "FormSelectionnerDons";
            this.Text = "FormSelectionnerDons";
            this.Load += new System.EventHandler(this.FormSelectionnerDons_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDons;
        private System.Windows.Forms.Button ValiderDons;
    }
}