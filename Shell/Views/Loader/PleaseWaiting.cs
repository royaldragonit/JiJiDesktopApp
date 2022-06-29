using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using Ji.Commons;

namespace Shell.Views.Loader
{
    public partial class PleaseWaiting : SplashScreen
    {
        public PleaseWaiting()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void PleaseWaiting_Load(object sender, EventArgs e)
        {
            txtAddress.Text = Configure.Setup.Address;
            txtFacebook.Text = Configure.Setup.Address;
            txtPhone.Text = Configure.Setup.Hotline;
        }
    }
}