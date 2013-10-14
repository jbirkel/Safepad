namespace Safepad
{
   partial class FindDlg
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
         this.label1 = new System.Windows.Forms.Label();
         this.txtFind = new System.Windows.Forms.TextBox();
         this.chkCase = new System.Windows.Forms.CheckBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.radDown = new System.Windows.Forms.RadioButton();
         this.radUp = new System.Windows.Forms.RadioButton();
         this.btnFind = new System.Windows.Forms.Button();
         this.btnClose = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 15);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(56, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "Find what:";
         // 
         // txtFind
         // 
         this.txtFind.Location = new System.Drawing.Point(73, 12);
         this.txtFind.Name = "txtFind";
         this.txtFind.Size = new System.Drawing.Size(189, 20);
         this.txtFind.TabIndex = 0;
         // 
         // chkCase
         // 
         this.chkCase.AutoSize = true;
         this.chkCase.Location = new System.Drawing.Point(15, 59);
         this.chkCase.Name = "chkCase";
         this.chkCase.Size = new System.Drawing.Size(82, 17);
         this.chkCase.TabIndex = 1;
         this.chkCase.Text = "Match case";
         this.chkCase.UseVisualStyleBackColor = true;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.radDown);
         this.groupBox1.Controls.Add(this.radUp);
         this.groupBox1.Location = new System.Drawing.Point(152, 39);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(110, 45);
         this.groupBox1.TabIndex = 2;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Direction";
         // 
         // radDown
         // 
         this.radDown.AutoSize = true;
         this.radDown.Location = new System.Drawing.Point(51, 19);
         this.radDown.Name = "radDown";
         this.radDown.Size = new System.Drawing.Size(53, 17);
         this.radDown.TabIndex = 1;
         this.radDown.TabStop = true;
         this.radDown.Text = "Down";
         this.radDown.UseVisualStyleBackColor = true;
         // 
         // radUp
         // 
         this.radUp.AutoSize = true;
         this.radUp.Location = new System.Drawing.Point(6, 19);
         this.radUp.Name = "radUp";
         this.radUp.Size = new System.Drawing.Size(39, 17);
         this.radUp.TabIndex = 0;
         this.radUp.TabStop = true;
         this.radUp.Text = "Up";
         this.radUp.UseVisualStyleBackColor = true;
         // 
         // btnFind
         // 
         this.btnFind.Location = new System.Drawing.Point(280, 10);
         this.btnFind.Name = "btnFind";
         this.btnFind.Size = new System.Drawing.Size(75, 23);
         this.btnFind.TabIndex = 3;
         this.btnFind.Text = "Find Next";
         this.btnFind.UseVisualStyleBackColor = true;
         this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
         // 
         // btnClose
         // 
         this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnClose.Location = new System.Drawing.Point(280, 39);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(75, 23);
         this.btnClose.TabIndex = 4;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = true;
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
         // 
         // FindDlg
         // 
         this.AcceptButton = this.btnFind;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnClose;
         this.ClientSize = new System.Drawing.Size(367, 97);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.btnFind);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.chkCase);
         this.Controls.Add(this.txtFind);
         this.Controls.Add(this.label1);
         this.Name = "FindDlg";
         this.Text = "FindDlg";
         this.Load += new System.EventHandler(this.FindDlg_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtFind;
      private System.Windows.Forms.CheckBox chkCase;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.RadioButton radDown;
      private System.Windows.Forms.RadioButton radUp;
      private System.Windows.Forms.Button btnFind;
      private System.Windows.Forms.Button btnClose;
   }
}