namespace aTree
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabDelimitedFiletsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commaSeparatedcsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tvStructure = new System.Windows.Forms.TreeView();
            this.imlTree = new System.Windows.Forms.ImageList(this.components);
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpDetail = new System.Windows.Forms.TabPage();
            this.pnDetail = new System.Windows.Forms.Panel();
            this.tcItem = new System.Windows.Forms.TabControl();
            this.tpBasicPermissions = new System.Windows.Forms.TabPage();
            this.clbBasic = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpAdvancedPermissions = new System.Windows.Forms.TabPage();
            this.clbAdvanced = new System.Windows.Forms.CheckedListBox();
            this.tbAdvancedAppliesTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAccessType = new System.Windows.Forms.TextBox();
            this.tbPrincipal = new System.Windows.Forms.TextBox();
            this.lbPrincipal = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.tpFileFolder = new System.Windows.Forms.TabPage();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.tbFullPath = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tcFileFolderDetails = new System.Windows.Forms.TabControl();
            this.tpFileFolderDetails = new System.Windows.Forms.TabPage();
            this.tbOwner = new System.Windows.Forms.TextBox();
            this.tbLastAccessTime = new System.Windows.Forms.TextBox();
            this.tbModificationTime = new System.Windows.Forms.TextBox();
            this.tbCreationTime = new System.Windows.Forms.TextBox();
            this.lbOwner = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCreationTime = new System.Windows.Forms.Label();
            this.lbModificationTime = new System.Windows.Forms.Label();
            this.tpFileFolderAttributes = new System.Windows.Forms.TabPage();
            this.clbFileFolderAttributes = new System.Windows.Forms.CheckedListBox();
            this.tpError = new System.Windows.Forms.TabPage();
            this.tbStackTrace = new System.Windows.Forms.TextBox();
            this.lbStackTrace = new System.Windows.Forms.Label();
            this.tbError = new System.Windows.Forms.TextBox();
            this.lbErrorMessage = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbFullPath = new System.Windows.Forms.Label();
            this.tpDefault = new System.Windows.Forms.TabPage();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbStartScanning = new System.Windows.Forms.ToolStripButton();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslScanDirection = new System.Windows.Forms.ToolStripLabel();
            this.tscScanDirection = new System.Windows.Forms.ToolStripComboBox();
            this.tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslLevelCount = new System.Windows.Forms.ToolStripLabel();
            this.ttbLevelCount = new System.Windows.Forms.ToolStripTextBox();
            this.tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslInheritedItems = new System.Windows.Forms.ToolStripLabel();
            this.tsbShowInherited = new System.Windows.Forms.ToolStripButton();
            this.tsbFiles = new System.Windows.Forms.ToolStripButton();
            this.tsbFileSize = new System.Windows.Forms.ToolStripButton();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tslProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.bwMain = new System.ComponentModel.BackgroundWorker();
            this.bwBuildTree = new System.ComponentModel.BackgroundWorker();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.cmsTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bwCreateSvItem = new System.ComponentModel.BackgroundWorker();
            this.bwOpenFile = new System.ComponentModel.BackgroundWorker();
            this.bwSaveFile = new System.ComponentModel.BackgroundWorker();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpDetail.SuspendLayout();
            this.pnDetail.SuspendLayout();
            this.tcItem.SuspendLayout();
            this.tpBasicPermissions.SuspendLayout();
            this.tpAdvancedPermissions.SuspendLayout();
            this.tpFileFolder.SuspendLayout();
            this.tcFileFolderDetails.SuspendLayout();
            this.tpFileFolderDetails.SuspendLayout();
            this.tpFileFolderAttributes.SuspendLayout();
            this.tpError.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(937, 28);
            this.msMain.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTreeToolStripMenuItem,
            this.openTreeToolStripMenuItem,
            this.exportTreeToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveTreeToolStripMenuItem
            // 
            this.saveTreeToolStripMenuItem.Name = "saveTreeToolStripMenuItem";
            this.saveTreeToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.saveTreeToolStripMenuItem.Text = "&Save Tree";
            this.saveTreeToolStripMenuItem.Click += new System.EventHandler(this.saveTreeToolStripMenuItem_Click);
            // 
            // openTreeToolStripMenuItem
            // 
            this.openTreeToolStripMenuItem.Name = "openTreeToolStripMenuItem";
            this.openTreeToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.openTreeToolStripMenuItem.Text = "&Open Tree";
            this.openTreeToolStripMenuItem.Click += new System.EventHandler(this.openTreeToolStripMenuItem_Click);
            // 
            // exportTreeToolStripMenuItem
            // 
            this.exportTreeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabDelimitedFiletsvToolStripMenuItem,
            this.commaSeparatedcsvToolStripMenuItem});
            this.exportTreeToolStripMenuItem.Name = "exportTreeToolStripMenuItem";
            this.exportTreeToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.exportTreeToolStripMenuItem.Text = "&Export Tree";
            // 
            // tabDelimitedFiletsvToolStripMenuItem
            // 
            this.tabDelimitedFiletsvToolStripMenuItem.Name = "tabDelimitedFiletsvToolStripMenuItem";
            this.tabDelimitedFiletsvToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.tabDelimitedFiletsvToolStripMenuItem.Text = "Tab-Separated (.tsv)";
            this.tabDelimitedFiletsvToolStripMenuItem.Click += new System.EventHandler(this.tabDelimitedFiletsvToolStripMenuItem_Click);
            // 
            // commaSeparatedcsvToolStripMenuItem
            // 
            this.commaSeparatedcsvToolStripMenuItem.Name = "commaSeparatedcsvToolStripMenuItem";
            this.commaSeparatedcsvToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.commaSeparatedcsvToolStripMenuItem.Text = "Comma-Separated (.csv)";
            this.commaSeparatedcsvToolStripMenuItem.Click += new System.EventHandler(this.commaSeparatedcsvToolStripMenuItem_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to Cli&pboard";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.advancedToolStripMenuItem.Text = "&Advanced";
            this.advancedToolStripMenuItem.Click += new System.EventHandler(this.advancedToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // scMain
            // 
            this.scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scMain.Location = new System.Drawing.Point(1, 100);
            this.scMain.Margin = new System.Windows.Forms.Padding(4);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tvStructure);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.tcMain);
            this.scMain.Size = new System.Drawing.Size(936, 546);
            this.scMain.SplitterDistance = 310;
            this.scMain.SplitterWidth = 5;
            this.scMain.TabIndex = 1;
            // 
            // tvStructure
            // 
            this.tvStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvStructure.ImageIndex = 0;
            this.tvStructure.ImageList = this.imlTree;
            this.tvStructure.Location = new System.Drawing.Point(0, 0);
            this.tvStructure.Margin = new System.Windows.Forms.Padding(4);
            this.tvStructure.Name = "tvStructure";
            this.tvStructure.SelectedImageIndex = 0;
            this.tvStructure.Size = new System.Drawing.Size(310, 546);
            this.tvStructure.TabIndex = 0;
            this.tvStructure.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvStructure_BeforeSelect);
            this.tvStructure.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvStructure_NodeMouseClick);
            // 
            // imlTree
            // 
            this.imlTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTree.ImageStream")));
            this.imlTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imlTree.Images.SetKeyName(0, "folder16x16.ico");
            this.imlTree.Images.SetKeyName(1, "foldererror16x16.ico");
            this.imlTree.Images.SetKeyName(2, "file16x16.png");
            this.imlTree.Images.SetKeyName(3, "fileerror16x16.ico");
            this.imlTree.Images.SetKeyName(4, "user16x16.ico");
            this.imlTree.Images.SetKeyName(5, "usererror16x16.ico");
            this.imlTree.Images.SetKeyName(6, "group16x16.ico");
            this.imlTree.Images.SetKeyName(7, "grouperror16x16.ico");
            this.imlTree.Images.SetKeyName(8, "sid16x16.ico");
            this.imlTree.Images.SetKeyName(9, "siderror16x16.ico");
            this.imlTree.Images.SetKeyName(10, "userinherited16x16.ico");
            this.imlTree.Images.SetKeyName(11, "userinheritederror16x16.ico");
            this.imlTree.Images.SetKeyName(12, "groupinherited16x16.ico");
            this.imlTree.Images.SetKeyName(13, "groupinheritederror16x16.ico");
            this.imlTree.Images.SetKeyName(14, "sidinherited16x16.ico");
            this.imlTree.Images.SetKeyName(15, "sidinheritederror16x16.ico");
            this.imlTree.Images.SetKeyName(16, "link16x16.png");
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpDetail);
            this.tcMain.Controls.Add(this.tpFileFolder);
            this.tcMain.Controls.Add(this.tpDefault);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(621, 546);
            this.tcMain.TabIndex = 4;
            // 
            // tpDetail
            // 
            this.tpDetail.Controls.Add(this.pnDetail);
            this.tpDetail.Location = new System.Drawing.Point(4, 25);
            this.tpDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tpDetail.Name = "tpDetail";
            this.tpDetail.Padding = new System.Windows.Forms.Padding(4);
            this.tpDetail.Size = new System.Drawing.Size(613, 517);
            this.tpDetail.TabIndex = 0;
            this.tpDetail.Text = "Detail";
            this.tpDetail.UseVisualStyleBackColor = true;
            // 
            // pnDetail
            // 
            this.pnDetail.Controls.Add(this.tcItem);
            this.pnDetail.Controls.Add(this.tbAccessType);
            this.pnDetail.Controls.Add(this.tbPrincipal);
            this.pnDetail.Controls.Add(this.lbPrincipal);
            this.pnDetail.Controls.Add(this.lbType);
            this.pnDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDetail.Location = new System.Drawing.Point(4, 4);
            this.pnDetail.Margin = new System.Windows.Forms.Padding(4);
            this.pnDetail.Name = "pnDetail";
            this.pnDetail.Size = new System.Drawing.Size(605, 509);
            this.pnDetail.TabIndex = 3;
            // 
            // tcItem
            // 
            this.tcItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcItem.Controls.Add(this.tpBasicPermissions);
            this.tcItem.Controls.Add(this.tpAdvancedPermissions);
            this.tcItem.Location = new System.Drawing.Point(16, 166);
            this.tcItem.Margin = new System.Windows.Forms.Padding(4);
            this.tcItem.Name = "tcItem";
            this.tcItem.SelectedIndex = 0;
            this.tcItem.Size = new System.Drawing.Size(577, 339);
            this.tcItem.TabIndex = 5;
            // 
            // tpBasicPermissions
            // 
            this.tpBasicPermissions.Controls.Add(this.clbBasic);
            this.tpBasicPermissions.Controls.Add(this.textBox1);
            this.tpBasicPermissions.Controls.Add(this.label2);
            this.tpBasicPermissions.Location = new System.Drawing.Point(4, 25);
            this.tpBasicPermissions.Margin = new System.Windows.Forms.Padding(4);
            this.tpBasicPermissions.Name = "tpBasicPermissions";
            this.tpBasicPermissions.Padding = new System.Windows.Forms.Padding(4);
            this.tpBasicPermissions.Size = new System.Drawing.Size(569, 310);
            this.tpBasicPermissions.TabIndex = 0;
            this.tpBasicPermissions.Text = "Basic Permissions";
            this.tpBasicPermissions.UseVisualStyleBackColor = true;
            // 
            // clbBasic
            // 
            this.clbBasic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbBasic.FormattingEnabled = true;
            this.clbBasic.Items.AddRange(new object[] {
            "Full control",
            "Modify",
            "Read & execute",
            "List folder contents",
            "Read",
            "Write",
            "Special permissions"});
            this.clbBasic.Location = new System.Drawing.Point(8, 49);
            this.clbBasic.Margin = new System.Windows.Forms.Padding(4);
            this.clbBasic.Name = "clbBasic";
            this.clbBasic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clbBasic.Size = new System.Drawing.Size(549, 225);
            this.clbBasic.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(109, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(449, 15);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Applies To:";
            // 
            // tpAdvancedPermissions
            // 
            this.tpAdvancedPermissions.Controls.Add(this.clbAdvanced);
            this.tpAdvancedPermissions.Controls.Add(this.tbAdvancedAppliesTo);
            this.tpAdvancedPermissions.Controls.Add(this.label1);
            this.tpAdvancedPermissions.Location = new System.Drawing.Point(4, 25);
            this.tpAdvancedPermissions.Margin = new System.Windows.Forms.Padding(4);
            this.tpAdvancedPermissions.Name = "tpAdvancedPermissions";
            this.tpAdvancedPermissions.Padding = new System.Windows.Forms.Padding(4);
            this.tpAdvancedPermissions.Size = new System.Drawing.Size(569, 310);
            this.tpAdvancedPermissions.TabIndex = 1;
            this.tpAdvancedPermissions.Text = "Advanced Permissions";
            this.tpAdvancedPermissions.UseVisualStyleBackColor = true;
            // 
            // clbAdvanced
            // 
            this.clbAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbAdvanced.FormattingEnabled = true;
            this.clbAdvanced.Items.AddRange(new object[] {
            "Full control",
            "Traverse folder / execute file",
            "List folder / read data",
            "Read attributes",
            "Read extended attributes",
            "Create files / write data",
            "Create folders / append data",
            "Write attributes",
            "Write extended attributes",
            "Delete subfolders and files",
            "Delete",
            "Read permissions",
            "Change permissions",
            "Take ownership"});
            this.clbAdvanced.Location = new System.Drawing.Point(8, 53);
            this.clbAdvanced.Margin = new System.Windows.Forms.Padding(4);
            this.clbAdvanced.Name = "clbAdvanced";
            this.clbAdvanced.Size = new System.Drawing.Size(549, 208);
            this.clbAdvanced.TabIndex = 2;
            // 
            // tbAdvancedAppliesTo
            // 
            this.tbAdvancedAppliesTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdvancedAppliesTo.BackColor = System.Drawing.SystemColors.Window;
            this.tbAdvancedAppliesTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAdvancedAppliesTo.Location = new System.Drawing.Point(109, 15);
            this.tbAdvancedAppliesTo.Margin = new System.Windows.Forms.Padding(4);
            this.tbAdvancedAppliesTo.Name = "tbAdvancedAppliesTo";
            this.tbAdvancedAppliesTo.Size = new System.Drawing.Size(449, 15);
            this.tbAdvancedAppliesTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Applies To:";
            // 
            // tbAccessType
            // 
            this.tbAccessType.BackColor = System.Drawing.SystemColors.Control;
            this.tbAccessType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAccessType.Location = new System.Drawing.Point(116, 46);
            this.tbAccessType.Margin = new System.Windows.Forms.Padding(4);
            this.tbAccessType.Name = "tbAccessType";
            this.tbAccessType.ReadOnly = true;
            this.tbAccessType.Size = new System.Drawing.Size(356, 15);
            this.tbAccessType.TabIndex = 4;
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.tbPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrincipal.Location = new System.Drawing.Point(116, 14);
            this.tbPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.ReadOnly = true;
            this.tbPrincipal.Size = new System.Drawing.Size(356, 15);
            this.tbPrincipal.TabIndex = 3;
            // 
            // lbPrincipal
            // 
            this.lbPrincipal.AutoSize = true;
            this.lbPrincipal.Location = new System.Drawing.Point(12, 14);
            this.lbPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrincipal.Name = "lbPrincipal";
            this.lbPrincipal.Size = new System.Drawing.Size(66, 17);
            this.lbPrincipal.TabIndex = 1;
            this.lbPrincipal.Text = "Principal:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(12, 48);
            this.lbType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(93, 17);
            this.lbType.TabIndex = 2;
            this.lbType.Text = "Access Type:";
            // 
            // tpFileFolder
            // 
            this.tpFileFolder.Controls.Add(this.tbSize);
            this.tpFileFolder.Controls.Add(this.lbSize);
            this.tpFileFolder.Controls.Add(this.tbFullPath);
            this.tpFileFolder.Controls.Add(this.tbName);
            this.tpFileFolder.Controls.Add(this.tcFileFolderDetails);
            this.tpFileFolder.Controls.Add(this.lbName);
            this.tpFileFolder.Controls.Add(this.lbFullPath);
            this.tpFileFolder.Location = new System.Drawing.Point(4, 25);
            this.tpFileFolder.Margin = new System.Windows.Forms.Padding(4);
            this.tpFileFolder.Name = "tpFileFolder";
            this.tpFileFolder.Padding = new System.Windows.Forms.Padding(4);
            this.tpFileFolder.Size = new System.Drawing.Size(613, 517);
            this.tpFileFolder.TabIndex = 1;
            this.tpFileFolder.Text = "FileFolder";
            this.tpFileFolder.UseVisualStyleBackColor = true;
            // 
            // tbSize
            // 
            this.tbSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSize.BackColor = System.Drawing.SystemColors.Control;
            this.tbSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSize.Location = new System.Drawing.Point(121, 85);
            this.tbSize.Margin = new System.Windows.Forms.Padding(4);
            this.tbSize.Name = "tbSize";
            this.tbSize.ReadOnly = true;
            this.tbSize.Size = new System.Drawing.Size(467, 15);
            this.tbSize.TabIndex = 13;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(31, 85);
            this.lbSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(39, 17);
            this.lbSize.TabIndex = 12;
            this.lbSize.Text = "Size:";
            // 
            // tbFullPath
            // 
            this.tbFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFullPath.BackColor = System.Drawing.SystemColors.Control;
            this.tbFullPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFullPath.Location = new System.Drawing.Point(121, 54);
            this.tbFullPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbFullPath.Name = "tbFullPath";
            this.tbFullPath.ReadOnly = true;
            this.tbFullPath.Size = new System.Drawing.Size(467, 15);
            this.tbFullPath.TabIndex = 11;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.BackColor = System.Drawing.SystemColors.Control;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Location = new System.Drawing.Point(121, 22);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(467, 15);
            this.tbName.TabIndex = 10;
            // 
            // tcFileFolderDetails
            // 
            this.tcFileFolderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcFileFolderDetails.Controls.Add(this.tpFileFolderDetails);
            this.tcFileFolderDetails.Controls.Add(this.tpFileFolderAttributes);
            this.tcFileFolderDetails.Controls.Add(this.tpError);
            this.tcFileFolderDetails.Location = new System.Drawing.Point(8, 143);
            this.tcFileFolderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.tcFileFolderDetails.Name = "tcFileFolderDetails";
            this.tcFileFolderDetails.SelectedIndex = 0;
            this.tcFileFolderDetails.Size = new System.Drawing.Size(593, 364);
            this.tcFileFolderDetails.TabIndex = 6;
            // 
            // tpFileFolderDetails
            // 
            this.tpFileFolderDetails.Controls.Add(this.tbOwner);
            this.tpFileFolderDetails.Controls.Add(this.tbLastAccessTime);
            this.tpFileFolderDetails.Controls.Add(this.tbModificationTime);
            this.tpFileFolderDetails.Controls.Add(this.tbCreationTime);
            this.tpFileFolderDetails.Controls.Add(this.lbOwner);
            this.tpFileFolderDetails.Controls.Add(this.label3);
            this.tpFileFolderDetails.Controls.Add(this.lbCreationTime);
            this.tpFileFolderDetails.Controls.Add(this.lbModificationTime);
            this.tpFileFolderDetails.Location = new System.Drawing.Point(4, 25);
            this.tpFileFolderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.tpFileFolderDetails.Name = "tpFileFolderDetails";
            this.tpFileFolderDetails.Padding = new System.Windows.Forms.Padding(4);
            this.tpFileFolderDetails.Size = new System.Drawing.Size(585, 335);
            this.tpFileFolderDetails.TabIndex = 0;
            this.tpFileFolderDetails.Text = "Details";
            this.tpFileFolderDetails.UseVisualStyleBackColor = true;
            // 
            // tbOwner
            // 
            this.tbOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOwner.Location = new System.Drawing.Point(149, 18);
            this.tbOwner.Margin = new System.Windows.Forms.Padding(4);
            this.tbOwner.Name = "tbOwner";
            this.tbOwner.Size = new System.Drawing.Size(425, 15);
            this.tbOwner.TabIndex = 9;
            // 
            // tbLastAccessTime
            // 
            this.tbLastAccessTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastAccessTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastAccessTime.Location = new System.Drawing.Point(151, 114);
            this.tbLastAccessTime.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastAccessTime.Name = "tbLastAccessTime";
            this.tbLastAccessTime.Size = new System.Drawing.Size(424, 15);
            this.tbLastAccessTime.TabIndex = 8;
            // 
            // tbModificationTime
            // 
            this.tbModificationTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModificationTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbModificationTime.Location = new System.Drawing.Point(149, 82);
            this.tbModificationTime.Margin = new System.Windows.Forms.Padding(4);
            this.tbModificationTime.Name = "tbModificationTime";
            this.tbModificationTime.Size = new System.Drawing.Size(425, 15);
            this.tbModificationTime.TabIndex = 7;
            // 
            // tbCreationTime
            // 
            this.tbCreationTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCreationTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCreationTime.Location = new System.Drawing.Point(149, 50);
            this.tbCreationTime.Margin = new System.Windows.Forms.Padding(4);
            this.tbCreationTime.Name = "tbCreationTime";
            this.tbCreationTime.Size = new System.Drawing.Size(425, 15);
            this.tbCreationTime.TabIndex = 6;
            // 
            // lbOwner
            // 
            this.lbOwner.AutoSize = true;
            this.lbOwner.Location = new System.Drawing.Point(17, 18);
            this.lbOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(53, 17);
            this.lbOwner.TabIndex = 0;
            this.lbOwner.Text = "Owner:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Access Time:";
            // 
            // lbCreationTime
            // 
            this.lbCreationTime.AutoSize = true;
            this.lbCreationTime.Location = new System.Drawing.Point(17, 50);
            this.lbCreationTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCreationTime.Name = "lbCreationTime";
            this.lbCreationTime.Size = new System.Drawing.Size(100, 17);
            this.lbCreationTime.TabIndex = 3;
            this.lbCreationTime.Text = "Creation Time:";
            // 
            // lbModificationTime
            // 
            this.lbModificationTime.AutoSize = true;
            this.lbModificationTime.Location = new System.Drawing.Point(17, 82);
            this.lbModificationTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModificationTime.Name = "lbModificationTime";
            this.lbModificationTime.Size = new System.Drawing.Size(122, 17);
            this.lbModificationTime.TabIndex = 4;
            this.lbModificationTime.Text = "Modification Time:";
            // 
            // tpFileFolderAttributes
            // 
            this.tpFileFolderAttributes.Controls.Add(this.clbFileFolderAttributes);
            this.tpFileFolderAttributes.Location = new System.Drawing.Point(4, 25);
            this.tpFileFolderAttributes.Margin = new System.Windows.Forms.Padding(4);
            this.tpFileFolderAttributes.Name = "tpFileFolderAttributes";
            this.tpFileFolderAttributes.Padding = new System.Windows.Forms.Padding(4);
            this.tpFileFolderAttributes.Size = new System.Drawing.Size(585, 335);
            this.tpFileFolderAttributes.TabIndex = 1;
            this.tpFileFolderAttributes.Text = "Attributes";
            this.tpFileFolderAttributes.UseVisualStyleBackColor = true;
            // 
            // clbFileFolderAttributes
            // 
            this.clbFileFolderAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbFileFolderAttributes.FormattingEnabled = true;
            this.clbFileFolderAttributes.Items.AddRange(new object[] {
            "Archive",
            "Compressed",
            "Device",
            "Directory",
            "Encrypted",
            "hidden",
            "IntegrityStream",
            "Normal",
            "NoScrubData",
            "NotContentIndexed",
            "Offline",
            "ReadOnly",
            "ReparsePoint",
            "SparseFile",
            "System",
            "Temporary"});
            this.clbFileFolderAttributes.Location = new System.Drawing.Point(4, 4);
            this.clbFileFolderAttributes.Margin = new System.Windows.Forms.Padding(4);
            this.clbFileFolderAttributes.Name = "clbFileFolderAttributes";
            this.clbFileFolderAttributes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clbFileFolderAttributes.Size = new System.Drawing.Size(577, 327);
            this.clbFileFolderAttributes.TabIndex = 6;
            // 
            // tpError
            // 
            this.tpError.Controls.Add(this.tbStackTrace);
            this.tpError.Controls.Add(this.lbStackTrace);
            this.tpError.Controls.Add(this.tbError);
            this.tpError.Controls.Add(this.lbErrorMessage);
            this.tpError.Location = new System.Drawing.Point(4, 25);
            this.tpError.Margin = new System.Windows.Forms.Padding(4);
            this.tpError.Name = "tpError";
            this.tpError.Padding = new System.Windows.Forms.Padding(4);
            this.tpError.Size = new System.Drawing.Size(585, 335);
            this.tpError.TabIndex = 2;
            this.tpError.Text = "Error";
            this.tpError.UseVisualStyleBackColor = true;
            // 
            // tbStackTrace
            // 
            this.tbStackTrace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStackTrace.BackColor = System.Drawing.SystemColors.Control;
            this.tbStackTrace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStackTrace.Location = new System.Drawing.Point(133, 55);
            this.tbStackTrace.Margin = new System.Windows.Forms.Padding(4);
            this.tbStackTrace.Multiline = true;
            this.tbStackTrace.Name = "tbStackTrace";
            this.tbStackTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbStackTrace.Size = new System.Drawing.Size(441, 266);
            this.tbStackTrace.TabIndex = 16;
            // 
            // lbStackTrace
            // 
            this.lbStackTrace.AutoSize = true;
            this.lbStackTrace.Location = new System.Drawing.Point(21, 55);
            this.lbStackTrace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStackTrace.Name = "lbStackTrace";
            this.lbStackTrace.Size = new System.Drawing.Size(88, 17);
            this.lbStackTrace.TabIndex = 15;
            this.lbStackTrace.Text = "Stack Trace:";
            // 
            // tbError
            // 
            this.tbError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbError.BackColor = System.Drawing.SystemColors.Control;
            this.tbError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbError.Location = new System.Drawing.Point(133, 17);
            this.tbError.Margin = new System.Windows.Forms.Padding(4);
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(441, 15);
            this.tbError.TabIndex = 14;
            // 
            // lbErrorMessage
            // 
            this.lbErrorMessage.AutoSize = true;
            this.lbErrorMessage.Location = new System.Drawing.Point(21, 17);
            this.lbErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorMessage.Name = "lbErrorMessage";
            this.lbErrorMessage.Size = new System.Drawing.Size(105, 17);
            this.lbErrorMessage.TabIndex = 0;
            this.lbErrorMessage.Text = "Error Message:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(31, 22);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 17);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name:";
            // 
            // lbFullPath
            // 
            this.lbFullPath.AutoSize = true;
            this.lbFullPath.Location = new System.Drawing.Point(31, 54);
            this.lbFullPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFullPath.Name = "lbFullPath";
            this.lbFullPath.Size = new System.Drawing.Size(67, 17);
            this.lbFullPath.TabIndex = 1;
            this.lbFullPath.Text = "Full Path:";
            // 
            // tpDefault
            // 
            this.tpDefault.Location = new System.Drawing.Point(4, 25);
            this.tpDefault.Margin = new System.Windows.Forms.Padding(4);
            this.tpDefault.Name = "tpDefault";
            this.tpDefault.Padding = new System.Windows.Forms.Padding(4);
            this.tpDefault.Size = new System.Drawing.Size(613, 517);
            this.tpDefault.TabIndex = 2;
            this.tpDefault.Text = "Default";
            this.tpDefault.UseVisualStyleBackColor = true;
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStartScanning,
            this.tss1,
            this.tslScanDirection,
            this.tscScanDirection,
            this.tss2,
            this.tslLevelCount,
            this.ttbLevelCount,
            this.tss3,
            this.tslInheritedItems,
            this.tsbShowInherited,
            this.tsbFiles,
            this.tsbFileSize});
            this.tsMain.Location = new System.Drawing.Point(0, 28);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(937, 28);
            this.tsMain.TabIndex = 2;
            // 
            // tsbStartScanning
            // 
            this.tsbStartScanning.AutoSize = false;
            this.tsbStartScanning.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStartScanning.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStartScanning.Name = "tsbStartScanning";
            this.tsbStartScanning.Size = new System.Drawing.Size(100, 22);
            this.tsbStartScanning.Text = "Start Scanning";
            this.tsbStartScanning.Click += new System.EventHandler(this.tsbStartScanning_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(6, 28);
            // 
            // tslScanDirection
            // 
            this.tslScanDirection.Name = "tslScanDirection";
            this.tslScanDirection.Size = new System.Drawing.Size(108, 25);
            this.tslScanDirection.Text = "Scan Direction:";
            // 
            // tscScanDirection
            // 
            this.tscScanDirection.Items.AddRange(new object[] {
            "Scan Parent(Upward)",
            "Scan Children(Downward)",
            "Scan Current Folder Only"});
            this.tscScanDirection.Name = "tscScanDirection";
            this.tscScanDirection.Size = new System.Drawing.Size(225, 28);
            this.tscScanDirection.ToolTipText = resources.GetString("tscScanDirection.ToolTipText");
            this.tscScanDirection.DropDownClosed += new System.EventHandler(this.tscScanDirection_DropDownClosed);
            this.tscScanDirection.SelectedIndexChanged += new System.EventHandler(this.tscScanDirection_SelectedIndexChanged);
            // 
            // tss2
            // 
            this.tss2.Name = "tss2";
            this.tss2.Size = new System.Drawing.Size(6, 28);
            // 
            // tslLevelCount
            // 
            this.tslLevelCount.Name = "tslLevelCount";
            this.tslLevelCount.Size = new System.Drawing.Size(52, 25);
            this.tslLevelCount.Text = "Levels:";
            this.tslLevelCount.ToolTipText = "The number of levels to scan.\r\n\r\nThe program will only scan up, or down the numbe" +
    "r of levels specified here. To scan until all possible items are processed, set " +
    "the value to \"0\"";
            // 
            // ttbLevelCount
            // 
            this.ttbLevelCount.Name = "ttbLevelCount";
            this.ttbLevelCount.Size = new System.Drawing.Size(39, 28);
            this.ttbLevelCount.Text = global::aTree.Properties.Settings.Default.Scan_Levels;
            this.ttbLevelCount.Leave += new System.EventHandler(this.ttbLevelCount_Leave);
            this.ttbLevelCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbLevelCount_KeyPress);
            this.ttbLevelCount.Validating += new System.ComponentModel.CancelEventHandler(this.ttbLevelCount_Validating);
            this.ttbLevelCount.TextChanged += new System.EventHandler(this.ttbLevelCount_TextChanged);
            // 
            // tss3
            // 
            this.tss3.Name = "tss3";
            this.tss3.Size = new System.Drawing.Size(6, 28);
            // 
            // tslInheritedItems
            // 
            this.tslInheritedItems.Name = "tslInheritedItems";
            this.tslInheritedItems.Size = new System.Drawing.Size(111, 25);
            this.tslInheritedItems.Text = "Inherited Items:";
            // 
            // tsbShowInherited
            // 
            this.tsbShowInherited.Checked = global::aTree.Properties.Settings.Default.Scan_ShowInherited;
            this.tsbShowInherited.CheckOnClick = true;
            this.tsbShowInherited.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbShowInherited.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShowInherited.Image = global::aTree.Properties.Resources.inherited16x16;
            this.tsbShowInherited.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowInherited.Name = "tsbShowInherited";
            this.tsbShowInherited.Size = new System.Drawing.Size(24, 25);
            this.tsbShowInherited.Text = "Show Inherited ACEs";
            this.tsbShowInherited.CheckedChanged += new System.EventHandler(this.tsbShowInherited_CheckedChanged);
            // 
            // tsbFiles
            // 
            this.tsbFiles.Checked = global::aTree.Properties.Settings.Default.Scan_ShowFiles;
            this.tsbFiles.CheckOnClick = true;
            this.tsbFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFiles.Image = global::aTree.Properties.Resources.file16x16;
            this.tsbFiles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiles.Name = "tsbFiles";
            this.tsbFiles.Size = new System.Drawing.Size(23, 25);
            this.tsbFiles.Text = "Show Files";
            this.tsbFiles.CheckedChanged += new System.EventHandler(this.tsbFiles_CheckedChanged);
            // 
            // tsbFileSize
            // 
            this.tsbFileSize.Checked = global::aTree.Properties.Settings.Default.Scan_ShowFileSize;
            this.tsbFileSize.CheckOnClick = true;
            this.tsbFileSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbFileSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFileSize.Image = global::aTree.Properties.Resources.size16x16;
            this.tsbFileSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFileSize.Name = "tsbFileSize";
            this.tsbFileSize.Size = new System.Drawing.Size(24, 25);
            this.tsbFileSize.Text = "File Size";
            this.tsbFileSize.CheckedChanged += new System.EventHandler(this.tsbFileSize_CheckedChanged);
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslProgressBar,
            this.tslStatus});
            this.ssMain.Location = new System.Drawing.Point(0, 651);
            this.ssMain.Name = "ssMain";
            this.ssMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssMain.Size = new System.Drawing.Size(937, 26);
            this.ssMain.TabIndex = 3;
            // 
            // tslProgressBar
            // 
            this.tslProgressBar.MarqueeAnimationSpeed = 40;
            this.tslProgressBar.Name = "tslProgressBar";
            this.tslProgressBar.Size = new System.Drawing.Size(267, 20);
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(81, 21);
            this.tslStatus.Text = "Status: Idle";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(16, 71);
            this.lbPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(45, 17);
            this.lbPath.TabIndex = 4;
            this.lbPath.Text = "Path: ";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(821, 65);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // bwMain
            // 
            this.bwMain.WorkerReportsProgress = true;
            this.bwMain.WorkerSupportsCancellation = true;
            this.bwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMain_DoWork);
            this.bwMain.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwMain_ProgressChanged);
            this.bwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwMain_RunWorkerCompleted);
            // 
            // bwBuildTree
            // 
            this.bwBuildTree.WorkerReportsProgress = true;
            this.bwBuildTree.WorkerSupportsCancellation = true;
            this.bwBuildTree.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwBuildTree_DoWork);
            this.bwBuildTree.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwBuildTree_RunWorkerCompleted);
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::aTree.Properties.Settings.Default, "ACL_FolderPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbPath.Location = new System.Drawing.Point(71, 68);
            this.tbPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(741, 22);
            this.tbPath.TabIndex = 5;
            this.tbPath.Text = global::aTree.Properties.Settings.Default.ACL_FolderPath;
            // 
            // cmsTree
            // 
            this.cmsTree.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTree.Name = "cmsTree";
            this.cmsTree.Size = new System.Drawing.Size(67, 4);
            // 
            // bwOpenFile
            // 
            this.bwOpenFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwOpenFile_DoWork);
            this.bwOpenFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwOpenFile_RunWorkerCompleted);
            // 
            // bwSaveFile
            // 
            this.bwSaveFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSaveFile_DoWork);
            this.bwSaveFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSaveFile_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 677);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "aTree";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpDetail.ResumeLayout(false);
            this.pnDetail.ResumeLayout(false);
            this.pnDetail.PerformLayout();
            this.tcItem.ResumeLayout(false);
            this.tpBasicPermissions.ResumeLayout(false);
            this.tpBasicPermissions.PerformLayout();
            this.tpAdvancedPermissions.ResumeLayout(false);
            this.tpAdvancedPermissions.PerformLayout();
            this.tpFileFolder.ResumeLayout(false);
            this.tpFileFolder.PerformLayout();
            this.tcFileFolderDetails.ResumeLayout(false);
            this.tpFileFolderDetails.ResumeLayout(false);
            this.tpFileFolderDetails.PerformLayout();
            this.tpFileFolderAttributes.ResumeLayout(false);
            this.tpError.ResumeLayout(false);
            this.tpError.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabDelimitedFiletsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commaSeparatedcsvToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TreeView tvStructure;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripLabel tslScanDirection;
        private System.Windows.Forms.ToolStripComboBox tscScanDirection;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripLabel tslLevelCount;
        private System.Windows.Forms.ToolStripTextBox ttbLevelCount;
        private System.Windows.Forms.ToolStripSeparator tss2;
        private System.Windows.Forms.ToolStripLabel tslInheritedItems;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripProgressBar tslProgressBar;
        private System.Windows.Forms.ToolStripButton tsbStartScanning;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ToolStripSeparator tss3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.Label lbPrincipal;
        private System.Windows.Forms.Panel pnDetail;
        private System.Windows.Forms.TabControl tcItem;
        private System.Windows.Forms.TabPage tpBasicPermissions;
        private System.Windows.Forms.TabPage tpAdvancedPermissions;
        private System.Windows.Forms.TextBox tbAccessType;
        private System.Windows.Forms.TextBox tbPrincipal;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpDetail;
        private System.Windows.Forms.TabPage tpFileFolder;
        private System.Windows.Forms.CheckedListBox clbBasic;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbAdvanced;
        private System.Windows.Forms.TextBox tbAdvancedAppliesTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpDefault;
        private System.ComponentModel.BackgroundWorker bwMain;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bwBuildTree;
        private System.Windows.Forms.ToolStripButton tsbShowInherited;
        private System.Windows.Forms.ToolStripButton tsbFiles;
        private System.Windows.Forms.ToolStripButton tsbFileSize;
        private System.Windows.Forms.ImageList imlTree;
        private System.Windows.Forms.Label lbOwner;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbFullPath;
        private System.Windows.Forms.TextBox tbFullPath;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TabControl tcFileFolderDetails;
        private System.Windows.Forms.TabPage tpFileFolderDetails;
        private System.Windows.Forms.TextBox tbOwner;
        private System.Windows.Forms.TextBox tbLastAccessTime;
        private System.Windows.Forms.TextBox tbModificationTime;
        private System.Windows.Forms.TextBox tbCreationTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCreationTime;
        private System.Windows.Forms.Label lbModificationTime;
        private System.Windows.Forms.TabPage tpFileFolderAttributes;
        private System.Windows.Forms.CheckedListBox clbFileFolderAttributes;
        private System.Windows.Forms.ContextMenuStrip cmsTree;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.TabPage tpError;
        private System.Windows.Forms.TextBox tbStackTrace;
        private System.Windows.Forms.Label lbStackTrace;
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.Label lbErrorMessage;
        private System.ComponentModel.BackgroundWorker bwCreateSvItem;
        private System.ComponentModel.BackgroundWorker bwOpenFile;
        private System.ComponentModel.BackgroundWorker bwSaveFile;
    }
}

