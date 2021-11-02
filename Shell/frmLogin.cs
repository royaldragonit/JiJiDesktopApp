using DevExpress.XtraSplashScreen;
using Google.Apis.Discovery.v1;
using Google.Apis.Discovery.v1.Data;
using Google.Apis.Services;
using Ji;
using Ji.Core;
using Ji.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shell.Model;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Shell
{
    public partial class frmLogin : ClientForm
    {
        protected string googleplus_client_id = "530840873560-39mgdeqjhf2ns2vueodsrg011sdj781p.apps.googleusercontent.com";    // Replace this with your Client ID
        protected string googleplus_client_secret = "F2YHsmQiqd97jeHCLk-RTyva";                                                // Replace this with your Client Secret
        protected string googleplus_redirect_url = "http://localhost:2443/Index.aspx";                                         // Replace this with your Redirect URL; Your Redirect URL from your developer.google application should match this URL.
        protected string Parameters;
        public frmLogin()
        {
            InitializeComponent();
            //frmLoginWithGoogle frm = new frmLoginWithGoogle();
            //frm.Show();
        }
        private async Task Run()
        {
            // Create the service.
            var service = new DiscoveryService(new BaseClientService.Initializer
            {
                ApplicationName = "Discovery Sample",
                ApiKey = "[YOUR_API_KEY_HERE]",
            });

            // Run the request.
            Console.WriteLine("Executing a list request...");
            var result = await service.Apis.List().ExecuteAsync();

            // Display the results.
            if (result.Items != null)
            {
                foreach (DirectoryList.ItemsData api in result.Items)
                {
                    Console.WriteLine(api.Id + " - " + api.Title);
                }
            }
        }
        private void btnGoogleLogin()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("https://accounts.google.com/o/oauth2/token");
            webRequest.Method = "POST";
            Parameters = "client_id=" + googleplus_client_id + "&client_secret=" + googleplus_client_secret + "&grant_type=authorization_code";
            byte[] byteArray = Encoding.UTF8.GetBytes(Parameters);
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ContentLength = byteArray.Length;
            Stream postStream = webRequest.GetRequestStream();
            // Add the post data to the web request
            postStream.Write(byteArray, 0, byteArray.Length);
            postStream.Close();

            WebResponse response = webRequest.GetResponse();
            postStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(postStream);
            string responseFromServer = reader.ReadToEnd();

            GooglePlusAccessToken serStatus = JsonConvert.DeserializeObject<GooglePlusAccessToken>(responseFromServer);

            if (serStatus != null)
            {
                string accessToken = string.Empty;
                accessToken = serStatus.access_token;

                if (!string.IsNullOrEmpty(accessToken))
                {
                    // This is where you want to add the code if login is successful.
                    // getgoogleplususerdataSer(accessToken);
                }
            }
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
                string Username = txtUsername.Text.Trim().ToLower();
                string Password = txtPassword.Text.Trim();
                //L_Users user = db.L_Users.FirstOrDefault(x => x.Username.Equals(Username) && x.Password.Equals(Password));
                string user = API.API_LOGIN(Extension.GetAppSetting("Token"), Username, Password);
                SplashScreenManager.CloseForm();
                JObject json = JObject.Parse(user);
                if (json["error_description"] != null)
                {
                    UI.Warning(json["error_description"].ToString());
                    return;
                }
                Extension.Setup = json;
                API.Access_Token = json["token"]?.ToString() ?? "";
                SplashScreenManager.ShowForm(typeof(PleaseWaiting));
                if (chkRememberPassword.Checked)
                {
                    if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
                        new XDocument(
                            new XElement("root",
                                new XElement("User", Username),
                                new XElement("Password", txtPassword.Text.Trim())
                            )
                        )
                        .Save("Information.xml");
                }
                else
                {
                    if (File.Exists("Information.xml"))
                    {
                        File.Delete("Information.xml");
                    }
                }
                this.DialogResult = DialogResult.OK;
                Close();
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
                if (!string.IsNullOrEmpty(GetInfoByXML("User")) && !string.IsNullOrEmpty(GetInfoByXML("Password")))
                {
                    string Username = GetInfoByXML("User"), Password = GetInfoByXML("Password");
                    string user = API.API_LOGIN(Extension.GetAppSetting("Token"), Username, Password);
                    JObject json = JObject.Parse(user);
                    if (json["error_description"] != null)
                    {
                        UI.Warning(json["error_description"].ToString());
                        return;
                    }
                    else
                    {
                        Extension.Setup = json;
                        API.Access_Token =  json["token"].ToString();
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    if (flag)
                    {
                        if (SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                            SplashScreenManager.CloseForm();
                        File.Delete("Information.xml");
                        UI.Debug("Tài khoản và mật khẩu của bạn đã lưu không chính xác, vui lòng bấm đăng nhập lần nữa để thử lại!");
                    }
                }
            }           
            if (SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.CloseForm();

        }
        /// <summary>
        /// Lấy thông tin theo element trong file XML
        /// </summary>
        /// <param name="el"></param>
        /// <returns></returns>
        private string GetInfoByXML(string el)
        {
            XElement root = XElement.Load("Information.xml");
            if (root.Element(el) != null)
                return root.Element(el).Value;
            return null;
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
