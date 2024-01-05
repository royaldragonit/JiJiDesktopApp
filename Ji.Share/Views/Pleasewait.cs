using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;
using Ji.Commons;

namespace Ji.Views
{
    public partial class Pleasewait : WaitForm
    {
        public Pleasewait()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }

        private void Pleasewait_Load(object sender, EventArgs e)
        {
            txtAddress.Text = Configure.Setup?.Address==null? txtAddress.Text: Configure.Setup?.Address;
            txtFacebook.Text = Configure.Setup?.FaceBook == null ? txtFacebook.Text : Configure.Setup?.FaceBook;
            txtPhone.Text = Configure.Setup?.Hotline == null ? txtPhone.Text : Configure.Setup?.Hotline;
        }
    }
}