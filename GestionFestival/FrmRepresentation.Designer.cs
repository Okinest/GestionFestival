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
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtSearchPiece;
        private System.Windows.Forms.Button btnFilter;

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
            // Ajouter le contrôle DateTimePicker pour la date de début
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(31, 95);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(150, 22);
            this.dtpStartDate.TabIndex = 5;

            // Ajouter le contrôle DateTimePicker pour la date de fin
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(200, 95);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(150, 22);
            this.dtpEndDate.TabIndex = 6;

            // Ajouter le TextBox pour la recherche par pièce de théâtre
            this.txtSearchPiece = new System.Windows.Forms.TextBox();
            this.txtSearchPiece.Location = new System.Drawing.Point(375, 95);
            this.txtSearchPiece.Name = "txtSearchPiece";
            this.txtSearchPiece.Size = new System.Drawing.Size(150, 22);
            this.txtSearchPiece.TabIndex = 7;

            // Ajouter le bouton de filtrage
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnFilter.Location = new System.Drawing.Point(550, 94);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 23);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filtrer";
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);

            // Ajouter ces nouveaux contrôles au formulaire
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.txtSearchPiece);
            this.Controls.Add(this.btnFilter);
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
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Location = new System.Drawing.Point(679, 337);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(177, 47);
            this.BtnSupprimer.TabIndex = 2;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
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
            this.dtgRepresentations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRepresentations.Size = new System.Drawing.Size(991, 164);
            this.dtgRepresentations.TabIndex = 4;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDate.HeaderText = "colDate";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colHeure
            // 
            this.colHeure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHeure.HeaderText = "colHeure";
            this.colHeure.MinimumWidth = 6;
            this.colHeure.Name = "colHeure";
            this.colHeure.ReadOnly = true;
            this.colHeure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colNombrePlaces
            // 
            this.colNombrePlaces.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombrePlaces.HeaderText = "colNombrePlaces";
            this.colNombrePlaces.MinimumWidth = 6;
            this.colNombrePlaces.Name = "colNombrePlaces";
            this.colNombrePlaces.ReadOnly = true;
            this.colNombrePlaces.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colLieu
            // 
            this.colLieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLieu.HeaderText = "colLieu";
            this.colLieu.MinimumWidth = 6;
            this.colLieu.Name = "colLieu";
            this.colLieu.ReadOnly = true;
            this.colLieu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colNom
            // 
            this.colNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNom.HeaderText = "colNom";
            this.colNom.MinimumWidth = 6;
            this.colNom.Name = "colNom";
            this.colNom.ReadOnly = true;
            this.colNom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colRatePeriod
            // 
            this.colRatePeriod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRatePeriod.HeaderText = "colRatePeriod";
            this.colRatePeriod.MinimumWidth = 6;
            this.colRatePeriod.Name = "colRatePeriod";
            this.colRatePeriod.ReadOnly = true;
            this.colRatePeriod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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

        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombrePlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRatePeriod;
    }
}
