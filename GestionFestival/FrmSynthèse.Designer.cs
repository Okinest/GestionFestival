namespace GestionFestival
{
    partial class FrmSynthèse
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
            this.dtgSynthese = new System.Windows.Forms.DataGridView();
            this.colPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbRepresentation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbSpecTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbSpecMoyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaRéalise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaRealMoyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSynthese)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgSynthese
            // 
            this.dtgSynthese.AllowUserToResizeColumns = false;
            this.dtgSynthese.AllowUserToResizeRows = false;
            this.dtgSynthese.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSynthese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSynthese.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPiece,
            this.nbRepresentation,
            this.nbSpecTotal,
            this.nbSpecMoyen,
            this.CaRéalise,
            this.CaRealMoyen});
            this.dtgSynthese.Location = new System.Drawing.Point(63, 239);
            this.dtgSynthese.Name = "dtgSynthese";
            this.dtgSynthese.RowHeadersWidth = 51;
            this.dtgSynthese.RowTemplate.Height = 24;
            this.dtgSynthese.Size = new System.Drawing.Size(926, 202);
            this.dtgSynthese.TabIndex = 0;
            // 
            // colPiece
            // 
            this.colPiece.HeaderText = "Pièce";
            this.colPiece.MinimumWidth = 6;
            this.colPiece.Name = "colPiece";
            // 
            // nbRepresentation
            // 
            this.nbRepresentation.HeaderText = "Nb Représentation";
            this.nbRepresentation.MinimumWidth = 6;
            this.nbRepresentation.Name = "nbRepresentation";
            // 
            // nbSpecTotal
            // 
            this.nbSpecTotal.HeaderText = "Nb Spectateurs Total";
            this.nbSpecTotal.MinimumWidth = 6;
            this.nbSpecTotal.Name = "nbSpecTotal";
            // 
            // nbSpecMoyen
            // 
            this.nbSpecMoyen.HeaderText = "Nb Spectateur Moyen";
            this.nbSpecMoyen.MinimumWidth = 6;
            this.nbSpecMoyen.Name = "nbSpecMoyen";
            // 
            // CaRéalise
            // 
            this.CaRéalise.HeaderText = "CA Réalisé";
            this.CaRéalise.MinimumWidth = 6;
            this.CaRéalise.Name = "CaRéalise";
            // 
            // CaRealMoyen
            // 
            this.CaRealMoyen.HeaderText = "CA Réalisé Moyen";
            this.CaRealMoyen.MinimumWidth = 6;
            this.CaRealMoyen.Name = "CaRealMoyen";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(439, 478);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(177, 47);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Revenir en arrière";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(155, 33);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(150, 22);
            this.dtpStartDate.TabIndex = 9;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(390, 33);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(150, 22);
            this.dtpEndDate.TabIndex = 10;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(812, 48);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 23);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Filtrer";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "au";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "du";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpStartDate);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Location = new System.Drawing.Point(63, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 82);
            this.panel1.TabIndex = 16;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(696, 48);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmSynthèse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dtgSynthese);
            this.Name = "FrmSynthèse";
            this.Text = "FrmSynthèse";
            this.Load += new System.EventHandler(this.FrmSynthèse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSynthese)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgSynthese;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPiece;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbRepresentation;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbSpecTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbSpecMoyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaRéalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaRealMoyen;
        private System.Windows.Forms.Button btnReset;
    }
}