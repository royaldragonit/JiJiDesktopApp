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
using Ji.Revenue.Models;
using Ji.Model;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;
using System.Reflection;
using System.IO;
using Ji.Services.Interface;
using Ji.Commons;
using Ji.Model.CustomModels;
using Ji.Model.Entities;

namespace Ji.Revenue
{
    public partial class ucRevenue : ClientControl, IClientControl
    {
        private List<ji_Report_RevenueTodayResult> SaveRevenue = new List<ji_Report_RevenueTodayResult>();
        private readonly IRevenueServices _revenueServices;
        int p = 0;
        public ucRevenue()
        {
            InitializeComponent();
            _revenueServices = _revenueServices.GetServices();
            BindingData();
        }
        public void BindingData()
        {
            InitRevenueModel data = _revenueServices.InitRevenue(Configure.Setup.FacId);
            gridControl1.DataSource = null;
            gridControl1.DataSource = data.RevenueToday;
            txtLy.Text = data.RevenueToday.Sum(x => x.cQuantity).ToString();
            lblTotalDiscount.Text = data.RevenueToday?.Sum(x => x.cDiscount).ToVND() ?? "0 VNĐ";
            lblTotalRevenueReal.Text = data.RevenueToday?.Sum(x => x.cTotalMoney.VNDToNumber()).ToVND() ?? "0 VNĐ";
            SaveRevenue = data.RevenueToday;
            int total = data.RevenueToday.Sum(x => x.cTotalMoney.VNDToNumber());
            txtTotalMoney.Text = total.ToVND();
            int p = data.PayToDay?.Sum(x => x.Money) ?? 0;
            txtTotalPay.Text = p.ToVND();
            total = data.RevenueCurrentMonth.Sum(x => x.cTotalMoney.VNDToNumber()); ;
            txtRevenueThisMonth.Text = total.ToVND();
            lblRevenue.Text = data.RevenueToday.Where(x => x.Delivery.Contains("GRAB") || x.Delivery.Contains("NOW")).Sum(x => x.cTotalMoney.VNDToNumber()).ToVND();
        }

        public void LoadControl()
        {

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
        /// <summary>
        /// Hàm chọn doanh thu thuần
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hiển thị doanh từ từ ngày From đến này To
            if (ChooseType.Properties.Items[ChooseType.SelectedIndex].Value.ToString().ToInt() == 1)
            {
                PanelChoose.Visible = true;
            }
            //Hiển thị doanh thu trong ngày
            else
            {
                PanelChoose.Visible = false;
                BindingData();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (ChooseType.Properties.Items[ChooseType.SelectedIndex].Value.ToString().ToInt() == 1)
            {
                PanelChoose.Visible = true;
                DateTime fromDate = dtFromDate.Value.Date;
                DateTime toDate = dtToDate.Value.Date;
                gridControl1.DataSource = null;
                List<ji_Report_RevenueTodayResult> data = _revenueServices.RevenueDistance(fromDate, toDate);
                gridControl1.DataSource = data;
                SaveRevenue = data;
                int total = data.Sum(x => x.cTotalMoney.VNDToNumber());
                txtTotalMoney.Text = total.ToVND();
                lblRevenue.Text = data.Where(x => !x.Delivery.Contains("GRAB") || !x.Delivery.Contains("NOW")).Sum(x => x.cTotalMoney.VNDToNumber()).ToVND();
            }
            else
                UI.Warning("Bạn phải chọn bộ lọc \"chọn ngày\"");
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if (gridView1.DataSource != null && ((List<ji_Report_RevenueTodayResult>)gridView1.DataSource).Count != 0 && txtBillID.Text.IsNumber())
            {
                List<ji_Report_RevenueTodayResult> temp = (List<ji_Report_RevenueTodayResult>)gridControl1.DataSource;
                gridControl1.DataSource = null;
                var ds = temp.Where(x => x.cOrderID == txtBillID.Text.ToInt()).ToList();
                gridControl1.DataSource = ds;
                SaveRevenue = ds;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UI.Question("Bạn có chắc chắn muốn xóa phần doanh thu này không?"))
            {
                int OrderID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "cOrderID")?.ToInt() ?? 0;
                int remove = API.RemoveRevenue(OrderID);
                if (remove > 0)
                {
                    var temp = SaveRevenue.FirstOrDefault(x => x.cOrderID == OrderID);
                    SaveRevenue.Remove(temp);
                    gridControl1.DataSource = null;
                    gridControl1.DataSource = SaveRevenue;
                    txtLy.Text = SaveRevenue.Sum(x => x.cQuantity).ToString();
                    int total = 0;
                    foreach (var item in SaveRevenue)
                    {
                        total += item.cTotalMoney.VNDToNumber();
                    }
                    txtTotalMoney.Text = total.ToVND();
                }
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            string path = "doanh-thu-" + DateTime.Now.ToString().NonUnicode() + ".xlsx";
            gridControl1.ExportToXlsx(path);
            Process.Start(path);
        }

        private void btnExportToJSON_Click(object sender, EventArgs e)
        {
            UI.Warning("Chức năng này đang phát triển, vui lòng thử lại sau");
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string CustomerName = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Delivery"]);
                if (CustomerName.Contains("GRAB"))
                {
                    e.Appearance.ForeColor = Color.Green;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
                else if (CustomerName.Contains("NOW"))
                {
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }

        private void ucRevenue_Enter(object sender, EventArgs e)
        {
            if (p == 0 && DateTime.Now.Hour >= 20)
                UI.Warning("Hôm nay bạn chưa có chi bất kỳ khoản nào!");
        }

        private void ucRevenue_Load(object sender, EventArgs e)
        {

        }
    }
}
