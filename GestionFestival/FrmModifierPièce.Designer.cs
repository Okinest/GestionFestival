namespace GestionFestival
{
    partial class FrmModifierPièce
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.TextBox txtPrix;  // Nouvelle textbox pour le prix
        private System.Windows.Forms.ComboBox cmbAuteur;
        private System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.ComboBox cmbAudience;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();  // Initialisation du prix
            this.cmbAuteur = new System.Windows.Forms.ComboBox();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.cmbAudience = new System.Windows.Forms.ComboBox();

            // Form layout
            this.ClientSize = new System.Drawing.Size(600, 450);  // Augmenter la taille du formulaire pour le prix
            this.Name = "FrmModifierPièce";
            this.Text = "Modifier une pièce de théâtre";

            // Position des contrôles (alignement horizontal en ligne)
            int xStart = 50;
            int yStart = 50;
            int controlWidth = 80;
            int spacing = 120;

            // Étiquettes et TextBoxes en ligne
            string[] labels = { "Nom", "Description", "Durée", "Prix", "Thème", "Audience", "Auteur" }; // Ajout du prix
            System.Windows.Forms.TextBox[] textBoxes = { txtNom, txtDescription, txtDuree, txtPrix }; // Ajout du textbox pour le prix
            System.Windows.Forms.ComboBox[] comboBoxes = { cmbTheme, cmbAudience, cmbAuteur };

            for (int i = 0; i < labels.Length; i++)
            {
                var lbl = new System.Windows.Forms.Label();
                lbl.Text = labels[i];
                lbl.Location = new System.Drawing.Point(xStart + (i * spacing), yStart);
                lbl.Size = new System.Drawing.Size(controlWidth, 20);
                this.Controls.Add(lbl);

                if (i < textBoxes.Length)
                {
                    textBoxes[i].Location = new System.Drawing.Point(xStart + (i * spacing), yStart + 30);
                    textBoxes[i].Size = new System.Drawing.Size(controlWidth, 20);
                    this.Controls.Add(textBoxes[i]);
                }
                else
                {
                    comboBoxes[i - textBoxes.Length].Location = new System.Drawing.Point(xStart + (i * spacing), yStart + 30);
                    comboBoxes[i - textBoxes.Length].Size = new System.Drawing.Size(controlWidth, 20);
                    this.Controls.Add(comboBoxes[i - textBoxes.Length]);
                }
            }

            // Bouton Modifier
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Location = new System.Drawing.Point(250, 280);
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            this.Controls.Add(this.btnModifier);

            // Bouton Retour
            this.btnRetour.Text = "Revenir en arrière";
            this.btnRetour.Location = new System.Drawing.Point(250, 320);
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            this.Controls.Add(this.btnRetour);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
