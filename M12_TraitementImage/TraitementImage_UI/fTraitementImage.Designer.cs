
namespace TraitementImage_UI
{
    partial class fTraitementImage
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
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatut = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.lbSuiteTraitementsAAppliquer = new System.Windows.Forms.ListBox();
            this.pAppliquerSuiteTraitements = new System.Windows.Forms.Panel();
            this.bAppliquerSuiteTraitements = new System.Windows.Forms.Button();
            this.pControlSuiteTraitements = new System.Windows.Forms.Panel();
            this.bSupprimerTraitement = new System.Windows.Forms.Button();
            this.bAjouterTraitement = new System.Windows.Forms.Button();
            this.bSuiteTraitementsDeplacerBas = new System.Windows.Forms.Button();
            this.bSuiteTraitementsDeplacerHaut = new System.Windows.Forms.Button();
            this.cbTraitementAAjouter = new System.Windows.Forms.ComboBox();
            this.pCanvas = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.msPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pAppliquerSuiteTraitements.SuspendLayout();
            this.pControlSuiteTraitements.SuspendLayout();
            this.pCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFichier});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1646, 33);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tsmiFichier
            // 
            this.tsmiFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOuvrir});
            this.tsmiFichier.Name = "tsmiFichier";
            this.tsmiFichier.Size = new System.Drawing.Size(78, 29);
            this.tsmiFichier.Text = "Fichier";
            // 
            // tsmiOuvrir
            // 
            this.tsmiOuvrir.Name = "tsmiOuvrir";
            this.tsmiOuvrir.Size = new System.Drawing.Size(163, 34);
            this.tsmiOuvrir.Text = "Ouvrir";
            // 
            // ssStatut
            // 
            this.ssStatut.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssStatut.Location = new System.Drawing.Point(0, 946);
            this.ssStatut.Name = "ssStatut";
            this.ssStatut.Size = new System.Drawing.Size(1646, 22);
            this.ssStatut.TabIndex = 1;
            this.ssStatut.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.propertyGrid1);
            this.splitContainer1.Panel1.Controls.Add(this.lbSuiteTraitementsAAppliquer);
            this.splitContainer1.Panel1.Controls.Add(this.pAppliquerSuiteTraitements);
            this.splitContainer1.Panel1.Controls.Add(this.pControlSuiteTraitements);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pCanvas);
            this.splitContainer1.Size = new System.Drawing.Size(1646, 913);
            this.splitContainer1.SplitterDistance = 507;
            this.splitContainer1.TabIndex = 2;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(10, 482);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(490, 405);
            this.propertyGrid1.TabIndex = 3;
            // 
            // lbSuiteTraitementsAAppliquer
            // 
            this.lbSuiteTraitementsAAppliquer.FormattingEnabled = true;
            this.lbSuiteTraitementsAAppliquer.ItemHeight = 25;
            this.lbSuiteTraitementsAAppliquer.Location = new System.Drawing.Point(10, 174);
            this.lbSuiteTraitementsAAppliquer.Name = "lbSuiteTraitementsAAppliquer";
            this.lbSuiteTraitementsAAppliquer.Size = new System.Drawing.Size(490, 179);
            this.lbSuiteTraitementsAAppliquer.TabIndex = 2;
            // 
            // pAppliquerSuiteTraitements
            // 
            this.pAppliquerSuiteTraitements.Controls.Add(this.bAppliquerSuiteTraitements);
            this.pAppliquerSuiteTraitements.Location = new System.Drawing.Point(10, 359);
            this.pAppliquerSuiteTraitements.Name = "pAppliquerSuiteTraitements";
            this.pAppliquerSuiteTraitements.Size = new System.Drawing.Size(490, 117);
            this.pAppliquerSuiteTraitements.TabIndex = 1;
            // 
            // bAppliquerSuiteTraitements
            // 
            this.bAppliquerSuiteTraitements.Location = new System.Drawing.Point(3, 21);
            this.bAppliquerSuiteTraitements.Name = "bAppliquerSuiteTraitements";
            this.bAppliquerSuiteTraitements.Size = new System.Drawing.Size(484, 66);
            this.bAppliquerSuiteTraitements.TabIndex = 3;
            this.bAppliquerSuiteTraitements.Text = "Appliquer";
            this.bAppliquerSuiteTraitements.UseVisualStyleBackColor = true;
            // 
            // pControlSuiteTraitements
            // 
            this.pControlSuiteTraitements.Controls.Add(this.bSupprimerTraitement);
            this.pControlSuiteTraitements.Controls.Add(this.bAjouterTraitement);
            this.pControlSuiteTraitements.Controls.Add(this.bSuiteTraitementsDeplacerBas);
            this.pControlSuiteTraitements.Controls.Add(this.bSuiteTraitementsDeplacerHaut);
            this.pControlSuiteTraitements.Controls.Add(this.cbTraitementAAjouter);
            this.pControlSuiteTraitements.Location = new System.Drawing.Point(10, 3);
            this.pControlSuiteTraitements.Name = "pControlSuiteTraitements";
            this.pControlSuiteTraitements.Size = new System.Drawing.Size(490, 165);
            this.pControlSuiteTraitements.TabIndex = 0;
            // 
            // bSupprimerTraitement
            // 
            this.bSupprimerTraitement.Location = new System.Drawing.Point(375, 115);
            this.bSupprimerTraitement.Name = "bSupprimerTraitement";
            this.bSupprimerTraitement.Size = new System.Drawing.Size(112, 34);
            this.bSupprimerTraitement.TabIndex = 4;
            this.bSupprimerTraitement.Text = "-\r\n";
            this.bSupprimerTraitement.UseVisualStyleBackColor = true;
            // 
            // bAjouterTraitement
            // 
            this.bAjouterTraitement.Location = new System.Drawing.Point(375, 64);
            this.bAjouterTraitement.Name = "bAjouterTraitement";
            this.bAjouterTraitement.Size = new System.Drawing.Size(112, 34);
            this.bAjouterTraitement.TabIndex = 3;
            this.bAjouterTraitement.Text = "+\r\n";
            this.bAjouterTraitement.UseVisualStyleBackColor = true;
            // 
            // bSuiteTraitementsDeplacerBas
            // 
            this.bSuiteTraitementsDeplacerBas.Location = new System.Drawing.Point(3, 115);
            this.bSuiteTraitementsDeplacerBas.Name = "bSuiteTraitementsDeplacerBas";
            this.bSuiteTraitementsDeplacerBas.Size = new System.Drawing.Size(112, 34);
            this.bSuiteTraitementsDeplacerBas.TabIndex = 2;
            this.bSuiteTraitementsDeplacerBas.Text = "v\r\n";
            this.bSuiteTraitementsDeplacerBas.UseVisualStyleBackColor = true;
            // 
            // bSuiteTraitementsDeplacerHaut
            // 
            this.bSuiteTraitementsDeplacerHaut.Location = new System.Drawing.Point(3, 64);
            this.bSuiteTraitementsDeplacerHaut.Name = "bSuiteTraitementsDeplacerHaut";
            this.bSuiteTraitementsDeplacerHaut.Size = new System.Drawing.Size(112, 34);
            this.bSuiteTraitementsDeplacerHaut.TabIndex = 1;
            this.bSuiteTraitementsDeplacerHaut.Text = "^\r\n";
            this.bSuiteTraitementsDeplacerHaut.UseVisualStyleBackColor = true;
            // 
            // cbTraitementAAjouter
            // 
            this.cbTraitementAAjouter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTraitementAAjouter.FormattingEnabled = true;
            this.cbTraitementAAjouter.Location = new System.Drawing.Point(3, 13);
            this.cbTraitementAAjouter.Name = "cbTraitementAAjouter";
            this.cbTraitementAAjouter.Size = new System.Drawing.Size(484, 33);
            this.cbTraitementAAjouter.TabIndex = 0;
            // 
            // pCanvas
            // 
            this.pCanvas.Controls.Add(this.pbImage);
            this.pCanvas.Location = new System.Drawing.Point(3, 3);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.Size = new System.Drawing.Size(1125, 905);
            this.pCanvas.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(3, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(202, 110);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // fTraitementImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 968);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ssStatut);
            this.Controls.Add(this.msPrincipal);
            this.Name = "fTraitementImage";
            this.Text = "Traitement d\'image";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pAppliquerSuiteTraitements.ResumeLayout(false);
            this.pControlSuiteTraitements.ResumeLayout(false);
            this.pCanvas.ResumeLayout(false);
            this.pCanvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiFichier;
        private System.Windows.Forms.ToolStripMenuItem tsmiOuvrir;
        private System.Windows.Forms.StatusStrip ssStatut;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbSuiteTraitementsAAppliquer;
        private System.Windows.Forms.Panel pAppliquerSuiteTraitements;
        private System.Windows.Forms.Button bAppliquerSuiteTraitements;
        private System.Windows.Forms.Panel pControlSuiteTraitements;
        private System.Windows.Forms.ComboBox cbTraitementAAjouter;
        private System.Windows.Forms.Button bSuiteTraitementsDeplacerBas;
        private System.Windows.Forms.Button bSuiteTraitementsDeplacerHaut;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button bSupprimerTraitement;
        private System.Windows.Forms.Button bAjouterTraitement;
        private System.Windows.Forms.Panel pCanvas;
        private System.Windows.Forms.PictureBox pbImage;
    }
}

