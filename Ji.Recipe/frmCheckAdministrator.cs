using Ji.Core;
using Ji.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ji.Recipe
{
    public partial class frmCheckAdministrator : ClientForm
    {
        public frmCheckAdministrator()
        {
            InitializeComponent();
            lblError.Visible = false;
        }

        private void txtPassword_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            lblError.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            JObject users = Extension.Setup;
            if (users["userPassword"].ToString().ToLower() == txtPassword.Text.ToMD5().ToLower())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                lblError.Visible = true;
        }
    }
}
