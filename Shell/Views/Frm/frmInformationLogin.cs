using Ji;
using Ji.Commons;
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

namespace Shell.Views.Frm
{
    public partial class frmInformationLogin : ClientForm
    {
        private JObject users = Extension.Setup;
        public frmInformationLogin()
        {
            InitializeComponent();
        }

        private void frmInformationLogin_Load(object sender, EventArgs e)
        {
            txtAddress.Text = AuthorizeConstant.Users.Address;
            txtBirthday.DateTime = AuthorizeConstant.Users.Birthday;
            txtPassword.Text = AuthorizeConstant.Users.Password;
            txtPermission.Text = AuthorizeConstant.Users.Roles;
            txtPhone.Text = AuthorizeConstant.Users.Phone;
            txtUsername.Text = AuthorizeConstant.Users.Username;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UI.Information("Hiện tại, để thay đổi thông tin User! Vui lòng liên hệ Supporter hoặc truy cập vào Web để thay đổi");
            return;
            if (users["userPassword"].ToString().ToLower() == txtPassword.Text.ToMD5().ToLower())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
