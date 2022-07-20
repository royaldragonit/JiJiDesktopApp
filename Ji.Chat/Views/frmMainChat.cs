using Ji.Chat.Views.Shared;
using Ji.Chat.Views.Shared.Uc;
using Ji.Commons;
using Ji.Core;
using Ji.Model.CustomerModels;
using Ji.Model.Entities;
using Ji.Services.Interface;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ji.Chat.Views
{
    public partial class frmMainChat : BeautyForm
    {
        public HubConnection hubConnection;
        public ICustomerServices _customerServices;

        public frmMainChat()
        {
            _customerServices = _customerServices.GetServices();
            hubConnection = new HubConnectionBuilder()
               .WithUrl(Extension.GetAppSetting("Server") + "/chathub", options =>
               {
                   options.Headers.Add("Authorization", UrlApi.TokenType + AuthorizeConstant.Token);
               })
               .AddJsonProtocol()
               .Build();
            InitializeComponent();
            LoadSupporter();
        }
        private void LoadSupporter()
        {
            panel5.Controls.Clear();
            var listSupporter = _customerServices.ListSupporter();
            foreach (var item in listSupporter)
            {
                Users user = new Users();
                user.BackColor = Color.Transparent;
                user.Cursor = Cursors.Hand;
                user.Tag = item;
                user.Dock = DockStyle.Top;
                user.Name = "supporter_" + item.Id;
                user.ProfileImageCursor = Cursors.Hand;
                user.Size = new Size(202, 49);
                user.StatusMessage = "Online";
                user.TabIndex = 10;
                user.UserImage = Properties.Resources._2_32;
                user.Username = item.UserName;
                user.UserStatus = Status.Online;
                user.OnClick += new Users.Clicked(OnUserClick);
                panel5.Controls.Add(user);
            }
        }

        //Move Form with the mouse. This method is available in BeautyForm that this form inherits
        protected override void OnMouseDownMoveForm(object sender, MouseEventArgs e)
        {
            base.OnMouseDownMoveForm(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void typingBox1_OnTypingTextChanged(string newVal)
        {
            // When you type something this fires... From 'typingBox11.OnTypingTextChanged'
            //'NewVal' is the new value... also can be gotten from 'typingBox1.Value'

        }
        //Hàm gửi tin nhắn
        private async void typingBox1_OnHitEnter(object sender, EventArgs e)
        {
            int supporterId = 2;
            string message = typingBox1.Value;
            if (!string.IsNullOrEmpty(typingBox1.Value))
            {
                MeBubble bubble = new MeBubble();
                bubble.Dock = DockStyle.Bottom;
                bubble.SendToBack();
                bubble.Body = typingBox1.Value;
                panel4.Controls.Add(bubble);
                typingBox1.Value = "";
                await hubConnection.InvokeAsync("MerchantSendToSupporter", supporterId, message);
                panel4.VerticalScroll.Value = panel4.VerticalScroll.Maximum;
            }
        }

        private void FakeRecieving()
        {
            YouBubble bubble = new YouBubble();
            bubble.Dock = DockStyle.Bottom;
            bubble.SendToBack();
            bubble.Body = "This is a message received.";
            panel4.Controls.Add(bubble);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnUserClick(object sender, EventArgs e)
        {
            var ClickedUser = ((Users)sender);
            string name = ClickedUser.Username;
            string statusText = ClickedUser.StatusMessage;
            Image profileImage = ClickedUser.UserImage;
            this.chatHeader1.UserTitle = name;
            this.chatHeader1.UserStatusText = statusText;
            this.chatHeader1.UserImage = profileImage;
            Supporter supporter = ClickedUser.Tag as Supporter;
            var lstMessage = _customerServices.GetMessenger(AuthorizeConstant.Users.Id, supporter.Id);
            LoadMessage(lstMessage);
        }

        private void users1_Load(object sender, EventArgs e)
        {

        }

        private void meBubble2_Load(object sender, EventArgs e)
        {

        }

        private void frmMainChat_Load(object sender, EventArgs e)
        {
            StartHubs();
            ReceiveFromSupporter();
        }
        private async void StartHubs()
        {
            await hubConnection.StartAsync();
        }
        private void ReceiveFromSupporter()
        {
            hubConnection.On<string, int>("ReceiveFromSupporter", (message, supporterId) =>
            {
                var you = new YouBubble();
                you.BackColor = Color.Transparent;
                you.Body = message;
                you.ChatImageCursor = Cursors.Default;
                you.ChatTextCursor = Cursors.IBeam;
                you.Dock = DockStyle.Bottom;
                you.Location = new Point(0, 119);
                you.MinimumSize = new Size(0, 95);
                you.MsgColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
                you.MsgTextColor = SystemColors.ControlDarkDark;
                you.Name = "youBubble_" + supporterId;
                you.Padding = new Padding(0, 5, 0, 5);
                you.Size = new Size(768, 95);
                you.Status = MessageStatus.Custom;
                you.StatusImage = null;
                you.TabIndex = 1;
                you.Time = "11:46 PM";
                you.TimeColor = Color.White;
                you.UserImage = Properties.Resources._2_32;
                panel4.Controls.Add(you);
                panel4.Controls[panel4.Controls.Count - 1].Select();
                panel4.VerticalScroll.Value = panel4.VerticalScroll.Maximum;
            });

        }
        private void LoadMessage(List<MessageResponse> messages)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmMainChat));
            panel4.Controls.Clear();
            foreach (var item in messages)
            {
                if (!item.SupporterSend)
                {
                    var me = new MeBubble();
                    me.AutoSize = true;
                    me.BackColor = Color.Transparent;
                    me.Body = item.Message;
                    me.ChatImageCursor = Cursors.Default;
                    me.ChatTextCursor = Cursors.IBeam;
                    me.Dock = DockStyle.Bottom;
                    me.Location = new Point(0, 24);
                    me.MinimumSize = new Size(0, 95);
                    me.MsgColor = Color.DodgerBlue;
                    me.MsgTextColor = SystemColors.ControlLightLight;
                    me.Name = "meBubble_" + item.CustomerId;
                    me.Padding = new Padding(0, 5, 0, 5);
                    me.Size = new Size(768, 95);
                    me.Status = MessageStatus.Custom;
                    me.StatusImage = ((Image)(resources.GetObject("meBubble2.StatusImage")));
                    me.TabIndex = 2;
                    me.Time = DateTime.Now.ToString("HH:mm");
                    me.TimeColor = Color.White;
                    me.UserImage = ((Image)(resources.GetObject("meBubble2.UserImage")));
                    panel4.Controls.Add(me);
                }
                else
                {
                    var you = new YouBubble();
                    you.BackColor = Color.Transparent;
                    you.Body = item.Message;
                    you.ChatImageCursor = Cursors.Default;
                    you.ChatTextCursor = Cursors.IBeam;
                    you.Dock = DockStyle.Bottom;
                    you.Location = new Point(0, 119);
                    you.MinimumSize = new Size(0, 95);
                    you.MsgColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
                    you.MsgTextColor = SystemColors.ControlDarkDark;
                    you.Name = "youBubble_" + item.SupporterId;
                    you.Padding = new Padding(0, 5, 0, 5);
                    you.Size = new Size(768, 95);
                    you.Status = MessageStatus.Custom;
                    you.StatusImage = null;
                    you.TabIndex = 1;
                    you.Time = item.Time;
                    you.TimeColor = Color.White;
                    you.UserImage = Properties.Resources._2_32;
                    panel4.Controls.Add(you);
                }
            }
            panel4.AlwaysScrollActiveControlIntoView = true;
            if (panel4.Controls.Count > 0)
                panel4.Controls[panel4.Controls.Count - 1].Select();
            panel4.VerticalScroll.Value = panel4.VerticalScroll.Maximum;
        }
    }
}
