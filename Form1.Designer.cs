namespace Nightek.PBM
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
            this.MenuBar = new DarkUI.Controls.DarkMenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.renderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PixelPerfectItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JPEGItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PNGItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenRecentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Preview = new Nightek.PBM.ImagePreviewerControl();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MenuBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditItem,
            this.renderingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.MenuBar.Size = new System.Drawing.Size(800, 24);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "darkMenuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenItem,
            this.OpenRecentItem,
            this.SaveItem,
            this.toolStripSeparator1,
            this.exportToolStripMenuItem,
            this.ImportItem,
            this.toolStripSeparator2});
            this.FileMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // renderingToolStripMenuItem
            // 
            this.renderingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PixelPerfectItem});
            this.renderingToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.renderingToolStripMenuItem.Name = "renderingToolStripMenuItem";
            this.renderingToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.renderingToolStripMenuItem.Text = "Rendering";
            // 
            // PixelPerfectItem
            // 
            this.PixelPerfectItem.Checked = true;
            this.PixelPerfectItem.CheckOnClick = true;
            this.PixelPerfectItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PixelPerfectItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.PixelPerfectItem.Name = "PixelPerfectItem";
            this.PixelPerfectItem.Size = new System.Drawing.Size(139, 22);
            this.PixelPerfectItem.Text = "Pixel Perfect";
            this.PixelPerfectItem.ToolTipText = "Draws the image in Pixel Perfect mode.\r\n\r\nThe pixels will not be stretched and wi" +
    "ll be squared. Disable this mode if you are loading a very large image;";
            this.PixelPerfectItem.CheckedChanged += new System.EventHandler(this.PixelPerfectItem_CheckedChanged);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // EditItem
            // 
            this.EditItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyItem});
            this.EditItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(39, 20);
            this.EditItem.Text = "Edit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JPEGItem,
            this.PNGItem});
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // JPEGItem
            // 
            this.JPEGItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.JPEGItem.Name = "JPEGItem";
            this.JPEGItem.Size = new System.Drawing.Size(140, 22);
            this.JPEGItem.Text = "JPEG Format";
            this.JPEGItem.Click += new System.EventHandler(this.JPEGItem_Click);
            // 
            // PNGItem
            // 
            this.PNGItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.PNGItem.Name = "PNGItem";
            this.PNGItem.Size = new System.Drawing.Size(140, 22);
            this.PNGItem.Text = "PNG Format";
            this.PNGItem.Click += new System.EventHandler(this.PNGItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // OpenItem
            // 
            this.OpenItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.OpenItem.Image = global::Nightek.PBM.Properties.Resources.OpenFile_16x;
            this.OpenItem.Name = "OpenItem";
            this.OpenItem.Size = new System.Drawing.Size(180, 22);
            this.OpenItem.Text = "Open";
            this.OpenItem.Click += new System.EventHandler(this.OpenItemClicked);
            // 
            // OpenRecentItem
            // 
            this.OpenRecentItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.OpenRecentItem.Image = global::Nightek.PBM.Properties.Resources.Time_16x;
            this.OpenRecentItem.Name = "OpenRecentItem";
            this.OpenRecentItem.Size = new System.Drawing.Size(180, 22);
            this.OpenRecentItem.Text = "Open recent";
            // 
            // SaveItem
            // 
            this.SaveItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.SaveItem.Image = global::Nightek.PBM.Properties.Resources.Save_16x;
            this.SaveItem.Name = "SaveItem";
            this.SaveItem.Size = new System.Drawing.Size(180, 22);
            this.SaveItem.Text = "Save";
            this.SaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // ImportItem
            // 
            this.ImportItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ImportItem.Image = global::Nightek.PBM.Properties.Resources.ImportFile_16x;
            this.ImportItem.Name = "ImportItem";
            this.ImportItem.Size = new System.Drawing.Size(180, 22);
            this.ImportItem.Text = "Import";
            this.ImportItem.Click += new System.EventHandler(this.ImportItem_Click);
            // 
            // CopyItem
            // 
            this.CopyItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CopyItem.Image = global::Nightek.PBM.Properties.Resources.Copy_16x;
            this.CopyItem.Name = "CopyItem";
            this.CopyItem.Size = new System.Drawing.Size(169, 22);
            this.CopyItem.Text = "Copy to clipboard";
            this.CopyItem.Click += new System.EventHandler(this.CopyItem_Click);
            // 
            // Preview
            // 
            this.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Preview.Location = new System.Drawing.Point(0, 24);
            this.Preview.Name = "Preview";
            this.Preview.PixelPerfect = true;
            this.Preview.Size = new System.Drawing.Size(800, 426);
            this.Preview.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.MenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBM Reader .NET";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkMenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenItem;
        private ImagePreviewerControl Preview;
        private System.Windows.Forms.ToolStripMenuItem renderingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PixelPerfectItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenRecentItem;
        private System.Windows.Forms.ToolStripMenuItem EditItem;
        private System.Windows.Forms.ToolStripMenuItem CopyItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JPEGItem;
        private System.Windows.Forms.ToolStripMenuItem PNGItem;
        private System.Windows.Forms.ToolStripMenuItem ImportItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SaveItem;
    }
}

