using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Safepad
{
   public partial class GotoDlg : Form
   {
      public string Caption { set { _caption = value; } }
      string _caption;
      
      public int CurrLine { set { _currLine = value; }} 
      public int LastLine { set { _lastLine = value; }}       
      public int GotoLine { get { return _gotoLine;  }}             
      int _currLine, _lastLine, _gotoLine;
      
      public GotoDlg()
      {
         InitializeComponent();
      }

      private void GotoDlg_Load(object sender, EventArgs e) {
         Text = _caption;
         numGoto.Maximum = _lastLine;
         numGoto.Value = _currLine;
      }

      private void btnOK_Click(object sender, EventArgs e) {
         _gotoLine = (int)numGoto.Value;
         DialogResult = DialogResult.OK;
         Close();
      }

      private void btnCancel_Click(object sender, EventArgs e) {
         DialogResult = DialogResult.Cancel;
         Close();      
      }
   }
}
