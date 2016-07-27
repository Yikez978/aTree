using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aTree
{
    public partial class frmAdvanced : Form
    {
        public frmAdvanced()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvanced));
            this.btnClose = new System.Windows.Forms.Button();
            this.lbExNote = new System.Windows.Forms.Label();
            this.lbIncNote = new System.Windows.Forms.Label();
            this.tbWarning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUIUpdateThrottle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMaxThreadCount = new System.Windows.Forms.Label();
            this.tcAdvanced = new System.Windows.Forms.TabControl();
            this.tpFiltering = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbEnableBasicExclude = new System.Windows.Forms.CheckBox();
            this.tbBasicExcludeFilter = new System.Windows.Forms.TextBox();
            this.cbEnableBasicInclude = new System.Windows.Forms.CheckBox();
            this.tbRegExInclude = new System.Windows.Forms.TextBox();
            this.cbEnableRegexExclude = new System.Windows.Forms.CheckBox();
            this.tbRegExExclude = new System.Windows.Forms.TextBox();
            this.cbEnableRegexInclude = new System.Windows.Forms.CheckBox();
            this.tbBasicIncludeFilter = new System.Windows.Forms.TextBox();
            this.tpMultithreading = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbUpdateThrottleMilliseconds = new System.Windows.Forms.TextBox();
            this.tbMaxThreadCount = new System.Windows.Forms.TextBox();
            this.cbEnableCustomThread = new System.Windows.Forms.CheckBox();
            this.tpIdentityTranslation = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbSearchScopes = new System.Windows.Forms.TextBox();
            this.cbUseSimpleTranslation = new System.Windows.Forms.CheckBox();
            this.tcAdvanced.SuspendLayout();
            this.tpFiltering.SuspendLayout();
            this.tpMultithreading.SuspendLayout();
            this.tpIdentityTranslation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(381, 476);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbExNote
            // 
            this.lbExNote.AutoSize = true;
            this.lbExNote.Location = new System.Drawing.Point(117, 211);
            this.lbExNote.Name = "lbExNote";
            this.lbExNote.Size = new System.Drawing.Size(305, 13);
            this.lbExNote.TabIndex = 17;
            this.lbExNote.Text = "Separate clauses with semicolon (;), wildcards (*) are accepted.";
            // 
            // lbIncNote
            // 
            this.lbIncNote.AutoSize = true;
            this.lbIncNote.Location = new System.Drawing.Point(117, 124);
            this.lbIncNote.Name = "lbIncNote";
            this.lbIncNote.Size = new System.Drawing.Size(305, 13);
            this.lbIncNote.TabIndex = 14;
            this.lbIncNote.Text = "Separate clauses with semicolon (;), wildcards (*) are accepted.";
            // 
            // tbWarning
            // 
            this.tbWarning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWarning.BackColor = System.Drawing.SystemColors.Control;
            this.tbWarning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWarning.Location = new System.Drawing.Point(56, 16);
            this.tbWarning.Multiline = true;
            this.tbWarning.Name = "tbWarning";
            this.tbWarning.Size = new System.Drawing.Size(366, 40);
            this.tbWarning.TabIndex = 1;
            this.tbWarning.Text = "WARNING: Filters will add to the processing requirements for the scan. If scans b" +
    "ecome sluggish, try reducing or simplifying your filters.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // lbUIUpdateThrottle
            // 
            this.lbUIUpdateThrottle.AutoSize = true;
            this.lbUIUpdateThrottle.Location = new System.Drawing.Point(17, 170);
            this.lbUIUpdateThrottle.Name = "lbUIUpdateThrottle";
            this.lbUIUpdateThrottle.Size = new System.Drawing.Size(164, 13);
            this.lbUIUpdateThrottle.TabIndex = 15;
            this.lbUIUpdateThrottle.Text = "UI Update Throttle (Milliseconds):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Set thread counts to \"0\" to let the program determine settings automatically.";
            // 
            // lbMaxThreadCount
            // 
            this.lbMaxThreadCount.AutoSize = true;
            this.lbMaxThreadCount.Location = new System.Drawing.Point(64, 111);
            this.lbMaxThreadCount.Name = "lbMaxThreadCount";
            this.lbMaxThreadCount.Size = new System.Drawing.Size(108, 13);
            this.lbMaxThreadCount.TabIndex = 1;
            this.lbMaxThreadCount.Text = "Max. Worker Thread:";
            // 
            // tcAdvanced
            // 
            this.tcAdvanced.Controls.Add(this.tpFiltering);
            this.tcAdvanced.Controls.Add(this.tpMultithreading);
            this.tcAdvanced.Controls.Add(this.tpIdentityTranslation);
            this.tcAdvanced.Location = new System.Drawing.Point(12, 12);
            this.tcAdvanced.Name = "tcAdvanced";
            this.tcAdvanced.SelectedIndex = 0;
            this.tcAdvanced.Size = new System.Drawing.Size(448, 447);
            this.tcAdvanced.TabIndex = 14;
            // 
            // tpFiltering
            // 
            this.tpFiltering.Controls.Add(this.checkBox1);
            this.tpFiltering.Controls.Add(this.cbEnableBasicExclude);
            this.tpFiltering.Controls.Add(this.tbBasicExcludeFilter);
            this.tpFiltering.Controls.Add(this.cbEnableBasicInclude);
            this.tpFiltering.Controls.Add(this.tbRegExInclude);
            this.tpFiltering.Controls.Add(this.cbEnableRegexExclude);
            this.tpFiltering.Controls.Add(this.tbRegExExclude);
            this.tpFiltering.Controls.Add(this.cbEnableRegexInclude);
            this.tpFiltering.Controls.Add(this.tbBasicIncludeFilter);
            this.tpFiltering.Controls.Add(this.lbExNote);
            this.tpFiltering.Controls.Add(this.label1);
            this.tpFiltering.Controls.Add(this.tbWarning);
            this.tpFiltering.Controls.Add(this.lbIncNote);
            this.tpFiltering.Location = new System.Drawing.Point(4, 22);
            this.tpFiltering.Name = "tpFiltering";
            this.tpFiltering.Padding = new System.Windows.Forms.Padding(3);
            this.tpFiltering.Size = new System.Drawing.Size(440, 421);
            this.tpFiltering.TabIndex = 0;
            this.tpFiltering.Text = "Filtering";
            this.tpFiltering.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::aTree.Properties.Settings.Default.Filter_IncludeACEs;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::aTree.Properties.Settings.Default, "Filter_IncludeACEs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(16, 317);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(206, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Include Access Control Entries in Filter";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbEnableBasicExclude
            // 
            this.cbEnableBasicExclude.AutoSize = true;
            this.cbEnableBasicExclude.Checked = global::aTree.Properties.Settings.Default.Basic_ExcludeFilterEnabled;
            this.cbEnableBasicExclude.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::aTree.Properties.Settings.Default, "Basic_ExcludeFilterEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbEnableBasicExclude.Location = new System.Drawing.Point(16, 210);
            this.cbEnableBasicExclude.Name = "cbEnableBasicExclude";
            this.cbEnableBasicExclude.Size = new System.Drawing.Size(96, 17);
            this.cbEnableBasicExclude.TabIndex = 8;
            this.cbEnableBasicExclude.Text = "Basic Exclude:";
            this.cbEnableBasicExclude.UseVisualStyleBackColor = true;
            this.cbEnableBasicExclude.CheckedChanged += new System.EventHandler(this.cbEnableBasicExclude_CheckedChanged);
            // 
            // tbBasicExcludeFilter
            // 
            this.tbBasicExcludeFilter.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::aTree.Properties.Settings.Default, "Basic_ExcludeFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbBasicExcludeFilter.Enabled = false;
            this.tbBasicExcludeFilter.Location = new System.Drawing.Point(120, 240);
            this.tbBasicExcludeFilter.Multiline = true;
            this.tbBasicExcludeFilter.Name = "tbBasicExcludeFilter";
            this.tbBasicExcludeFilter.Size = new System.Drawing.Size(302, 47);
            this.tbBasicExcludeFilter.TabIndex = 9;
            this.tbBasicExcludeFilter.Text = global::aTree.Properties.Settings.Default.Basic_ExcludeFilter;
            // 
            // cbEnableBasicInclude
            // 
            this.cbEnableBasicInclude.AutoSize = true;
            this.cbEnableBasicInclude.Checked = global::aTree.Properties.Settings.Default.Basic_IncludeFilterEnabled;
            this.cbEnableBasicInclude.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::aTree.Properties.Settings.Default, "Basic_IncludeFilterEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbEnableBasicInclude.Location = new System.Drawing.Point(16, 123);
            this.cbEnableBasicInclude.Name = "cbEnableBasicInclude";
            this.cbEnableBasicInclude.Size = new System.Drawing.Size(93, 17);
            this.cbEnableBasicInclude.TabIndex = 6;
            this.cbEnableBasicInclude.Text = "Basic Include:";
            this.cbEnableBasicInclude.UseVisualStyleBackColor = true;
            this.cbEnableBasicInclude.CheckedChanged += new System.EventHandler(this.cbEnableBasicInclude_CheckedChanged);
            // 
            // tbRegExInclude
            // 
            this.tbRegExInclude.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::aTree.Properties.Settings.Default, "RegEx_IncludeFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbRegExInclude.Enabled = false;
            this.tbRegExInclude.Location = new System.Drawing.Point(120, 59);
            this.tbRegExInclude.Name = "tbRegExInclude";
            this.tbRegExInclude.Size = new System.Drawing.Size(302, 20);
            this.tbRegExInclude.TabIndex = 3;
            this.tbRegExInclude.Text = global::aTree.Properties.Settings.Default.RegEx_IncludeFilter;
            // 
            // cbEnableRegexExclude
            // 
            this.cbEnableRegexExclude.AutoSize = true;
            this.cbEnableRegexExclude.Checked = global::aTree.Properties.Settings.Default.RegEx_ExcludeFilterEnabled;
            this.cbEnableRegexExclude.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::aTree.Properties.Settings.Default, "RegEx_ExcludeFilterEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbEnableRegexExclude.Enabled = false;
            this.cbEnableRegexExclude.Location = new System.Drawing.Point(16, 92);
            this.cbEnableRegexExclude.Name = "cbEnableRegexExclude";
            this.cbEnableRegexExclude.Size = new System.Drawing.Size(102, 17);
            this.cbEnableRegexExclude.TabIndex = 4;
            this.cbEnableRegexExclude.Text = "RegEx Exclude:";
            this.cbEnableRegexExclude.UseVisualStyleBackColor = true;
            // 
            // tbRegExExclude
            // 
            this.tbRegExExclude.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::aTree.Properties.Settings.Default, "RegEx_ExcludeFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbRegExExclude.Enabled = false;
            this.tbRegExExclude.Location = new System.Drawing.Point(120, 90);
            this.tbRegExExclude.Name = "tbRegExExclude";
            this.tbRegExExclude.Size = new System.Drawing.Size(302, 20);
            this.tbRegExExclude.TabIndex = 5;
            this.tbRegExExclude.Text = global::aTree.Properties.Settings.Default.RegEx_ExcludeFilter;
            // 
            // cbEnableRegexInclude
            // 
            this.cbEnableRegexInclude.AutoSize = true;
            this.cbEnableRegexInclude.Checked = global::aTree.Properties.Settings.Default.RegEx_IncludeFilterEnabled;
            this.cbEnableRegexInclude.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::aTree.Properties.Settings.Default, "RegEx_IncludeFilterEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbEnableRegexInclude.Enabled = false;
            this.cbEnableRegexInclude.Location = new System.Drawing.Point(16, 61);
            this.cbEnableRegexInclude.Name = "cbEnableRegexInclude";
            this.cbEnableRegexInclude.Size = new System.Drawing.Size(99, 17);
            this.cbEnableRegexInclude.TabIndex = 2;
            this.cbEnableRegexInclude.Text = "RegEx Include:";
            this.cbEnableRegexInclude.UseVisualStyleBackColor = true;
            // 
            // tbBasicIncludeFilter
            // 
            this.tbBasicIncludeFilter.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::aTree.Properties.Settings.Default, "Basic_IncludeFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbBasicIncludeFilter.Enabled = false;
            this.tbBasicIncludeFilter.Location = new System.Drawing.Point(120, 153);
            this.tbBasicIncludeFilter.Multiline = true;
            this.tbBasicIncludeFilter.Name = "tbBasicIncludeFilter";
            this.tbBasicIncludeFilter.Size = new System.Drawing.Size(302, 45);
            this.tbBasicIncludeFilter.TabIndex = 7;
            this.tbBasicIncludeFilter.Text = global::aTree.Properties.Settings.Default.Basic_IncludeFilter;
            // 
            // tpMultithreading
            // 
            this.tpMultithreading.Controls.Add(this.textBox1);
            this.tpMultithreading.Controls.Add(this.lbUIUpdateThrottle);
            this.tpMultithreading.Controls.Add(this.label3);
            this.tpMultithreading.Controls.Add(this.lbMaxThreadCount);
            this.tpMultithreading.Controls.Add(this.tbUpdateThrottleMilliseconds);
            this.tpMultithreading.Controls.Add(this.tbMaxThreadCount);
            this.tpMultithreading.Controls.Add(this.cbEnableCustomThread);
            this.tpMultithreading.Location = new System.Drawing.Point(4, 22);
            this.tpMultithreading.Name = "tpMultithreading";
            this.tpMultithreading.Padding = new System.Windows.Forms.Padding(3);
            this.tpMultithreading.Size = new System.Drawing.Size(440, 421);
            this.tpMultithreading.TabIndex = 1;
            this.tpMultithreading.Text = "Multithreading";
            this.tpMultithreading.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(20, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 40);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "WARNING: It is best to allow the program handle multithreading automatically. Inc" +
    "rease the UI throttle only if the window freezes during scans.";
            // 
            // tbUpdateThrottleMilliseconds
            // 
            this.tbUpdateThrottleMilliseconds.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::aTree.Properties.Settings.Default, "Scan_InterfaceUpdateThrottleMilliseconds", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbUpdateThrottleMilliseconds.Location = new System.Drawing.Point(217, 167);
            this.tbUpdateThrottleMilliseconds.Name = "tbUpdateThrottleMilliseconds";
            this.tbUpdateThrottleMilliseconds.Size = new System.Drawing.Size(205, 20);
            this.tbUpdateThrottleMilliseconds.TabIndex = 16;
            this.tbUpdateThrottleMilliseconds.Text = global::aTree.Properties.Settings.Default.Scan_InterfaceUpdateThrottleMilliseconds;
            this.tbUpdateThrottleMilliseconds.TextChanged += new System.EventHandler(this.tbUpdateThrottleMilliseconds_TextChanged);
            // 
            // tbMaxThreadCount
            // 
            this.tbMaxThreadCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::aTree.Properties.Settings.Default, "Scan_MaxWorkerThreadCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMaxThreadCount.Location = new System.Drawing.Point(217, 108);
            this.tbMaxThreadCount.Name = "tbMaxThreadCount";
            this.tbMaxThreadCount.Size = new System.Drawing.Size(205, 20);
            this.tbMaxThreadCount.TabIndex = 11;
            this.tbMaxThreadCount.Text = global::aTree.Properties.Settings.Default.Scan_MaxWorkerThreadCount;
            this.tbMaxThreadCount.TextChanged += new System.EventHandler(this.tbMaxThreadCount_TextChanged);
            this.tbMaxThreadCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxThreadCount_KeyPress);
            this.tbMaxThreadCount.Leave += new System.EventHandler(this.tbMaxThreadCount_Leave);
            // 
            // cbEnableCustomThread
            // 
            this.cbEnableCustomThread.AutoSize = true;
            this.cbEnableCustomThread.Checked = global::aTree.Properties.Settings.Default.Scan_EnableCustomThreadParameters;
            this.cbEnableCustomThread.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::aTree.Properties.Settings.Default, "Scan_EnableCustomThreadParameters", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbEnableCustomThread.Location = new System.Drawing.Point(20, 80);
            this.cbEnableCustomThread.Name = "cbEnableCustomThread";
            this.cbEnableCustomThread.Size = new System.Drawing.Size(222, 17);
            this.cbEnableCustomThread.TabIndex = 10;
            this.cbEnableCustomThread.Text = "Enable Custom Multithreading Parameters";
            this.cbEnableCustomThread.UseVisualStyleBackColor = true;
            this.cbEnableCustomThread.CheckedChanged += new System.EventHandler(this.cbEnableCustomThread_CheckedChanged);
            // 
            // tpIdentityTranslation
            // 
            this.tpIdentityTranslation.Controls.Add(this.textBox3);
            this.tpIdentityTranslation.Controls.Add(this.textBox2);
            this.tpIdentityTranslation.Controls.Add(this.tbSearchScopes);
            this.tpIdentityTranslation.Controls.Add(this.cbUseSimpleTranslation);
            this.tpIdentityTranslation.Location = new System.Drawing.Point(4, 22);
            this.tpIdentityTranslation.Name = "tpIdentityTranslation";
            this.tpIdentityTranslation.Padding = new System.Windows.Forms.Padding(3);
            this.tpIdentityTranslation.Size = new System.Drawing.Size(440, 421);
            this.tpIdentityTranslation.TabIndex = 2;
            this.tpIdentityTranslation.Text = "Identity Translation";
            this.tpIdentityTranslation.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(24, 154);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(402, 91);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "Specify the scopes in distinguishedName format, and delimit by pipe (  |  ) or ne" +
    "w-line. \r\n\r\nExample: \r\n\r\nDC=MYDOMAIN,DC=COM\r\nOU=IdentityContainer,DC=PARTNERDOMA" +
    "IN,DC=COM";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(24, 16);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(402, 97);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // tbSearchScopes
            // 
            this.tbSearchScopes.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::aTree.Properties.Settings.Default, "Scan_TranslationLookupScopes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbSearchScopes.Location = new System.Drawing.Point(24, 266);
            this.tbSearchScopes.Multiline = true;
            this.tbSearchScopes.Name = "tbSearchScopes";
            this.tbSearchScopes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSearchScopes.Size = new System.Drawing.Size(402, 136);
            this.tbSearchScopes.TabIndex = 1;
            this.tbSearchScopes.Text = global::aTree.Properties.Settings.Default.Scan_TranslationLookupScopes;
            // 
            // cbUseSimpleTranslation
            // 
            this.cbUseSimpleTranslation.AutoSize = true;
            this.cbUseSimpleTranslation.Checked = global::aTree.Properties.Settings.Default.Scan_SimpleNameTranslation;
            this.cbUseSimpleTranslation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseSimpleTranslation.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::aTree.Properties.Settings.Default, "Scan_SimpleNameTranslation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbUseSimpleTranslation.Location = new System.Drawing.Point(24, 119);
            this.cbUseSimpleTranslation.Name = "cbUseSimpleTranslation";
            this.cbUseSimpleTranslation.Size = new System.Drawing.Size(134, 17);
            this.cbUseSimpleTranslation.TabIndex = 0;
            this.cbUseSimpleTranslation.Text = "Use Simple Translation";
            this.cbUseSimpleTranslation.UseVisualStyleBackColor = true;
            this.cbUseSimpleTranslation.CheckedChanged += new System.EventHandler(this.cbUseSimpleTranslation_CheckedChanged);
            // 
            // frmAdvanced
            // 
            this.ClientSize = new System.Drawing.Size(470, 515);
            this.Controls.Add(this.tcAdvanced);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAdvanced";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Advanced Options";
            this.Load += new System.EventHandler(this.frmAdvanced_Load);
            this.tcAdvanced.ResumeLayout(false);
            this.tpFiltering.ResumeLayout(false);
            this.tpFiltering.PerformLayout();
            this.tpMultithreading.ResumeLayout(false);
            this.tpMultithreading.PerformLayout();
            this.tpIdentityTranslation.ResumeLayout(false);
            this.tpIdentityTranslation.PerformLayout();
            this.ResumeLayout(false);

        }
        private Button btnClose;
        private TextBox tbRegExInclude;
        private TextBox tbRegExExclude;

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void tbMaxThreadCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            string chars = "0123456789" + (char)8;
            if (!(chars.Contains(e.KeyChar))) { e.Handled = true; }
        }

        private void tbMaxThreadCount_Leave(object sender, EventArgs e)
        {
            int t = 8;
            if (int.TryParse(tbMaxThreadCount.Text, out t)) {

                tbMaxThreadCount.Text = t.ToString();

            }
        }

        private void frmAdvanced_Load(object sender, EventArgs e)
        {
            tcAdvanced.Focus();
            if (!Properties.Settings.Default.Scan_EnableCustomThreadParameters) {
                tbMaxThreadCount.Enabled = false;
            }

            if (!Properties.Settings.Default.Scan_SimpleNameTranslation)
            {
                cbUseSimpleTranslation.Checked = false;
                tbSearchScopes.Enabled = true;
            }
            if (Properties.Settings.Default.Basic_ExcludeFilterEnabled)
            {
                tbBasicExcludeFilter.Enabled = true;
            }
            if (Properties.Settings.Default.Basic_IncludeFilterEnabled)
            {
                tbBasicIncludeFilter.Enabled = true;
            }

            //TODO: Remove this when Advanced translation works.
            tcAdvanced.TabPages.Remove(tpIdentityTranslation);

        }

        private void tbMaxThreadCount_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Scan_MaxWorkerThreadCount = 
                tbMaxThreadCount.Text;
        }

        private void tbUpdateThrottleMilliseconds_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Scan_InterfaceUpdateThrottleMilliseconds =
                tbUpdateThrottleMilliseconds.Text;
        }

        private void cbEnableCustomThread_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Scan_EnableCustomThreadParameters = 
                cbEnableCustomThread.Checked;

            tbMaxThreadCount.Enabled = (bool)cbEnableCustomThread.Checked;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbUseSimpleTranslation_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Scan_SimpleNameTranslation =
                cbUseSimpleTranslation.Checked;

            tbSearchScopes.Enabled = !(bool)cbUseSimpleTranslation.Checked;

        }

        private void cbEnableBasicInclude_CheckedChanged(object sender, EventArgs e)
        {
            tbBasicIncludeFilter.Enabled = (bool)cbEnableBasicInclude.Checked;
        }

        private void cbEnableBasicExclude_CheckedChanged(object sender, EventArgs e)
        {
            tbBasicExcludeFilter.Enabled = (bool)cbEnableBasicExclude.Checked;
        }
    }
}
