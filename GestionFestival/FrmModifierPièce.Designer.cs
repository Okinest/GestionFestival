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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Thème";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Description";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(972, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Auteur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(822, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Audience";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Durée";
            // 
            // FrmModifierPièce
            // 
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
