using DevExpress.XtraSplashScreen;
using Google.Apis.Discovery.v1;
using Google.Apis.Discovery.v1.Data;
using Google.Apis.Services;
using Ji;
using Ji.Commons;
using Ji.Core;
using Ji.Model;
using Ji.Model.CustomModels;
using Ji.Model.LoginModels;
using Ji.Services.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shell.Model;
using Shell.Views.Loader;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Shell.Views.Frm
{
    public partial class frmLogin : ClientForm
    {
        private readonly ILoginServices _loginServices;
        public frmLogin()
        {
            _loginServices = _loginServices.GetServices();
            InitializeComponent();
        }
        /// <summary>
        /// Hàm đăng nhập khi bấm nút btnLogin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (SplashScreenManager.Default == null || !SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.ShowForm(typeof(WaitCheck));
            //Nếu tồn tại File lưu mật khẩu
            if (File.Exists("Information.xml"))
            {
                CheckInfo(true);
            }
            else
            {
                UI.ShowSplashForm();
                LoginRequest login = new LoginRequest();
                login.Username = txtUsername.Text;
                login.Password = txtPassword.Text;
                ResultCustomModel<LoginResultModel> result = _loginServices.UserLogin(login);
                UI.CloseSplashForm();
                if (result.Success)
                {
                    AuthorizeConstant.Users = result.Data.User;
                    AuthorizeConstant.Token = result.Data.Token;

                    if (chkRememberPassword.Checked)
                    {
                        new XDocument(
                            new XElement("root",
                                new XElement("User", login.Username),
                                new XElement("Password", login.Password)
                            )
                        )
                        .Save("Information.xml");
                    }
                    //Nếu không lựa chọn Remember Password thì xoá luôn file lưu trữ password
                    else
                    {
                        if (File.Exists("Information.xml"))
                        {
                            File.Delete("Information.xml");
                        }
                    }
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    UI.ShowError(result.Message["vn"]);
                    return;
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            CheckInfo();
        }
        /// <summary>
        /// Kiểm tra thông tin đăng nhập
        /// </summary>
        /// <param name="flag"></param>
        private void CheckInfo(bool flag = false)
        {
            if (File.Exists("Information.xml"))
            {
                if (!string.IsNullOrEmpty(Extension.GetInfoByXML("Information.xml","User")) && !string.IsNullOrEmpty(Extension.GetInfoByXML("Information.xml", "Password")))
                {
                    UI.ShowSplashForm();
                    LoginRequest login = new LoginRequest();
                    login.Username = Extension.GetInfoByXML("Information.xml", "User");
                    login.Password = Extension.GetInfoByXML("Information.xml", "Password");
                    ResultCustomModel<LoginResultModel> result = _loginServices.UserLogin(login);
                    UI.CloseSplashForm();
                    if (result.Success)
                    {
                        AuthorizeConstant.Users = result.Data.User;
                        AuthorizeConstant.Token = result.Data.Token;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        UI.ShowError(result.Message["vn"]);
                        return;
                    }
                }
                else
                {
                    if (flag)
                    {
                        UI.CloseSplashForm();
                        File.Delete("Information.xml");
                        UI.Debug(MessageConstant.InvalidInfoSave);
                    }
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            using (frmSignUp frm = new frmSignUp())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
