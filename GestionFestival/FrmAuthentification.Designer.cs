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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUtilisteurs = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblinconnu = new System.Windows.Forms.Label();
            this.lblconnexion = new System.Windows.Forms.Label();
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
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsername.Location = new System.Drawing.Point(297, 151);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(181, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Location = new System.Drawing.Point(297, 245);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(181, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de passe";
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
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.ForeColor = System.Drawing.Color.Red;
            this.lblpassword.Location = new System.Drawing.Point(286, 268);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(195, 13);
            this.lblpassword.TabIndex = 6;
            this.lblpassword.Text = "Le champ mot de passe est obligatoire *";
            this.lblpassword.Visible = false;
            // 
            // lblinconnu
            // 
            this.lblinconnu.AutoSize = true;
            this.lblinconnu.ForeColor = System.Drawing.Color.Red;
            this.lblinconnu.Location = new System.Drawing.Point(266, 358);
            this.lblinconnu.Name = "lblinconnu";
            this.lblinconnu.Size = new System.Drawing.Size(256, 13);
            this.lblinconnu.TabIndex = 7;
            this.lblinconnu.Text = "Le nom d\'utilisateur ou le mot de passe est incorrecte";
            this.lblinconnu.Visible = false;
            // 
            // lblconnexion
            // 
            this.lblconnexion.AutoSize = true;
            this.lblconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconnexion.Location = new System.Drawing.Point(281, 59);
            this.lblconnexion.Name = "lblconnexion";
            this.lblconnexion.Size = new System.Drawing.Size(213, 46);
            this.lblconnexion.TabIndex = 8;
            this.lblconnexion.Text = "Connexion";
            this.lblconnexion.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 465);
            this.Controls.Add(this.lblconnexion);
            this.Controls.Add(this.lblinconnu);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblUtilisteurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
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
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUtilisteurs;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblinconnu;
        private System.Windows.Forms.Label lblconnexion;
    }
}

