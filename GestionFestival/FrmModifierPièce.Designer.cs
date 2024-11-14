
namespace GestionFestival
{
    partial class FrmModifierPièce
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
            this.btnretour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnretour
            // 
            this.btnretour.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnretour.FlatAppearance.BorderSize = 2;
            this.btnretour.Location = new System.Drawing.Point(319, 284);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(133, 38);
            this.btnretour.TabIndex = 4;
            this.btnretour.Text = "Revenir en arrière";
            this.btnretour.UseVisualStyleBackColor = true;
            this.btnretour.Click += new System.EventHandler(this.btnretour_Click);
            // 
            // FrmModifierPièce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnretour);
            this.Name = "FrmModifierPièce";
            this.Text = "FrmModifierPièce";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnretour;
    }
}