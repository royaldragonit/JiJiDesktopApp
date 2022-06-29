using DevExpress.XtraEditors;
using Ji;
using Ji.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using Ji.Model;
using Ji.Model.CustomerModels;
using Ji.Services.Interface;

namespace Shell.Views.Frm
{
    public partial class frmChat : ClientForm
    {
        public HubConnection hubConnection;
        public readonly ICustomerServices _customerServices;
        int SupporterID { get; set; } = 0;
        public frmChat()
        {
            _customerServices= _customerServices.GetServices();
            InitializeComponent();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMessage.Text))
            {
                SendMessengerRealtime(txtMessage.Text, hubConnection.ConnectionId, Extension.Setup["userID"].ToInt());
                LoadControl(txtMessage.Text, Extension.Setup["userFullName"].ToString(), true);
                txtMessage.Text = string.Empty;
            }
        }
        private void LoadControl(string Messenger, string Name, bool Send)
        {
            PanelControl panel = new PanelControl();
            panel.Height = 65;
            panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panel.Width = flowLayoutPanel1.Width;

            LabelControl lblSender = new LabelControl();
            lblSender.Text = Name;
            lblSender.Font = new Font("Arial", 12, FontStyle.Bold);
            lblSender.Appearance.ForeColor = Color.Red;
            PanelControl panelSender = new PanelControl();
            panelSender.Dock = DockStyle.Left;
            PanelControl panelMessenger = new PanelControl();
            panelMessenger.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            LabelControl message = new LabelControl();
            message.Font = new Font("Arial", 11, FontStyle.Bold);
            message.Location = new Point(150, 15);
            message.Text = Messenger;
            message.Appearance.ForeColor = Color.Green;
            panelMessenger.Padding = new Padding(5, 5, 0, 0);
            panelMessenger.Controls.Add(message);
            if (Send)
            {
                lblSender.Text = Extension.Setup["userFullName"].ToString();
                panel.Appearance.BackColor = Color.FromArgb(192, 255, 255);
                panelSender.Dock = DockStyle.Left;
                panelSender.Width = 115;
                panelMessenger.Dock = DockStyle.Fill;
                lblSender.Location = new Point(5, 18);
                panel.Controls.Add(panelSender);
            }
            else
            {
                panel.Appearance.BackColor = Color.FromArgb(255, 192, 192);
                panelSender.Dock = DockStyle.Left;
                panelSender.Width = 115;
                panelMessenger.Dock = DockStyle.Fill;
                lblSender.Location = new Point(5, 18);
                panel.Controls.Add(panelSender);
            }
            panelSender.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelSender.Controls.Add(lblSender);





            panel.Controls.Add(panelMessenger);
            if (flowLayoutPanel1.InvokeRequired)
            {
                flowLayoutPanel1.Invoke(new MethodInvoker(delegate { flowLayoutPanel1.Controls.Add(panel); }));
            }
            else
                flowLayoutPanel1.Controls.Add(panel);
        }
        private void LoadData()
        {
            List<MessageResponse> ds = _customerServices.GetMessenger(Extension.Setup["userID"].ToInt());
            if (ds != null)
            {
                foreach (var item in ds)
                {
                    LoadControl(item.Message, item.SupporterName, !item.SupporterSend);
                }
                SupporterID = ds[0].SupporterId;
                txtMessage.Enabled = true;
                btnSend.Enabled = true;
            }
        }
        private void AddMessenger(string Messenger, string Name)
        {
            LoadControl(Messenger, Name, false);
        }
        private async void PM()
        {
            hubConnection.On<int, string, DateTime, string, string>("PM", (ID, FullName, CreateOn, Message, CustomerImage) =>
               {
                   SupporterID = ID;
                   if (lblSupporter.InvokeRequired)
                   {
                       lblSupporter.Invoke(new MethodInvoker(delegate
                       {
                           lblSupporter.Text = FullName + " đã tham gia phiên chat với bạn ♥";
                           lblSupporter.Visible = true;
                           txtMessage.Enabled = true;
                           btnSend.Enabled = true;
                       }));
                   }
                   else
                   {
                       lblSupporter.Text = FullName + " đã tham gia phiên chat với bạn ♥";
                       txtMessage.Enabled = true;
                       btnSend.Enabled = true;
                   }
                   AddMessenger(Message, FullName);
               });
           await hubConnection.StartAsync();
        }
        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(null, null);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        /// <summary>
        /// Thêm file vào nội dung
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = Extension.ChooseFile("Tệp hình ảnh (*.PNG, *.JPG, *.ICO, *.JPEG)  | *.png;*.jpg;*.ico;*.jpeg", false);
            if (file != null)
            {
                lblFile.Text = Path.GetFileName(file.FileName);
            }
        }
        private async void SendMessengerRealtime(string Messenger, string ConnectionId, int CustomerID)
        {
            if (SupporterID != 0)
            {
                await hubConnection.StartAsync();
                //Gọi hàm gửi trên Server
               await hubConnection.InvokeAsync("PM", SupporterID, txtMessage.Text, false, DateTime.Now, hubConnection.ConnectionId);
            }
        }
        private async void frmChat_Load(object sender, EventArgs e)
        {
            LoadData();
            PM();
            try
            {
                await hubConnection.StartAsync();
                //Gửi mail thông báo cho Supporter
               await hubConnection.InvokeAsync("SendMailForSupporter", Extension.Setup["shopName"].ToString(), Extension.Setup["hotline"].ToString());
            }
            catch (Exception)
            {

            }
            UI.CloseSplashForm();
        }
    }
}
