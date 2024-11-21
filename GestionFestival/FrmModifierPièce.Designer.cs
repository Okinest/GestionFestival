
namespace GestionFestival
{
    partial class FrmModifierPièce
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.ComboBox cmbAuteur;
        private System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.ComboBox cmbAudience;
        private System.Windows.Forms.Button btnEnregistrer;

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
            this.btnretour = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.cmbAuteur = new System.Windows.Forms.ComboBox();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.cmbAudience = new System.Windows.Forms.ComboBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnretour
            // 
            this.btnretour.Location = new System.Drawing.Point(10, 350);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(100, 30);
            this.btnretour.TabIndex = 0;
            this.btnretour.Text = "Retour";
            this.btnretour.UseVisualStyleBackColor = true;
            this.btnretour.Click += new System.EventHandler(this.btnretour_Click);

            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(150, 50);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 20);
            this.txtNom.TabIndex = 1;

            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 90);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 20);
            this.txtDescription.TabIndex = 2;

            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(150, 130);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(200, 20);
            this.txtDuree.TabIndex = 3;

            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(150, 170);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(200, 20);
            this.txtPrix.TabIndex = 4;

            // 
            // cmbAuteur
            // 
            this.cmbAuteur.FormattingEnabled = true;
            this.cmbAuteur.Location = new System.Drawing.Point(150, 210);
            this.cmbAuteur.Name = "cmbAuteur";
            this.cmbAuteur.Size = new System.Drawing.Size(200, 21);
            this.cmbAuteur.TabIndex = 5;

            // 
            // cmbTheme
            // 
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Location = new System.Drawing.Point(150, 250);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(200, 21);
            this.cmbTheme.TabIndex = 6;

            // 
            // cmbAudience
            // 
            this.cmbAudience.FormattingEnabled = true;
            this.cmbAudience.Location = new System.Drawing.Point(150, 290);
            this.cmbAudience.Name = "cmbAudience";
            this.cmbAudience.Size = new System.Drawing.Size(200, 21);
            this.cmbAudience.TabIndex = 7;

            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(150, 350);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(100, 30);
            this.btnEnregistrer.TabIndex = 8;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);

            // 
            // FrmModifierPièce
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.cmbAuteur);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.cmbAudience);
            this.Controls.Add(this.btnEnregistrer);
            this.Name = "FrmModifierPièce";
            this.Text = "Modifier une Pièce";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

