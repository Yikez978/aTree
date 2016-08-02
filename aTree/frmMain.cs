using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Security.AccessControl;
using System.Security.Principal;
using System.IO;
using System.Threading;
using System.Threading.Tasks.Schedulers;
using Microsoft.VisualBasic.CompilerServices;
using System.Xml.Serialization;

namespace aTree
{
    public partial class frmMain : Form
    {

        private aTreeControlledFileSystemObject CurrentObject;
        private bool IsScanning = false;
        private const string DateTimeFormat = "MM:dd:yyyy HH:mm:ss";

        #region "Main Form Events"

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            tsbStartScanning.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;

            tscScanDirection.DropDownStyle = ComboBoxStyle.DropDownList;

            tscScanDirection.SelectedIndex = Properties.Settings.Default.Scan_Direction;

            tcMain.Appearance = TabAppearance.FlatButtons;
            tcMain.ItemSize = new Size(0, 1);
            tcMain.SizeMode = TabSizeMode.Fixed;
            tcMain.SelectedTab = tpDefault;

            tsbStartScanning.Image = Properties.Resources.start128x128.ToBitmap();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Upgrade();
            Properties.Settings.Default.Save();
        }

        #endregion
        #region "Browse button."
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cfd = new CommonOpenFileDialog();
            cfd.IsFolderPicker = true;
            if (cfd.ShowDialog() == CommonFileDialogResult.Ok) {
                tbPath.Text = cfd.FileName;
            }
        }
        #endregion
        #region "Config Object Generation"
        private aTreeConfig GetConfig() {
            aTreeConfig Config = new aTreeConfig(Properties.Settings.Default.ACL_FolderPath);

            Config.CustomMaxThreads = Config.CustomMaxThreads;

            int MaxWorkerThreads = 0;
            int.TryParse(
                Properties.Settings.Default.Scan_MaxWorkerThreadCount,
                out MaxWorkerThreads
            );
            Config.MaxWorkerThreads = MaxWorkerThreads;

            int ScanLevels = 0;
            int.TryParse(
                Properties.Settings.Default.Scan_Levels,
                out ScanLevels
            );

            Config.ScanLevels = ScanLevels;

            switch (Properties.Settings.Default.Scan_Direction) {

                case 0:
                    Config.ScanDirection = aTreeScanDirection.Up;
                    break;
                case 1:
                    Config.ScanDirection = aTreeScanDirection.Down;
                    break;
                case 2:
                    Config.ScanDirection = aTreeScanDirection.None;
                    break;
                default:
                    Config.ScanDirection = aTreeScanDirection.None;
                break;
            }

            Config.BasicExcludeFilterEnabled = Properties.Settings.Default.Basic_ExcludeFilterEnabled;
            Config.BasicIncludeFilterEnabled = Properties.Settings.Default.Basic_IncludeFilterEnabled;
            Config.RegExExcludeFilterEnabled = Properties.Settings.Default.RegEx_ExcludeFilterEnabled;
            Config.RegExIncludeFilterEnabled = Properties.Settings.Default.RegEx_IncludeFilterEnabled;

            Config.BasicExcludeFilter = Properties.Settings.Default.Basic_ExcludeFilter;
            Config.BasicIncludeFilter = Properties.Settings.Default.Basic_IncludeFilter;
            Config.RegExExcludeFilter = Properties.Settings.Default.RegEx_ExcludeFilter;
            Config.RegExIncludeFilter = Properties.Settings.Default.RegEx_IncludeFilter;

            Config.RootPath = tbPath.Text;
            Config.ShowFiles = Properties.Settings.Default.Scan_ShowFiles;
            Config.ShowFileSize = Properties.Settings.Default.Scan_ShowFileSize;
            Config.ShowInheritedACEs = Properties.Settings.Default.Scan_ShowInherited;

            return Config;
        }
        #endregion
        #region "Control States"

        private void PreWorkerControls() {

            tvStructure.Nodes.Clear();

            tcMain.SelectedTab = tpDefault;
            tsbShowInherited.Enabled = false;
            tsbFileSize.Enabled = false;
            tsbFiles.Enabled = false;
            tbPath.Enabled = false;
            btnBrowse.Enabled = false;
            tscScanDirection.Enabled = false;
            ttbLevelCount.Enabled = false;
            saveTreeToolStripMenuItem.Enabled = false;
            openTreeToolStripMenuItem.Enabled = false;
            exportTreeToolStripMenuItem.Enabled = false;
            copyToClipboardToolStripMenuItem.Enabled = false;
            advancedToolStripMenuItem.Enabled = false;

            tsbStartScanning.Text = "Stop Scanning";
            tsbStartScanning.Image = Properties.Resources.stop128x128.ToBitmap();
            IsScanning = true;
            tslProgressBar.Style = ProgressBarStyle.Marquee;
        }

        private void PostWorkerControls() {

            tbPath.Enabled = true;
            btnBrowse.Enabled = true;
            tsbShowInherited.Enabled = true;
            tsbFileSize.Enabled = true;
            tsbFiles.Enabled = true;
            tscScanDirection.Enabled = true;
            ttbLevelCount.Enabled = true;
            saveTreeToolStripMenuItem.Enabled = true;
            openTreeToolStripMenuItem.Enabled = true;
            exportTreeToolStripMenuItem.Enabled = true;
            copyToClipboardToolStripMenuItem.Enabled = true;
            advancedToolStripMenuItem.Enabled = true;

            tsbStartScanning.Text = "Start Scanning";
            tsbStartScanning.Image = Properties.Resources.start128x128.ToBitmap();
            IsScanning = false;
            tslProgressBar.Style = ProgressBarStyle.Blocks;
            tslStatus.Text = "Status: Idle";

        }

        private void SetFooterLabel(string Status)
        {
            tslStatus.Text = Status;
        }

        #endregion
        #region "Filtering"

        private bool CheckFilter(aTreeConfig Config, string CompareObject) {

            //If basic exclude enabled...
            if (Config.BasicExcludeFilterEnabled)
            {

                foreach (string s in Config.BasicExcludeFilter.Split(new char[1] { ';' })) { 

                    //And this matches the filter...
                    if (LikeOperator.LikeString(
                        CompareObject,
                        s,
                        Microsoft.VisualBasic.CompareMethod.Text))
                    {

                        //No pass.
                        return false;
                    }
                }
            }

            //If basic include enabled...
            if (Config.BasicIncludeFilterEnabled)
            {

                bool Result = false;

                foreach (string s in Config.BasicIncludeFilter.Split(new char[1] { ';' }))
                {
                    {

                        //And this does NOT match the filter...
                        if (LikeOperator.LikeString(
                        CompareObject,
                        s,
                        Microsoft.VisualBasic.CompareMethod.Text))
                        {
                            //Pass.
                            Result= true;
                            break;
                        }
                    }
                }
                if (!Result) return false;
            }
            //TODO: RegEx filters.

            return true;
        }
        
        #endregion
        #region "Sid Translation"

        private string SidToName(SecurityIdentifier Sid) {

            //TODO: Ok, so I have translation in here for "basic", but need to include
            //the code for advanced.

            SIDInfo Info = null;

            try
            {
                Info = new SIDInfo(Sid.ToString(), string.Empty, SIDInfo.IdentityType.SID);
            }
            catch (Exception e) {
                //Eh.
            }

            if (Info == null)
            {
                return Sid.ToString();
            }
            else
            {
                return Info.ToString();
            }
        }

        #endregion
        #region "bwMain Background Worker"
        private void bwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            aTreeConfig Config = (aTreeConfig)e.Argument;

            TaskScheduler Scheduler = null;

            if (Config.CustomMaxThreads && Config.MaxWorkerThreads != 0){

                Scheduler = new QueuedTaskScheduler(Config.MaxWorkerThreads);

            }

            e.Result = ProcessObject(Config.RootPath,Config, 1, Scheduler);
        }

        private void bwMain_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tslStatus.Text = (string)e.UserState;
        }

        private void bwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tslStatus.Text = "Status: Building tree...";
            if (e.Result != null) {
                CurrentObject = (aTreeControlledFileSystemObject)e.Result;
                bwBuildTree.RunWorkerAsync(new[] { e.Result, GetConfig() });
            }
        }

        private void ProgressChanged(int PercentProgress, string UserState)
        {

            ProgressChangedThrottler(PercentProgress, UserState);
        }

        //TODO: Get rid of this ugly, hardcoded value. This belongs in Appconfig.
        private int Scan_InterfaceUpdateThrottleMilliseconds = 40;

        private object ProgressChangedThrottlerLock = new object();
        private void ProgressChangedThrottler(int PercentProgress, object UserState)
        {
            lock (ProgressChangedThrottlerLock)
            {
                bwMain.ReportProgress(PercentProgress, UserState);
                //TODO: Put this as a property on frmMain to read a parsed value.
                //TODO: Maybe option to disable throttle?
                Thread.Sleep(Scan_InterfaceUpdateThrottleMilliseconds);
            }
        }

        #endregion
        #region "bwBuildTree Background Worker"
        private void bwBuildTree_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument != null && e.Argument.GetType().IsArray) {

                object[] arr = (object[])e.Argument;

                aTreeControlledFileSystemObject ControlledObject = (aTreeControlledFileSystemObject)arr[0];
                aTreeConfig Config = (aTreeConfig)arr[1];

                TaskScheduler Scheduler = null;

                if (Config.CustomMaxThreads && Config.MaxWorkerThreads != 0)
                {

                    Scheduler = new QueuedTaskScheduler(Config.MaxWorkerThreads);

                }

                TreeNode RootNode = BuildTreeNode(ControlledObject, Scheduler);

                if (RootNode != null) RootNode.ExpandAll();

                e.Result = RootNode;
            }
        }

        private void bwBuildTree_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PostWorkerControls();
            if (e.Result != null){
                tvStructure.Nodes.Add((TreeNode)e.Result);
            }
        }

        #endregion
        #region "Tree Node Building"
        private aTreeNode BuildTreeNode(aTreeAccessControlEntry EntryObject, TaskScheduler Scheduler)
        {

            if (!EntryObject.PassedFilter) return null;

            aTreeNode CurrentNode = new aTreeNode();
            CurrentNode.Name = EntryObject.Identity;
            CurrentNode.Text = EntryObject.Identity;
            CurrentNode.DetailObject = EntryObject;
            CurrentNode.ObjectCategory = aTreeControlledObjectCategory.Access;

            //if ((int)EntryObject.DisplayClass <= 3)
            //{

            //TODO: This is just to prevent index-out-of-bounds on the image list until I get all the images in place.

            CurrentNode.ImageIndex = (int)EntryObject.DisplayClass;
            CurrentNode.SelectedImageIndex = (int)EntryObject.DisplayClass;

            //}

            return CurrentNode;

        }
        private aTreeNode BuildTreeNode(aTreeControlledFileSystemObject ControlledObject, TaskScheduler Scheduler)
        {

            if (!ControlledObject.PassedFilter) return null;

            aTreeNode CurrentNode = new aTreeNode();
            CurrentNode.Name = ControlledObject.FullName;
            CurrentNode.Text = ControlledObject.Name;
            CurrentNode.DetailObject = ControlledObject;
            CurrentNode.ObjectCategory = ControlledObject.ObjectCategory;

            //if ((int)ControlledObject.DisplayClass <= 3)
            //{

            //TODO: This is just to prevent index-out-of-bounds on the image list until I get all the images in place.

            CurrentNode.ImageIndex = (int)ControlledObject.DisplayClass;
            CurrentNode.SelectedImageIndex = (int)ControlledObject.DisplayClass;

            //}

            if (bwBuildTree.CancellationPending)
            {

                return CurrentNode;
            }

            List<Task> Tasks = new List<Task>();

            foreach (aTreeControlledFileSystemObject c in ControlledObject.Children)
            {

                if (c == null)
                {
                    object derp = new object();
                }

                if (Scheduler != null)
                {
                    Tasks.Add(
                        Task<aTreeNode>.Factory.StartNew(
                            () => BuildTreeNode(c, Scheduler),
                            CancellationToken.None,
                            TaskCreationOptions.None,
                            Scheduler
                        )
                    );
                }
                else {

                    Tasks.Add(
                        Task<aTreeNode>.Factory.StartNew(
                            () => BuildTreeNode(c, Scheduler)
                        )
                    );
                }
            }

            foreach (aTreeAccessControlEntry c in ControlledObject.AccessControlEntries)
            {

                if (c == null)
                {
                    object derp = new object();
                }

                if (Scheduler != null)
                {
                    Tasks.Add(
                        Task<aTreeNode>.Factory.StartNew(
                            () => BuildTreeNode(c, Scheduler),
                            CancellationToken.None,
                            TaskCreationOptions.None,
                            Scheduler
                        )
                    );
                }
                else {

                    Tasks.Add(
                        Task<aTreeNode>.Factory.StartNew(
                            () => BuildTreeNode(c, Scheduler)
                        )
                    );
                }
            }

            //TODO: Sort, re-order ACEs so they're on top.

            Task.WhenAll(Tasks.ToArray());

            foreach (Task<aTreeNode> t in Tasks)
            {
                if (t.Result != null)
                {
                    CurrentNode.Nodes.Add(t.Result);
                }
            }

            //Also add the access control entries.

            return CurrentNode;
        }
        #endregion
        #region "Folder Processing"
        private aTreeControlledFileSystemObject ProcessObject(string Path, aTreeConfig Config, int CurrentLevel, TaskScheduler Scheduler)
        {

            //Send notification that we're starting on this folder. Display purposes only.
            ProgressChanged(0, "Status: Collecting Data, " + Path);

            //Creating our initial info object. System.IO.Path.GetFileName can bomb here,
            //but we should have already validated a correct path by this point.
            aTreeControlledFileSystemObject CurrentObject = new aTreeControlledFileSystemObject();
            CurrentObject.FullName = Path;

            DirectoryInfo[] ChildDirectories = new DirectoryInfo[] { };
            FileInfo[] ChildFiles = new FileInfo[] { };
            AuthorizationRuleCollection ChildRules = null;

            try
            {

                if (Directory.Exists(Path))
                {
                    //Folder stuff.

                    CurrentObject.ObjectCategory = aTreeControlledObjectCategory.Folder;
                    CurrentObject.DisplayClass = aTreeObjectDisplayCategory.Folder;

                    CurrentObject.Name = System.IO.Path.GetFileName(Path);

                    //This sometimes happens if the current item is a root drive.
                    if (string.IsNullOrEmpty(CurrentObject.Name))
                    {
                        CurrentObject.Name = Path;
                    }

                    DirectoryInfo Info = new DirectoryInfo(Path);

                    CurrentObject.Attributes = (int)Info.Attributes;
                    CurrentObject.CreationTime = Info.CreationTime;
                    CurrentObject.LastWriteTime = Info.LastWriteTime;
                    CurrentObject.LastAccessTime = Info.LastAccessTime;

                    CurrentObject.Owner = SidToName((SecurityIdentifier)Info.GetAccessControl().GetOwner(typeof(SecurityIdentifier)));

                    if (Config.ScanDirection == aTreeScanDirection.Up)
                    {

                        List<DirectoryInfo> ChildList = new List<DirectoryInfo>();

                        if (Info.Parent != null && Info.Parent.FullName != Path)
                        {
                            ChildList.Add(Info.Parent);
                        }

                        ChildDirectories = ChildList.ToArray();

                    }
                    else {
                        ChildDirectories = Info.GetDirectories();
                    }

                    if (Config.ShowFiles)
                    {
                        ChildFiles = Info.GetFiles();
                    }

                    ChildRules = Info.GetAccessControl().GetAccessRules(
                        true, true, typeof(System.Security.Principal.SecurityIdentifier));

                }

                if (File.Exists(Path))
                {
                    //File stuff.
                    CurrentObject.ObjectCategory = aTreeControlledObjectCategory.File;
                    CurrentObject.DisplayClass = aTreeObjectDisplayCategory.File;

                    CurrentObject.Name = System.IO.Path.GetFileName(Path);

                    FileInfo Info = new FileInfo(Path);

                    CurrentObject.Attributes = (int)Info.Attributes;
                    CurrentObject.CreationTime = Info.CreationTime;
                    CurrentObject.LastWriteTime = Info.LastWriteTime;
                    CurrentObject.LastAccessTime = Info.LastAccessTime;
                    CurrentObject.Size = Info.Length;

                    CurrentObject.Owner = SidToName((SecurityIdentifier)Info.GetAccessControl().GetOwner(typeof(SecurityIdentifier)));

                    ChildRules = Info.GetAccessControl().GetAccessRules(
                        true, true, typeof(System.Security.Principal.SecurityIdentifier));

                }
            }
            catch (Exception e)
            {

                switch (CurrentObject.ObjectCategory)
                {

                    case aTreeControlledObjectCategory.File:
                        CurrentObject.DisplayClass = aTreeObjectDisplayCategory.FileError;
                        break;

                    case aTreeControlledObjectCategory.Folder:
                        CurrentObject.DisplayClass = aTreeObjectDisplayCategory.FolderError;
                        break;

                    case aTreeControlledObjectCategory.Undetermined:
                        CurrentObject.DisplayClass = aTreeObjectDisplayCategory.FileError;
                        break;
                }

                CurrentObject.LastException = e;

            }

            CurrentObject.PassedFilter = CheckFilter(Config, CurrentObject.Name);

            List<Task> Tasks = new List<Task>();

            if (ChildRules != null)
            {
                foreach (FileSystemAccessRule Rule in ChildRules)
                {

                    aTreeAccessControlEntry AccessControl = new aTreeAccessControlEntry();
                    AccessControl.AccessFlags = (int)Rule.FileSystemRights;
                    AccessControl.AccessControlType = (int)Rule.AccessControlType;
                    AccessControl.PropagationFlags = (int)Rule.PropagationFlags;
                    AccessControl.InheritanceFlags = (int)Rule.InheritanceFlags;
                    AccessControl.IsInherited = Rule.IsInherited;

                    AccessControl.Identity = SidToName((SecurityIdentifier)Rule.IdentityReference.Translate(typeof(SecurityIdentifier)));

                    if (Properties.Settings.Default.Filter_IncludeACEs)
                    {
                        AccessControl.PassedFilter = CheckFilter(Config, AccessControl.Identity);
                    }
                    else {
                        AccessControl.PassedFilter = true;
                    }

                    //TODO: If group, select group display. If user, user display. If unknown sid, sid display.

                    if (Rule.IsInherited)
                    {
                        AccessControl.DisplayClass = aTreeObjectDisplayCategory.InheritedUser;
                    }
                    else
                    {
                        AccessControl.DisplayClass = aTreeObjectDisplayCategory.User;
                    }

                    CurrentObject.AccessControlEntries.Add(AccessControl);

                }
            }

            if (CurrentObject.ObjectCategory == aTreeControlledObjectCategory.Folder && ChildFiles != null)
            {

                foreach (FileInfo File in ChildFiles)
                {

                    if (Scheduler != null)
                    {
                        Tasks.Add(
                            Task<aTreeControlledFileSystemObject>.Factory.StartNew(
                                () => {
                                    return ProcessObject(File.FullName, Config, CurrentLevel + 1, Scheduler);
                                },
                                CancellationToken.None,
                                TaskCreationOptions.None,
                                Scheduler
                            )
                        );
                    }
                    else {

                        Tasks.Add(
                            Task<aTreeControlledFileSystemObject>.Factory.StartNew(
                                () => {
                                    return ProcessObject(File.FullName, Config, CurrentLevel + 1, Scheduler);
                                }
                            )
                        );
                    }
                }
            }

            //Check cancellation here, because we want each object to complete as completely as possible.
            //So we'll collect as much data on this object as we can, and stop walking the tree.
            if (!bwMain.CancellationPending &&
                (Config.ScanLevels == 0 || (CurrentLevel < Config.ScanLevels)) &&
                ChildDirectories != null &&
                Config.ScanDirection != aTreeScanDirection.None)
            {
                foreach (DirectoryInfo Folder in ChildDirectories)
                {

                    if (Scheduler != null)
                    {
                        Tasks.Add(
                            Task<aTreeControlledFileSystemObject>.Factory.StartNew(
                                () => ProcessObject(Folder.FullName, Config, CurrentLevel + 1, Scheduler),
                                CancellationToken.None,
                                TaskCreationOptions.None,
                                Scheduler
                            )
                        );
                    }
                    else {

                        Tasks.Add(
                            Task<aTreeControlledFileSystemObject>.Factory.StartNew(
                                () => ProcessObject(Folder.FullName, Config, CurrentLevel + 1, Scheduler)
                            )
                        );
                    }
                }
            }

            Task.WhenAll(Tasks.ToArray());

            foreach (Task<aTreeControlledFileSystemObject> t in Tasks)
            {
                if (t.Result != null)
                {
                    CurrentObject.Children.Add(t.Result);
                    CurrentObject.Size += t.Result.Size;
                }
            }

            //If even one child passes the filter, this parent has to pass as well.
            //This allows the child to be ultimately displayed...which is kind of the
            //entire goal of allowing filters.
            foreach (aTreeControlledFileSystemObject o in CurrentObject.Children)
            {
                if (o.PassedFilter) CurrentObject.PassedFilter = true;
            }

            if (Properties.Settings.Default.Filter_IncludeACEs)
            {
                foreach (aTreeAccessControlEntry o in CurrentObject.AccessControlEntries)
                {
                    if (o.PassedFilter) CurrentObject.PassedFilter = true;
                }
            }

            if (Config.ShowFileSize)
            {
                CurrentObject.Name = CurrentObject.Name + ": " + FileSize.NormalizeString(CurrentObject.Size);
            }
            else {
                CurrentObject.Name = CurrentObject.Name;
            }

            return CurrentObject;
        }
        #endregion
        #region "Toolstrip Events"

        private void tscScanDirection_DropDownClosed(object sender, EventArgs e)
        {
            Properties.Settings.Default.Scan_Direction = tscScanDirection.SelectedIndex;
        }

        private void ttbLevelCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            string chars = "0123456789" + (char)8;
            if (!(chars.Contains(e.KeyChar))) { e.Handled = true; }
        }

        private void ttbLevelCount_Validating(object sender, CancelEventArgs e)
        {
            int o = 0;
            if (!(int.TryParse(ttbLevelCount.Text, out o))) { ttbLevelCount.Text = "0"; }
        }

        private void ttbLevelCount_Leave(object sender, EventArgs e)
        {
            int t = 8;
            if (int.TryParse(ttbLevelCount.Text, out t))
            {

                ttbLevelCount.Text = t.ToString();

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAbout frm = new frmAbout())
            {
                frm.ShowDialog();
            }
        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAdvanced frm = new frmAdvanced())
            {
                frm.ShowDialog();
            }
        }



        private void tsbStartScanning_Click(object sender, EventArgs e)
        {
            if (IsScanning)
            {

                bwMain.CancelAsync();
                tsbStartScanning.Text = "Stopping...";
                return;
            }

            if (string.IsNullOrEmpty(tbPath.Text))
            {
                MessageBox.Show(
                    "Path cannot be blank.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int.TryParse(
                Properties.Settings.Default.Scan_InterfaceUpdateThrottleMilliseconds,
                out Scan_InterfaceUpdateThrottleMilliseconds
            );

            aTreeConfig Config = GetConfig();

            PreWorkerControls();

            bwMain.RunWorkerAsync(Config);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ttbLevelCount_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Scan_Levels = ttbLevelCount.Text;
        }

        private void tsbShowInherited_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Scan_ShowInherited =
                (bool)tsbShowInherited.Checked;
        }

        private void tsbFiles_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Scan_ShowFiles =
                (bool)tsbFiles.Checked;
        }

        private void tsbFileSize_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Scan_ShowFileSize =
                (bool)tsbFileSize.Checked;
        }

        private void tscScanDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Scan_Direction = tscScanDirection.SelectedIndex;
        }

        private void saveTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                "Exception data is not saved. If aTree could not properly read an object, \r\nit will not be shown as an error object when the data is re-loaded later.",
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );


            if (CurrentObject == null)
            {
                MessageBox.Show(
                    "Nothing to save yet, please run tool at least once.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            CommonSaveFileDialog cfd = new CommonSaveFileDialog();
            cfd.Filters.Add(new CommonFileDialogFilter("aTree XML File(*.txl)", "*.txl"));
            cfd.Filters.Add(new CommonFileDialogFilter("All files(*.*)", "*.*"));

            if (cfd.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            try
            {
                XmlSerializer x = new XmlSerializer(typeof(aTreeControlledFileSystemObject));

                using (StreamWriter writer = new StreamWriter(cfd.FileName))
                {
                    x.Serialize(writer, CurrentObject);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to save file: " + ex.Message,
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;

            }
        }

        private void openTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CommonOpenFileDialog cfd = new CommonOpenFileDialog();
            if (cfd.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            string XmlInput = string.Empty;

            try
            {

                XmlSerializer x = new XmlSerializer(typeof(aTreeControlledFileSystemObject));

                using (StreamReader reader = new StreamReader(cfd.FileName))
                {
                    CurrentObject = (aTreeControlledFileSystemObject)x.Deserialize(reader);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to read file: " + ex.Message,
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            PreWorkerControls();

            tbPath.Text = CurrentObject.FullName;

            aTreeConfig Config = GetConfig();
            Config.RootPath = CurrentObject.FullName;

            bwBuildTree.RunWorkerAsync(new object[] { CurrentObject, GetConfig() });

        }

        #endregion
        #region "Tree Context Menu"

        private void tvStructure_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            aTreeNode Node = (aTreeNode)e.Node;

            tvStructure.SelectedNode = Node;

            //Memory management sucks.
            List<ToolStripItem> DestroyThese = new List<ToolStripItem>();

            foreach (ToolStripItem i in cmsTree.Items) {
                DestroyThese.Add(i);
            }

            ToolStripItem[] DestroyTheseArr = DestroyThese.ToArray();

            cmsTree.Items.Clear();

            for (int i = 0; i < DestroyTheseArr.Length; i++) {
                DestroyTheseArr[i].Dispose();
            }
            //But not as much as in C++

            if (e.Button == MouseButtons.Right) {


                ToolStripItem tsi = cmsTree.Items.Add("E&xpand All");
                tsi.Tag = Node;
                tsi.Click += new EventHandler(this.ExpandAllToolStripItemClick);

                ToolStripItem tsi2 = cmsTree.Items.Add("Co&llapse All");
                tsi2.Tag = Node;
                tsi2.Click += new EventHandler(this.CollapseAllToolStripItemClick);

                if (Node.ObjectCategory == aTreeControlledObjectCategory.File ||
                    Node.ObjectCategory == aTreeControlledObjectCategory.Folder) {

                    ToolStripItem tsi3 = cmsTree.Items.Add("&Copy Path to Clipboard");
                    tsi3.Tag = Node;
                    tsi3.Click += new EventHandler(this.CopyPathToolStripItemClick);

                }

                if (Node.ObjectCategory == aTreeControlledObjectCategory.File)
                {
                    //Nothing special for files at this time.
                }

                if (Node.ObjectCategory == aTreeControlledObjectCategory.Folder)
                {
                    ToolStripItem tsi4 = cmsTree.Items.Add("&Explore This Folder");
                    tsi4.Tag = Node;
                    tsi4.Click += new EventHandler(this.ExploreToolStripItemClick);
                }

                if (Node.ObjectCategory == aTreeControlledObjectCategory.Access)
                {
                    ToolStripItem tsi5 = cmsTree.Items.Add("&Copy Name to Clipboard");
                    tsi5.Tag = Node;
                    tsi5.Click += new EventHandler(this.CopyNameToolStripItemClick);
                }

                cmsTree.Show(tvStructure.PointToScreen(e.Location));
    
            }

            SelectNode(Node);

        }

        private void ExploreToolStripItemClick(object sender, EventArgs e)
        {
            ToolStripItem tsi = (ToolStripItem)sender;

            if (tsi.Tag == null) return;

            aTreeNode Node = (aTreeNode)tsi.Tag;

            aTreeControlledFileSystemObject ControlledObject =
                (aTreeControlledFileSystemObject)Node.DetailObject;

            System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo() {
                    FileName = ControlledObject.FullName,
                    UseShellExecute = true,
                    Verb = "open"
                }
            );
        }

        private void CopyPathToolStripItemClick(object sender, EventArgs e)
        {

            ToolStripItem tsi = (ToolStripItem)sender;

            if (tsi.Tag == null) return;

            aTreeNode Node = (aTreeNode)tsi.Tag;

            aTreeControlledFileSystemObject ControlledObject = 
                (aTreeControlledFileSystemObject)Node.DetailObject;

            Clipboard.SetText(ControlledObject.FullName);
        }

        private void CopyNameToolStripItemClick(object sender, EventArgs e)
        {

            ToolStripItem tsi = (ToolStripItem)sender;

            if (tsi.Tag == null) return;

            aTreeNode Node = (aTreeNode)tsi.Tag;

            aTreeAccessControlEntry ControlledObject =
                (aTreeAccessControlEntry)Node.DetailObject;

            Clipboard.SetText(ControlledObject.Identity);
        }

        private void CollapseAllToolStripItemClick(object sender, EventArgs e)
        {
            ToolStripItem tsi = (ToolStripItem)sender;

            if (tsi.Tag == null) return;

            aTreeNode Node = (aTreeNode)tsi.Tag;

            Node.Collapse();
        }

        private void ExpandAllToolStripItemClick(object sender, EventArgs e)
        {
            ToolStripItem tsi = (ToolStripItem)sender;

            if (tsi.Tag == null) return;

            aTreeNode Node = (aTreeNode)tsi.Tag;

            Node.ExpandAll();
        }

        private void tvStructure_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            SelectNode((aTreeNode)e.Node);
        }

        private void SelectNode(aTreeNode Node) {

            if (Node.ObjectCategory == aTreeControlledObjectCategory.File ||
                Node.ObjectCategory == aTreeControlledObjectCategory.Folder)
            {

                aTreeControlledFileSystemObject DetailObject =
                    (aTreeControlledFileSystemObject)Node.DetailObject;

                tcMain.SelectedTab = tpFileFolder;


                tbFullPath.Text = DetailObject.FullName;
                tbName.Text = Path.GetFileName(tbFullPath.Text);
                tbOwner.Text = DetailObject.Owner;
                tbCreationTime.Text = DetailObject.CreationTime.ToString("M:d:yyyy H:mm:ss");
                tbModificationTime.Text = DetailObject.LastWriteTime.ToString("M:d:yyyy H:mm:ss");
                tbLastAccessTime.Text = DetailObject.LastAccessTime.ToString("M:d:yyyy H:mm:ss");
                tbSize.Text = FileSize.NormalizeString(DetailObject.Size);

                if (DetailObject.LastException != null) {

                    tbError.Text = DetailObject.LastException.Message;
                    tbStackTrace.Text = DetailObject.LastException.ToString();

                }

                for (int i = 0; i <= (clbFileFolderAttributes.Items.Count - 1); i++)
                {
                    clbFileFolderAttributes.SetItemCheckState(i, CheckState.Unchecked);
                }

                if (((FileAttributes)DetailObject.Attributes & FileAttributes.Archive) == FileAttributes.Archive)
                {
                    clbFileFolderAttributes.SetItemCheckState(0, CheckState.Checked);
                }
                if (((FileAttributes)DetailObject.Attributes & FileAttributes.Compressed) == FileAttributes.Compressed)
                {
                    clbFileFolderAttributes.SetItemCheckState(1, CheckState.Checked);
                }
                if (((FileAttributes)DetailObject.Attributes & FileAttributes.Device) == FileAttributes.Device)
                {
                    clbFileFolderAttributes.SetItemCheckState(2, CheckState.Checked);
                }
                if (((FileAttributes)DetailObject.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    clbFileFolderAttributes.SetItemCheckState(3, CheckState.Checked);
                }
                if (((FileAttributes)DetailObject.Attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted)
                {
                    clbFileFolderAttributes.SetItemCheckState(4, CheckState.Checked);
                }
                if (((FileAttributes)DetailObject.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    clbFileFolderAttributes.SetItemCheckState(5, CheckState.Checked);
                }
                if (((FileAttributes)DetailObject.Attributes & FileAttributes.IntegrityStream) == FileAttributes.IntegrityStream)
                {
                    clbFileFolderAttributes.SetItemCheckState(6, CheckState.Checked);
                }
                if (((FileAttributes)DetailObject.Attributes & FileAttributes.Normal) == FileAttributes.Normal)
                {
                    clbFileFolderAttributes.SetItemCheckState(7, CheckState.Checked);
                }
                if (((FileAttributes)DetailObject.Attributes & FileAttributes.NoScrubData) == FileAttributes.NoScrubData)
                {
                    clbFileFolderAttributes.SetItemCheckState(8, CheckState.Checked);
                }
                if (((FileAttributes)DetailObject.Attributes & FileAttributes.NotContentIndexed) == FileAttributes.NotContentIndexed)
                {
                    clbFileFolderAttributes.SetItemCheckState(9, CheckState.Checked);
                }
                if (((FileAttributes)DetailObject.Attributes & FileAttributes.Offline) == FileAttributes.Offline)
                {
                    clbFileFolderAttributes.SetItemCheckState(10, CheckState.Checked);
                }
                if (((FileAttributes)DetailObject.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    clbFileFolderAttributes.SetItemCheckState(11, CheckState.Checked);
                }
                if (((FileAttributes)DetailObject.Attributes & FileAttributes.ReparsePoint) == FileAttributes.ReparsePoint)
                {
                    clbFileFolderAttributes.SetItemCheckState(12, CheckState.Checked);
                }
                if (((FileAttributes)DetailObject.Attributes & FileAttributes.System) == FileAttributes.System)
                {
                    clbFileFolderAttributes.SetItemCheckState(13, CheckState.Checked);
                }
                if (((FileAttributes)DetailObject.Attributes & FileAttributes.Temporary) == FileAttributes.Temporary)
                {
                    clbFileFolderAttributes.SetItemCheckState(14, CheckState.Checked);
                }
            }

            clbAdvanced.SetItemCheckState(3, CheckState.Checked);

            if (Node.ObjectCategory == aTreeControlledObjectCategory.Access)
            {
                aTreeAccessControlEntry DetailObject =
                    (aTreeAccessControlEntry)Node.DetailObject;

                tcMain.SelectedTab = tpDetail;

                tbPrincipal.Text = DetailObject.Identity;
                tbAccessType.Text = DetailObject.AccessControlType.ToString();

                for (int i = 0; i <= (clbAdvanced.Items.Count - 1); i++)
                {
                    clbAdvanced.SetItemCheckState(i, CheckState.Unchecked);
                }

                for (int i = 0; i <= (clbBasic.Items.Count - 1); i++)
                {
                    clbBasic.SetItemCheckState(i, CheckState.Unchecked);
                }


                switch ((int)DetailObject.AccessFlags) {

                    case 2032127: //Full control
                        clbBasic.SetItemCheckState(0, CheckState.Checked);
                        clbBasic.SetItemCheckState(1, CheckState.Checked);
                        clbBasic.SetItemCheckState(2, CheckState.Checked);
                        clbBasic.SetItemCheckState(3, CheckState.Checked);
                        clbBasic.SetItemCheckState(4, CheckState.Checked);
                        clbBasic.SetItemCheckState(5, CheckState.Checked);
                        break;

                    case 1245631: //Modify
                        clbBasic.SetItemCheckState(1, CheckState.Checked);
                        clbBasic.SetItemCheckState(2, CheckState.Checked);
                        clbBasic.SetItemCheckState(3, CheckState.Checked);
                        clbBasic.SetItemCheckState(4, CheckState.Checked);
                        clbBasic.SetItemCheckState(5, CheckState.Checked);
                        break;

                    case 1179817: //Read & execute
                        clbBasic.SetItemCheckState(2, CheckState.Checked);
                        clbBasic.SetItemCheckState(3, CheckState.Checked);
                        clbBasic.SetItemCheckState(4, CheckState.Checked);
                        break;

                    case 131241: //List folder contents
                        clbBasic.SetItemCheckState(3, CheckState.Checked);
                        break;

                    case 1179785: //Read
                        clbBasic.SetItemCheckState(4, CheckState.Checked);
                        break;

                    case 1048854: //Write
                        clbBasic.SetItemCheckState(5, CheckState.Checked);
                        break;

                    default: //None of the basic permission sets, i.e "Special" permissions.
                        clbBasic.SetItemCheckState(6, CheckState.Checked);
                        break;  

                }


                if (((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.FullControl) == FileSystemRights.FullControl)
                {
                    clbAdvanced.SetItemCheckState(0, CheckState.Checked);
                }

                if (((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.Traverse) == FileSystemRights.Traverse && 
                    ((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.ExecuteFile) == FileSystemRights.ExecuteFile)
                {
                    clbAdvanced.SetItemCheckState(1, CheckState.Checked);
                }

                if (((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.ListDirectory) == FileSystemRights.ListDirectory &&
                    ((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.ReadData) == FileSystemRights.ReadData)
                {
                    clbAdvanced.SetItemCheckState(2, CheckState.Checked);
                }

                if (((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.ReadAttributes) == FileSystemRights.ReadAttributes)
                {
                    clbAdvanced.SetItemCheckState(3, CheckState.Checked);
                }

                if (((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.ReadExtendedAttributes) == FileSystemRights.ReadExtendedAttributes)
                {
                    clbAdvanced.SetItemCheckState(4, CheckState.Checked);
                }

                if (((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.CreateFiles) == FileSystemRights.CreateFiles &&
                    ((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.WriteData) == FileSystemRights.WriteData)
                {
                    clbAdvanced.SetItemCheckState(5, CheckState.Checked);
                }

                if (((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.CreateDirectories) == FileSystemRights.CreateDirectories &&
                    ((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.AppendData) == FileSystemRights.AppendData)
                {
                    clbAdvanced.SetItemCheckState(6, CheckState.Checked);
                }

                if (((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.WriteAttributes) == FileSystemRights.WriteAttributes)
                {
                    clbAdvanced.SetItemCheckState(7, CheckState.Checked);
                }

                if (((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.WriteExtendedAttributes) == FileSystemRights.WriteExtendedAttributes)
                {
                    clbAdvanced.SetItemCheckState(8, CheckState.Checked);
                }

                if (((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.DeleteSubdirectoriesAndFiles) == FileSystemRights.DeleteSubdirectoriesAndFiles)
                {
                    clbAdvanced.SetItemCheckState(9, CheckState.Checked);
                }

                if (((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.Delete) == FileSystemRights.Delete)
                {
                    clbAdvanced.SetItemCheckState(10, CheckState.Checked);
                }

                if (((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.ReadPermissions) == FileSystemRights.ReadPermissions)
                {
                    clbAdvanced.SetItemCheckState(11, CheckState.Checked);
                }

                if (((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.ChangePermissions) == FileSystemRights.ChangePermissions)
                {
                    clbAdvanced.SetItemCheckState(12, CheckState.Checked);
                }

                if (((FileSystemRights)DetailObject.AccessFlags & FileSystemRights.TakeOwnership) == FileSystemRights.TakeOwnership)
                {
                    clbAdvanced.SetItemCheckState(13, CheckState.Checked);
                }

            }

        }

        #endregion

        private void tabDelimitedFiletsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentObject == null)
            {
                MessageBox.Show(
                    "Nothing to save yet, please run tool at least once.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            string FileContents =
                "Identity | File Name" + '\t' +
                "Access Control Type | Owner" + '\t' +
                "Access Flags | Size" + '\t' +
                "Is Inherited | Last Access Time" + '\t' +
                "Inheritence Flags | Last Write Time" + '\t' +
                "Propagation Flags | nocolumn" + "\r\n";

                FileContents += CreateSvItem(CurrentObject,'\t', 0);

                CommonSaveFileDialog cfd = new CommonSaveFileDialog();
                cfd.Filters.Add(new CommonFileDialogFilter("Tab-Separated Values(*.tsv)", "*.tsv"));
                cfd.Filters.Add(new CommonFileDialogFilter("All files(*.*)", "*.*"));

                if (cfd.ShowDialog() != CommonFileDialogResult.Ok)
                {
                    return;
                }

                try
                {

                    using (StreamWriter writer = new StreamWriter(cfd.FileName))
                    {
                        writer.Write(FileContents);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Failed to save file: " + ex.Message,
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;

                }
        }

        string CreateSvItem(aTreeAccessControlEntry ControlItem, char Delimiter, int Levels) {
            
            string ReturnValue = "Access Control" + Delimiter;

            //for (int i = 0; i < Levels; i++) {
            //    ReturnValue += "+";
            //}

            string EnumName = string.Empty;

            ReturnValue +=
                EscapeDelimiterString(ControlItem.Identity.ToString(), Delimiter) + Delimiter;

                EnumName = Enum.GetName(typeof(AccessControlType), ControlItem.AccessControlType);
            if (EnumName != null) {
                ReturnValue += EscapeDelimiterString(EnumName ,Delimiter) + Delimiter;
            }
            else {
                ReturnValue += EscapeDelimiterString(ControlItem.AccessControlType.ToString(), Delimiter) + Delimiter;
            }

            EnumName = Enum.GetName(typeof(FileSystemRights), ControlItem.AccessFlags);
            if (EnumName != null)
            {
                ReturnValue += EscapeDelimiterString(EnumName, Delimiter) + Delimiter;
            }
            else {
                ReturnValue += EscapeDelimiterString(ControlItem.AccessFlags.ToString(), Delimiter) + Delimiter;
            }

            ReturnValue += EscapeDelimiterString(ControlItem.IsInherited.ToString(), Delimiter) + Delimiter;

            EnumName = Enum.GetName(typeof(InheritanceFlags), ControlItem.InheritanceFlags);
            if (EnumName != null)
            {
                ReturnValue += EscapeDelimiterString(EnumName, Delimiter) + Delimiter;
            }
            else {
                ReturnValue += EscapeDelimiterString(ControlItem.InheritanceFlags.ToString(), Delimiter) + Delimiter;
            }

            ReturnValue += EscapeDelimiterString(ControlItem.IsInherited.ToString(), Delimiter) + Delimiter;

            EnumName = Enum.GetName(typeof(PropagationFlags), ControlItem.PropagationFlags);
            if (EnumName != null)
            {
                ReturnValue += EscapeDelimiterString(EnumName, Delimiter) + Delimiter;
            }
            else {
                ReturnValue += EscapeDelimiterString(ControlItem.PropagationFlags.ToString(), Delimiter) + Delimiter;
            }

            ReturnValue += "\r\n";

            return ReturnValue;
                    
        }


        string CreateSvItem(aTreeControlledFileSystemObject ControlItem, char Delimiter, int Levels) {
            string ReturnValue = "File System" + Delimiter;

            //for (int i = 0; i < Levels; i++)
            //{
            //    ReturnValue += "+";
            //}

            ReturnValue +=
                EscapeDelimiterString(ControlItem.FullName, Delimiter) + Delimiter +
                EscapeDelimiterString(ControlItem.Owner, Delimiter) + Delimiter +
                EscapeDelimiterString(ControlItem.Size.ToString(), Delimiter) + Delimiter +
                EscapeDelimiterString(ControlItem.LastAccessTime.ToString(DateTimeFormat), Delimiter) + Delimiter +
                EscapeDelimiterString(ControlItem.LastWriteTime.ToString(DateTimeFormat), Delimiter) + "\r\n";

            foreach (aTreeAccessControlEntry a in ControlItem.AccessControlEntries) {
                ReturnValue += CreateSvItem(a, Delimiter, Levels + 1);
            }

            foreach (aTreeControlledFileSystemObject a in ControlItem.Children)
            {
                ReturnValue += CreateSvItem(a, Delimiter, Levels + 1);
            }

            return ReturnValue;

        }

        string EscapeDelimiterString(string Value, char Delimiter) {
            if (Delimiter == '\0') {
                return Value;
            }

            while (Value.IndexOf(Delimiter) != -1 && Value.IndexOf(Delimiter) != '\\') {
                Value = Value.Insert(Value.IndexOf(Delimiter), "\\");
            }

            return Value;
        }


    }
}
