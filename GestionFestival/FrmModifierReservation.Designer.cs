﻿
namespace GestionFestival
{
    partial class FrmModifierReservation
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
            this.lblReservation = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.cmbRepresentation = new System.Windows.Forms.ComboBox();
            this.cmbPiece = new System.Windows.Forms.ComboBox();
            this.txtTarifReservation = new System.Windows.Forms.TextBox();
            this.txtTarifPlace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPiece = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline);
            this.lblReservation.Location = new System.Drawing.Point(185, 75);
            this.lblReservation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(446, 46);
            this.lblReservation.TabIndex = 2;
            this.lblReservation.Text = "Modifier une réservation";
            this.lblReservation.Click += new System.EventHandler(this.lblReservation_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.cmbRepresentation);
            this.grpDetails.Controls.Add(this.cmbPiece);
            this.grpDetails.Controls.Add(this.txtTarifReservation);
            this.grpDetails.Controls.Add(this.txtTarifPlace);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.label3);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.lblPiece);
            this.grpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(94, 220);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(592, 107);
            this.grpDetails.TabIndex = 31;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Détails :";
            // 
            // cmbRepresentation
            // 
            this.cmbRepresentation.FormattingEnabled = true;
            this.cmbRepresentation.Location = new System.Drawing.Point(446, 27);
            this.cmbRepresentation.Name = "cmbRepresentation";
            this.cmbRepresentation.Size = new System.Drawing.Size(121, 21);
            this.cmbRepresentation.TabIndex = 23;
            // 
            // cmbPiece
            // 
            this.cmbPiece.FormattingEnabled = true;
            this.cmbPiece.Location = new System.Drawing.Point(126, 27);
            this.cmbPiece.Name = "cmbPiece";
            this.cmbPiece.Size = new System.Drawing.Size(121, 21);
            this.cmbPiece.TabIndex = 22;
            // 
            // txtTarifReservation
            // 
            this.txtTarifReservation.Location = new System.Drawing.Point(453, 62);
            this.txtTarifReservation.Name = "txtTarifReservation";
            this.txtTarifReservation.Size = new System.Drawing.Size(100, 20);
            this.txtTarifReservation.TabIndex = 21;
            // 
            // txtTarifPlace
            // 
            this.txtTarifPlace.Location = new System.Drawing.Point(139, 62);
            this.txtTarifPlace.Name = "txtTarifPlace";
            this.txtTarifPlace.Size = new System.Drawing.Size(100, 20);
            this.txtTarifPlace.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tarif réservation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Représentation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tarif par place :";
            // 
            // lblPiece
            // 
            this.lblPiece.AutoSize = true;
            this.lblPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiece.Location = new System.Drawing.Point(52, 30);
            this.lblPiece.Name = "lblPiece";
            this.lblPiece.Size = new System.Drawing.Size(40, 13);
            this.lblPiece.TabIndex = 14;
            this.lblPiece.Text = "Pièce :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nb de places";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(493, 160);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(48, 17);
            this.lblTelephone.TabIndex = 29;
            this.lblTelephone.Text = "N° Tel";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(362, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(217, 160);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 17);
            this.lblPrenom.TabIndex = 27;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(127, 160);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 17);
            this.lblNom.TabIndex = 26;
            this.lblNom.Text = "Nom";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(556, 179);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 20);
            this.textBox4.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(475, 179);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 20);
            this.textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 179);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 179);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 22;
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(94, 179);
            this.txtLieu.Margin = new System.Windows.Forms.Padding(2);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(102, 20);
            this.txtLieu.TabIndex = 21;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(323, 384);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(133, 38);
            this.btnRetour.TabIndex = 20;
            this.btnRetour.Text = "Revenir en arrière";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(323, 332);
            this.btnModif.Margin = new System.Windows.Forms.Padding(2);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(133, 38);
            this.btnModif.TabIndex = 19;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            // 
            // FrmModifierReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.lblReservation);
            this.Name = "FrmModifierReservation";
            this.Text = "Modifier une réservation";
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.ComboBox cmbRepresentation;
        private System.Windows.Forms.ComboBox cmbPiece;
        private System.Windows.Forms.TextBox txtTarifReservation;
        private System.Windows.Forms.TextBox txtTarifPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPiece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnModif;
    }
}