namespace Safepad
{
   partial class Form1
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.menuStrip = new System.Windows.Forms.MenuStrip();
         this.mnuMainFile = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.mnuFileRecent = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuRecentFileItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
         this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuMainEdit = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
         this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
         this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuFindNext = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuReplace = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuGoTo = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.mnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuTimeDate = new System.Windows.Forms.ToolStripMenuItem();
         this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuWordwrap = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
         this.txtMain = new System.Windows.Forms.TextBox();
         this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
         this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
         this.fontDialog = new System.Windows.Forms.FontDialog();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.staLock = new System.Windows.Forms.ToolStripStatusLabel();
         this.lblFiller = new System.Windows.Forms.ToolStripStatusLabel();
         this.lblChrPos = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.imgList = new System.Windows.Forms.ImageList(this.components);
         this.menuStrip.SuspendLayout();
         this.statusStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip
         // 
         this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFile,
            this.mnuMainEdit,
            this.formatToolStripMenuItem,
            this.helpToolStripMenuItem});
         this.menuStrip.Location = new System.Drawing.Point(0, 0);
         this.menuStrip.Name = "menuStrip";
         this.menuStrip.Size = new System.Drawing.Size(303, 24);
         this.menuStrip.TabIndex = 0;
         this.menuStrip.Text = "menuStrip1";
         // 
         // mnuMainFile
         // 
         this.mnuMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAs,
            this.toolStripSeparator2,
            this.mnuFileRecent,
            this.toolStripSeparator5,
            this.mnuExit});
         this.mnuMainFile.Name = "mnuMainFile";
         this.mnuMainFile.Size = new System.Drawing.Size(37, 20);
         this.mnuMainFile.Text = "File";
         this.mnuMainFile.DropDownOpening += new System.EventHandler(this.mnuMainFile_DropDownOpening);
         // 
         // mnuNew
         // 
         this.mnuNew.Name = "mnuNew";
         this.mnuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
         this.mnuNew.Size = new System.Drawing.Size(155, 22);
         this.mnuNew.Text = "&New";
         this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
         // 
         // mnuOpen
         // 
         this.mnuOpen.Name = "mnuOpen";
         this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
         this.mnuOpen.Size = new System.Drawing.Size(155, 22);
         this.mnuOpen.Text = "&Open...";
         this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
         // 
         // mnuSave
         // 
         this.mnuSave.Name = "mnuSave";
         this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
         this.mnuSave.Size = new System.Drawing.Size(155, 22);
         this.mnuSave.Text = "&Save";
         this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
         // 
         // mnuSaveAs
         // 
         this.mnuSaveAs.Name = "mnuSaveAs";
         this.mnuSaveAs.Size = new System.Drawing.Size(155, 22);
         this.mnuSaveAs.Text = "Save &As...";
         this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
         // 
         // mnuFileRecent
         // 
         this.mnuFileRecent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecentFileItem});
         this.mnuFileRecent.Enabled = false;
         this.mnuFileRecent.Name = "mnuFileRecent";
         this.mnuFileRecent.Size = new System.Drawing.Size(155, 22);
         this.mnuFileRecent.Text = "Recent";
         this.mnuFileRecent.DropDownOpening += new System.EventHandler(this.mnuFileRecent_DropDownOpening);
         // 
         // mnuRecentFileItem
         // 
         this.mnuRecentFileItem.Name = "mnuRecentFileItem";
         this.mnuRecentFileItem.Size = new System.Drawing.Size(157, 22);
         this.mnuRecentFileItem.Text = "<place-holder>";
         this.mnuRecentFileItem.Click += new System.EventHandler(this.mnuRecentFileItem_Click);
         // 
         // toolStripSeparator5
         // 
         this.toolStripSeparator5.Name = "toolStripSeparator5";
         this.toolStripSeparator5.Size = new System.Drawing.Size(152, 6);
         // 
         // mnuExit
         // 
         this.mnuExit.Name = "mnuExit";
         this.mnuExit.Size = new System.Drawing.Size(155, 22);
         this.mnuExit.Text = "E&xit";
         this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
         // 
         // mnuMainEdit
         // 
         this.mnuMainEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUndo,
            this.toolStripSeparator3,
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.toolStripSeparator4,
            this.mnuFind,
            this.mnuFindNext,
            this.mnuReplace,
            this.mnuGoTo,
            this.toolStripSeparator1,
            this.mnuSelectAll,
            this.mnuTimeDate});
         this.mnuMainEdit.Name = "mnuMainEdit";
         this.mnuMainEdit.Size = new System.Drawing.Size(39, 20);
         this.mnuMainEdit.Text = "&Edit";
         this.mnuMainEdit.DropDownOpening += new System.EventHandler(this.mnuMainEdit_DropDownOpening);
         // 
         // mnuUndo
         // 
         this.mnuUndo.Name = "mnuUndo";
         this.mnuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
         this.mnuUndo.Size = new System.Drawing.Size(167, 22);
         this.mnuUndo.Text = "Undo";
         this.mnuUndo.Click += new System.EventHandler(this.mnuUndo_Click);
         // 
         // toolStripSeparator3
         // 
         this.toolStripSeparator3.Name = "toolStripSeparator3";
         this.toolStripSeparator3.Size = new System.Drawing.Size(164, 6);
         // 
         // mnuCut
         // 
         this.mnuCut.Name = "mnuCut";
         this.mnuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
         this.mnuCut.Size = new System.Drawing.Size(167, 22);
         this.mnuCut.Text = "Cut";
         this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
         // 
         // mnuCopy
         // 
         this.mnuCopy.Name = "mnuCopy";
         this.mnuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
         this.mnuCopy.Size = new System.Drawing.Size(167, 22);
         this.mnuCopy.Text = "Copy";
         this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
         // 
         // mnuPaste
         // 
         this.mnuPaste.Name = "mnuPaste";
         this.mnuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
         this.mnuPaste.Size = new System.Drawing.Size(167, 22);
         this.mnuPaste.Text = "Paste";
         this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
         // 
         // toolStripSeparator4
         // 
         this.toolStripSeparator4.Name = "toolStripSeparator4";
         this.toolStripSeparator4.Size = new System.Drawing.Size(164, 6);
         // 
         // mnuFind
         // 
         this.mnuFind.Name = "mnuFind";
         this.mnuFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
         this.mnuFind.Size = new System.Drawing.Size(167, 22);
         this.mnuFind.Text = "Find...";
         this.mnuFind.Click += new System.EventHandler(this.mnuFind_Click);
         // 
         // mnuFindNext
         // 
         this.mnuFindNext.Name = "mnuFindNext";
         this.mnuFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
         this.mnuFindNext.Size = new System.Drawing.Size(167, 22);
         this.mnuFindNext.Text = "Find Next";
         this.mnuFindNext.Click += new System.EventHandler(this.mnuFindNext_Click);
         // 
         // mnuReplace
         // 
         this.mnuReplace.Name = "mnuReplace";
         this.mnuReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
         this.mnuReplace.Size = new System.Drawing.Size(167, 22);
         this.mnuReplace.Text = "Replace...";
         this.mnuReplace.Visible = false;
         this.mnuReplace.Click += new System.EventHandler(this.mnuReplace_Click);
         // 
         // mnuGoTo
         // 
         this.mnuGoTo.Name = "mnuGoTo";
         this.mnuGoTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
         this.mnuGoTo.Size = new System.Drawing.Size(167, 22);
         this.mnuGoTo.Text = "Go To...";
         this.mnuGoTo.Click += new System.EventHandler(this.mnuGoTo_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
         // 
         // mnuSelectAll
         // 
         this.mnuSelectAll.Name = "mnuSelectAll";
         this.mnuSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
         this.mnuSelectAll.Size = new System.Drawing.Size(167, 22);
         this.mnuSelectAll.Text = "Select All";
         this.mnuSelectAll.Click += new System.EventHandler(this.mnuSelectAll_Click);
         // 
         // mnuTimeDate
         // 
         this.mnuTimeDate.Name = "mnuTimeDate";
         this.mnuTimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
         this.mnuTimeDate.Size = new System.Drawing.Size(167, 22);
         this.mnuTimeDate.Text = "Time/Date";
         this.mnuTimeDate.Click += new System.EventHandler(this.mnuTimeDate_Click);
         // 
         // formatToolStripMenuItem
         // 
         this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWordwrap,
            this.mnuFont});
         this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
         this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
         this.formatToolStripMenuItem.Text = "F&ormat";
         // 
         // mnuWordwrap
         // 
         this.mnuWordwrap.CheckOnClick = true;
         this.mnuWordwrap.Name = "mnuWordwrap";
         this.mnuWordwrap.Size = new System.Drawing.Size(152, 22);
         this.mnuWordwrap.Text = "Wordwrap";
         this.mnuWordwrap.CheckedChanged += new System.EventHandler(this.mnuWordwrap_CheckedChanged);
         // 
         // mnuFont
         // 
         this.mnuFont.Name = "mnuFont";
         this.mnuFont.Size = new System.Drawing.Size(152, 22);
         this.mnuFont.Text = "Font...";
         this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this.helpToolStripMenuItem.Text = "Help";
         // 
         // mnuAbout
         // 
         this.mnuAbout.Name = "mnuAbout";
         this.mnuAbout.Size = new System.Drawing.Size(152, 22);
         this.mnuAbout.Text = "About";
         this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
         // 
         // txtMain
         // 
         this.txtMain.AcceptsReturn = true;
         this.txtMain.AcceptsTab = true;
         this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtMain.HideSelection = false;
         this.txtMain.Location = new System.Drawing.Point(0, 24);
         this.txtMain.MaxLength = 1048576;
         this.txtMain.Multiline = true;
         this.txtMain.Name = "txtMain";
         this.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.txtMain.Size = new System.Drawing.Size(303, 293);
         this.txtMain.TabIndex = 1;
         this.txtMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMain_KeyDown);
         this.txtMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMain_KeyUp);
         this.txtMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMain_MouseClick);
         // 
         // openFileDialog
         // 
         this.openFileDialog.FileName = "openFileDialog1";
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staLock,
            this.lblFiller,
            this.lblChrPos});
         this.statusStrip1.Location = new System.Drawing.Point(0, 317);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(303, 24);
         this.statusStrip1.TabIndex = 2;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // staLock
         // 
         this.staLock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.staLock.Image = ((System.Drawing.Image)(resources.GetObject("staLock.Image")));
         this.staLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.staLock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this.staLock.Name = "staLock";
         this.staLock.Size = new System.Drawing.Size(16, 19);
         this.staLock.Text = "<lock>";
         this.staLock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblFiller
         // 
         this.lblFiller.Name = "lblFiller";
         this.lblFiller.Size = new System.Drawing.Size(206, 19);
         this.lblFiller.Spring = true;
         // 
         // lblChrPos
         // 
         this.lblChrPos.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
         this.lblChrPos.Name = "lblChrPos";
         this.lblChrPos.Size = new System.Drawing.Size(66, 19);
         this.lblChrPos.Text = "<chr pos>";
         this.lblChrPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 23);
         // 
         // imgList
         // 
         this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
         this.imgList.TransparentColor = System.Drawing.Color.Transparent;
         this.imgList.Images.SetKeyName(0, "lock-16x16.ico");
         this.imgList.Images.SetKeyName(1, "unlock-16x16.ico");
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(303, 341);
         this.Controls.Add(this.txtMain);
         this.Controls.Add(this.menuStrip);
         this.Controls.Add(this.statusStrip1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this.menuStrip;
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
         this.menuStrip.ResumeLayout(false);
         this.menuStrip.PerformLayout();
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip;
      private System.Windows.Forms.ToolStripMenuItem mnuMainFile;
      private System.Windows.Forms.ToolStripMenuItem mnuNew;
      private System.Windows.Forms.ToolStripMenuItem mnuOpen;
      private System.Windows.Forms.TextBox txtMain;
      private System.Windows.Forms.ToolStripMenuItem mnuSave;
      private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
      private System.Windows.Forms.ToolStripMenuItem mnuExit;
      private System.Windows.Forms.SaveFileDialog saveFileDialog;
      private System.Windows.Forms.OpenFileDialog openFileDialog;
      private System.Windows.Forms.FontDialog fontDialog;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripMenuItem mnuMainEdit;
      private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem mnuWordwrap;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem mnuAbout;
      private System.Windows.Forms.ToolStripMenuItem mnuSelectAll;
      private System.Windows.Forms.ToolStripMenuItem mnuTimeDate;
      private System.Windows.Forms.ToolStripMenuItem mnuUndo;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
      private System.Windows.Forms.ToolStripMenuItem mnuCut;
      private System.Windows.Forms.ToolStripMenuItem mnuCopy;
      private System.Windows.Forms.ToolStripMenuItem mnuPaste;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
      private System.Windows.Forms.ToolStripMenuItem mnuFont;
      private System.Windows.Forms.ToolStripMenuItem mnuFind;
      private System.Windows.Forms.ToolStripMenuItem mnuFindNext;
      private System.Windows.Forms.ToolStripMenuItem mnuReplace;
      private System.Windows.Forms.ToolStripMenuItem mnuGoTo;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripMenuItem mnuFileRecent;
      private System.Windows.Forms.ToolStripMenuItem mnuRecentFileItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel lblChrPos;
      private System.Windows.Forms.ToolStripStatusLabel staLock;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
      private System.Windows.Forms.ToolStripStatusLabel lblFiller;
      private System.Windows.Forms.ImageList imgList;
   }
}

