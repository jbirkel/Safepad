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
   public partial class FindDlg : Form
   {
      public string Caption { set { _caption   = value; } } string _caption;
      public string FindStr { set { _findStr   = value; } } string _findStr;
      public bool MatchCase { set { _matchCase = value; } } bool _matchCase;
      public bool SearchUp  { set { _searchUp  = value; } } bool _searchUp;            
   
      public  delegate bool del_Find ( string s, bool bMatchCase, bool bUp );
      public  del_Find fnFind { set { _fnFind = value; }}
      private del_Find _fnFind;
      
      public FindDlg()
      {
         InitializeComponent();
      }

      private void FindDlg_Load(object sender, EventArgs e) {
         Text = _caption;
         txtFind.Text    = _findStr;
         chkCase.Checked = _matchCase;
         
         radUp.Checked   =  _searchUp;
         radDown.Checked = !_searchUp;               
      }
      
      private void btnFind_Click(object sender, EventArgs e) {
         if (!_fnFind( txtFind.Text, chkCase.Checked, radUp.Checked )) {
            MessageBox.Show( String.Format( "Cannot find \"{0}\"", txtFind.Text), _caption, MessageBoxButtons.OK,MessageBoxIcon.Information );
         }
      }

      private void btnClose_Click(object sender, EventArgs e) {
         Close();
      }

    
   }
}
