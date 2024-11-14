
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAudience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompagnie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btnajout.Click += new System.EventHandler(this.btnajout_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNom,
            this.colDescription,
            this.colTheme,
            this.colDuree,
            this.colAudience,
            this.colCompagnie});
            this.dataGridView1.Location = new System.Drawing.Point(84, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 133);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colNom
            // 
            this.colNom.HeaderText = "Nom";
            this.colNom.Name = "colNom";
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colTheme
            // 
            this.colTheme.HeaderText = "Thème";
            this.colTheme.Name = "colTheme";
            // 
            // colDuree
            // 
            this.colDuree.HeaderText = "Durée";
            this.colDuree.Name = "colDuree";
            // 
            // colAudience
            // 
            this.colAudience.HeaderText = "Audience";
            this.colAudience.Name = "colAudience";
            // 
            // colCompagnie
            // 
            this.colCompagnie.HeaderText = "Compagnie";
            this.colCompagnie.Name = "colCompagnie";
            // 
            // FrmGestionPièce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnajout);
            this.Name = "FrmGestionPièce";
            this.Text = "Gestion des pièces de théâtre";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnajout;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAudience;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompagnie;
    }
}