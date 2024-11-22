
namespace GestionFestival
{
    partial class FrmGestionPièce
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
            this.BtnAjout = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnRetour = new System.Windows.Forms.Button();
            this.dtgPieces = new System.Windows.Forms.DataGridView();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAudience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPieces)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAjout
            // 
            this.BtnAjout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnAjout.FlatAppearance.BorderSize = 2;
            this.BtnAjout.Location = new System.Drawing.Point(175, 337);
            this.BtnAjout.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(177, 47);
            this.BtnAjout.TabIndex = 0;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnModifier.FlatAppearance.BorderSize = 2;
            this.BtnModifier.Location = new System.Drawing.Point(433, 337);
            this.BtnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(177, 47);
            this.BtnModifier.TabIndex = 1;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnSupprimer.FlatAppearance.BorderSize = 2;
            this.BtnSupprimer.Location = new System.Drawing.Point(679, 337);
            this.BtnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(177, 47);
            this.BtnSupprimer.TabIndex = 2;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnRetour
            // 
            this.BtnRetour.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnRetour.FlatAppearance.BorderSize = 2;
            this.BtnRetour.Location = new System.Drawing.Point(433, 414);
            this.BtnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(177, 47);
            this.BtnRetour.TabIndex = 3;
            this.BtnRetour.Text = "Revenir en arrière";
            this.BtnRetour.UseVisualStyleBackColor = true;
            this.BtnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // dtgPieces
            // 
            this.dtgPieces.BackgroundColor = System.Drawing.Color.White;
            this.dtgPieces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPieces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNom,
            this.colDescription,
            this.colTheme,
            this.colDuree,
            this.colAudience,
            this.colAuteur});
            this.dtgPieces.Location = new System.Drawing.Point(31, 144);
            this.dtgPieces.Margin = new System.Windows.Forms.Padding(4);
            this.dtgPieces.Name = "dtgPieces";
            this.dtgPieces.RowHeadersWidth = 51;
            this.dtgPieces.Size = new System.Drawing.Size(991, 164);
            this.dtgPieces.TabIndex = 4;
            // 
            // colNom
            // 
            this.colNom.HeaderText = "Nom";
            this.colNom.MinimumWidth = 6;
            this.colNom.Name = "colNom";
            this.colNom.Width = 125;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 6;
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 125;
            // 
            // colTheme
            // 
            this.colTheme.HeaderText = "Thème";
            this.colTheme.MinimumWidth = 6;
            this.colTheme.Name = "colTheme";
            this.colTheme.Width = 125;
            // 
            // colDuree
            // 
            this.colDuree.HeaderText = "Durée";
            this.colDuree.MinimumWidth = 6;
            this.colDuree.Name = "colDuree";
            this.colDuree.Width = 125;
            // 
            // colAudience
            // 
            this.colAudience.HeaderText = "Audience";
            this.colAudience.MinimumWidth = 6;
            this.colAudience.Name = "colAudience";
            this.colAudience.Width = 125;
            // 
            // colAuteur
            // 
            this.colAuteur.HeaderText = "Auteur";
            this.colAuteur.MinimumWidth = 6;
            this.colAuteur.Name = "colAuteur";
            this.colAuteur.Width = 125;
            // 
            // FrmGestionPièce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtgPieces);
            this.Controls.Add(this.BtnRetour);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.BtnAjout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionPièce";
            this.Text = "Gestion des pièces de théâtre";
            this.Load += new System.EventHandler(this.FrmGestionPièce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPieces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.DataGridView dtgPieces;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAudience;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuteur;
    }
}