namespace Safepad
{
   partial class NewPasswordDlg
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
         this.btnOK = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.grpNewPwd = new System.Windows.Forms.GroupBox();
         this.txtNewPwd2 = new System.Windows.Forms.TextBox();
         this.txtNewPwd1 = new System.Windows.Forms.TextBox();
         this.chkShowText = new System.Windows.Forms.CheckBox();
         this.chkNewPwd = new System.Windows.Forms.CheckBox();
         this.lblWarning = new System.Windows.Forms.Label();
         this.grpNewPwd.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnOK
         // 
         this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnOK.Location = new System.Drawing.Point(179, 190);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(75, 23);
         this.btnOK.TabIndex = 2;
         this.btnOK.Text = "OK";
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(260, 190);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 3;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // grpNewPwd
         // 
         this.grpNewPwd.Controls.Add(this.txtNewPwd2);
         this.grpNewPwd.Controls.Add(this.txtNewPwd1);
         this.grpNewPwd.Controls.Add(this.chkShowText);
         this.grpNewPwd.Location = new System.Drawing.Point(12, 47);
         this.grpNewPwd.Name = "grpNewPwd";
         this.grpNewPwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.grpNewPwd.Size = new System.Drawing.Size(323, 99);
         this.grpNewPwd.TabIndex = 0;
         this.grpNewPwd.TabStop = false;
         this.grpNewPwd.Text = "Enter new password (twice)";
         // 
         // txtNewPwd2
         // 
         this.txtNewPwd2.Location = new System.Drawing.Point(6, 47);
         this.txtNewPwd2.MaxLength = 80;
         this.txtNewPwd2.Name = "txtNewPwd2";
         this.txtNewPwd2.Size = new System.Drawing.Size(300, 20);
         this.txtNewPwd2.TabIndex = 1;
         // 
         // txtNewPwd1
         // 
         this.txtNewPwd1.Location = new System.Drawing.Point(6, 19);
         this.txtNewPwd1.MaxLength = 80;
         this.txtNewPwd1.Name = "txtNewPwd1";
         this.txtNewPwd1.Size = new System.Drawing.Size(300, 20);
         this.txtNewPwd1.TabIndex = 0;
         // 
         // chkShowText
         // 
         this.chkShowText.AutoSize = true;
         this.chkShowText.Location = new System.Drawing.Point(6, 76);
         this.chkShowText.Name = "chkShowText";
         this.chkShowText.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.chkShowText.Size = new System.Drawing.Size(73, 17);
         this.chkShowText.TabIndex = 2;
         this.chkShowText.Text = "Show text";
         this.chkShowText.UseVisualStyleBackColor = true;
         this.chkShowText.CheckedChanged += new System.EventHandler(this.chkShowText_CheckedChanged);
         // 
         // chkNewPwd
         // 
         this.chkNewPwd.AutoSize = true;
         this.chkNewPwd.Checked = true;
         this.chkNewPwd.CheckState = System.Windows.Forms.CheckState.Checked;
         this.chkNewPwd.Location = new System.Drawing.Point(12, 12);
         this.chkNewPwd.Name = "chkNewPwd";
         this.chkNewPwd.Size = new System.Drawing.Size(200, 17);
         this.chkNewPwd.TabIndex = 4;
         this.chkNewPwd.Text = "Create a password to protect this file.";
         this.chkNewPwd.UseVisualStyleBackColor = true;
         this.chkNewPwd.CheckedChanged += new System.EventHandler(this.chkNewPwd_CheckedChanged);
         // 
         // lblWarning
         // 
         this.lblWarning.AutoSize = true;
         this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblWarning.ForeColor = System.Drawing.Color.Red;
         this.lblWarning.Location = new System.Drawing.Point(12, 159);
         this.lblWarning.Name = "lblWarning";
         this.lblWarning.Size = new System.Drawing.Size(301, 13);
         this.lblWarning.TabIndex = 1;
         this.lblWarning.Text = "WARNING: This file will not be password-protected.";
         // 
         // NewPasswordDlg
         // 
         this.AcceptButton = this.btnOK;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(354, 228);
         this.ControlBox = false;
         this.Controls.Add(this.lblWarning);
         this.Controls.Add(this.chkNewPwd);
         this.Controls.Add(this.grpNewPwd);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnOK);
         this.Name = "NewPasswordDlg";
         this.Text = "<app>";
         this.Load += new System.EventHandler(this.NewPasswordDlg_Load);
         this.grpNewPwd.ResumeLayout(false);
         this.grpNewPwd.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.GroupBox grpNewPwd;
      private System.Windows.Forms.TextBox txtNewPwd2;
      private System.Windows.Forms.CheckBox chkNewPwd;
      private System.Windows.Forms.CheckBox chkShowText;
      private System.Windows.Forms.TextBox txtNewPwd1;
      private System.Windows.Forms.Label lblWarning;
   }
}