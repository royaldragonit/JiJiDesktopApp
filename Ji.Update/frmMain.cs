using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using RestSharp;
using System.Net;
using System.Web.Script.Serialization;
namespace Ji.Update
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            b = new BackgroundWorker();
            b.WorkerReportsProgress = true;
            b.WorkerSupportsCancellation = true;
            b.DoWork += B_DoWork;
            b.ProgressChanged += B_ProgressChanged;
            b.RunWorkerCompleted += B_RunWorkerCompleted;
            if (b.IsBusy)
            {
                b.CancelAsync();
            }
            else
            {
                pbRun.Properties.Minimum = 0;
                pbRun.Properties.Step = 1;
                //PBProcess.Properties.PercentView = true;        
                b.RunWorkerAsync();
            }
        }
        private void B_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Shell.exe")))
            {
                Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Shell.exe"));
                Close();
            }
        }
        public class Installed
        {
            public int ID { get; set; }
            public string NameDLL { get; set; }
            public string MAC_Address { get; set; }
            public string Version { get; set; }
        }
        public class Installer
        {
            public string NameDLL { get; set; }
            public string Version { get; set; }
            public string DLL { get; set; }
            public Nullable<System.DateTime> CreateOn { get; set; }
        }
        private void B_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbRun.EditValue = e.ProgressPercentage;
        }
        private IEnumerable<Installer> GetInstallers()
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Application/GetInstallers");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            var response = client.Post<IEnumerable<Installer>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }
        private IEnumerable<Installed> GetInstalleds()
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Application/GetInstalleds");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            var response = client.Post<IEnumerable<Installed>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }
        private void UpdateVersion(string Version, string NameDLL)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Application/UpdateVersion");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("NameDLL", NameDLL);
            request.AddParameter("Version", Version);
            var response = client.Post<int>(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {

            }
            return;
        }
        private void AddDLL(Installed installed)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Application/AddDLL");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            var json = new JavaScriptSerializer().Serialize(installed);
            request.AddParameter("Installed", json);
            var response = client.Post<int>(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {

            }
            return;
        }
        private void B_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                #region Kiểm tra + tính toán những thứ cần tải về
                int MaxItem = 0;
                string MAC_Address = Extension.GetMACAddress();

                // Lấy tất cả dll đang có trong SQL
                List<Installer> installer = GetInstallers()?.ToList();

                //Danh sách các dll đã được cài trên máy tính có MAC_Address có trong SQL
                List<Installed> installed = GetInstalleds()?.ToList();
                //Lặp tất cả các DLL có trên Server
                string FilePath = AppDomain.CurrentDomain.BaseDirectory;

                //Lấy tên vs ver của tất cả dll đang có trong SQL
                var counter = installer.
                Select(x => new { x.NameDLL, x.Version });
                //Đếm tổng số DLL cần Update // Tìm ra được tổng số DLL
                foreach (var item in counter) //Check xem những cái đã cài đặt có trong Server không? NẾu có thì vào if
                {
                    if (installed.Any(x => x.NameDLL.Equals(item.NameDLL)))
                    {
                        Version v1 = new Version(item.Version);
                        Version v2 = new Version(installed.FirstOrDefault(x => x.NameDLL.Equals(item.NameDLL)).Version);
                        if (v1.CompareTo(v2) > 0)
                        {
                            MaxItem++;
                        }
                    }
                    else
                    {
                        MaxItem++;
                    }
                }
                Invoke((Action)(() =>
                {
                    pbRun.Properties.Maximum = MaxItem;
                    lblItem.Text = MaxItem + " Items";
                    if (MaxItem > 0)
                    {
                        ListDLL.Items.Add("Start downloading ..");
                    }
                    else
                    {
                        ListDLL.Items.Add("This is the latest version ...");
                    }
                }));
                if (MaxItem == 0)
                {
                    if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Shell.exe")))
                    {
                        Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Shell.exe"));
                        Close();
                    }
                }

                #endregion

                int StepCompletter = 0;
                foreach (var item in installer)
                {
                    //Kiểm tra xem DLL này đã được cài đặt chưa?
                    if (installed.Any(x => x.NameDLL.Equals(item.NameDLL)))//Nếu cài đặt rồi
                    {
                        Version v1 = new Version(item.Version);
                        Version v2 = new Version(installed.FirstOrDefault(x => x.NameDLL.Equals(item.NameDLL)).Version);
                        if (v1.CompareTo(v2) > 0) ////Version nếu cao hơn thì tải về
                        {
                            this.Invoke((Action)(() =>
                            {
                                ListDLL.Items.Add(string.Format(" - {1} Đang tải {0} ...", item.NameDLL, StepCompletter + 1));
                            }));
                            item.DLL.Base64ToFile(item.NameDLL, FilePath);
                            //Cập nhật Version
                            UpdateVersion(item.Version, item.NameDLL);
                            StepCompletter++;
                            this.Invoke((Action)(() =>
                            {
                                ListDLL.Items.Add(string.Format("+Download {0} Successfully", item.NameDLL));
                                ListDLL.Items.Add(string.Format("Searching...", item.NameDLL));
                                lblPercent.Text = string.Format("{0:n2} %", (Convert.ToDecimal(StepCompletter) / MaxItem * 100));
                            }));
                            b.ReportProgress(StepCompletter, StepCompletter);
                        }
                    }
                    else //Nếu chưa cài đặt
                    {
                        this.Invoke((Action)(() =>
                        {
                            ListDLL.Items.Add(string.Format(" - {1} Start downloading {0} ...", item.NameDLL, StepCompletter + 1));
                        }));
                        Installed ins = new Installed();
                        ins.MAC_Address = Extension.GetMACAddress();
                        ins.NameDLL = item.NameDLL;
                        ins.Version = item.Version;
                        AddDLL(ins);
                        item.DLL.Base64ToFile(item.NameDLL, FilePath);
                        StepCompletter++;
                        this.Invoke((Action)(() =>
                        {
                            ListDLL.Items.Add(string.Format("Download {0} Successfully", item.NameDLL));
                            ListDLL.Items.Add(string.Format("Searching..."));
                            ListDLL.Items.Add(string.Format("..."));
                            lblPercent.Text = string.Format("{0:n2} %", (Convert.ToDecimal(StepCompletter) / MaxItem * 100));
                        }));
                        b.ReportProgress(StepCompletter, StepCompletter);
                    }
                    Thread.Sleep(500);
                }
            }
            catch (Exception ex)
            {
                this.Invoke((Action)(() =>
                {
                    MessageBox.Show(ex.Message);
                }));
            }
        }
    }
}
