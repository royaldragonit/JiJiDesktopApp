using DevExpress.XtraSplashScreen;
using Ji;
using Ji.Commons;
using Ji.Core;
using Ji.Services;
using Ji.Services.Interface;
using Microsoft.Extensions.DependencyInjection;
using Shell.Views.Frm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shell
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLoginWithGoogle());
            bool ownmutex;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            ConfigureServices();
            UrlApi.Url = Extension.GetAppSetting("ApiUrl");
            // Tạo và lấy quyền sở hữu một Mutex có tên là Icon;
            using (Mutex mutex = new Mutex(true, "Icon", out ownmutex))
            {
                if (ownmutex)
                {
                    if (!Extension.CheckInternet())
                    {
                        UI.Warning("Vui lòng kiểm tra kết nối mạng và thử lại");
                        return;
                    }
                    if (SplashScreenManager.Default == null || !SplashScreenManager.Default.IsSplashFormVisible)
                        SplashScreenManager.ShowForm(typeof(Pleasewait));
                    AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);
                    //using (frmCheckNewVersion frm = new frmCheckNewVersion())
                    //{
                    //    SplashScreenManager.CloseForm();
                    //    frm.DialogResult = DialogResult.OK;
                    //    if (frm.ShowDialog() != DialogResult.OK)
                    //        return;
                    //}
                    using (frmLogin frm = new frmLogin())
                    {
                        SplashScreenManager.CloseForm();
                        if (frm.ShowDialog() != DialogResult.OK)
                            return;
                    }
                    //Extension.a();
                    Application.Run(new frmMain());
                    //Nếu User nhấn nút đăng xuất thì quá trình đăng nhập lại bắt đầu
                    if (API.Access_Token == null)
                    {

                    }
                    else
                        return;
                    mutex.ReleaseMutex();
                }
                else
                {
                    UI.Warning("Ứng dụng đang chạy, vui lòng tắt ứng dụng trước");
                    EndProcess();
                    return;
                }
            }
        }
        static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            UI.Error(e);
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<ILoginServices, LoginServices>();
            services.AddTransient<ISystemServices, SystemServices>();
            services.AddTransient<IOrderServices, OrderServices>();
            services.AddTransient<IProductServices, ProductServices>();
            API.ServiceProvider = services.BuildServiceProvider();
        }
        static void EndProcess()
        {
            var shell = System.Diagnostics.Process.GetProcesses().
            Where(pr => pr.ProcessName == "Shell"); // without '.exe'
            foreach (var process in shell)
            {
                process.Kill();
            }
        }
    }
}
