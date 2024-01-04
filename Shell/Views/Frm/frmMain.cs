using DevExpress.XtraSplashScreen;
using Ji;
using Ji.Chat.Views.Shared;
using Ji.Commons;
using Ji.Core;
using Ji.Model;
using Ji.Model.Entities;
using Ji.Services.Interface;
using Ji.Views;
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
        private readonly IOrderServices _orderServices;
        private readonly ICustomerServices _customerServices;
        public frmMain()
        {
            _systemServices= _systemServices.GetServices();
            _orderServices = _orderServices.GetServices();
            _customerServices = _customerServices.GetServices();
            InitializeComponent();
            hubConnection = new HubConnectionBuilder()
                .WithUrl(Extension.GetAppSetting("Server") + "/chathub", options =>
                {
                    options.Headers.Add("Authorization", UrlApi.TokenType + AuthorizeConstant.Token);
                })
                .AddJsonProtocol()
                .Build();
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
                    if (item.Image?.Length > 100)
                    {
                        Image image = item.Image.Base64ToImage();
                        SubMenuItem.Image = image;
                    }
                    SubMenuItem.Tag = item;
                    SubMenuItem.Click += SubMenuItem_Click;
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
            ji_GetApplicationResult menuItem = MenuItems.Tag as ji_GetApplicationResult;
            string fileName = menuItem.Dll;
            string className = menuItem.ClassName;
            if (!menuItem.IsForm)
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
                bool isExcept = false;
                switch (MenuItems.Text)
                {
                    case "Đăng xuất":
                        {
                            if (UI.Question("Bạn có muốn đăng xuất không?"))
                            {
                                API.AccessToken = null;
                                //Xóa tài khoản
                                if (File.Exists("Information.xml"))
                                    File.Delete("Information.xml");
                                Close();
                            }
                            isExcept=true;
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
                            isExcept = true;
                            break;
                        }
                    case "Facebook":
                        {
                            Process.Start(Extension.GetAppSetting("FBLink"));
                            isExcept = true;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                if (!isExcept)
                {
                    var assembly = Assembly.LoadFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName));
                    var form = assembly.CreateInstance(menuItem.Install) as BeautyForm;
                    form.ShowDialog();
                } 
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
                    var ds = _orderServices.GetListOrderByTable(Table,Floor);
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
