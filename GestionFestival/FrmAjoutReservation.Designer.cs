﻿
namespace GestionFestival
{
    partial class FrmAjoutReservation
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
            this.components = new System.ComponentModel.Container();
            this.lblReservation = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtNbPlace = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.cmbRepresentation = new System.Windows.Forms.ComboBox();
            this.cmbPiece = new System.Windows.Forms.ComboBox();
            this.txtTarifReservation = new System.Windows.Forms.TextBox();
            this.txtTarifPlace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPiece = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline);
            this.lblReservation.Location = new System.Drawing.Point(182, 74);
            this.lblReservation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(428, 46);
            this.lblReservation.TabIndex = 1;
            this.lblReservation.Text = "Ajout d\'une réservation";
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(318, 333);
            this.btnAjout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(133, 38);
            this.btnAjout.TabIndex = 6;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(318, 385);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(133, 38);
            this.btnRetour.TabIndex = 7;
            this.btnRetour.Text = "Revenir en arrière";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(61, 176);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(102, 20);
            this.txtNom.TabIndex = 8;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(177, 176);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(101, 20);
            this.txtPrenom.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(293, 176);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(500, 176);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(86, 20);
            this.txtTelephone.TabIndex = 11;
            // 
            // txtNbPlace
            // 
            this.txtNbPlace.Location = new System.Drawing.Point(599, 176);
            this.txtNbPlace.Margin = new System.Windows.Forms.Padding(2);
            this.txtNbPlace.Name = "txtNbPlace";
            this.txtNbPlace.Size = new System.Drawing.Size(130, 20);
            this.txtNbPlace.TabIndex = 12;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(94, 157);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 17);
            this.lblNom.TabIndex = 13;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(201, 157);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 17);
            this.lblPrenom.TabIndex = 14;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(368, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(518, 157);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(48, 17);
            this.lblTelephone.TabIndex = 16;
            this.lblTelephone.Text = "N° Tel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nb de places";
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
            this.grpDetails.Location = new System.Drawing.Point(89, 221);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(592, 107);
            this.grpDetails.TabIndex = 18;
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
            this.cmbRepresentation.SelectedIndexChanged += new System.EventHandler(this.cmbRepresentation_SelectedIndexChanged);
            // 
            // cmbPiece
            // 
            this.cmbPiece.FormattingEnabled = true;
            this.cmbPiece.Location = new System.Drawing.Point(126, 27);
            this.cmbPiece.Name = "cmbPiece";
            this.cmbPiece.Size = new System.Drawing.Size(121, 21);
            this.cmbPiece.TabIndex = 22;
            this.cmbPiece.SelectedIndexChanged += new System.EventHandler(this.cmbPiece_SelectedIndexChanged);
            // 
            // txtTarifReservation
            // 
            this.txtTarifReservation.Location = new System.Drawing.Point(453, 62);
            this.txtTarifReservation.Name = "txtTarifReservation";
            this.txtTarifReservation.ReadOnly = true;
            this.txtTarifReservation.Size = new System.Drawing.Size(100, 20);
            this.txtTarifReservation.TabIndex = 21;
            // 
            // txtTarifPlace
            // 
            this.txtTarifPlace.Location = new System.Drawing.Point(139, 62);
            this.txtTarifPlace.Name = "txtTarifPlace";
            this.txtTarifPlace.ReadOnly = true;
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmAjoutReservation
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
            this.Controls.Add(this.txtNbPlace);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.lblReservation);
            this.Name = "FrmAjoutReservation";
            this.Text = "Ajouter une réservation";
            this.Load += new System.EventHandler(this.FrmAjoutReservation_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnRetour;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtNbPlace;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPiece;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cmbRepresentation;
        private System.Windows.Forms.ComboBox cmbPiece;
        private System.Windows.Forms.TextBox txtTarifReservation;
        private System.Windows.Forms.TextBox txtTarifPlace;
    }
}