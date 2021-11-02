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

namespace Ji.Revenue
{
    public partial class ucRevenue : ClientControl, IClientControl
    {
        private List<Revenue> SaveRevenue = new List<Revenue>();
        int p = 0;
        public ucRevenue()
        {
            InitializeComponent();
            BindingData();
        }
        public void BindingData()
        {
            gridControl1.DataSource = null;
            var ds = API.GetRevenueToday<Revenue>(Extension.GetAppSetting("API") + "Report/GetRevenueToday", API.Access_Token, DateTime.Now).ToList();
            gridControl1.DataSource = ds;
            txtLy.Text = ds.Sum(x => x.cQuantity).ToString();
            lblTotalDiscount.Text = ds?.Sum(x => x.cDiscount).ToVND() ?? "0 VNĐ";
            lblTotalRevenueReal.Text = ds?.Sum(x => x.cTotalMoney.VNDToNumber()).ToVND() ?? "0 VNĐ";
            SaveRevenue = ds;
            int total = 0;
            foreach (var item in ds)
            {
                total += item.cTotalMoney.VNDToNumber();
            }
            txtTotalMoney.Text = total.ToVND();
            var pays = API.GetPayToDay<Pays>(Extension.GetAppSetting("API") + "Pay/GetPayToDay", API.Access_Token, DateTime.Now);
            int p = pays?.Sum(x => x.Money) ?? 0;
            txtTotalPay.Text = p.ToVND();
            DateTime from = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime to = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            var ds_this_month = API.GetRevenue<Revenue>(Extension.GetAppSetting("API") + "Report/GetRevenue", API.Access_Token, from, to).ToList();
            total = 0;
            foreach (var item in ds_this_month)
            {
                total += item.cTotalMoney.VNDToNumber();
            }
            txtRevenueThisMonth.Text = total.ToVND();
            lblRevenue.Text = ds.Where(x => x.Delivery.Contains("GRAB") || x.Delivery.Contains("NOW")).Sum(x => x.cTotalMoney.VNDToNumber()).ToVND();
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
                DateTime from = dtFromDate.Value.Date;
                DateTime to = dtToDate.Value.Date;
                gridControl1.DataSource = null;
                var ds = API.GetRevenue<Revenue>(Extension.GetAppSetting("API") + "Report/GetRevenue", API.Access_Token, from, to).ToList();
                gridControl1.DataSource = ds;
                SaveRevenue = ds;
                int total = 0;
                foreach (var item in ds)
                {
                    total += item.cTotalMoney.VNDToNumber();
                }
                txtTotalMoney.Text = total.ToVND();
                lblRevenue.Text = ds.Where(x => !x.Delivery.Contains("GRAB") || !x.Delivery.Contains("NOW")).Sum(x => x.cTotalMoney.VNDToNumber()).ToVND();
            }
            else
                UI.Warning("Bạn phải chọn bộ lọc \"chọn ngày\"");
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if (gridView1.DataSource != null && ((List<Revenue>)gridView1.DataSource).Count != 0 && txtBillID.Text.IsNumber())
            {
                List<Revenue> temp = (List<Revenue>)gridControl1.DataSource;
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
                    txtLy.Text = SaveRevenue.Sum(x => x.Quantity).ToString();
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
