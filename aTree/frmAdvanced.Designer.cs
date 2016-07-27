namespace aTree
{
    partial class frmAdvanced
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

        #endregion
        private System.Windows.Forms.TextBox tbBasicIncludeFilter;
        private System.Windows.Forms.TextBox tbWarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIncNote;
        private System.Windows.Forms.Label lbExNote;
        private System.Windows.Forms.TextBox tbBasicExcludeFilter;
        private System.Windows.Forms.CheckBox cbEnableBasicExclude;
        private System.Windows.Forms.CheckBox cbEnableBasicInclude;
        private System.Windows.Forms.CheckBox cbEnableRegexExclude;
        private System.Windows.Forms.CheckBox cbEnableRegexInclude;
        private System.Windows.Forms.Label lbMaxThreadCount;
        private System.Windows.Forms.TextBox tbMaxThreadCount;
        private System.Windows.Forms.CheckBox cbEnableCustomThread;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUIUpdateThrottle;
        private System.Windows.Forms.TextBox tbUpdateThrottleMilliseconds;
        private System.Windows.Forms.TabControl tcAdvanced;
        private System.Windows.Forms.TabPage tpFiltering;
        private System.Windows.Forms.TabPage tpMultithreading;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tpIdentityTranslation;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbSearchScopes;
        private System.Windows.Forms.CheckBox cbUseSimpleTranslation;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}