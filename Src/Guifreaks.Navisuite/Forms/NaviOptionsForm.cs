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
using System.Resources;
using System.Reflection;

namespace Guifreaks.Navisuite
{
   public partial class NaviOptionsForm : Form
   {
      NaviBar bar;

      public NaviOptionsForm()
      {
         InitializeComponent();
      }

      public void Initialize(NaviBar bar)
      {
         this.bar = bar;
         checkedListBoxBands.Items.Clear();
         foreach (NaviBand band in bar.Bands)
         {
            checkedListBoxBands.Items.Add(band.Text, band.Visible);
         }
         Translate();
      }

      private void Translate()
      {
         ResourceManager rm = new ResourceManager(
            "Guifreaks.NaviSuite.Resources.Text", Assembly.GetExecutingAssembly());
         
         buttonCancel.Text = rm.GetString("OptionsCancel");
         buttonOk.Text = rm.GetString("OptionsOk");
         labelDesc.Text = rm.GetString("OptionsIntro");
         buttonMoveDown.Text = rm.GetString("OptionsMoveDown");
         buttonMoveUp.Text = rm.GetString("OptionsMoveUp");
         buttonReset.Text = rm.GetString("OptionsReset");
         Text = rm.GetString("OptionsTitle");
      }

      private void buttonOk_Click(object sender, EventArgs e)
      {
         // Set the new order
         for (int i = 0; i < bar.Bands.Count; i++)
         {
            int loc = checkedListBoxBands.Items.IndexOf(bar.Bands[i].Text);
            bar.Bands[i].Visible = checkedListBoxBands.CheckedItems.Contains(bar.Bands[i].Text);
            bar.Bands[i].Order = loc;
         }

         // And sort the list based on the new order
         bar.Bands.Sort(new NaviBandOrderComparer());
      }

      private void buttonMoveUp_Click(object sender, EventArgs e)
      {
         if (checkedListBoxBands.SelectedIndex > 0)
         {
            bool oldChecked = checkedListBoxBands.CheckedIndices.Contains(
               checkedListBoxBands.SelectedIndex - 1);
            bool oldChecked2 = checkedListBoxBands.CheckedIndices.Contains(
               checkedListBoxBands.SelectedIndex);

            object oldItem = checkedListBoxBands.Items[checkedListBoxBands.SelectedIndex - 1];
            checkedListBoxBands.Items[checkedListBoxBands.SelectedIndex - 1] =
               checkedListBoxBands.SelectedItem;

            checkedListBoxBands.SetItemChecked(checkedListBoxBands.SelectedIndex,
               oldChecked);
            checkedListBoxBands.SetItemChecked(checkedListBoxBands.SelectedIndex - 1,
               oldChecked2);

            checkedListBoxBands.Items[checkedListBoxBands.SelectedIndex] = oldItem;
            checkedListBoxBands.SelectedIndex -= 1;
         }
      }

      private void buttonMoveDown_Click(object sender, EventArgs e)
      {
         if ((checkedListBoxBands.SelectedIndex > 0)
         && (checkedListBoxBands.SelectedIndex < checkedListBoxBands.Items.Count - 1))
         {
            bool oldChecked = checkedListBoxBands.CheckedIndices.Contains(
               checkedListBoxBands.SelectedIndex + 1);
            bool oldChecked2 = checkedListBoxBands.CheckedIndices.Contains(
               checkedListBoxBands.SelectedIndex);

            object oldItem = checkedListBoxBands.Items[checkedListBoxBands.SelectedIndex + 1];
            checkedListBoxBands.Items[checkedListBoxBands.SelectedIndex + 1] =
               checkedListBoxBands.SelectedItem;

            checkedListBoxBands.SetItemChecked(checkedListBoxBands.SelectedIndex,
               oldChecked);
            checkedListBoxBands.SetItemChecked(checkedListBoxBands.SelectedIndex + 1,
               oldChecked2);

            checkedListBoxBands.Items[checkedListBoxBands.SelectedIndex] = oldItem;
            checkedListBoxBands.SelectedIndex += 1;
         }
      }

      private void buttonReset_Click(object sender, EventArgs e)
      {
         // Sort list based on original order
         bar.Bands.Sort(new NaviBandOrgOrderComparer());
         Initialize(bar);
      }

      private void buttonCancel_Click(object sender, EventArgs e)
      {
         // Reset ordering posibly caused by reset button
         bar.Bands.Sort(new NaviBandOrderComparer());
      }
   }
}
