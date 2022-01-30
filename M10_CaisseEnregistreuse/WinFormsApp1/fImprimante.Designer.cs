
namespace WinFormsApp1
{
    partial class fImprimante
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
            this.tbImprimante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbImprimante
            // 
            this.tbImprimante.Location = new System.Drawing.Point(11, 12);
            this.tbImprimante.Multiline = true;
            this.tbImprimante.Name = "tbImprimante";
            this.tbImprimante.Size = new System.Drawing.Size(273, 426);
            this.tbImprimante.TabIndex = 0;
            // 
            // fImprimante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 450);
            this.Controls.Add(this.tbImprimante);
            this.Name = "fImprimante";
            this.Text = "Imprimante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbImprimante;
    }
}