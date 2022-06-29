using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Ji.Model;
using Ji.Core;
using Newtonsoft.Json.Linq;
using Ji.Commons;

namespace Ji.Bill
{
    public partial class rptBarCode : XtraReport
    {
        public rptBarCode()
        {
            InitializeComponent();
            if (Configure.Setup != null)
            {
                lblShopName.Text = Configure.Setup.ShopName;
                lblAddress.Text = Configure.Setup.Address;              
            }
        }

    }
}
