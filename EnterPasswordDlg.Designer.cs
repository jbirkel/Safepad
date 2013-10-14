namespace Safepad
{
   partial class EnterPasswordDlg
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
         this.grpOldPwd = new System.Windows.Forms.GroupBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.chkShowText = new System.Windows.Forms.CheckBox();
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnOK = new System.Windows.Forms.Button();
         this.grpOldPwd.SuspendLayout();
         this.SuspendLayout();
         // 
         // grpOldPwd
         // 
         this.grpOldPwd.Controls.Add(this.txtPassword);
         this.grpOldPwd.Controls.Add(this.chkShowText);
         this.grpOldPwd.Location = new System.Drawing.Point(12, 12);
         this.grpOldPwd.Name = "grpOldPwd";
         this.grpOldPwd.Size = new System.Drawing.Size(323, 73);
         this.grpOldPwd.TabIndex = 0;
         this.grpOldPwd.TabStop = false;
         this.grpOldPwd.Text = "Enter Password:";
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(6, 19);
         this.txtPassword.MaxLength = 80;
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(300, 20);
         this.txtPassword.TabIndex = 0;
         // 
         // chkShowText
         // 
         this.chkShowText.AutoSize = true;
         this.chkShowText.Location = new System.Drawing.Point(6, 45);
         this.chkShowText.Name = "chkShowText";
         this.chkShowText.Size = new System.Drawing.Size(73, 17);
         this.chkShowText.TabIndex = 1;
         this.chkShowText.Text = "Show text";
         this.chkShowText.UseVisualStyleBackColor = true;
         this.chkShowText.CheckedChanged += new System.EventHandler(this.chkShowText_CheckedChanged);
         // 
         // btnCancel
         // 
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(261, 91);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 2;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnOK
         // 
         this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnOK.Location = new System.Drawing.Point(180, 91);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(75, 23);
         this.btnOK.TabIndex = 1;
         this.btnOK.Text = "OK";
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // EnterPasswordDlg
         // 
         this.AcceptButton = this.btnOK;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(348, 123);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.grpOldPwd);
         this.Name = "EnterPasswordDlg";
         this.Text = "EnterPasswordDlg";
         this.Load += new System.EventHandler(this.EnterPasswordDlg_Load);
         this.Shown += new System.EventHandler(this.EnterPasswordDlg_Shown);
         this.grpOldPwd.ResumeLayout(false);
         this.grpOldPwd.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox grpOldPwd;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.CheckBox chkShowText;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnOK;

   }
}