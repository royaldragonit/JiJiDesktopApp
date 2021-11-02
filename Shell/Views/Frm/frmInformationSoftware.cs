using DevExpress.XtraEditors;
using Ji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shell.Views.Frm
{
    public partial class frmInformationSoftware : ClientForm
    {
        public frmInformationSoftware()
        {
            InitializeComponent();
        }
        private void Link_Click(object sender, EventArgs e)
        {
           var link= sender as HyperlinkLabelControl;
            Process.Start(link.ToolTip);
        }
    }
}
