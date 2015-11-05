#region License and Copyright
/*
 
Copyright (c) Guifreaks - Jacob Mesu
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the Guifreaks nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

*/
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Guifreaks.Navisuite;
using Microsoft.Xml.Serialization.GeneratedAssembly;
using System.IO;
using System.Threading;
using System.Globalization;

namespace Guifreaks.NavisuiteDemo
{
   public partial class FormMain : Form
   {
      public FormMain()
      {
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");

         InitializeComponent();

         checkBox1.DataBindings.Add(new Binding("Checked", naviBand1, "Visible",
            true, DataSourceUpdateMode.OnPropertyChanged));
         textBoxButtonHeight.DataBindings.Add(new Binding("Text", naviBar1,
            "ButtonHeight", true, DataSourceUpdateMode.OnPropertyChanged));
         textBoxHeaderHeight.DataBindings.Add(new Binding("Text", naviBar1,
            "HeaderHeight", true, DataSourceUpdateMode.OnPropertyChanged));
         textBoxVisibleButtons.DataBindings.Add(new Binding("Text", naviBar1,
            "VisibleLargeButtons", true, DataSourceUpdateMode.OnValidation));
         textBoxSmallButtonsHeight.DataBindings.Add(new Binding("Text", naviBar1,
            "MinimizedPanelHeight", true, DataSourceUpdateMode.OnValidation));
         textBoxPopupHeight.DataBindings.Add(new Binding("Text", naviBar1,
            "PopupHeight", true, DataSourceUpdateMode.OnValidation));


         checkBoxMoreOptions.DataBindings.Add(new Binding("Checked", naviBar1, "ShowMoreOptionsButton",
            true, DataSourceUpdateMode.OnPropertyChanged));
         checkBoxCollapsed.DataBindings.Add(new Binding("Checked", naviBar1, "Collapsed",
            true, DataSourceUpdateMode.OnPropertyChanged));
         checkBoxShowCollapseButton.DataBindings.Add(new Binding("Checked", naviBar1,
            "ShowCollapseButton", true, DataSourceUpdateMode.OnPropertyChanged));
         checkBoxGroupExpanded.DataBindings.Add(new Binding("Checked", naviGroup1,
            "Expanded", true, DataSourceUpdateMode.OnPropertyChanged));

         naviGroup1.LayoutStyle = naviBar1.LayoutStyle;
         naviGroup2.LayoutStyle = naviBar1.LayoutStyle;
      }

      private void naviGroup2_Click(object sender, EventArgs e)
      {

      }

      private void naviBar1_ActiveBandChanged(object sender, EventArgs e)
      {
         textBoxBarLog.AppendText("BandChanged" + Environment.NewLine);
      }

      private void naviBar1_ActiveBandChanging(object sender, Guifreaks.Navisuite.NaviBandEventArgs e)
      {
			if (e.NewActiveBand == naviBand2)
			{
				MessageBox.Show("Test succeeded");
				e.Canceled = true;
			}
					
			
			//textBoxBarLog.AppendText("BandChanging" + Environment.NewLine);
         //if (e.NewActiveBand == naviBand2)
         //{
			//   if (MessageBox.Show("Do you want to change to Band 2?", "Confirm",
			//      MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
			//   {
			//      e.Canceled = true;
			//   }
			//}
      }

      private void naviBar1_BandAdded(object sender, ControlEventArgs e)
      {
         textBoxBarLog.AppendText("BandAdded" + Environment.NewLine);
      }

      private void button1_Click(object sender, EventArgs e)
      {
         if (naviBar1.NaviLayoutEngine is NaviLayoutEngineOffice)
         {
									naviBar1.VisibleLargeButtons++;         
         }
      }

      private void ButtonActivateBand_Click(object sender, EventArgs e)
      {
         naviBar1.ActiveBand = naviBar1.Bands[0];
      }

