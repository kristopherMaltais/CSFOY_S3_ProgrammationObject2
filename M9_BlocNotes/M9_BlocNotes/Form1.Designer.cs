
namespace M9_BlocNotes
{
    partial class Form1
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
            this.msMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTexte = new System.Windows.Forms.TextBox();
            this.msMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuPrincipal
            // 
            this.msMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNouveau,
            this.tsmiOuvrir,
            this.tsmiEnregistrer,
            this.tsmiEnregistrerSous,
            this.tsmiQuitter});
            this.msMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msMenuPrincipal.Name = "msMenuPrincipal";
            this.msMenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.msMenuPrincipal.TabIndex = 0;
            this.msMenuPrincipal.Text = "menuStrip1";
            // 
            // tsmiNouveau
            // 
            this.tsmiNouveau.Name = "tsmiNouveau";
            this.tsmiNouveau.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNouveau.Size = new System.Drawing.Size(67, 20);
            this.tsmiNouveau.Text = "Nouveau";
            this.tsmiNouveau.Click += new System.EventHandler(this.tsmiNouveau_Click);
            // 
            // tsmiOuvrir
            // 
            this.tsmiOuvrir.Name = "tsmiOuvrir";
            this.tsmiOuvrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOuvrir.Size = new System.Drawing.Size(52, 20);
            this.tsmiOuvrir.Text = "Ouvrir";
            this.tsmiOuvrir.Click += new System.EventHandler(this.tsmiOuvrir_Click);
            // 
            // tsmiEnregistrer
            // 
            this.tsmiEnregistrer.Name = "tsmiEnregistrer";
            this.tsmiEnregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiEnregistrer.Size = new System.Drawing.Size(75, 20);
            this.tsmiEnregistrer.Text = "Enregistrer";
            this.tsmiEnregistrer.Click += new System.EventHandler(this.tsmiEnregistrer_Click);
            // 
            // tsmiEnregistrerSous
            // 
            this.tsmiEnregistrerSous.Name = "tsmiEnregistrerSous";
            this.tsmiEnregistrerSous.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiEnregistrerSous.Size = new System.Drawing.Size(102, 20);
            this.tsmiEnregistrerSous.Text = "Enregistrer sous";
            this.tsmiEnregistrerSous.Click += new System.EventHandler(this.tsmiEnregistrerSous_Click);
            // 
            // tsmiQuitter
            // 
            this.tsmiQuitter.Name = "tsmiQuitter";
            this.tsmiQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F4)));
            this.tsmiQuitter.Size = new System.Drawing.Size(56, 20);
            this.tsmiQuitter.Text = "Quitter";
            this.tsmiQuitter.Click += new System.EventHandler(this.tsmiQuitter_Click);
            // 
            // tbTexte
            // 
            this.tbTexte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTexte.Location = new System.Drawing.Point(12, 27);
            this.tbTexte.Multiline = true;
            this.tbTexte.Name = "tbTexte";
            this.tbTexte.Size = new System.Drawing.Size(776, 411);
            this.tbTexte.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTexte);
            this.Controls.Add(this.msMenuPrincipal);
            this.MainMenuStrip = this.msMenuPrincipal;
            this.Name = "Form1";
            this.Text = "Super bloc-notes";
            this.msMenuPrincipal.ResumeLayout(false);
            this.msMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiNouveau;
        private System.Windows.Forms.ToolStripMenuItem tsmiOuvrir;
        private System.Windows.Forms.ToolStripMenuItem tsmiEnregistrer;
        private System.Windows.Forms.ToolStripMenuItem tsmiEnregistrerSous;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuitter;
        private System.Windows.Forms.TextBox tbTexte;
    }
}

