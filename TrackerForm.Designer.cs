namespace Tracker
{
    partial class TrackerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackerForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.addLinkToLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMultipleLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileAccessStrip = new System.Windows.Forms.ToolStrip();
            this.tsbPlayNext = new System.Windows.Forms.ToolStripButton();
            this.tsbPlaySelected = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenDirectory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRename = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddFolder = new System.Windows.Forms.ToolStripButton();
            this.tsbAddFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddLink = new System.Windows.Forms.ToolStripButton();
            this.tsbAddMultipleLinks = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRemoveSelected = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.RightToolStripPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.fileAccessStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.libraryToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(747, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "Main Menu Strip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.recentFilesToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.checkDirectory);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Tracker.Properties.Resources.Open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.recentFilesToolStripMenuItem.Text = "Recent Files...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(160, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Tracker.Properties.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::Tracker.Properties.Resources.SaveFileDialog;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeSelectedToolStripMenuItem1,
            this.clearAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeSelectedToolStripMenuItem1
            // 
            this.removeSelectedToolStripMenuItem1.Image = global::Tracker.Properties.Resources.Remove;
            this.removeSelectedToolStripMenuItem1.Name = "removeSelectedToolStripMenuItem1";
            this.removeSelectedToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.removeSelectedToolStripMenuItem1.Text = "Remove Selected";
            this.removeSelectedToolStripMenuItem1.Click += new System.EventHandler(this.tsbRemoveSelected_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Image = global::Tracker.Properties.Resources.XDelete;
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToLibraryToolStripMenuItem,
            this.addFolderToLibraryToolStripMenuItem,
            this.toolStripMenuItem2,
            this.addLinkToLibraryToolStripMenuItem,
            this.addMultipleLinksToolStripMenuItem});
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripMenuItem.Text = "Library";
            // 
            // addFileToLibraryToolStripMenuItem
            // 
            this.addFileToLibraryToolStripMenuItem.Image = global::Tracker.Properties.Resources.File;
            this.addFileToLibraryToolStripMenuItem.Name = "addFileToLibraryToolStripMenuItem";
            this.addFileToLibraryToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addFileToLibraryToolStripMenuItem.Text = "Add File to Library";
            this.addFileToLibraryToolStripMenuItem.Click += new System.EventHandler(this.tsbAddFile_Click);
            // 
            // addFolderToLibraryToolStripMenuItem
            // 
            this.addFolderToLibraryToolStripMenuItem.Image = global::Tracker.Properties.Resources.FolderWindow;
            this.addFolderToLibraryToolStripMenuItem.Name = "addFolderToLibraryToolStripMenuItem";
            this.addFolderToLibraryToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addFolderToLibraryToolStripMenuItem.Text = "Add Folder to Library";
            this.addFolderToLibraryToolStripMenuItem.Click += new System.EventHandler(this.tsbAddFolder_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(182, 6);
            // 
            // addLinkToLibraryToolStripMenuItem
            // 
            this.addLinkToLibraryToolStripMenuItem.Image = global::Tracker.Properties.Resources.Link;
            this.addLinkToLibraryToolStripMenuItem.Name = "addLinkToLibraryToolStripMenuItem";
            this.addLinkToLibraryToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addLinkToLibraryToolStripMenuItem.Text = "Add Link to Library";
            this.addLinkToLibraryToolStripMenuItem.Click += new System.EventHandler(this.tsbAddLink_Click);
            // 
            // addMultipleLinksToolStripMenuItem
            // 
            this.addMultipleLinksToolStripMenuItem.Image = global::Tracker.Properties.Resources.LinkMultiple;
            this.addMultipleLinksToolStripMenuItem.Name = "addMultipleLinksToolStripMenuItem";
            this.addMultipleLinksToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addMultipleLinksToolStripMenuItem.Text = "Add Multiple Links";
            this.addMultipleLinksToolStripMenuItem.Click += new System.EventHandler(this.addMultipleLinksToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.checkedListBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(639, 362);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.Controls.Add(this.fileAccessStrip);
            this.toolStripContainer1.Size = new System.Drawing.Size(747, 387);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(639, 362);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.openFolderToolStripMenuItem,
            this.toolStripMenuItem1,
            this.removeSelectedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 76);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.atsPlaySelected_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.atsOpenDirectory_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove Selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.tsbRemoveSelected_Click);
            // 
            // fileAccessStrip
            // 
            this.fileAccessStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fileAccessStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fileAccessStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPlayNext,
            this.tsbPlaySelected,
            this.toolStripSeparator4,
            this.tsbOpenDirectory,
            this.tsbRename});
            this.fileAccessStrip.Location = new System.Drawing.Point(0, 3);
            this.fileAccessStrip.Name = "fileAccessStrip";
            this.fileAccessStrip.Size = new System.Drawing.Size(108, 100);
            this.fileAccessStrip.TabIndex = 0;
            // 
            // tsbPlayNext
            // 
            this.tsbPlayNext.Image = global::Tracker.Properties.Resources.ArrowRun;
            this.tsbPlayNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbPlayNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlayNext.Name = "tsbPlayNext";
            this.tsbPlayNext.Size = new System.Drawing.Size(106, 20);
            this.tsbPlayNext.Text = "Open Next";
            this.tsbPlayNext.Click += new System.EventHandler(this.atsPlayNext_Click);
            // 
            // tsbPlaySelected
            // 
            this.tsbPlaySelected.Image = global::Tracker.Properties.Resources.ArrowRunHollow;
            this.tsbPlaySelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbPlaySelected.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPlaySelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlaySelected.Name = "tsbPlaySelected";
            this.tsbPlaySelected.Size = new System.Drawing.Size(106, 20);
            this.tsbPlaySelected.Text = "Open Selected";
            this.tsbPlaySelected.Click += new System.EventHandler(this.atsPlaySelected_Click);
            // 
            // tsbOpenDirectory
            // 
            this.tsbOpenDirectory.Image = global::Tracker.Properties.Resources.Folder;
            this.tsbOpenDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenDirectory.Name = "tsbOpenDirectory";
            this.tsbOpenDirectory.Size = new System.Drawing.Size(106, 20);
            this.tsbOpenDirectory.Text = "Open Directory";
            this.tsbOpenDirectory.Click += new System.EventHandler(this.atsOpenDirectory_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(106, 6);
            // 
            // tsbRename
            // 
            this.tsbRename.Image = global::Tracker.Properties.Resources.Rename;
            this.tsbRename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbRename.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRename.Name = "tsbRename";
            this.tsbRename.Size = new System.Drawing.Size(106, 20);
            this.tsbRename.Text = "Rename";
            this.tsbRename.Click += new System.EventHandler(this.atsRename_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddFolder,
            this.tsbAddFile,
            this.toolStripSeparator5,
            this.tsbAddLink,
            this.tsbAddMultipleLinks,
            this.toolStripSeparator2,
            this.tsbRemoveSelected,
            this.tsbClear});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(558, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbAddFolder
            // 
            this.tsbAddFolder.Image = global::Tracker.Properties.Resources.FolderWindow;
            this.tsbAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddFolder.Name = "tsbAddFolder";
            this.tsbAddFolder.Size = new System.Drawing.Size(85, 22);
            this.tsbAddFolder.Text = "Add Folder";
            this.tsbAddFolder.Click += new System.EventHandler(this.tsbAddFolder_Click);
            // 
            // tsbAddFile
            // 
            this.tsbAddFile.Image = global::Tracker.Properties.Resources.File;
            this.tsbAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddFile.Name = "tsbAddFile";
            this.tsbAddFile.Size = new System.Drawing.Size(70, 22);
            this.tsbAddFile.Text = "Add File";
            this.tsbAddFile.Click += new System.EventHandler(this.tsbAddFile_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAddLink
            // 
            this.tsbAddLink.Image = global::Tracker.Properties.Resources.Link;
            this.tsbAddLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddLink.Name = "tsbAddLink";
            this.tsbAddLink.Size = new System.Drawing.Size(74, 22);
            this.tsbAddLink.Text = "Add Link";
            this.tsbAddLink.Click += new System.EventHandler(this.tsbAddLink_Click);
            // 
            // tsbAddMultipleLinks
            // 
            this.tsbAddMultipleLinks.Image = global::Tracker.Properties.Resources.LinkMultiple;
            this.tsbAddMultipleLinks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddMultipleLinks.Name = "tsbAddMultipleLinks";
            this.tsbAddMultipleLinks.Size = new System.Drawing.Size(126, 22);
            this.tsbAddMultipleLinks.Text = "Add Multiple Links";
            this.tsbAddMultipleLinks.Click += new System.EventHandler(this.addMultipleLinksToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRemoveSelected
            // 
            this.tsbRemoveSelected.Image = global::Tracker.Properties.Resources.Remove;
            this.tsbRemoveSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveSelected.Name = "tsbRemoveSelected";
            this.tsbRemoveSelected.Size = new System.Drawing.Size(117, 22);
            this.tsbRemoveSelected.Text = "Remove Selected";
            this.tsbRemoveSelected.Click += new System.EventHandler(this.tsbRemoveSelected_Click);
            // 
            // tsbClear
            // 
            this.tsbClear.Image = global::Tracker.Properties.Resources.XDelete;
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(71, 22);
            this.tsbClear.Text = "Clear All";
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 411);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "TrackerForm";
            this.Text = "Tracker";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.RightToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.RightToolStripPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.fileAccessStrip.ResumeLayout(false);
            this.fileAccessStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddFolder;
        private System.Windows.Forms.ToolStripButton tsbAddFile;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStrip fileAccessStrip;
        private System.Windows.Forms.ToolStripButton tsbPlaySelected;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton tsbPlayNext;
        private System.Windows.Forms.ToolStripButton tsbRemoveSelected;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbOpenDirectory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbRename;
        private System.Windows.Forms.ToolStripButton tsbAddLink;
        private System.Windows.Forms.ToolStripMenuItem addFileToLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFolderToLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addLinkToLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMultipleLinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbAddMultipleLinks;
    }
}

