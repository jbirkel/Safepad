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
   public partial class EnterPasswordDlg : Form
   {
      public string title    { set { _title    = value; }                           }
      public string password {                            get { return _password; } } 
      
      string _title = "<title>";
      bool   _showText = false;
      string _password;
      
      public EnterPasswordDlg() {
         InitializeComponent();
      }

      private void EnterPasswordDlg_Load(object sender, EventArgs e) {
         Text = _title;
         SetAndUpdateShowText( _showText );
      }

      private void EnterPasswordDlg_Shown(object sender, EventArgs e) {
         txtPassword.SelectAll();
         txtPassword.Focus();
      }      

      private void chkShowText_CheckedChanged(object sender, EventArgs e) {
         var chk = (CheckBox)sender;
         SetAndUpdateShowText(chk.Checked);         
      }
      
      private void SetAndUpdateShowText( bool bShowText ) {
         _showText = bShowText;      
         chkShowText.Checked = _showText;
         txtPassword.UseSystemPasswordChar = !_showText;         
      }

      private void btnOK_Click    (object sender, EventArgs e) { _password = txtPassword.Text; Close(); }
      private void btnCancel_Click(object sender, EventArgs e) {                               Close(); }
   }
}
