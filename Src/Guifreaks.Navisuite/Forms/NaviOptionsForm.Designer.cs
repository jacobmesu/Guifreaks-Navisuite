namespace Guifreaks.Navisuite
{
   partial class NaviOptionsForm
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
         this.labelDesc = new System.Windows.Forms.Label();
         this.buttonMoveUp = new System.Windows.Forms.Button();
         this.buttonReset = new System.Windows.Forms.Button();
         this.buttonMoveDown = new System.Windows.Forms.Button();
         this.buttonOk = new System.Windows.Forms.Button();
         this.buttonCancel = new System.Windows.Forms.Button();
         this.checkedListBoxBands = new Guifreaks.Navisuite.NaviCheckedListBox();
         this.SuspendLayout();
         // 
         // labelDesc
         // 
         this.labelDesc.AutoSize = true;
         this.labelDesc.Location = new System.Drawing.Point(12, 9);
         this.labelDesc.Name = "labelDesc";
         this.labelDesc.Size = new System.Drawing.Size(136, 13);
         this.labelDesc.TabIndex = 0;
         this.labelDesc.Text = "Display buttons in this order";
         // 
         // buttonMoveUp
         // 
         this.buttonMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonMoveUp.Location = new System.Drawing.Point(208, 43);
         this.buttonMoveUp.Name = "buttonMoveUp";
         this.buttonMoveUp.Size = new System.Drawing.Size(75, 23);
         this.buttonMoveUp.TabIndex = 1;
         this.buttonMoveUp.Text = "Move up";
         this.buttonMoveUp.UseVisualStyleBackColor = true;
         this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
         // 
         // buttonReset
         // 
         this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonReset.Location = new System.Drawing.Point(208, 101);
         this.buttonReset.Name = "buttonReset";
         this.buttonReset.Size = new System.Drawing.Size(75, 23);
         this.buttonReset.TabIndex = 2;
         this.buttonReset.Text = "Reset";
         this.buttonReset.UseVisualStyleBackColor = true;
         this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
         // 
         // buttonMoveDown
         // 
         this.buttonMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonMoveDown.Location = new System.Drawing.Point(208, 72);
         this.buttonMoveDown.Name = "buttonMoveDown";
         this.buttonMoveDown.Size = new System.Drawing.Size(75, 23);
         this.buttonMoveDown.TabIndex = 3;
         this.buttonMoveDown.Text = "Move down";
         this.buttonMoveDown.UseVisualStyleBackColor = true;
         this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
         // 
         // buttonOk
         // 
         this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.buttonOk.Location = new System.Drawing.Point(124, 231);
         this.buttonOk.Name = "buttonOk";
         this.buttonOk.Size = new System.Drawing.Size(75, 23);
         this.buttonOk.TabIndex = 4;
         this.buttonOk.Text = "Ok";
         this.buttonOk.UseVisualStyleBackColor = true;
         this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
         // 
         // buttonCancel
         // 
         this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.buttonCancel.Location = new System.Drawing.Point(205, 231);
         this.buttonCancel.Name = "buttonCancel";
         this.buttonCancel.Size = new System.Drawing.Size(75, 23);
         this.buttonCancel.TabIndex = 5;
         this.buttonCancel.Text = "Cancel";
         this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
         // 
         // checkedListBoxBands
         // 
         this.checkedListBoxBands.FormattingEnabled = true;
         this.checkedListBoxBands.Location = new System.Drawing.Point(12, 30);
         this.checkedListBoxBands.Name = "checkedListBoxBands";
         this.checkedListBoxBands.Size = new System.Drawing.Size(187, 184);
         this.checkedListBoxBands.TabIndex = 6;
         // 
         // NaviOptionsForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(292, 266);
         this.Controls.Add(this.checkedListBoxBands);
         this.Controls.Add(this.buttonCancel);
         this.Controls.Add(this.buttonOk);
         this.Controls.Add(this.buttonMoveDown);
         this.Controls.Add(this.buttonReset);
         this.Controls.Add(this.buttonMoveUp);
         this.Controls.Add(this.labelDesc);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "NaviOptionsForm";
         this.Text = "Options of the Navigation Pane";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label labelDesc;
      private System.Windows.Forms.Button buttonMoveUp;
      private System.Windows.Forms.Button buttonReset;
      private System.Windows.Forms.Button buttonMoveDown;
      private System.Windows.Forms.Button buttonOk;
      private System.Windows.Forms.Button buttonCancel;
      private NaviCheckedListBox checkedListBoxBands;
   }
}