using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ji.Core;
using RestSharp;
using System.Net;
using Ji.Revenue.Models;
using Ji.Revenue;

namespace Ji.Customer
{
  public partial class ucCustomer : ClientControl
  {
    public ucCustomer()
    {
      InitializeComponent();
      LoadData();
    }
    private void LoadData()
    {
      var client = new RestClient(Extension.GetAppSetting("API") + "Report/GetCustomers");
      client.Timeout = -1;
      var request = new RestRequest(Method.POST);
      request.AddHeader("Authorization", API.Token_Type + API.Access_Token);
      var response = client.Post<List<L_Customer>>(request);
      if (response.StatusCode == HttpStatusCode.OK)
      {
        gridControl1.DataSource = response.Data;
      }
    }
    private void btnAdd_Click(object sender, EventArgs e)
    {
      frmNewCustomer frm = new frmNewCustomer();
      if (frm.ShowDialog() == DialogResult.OK)
      {

      }
    }
    private int? GetBillID(string CustomerID)
    {
      var client = new RestClient(Extension.GetAppSetting("API") + "Report/GetBillID");
      client.Timeout = -1;
      var request = new RestRequest(Method.POST);
      request.AddHeader("Authorization", API.Token_Type + API.Access_Token);
      request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
      request.AddParameter("CustomerID", CustomerID);
      var response = client.Post<int>(request);
      if (response.StatusCode == HttpStatusCode.OK)
        return response.Data;
      return null;
    }
    private void btnViewDetail_Click(object sender, EventArgs e)
    {
      int CustomerID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToInt();
      using (frmRevenueCustomer frm = new frmRevenueCustomer())
      {
        frm.CustomerID = CustomerID;
        frm.ShowDialog();
      }
    }
  }
}
