namespace GestionFestival
{
    partial class FrmGestionRepresentation
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dtgRepresentations;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtHeure;
        private System.Windows.Forms.TextBox txtPlacesMax;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.TextBox txtPlayId;
        private System.Windows.Forms.TextBox txtPlayName;

        private void InitializeComponent()
        {
            this.dtgRepresentations = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtHeure = new System.Windows.Forms.TextBox();
            this.txtPlacesMax = new System.Windows.Forms.TextBox();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.txtPlayId = new System.Windows.Forms.TextBox();
            this.txtPlayName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRepresentations)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRepresentations
            // 
            this.dtgRepresentations.BackgroundColor = System.Drawing.Color.White;
            this.dtgRepresentations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRepresentations.Location = new System.Drawing.Point(31, 144);
            this.dtgRepresentations.Name = "dtgRepresentations";
            this.dtgRepresentations.RowHeadersWidth = 51;
            this.dtgRepresentations.Size = new System.Drawing.Size(991, 164);
            this.dtgRepresentations.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(31, 350);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(120, 350);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            // 
            // FrmGestionRepresentation
            // 
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtgRepresentations);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtHeure);
            this.Controls.Add(this.txtPlacesMax);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.txtPlayId);
            this.Controls.Add(this.txtPlayName);
            this.Name = "FrmGestionRepresentation";
            this.Text = "Gestion des Représentations";
            this.Load += new System.EventHandler(this.FrmGestionRepresentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRepresentations)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
