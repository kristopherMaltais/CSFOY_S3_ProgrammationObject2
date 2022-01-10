
namespace WinFormsGestionClient
{
    partial class fSaisieClient
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
            this.lNom = new System.Windows.Forms.Label();
            this.lPrenom = new System.Windows.Forms.Label();
            this.tNomClient = new System.Windows.Forms.TextBox();
            this.tPrenomClient = new System.Windows.Forms.TextBox();
            this.bAnnulerClient = new System.Windows.Forms.Button();
            this.bEnregistrerClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(21, 13);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(37, 15);
            this.lNom.TabIndex = 0;
            this.lNom.Text = "Nom:";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.Location = new System.Drawing.Point(21, 47);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(52, 15);
            this.lPrenom.TabIndex = 1;
            this.lPrenom.Text = "Prénom:";
            // 
            // tNomClient
            // 
            this.tNomClient.Location = new System.Drawing.Point(79, 10);
            this.tNomClient.Name = "tNomClient";
            this.tNomClient.Size = new System.Drawing.Size(279, 23);
            this.tNomClient.TabIndex = 2;
            // 
            // tPrenomClient
            // 
            this.tPrenomClient.Location = new System.Drawing.Point(79, 39);
            this.tPrenomClient.Name = "tPrenomClient";
            this.tPrenomClient.Size = new System.Drawing.Size(279, 23);
            this.tPrenomClient.TabIndex = 3;
            // 
            // bAnnulerClient
            // 
            this.bAnnulerClient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAnnulerClient.Location = new System.Drawing.Point(187, 79);
            this.bAnnulerClient.Name = "bAnnulerClient";
            this.bAnnulerClient.Size = new System.Drawing.Size(75, 23);
            this.bAnnulerClient.TabIndex = 4;
            this.bAnnulerClient.Text = "Annuler";
            this.bAnnulerClient.UseVisualStyleBackColor = true;
            // 
            // bEnregistrerClient
            // 
            this.bEnregistrerClient.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bEnregistrerClient.Location = new System.Drawing.Point(283, 79);
            this.bEnregistrerClient.Name = "bEnregistrerClient";
            this.bEnregistrerClient.Size = new System.Drawing.Size(75, 23);
            this.bEnregistrerClient.TabIndex = 5;
            this.bEnregistrerClient.Text = "Enregistrer";
            this.bEnregistrerClient.UseVisualStyleBackColor = true;
            // 
            // fSaisieClient
            // 
            this.AcceptButton = this.bEnregistrerClient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bAnnulerClient;
            this.ClientSize = new System.Drawing.Size(393, 118);
            this.Controls.Add(this.bEnregistrerClient);
            this.Controls.Add(this.bAnnulerClient);
            this.Controls.Add(this.tPrenomClient);
            this.Controls.Add(this.tNomClient);
            this.Controls.Add(this.lPrenom);
            this.Controls.Add(this.lNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fSaisieClient";
            this.Text = "Saisie d\'un nouveau client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lPrenom;
        private System.Windows.Forms.TextBox tNomClient;
        private System.Windows.Forms.TextBox tPrenomClient;
        private System.Windows.Forms.Button bAnnulerClient;
        private System.Windows.Forms.Button bEnregistrerClient;
    }
}