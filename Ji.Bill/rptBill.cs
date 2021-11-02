using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using System.Collections.Generic;
using Ji.Model;
using Ji.Core;
using Newtonsoft.Json.Linq;

namespace Ji.Bill
{
    public partial class rptBill : XtraReport
    {
        public rptBill()
        {
            InitializeComponent();
            JObject setup = Extension.Setup;
            if (setup != null)
            {
                lblShopName.Text = setup["shopName"].ToString();
                lblAddress.Text = setup["address"].ToString();
                lblFaceBook.Text = setup["faceBook"].ToString();
                if (!string.IsNullOrEmpty(setup["logo"].ToString()))
                    imgLogo.Image = setup["logo"].ToString().Base64ToImage().Resize(250,250);
                lblPhone.Text = "Hotline: " + setup["hotline"].ToString();
            }
        }
    }
}
