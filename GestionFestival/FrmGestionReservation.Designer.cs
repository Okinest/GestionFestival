
namespace GestionFestival
{
    partial class FrmGestionReservation
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
            this.dtgReservations = new System.Windows.Forms.DataGridView();
            this.NomPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRepresentation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LieuRepresentation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombrePlacesReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarifReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservations)).BeginInit();
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
            // dtgReservations
            // 
            this.dtgReservations.AllowUserToResizeColumns = false;
            this.dtgReservations.AllowUserToResizeRows = false;
            this.dtgReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReservations.BackgroundColor = System.Drawing.Color.White;
            this.dtgReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomPiece,
            this.DateRepresentation,
            this.LieuRepresentation,
            this.colNomReservation,
            this.colNombrePlacesReservation,
            this.colTarifReservation});
            this.dtgReservations.Location = new System.Drawing.Point(28, 132);
            this.dtgReservations.Margin = new System.Windows.Forms.Padding(4);
            this.dtgReservations.Name = "dtgReservations";
            this.dtgReservations.RowHeadersWidth = 51;
            this.dtgReservations.Size = new System.Drawing.Size(991, 164);
            this.dtgReservations.TabIndex = 5;
            // 
            // NomPiece
            // 
            this.NomPiece.HeaderText = "Pièce";
            this.NomPiece.MinimumWidth = 6;
            this.NomPiece.Name = "NomPiece";
            this.NomPiece.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NomPiece.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateRepresentation
            // 
            this.DateRepresentation.HeaderText = "Représentation";
            this.DateRepresentation.MinimumWidth = 6;
            this.DateRepresentation.Name = "DateRepresentation";
            // 
            // LieuRepresentation
            // 
            this.LieuRepresentation.HeaderText = "Lieu";
            this.LieuRepresentation.MinimumWidth = 6;
            this.LieuRepresentation.Name = "LieuRepresentation";
            // 
            // colNomReservation
            // 
            this.colNomReservation.HeaderText = "Nom";
            this.colNomReservation.MinimumWidth = 6;
            this.colNomReservation.Name = "colNomReservation";
            // 
            // colNombrePlacesReservation
            // 
            this.colNombrePlacesReservation.HeaderText = "Nombre de Places";
            this.colNombrePlacesReservation.MinimumWidth = 6;
            this.colNombrePlacesReservation.Name = "colNombrePlacesReservation";
            // 
            // colTarifReservation
            // 
            this.colTarifReservation.HeaderText = "Tarif";
            this.colTarifReservation.MinimumWidth = 6;
            this.colTarifReservation.Name = "colTarifReservation";
            // 
            // FrmGestionReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtgReservations);
            this.Controls.Add(this.BtnRetour);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.BtnAjout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionReservation";
            this.Text = "Gestion des réservations";
            this.Load += new System.EventHandler(this.FrmGestionReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.DataGridView dtgReservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPiece;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRepresentation;
        private System.Windows.Forms.DataGridViewTextBoxColumn LieuRepresentation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombrePlacesReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifReservation;
    }
}