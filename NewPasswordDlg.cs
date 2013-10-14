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
   public partial class NewPasswordDlg : Form
   {
      public string title    { set { _title = value;   } }
      public string password { get { return _password; } }

      string _title = "<title>";
      string _password;
      
      public NewPasswordDlg()
      {
         InitializeComponent();
      }

      private void NewPasswordDlg_Load(object sender, EventArgs e) {
         Text = _title;
         chkNewPwd.Checked = true;
         chkShowText.Checked = false;
         
         UpdatePasswordState(chkNewPwd.Checked);
         UpdateShowTextState(chkShowText.Checked);         
      }
      
      private void UpdatePasswordState( bool enabled ) {
         grpNewPwd.Enabled   =  enabled;
         txtNewPwd1.Enabled  =  enabled;
         txtNewPwd2.Enabled  =  enabled;
         chkShowText.Enabled =  enabled;
         lblWarning.Visible  = !enabled;      
      }

      private void UpdateShowTextState(bool show) {
         char cPwdChar = show ? '\0' : '*';
         //txtNewPwd1.PasswordChar = cPwdChar;
         //txtNewPwd2.PasswordChar = cPwdChar;
         txtNewPwd1.UseSystemPasswordChar = !show;
         txtNewPwd2.UseSystemPasswordChar = !show;         
      }
      
      private void btnOK_Click(object sender, EventArgs e)
      {
         if (chkNewPwd.Checked) {
            if (txtNewPwd1.Text == txtNewPwd2.Text) {
               _password = txtNewPwd1.Text;
            }
            else {
               MessageBox.Show( "The two passwords are not the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
               txtNewPwd1.Focus();
               txtNewPwd1.SelectAll();            
               return;
            }   
         }
         else {
            _password = null;
         }
            
         DialogResult = DialogResult.OK;
         Close();         
      }

      private void btnCancel_Click(object sender, EventArgs e) {
         DialogResult = DialogResult.Cancel;
         Close();
      }

      private void chkNewPwd_CheckedChanged(object sender, EventArgs e)  {
         var chk = (CheckBox)sender;
         UpdatePasswordState( chk.Checked );
      }
    
      private void chkShowText_CheckedChanged(object sender, EventArgs e) {
         var chk = (CheckBox)sender;
         UpdateShowTextState(chk.Checked);
      }
   }
}
