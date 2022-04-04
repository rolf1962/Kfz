namespace Kfz.WinApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateiBeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenKostenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenFahrzeugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenKatalogeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenKatalogeFahrzeugartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenKatalogeFahrzeugherstellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenKatalogeKostenartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(507, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiBeendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.dateiToolStripMenuItem.Text = "&Datei";
            // 
            // dateiBeendenToolStripMenuItem
            // 
            this.dateiBeendenToolStripMenuItem.Name = "dateiBeendenToolStripMenuItem";
            this.dateiBeendenToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.dateiBeendenToolStripMenuItem.Text = "&Beenden";
            this.dateiBeendenToolStripMenuItem.Click += new System.EventHandler(this.dateiBeendenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bearbeitenKostenToolStripMenuItem,
            this.bearbeitenFahrzeugeToolStripMenuItem,
            this.bearbeitenKatalogeToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.bearbeitenToolStripMenuItem.Text = "&Bearbeiten";
            // 
            // bearbeitenKostenToolStripMenuItem
            // 
            this.bearbeitenKostenToolStripMenuItem.Name = "bearbeitenKostenToolStripMenuItem";
            this.bearbeitenKostenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.bearbeitenKostenToolStripMenuItem.Text = "&Kosten";
            this.bearbeitenKostenToolStripMenuItem.Click += new System.EventHandler(this.bearbeitenKostenToolStripMenuItem_Click);
            // 
            // bearbeitenFahrzeugeToolStripMenuItem
            // 
            this.bearbeitenFahrzeugeToolStripMenuItem.Name = "bearbeitenFahrzeugeToolStripMenuItem";
            this.bearbeitenFahrzeugeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.bearbeitenFahrzeugeToolStripMenuItem.Text = "&Fahrzeuge";
            // 
            // bearbeitenKatalogeToolStripMenuItem
            // 
            this.bearbeitenKatalogeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bearbeitenKatalogeFahrzeugartToolStripMenuItem,
            this.bearbeitenKatalogeFahrzeugherstellerToolStripMenuItem,
            this.bearbeitenKatalogeKostenartToolStripMenuItem});
            this.bearbeitenKatalogeToolStripMenuItem.Name = "bearbeitenKatalogeToolStripMenuItem";
            this.bearbeitenKatalogeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.bearbeitenKatalogeToolStripMenuItem.Text = "Katalo&ge";
            // 
            // bearbeitenKatalogeFahrzeugartToolStripMenuItem
            // 
            this.bearbeitenKatalogeFahrzeugartToolStripMenuItem.Name = "bearbeitenKatalogeFahrzeugartToolStripMenuItem";
            this.bearbeitenKatalogeFahrzeugartToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.bearbeitenKatalogeFahrzeugartToolStripMenuItem.Text = "Fahrzeug&art";
            // 
            // bearbeitenKatalogeFahrzeugherstellerToolStripMenuItem
            // 
            this.bearbeitenKatalogeFahrzeugherstellerToolStripMenuItem.Name = "bearbeitenKatalogeFahrzeugherstellerToolStripMenuItem";
            this.bearbeitenKatalogeFahrzeugherstellerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.bearbeitenKatalogeFahrzeugherstellerToolStripMenuItem.Text = "Fahrzeug&hersteller";
            // 
            // bearbeitenKatalogeKostenartToolStripMenuItem
            // 
            this.bearbeitenKatalogeKostenartToolStripMenuItem.Name = "bearbeitenKatalogeKostenartToolStripMenuItem";
            this.bearbeitenKatalogeKostenartToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.bearbeitenKatalogeKostenartToolStripMenuItem.Text = "K&ostenart";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Kfz.WinApp.Properties.Resources.hyundai_i10_magna;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(507, 418);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "Kfz Verwaltung";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateiBeendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenFahrzeugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenKostenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenKatalogeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenKatalogeFahrzeugartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenKatalogeKostenartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenKatalogeFahrzeugherstellerToolStripMenuItem;
    }
}