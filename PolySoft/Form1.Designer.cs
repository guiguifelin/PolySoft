namespace PolySoft
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPoly = new System.Windows.Forms.TabPage();
            this.buttonDeriver = new System.Windows.Forms.Button();
            this.textFonction = new System.Windows.Forms.TextBox();
            this.tabEtude = new System.Windows.Forms.TabPage();
            this.tabIntegration = new System.Windows.Forms.TabPage();
            this.tKNMCopyright2014ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPoly.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tKNMCopyright2014ToolStripMenuItem});
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPoly);
            this.tabControl1.Controls.Add(this.tabEtude);
            this.tabControl1.Controls.Add(this.tabIntegration);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 515);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPoly
            // 
            this.tabPoly.Controls.Add(this.buttonDeriver);
            this.tabPoly.Controls.Add(this.textFonction);
            this.tabPoly.Location = new System.Drawing.Point(4, 22);
            this.tabPoly.Name = "tabPoly";
            this.tabPoly.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoly.Size = new System.Drawing.Size(556, 489);
            this.tabPoly.TabIndex = 0;
            this.tabPoly.Text = "Polynome";
            this.tabPoly.UseVisualStyleBackColor = true;
            // 
            // buttonDeriver
            // 
            this.buttonDeriver.Location = new System.Drawing.Point(457, 4);
            this.buttonDeriver.Name = "buttonDeriver";
            this.buttonDeriver.Size = new System.Drawing.Size(91, 23);
            this.buttonDeriver.TabIndex = 1;
            this.buttonDeriver.Text = "Deriver";
            this.buttonDeriver.UseVisualStyleBackColor = true;
            this.buttonDeriver.Click += new System.EventHandler(this.buttonDeriver_Click);
            // 
            // textFonction
            // 
            this.textFonction.Location = new System.Drawing.Point(8, 6);
            this.textFonction.Name = "textFonction";
            this.textFonction.Size = new System.Drawing.Size(443, 20);
            this.textFonction.TabIndex = 0;
            // 
            // tabEtude
            // 
            this.tabEtude.Location = new System.Drawing.Point(4, 22);
            this.tabEtude.Name = "tabEtude";
            this.tabEtude.Padding = new System.Windows.Forms.Padding(3);
            this.tabEtude.Size = new System.Drawing.Size(556, 489);
            this.tabEtude.TabIndex = 1;
            this.tabEtude.Text = "Etude";
            this.tabEtude.UseVisualStyleBackColor = true;
            // 
            // tabIntegration
            // 
            this.tabIntegration.Location = new System.Drawing.Point(4, 22);
            this.tabIntegration.Name = "tabIntegration";
            this.tabIntegration.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntegration.Size = new System.Drawing.Size(556, 489);
            this.tabIntegration.TabIndex = 2;
            this.tabIntegration.Text = "Intégration";
            this.tabIntegration.UseVisualStyleBackColor = true;
            // 
            // tKNMCopyright2014ToolStripMenuItem
            // 
            this.tKNMCopyright2014ToolStripMenuItem.Name = "tKNMCopyright2014ToolStripMenuItem";
            this.tKNMCopyright2014ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.tKNMCopyright2014ToolStripMenuItem.Text = "TKNM Copyright 2014";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 542);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(580, 580);
            this.MinimumSize = new System.Drawing.Size(580, 580);
            this.Name = "Form1";
            this.Text = "PolySoft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPoly.ResumeLayout(false);
            this.tabPoly.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPoly;
        private System.Windows.Forms.Button buttonDeriver;
        private System.Windows.Forms.TextBox textFonction;
        private System.Windows.Forms.TabPage tabEtude;
        private System.Windows.Forms.TabPage tabIntegration;
        private System.Windows.Forms.ToolStripMenuItem tKNMCopyright2014ToolStripMenuItem;
    }
}

