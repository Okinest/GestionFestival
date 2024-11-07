namespace GestionFestival
{
    partial class FrmAuthentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.Txtpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUtilisteurs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(322, 303);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(124, 38);
            this.btnConnexion.TabIndex = 0;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom d\'utilisateur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNom.Location = new System.Drawing.Point(297, 151);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(181, 20);
            this.txtNom.TabIndex = 2;
            // 
            // Txtpassword
            // 
            this.Txtpassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txtpassword.Location = new System.Drawing.Point(297, 245);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Size = new System.Drawing.Size(181, 20);
            this.Txtpassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de passe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUtilisteurs
            // 
            this.lblUtilisteurs.AutoSize = true;
            this.lblUtilisteurs.ForeColor = System.Drawing.Color.Red;
            this.lblUtilisteurs.Location = new System.Drawing.Point(305, 174);
            this.lblUtilisteurs.Name = "lblUtilisteurs";
            this.lblUtilisteurs.Size = new System.Drawing.Size(176, 13);
            this.lblUtilisteurs.TabIndex = 5;
            this.lblUtilisteurs.Text = "Le champ utilisateur est obligatoire *";
            this.lblUtilisteurs.Visible = false;
            this.lblUtilisteurs.Click += new System.EventHandler(this.lblUtilisteurs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(305, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Le champ utilisateur est obligatoire *";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(266, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Le nom d\'utilisateur ou le mot de passe est incorrecte";
            this.label4.Visible = false;
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 465);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUtilisteurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnexion);
            this.Name = "FrmAuthentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox Txtpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUtilisteurs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

