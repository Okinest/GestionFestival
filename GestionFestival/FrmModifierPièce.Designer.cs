namespace GestionFestival
{
    partial class FrmModifierPièce
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.ComboBox cmbAuteur;
        private System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.ComboBox cmbAudience;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnRetour;

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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.cmbAuteur = new System.Windows.Forms.ComboBox();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.cmbAudience = new System.Windows.Forms.ComboBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(275, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modification d\'une pièce";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 200);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(114, 22);
            this.txtNom.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(161, 200);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(147, 22);
            this.txtDescription.TabIndex = 2;
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(643, 204);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(114, 22);
            this.txtDuree.TabIndex = 3;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(501, 202);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(114, 22);
            this.txtPrix.TabIndex = 4;
            // 
            // cmbAuteur
            // 
            this.cmbAuteur.FormattingEnabled = true;
            this.cmbAuteur.Location = new System.Drawing.Point(934, 202);
            this.cmbAuteur.Name = "cmbAuteur";
            this.cmbAuteur.Size = new System.Drawing.Size(121, 24);
            this.cmbAuteur.TabIndex = 5;
            // 
            // cmbTheme
            // 
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Location = new System.Drawing.Point(343, 200);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(121, 24);
            this.cmbTheme.TabIndex = 6;
            // 
            // cmbAudience
            // 
            this.cmbAudience.FormattingEnabled = true;
            this.cmbAudience.Location = new System.Drawing.Point(789, 202);
            this.cmbAudience.Name = "cmbAudience";
            this.cmbAudience.Size = new System.Drawing.Size(121, 24);
            this.cmbAudience.TabIndex = 7;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(429, 320);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(177, 47);
            this.btnModif.TabIndex = 8;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(429, 390);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(177, 47);
            this.btnRetour.TabIndex = 9;
            this.btnRetour.Text = "Revenir en arrière";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // FrmModifierPièce
            // 
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.cmbAudience);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.cmbAuteur);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Name = "FrmModifierPièce";
            this.Text = "Modifier une pièce de théâtre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
