using DevExpress.XtraSplashScreen;
using Ji;
using Ji.Commons;
using Ji.Core;
using Ji.Model;
using Ji.Services.Interface;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Shell.Views.Loader;
//using PluginChat;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shell.Views.Frm
{
    public partial class frmMain : ClientForm, IClientControl
    {
        private readonly HubConnection hubConnection;
        private readonly ISystemServices _systemServices;
        public frmMain()
        {
            _systemServices= _systemServices.GetServices();
            InitializeComponent();
            hubConnection = new HubConnectionBuilder()
                .WithUrl(Extension.GetAppSetting("Server") + "/ChatHub", options =>
                {
                    options.Headers.Add("Authorization", API.Token_Type+API.Access_Token);
                })
                .AddJsonProtocol()
                .Build();

            hubConnection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await hubConnection.StartAsync();
            };
            LoadControl();
            
        }

        private void SubMenuExit_Click(object sender, EventArgs e)
        {
            if (UI.Question("Thoát khỏi ứng dụng?"))
                Close();
        }

        private void SubMenuPoached_Click(object sender, EventArgs e)
        {
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SaveInfoCustomer();
            CallOrder();
        }

        private void SubMenuSetupShop_Click(object sender, EventArgs e)
        {

        }

        public void LoadControl()
        {
            UI.ShowSplashForm();
            Configure.ListSystemMenu = _systemServices.ListSystemMenu();
            var menu2 = Configure.ListSystemMenu.Select(x => new
            {
                x.Category,
                x.CategoryNonUnicode
            }).Distinct();
            foreach (var cat in menu2)
            {
                ToolStripMenuItem MenuItems = new ToolStripMenuItem(cat.Category);
                MenuItems.Name = cat.CategoryNonUnicode;
                JiMenu.Items.Add(MenuItems);
                var lstMenu2 = Configure.ListSystemMenu.Where(x => x.CategoryNonUnicode.Equals(cat.CategoryNonUnicode));
                foreach (var item in lstMenu2)
                {
                    ToolStripMenuItem SubMenuItem = new ToolStripMenuItem(item.Name);
                    SubMenuItem.Name = item.NameNonUnicode;
                    if (item.Image.Length > 100)
                    {
                        Image image = item.Image.Base64ToImage();
                        SubMenuItem.Image = image;
                    }
                    SubMenuItem.Tag = item.Dll + "," + item.ClassName;
                    SubMenuItem.Click += SubMenuItem_Click;
                    string FileName = item.Dll;
                    string ClassName = item.ClassName;
                    MenuItems.DropDownItems.Add(SubMenuItem);
                }
            }
            #region Load DLL mặc định
            var menu3 = Configure.ListSystemMenu.FirstOrDefault(x =>x.DefaultDLL);
            if (menu3 != null)
            {
                ClientControl control = null;
                string fileName = menu3.Dll;
                string className = menu3.ClassName;
                if (fileName != "0")
                {
                    fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                    if (File.Exists(fileName))
                    {
                        var assembly = Assembly.LoadFile(fileName);
                        control = assembly.CreateInstance(className) as ClientControl;
                        if (control != null)
                        {
                            panelControl1.Controls.Clear();
                            panelControl1.Controls.Add(control);
                            control.Dock = DockStyle.Fill;
                        }
                        else
                            UI.Warning("Vui lòng thử lại tính năng này sau! Xin cảm ơn");
                    }
                    else
                        UI.Warning("Không tìm thấy file DLL. Vui lòng kết nối mạng và khởi động lại phần mềm");
                }
            }
            #endregion
            UI.CloseSplashForm();
        }

        private void SubMenuItem_Click(object sender, EventArgs e)
        {
            if (!Extension.CheckInternet())
            {
                UI.Warning("Vui lòng kiểm tra kết nối mạng và thử lại");
                return;
            }
            var MenuItems = sender as ToolStripMenuItem;
            ClientControl control = null;
            string fileName = MenuItems.Tag.ToString().Split(',')[0];
            string className = MenuItems.Tag.ToString().Split(',')[1];
            if (fileName != "0")
            {
                if (SplashScreenManager.Default == null || !SplashScreenManager.Default.IsSplashFormVisible)
                    SplashScreenManager.ShowForm(typeof(PleaseWaiting));
                var dll = fileName;
                fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                if (File.Exists(fileName))
                {
                    var assembly = Assembly.LoadFile(fileName);
                    control = assembly.CreateInstance(className) as ClientControl;
                    if (control != null)
                    {
                        #region Cập nhật DLL mặc định
                        _systemServices.SetDefaultDLL(dll, className);
                        #endregion
                        panelControl1.Controls.Clear();
                        panelControl1.Controls.Add(control);
                        control.Dock = DockStyle.Fill;
                    }
                    else
                        UI.Warning("Vui lòng thử lại tính năng này sau! Xin cảm ơn");
                }
                else
                    UI.Warning("Không tìm thấy file DLL. Vui lòng kết nối mạng và khởi động lại phần mềm");
                if (SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                    SplashScreenManager.CloseForm();
            }
            else
            {
                switch (MenuItems.Text)
                {
                    case "Thông tin đăng nhập":
                        {
                            frmInformationLogin frm = new frmInformationLogin();
                            frm.ShowDialog();
                            break;
                        }
                    case "Thông tin phần mềm":
                        {
                            frmInformationSoftware frm = new frmInformationSoftware();
                            frm.ShowDialog();
                            break;
                        }
                    case "Đăng xuất":
                        {
                            if (UI.Question("Bạn có muốn đăng xuất không?"))
                            {
                                API.Access_Token = null;
                                //Xóa tài khoản
                                if (File.Exists("Information.xml"))
                                    File.Delete("Information.xml");
                                Close();
                            }
                            break;
                        }
                    case "Thoát":
                        {
                            Close();
                            break;
                        }
                    case "Zalo":
                        {
                            Process.Start(Extension.GetAppSetting("ZaloLink"));
                            break;
                        }
                    case "Facebook":
                        {
                            Process.Start(Extension.GetAppSetting("FBLink"));
                            break;
                        }
                    case "Chat trực tuyến":
                        {
                            UI.ShowSplashForm();
                            //frmChatRealTime frm = new frmChatRealTime();
                            //frm.hubConnection = hubConnection;
                            //frm.UserID = Extension.Setup["userID"].ToInt();
                            //frm.Token ="Bearer "+ API.Access_Token;
                            //frm.HotLine = Extension.Setup["hotline"].ToString();
                            //frm.ShopName = Extension.Setup["shopName"].ToString();
                            //frm.ShowDialog();
                            break;
                        }
                    default:
                        {
                            UI.Warning("Chức năng " + MenuItems.Text + " đang được phát triển! Vui lòng thử lại sau!");
                            break;
                        }
                }

            }
        }
        private async void SaveInfoCustomer()
        {
            try
            {
                int CustomerID =1;
                await hubConnection.StartAsync();
                string ConnectionID = hubConnection.ConnectionId;
                //Lưu ConnectionID của Supporter lên Server
                await hubConnection.InvokeAsync("SaveInfoCustomer", ConnectionID, CustomerID);

            }
            catch (Exception ex)
            {

            }

        }
        public void CallOrder()
        {
            try
            {
                hubConnection.On<int, int>("CallOrder", (Floor, Table) =>
                {
                    NotifyNewOrder();
                    frmNewOrder frm = new frmNewOrder();
                    frm.hubConnection = hubConnection;
                    var ds = API.GetDataOrder(Floor, Table).ToDataTable();
                    frm.DataSource = ds;
                    frm.ShowDialog();
                });
            }
            catch (Exception)
            {

            }           
        }
        static void NotifyNewOrder()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = Application.StartupPath + @"\mess.wav";
            player.Play();
        }
        public void BindingData()
        {

        }
    }
}