      private void buttonSaveSettings_Click(object sender, EventArgs e)
      {
         if (saveFileDialogSettings.ShowDialog() == DialogResult.OK)
         {
            try
            {
               string fileName = saveFileDialogSettings.FileName;
               NaviBarSettingsSerializer serial = new NaviBarSettingsSerializer();
               using (TextWriter w = new StreamWriter(fileName))
               {
                  serial.Serialize(w, naviBar1.Settings);
               }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
         }

      }

      private void button2_Click(object sender, EventArgs e)
      {
         if (naviBar1.NaviLayoutEngine is NaviLayoutEngineOffice)
         {
				if (naviBar1.VisibleLargeButtons > 0)
					naviBar1.VisibleLargeButtons--;
         }
      }

      private void ButtonAddBand_Click(object sender, EventArgs e)
      {
         naviBar1.SuspendLayout();
         NaviBand band = new NaviBand();

         band.Text = "NaviBand" + (naviBar1.Bands.Count + 1).ToString();
         band.Name = "NaviBand" + (naviBar1.Bands.Count + 1).ToString();
         band.LargeImageIndex = 2;
         band.SmallImageIndex = 2;

         naviBar1.Controls.Add(band);
         naviBar1.ResumeLayout();
         naviBar1.PerformLayout();
      }

      private void buttonLoadSettings_Click(object sender, EventArgs e)
      {
         if (openFileDialogSettings.ShowDialog() == DialogResult.OK)
         {
            try
            {
               string fileName = openFileDialogSettings.FileName;
               NaviBarSettingsSerializer serial = new NaviBarSettingsSerializer();
               using (StreamReader reader = new StreamReader(fileName))
               {
                  NaviBarSettings settings = serial.Deserialize(reader) as NaviBarSettings;
                  if (settings != null)
                  {
                     naviBar1.Settings = settings;
                     naviBar1.ApplySettings();
                  }
               }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
         }

      }

      private void checkBoxRightToLeft_CheckedChanged(object sender, EventArgs e)
      {
         if (checkBoxRightToLeft.Checked)
            RightToLeft = RightToLeft.Yes;
         else
            RightToLeft = RightToLeft.No;
      }

      private void ComboBoxLayoutBar_SelectedIndexChanged(object sender, EventArgs e)
      {
         switch (ComboBoxLayoutBar.SelectedItem.ToString())
         {
            case "Office 2003 Blue":
               naviBar1.LayoutStyle = NaviLayoutStyle.Office2003Blue;
               break;
            case "Office 2003 Green":
               naviBar1.LayoutStyle = NaviLayoutStyle.Office2003Green;
               break;
            case "Office 2003 Silver":
               naviBar1.LayoutStyle = NaviLayoutStyle.Office2003Silver;
               break;
            case "Office 2007 Blue":
               naviBar1.LayoutStyle = NaviLayoutStyle.Office2007Blue;
               break;
            case "Office 2007 Black":
               naviBar1.LayoutStyle = NaviLayoutStyle.Office2007Black;
               break;
            case "Office 2007 Silver":
               naviBar1.LayoutStyle = NaviLayoutStyle.Office2007Silver;
               break;
            case "Office 2010 Blue":
               naviBar1.LayoutStyle = NaviLayoutStyle.Office2010Blue;
               break;
            case "Office 2010 Black":
               naviBar1.LayoutStyle = NaviLayoutStyle.Office2010Black;
               break;
            case "Office 2010 Silver":
               naviBar1.LayoutStyle = NaviLayoutStyle.Office2010Silver;
               break;
            case "Office Guifreaks":
               break;
         }
         naviGroup1.LayoutStyle = naviBar1.LayoutStyle;
         naviGroup2.LayoutStyle = naviBar1.LayoutStyle;
      }

      private void naviGroup1_Click(object sender, EventArgs e)
      {

      }

		private void naviBar1_CollapsedBandClick(object sender, EventArgs e)
		{
			textBoxBarLog.AppendText("CollapsedBandClick" + Environment.NewLine);
		}

		private void naviBar1_CollapsedChanged(object sender, EventArgs e)
		{
			textBoxBarLog.AppendText("CollapsedChanged" + Environment.NewLine);
		}
   }
}
