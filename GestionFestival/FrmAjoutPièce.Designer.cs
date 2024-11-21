
namespace GestionFestival
{
    partial class FrmAjoutPièce
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
            this.btnretour = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblTitreAjout = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.cmbThemes = new System.Windows.Forms.ComboBox();
            this.cmbAudience = new System.Windows.Forms.ComboBox();
            this.cmbAuteur = new System.Windows.Forms.ComboBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblErreurNom = new System.Windows.Forms.Label();
            this.lblErreurDescription = new System.Windows.Forms.Label();
            this.lblErreurAuteur = new System.Windows.Forms.Label();
            this.lblErreurAudience = new System.Windows.Forms.Label();
            this.lblErreurDuree = new System.Windows.Forms.Label();
            this.lblErreurPrix = new System.Windows.Forms.Label();
            this.lblErreurTheme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnretour
            // 
            this.btnretour.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnretour.FlatAppearance.BorderSize = 2;
            this.btnretour.Location = new System.Drawing.Point(319, 369);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(133, 38);
            this.btnretour.TabIndex = 4;
            this.btnretour.Text = "Revenir en arrière";
            this.btnretour.UseVisualStyleBackColor = true;
            this.btnretour.Click += new System.EventHandler(this.btnretour_Click);
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(104, 157);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(140, 20);
            this.txtNom.TabIndex = 5;
            // 
            // btnAjout
            // 
            this.btnAjout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAjout.FlatAppearance.BorderSize = 2;
            this.btnAjout.Location = new System.Drawing.Point(319, 325);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(133, 38);
            this.btnAjout.TabIndex = 10;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDuree
            // 
            this.txtDuree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuree.Location = new System.Drawing.Point(474, 157);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(70, 20);
            this.txtDuree.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(293, 157);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(140, 20);
            this.txtDescription.TabIndex = 12;
            // 
            // lblTitreAjout
            // 
            this.lblTitreAjout.AutoSize = true;
            this.lblTitreAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAjout.Location = new System.Drawing.Point(142, 48);
            this.lblTitreAjout.Name = "lblTitreAjout";
            this.lblTitreAjout.Size = new System.Drawing.Size(517, 46);
            this.lblTitreAjout.TabIndex = 15;
            this.lblTitreAjout.Text = "Ajout d\'une pièce de théâtre";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(160, 134);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 16;
            this.lblNom.Text = "Nom";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(319, 124);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.Location = new System.Drawing.Point(196, 227);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(58, 20);
            this.lblTheme.TabIndex = 18;
            this.lblTheme.Text = "Thème";
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuree.Location = new System.Drawing.Point(470, 124);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(53, 20);
            this.lblDuree.TabIndex = 19;
            this.lblDuree.Text = "Durée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Public visé";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuteur.Location = new System.Drawing.Point(507, 227);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(57, 20);
            this.lblAuteur.TabIndex = 23;
            this.lblAuteur.Text = "Auteur";
            // 
            // cmbThemes
            // 
            this.cmbThemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThemes.FormattingEnabled = true;
            this.cmbThemes.ItemHeight = 13;
            this.cmbThemes.Location = new System.Drawing.Point(171, 250);
            this.cmbThemes.MaximumSize = new System.Drawing.Size(125, 0);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.Size = new System.Drawing.Size(113, 21);
            this.cmbThemes.TabIndex = 24;
            // 
            // cmbAudience
            // 
            this.cmbAudience.FormattingEnabled = true;
            this.cmbAudience.Location = new System.Drawing.Point(331, 250);
            this.cmbAudience.Name = "cmbAudience";
            this.cmbAudience.Size = new System.Drawing.Size(106, 21);
            this.cmbAudience.TabIndex = 25;
            // 
            // cmbAuteur
            // 
            this.cmbAuteur.FormattingEnabled = true;
            this.cmbAuteur.Location = new System.Drawing.Point(486, 250);
            this.cmbAuteur.Name = "cmbAuteur";
            this.cmbAuteur.Size = new System.Drawing.Size(108, 21);
            this.cmbAuteur.TabIndex = 26;
            // 
            // txtPrix
            // 
            this.txtPrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.Location = new System.Drawing.Point(594, 157);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(65, 20);
            this.txtPrix.TabIndex = 27;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(609, 124);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(34, 20);
            this.lblPrix.TabIndex = 28;
            this.lblPrix.Text = "Prix";
            // 
            // lblErreurNom
            // 
            this.lblErreurNom.AutoSize = true;
            this.lblErreurNom.ForeColor = System.Drawing.Color.Red;
            this.lblErreurNom.Location = new System.Drawing.Point(115, 188);
            this.lblErreurNom.Name = "lblErreurNom";
            this.lblErreurNom.Size = new System.Drawing.Size(117, 13);
            this.lblErreurNom.TabIndex = 29;
            this.lblErreurNom.Text = "Le nom est obligatoire *";
            this.lblErreurNom.Visible = false;
            // 
            // lblErreurDescription
            // 
            this.lblErreurDescription.AutoSize = true;
            this.lblErreurDescription.ForeColor = System.Drawing.Color.Red;
            this.lblErreurDescription.Location = new System.Drawing.Point(290, 188);
            this.lblErreurDescription.Name = "lblErreurDescription";
            this.lblErreurDescription.Size = new System.Drawing.Size(148, 13);
            this.lblErreurDescription.TabIndex = 30;
            this.lblErreurDescription.Text = "La description est obligatoire *";
            this.lblErreurDescription.Visible = false;
            // 
            // lblErreurAuteur
            // 
            this.lblErreurAuteur.AutoSize = true;
            this.lblErreurAuteur.ForeColor = System.Drawing.Color.Red;
            this.lblErreurAuteur.Location = new System.Drawing.Point(483, 287);
            this.lblErreurAuteur.Name = "lblErreurAuteur";
            this.lblErreurAuteur.Size = new System.Drawing.Size(120, 13);
            this.lblErreurAuteur.TabIndex = 31;
            this.lblErreurAuteur.Text = "L\'auteur est obligatoire *";
            this.lblErreurAuteur.Visible = false;
            // 
            // lblErreurAudience
            // 
            this.lblErreurAudience.AutoSize = true;
            this.lblErreurAudience.ForeColor = System.Drawing.Color.Red;
            this.lblErreurAudience.Location = new System.Drawing.Point(319, 287);
            this.lblErreurAudience.Name = "lblErreurAudience";
            this.lblErreurAudience.Size = new System.Drawing.Size(134, 13);
            this.lblErreurAudience.TabIndex = 32;
            this.lblErreurAudience.Text = "L\'audience est obligatoire *";
            this.lblErreurAudience.Visible = false;
            // 
            // lblErreurDuree
            // 
            this.lblErreurDuree.AutoSize = true;
            this.lblErreurDuree.ForeColor = System.Drawing.Color.Red;
            this.lblErreurDuree.Location = new System.Drawing.Point(453, 188);
            this.lblErreurDuree.Name = "lblErreurDuree";
            this.lblErreurDuree.Size = new System.Drawing.Size(124, 13);
            this.lblErreurDuree.TabIndex = 33;
            this.lblErreurDuree.Text = "La durée est obligatoire *";
            this.lblErreurDuree.Visible = false;
            // 
            // lblErreurPrix
            // 
            this.lblErreurPrix.AutoSize = true;
            this.lblErreurPrix.ForeColor = System.Drawing.Color.Red;
            this.lblErreurPrix.Location = new System.Drawing.Point(583, 188);
            this.lblErreurPrix.Name = "lblErreurPrix";
            this.lblErreurPrix.Size = new System.Drawing.Size(113, 13);
            this.lblErreurPrix.TabIndex = 34;
            this.lblErreurPrix.Text = "Le prix est obligatoire *";
            this.lblErreurPrix.Visible = false;
            // 
            // lblErreurTheme
            // 
            this.lblErreurTheme.AutoSize = true;
            this.lblErreurTheme.ForeColor = System.Drawing.Color.Red;
            this.lblErreurTheme.Location = new System.Drawing.Point(168, 287);
            this.lblErreurTheme.Name = "lblErreurTheme";
            this.lblErreurTheme.Size = new System.Drawing.Size(126, 13);
            this.lblErreurTheme.TabIndex = 35;
            this.lblErreurTheme.Text = "Le thème est obligatoire *";
            this.lblErreurTheme.Visible = false;
            // 
            // FrmAjoutPièce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErreurTheme);
            this.Controls.Add(this.lblErreurPrix);
            this.Controls.Add(this.lblErreurDuree);
            this.Controls.Add(this.lblErreurAudience);
            this.Controls.Add(this.lblErreurAuteur);
            this.Controls.Add(this.lblErreurDescription);
            this.Controls.Add(this.lblErreurNom);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.cmbAuteur);
            this.Controls.Add(this.cmbAudience);
            this.Controls.Add(this.cmbThemes);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblTitreAjout);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnretour);
            this.Name = "FrmAjoutPièce";
            this.Text = "FrmAjoutpièce";
            this.Load += new System.EventHandler(this.FrmAjoutPièce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblTitreAjout;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.ComboBox cmbThemes;
        private System.Windows.Forms.ComboBox cmbAudience;
        private System.Windows.Forms.ComboBox cmbAuteur;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblErreurNom;
        private System.Windows.Forms.Label lblErreurDescription;
        private System.Windows.Forms.Label lblErreurAuteur;
        private System.Windows.Forms.Label lblErreurAudience;
        private System.Windows.Forms.Label lblErreurDuree;
        private System.Windows.Forms.Label lblErreurPrix;
        private System.Windows.Forms.Label lblErreurTheme;
    }
}