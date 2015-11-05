namespace Guifreaks.NavisuiteDemo
{
   partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node6", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node3");
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.labelPopupHeight = new System.Windows.Forms.Label();
            this.textBoxPopupHeight = new System.Windows.Forms.TextBox();
            this.buttonLoadSettings = new System.Windows.Forms.Button();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.ButtonAddBand = new System.Windows.Forms.Button();
            this.checkBoxGroupExpanded = new System.Windows.Forms.CheckBox();
            this.ButtonActivateBand = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxLayoutBar = new System.Windows.Forms.ComboBox();
            this.checkBoxRightToLeft = new System.Windows.Forms.CheckBox();
            this.checkBoxShowCollapseButton = new System.Windows.Forms.CheckBox();
            this.checkBoxCollapsed = new System.Windows.Forms.CheckBox();
            this.checkBoxMoreOptions = new System.Windows.Forms.CheckBox();
            this.labelSmallButtonsHeight = new System.Windows.Forms.Label();
            this.textBoxSmallButtonsHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVisibleButtons = new System.Windows.Forms.TextBox();
            this.labelHeaderHeight = new System.Windows.Forms.Label();
            this.textBoxHeaderHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxButtonHeight = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBarLog = new System.Windows.Forms.TextBox();
            this.openFileDialogSettings = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSettings = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.restToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.naviBar1 = new Guifreaks.Navisuite.NaviBar(this.components);
            this.naviBand2 = new Guifreaks.Navisuite.NaviBand(this.components);
            this.naviBand3 = new Guifreaks.Navisuite.NaviBand(this.components);
            this.naviGroup2 = new Guifreaks.Navisuite.NaviGroup(this.components);
            this.naviGroup1 = new Guifreaks.Navisuite.NaviGroup(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.naviBand1 = new Guifreaks.Navisuite.NaviBand(this.components);
            this.menuStrip1.SuspendLayout();
            this.naviBar1.SuspendLayout();
            this.naviBand2.SuspendLayout();
            this.naviBand3.ClientArea.SuspendLayout();
            this.naviBand3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naviGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naviGroup1)).BeginInit();
            this.naviGroup1.SuspendLayout();
            this.naviBand1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "bookmark.png");
            this.imageListLarge.Images.SetKeyName(1, "colorize.png");
            this.imageListLarge.Images.SetKeyName(2, "history.png");
            this.imageListLarge.Images.SetKeyName(3, "klipper.png");
            this.imageListLarge.Images.SetKeyName(4, "wizard.png");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "bookmark.png");
            this.imageListSmall.Images.SetKeyName(1, "colorize.png");
            this.imageListSmall.Images.SetKeyName(2, "history.png");
            this.imageListSmall.Images.SetKeyName(3, "klipper_dock.png");
            this.imageListSmall.Images.SetKeyName(4, "wizard.png");
            // 
            // labelPopupHeight
            // 
            this.labelPopupHeight.AutoSize = true;
            this.labelPopupHeight.Location = new System.Drawing.Point(275, 290);
            this.labelPopupHeight.Name = "labelPopupHeight";
            this.labelPopupHeight.Size = new System.Drawing.Size(67, 13);
            this.labelPopupHeight.TabIndex = 54;
            this.labelPopupHeight.Text = "Popupheight";
            // 
            // textBoxPopupHeight
            // 
            this.textBoxPopupHeight.Location = new System.Drawing.Point(382, 287);
            this.textBoxPopupHeight.Name = "textBoxPopupHeight";
            this.textBoxPopupHeight.Size = new System.Drawing.Size(128, 20);
            this.textBoxPopupHeight.TabIndex = 53;
            // 
            // buttonLoadSettings
            // 
            this.buttonLoadSettings.Location = new System.Drawing.Point(489, 41);
            this.buttonLoadSettings.Name = "buttonLoadSettings";
            this.buttonLoadSettings.Size = new System.Drawing.Size(101, 23);
            this.buttonLoadSettings.TabIndex = 52;
            this.buttonLoadSettings.Text = "Load settings";
            this.buttonLoadSettings.UseVisualStyleBackColor = true;
            this.buttonLoadSettings.Click += new System.EventHandler(this.buttonLoadSettings_Click);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(489, 12);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(101, 23);
            this.buttonSaveSettings.TabIndex = 51;
            this.buttonSaveSettings.Text = "Save settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // ButtonAddBand
            // 
            this.ButtonAddBand.Location = new System.Drawing.Point(382, 41);
            this.ButtonAddBand.Name = "ButtonAddBand";
            this.ButtonAddBand.Size = new System.Drawing.Size(101, 23);
            this.ButtonAddBand.TabIndex = 50;
            this.ButtonAddBand.Text = "Add band";
            this.ButtonAddBand.UseVisualStyleBackColor = true;
            this.ButtonAddBand.Click += new System.EventHandler(this.ButtonAddBand_Click);
            // 
            // checkBoxGroupExpanded
            // 
            this.checkBoxGroupExpanded.AutoSize = true;
            this.checkBoxGroupExpanded.Location = new System.Drawing.Point(445, 63);
            this.checkBoxGroupExpanded.Name = "checkBoxGroupExpanded";
            this.checkBoxGroupExpanded.Size = new System.Drawing.Size(143, 30);
            this.checkBoxGroupExpanded.TabIndex = 49;
            this.checkBoxGroupExpanded.Text = "Personal tasks (in tasks) \r\nexpanded";
            this.checkBoxGroupExpanded.UseVisualStyleBackColor = true;
            // 
            // ButtonActivateBand
            // 
            this.ButtonActivateBand.Location = new System.Drawing.Point(382, 12);
            this.ButtonActivateBand.Name = "ButtonActivateBand";
            this.ButtonActivateBand.Size = new System.Drawing.Size(101, 23);
            this.ButtonActivateBand.TabIndex = 48;
            this.ButtonActivateBand.Text = "Activate band 0";
            this.ButtonActivateBand.UseVisualStyleBackColor = true;
            this.ButtonActivateBand.Click += new System.EventHandler(this.ButtonActivateBand_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Layout";
            // 
            // ComboBoxLayoutBar
            // 
            this.ComboBoxLayoutBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxLayoutBar.FormattingEnabled = true;
            this.ComboBoxLayoutBar.Items.AddRange(new object[] {
            "Office 2003 Blue",
            "Office 2003 Green",
            "Office 2003 Silver",
            "Office 2007 Blue",
            "Office 2007 Black",
            "Office 2007 Silver",
            "Office 2010 Blue",
            "Office 2010 Black",
            "Office 2010 Silver"});
            this.ComboBoxLayoutBar.Location = new System.Drawing.Point(382, 317);
            this.ComboBoxLayoutBar.Name = "ComboBoxLayoutBar";
            this.ComboBoxLayoutBar.Size = new System.Drawing.Size(244, 21);
            this.ComboBoxLayoutBar.TabIndex = 46;
            this.ComboBoxLayoutBar.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLayoutBar_SelectedIndexChanged);
            // 
            // checkBoxRightToLeft
            // 
            this.checkBoxRightToLeft.AutoSize = true;
            this.checkBoxRightToLeft.Location = new System.Drawing.Point(278, 162);
            this.checkBoxRightToLeft.Name = "checkBoxRightToLeft";
            this.checkBoxRightToLeft.Size = new System.Drawing.Size(80, 17);
            this.checkBoxRightToLeft.TabIndex = 45;
            this.checkBoxRightToLeft.Text = "Right to left";
            this.checkBoxRightToLeft.UseVisualStyleBackColor = true;
            this.checkBoxRightToLeft.CheckedChanged += new System.EventHandler(this.checkBoxRightToLeft_CheckedChanged);
            // 
            // checkBoxShowCollapseButton
            // 
            this.checkBoxShowCollapseButton.AutoSize = true;
            this.checkBoxShowCollapseButton.Location = new System.Drawing.Point(278, 139);
            this.checkBoxShowCollapseButton.Name = "checkBoxShowCollapseButton";
            this.checkBoxShowCollapseButton.Size = new System.Drawing.Size(128, 17);
            this.checkBoxShowCollapseButton.TabIndex = 44;
            this.checkBoxShowCollapseButton.Text = "Show collapse button";
            this.checkBoxShowCollapseButton.UseVisualStyleBackColor = true;
            // 
            // checkBoxCollapsed
            // 
            this.checkBoxCollapsed.AutoSize = true;
            this.checkBoxCollapsed.Location = new System.Drawing.Point(278, 116);
            this.checkBoxCollapsed.Name = "checkBoxCollapsed";
            this.checkBoxCollapsed.Size = new System.Drawing.Size(72, 17);
            this.checkBoxCollapsed.TabIndex = 43;
            this.checkBoxCollapsed.Text = "Collapsed";
            this.checkBoxCollapsed.UseVisualStyleBackColor = true;
            // 
            // checkBoxMoreOptions
            // 
            this.checkBoxMoreOptions.AutoSize = true;
            this.checkBoxMoreOptions.Location = new System.Drawing.Point(278, 93);
            this.checkBoxMoreOptions.Name = "checkBoxMoreOptions";
            this.checkBoxMoreOptions.Size = new System.Drawing.Size(149, 17);
            this.checkBoxMoreOptions.TabIndex = 42;
            this.checkBoxMoreOptions.Text = "Show more options button";
            this.checkBoxMoreOptions.UseVisualStyleBackColor = true;
            // 
            // labelSmallButtonsHeight
            // 
            this.labelSmallButtonsHeight.AutoSize = true;
            this.labelSmallButtonsHeight.Location = new System.Drawing.Point(275, 186);
            this.labelSmallButtonsHeight.Name = "labelSmallButtonsHeight";
            this.labelSmallButtonsHeight.Size = new System.Drawing.Size(102, 13);
            this.labelSmallButtonsHeight.TabIndex = 41;
            this.labelSmallButtonsHeight.Text = "Height small buttons";
            // 
            // textBoxSmallButtonsHeight
            // 
            this.textBoxSmallButtonsHeight.Location = new System.Drawing.Point(382, 183);
            this.textBoxSmallButtonsHeight.Name = "textBoxSmallButtonsHeight";
            this.textBoxSmallButtonsHeight.Size = new System.Drawing.Size(128, 20);
            this.textBoxSmallButtonsHeight.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Visible large buttons";
            // 
            // textBoxVisibleButtons
            // 
            this.textBoxVisibleButtons.Location = new System.Drawing.Point(382, 209);
            this.textBoxVisibleButtons.Name = "textBoxVisibleButtons";
            this.textBoxVisibleButtons.Size = new System.Drawing.Size(128, 20);
            this.textBoxVisibleButtons.TabIndex = 38;
            // 
            // labelHeaderHeight
            // 
            this.labelHeaderHeight.AutoSize = true;
            this.labelHeaderHeight.Location = new System.Drawing.Point(275, 264);
            this.labelHeaderHeight.Name = "labelHeaderHeight";
            this.labelHeaderHeight.Size = new System.Drawing.Size(76, 13);
            this.labelHeaderHeight.TabIndex = 37;
            this.labelHeaderHeight.Text = "Header Height";
            // 
            // textBoxHeaderHeight
            // 
            this.textBoxHeaderHeight.Location = new System.Drawing.Point(382, 261);
            this.textBoxHeaderHeight.Name = "textBoxHeaderHeight";
            this.textBoxHeaderHeight.Size = new System.Drawing.Size(128, 20);
            this.textBoxHeaderHeight.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Button height";
            // 
            // textBoxButtonHeight
            // 
            this.textBoxButtonHeight.Location = new System.Drawing.Point(382, 235);
            this.textBoxButtonHeight.Name = "textBoxButtonHeight";
            this.textBoxButtonHeight.Size = new System.Drawing.Size(128, 20);
            this.textBoxButtonHeight.TabIndex = 34;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(278, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "Band 1 visible";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Less buttons";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "More buttons";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBarLog
            // 
            this.textBoxBarLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBarLog.Location = new System.Drawing.Point(274, 344);
            this.textBoxBarLog.Multiline = true;
            this.textBoxBarLog.Name = "textBoxBarLog";
            this.textBoxBarLog.Size = new System.Drawing.Size(354, 116);
            this.textBoxBarLog.TabIndex = 30;
            // 
            // openFileDialogSettings
            // 
            this.openFileDialogSettings.DefaultExt = "xml";
            this.openFileDialogSettings.FileName = "settings.xml";
            this.openFileDialogSettings.Filter = "XML Files|*.xml";
            this.openFileDialogSettings.Title = "Select a settings file";
            // 
            // saveFileDialogSettings
            // 
            this.saveFileDialogSettings.DefaultExt = "xml";
            this.saveFileDialogSettings.FileName = "settings.xml";
            this.saveFileDialogSettings.Filter = "XML Files|*.xml";
            this.saveFileDialogSettings.Title = "Save settings file as:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // restToolStripMenuItem
            // 
            this.restToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.restToolStripMenuItem.Name = "restToolStripMenuItem";
            this.restToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.restToolStripMenuItem.Text = "rest";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 6);
            // 
            // naviBar1
            // 
            this.naviBar1.ActiveBand = this.naviBand2;
            this.naviBar1.Controls.Add(this.naviBand3);
            this.naviBar1.Controls.Add(this.naviBand2);
            this.naviBar1.Controls.Add(this.naviBand1);
            this.naviBar1.LargeImages = this.imageListLarge;
            this.naviBar1.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.Office2010Blue;
            this.naviBar1.Location = new System.Drawing.Point(12, 22);
            this.naviBar1.Name = "naviBar1";
            this.naviBar1.Size = new System.Drawing.Size(232, 421);
            this.naviBar1.SmallImages = this.imageListSmall;
            this.naviBar1.TabIndex = 0;
            this.naviBar1.Text = "naviBar1";
            this.naviBar1.VisibleLargeButtons = 3;
            this.naviBar1.ActiveBandChanging += new Guifreaks.Navisuite.NaviBandEventHandler(this.naviBar1_ActiveBandChanging);
            this.naviBar1.ActiveBandChanged += new System.EventHandler(this.naviBar1_ActiveBandChanged);
            this.naviBar1.BandAdded += new System.Windows.Forms.ControlEventHandler(this.naviBar1_BandAdded);
            this.naviBar1.CollapsedBandClick += new System.EventHandler(this.naviBar1_CollapsedBandClick);
            this.naviBar1.CollapsedChanged += new System.EventHandler(this.naviBar1_CollapsedChanged);
            // 
            // naviBand2
            // 
            // 
            // naviBand2.ClientArea
            // 
            this.naviBand2.ClientArea.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.StyleFromOwner;
            this.naviBand2.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand2.ClientArea.Name = "ClientArea";
            this.naviBand2.ClientArea.Size = new System.Drawing.Size(230, 260);
            this.naviBand2.ClientArea.TabIndex = 0;
            this.naviBand2.LargeImageIndex = 1;
            this.naviBand2.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.StyleFromOwner;
            this.naviBand2.Location = new System.Drawing.Point(1, 27);
            this.naviBand2.Name = "naviBand2";
            this.naviBand2.Size = new System.Drawing.Size(230, 260);
            this.naviBand2.SmallImageIndex = 1;
            this.naviBand2.TabIndex = 5;
            this.naviBand2.Text = "Colors (B2)";
            // 
            // naviBand3
            // 
            // 
            // naviBand3.ClientArea
            // 
            this.naviBand3.ClientArea.Controls.Add(this.naviGroup2);
            this.naviBand3.ClientArea.Controls.Add(this.naviGroup1);
            this.naviBand3.ClientArea.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.StyleFromOwner;
            this.naviBand3.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand3.ClientArea.Name = "ClientArea";
            this.naviBand3.ClientArea.Size = new System.Drawing.Size(1, 1);
            this.naviBand3.ClientArea.TabIndex = 0;
            this.naviBand3.LargeImageIndex = 2;
            this.naviBand3.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.StyleFromOwner;
            this.naviBand3.Location = new System.Drawing.Point(1, 27);
            this.naviBand3.Name = "naviBand3";
            this.naviBand3.Size = new System.Drawing.Size(0, 0);
            this.naviBand3.SmallImageIndex = 3;
            this.naviBand3.TabIndex = 7;
            this.naviBand3.Text = "History (B3)";
            // 
            // naviGroup2
            // 
            this.naviGroup2.Caption = "Yesterday";
            this.naviGroup2.Dock = System.Windows.Forms.DockStyle.Top;
            this.naviGroup2.HeaderContextMenuStrip = null;
            this.naviGroup2.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.Office2003Blue;
            this.naviGroup2.Location = new System.Drawing.Point(0, 150);
            this.naviGroup2.Name = "naviGroup2";
            this.naviGroup2.Padding = new System.Windows.Forms.Padding(1, 22, 1, 1);
            this.naviGroup2.Size = new System.Drawing.Size(1, 150);
            this.naviGroup2.TabIndex = 56;
            this.naviGroup2.Text = "naviGroup2";
            this.naviGroup2.Click += new System.EventHandler(this.naviGroup2_Click);
            // 
            // naviGroup1
            // 
            this.naviGroup1.Caption = "Today";
            this.naviGroup1.Controls.Add(this.treeView1);
            this.naviGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.naviGroup1.HeaderContextMenuStrip = null;
            this.naviGroup1.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.Office2003Blue;
            this.naviGroup1.Location = new System.Drawing.Point(0, 0);
            this.naviGroup1.Name = "naviGroup1";
            this.naviGroup1.Padding = new System.Windows.Forms.Padding(1, 22, 1, 1);
            this.naviGroup1.Size = new System.Drawing.Size(1, 150);
            this.naviGroup1.TabIndex = 55;
            this.naviGroup1.Text = "naviGroup1";
            this.naviGroup1.Click += new System.EventHandler(this.naviGroup1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(1, 22);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Node4";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Node5";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Node1";
            treeNode5.Name = "Node8";
            treeNode5.Text = "Node8";
            treeNode6.Name = "Node9";
            treeNode6.Text = "Node9";
            treeNode7.Name = "Node6";
            treeNode7.Text = "Node6";
            treeNode8.Name = "Node7";
            treeNode8.Text = "Node7";
            treeNode9.Name = "Node2";
            treeNode9.Text = "Node2";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Node3";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode9,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(0, 127);
            this.treeView1.TabIndex = 57;
            // 
            // naviBand1
            // 
            // 
            // naviBand1.ClientArea
            // 
            this.naviBand1.ClientArea.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.StyleFromOwner;
            this.naviBand1.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand1.ClientArea.Name = "ClientArea";
            this.naviBand1.ClientArea.Size = new System.Drawing.Size(1, 1);
            this.naviBand1.ClientArea.TabIndex = 0;
            this.naviBand1.ClientArea.Text = "Naviband1";
            this.naviBand1.LargeImageIndex = 0;
            this.naviBand1.LayoutStyle = Guifreaks.Navisuite.NaviLayoutStyle.StyleFromOwner;
            this.naviBand1.Location = new System.Drawing.Point(1, 27);
            this.naviBand1.Name = "naviBand1";
            this.naviBand1.Size = new System.Drawing.Size(0, 0);
            this.naviBand1.SmallImageIndex = 0;
            this.naviBand1.TabIndex = 0;
            this.naviBand1.Text = "Favorites (B1)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 483);
            this.Controls.Add(this.naviBar1);
            this.Controls.Add(this.labelPopupHeight);
            this.Controls.Add(this.textBoxPopupHeight);
            this.Controls.Add(this.buttonLoadSettings);
            this.Controls.Add(this.buttonSaveSettings);
            this.Controls.Add(this.ButtonAddBand);
            this.Controls.Add(this.checkBoxGroupExpanded);
            this.Controls.Add(this.ButtonActivateBand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBoxLayoutBar);
            this.Controls.Add(this.checkBoxRightToLeft);
            this.Controls.Add(this.checkBoxShowCollapseButton);
            this.Controls.Add(this.checkBoxCollapsed);
            this.Controls.Add(this.checkBoxMoreOptions);
            this.Controls.Add(this.labelSmallButtonsHeight);
            this.Controls.Add(this.textBoxSmallButtonsHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVisibleButtons);
            this.Controls.Add(this.labelHeaderHeight);
            this.Controls.Add(this.textBoxHeaderHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxButtonHeight);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxBarLog);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.naviBar1.ResumeLayout(false);
            this.naviBand2.ResumeLayout(false);
            this.naviBand3.ClientArea.ResumeLayout(false);
            this.naviBand3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.naviGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naviGroup1)).EndInit();
            this.naviGroup1.ResumeLayout(false);
            this.naviBand1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private Guifreaks.Navisuite.NaviBar naviBar1;
      private Guifreaks.Navisuite.NaviBand naviBand1;
      private Guifreaks.Navisuite.NaviBand naviBand2;
      private Guifreaks.Navisuite.NaviBand naviBand3;
      private System.Windows.Forms.Label labelPopupHeight;
      private System.Windows.Forms.TextBox textBoxPopupHeight;
      private System.Windows.Forms.Button buttonLoadSettings;
      private System.Windows.Forms.Button buttonSaveSettings;
      private System.Windows.Forms.Button ButtonAddBand;
      private System.Windows.Forms.CheckBox checkBoxGroupExpanded;
      private System.Windows.Forms.Button ButtonActivateBand;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ComboBox ComboBoxLayoutBar;
      private System.Windows.Forms.CheckBox checkBoxRightToLeft;
      private System.Windows.Forms.CheckBox checkBoxShowCollapseButton;
      private System.Windows.Forms.CheckBox checkBoxCollapsed;
      private System.Windows.Forms.CheckBox checkBoxMoreOptions;
      private System.Windows.Forms.Label labelSmallButtonsHeight;
      private System.Windows.Forms.TextBox textBoxSmallButtonsHeight;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox textBoxVisibleButtons;
      private System.Windows.Forms.Label labelHeaderHeight;
      private System.Windows.Forms.TextBox textBoxHeaderHeight;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBoxButtonHeight;
      private System.Windows.Forms.CheckBox checkBox1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox textBoxBarLog;
      private System.Windows.Forms.ImageList imageListSmall;
      private System.Windows.Forms.ImageList imageListLarge;
      private Guifreaks.Navisuite.NaviGroup naviGroup2;
      private Guifreaks.Navisuite.NaviGroup naviGroup1;
      private System.Windows.Forms.OpenFileDialog openFileDialogSettings;
      private System.Windows.Forms.SaveFileDialog saveFileDialogSettings;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem restToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
      private System.Windows.Forms.TreeView treeView1;
   }
}

