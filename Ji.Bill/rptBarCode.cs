using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Ji.Model;
using Ji.Core;
using Newtonsoft.Json.Linq;

namespace Ji.Bill
{
    public partial class rptBarCode : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBarCode()
        {
            InitializeComponent();
            JObject setup = Extension.Setup;
            if (setup != null)
            {
                lblShopName.Text = setup["shopName"].ToString();
                lblAddress.Text = setup["address"].ToString();              
            }
        }

    }
}
