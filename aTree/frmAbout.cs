using System;
using System.Windows.Forms;

namespace aTree
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            tbCopy.Text = aTree.Properties.Resources.copy;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
