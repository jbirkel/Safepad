namespace Safepad
{
   partial class GotoDlg
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
         this.btnOK = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.numGoto = new System.Windows.Forms.NumericUpDown();
         ((System.ComponentModel.ISupportInitialize)(this.numGoto)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(13, 13);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(55, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Go to line:";
         // 
         // btnOK
         // 
         this.btnOK.Location = new System.Drawing.Point(79, 57);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(75, 23);
         this.btnOK.TabIndex = 1;
         this.btnOK.Text = "OK";
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(161, 56);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 2;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // numGoto
         // 
         this.numGoto.Location = new System.Drawing.Point(16, 31);
         this.numGoto.Name = "numGoto";
         this.numGoto.Size = new System.Drawing.Size(220, 20);
         this.numGoto.TabIndex = 0;
         // 
         // GotoDlg
         // 
         this.AcceptButton = this.btnOK;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(253, 92);
         this.Controls.Add(this.numGoto);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.label1);
         this.Name = "GotoDlg";
         this.Text = "<title>";
         this.Load += new System.EventHandler(this.GotoDlg_Load);
         ((System.ComponentModel.ISupportInitialize)(this.numGoto)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.NumericUpDown numGoto;
   }
}