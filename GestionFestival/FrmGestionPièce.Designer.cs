
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
            this.btnajout = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnretour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnajout
            // 
            this.btnajout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnajout.FlatAppearance.BorderSize = 2;
            this.btnajout.Location = new System.Drawing.Point(131, 274);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(133, 38);
            this.btnajout.TabIndex = 0;
            this.btnajout.Text = "Ajouter";
            this.btnajout.UseVisualStyleBackColor = true;
            // 
            // btnmodifier
            // 
            this.btnmodifier.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnmodifier.FlatAppearance.BorderSize = 2;
            this.btnmodifier.Location = new System.Drawing.Point(325, 274);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(133, 38);
            this.btnmodifier.TabIndex = 1;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnsupprimer.FlatAppearance.BorderSize = 2;
            this.btnsupprimer.Location = new System.Drawing.Point(509, 274);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(133, 38);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            // 
            // btnretour
            // 
            this.btnretour.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnretour.FlatAppearance.BorderSize = 2;
            this.btnretour.Location = new System.Drawing.Point(325, 336);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(133, 38);
            this.btnretour.TabIndex = 3;
            this.btnretour.Text = "Revenir en arrière";
            this.btnretour.UseVisualStyleBackColor = true;
            this.btnretour.Click += new System.EventHandler(this.btnretour_Click);
            // 
            // FrmGestionPièce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnajout);
            this.Name = "FrmGestionPièce";
            this.Text = "Gestion des pièces de théâtre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnajout;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnretour;
    }
}