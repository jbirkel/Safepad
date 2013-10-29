using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Xml; 
using System.Xml.Linq; 
                       
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

using jhblib;

namespace Safepad
{
   public partial class Form1 : Form
   {
      class DocInfo {
         public DocInfo() {}
         public DocInfo( string path ) { _filepath = path; }
         
         public string Filename  { get { return IsUntitled() ? "Untitled" : Path.GetFileName( _filepath ); }}
         public string Directory { get { return Path.GetDirectoryName( _filepath); }}
         public string FullPath  { get { return _filepath; } }         

         public string password { set { _password = value; } get { return _password; } }

         public bool IsUntitled () { return null == _filepath; }
         public bool HasPassword() { return null != _password; }

         private string _filepath;
         private string _password;
      }
      DocInfo _DI = new DocInfo();

      // Find box parameters.
      string _sFind;
      //string _sReplace;
      bool   _bFindMatchCase;
      bool   _bFindSearchUp;
      
      // Form constants
      static string _AppName = "<_AppName>";      
      static string _OpenFile;
      
      
      // Utility functions --------------------------------------------------------------
      
      private void ShowException(string msg, Exception xx) {
         var sb = new StringBuilder(msg);
         sb.Append(Environment.NewLine);
         sb.Append(Environment.NewLine);
         sb.Append(xx.Message);
         MessageBox.Show(sb.ToString(), _AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }      
      
      private void InitAppConstants() {
         object[] ret = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
         if (0 < ret.Length) {
            _AppName = ((AssemblyProductAttribute)ret[0]).Product;
         }   
      }

      // Logging ------------------------------------------------------------------------
      jhblib.Logger _LOG;
      
      private void InitLogging() {
         _LOG = new jhblib.Logger(new jhblib.LogTgtFile(String.Format("{0}-log.txt", _AppName)));
      }
      
      // --------------------------------------------------------------------------------      
      // All we want from the command line is the name of the file to open, if
      // it was included.
      //
      // NOTE: Splitting by double quotes (with RemoveEmptyEntries) produces the 
      //       following args array:
      //
      //       arg[0] = EE path
      //       arg[1] = " "
      //       arg[2] = Arg #1  (file to open)
      //       arg[3,5..2*N-1] = " "
      //       arg[4,6..2*N  ] = Args #2..N (ignored)
      // --------------------------------------------------------------------------------            
      private void ParseCommandLine() {
      
         var args = Environment.CommandLine.ToString().Split(new char[] {'"'},StringSplitOptions.RemoveEmptyEntries);
         if (2 < args.Count()) {
         
            // Parse out file name.
            var cl = Environment.CommandLine.ToString();
            _LOG.Trace(String.Format("ParseCommandLine: {0}\n", cl));
            
            var s = args[2];
            s = s.Trim(new char[] {'"'});
            if (0 < s.Length) {
               _OpenFile = s;
            }
         }   
    
         //
         // -- Uncomment to display command line on startup.
         //
         //var sb = new StringBuilder();
         //for (uint i=0; i<args.Count(); i++) {
         //   sb.AppendFormat( "{0}: {1}{2}", i, args[i], Environment.NewLine );
         //}
         //MessageBox.Show(sb.ToString());
      }

      // --------------------------------------------------------------------------------
      //
      //  FFFFFF                       11  
      //  FF                         1111  
      //  FF                           11  
      //  FF      oooo  rrr mmmmmmm    11  
      //  FFFFF  oo  oo rr  mm mm mm   11  
      //  FF     oo  oo rr  mm mm mm   11  
      //  FF     oo  oo rr  mm mm mm   11  
      //  FF     oo  oo rr  mm mm mm   11  
      //  FF      oooo  rr  mm mm mm   11  
      //
      // --------------------------------------------------------------------------------      
      //      
      //  Main form event handlers.
      //
      // --------------------------------------------------------------------------------      

      System.Collections.Specialized.StringCollection _MRU;
      
      public Form1()
      {
         InitializeComponent();
         
         InitAppConstants();
         InitLogging();         
         
         try { ParseCommandLine(); }
         catch (Exception xx) {ShowException("Error parsing command line.", xx);}
         
      }
      
      private void Form1_Load(object sender, EventArgs e) {
      
         // Load persisted settings.   
         this.Size        = Properties.Settings.Default._FormSize  ; 
         txtMain.Font     = Properties.Settings.Default._TextFont  ;
         UpdateWordwrap   ( Properties.Settings.Default._Wordwrap );

         _MRU = Properties.Settings.Default._MRU_List;
         if (null == _MRU) {         
            _MRU = new System.Collections.Specialized.StringCollection();
         }
         
         // Load file from command line.  (If there is one.) 
         if ((null != _OpenFile) && (0 <_OpenFile.Length)) { 
            Open(_OpenFile); txtMain.SelectionStart = 0; 
         }
                              
         UpdateFileState();
         UpdateCursorPos(); 
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
         if (!SaveYourWork()) { 
            e.Cancel = true; 
            return; 
         }

         // Save persisted settings.
         Properties.Settings.Default._FormSize = this.Size;
         Properties.Settings.Default._TextFont = txtMain.Font;
         Properties.Settings.Default._Wordwrap = txtMain.WordWrap;
         Properties.Settings.Default._MRU_List = _MRU;
         Properties.Settings.Default.Save();
      }

      // --------------------------------------------------------------------------------         
      // Text Area events
      // --------------------------------------------------------------------------------               
      
      private void txtMain_MouseClick(object sender, MouseEventArgs e) { UpdateCursorPos(); }
      private void txtMain_KeyUp(object sender, KeyEventArgs e) { UpdateCursorPos(); }
      private void txtMain_KeyDown(object sender, KeyEventArgs e) { UpdateCursorPos(); }
      //private void txtMain_KeyPress(object sender, KeyPressEventArgs e) { UpdateCursorPos(); }
      //private void txtMain_Layout(object sender, LayoutEventArgs e)     { UpdateCursorPos(); }

      // --------------------------------------------------------------------------------         
      // GUI Update Routines
      // --------------------------------------------------------------------------------               

      private void UpdateFileState()
      {
         Text = _DI.Filename + " - " + _AppName;
         //staLock.Visible = _DI.HasPassword();
         staLock.Image = imgList.Images[_DI.HasPassword() ? 0 : 1];
      }
            
      void UpdateWordwrap( bool enabled ) {

         int pos = txtMain.SelectionStart;
         int len = txtMain.SelectionLength;
         txtMain.WordWrap = enabled;
         txtMain.SelectionStart = pos;
         txtMain.SelectionLength = len;
         
         txtMain.ScrollToCaret();
         txtMain.ScrollBars = enabled ? ScrollBars.Vertical : ScrollBars.Both;

         mnuWordwrap.Checked = enabled;
         UpdateCursorPos();
      }
      
      void UpdateCursorPos() {
         string sOut;
         if (txtMain.WordWrap) { sOut = "(Wordwrap: On)";  }
         else { 
            var pos = txtMain.SelectionStart;
            var lin = txtMain.GetLineFromCharIndex(pos);
            var col = pos - txtMain.GetFirstCharIndexFromLine(lin);
            sOut = String.Format( "Ln {0}, Col {1}", lin+1, col+1 );
         }
         lblChrPos.Text = sOut;
      }

      // --------------------------------------------------------------------------------         
      //
      //  FFFFFF ii ll       
      //  FF        ll       
      //  FF        ll       
      //  FF     ii ll  eeee 
      //  FFFFF  ii ll ee  ee
      //  FF     ii ll eeeeee
      //  FF     ii ll ee    
      //  FF     ii ll ee  ee
      //  FF     ii ll  eeee 
      //
      // --------------------------------------------------------------------------------         
      //
      // File Operations
      //
      // --------------------------------------------------------------------------------               

      void New() {
         if (!SaveYourWork()) return;
         
         _DI = new DocInfo();
         txtMain.Clear();
         UpdateFileState();
      }
      
      private void Open( string path ) {

         _LOG.Trace( String.Format( "Open: opening {0}\n", path ));
         var tmpDI = new DocInfo( path );
      
         string sText;
         try { sText = File.ReadAllText( tmpDI.FullPath, Encoding.Default ); }
         catch (Exception xx) {
            ShowException( "Error opening file.", xx ); 
            return;
         }

         CipherStore CS = null;
         try { CS = EasyXml.Import<CipherStore>(sText); } catch {}
         
         if (null != CS) {
            var dlg = new EnterPasswordDlg();
            dlg.title = _AppName;
            DialogResult ret;
            while (DialogResult.OK == (ret = dlg.ShowDialog())) {
               try {
                  sText = CS.DecryptString(tmpDI.password = dlg.password); 
                  break; 
               } 
               catch { MessageBox.Show( "Error decrypting document. (Bad password?)", _AppName, MessageBoxButtons.OK, MessageBoxIcon.Error ); }
            } 
            if (DialogResult.Cancel == ret) { 
               return;
            }   
         }

         txtMain.Text = sText;  
         _DI = tmpDI; 
         UpdateFileState();
         AddToMruList(_DI.FullPath);
         AddToRecentDocs(_DI.FullPath);         
      }
 
      bool Save() {
         return _DI.IsUntitled() ? SaveAs() : writeCurrDoc();
      }
      
      bool SaveAs() {

         string password;         
         {  var dlg = new NewPasswordDlg();
            dlg.title = _AppName;
            if (dlg.ShowDialog() == DialogResult.OK) {
               password = dlg.password;
            }
            else return false;             
         }
         
         DocInfo tmpDI;
         {  var dlg = saveFileDialog;
            dlg.Filter = (null == password) ? "Text files (*.txt)|*.txt|All files (*.*)|*.*"
                                            : "Safepad files (*.safepad)|*.safepad|All files (*.*)|*.*" ;
            var ret = dlg.ShowDialog();
            if (ret == DialogResult.OK) {
               tmpDI = new DocInfo( dlg.FileName );   
            }
            else return false;
         } 
        
         tmpDI.password = password;
         _DI = tmpDI;

         bool bRet = writeCurrDoc();

         UpdateFileState();
         AddToMruList(_DI.FullPath);         
         AddToRecentDocs(_DI.FullPath);         
         
         return bRet;
      }

      bool writeCurrDoc() {
      
         string sOut = "";
         if (null == _DI.password) { sOut = txtMain.Text; }
         else {
            try {
               var CS = CipherStore.Create(txtMain.Text,_DI.password);
               sOut = EasyXml.Export(CS);
            } catch (Exception xx) {
               ShowException( "Error encrypting document.", xx );
               return false;
            }   
         }

         try { File.WriteAllText(Path.Combine(_DI.Directory, _DI.Filename), sOut, Encoding.Default); }
         catch (Exception xx) {
            ShowException("Error saving file.", xx);
            return false;
         }
         
         txtMain.Modified = false;
         return true;      
      }
            
      bool SaveYourWork() {
         if (!txtMain.Modified) return true;
         
         string msg = String.Format( "Do you want to save changes to {0}?", _DI.Filename );
         var ret = MessageBox.Show(msg, _AppName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
         switch (ret) {
            case DialogResult.Yes   : return Save();         
            case DialogResult.No    : return true  ;         
            default /* Cancel */    : return false ;
         }
      }

      private void AddToMruList(string path){
         DelFromMruList(path);
         _MRU.Insert(0, path);
         for (int i = 10; i < _MRU.Count; i++) { _MRU.RemoveAt(i); }
      }
      private void DelFromMruList(string path) { if (_MRU.Contains(path)) { _MRU.Remove(path); } }
      
   
      // -------------------------------------------------------------------------------- 
      //
      //  MM    MM                            
      //  MM    MM                            
      //  MMM  MMM                            
      //  MMM  MMM   eeee  nnnnn  uu  uu  sss 
      //  MMMMMMMM  ee  ee nnn nn uu  uu ss ss
      //  MMMMMMMM  eeeeee nn  nn uu  uu  ss  
      //  MM MM MM  ee     nn  nn uu  uu   ss 
      //  MM MM MM  ee  ee nn  nn uu uuu ss ss
      //  MM    MM   eeee  nn  nn  uuuuu  sss 
      // 
      // --------------------------------------------------------------------------------             
      //
      //  Menu handlers
      //
      // --------------------------------------------------------------------------------       
      
      private void mnuNew_Click(object sender, EventArgs e) {
         if (txtMain.Modified) {
            var ret = MessageBox.Show( String.Format("Do you want to save changes to {0}?", _DI.Filename), _AppName, MessageBoxButtons.YesNoCancel ); 
            if (ret == DialogResult.Cancel) { return; }
            if (ret == DialogResult.Yes   ) { Save(); }            
         }
         New();
      }

      private void mnuOpen_Click(object sender, EventArgs e) {

         if (!SaveYourWork()) return;         
        
         var dlg = new OpenFileDialog();
         dlg.Filter = "Text and Safepad files|*.safepad;*.txt|All files|*.*";
         
         if (dlg.ShowDialog() != DialogResult.OK) {
            return;
         }
         
         Open( dlg.FileName );
      }
      private void mnuMainFile_DropDownOpening(object sender, EventArgs e) {
         mnuFileRecent.Enabled = (0 < _MRU.Count);
      }
      private void mnuFileRecent_DropDownOpening(object sender, EventArgs e) {
         UpdateRecentMenu();
      }
      
      private void mnuSave_Click  (object sender, EventArgs e) {
          if (_DI.IsUntitled()) { SaveAs(); } else { Save(); }
      }
      private void mnuSaveAs_Click(object sender, EventArgs e) { SaveAs(); }        
      private void mnuExit_Click  (object sender, EventArgs e) { Close() ; }

      private void mnuWordwrap_CheckedChanged(object sender, EventArgs e) {
         var mnu = (ToolStripMenuItem)sender;    
         UpdateWordwrap( mnu.Checked ); 
      }
      
      private void mnuTimeDate_Click(object sender, EventArgs e) {
         var now = DateTime.Now;
         txtMain.SelectedText = String.Format("{0} {1}", now.ToShortTimeString(), now.ToShortDateString()); 
      }

      private void mnuMainEdit_DropDownOpening(object sender, EventArgs e) {
         mnuUndo.Enabled = txtMain.CanUndo;
         mnuCut.Enabled = 0 < txtMain.SelectionLength;
         mnuCopy.Enabled = 0 < txtMain.SelectionLength;
         mnuPaste.Enabled = Clipboard.ContainsText();
         mnuFindNext.Enabled = null != _sFind;      
      }

      private void mnuUndo_Click     (object sender, EventArgs e) { txtMain.Undo     (); }
      private void mnuCut_Click      (object sender, EventArgs e) { txtMain.Cut      (); }
      private void mnuCopy_Click     (object sender, EventArgs e) { txtMain.Copy     (); }
      private void mnuPaste_Click    (object sender, EventArgs e) { txtMain.Paste    (); }
      private void mnuSelectAll_Click(object sender, EventArgs e) { txtMain.SelectAll(); }


      private void mnuAbout_Click(object sender, EventArgs e) {
         var dlg = new AboutBox1();
         dlg.ShowDialog();
      }
      
      private void mnuFont_Click(object sender, EventArgs e) {
         var dlg = fontDialog;
         dlg.Font = txtMain.Font ;
         if (DialogResult.OK == dlg.ShowDialog()) {
            txtMain.Font = dlg.Font;
         }
      }

      private void mnuGoTo_Click(object sender, EventArgs e)
      {
         var dlg = new GotoDlg();
         dlg.Caption = _AppName;
         dlg.CurrLine = txtMain.GetLineFromCharIndex(txtMain.SelectionStart) + 1;
         dlg.LastLine = txtMain.GetLineFromCharIndex(txtMain.Text.Length) +  1;
         if (DialogResult.OK == dlg.ShowDialog()) {
            int idx = txtMain.GetFirstCharIndexFromLine( dlg.GotoLine - 1 );
            txtMain.SelectionStart = idx;
            txtMain.ScrollToCaret();         
         }
      }

      private void mnuFindNext_Click(object sender, EventArgs e) {
         if (!findText( _sFind, _bFindMatchCase, _bFindSearchUp)) {
            MessageBox.Show(String.Format("Cannot find \"{0}\"", _sFind), _AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
         }      
      }

      private void mnuFind_Click(object sender, EventArgs e) {
         if (FindDlg.IsOpen) {
            FindDlg.BringToFront();
            return;
         }
         
         var dlg = new FindDlg();
         dlg.Caption   = _AppName;
         dlg.FindStr   = (0 < txtMain.SelectionLength) ? txtMain.SelectedText : _sFind ;
         dlg.fnFind    = findText;
         dlg.MatchCase = _bFindMatchCase ;
         dlg.SearchUp  = _bFindSearchUp ;
         
         dlg.Owner     = this; // keep FindDlg on top of main window                 
         
         dlg.Show();
      }

      private void mnuReplace_Click(object sender, EventArgs e) { }

      // --------------------------------------------------------------------------------
      // Recent files menu
      // --------------------------------------------------------------------------------      

      private string FormatRecentItem(int i, string path) { return String.Format("{0} {1}", i + 1, path); }
      private string FileFromRecentItem(string itemText) { return itemText.Split(' ')[1]; }

      private void UpdateRecentMenu()
      {
         var ddi = mnuFileRecent.DropDownItems;
         ddi.Clear();
         for (int i = 0; i < _MRU.Count; i++)
         {
            var tsmi = new ToolStripMenuItem(FormatRecentItem(i, _MRU[i]), null, mnuRecentFileItem_Click);
            ddi.Add(tsmi);
         }
      }

      private void mnuRecentFileItem_Click(object sender, EventArgs e)
      {
         var mnu = (ToolStripMenuItem)sender;
         var s = FileFromRecentItem(mnu.Text);
         if (File.Exists(s)) { Open(s); }
         else
         {
            string msg = "Cannot find selected file.  Would you like to remove it from the recent file list?";
            if (MessageBox.Show(msg, _AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               DelFromMruList(s);
            }
         }
      }

      // --------------------------------------------------------------------------------      
      //
      //  FFFFFF ii            dd
      //  FF                   dd
      //  FF                   dd
      //  FF     ii nnnnn   ddddd
      //  FFFFF  ii nnn nn dd  dd
      //  FF     ii nn  nn dd  dd
      //  FF     ii nn  nn dd  dd
      //  FF     ii nn  nn dd  dd
      //  FF     ii nn  nn  ddddd
      //
      // --------------------------------------------------------------------------------            
      private bool findText( string text, bool bMatchCase, bool bSearchUp ) {

         // Remember these parameters for next time or find next.
         _sFind = text;
         _bFindMatchCase = bMatchCase;
         _bFindSearchUp = bSearchUp;
         
         // Match case determines the string cmoparision method.
         var StrCmp = bMatchCase ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase ;

         // Search up or down.         
         var T = txtMain;
         int idx;
         if (!bSearchUp) {
            idx = T.Text.IndexOf( text, T.SelectionStart + T.SelectionLength, StrCmp );
         } else {
            idx = T.Text.LastIndexOf(text, T.SelectionStart, StrCmp);         
         }   
         
         // If found, highlight the found text and scroll to it. 
         if (0 <= idx) {
            T.SelectionStart = idx;
            T.SelectionLength = text.Length;
            T.ScrollToCaret();
            T.Update();
            return true;
         }
         
         return false;         
      }


      // --------------------------------------------------------------------------------
      // WIN API stuff to add docs to OS recently used file lists.                       
      // --------------------------------------------------------------------------------
      void AddToRecentDocs(string fileName) { SHAddToRecentDocs( (uint) SHARD.SHARD_PATHW, fileName); }

      [DllImport("shell32.dll")] public static extern void SHAddToRecentDocs(uint uFlags, [MarshalAs(UnmanagedType.LPWStr)] String pv);

      enum SHARD { 
        SHARD_PIDL             = 0x00000001,
        SHARD_PATHA            = 0x00000002,
        SHARD_PATHW            = 0x00000003,
        // Win 7 only:
        SHARD_APPIDINFO        = 0x00000004,   
        SHARD_APPIDINFOIDLIST  = 0x00000005,
        SHARD_LINK             = 0x00000006,
        SHARD_APPIDINFOLINK    = 0x00000007,
        SHARD_SHELLITEM        = 0x00000008
      } ;

   }
}
