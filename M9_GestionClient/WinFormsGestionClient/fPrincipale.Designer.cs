
using System;

namespace WinFormsGestionClient
{
    partial class fPrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbRechercheClient = new System.Windows.Forms.TextBox();
            this.bNouveau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbRechercheClient
            // 
            this.tbRechercheClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRechercheClient.Location = new System.Drawing.Point(120, 8);
            this.tbRechercheClient.Name = "tbRechercheClient";
            this.tbRechercheClient.Size = new System.Drawing.Size(549, 23);
            this.tbRechercheClient.TabIndex = 0;
            this.tbRechercheClient.TextChanged += new System.EventHandler(this.tbRechercheClient_TextChanged);
            // 
            // bNouveau
            // 
            this.bNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bNouveau.Location = new System.Drawing.Point(675, 8);
            this.bNouveau.Name = "bNouveau";
            this.bNouveau.Size = new System.Drawing.Size(113, 23);
            this.bNouveau.TabIndex = 1;
            this.bNouveau.Text = "Nouveau";
            this.bNouveau.UseVisualStyleBackColor = true;
            this.bNouveau.Click += new System.EventHandler(this.bNouveau_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recherche clients:";
            // 
            // lbClients
            // 
            this.lbClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClients.FormattingEnabled = true;
            this.lbClients.ItemHeight = 15;
            this.lbClients.Location = new System.Drawing.Point(12, 36);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(776, 394);
            this.lbClients.TabIndex = 4;
            this.lbClients.DoubleClick += new System.EventHandler(this.lbClients_DoubleClick);
            // 
            // fPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bNouveau);
            this.Controls.Add(this.tbRechercheClient);
            this.Name = "fPrincipale";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox tbRechercheClient;
        private System.Windows.Forms.Button bNouveau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbClients;
    }
}

