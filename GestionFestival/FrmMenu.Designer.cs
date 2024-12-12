namespace GestionFestival
{
    partial class FrmMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnPiece = new System.Windows.Forms.Button();
            this.btnRepresentations = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnSynthese = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.lblAccueil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPiece
            // 
            this.btnPiece.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPiece.Location = new System.Drawing.Point(53, 194);
            this.btnPiece.Name = "btnPiece";
            this.btnPiece.Size = new System.Drawing.Size(137, 34);
            this.btnPiece.TabIndex = 0;
            this.btnPiece.Text = "Pièces de théâtre";
            this.btnPiece.UseVisualStyleBackColor = true;
            this.btnPiece.Click += new System.EventHandler(this.btnPiece_Click);
            // 
            // btnRepresentations
            // 
            this.btnRepresentations.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRepresentations.Location = new System.Drawing.Point(243, 195);
            this.btnRepresentations.Name = "btnRepresentations";
            this.btnRepresentations.Size = new System.Drawing.Size(137, 34);
            this.btnRepresentations.TabIndex = 1;
            this.btnRepresentations.Text = "Représentations";
            this.btnRepresentations.UseVisualStyleBackColor = true;
            this.btnRepresentations.Click += new System.EventHandler(this.btnRepresentations_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnReservations.Location = new System.Drawing.Point(426, 194);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(137, 34);
            this.btnReservations.TabIndex = 2;
            this.btnReservations.Text = "Réservations";
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnSynthese
            // 
            this.btnSynthese.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSynthese.Location = new System.Drawing.Point(603, 195);
            this.btnSynthese.Name = "btnSynthese";
            this.btnSynthese.Size = new System.Drawing.Size(137, 35);
            this.btnSynthese.TabIndex = 3;
            this.btnSynthese.Text = "Synthèse";
            this.btnSynthese.UseVisualStyleBackColor = true;
            this.btnSynthese.Click += new System.EventHandler(this.btnSynthese_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeconnexion.Location = new System.Drawing.Point(324, 296);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(137, 34);
            this.btnDeconnexion.TabIndex = 4;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // lblAccueil
            // 
            this.lblAccueil.AutoSize = true;
            this.lblAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueil.Location = new System.Drawing.Point(316, 99);
            this.lblAccueil.Name = "lblAccueil";
            this.lblAccueil.Size = new System.Drawing.Size(151, 46);
            this.lblAccueil.TabIndex = 9;
            this.lblAccueil.Text = "Accueil";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAccueil);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnSynthese);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnRepresentations);
            this.Controls.Add(this.btnPiece);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPiece;
        private System.Windows.Forms.Button btnRepresentations;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnSynthese;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Label lblAccueil;
    }
}
