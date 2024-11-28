namespace GestionFestival
{
    partial class FrmGestionRepresentation
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.DataGridView dtgRepresentations;

        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombrePlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRatePeriod;  // Nouvelle colonne

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
            this.BtnAjout = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnRetour = new System.Windows.Forms.Button();
            this.dtgRepresentations = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombrePlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRatePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRepresentations)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAjout
            // 
            this.BtnAjout.Location = new System.Drawing.Point(175, 337);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(177, 47);
            this.BtnAjout.TabIndex = 0;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(433, 337);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(177, 47);
            this.BtnModifier.TabIndex = 1;
            this.BtnModifier.Text = "Modifier";
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Location = new System.Drawing.Point(679, 337);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(177, 47);
            this.BtnSupprimer.TabIndex = 2;
            this.BtnSupprimer.Text = "Supprimer";
            // 
            // BtnRetour
            // 
            this.BtnRetour.Location = new System.Drawing.Point(433, 414);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(177, 47);
            this.BtnRetour.TabIndex = 3;
            this.BtnRetour.Text = "Revenir en arrière";
            this.BtnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // dtgRepresentations
            // 
            this.dtgRepresentations.BackgroundColor = System.Drawing.Color.White;
            this.dtgRepresentations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRepresentations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colHeure,
            this.colNombrePlaces,
            this.colLieu,
            this.colNom,
            this.colRatePeriod});
            this.dtgRepresentations.Location = new System.Drawing.Point(31, 144);
            this.dtgRepresentations.Name = "dtgRepresentations";
            this.dtgRepresentations.RowHeadersWidth = 51;
            this.dtgRepresentations.Size = new System.Drawing.Size(991, 164);
            this.dtgRepresentations.TabIndex = 4;
            // 
            // colDate
            // 
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.Width = 125;
            // 
            // colHeure
            // 
            this.colHeure.MinimumWidth = 6;
            this.colHeure.Name = "colHeure";
            this.colHeure.Width = 125;
            // 
            // colNombrePlaces
            // 
            this.colNombrePlaces.MinimumWidth = 6;
            this.colNombrePlaces.Name = "colNombrePlaces";
            this.colNombrePlaces.Width = 125;
            // 
            // colLieu
            // 
            this.colLieu.MinimumWidth = 6;
            this.colLieu.Name = "colLieu";
            this.colLieu.Width = 125;
            // 
            // colNom
            // 
            this.colNom.MinimumWidth = 6;
            this.colNom.Name = "colNom";
            this.colNom.Width = 125;
            // 
            // colRatePeriod
            // 
            this.colRatePeriod.MinimumWidth = 6;
            this.colRatePeriod.Name = "colRatePeriod";
            this.colRatePeriod.Width = 125;
            // 
            // FrmGestionRepresentation
            // 
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtgRepresentations);
            this.Controls.Add(this.BtnRetour);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.BtnAjout);
            this.Name = "FrmGestionRepresentation";
            this.Text = "Gestion des Représentations";
            this.Load += new System.EventHandler(this.FrmGestionRepresentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRepresentations)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
