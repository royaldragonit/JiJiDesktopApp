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
using Ji.Services.Interface;

namespace Ji.Customer
{
    public partial class ucRevenueCustomer : ClientControl
    {
        public int CustomerID { get; set; }
        private readonly IRevenueServices _revenueServices;
        public ucRevenueCustomer()
        {
            InitializeComponent();
            _revenueServices = _revenueServices.GetServices();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            var row = gridView1.FocusedRowHandle;
            int BillID = gridView1.GetRowCellValue(row, "cOrderID").ToString().ToInt();
            using (frmBillDetail frm = new frmBillDetail())
            {
                frm.BillID = BillID;
                frm.dataSource = _revenueServices.RevenueDetail(BillID);
                frm.ShowDialog();
            }
        }
        private void LoadData()
        {
            gridControl1.DataSource = null;
            var dataSource = _revenueServices.RevenueDistance(DateTime.Now.AddYears(-3), DateTime.Now);
            gridControl1.DataSource = dataSource;
        }

        private IEnumerable<Revenue.Revenue> GetRevenueCustomer(string v, string access_Token, DateTime now)
        {
            var client = new RestClient(v);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", API.TokenType + access_Token);
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
                bool remove = _revenueServices.RemoveRevenue(OrderID);
                if (remove)
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
