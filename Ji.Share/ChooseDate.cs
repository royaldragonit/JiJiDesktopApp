using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ji
{
    public partial class frmChooseDate : ClientForm
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public frmChooseDate()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FromDate = dtFromDate.Value;
            ToDate = dtToDate.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
