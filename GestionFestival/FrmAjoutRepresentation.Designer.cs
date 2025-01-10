namespace GestionFestival
{
    partial class FrmAjoutRepresentation
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.cmbPieces = new System.Windows.Forms.ComboBox();
            this.cmbRates = new System.Windows.Forms.ComboBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHeure = new System.Windows.Forms.TextBox();
            this.cmbLieu = new System.Windows.Forms.ComboBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(128, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout d\'une représentation";
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(480, 170);
            this.txtSeat.Margin = new System.Windows.Forms.Padding(2);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(86, 20);
            this.txtSeat.TabIndex = 2;
            // 
            // cmbPieces
            // 
            this.cmbPieces.FormattingEnabled = true;
            this.cmbPieces.Location = new System.Drawing.Point(61, 168);
            this.cmbPieces.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPieces.Name = "cmbPieces";
            this.cmbPieces.Size = new System.Drawing.Size(92, 21);
            this.cmbPieces.TabIndex = 3;
            // 
            // cmbRates
            // 
            this.cmbRates.FormattingEnabled = true;
            this.cmbRates.Location = new System.Drawing.Point(595, 170);
            this.cmbRates.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRates.Name = "cmbRates";
            this.cmbRates.Size = new System.Drawing.Size(92, 21);
            this.cmbRates.TabIndex = 4;
            this.cmbRates.SelectedIndexChanged += new System.EventHandler(this.cmbRates_SelectedIndexChanged);
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(303, 250);
            this.btnAjout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(133, 38);
            this.btnAjout.TabIndex = 5;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(303, 310);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(133, 38);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Text = "Revenir en arrière";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(168, 170);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(89, 20);
            this.dtpDate.TabIndex = 7;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Heure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lieu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Places Maximum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tarif";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pièce";
            // 
            // txtHeure
            // 
            this.txtHeure.Location = new System.Drawing.Point(272, 170);
            this.txtHeure.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeure.Name = "txtHeure";
            this.txtHeure.Size = new System.Drawing.Size(86, 20);
            this.txtHeure.TabIndex = 15;
            // 
            // cmbLieu
            // 
            this.cmbLieu.FormattingEnabled = true;
            this.cmbLieu.Location = new System.Drawing.Point(371, 170);
            this.cmbLieu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLieu.Name = "cmbLieu";
            this.cmbLieu.Size = new System.Drawing.Size(92, 21);
            this.cmbLieu.TabIndex = 16;
            this.cmbLieu.SelectedIndexChanged += new System.EventHandler(this.cmbLieu_SelectedIndexChanged);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(401, 202);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(0, 13);
            this.lblDistance.TabIndex = 17;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(359, 202);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(117, 13);
            this.lblPlace.TabIndex = 18;
            this.lblPlace.Text = "Aucun lieu sélectionner";
            // 
            // FrmAjoutRepresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.cmbLieu);
            this.Controls.Add(this.txtHeure);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.cmbRates);
            this.Controls.Add(this.cmbPieces);
            this.Controls.Add(this.txtSeat);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAjoutRepresentation";
            this.Text = "Ajouter une représentation";
            this.Load += new System.EventHandler(this.FrmAjoutRepresentation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.ComboBox cmbPieces;
        private System.Windows.Forms.ComboBox cmbRates;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHeure;
        private System.Windows.Forms.ComboBox cmbLieu;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblPlace;
    }
}