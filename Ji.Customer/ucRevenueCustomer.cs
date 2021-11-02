using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ji.Revenue;
using Ji.Core;
using Ji.Revenue.Models;
using RestSharp;
using System.Net;

namespace Ji.Customer
{
  public partial class ucRevenueCustomer : ClientControl
  {
    public int CustomerID { get; set; }

    public ucRevenueCustomer()
    {
      InitializeComponent();
    }

    private void btnViewDetail_Click(object sender, EventArgs e)
    {
      var row = gridView1.FocusedRowHandle;
      int BillID = gridView1.GetRowCellValue(row, "cOrderID").ToString().ToInt();
      using (frmBillDetail frm = new frmBillDetail())
      {
        frm.BillID = BillID;
        try
        {
          var ds = API.GetBillDetail<BillDetails>(Extension.GetAppSetting("API") + "Report/GetBillsDetail", API.Access_Token, BillID).ToList();
          frm.dataSource = ds;
          frm.ShowDialog();
        }
        catch (Exception ex)
        {
          UI.Error(ex);
        }
      }
    }
    private void LoadData()
    {
      gridControl1.DataSource = null;
      var ds = GetRevenueCustomer(Extension.GetAppSetting("API") + "Report/GetRevenueCustomer", API.Access_Token, DateTime.Now)?.ToList();
      gridControl1.DataSource = ds;
    }

    private IEnumerable<Revenue.Revenue> GetRevenueCustomer(string v, string access_Token, DateTime now)
    {
      var client = new RestClient(v);
      client.Timeout = -1;
      var request = new RestRequest(Method.POST);
      request.AddHeader("Authorization", API.Token_Type + access_Token);
      request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
      request.AddParameter("CustomerID", CustomerID);
      var response = client.Post<List<Revenue.Revenue>>(request);
      if (response.StatusCode == HttpStatusCode.OK)
        return response.Data;
      return null;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (UI.Question("Bạn có chắc chắn muốn xóa phần doanh thu này không?"))
      {
        int OrderID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "cOrderID")?.ToInt() ?? 0;
        int remove = API.RemoveRevenue(OrderID);
        if (remove > 0)
        {
          LoadData();
        }
      }
    }

    private void ucRevenueCustomer_Load(object sender, EventArgs e)
    {
      LoadData();
    }
  }
}
