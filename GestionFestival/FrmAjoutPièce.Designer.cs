
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
            this.Btnretour = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.BtnAjout = new System.Windows.Forms.Button();
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
            // Btnretour
            // 
            this.Btnretour.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Btnretour.FlatAppearance.BorderSize = 2;
            this.Btnretour.Location = new System.Drawing.Point(425, 454);
            this.Btnretour.Margin = new System.Windows.Forms.Padding(4);
            this.Btnretour.Name = "Btnretour";
            this.Btnretour.Size = new System.Drawing.Size(177, 47);
            this.Btnretour.TabIndex = 4;
            this.Btnretour.Text = "Revenir en arrière";
            this.Btnretour.UseVisualStyleBackColor = true;
            this.Btnretour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(139, 193);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(186, 23);
            this.txtNom.TabIndex = 5;
            // 
            // BtnAjout
            // 
            this.BtnAjout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnAjout.FlatAppearance.BorderSize = 2;
            this.BtnAjout.Location = new System.Drawing.Point(425, 400);
            this.BtnAjout.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(177, 47);
            this.BtnAjout.TabIndex = 10;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // txtDuree
            // 
            this.txtDuree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuree.Location = new System.Drawing.Point(632, 193);
            this.txtDuree.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(93, 23);
            this.txtDuree.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(391, 193);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(186, 23);
            this.txtDescription.TabIndex = 12;
            // 
            // lblTitreAjout
            // 
            this.lblTitreAjout.AutoSize = true;
            this.lblTitreAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAjout.Location = new System.Drawing.Point(189, 59);
            this.lblTitreAjout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreAjout.Name = "lblTitreAjout";
            this.lblTitreAjout.Size = new System.Drawing.Size(646, 58);
            this.lblTitreAjout.TabIndex = 15;
            this.lblTitreAjout.Text = "Ajout d\'une pièce de théâtre";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(213, 165);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(53, 25);
            this.lblNom.TabIndex = 16;
            this.lblNom.Text = "Nom";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(425, 153);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(109, 25);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.Location = new System.Drawing.Point(261, 279);
            this.lblTheme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(74, 25);
            this.lblTheme.TabIndex = 18;
            this.lblTheme.Text = "Thème";
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuree.Location = new System.Drawing.Point(627, 153);
            this.lblDuree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(65, 25);
            this.lblDuree.TabIndex = 19;
            this.lblDuree.Text = "Durée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Public visé";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuteur.Location = new System.Drawing.Point(676, 279);
            this.lblAuteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(70, 25);
            this.lblAuteur.TabIndex = 23;
            this.lblAuteur.Text = "Auteur";
            // 
            // cmbThemes
            // 
            this.cmbThemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThemes.FormattingEnabled = true;
            this.cmbThemes.IntegralHeight = false;
            this.cmbThemes.ItemHeight = 17;
            this.cmbThemes.Location = new System.Drawing.Point(228, 308);
            this.cmbThemes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbThemes.MaximumSize = new System.Drawing.Size(165, 0);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.Size = new System.Drawing.Size(149, 25);
            this.cmbThemes.TabIndex = 24;
            // 
            // cmbAudience
            // 
            this.cmbAudience.FormattingEnabled = true;
            this.cmbAudience.Location = new System.Drawing.Point(441, 308);
            this.cmbAudience.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAudience.Name = "cmbAudience";
            this.cmbAudience.Size = new System.Drawing.Size(140, 24);
            this.cmbAudience.TabIndex = 25;
            // 
            // cmbAuteur
            // 
            this.cmbAuteur.FormattingEnabled = true;
            this.cmbAuteur.Location = new System.Drawing.Point(648, 308);
            this.cmbAuteur.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAuteur.Name = "cmbAuteur";
            this.cmbAuteur.Size = new System.Drawing.Size(143, 24);
            this.cmbAuteur.TabIndex = 26;
            // 
            // txtPrix
            // 
            this.txtPrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.Location = new System.Drawing.Point(792, 193);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(86, 23);
            this.txtPrix.TabIndex = 27;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(812, 153);
            this.lblPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(45, 25);
            this.lblPrix.TabIndex = 28;
            this.lblPrix.Text = "Prix";
            // 
            // lblErreurNom
            // 
            this.lblErreurNom.AutoSize = true;
            this.lblErreurNom.ForeColor = System.Drawing.Color.Red;
            this.lblErreurNom.Location = new System.Drawing.Point(153, 231);
            this.lblErreurNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreurNom.Name = "lblErreurNom";
            this.lblErreurNom.Size = new System.Drawing.Size(147, 16);
            this.lblErreurNom.TabIndex = 29;
            this.lblErreurNom.Text = "Le nom est obligatoire *";
            this.lblErreurNom.Visible = false;
            // 
            // lblErreurDescription
            // 
            this.lblErreurDescription.AutoSize = true;
            this.lblErreurDescription.ForeColor = System.Drawing.Color.Red;
            this.lblErreurDescription.Location = new System.Drawing.Point(387, 231);
            this.lblErreurDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreurDescription.Name = "lblErreurDescription";
            this.lblErreurDescription.Size = new System.Drawing.Size(187, 16);
            this.lblErreurDescription.TabIndex = 30;
            this.lblErreurDescription.Text = "La description est obligatoire *";
            this.lblErreurDescription.Visible = false;
            // 
            // lblErreurAuteur
            // 
            this.lblErreurAuteur.AutoSize = true;
            this.lblErreurAuteur.ForeColor = System.Drawing.Color.Red;
            this.lblErreurAuteur.Location = new System.Drawing.Point(644, 353);
            this.lblErreurAuteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreurAuteur.Name = "lblErreurAuteur";
            this.lblErreurAuteur.Size = new System.Drawing.Size(150, 16);
            this.lblErreurAuteur.TabIndex = 31;
            this.lblErreurAuteur.Text = "L\'auteur est obligatoire *";
            this.lblErreurAuteur.Visible = false;
            // 
            // lblErreurAudience
            // 
            this.lblErreurAudience.AutoSize = true;
            this.lblErreurAudience.ForeColor = System.Drawing.Color.Red;
            this.lblErreurAudience.Location = new System.Drawing.Point(425, 353);
            this.lblErreurAudience.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreurAudience.Name = "lblErreurAudience";
            this.lblErreurAudience.Size = new System.Drawing.Size(169, 16);
            this.lblErreurAudience.TabIndex = 32;
            this.lblErreurAudience.Text = "L\'audience est obligatoire *";
            this.lblErreurAudience.Visible = false;
            // 
            // lblErreurDuree
            // 
            this.lblErreurDuree.AutoSize = true;
            this.lblErreurDuree.ForeColor = System.Drawing.Color.Red;
            this.lblErreurDuree.Location = new System.Drawing.Point(604, 231);
            this.lblErreurDuree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreurDuree.Name = "lblErreurDuree";
            this.lblErreurDuree.Size = new System.Drawing.Size(156, 16);
            this.lblErreurDuree.TabIndex = 33;
            this.lblErreurDuree.Text = "La durée est obligatoire *";
            this.lblErreurDuree.Visible = false;
            // 
            // lblErreurPrix
            // 
            this.lblErreurPrix.AutoSize = true;
            this.lblErreurPrix.ForeColor = System.Drawing.Color.Red;
            this.lblErreurPrix.Location = new System.Drawing.Point(777, 231);
            this.lblErreurPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreurPrix.Name = "lblErreurPrix";
            this.lblErreurPrix.Size = new System.Drawing.Size(142, 16);
            this.lblErreurPrix.TabIndex = 34;
            this.lblErreurPrix.Text = "Le prix est obligatoire *";
            this.lblErreurPrix.Visible = false;
            // 
            // lblErreurTheme
            // 
            this.lblErreurTheme.AutoSize = true;
            this.lblErreurTheme.ForeColor = System.Drawing.Color.Red;
            this.lblErreurTheme.Location = new System.Drawing.Point(224, 353);
            this.lblErreurTheme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreurTheme.Name = "lblErreurTheme";
            this.lblErreurTheme.Size = new System.Drawing.Size(158, 16);
            this.lblErreurTheme.TabIndex = 35;
            this.lblErreurTheme.Text = "Le thème est obligatoire *";
            this.lblErreurTheme.Visible = false;
            // 
            // FrmAjoutPièce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.Btnretour);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAjoutPièce";
            this.Text = "FrmAjoutpièce";
            this.Load += new System.EventHandler(this.FrmAjoutPièce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnretour;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button BtnAjout;
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