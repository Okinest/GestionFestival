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
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNbPlace = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline);
            this.lblReservation.Location = new System.Drawing.Point(247, 92);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(563, 58);
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
            this.grpDetails.Location = new System.Drawing.Point(125, 271);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDetails.Size = new System.Drawing.Size(789, 132);
            this.grpDetails.TabIndex = 31;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Détails :";
            // 
            // cmbRepresentation
            // 
            this.cmbRepresentation.FormattingEnabled = true;
            this.cmbRepresentation.Location = new System.Drawing.Point(595, 33);
            this.cmbRepresentation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRepresentation.Name = "cmbRepresentation";
            this.cmbRepresentation.Size = new System.Drawing.Size(160, 25);
            this.cmbRepresentation.TabIndex = 23;
            this.cmbRepresentation.SelectedIndexChanged += new System.EventHandler(this.cmbRepresentation_SelectedIndexChanged);
            // 
            // cmbPiece
            // 
            this.cmbPiece.FormattingEnabled = true;
            this.cmbPiece.Location = new System.Drawing.Point(168, 33);
            this.cmbPiece.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPiece.Name = "cmbPiece";
            this.cmbPiece.Size = new System.Drawing.Size(160, 25);
            this.cmbPiece.TabIndex = 22;
            this.cmbPiece.SelectedIndexChanged += new System.EventHandler(this.cmbPiece_SelectedIndexChanged);
            // 
            // txtTarifReservation
            // 
            this.txtTarifReservation.Location = new System.Drawing.Point(604, 76);
            this.txtTarifReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTarifReservation.Name = "txtTarifReservation";
            this.txtTarifReservation.ReadOnly = true;
            this.txtTarifReservation.Size = new System.Drawing.Size(132, 23);
            this.txtTarifReservation.TabIndex = 21;
            // 
            // txtTarifPlace
            // 
            this.txtTarifPlace.Location = new System.Drawing.Point(185, 76);
            this.txtTarifPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTarifPlace.Name = "txtTarifPlace";
            this.txtTarifPlace.ReadOnly = true;
            this.txtTarifPlace.Size = new System.Drawing.Size(132, 23);
            this.txtTarifPlace.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tarif réservation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Représentation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tarif par place :";
            // 
            // lblPiece
            // 
            this.lblPiece.AutoSize = true;
            this.lblPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiece.Location = new System.Drawing.Point(69, 37);
            this.lblPiece.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPiece.Name = "lblPiece";
            this.lblPiece.Size = new System.Drawing.Size(51, 17);
            this.lblPiece.TabIndex = 14;
            this.lblPiece.Text = "Pièce :";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(431, 473);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(177, 47);
            this.btnRetour.TabIndex = 20;
            this.btnRetour.Text = "Revenir en arrière";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(431, 409);
            this.btnModif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(177, 47);
            this.btnModif.TabIndex = 19;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(813, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nb de places";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(687, 180);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(61, 22);
            this.lblTelephone.TabIndex = 32;
            this.lblTelephone.Text = "N° Tel";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(487, 180);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 22);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(264, 180);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(72, 22);
            this.lblPrenom.TabIndex = 30;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(121, 180);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 22);
            this.lblNom.TabIndex = 29;
            this.lblNom.Text = "Nom";
            // 
            // txtNbPlace
            // 
            this.txtNbPlace.Location = new System.Drawing.Point(795, 203);
            this.txtNbPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNbPlace.Name = "txtNbPlace";
            this.txtNbPlace.Size = new System.Drawing.Size(172, 22);
            this.txtNbPlace.TabIndex = 28;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(663, 203);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(113, 22);
            this.txtTelephone.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(387, 203);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 22);
            this.txtEmail.TabIndex = 26;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(232, 203);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(133, 22);
            this.txtPrenom.TabIndex = 25;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(77, 203);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(135, 22);
            this.txtNom.TabIndex = 24;
            // 
            // FrmModifierReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblReservation);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNbPlace);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtPrenom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNbPlace;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
    }
}