
namespace ApplicationGraphique_Winform
{
    partial class fRevolutionLignes
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
            this.pControles = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nudPas = new System.Windows.Forms.NumericUpDown();
            this.nubNombreLigne = new System.Windows.Forms.NumericUpDown();
            this.nudLongueur = new System.Windows.Forms.NumericUpDown();
            this.nudAngle = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pCanvas = new System.Windows.Forms.Panel();
            this.pControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubNombreLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // pControles
            // 
            this.pControles.Controls.Add(this.button1);
            this.pControles.Controls.Add(this.nudPas);
            this.pControles.Controls.Add(this.nubNombreLigne);
            this.pControles.Controls.Add(this.nudLongueur);
            this.pControles.Controls.Add(this.nudAngle);
            this.pControles.Controls.Add(this.label4);
            this.pControles.Controls.Add(this.label3);
            this.pControles.Controls.Add(this.label2);
            this.pControles.Controls.Add(this.label1);
            this.pControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControles.Location = new System.Drawing.Point(0, 0);
            this.pControles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pControles.Name = "pControles";
            this.pControles.Size = new System.Drawing.Size(560, 35);
            this.pControles.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dessiner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudPas
            // 
            this.nudPas.Location = new System.Drawing.Point(426, 7);
            this.nudPas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudPas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPas.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudPas.Name = "nudPas";
            this.nudPas.Size = new System.Drawing.Size(43, 23);
            this.nudPas.TabIndex = 7;
            // 
            // nubNombreLigne
            // 
            this.nubNombreLigne.Location = new System.Drawing.Point(339, 7);
            this.nubNombreLigne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nubNombreLigne.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nubNombreLigne.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nubNombreLigne.Name = "nubNombreLigne";
            this.nubNombreLigne.Size = new System.Drawing.Size(47, 23);
            this.nubNombreLigne.TabIndex = 6;
            this.nubNombreLigne.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nudLongueur
            // 
            this.nudLongueur.Location = new System.Drawing.Point(164, 7);
            this.nudLongueur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudLongueur.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudLongueur.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLongueur.Name = "nudLongueur";
            this.nudLongueur.Size = new System.Drawing.Size(52, 23);
            this.nudLongueur.TabIndex = 5;
            this.nudLongueur.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudAngle
            // 
            this.nudAngle.Location = new System.Drawing.Point(45, 7);
            this.nudAngle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudAngle.Name = "nudAngle";
            this.nudAngle.Size = new System.Drawing.Size(48, 23);
            this.nudAngle.TabIndex = 4;
            this.nudAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de lignes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longueur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angle";
            // 
            // pCanvas
            // 
            this.pCanvas.BackColor = System.Drawing.Color.White;
            this.pCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCanvas.Location = new System.Drawing.Point(0, 35);
            this.pCanvas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.Size = new System.Drawing.Size(560, 249);
            this.pCanvas.TabIndex = 1;
            // 
            // fRevolutionLignes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 284);
            this.Controls.Add(this.pCanvas);
            this.Controls.Add(this.pControles);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(425, 323);
            this.Name = "fRevolutionLignes";
            this.Text = "Form1";
            this.pControles.ResumeLayout(false);
            this.pControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubNombreLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControles;
        private System.Windows.Forms.NumericUpDown nudPas;
        private System.Windows.Forms.NumericUpDown nubNombreLigne;
        private System.Windows.Forms.NumericUpDown nudLongueur;
        private System.Windows.Forms.NumericUpDown nudAngle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pCanvas;
    }
}

