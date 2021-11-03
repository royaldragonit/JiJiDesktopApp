using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraEditors;
using Ji.Model;
using Ji.Core;
using DevExpress.XtraSplashScreen;
using System.Data.Entity;
using DevExpress.XtraEditors.Controls;
using Microsoft.AspNet.SignalR.Client;
using System.Threading;
using DevExpress.XtraPrinting.Caching;
using DevExpress.XtraReports.UI;
using Ji.Bill;
using Ji.Base;
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using Ji.Services.Interface;
using Ji.Model.Entities;
using Ji.Model.OrderModels;
using Ji.Model.CustomModels;

namespace Ji.Sales
{
    public partial class ucMilkTea : ClientControl, IClientControl
    {
        HubConnection hubConnection = new HubConnection(Extension.GetAppSetting("Server"));
        IHubProxy chat;
        private InitCashierModel initCashier;
        private int? CustomerID = null;
        private int Floor = 1, Table = 1;
        private readonly IProductServices _productServices;
        private readonly ISystemServices _systemServices;
        private readonly IOrderServices _orderServices;
        public void Initaily()
        {
            LoadData(Floor, Table, initCashier.ListOrderDetail);
            LoadControl();
            btnDelete.Click += btnDelete_Click;
            chat = hubConnection.CreateHubProxy("ChatHub");
        }

        public ucMilkTea()
        {
            _productServices = _productServices.GetServices();
            _systemServices = _systemServices.GetServices();
            _orderServices = _orderServices.GetServices();
            InitializeComponent();
            BinddingMilkTea();
            BindingTopping();
            Initaily();
        }
        public void BinddingMilkTea()
        {
            OrderDetailRequest orderDetailRequest = new OrderDetailRequest();
            orderDetailRequest.Table = Table;
            orderDetailRequest.Floor = Floor;
            initCashier = _systemServices.InitCashier(orderDetailRequest);
            searchFood.Properties.DataSource = initCashier.ListMilkTea;
            searchFood.Properties.DisplayMember = "FoodName";
            searchFood.Properties.ValueMember = "ID";
        }
        /// <summary>
        /// Lấy danh sách tất cả Order
        /// </summary>
        public void ReloadOrders()
        {
            initCashier.ListOrder = _orderServices.ListOrder();
        }
        /// <summary>
        /// Load Topping lên (Truy vấn Database ---> Tương lai sẽ chuyển sang Cached)
        /// </summary>
        private void BindingTopping()
        {
            var data = initCashier.ListTopping;
            if (data != null)
            {
                foreach (var item in data)
                {
                    CheckedListBoxItem items = new CheckedListBoxItem(item.Id, true);
                    items.Description = item.ToppingName;
                    items.CheckState = CheckState.Unchecked;
                    cbListTopping.Properties.Items.Add(items);
                }
            }
        }
        /// <summary>
        /// Hàm xóa Control để Add lại
        /// </summary>
        public void RemoveAllChildControl()
        {
            if (initCashier.ListFloor != null)
            {
                foreach (var item in initCashier.ListFloor)
                {
                    XtraTabPage tp = this.Controls.Find("TabFloor" + item.Affect, true).FirstOrDefault() as XtraTabPage;
                    TabControlListTable.TabPages.Remove(tp);
                }
            }
        }
        public void LoadControl()
        {
            int NumberTableInRow = (TabControlListTable.Width - 6) / 7;
            int Width = (TabControlListTable.Width - 6) / (NumberTableInRow == 0 ? 1 : NumberTableInRow);
            if (initCashier.ListFloor != null)
            {
                foreach (var item in initCashier.ListFloor)
                {
                    XtraTabPage tp = new XtraTabPage();
                    tp.Name = "TabFloor" + item.Affect;
                    tp.BackColor = Color.FromArgb(255, 192, 192);
                    tp.Click += Tp_Click;
                    tp.Tag = item.Affect;
                    tp.Text = item.Name;
                    TabControlListTable.TabPages.Add(tp);
                    //Số bàn trên 1 hàng
                    for (int i = 0; i < item.CountTable; i++)
                    {
                        SimpleButton btn = new SimpleButton();
                        btn.Text = (i + 1).ToString();
                        btn.Height = NumberTableInRow;
                        btn.ButtonStyle = BorderStyles.Style3D;
                        btn.Appearance.BackColor = Color.FromArgb(192, 255, 255);
                        btn.Appearance.ForeColor = Color.Black;
                        btn.Appearance.Font = new Font(btn.Appearance.Font.FontFamily, btn.Appearance.Font.Size, FontStyle.Bold);
                        btn.Name = "btnTable" + (i + 1).ToString();
                        btn.ToolTip = "Bàn " + (i + 1) + " Đang Trống";
                        btn.Width = NumberTableInRow;
                        var font1 = btn.Font;
                        btn.Font = new Font(font1, FontStyle.Bold);
                        btn.Location = new Point(btn.Width * (i % Width), btn.Height * (i / Width));
                        tp.Controls.Add(btn);
                        tp.AutoScroll = true;
                        btn.Click += BtnTable_Click;
                    }
                }
                //Set bàn đầu tiên Selected
                SetColorTable();
                SimpleButton tbx = Controls.Find("btnTable1", true).FirstOrDefault() as SimpleButton;
                tbx.Appearance.BackColor = Color.Yellow;
                tbx.Appearance.ForeColor = Color.Black;
            }
            //chkBarCode.Visible = Extension.Setup["showBarCode"].ToBoolean();
            chkBarCode.Visible =true;
        }
        /// <summary>
        /// Hàm TabPage Click để set đang chọn ở Tầng nào
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tp_Click(object sender, EventArgs e)
        {
            var tp = sender as XtraTabPage;
            Floor = tp.Tag.ToInt();
        }

        /// <summary>
        /// Hàm nhận sự kiện In từ điện thoại
        /// </summary>
        public void CallPrintBill()
        {
            try
            {
                chat.On<int, int>("CallPrintBill", (Table, Floor) =>
                {
                    var dataPrint = API.GetDataOrder(Floor, Table).ToDataTable();
                    if (dataPrint != null && dataPrint.Rows.Count > 0)
                    {
                        int t = 0;
                        foreach (DataRow item in dataPrint.Rows)
                        {
                            t = item["cTotal"].ToInt();

                        }
                        int discount = t * txtDiscountPercent.Text?.ToInt() ?? 0 / 100 - txtDiscountMoney.Text?.ToInt() ?? 0;
                        int totalMoney = t - discount;
                        int CustomerMoney = -1;
                        string CustomerName = "Khách yêu ♥";
                        if (!string.IsNullOrEmpty(txtCustomerName.EditValue.ToString()))
                            CustomerName = txtCustomerName.Text;
                        if (!string.IsNullOrEmpty(txtCustomerMoney.EditValue.ToString()))
                            CustomerMoney = txtCustomerMoney.Text.ToInt();
                        //List<ReportBillDetail> lst = new List<ReportBillDetail>();
                        //foreach (DataRow item in dataPrint.Rows)
                        //{
                        //    ReportBillDetail rep = new ReportBillDetail();
                        //    rep.BillID = item["cOrderID"].ToInt();
                        //    rep.Cashier = "Thu ngân";
                        //    rep.Topping = item["cPriceTopping"].ToVND();
                        //    rep.cIndex = item["cIndex"].ToInt();
                        //    rep.Quantity = item["cQuantity"].ToInt();
                        //    rep.TimeCheckout = DateTime.Now;
                        //    rep.CustomerName = CustomerName;
                        //    rep.CustomerRefund = (CustomerMoney - totalMoney).ToVND();
                        //    rep.Discount = discount;
                        //    rep.Floor = Floor;
                        //    rep.FoodName = item["cFood"].ToString();
                        //    //Đơn giá tiền
                        //    rep.Money = item["cPrice"].ToVND();
                        //    //Tiền khách đưa
                        //    rep.MoneyCustomer = CustomerMoney.ToVND();
                        //    //tổng tiền sau khi nhân với số lượng và Topping
                        //    rep.TotalMoney = item["cTotal"].ToVND();
                        //    //Số tiền cần thanh toán
                        //    rep.Total = totalMoney.ToVND();
                        //    lst.Add(rep);
                        //}
                        rptBill report = new rptBill();
                        report.ShowPrintMarginsWarning = false;
                        // report.DataSource = lst;
                        report.CreateDocument();
                        Thread thread = new Thread(() =>
                        {
                            BeginInvoke((Action)delegate ()
                            {
                                var storage = new MemoryDocumentStorage();
                                // report.ExportToPdf(Environment.SpecialFolder.MyDocuments.ToString());
                                var cachedReportSource = new CachedReportSource(report, storage);
                                var printTool = new ReportPrintTool(report);
                                printTool.PrinterSettings.PrinterName = Extension.Setup["defaultPrinter"].ToString();
                                printTool.Print();
                            });
                        });
                        thread.Start();
                    }
                });
                hubConnection.Start().Wait(5000);
                chat.Invoke("Notify", "Console app", hubConnection.ConnectionId);
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Set màu cho từng bàn
        /// </summary>
        public void SetColorTable()
        {
            foreach (var item in initCashier.ListOrder)
            {
                SimpleButton sb = Controls.Find("btnTable" + item.Table, true).FirstOrDefault() as SimpleButton;
                if (sb != null)
                {
                    sb.ToolTip = sb.Text + " đang có đơn hàng   ";
                    sb.Appearance.BackColor = Color.Red;
                    sb.Appearance.ForeColor = Color.Black;
                }
            }
        }
        private void BtnTable_Click(object sender, EventArgs e)
        {
            if (SplashScreenManager.Default == null || !SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.ShowForm(typeof(Pleasewait));
            //Thay đổi màu của bàn cũ thành màu xanh 
            SimpleButton tbx = Controls.Find("btnTable" + Table, true).FirstOrDefault() as SimpleButton;
            tbx.Appearance.BackColor = Color.FromArgb(192, 255, 255);
            tbx.Appearance.ForeColor = Color.Black;
            SetColorTable();
            //Thay đổi màu bàn hiện tại đang chọn thành màu vàng
            SimpleButton btn = sender as SimpleButton;
            btn.Appearance.BackColor = Color.Yellow;
            btn.Appearance.ForeColor = Color.Black;
            //Set biến Table thành bàn hiện tại đặt
            Table = btn.Text.ToInt();
            //Load lại dữ liệu của bàn hiện tại
            LoadData(Floor, Table);
            if (SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.CloseForm();
        }
        private void ucMiikTea_Load(object sender, EventArgs e)
        {
            CallPrintBill();
            if (SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.CloseForm();
        }
        /// <summary>
        /// Hàm xóa món
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var row = gridView1.FocusedRowHandle;
            int OrderID = gridView1.GetRowCellValue(row, "cOrderID").ToString().ToInt();
            int FoodID = gridView1.GetRowCellValue(row, "cFoodID").ToString().ToInt();
            string ToppingID = gridView1.GetRowCellValue(row, "cToppingID")?.ToString();
            if (UI.Question("Bạn có muốn xóa món này không?"))
            {
                if (!Extension.CheckInternet())
                {
                    UI.Warning("Vui lòng kiểm tra kết nối mạng và thử lại");
                    return;
                }
                if (API.RemoveOrderItems(OrderID, FoodID, ToppingID) != -1)
                    LoadData(Floor, Table);
            }
        }

        public void BindingData()
        {

        }
        public void LoadData(int floor, int table, List<Ji_GetDetailBillResult> lstData=null)
        {
            if (!Extension.CheckInternet())
            {
                UI.Warning("Vui lòng kiểm tra kết nối mạng và thử lại");
                return;
            }
            if (lstData == null)
            {
                OrderDetailRequest orderDetailRequest = new OrderDetailRequest();
                orderDetailRequest.Table = table;
                orderDetailRequest.Floor = floor;
                lstData= _orderServices.ListOrderDetail(orderDetailRequest);
            }
            gridControl1.DataSource = null;
            gridControl1.DataSource = lstData;
            lblTotalMoneyOrder.Text = 136975.ToVND();
            int total = 0;
            foreach (var item in lstData)
            {
                total += item.cTotal.Value;
            }
            txtNote.Text = lstData.Count > 0 ? lstData[0].Note : "";
            txtTotalTemp.Text = total.ToVND();
            try
            {
                int t = txtDiscountPercent.Text?.ToInt() ?? 0;
                if (t < 0 || t > 50)
                    UI.Warning("Vui lòng nhập định dạng giảm giá đúng với số");
                else
                {
                    txtTotal.Text = (total - total * t / 100 - txtDiscountMoney.Text?.ToInt() ?? 0).ToVND();
                }
            }
            catch (Exception)
            {
                UI.Warning("Vui lòng nhập định dạng giảm giá đúng với số");
            }
            if (lstData.Count > 0)
                gridControl1.Tag = lstData[0].cOrderID;
        }

        private void txtDiscountMoney_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (!e.NewValue.ToString().IsNumber())
                e.Cancel = true;
            else
            {
                try
                {
                    int t = txtDiscountPercent.Text?.ToInt() ?? 0;
                    var ds = (DataTable)gridControl1.DataSource;
                    int total = 0;
                    foreach (DataRow item in ds.Rows)
                    {
                        total += item["cTotal"].ToInt();
                    }
                    txtTotal.Text = (total - total * t / 100 - txtDiscountMoney.Text?.ToInt() ?? 0).ToVND();
                }
                catch (Exception)
                {
                    UI.Warning("Vui lòng nhập định dạng giảm giá đúng với số");
                    e.Cancel = true;
                }
            }
        }

        private void txtDiscountPercent_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (!e.NewValue.ToString().IsNumber())
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    int t = txtDiscountPercent.Text.ToInt();
                    if (t < 0 || t > 50)
                    {
                        UI.Warning("Vui lòng nhập định dạng giảm giá đúng < 50%");
                        e.Cancel = true;
                    }
                    else
                    {
                        var ds = (DataTable)gridControl1.DataSource;
                        int total = 0;
                        foreach (DataRow item in ds.Rows)
                        {
                            total += item["cTotal"].ToInt();
                        }
                        txtTotal.Text = (total - total * t / 100 - txtDiscountMoney.Text?.ToInt() ?? 0).ToVND();
                    }
                }
                catch (Exception)
                {
                    UI.Warning("Vui lòng nhập định dạng giảm giá đúng với số");
                    e.Cancel = true;
                }
            }
        }

        private void txtTotalTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabControlListTable_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (e.Page != null)
                Floor = e.Page.Tag.ToInt();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (gridControl1.DataSource == null)
                UI.Warning("Bàn này chưa gọi món nào");
            else
            {
                if (SplashScreenManager.Default == null || !SplashScreenManager.Default.IsSplashFormVisible)
                    SplashScreenManager.ShowForm(typeof(Pleasewait));
                PreviewPrinting printing = new PreviewPrinting();
                if (chkBarCode.Checked)
                    printing.BarCode = true;
                var dataSource = ReadyPrinting();
                if (dataSource != null)
                {
                    //  printing.dataSource = dataSource;
                    printing.ShowDialog();
                }
                if (SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                    SplashScreenManager.CloseForm();
            }
        }
        private List<dynamic> ReadyPrinting()
        {
            //var ds = ((DataTable)gridControl1.DataSource);
            //int t = 0;
            //foreach (DataRow item in ds.Rows)
            //{
            //    t += item["cTotal"].ToInt();
            //}
            ////Tính tổng giảm giá        (%)                        và          tiền mặt
            //int discount = t * txtDiscountPercent.Text.ToInt() / 100 + txtDiscountMoney.Text?.ToInt() ?? 0;
            //int totalMoney = t - discount;
            //if (ds.Rows.Count > 0)
            //{
            //    int CustomerMoney = -1;
            //    string CustomerName = "Khách yêu ♥";
            //    if (!string.IsNullOrEmpty(txtCustomerName.EditValue.ToString()))
            //        CustomerName = txtCustomerName.Text;
            //    if (!string.IsNullOrEmpty(txtCustomerMoney.EditValue.ToString()))
            //        CustomerMoney = txtCustomerMoney.Text.ToInt();
            //    List<ReportBillDetail> lst = new List<ReportBillDetail>();
            //    foreach (DataRow item in ds.Rows)
            //    {
            //        ReportBillDetail rep = new ReportBillDetail();
            //        rep.BillID = item["cOrderID"].ToInt();
            //        rep.Cashier = "Thu ngân";
            //        rep.Topping = item["cPriceTopping"].ToVND();
            //        rep.cIndex = item["cIndex"].ToInt();
            //        rep.Quantity = item["cQuantity"].ToInt();
            //        rep.TimeCheckout = DateTime.Now;
            //        rep.CustomerName = CustomerName;
            //        rep.CustomerRefund = (CustomerMoney - totalMoney).ToVND();
            //        rep.Discount = t;
            //        rep.Floor = Floor;
            //        rep.FoodName = item["cFood"].ToString();
            //        //Đơn giá tiền
            //        rep.Money = item["cPrice"].ToVND();
            //        //Tiền khách đưa
            //        rep.MoneyCustomer = CustomerMoney.ToVND();
            //        //tổng tiền sau khi nhân với số lượng và Topping
            //        rep.TotalMoney = item["cTotal"].ToVND();
            //        //Số tiền cần thanh toán
            //        rep.Total = totalMoney.ToVND();
            //        lst.Add(rep);
            //    }
            //    return lst;
            //}
            return null;
        }
        /// <summary>
        /// Hàm thêm món vào danh sách Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!Extension.CheckInternet())
            {
                UI.Warning("Vui lòng kiểm tra kết nối mạng và thử lại");
                return;
            }
            if (SplashScreenManager.Default == null)
                SplashScreenManager.ShowForm(typeof(Pleasewait));
            var FoodID = searchFood.EditValue;
            string ListToppingID = string.Empty;
            int count = cbListTopping.Properties.Items.Count();
            List<int> vs = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if (cbListTopping.Properties.Items[i].CheckState == CheckState.Checked)
                    vs.Add(cbListTopping.Properties.Items[i].Value.ToInt());
            }
            if (vs.Count() > 0)
            {
                vs.Sort();
                ListToppingID = vs.ToStringID();
            }
            if (FoodID != null)
            {
                List<AddListOrder> listOrders = new List<AddListOrder>
                {
                    new AddListOrder
                    {
                        Floor=Floor,
                        FoodID=FoodID.ToInt(),
                        ListTopping=vs,
                        Quantity=1,
                        Table=Table
                    }
                };
                var rs = API.AddOrderItems(listOrders).ToDataTable();
                if (rs != null && rs.Rows.Count > 0)
                {
                    gridControl1.DataSource = null;
                    gridControl1.DataSource = rs;
                    gridControl1.Tag = rs.Rows[0]["cOrderID"];
                    string res = API.GetTotalMoneyOrder();
                    lblTotalMoneyOrder.Text = res.VNDToNumber().ToVND();
                    var ds = (DataTable)gridControl1.DataSource;
                    int total = 0;
                    foreach (DataRow item in rs.Rows)
                    {
                        total += item["cTotal"].ToInt();
                    }
                    txtTotalTemp.Text = total.ToVND();
                    //Giảm theo %
                    int t = txtDiscountPercent.Text?.ToInt() ?? 0;
                    if (t < 0 || t > 50)
                        UI.Warning("Vui lòng nhập định dạng giảm giá đúng với số");
                    else
                    {
                        // + thêm giảm tiền mặt
                        t += txtDiscountMoney.Text?.ToInt() ?? 0;
                        txtTotal.Text = (total - t).ToVND();
                    }
                    ReloadOrders();
                }
            }
            if (SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.CloseForm();
        }

        private void txtDiscountPercent_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TabControlListTable_Resize(object sender, EventArgs e)
        {
            if (SplashScreenManager.Default == null)
                SplashScreenManager.ShowForm(typeof(Pleasewait));
            RemoveAllChildControl();
            LoadControl();
            LoadData(1, 1);
            if (SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.CloseForm();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Hàm hủy đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (gridControl1.DataSource == null && ((DataTable)gridControl1.DataSource).Rows.Count > 0)
            {
                if (UI.Question("Bạn có chắc muốn hủy đơn hàng này không?"))
                {
                    int ds1 = API.DeleteOrder(Floor, Table);
                    if (ds1 > 0)
                    {
                        ReloadOrders();
                        LoadData(Floor, Table);
                    }
                }
            }
        }
        /// <summary>
        /// Hàm chuyển bàn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMergeTable_Click(object sender, EventArgs e)
        {
            using (frmChooseTable frm = new frmChooseTable())
            {
                frm.FromTable = Table;
                frm.FromFloor = Floor;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.Result > 0)
                        LoadData(Floor, Table);
                }
            }
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            if (txtNote.Text.Length > 0)
            {
                int OrderID = gridControl1.Tag?.ToInt() ?? 0;
                if (OrderID > 0)
                {
                    int rs = API.SetNoteOrder(OrderID, txtNote.Text);
                    if (rs > 0)
                        UI.SaveInformation();
                    else
                        UI.Warning("Có lỗi khi lưu Lưu Ý :( vui lòng thử lại nhé");
                }
                else
                    UI.Warning("Bạn chưa Order, vui lòng Order trước khi Note");
            }
            else
                UI.Warning("Bạn chưa nhập Lưu Ý cho đơn hàng");
        }

        private void cbListTopping_MeasureListBoxItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 35;
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "cSaleOff")
            {
                if (!e.Value.ToString().IsNumber())
                {
                    UI.Warning("Giảm giá phải là số và không quá 100%");
                    gridView1.SetRowCellValue(e.RowHandle, "cSaleOff", 0);
                }
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "cSaleOff")
            {
                if (e.Value.ToInt() > 100 || e.Value.ToInt() < 0)
                {
                    UI.Warning("Giảm giá phải là số và không quá 100%");
                    gridView1.SetRowCellValue(e.RowHandle, "cSaleOff", 0);
                    return;
                }
                int cPrice = gridView1.GetRowCellValue(e.RowHandle, "cPrice").ToInt();
                int cQuantity = gridView1.GetRowCellValue(e.RowHandle, "cQuantity").ToInt();
                gridView1.SetRowCellValue(e.RowHandle, "cTotal", cPrice * cQuantity - cPrice * cQuantity * e.Value.ToInt() / 100);
                int t = ((List<OrderDetailV2>)gridControl1.DataSource).Sum(x => x.cTotal);
                txtTotalTemp.Text = t.ToVND();
                int discount = t - t * txtDiscountPercent.Text.ToInt() / 100 - txtDiscountMoney.Text?.ToInt() ?? 0;
                txtTotal.Text = discount.ToVND();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmNewCustomer frm = new frmNewCustomer();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CustomerID = frm.CustomerID;
                txtCustomerName.Text = frm.CustomerName;
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (gridControl1.DataSource == null)
                UI.Warning("Bàn này chưa gọi món nào");
            else
            {
                if (((DataTable)gridControl1.DataSource).Rows.Count > 0)
                {
                    string CustomerName = "Khách lẻ", Delivery = "";
                    int PercentSale = 0;
                    switch (cbTypeSale.SelectedIndex)
                    {
                        case -1:
                            CustomerName = "Khách yêu ♥ ♥";
                            break;
                        //Grab Food
                        case 0:
                            if (CustomerID == null)
                            {
                                btnAddCustomer_Click(null, null);
                                if (CustomerID == null)
                                    return;
                            }
                            PercentSale = 25;
                            CustomerName = cbTypeSale.SelectedItem.ToString();
                            Delivery = "GRAB";
                            break;
                        //Now Food
                        case 1:
                            if (CustomerID == null)
                            {
                                btnAddCustomer_Click(null, null);
                                if (CustomerID == null)
                                    return;
                            }
                            PercentSale = 20;
                            Delivery = "NOW";
                            break;
                        //Go Food
                        case 2:
                            PercentSale = 25;
                            Delivery = "GOFOOD";
                            break;
                        //BeaMin
                        case 3:
                            PercentSale = 25;
                            break;
                        default:
                            PercentSale = 0;
                            break;
                    }
                    if (!Extension.Setup["warningCheckout"].ToBoolean() || UI.Question("Xác nhận thanh toán?"))
                    {
                        try
                        {
                            if (SplashScreenManager.Default == null || !SplashScreenManager.Default.IsSplashFormVisible)
                                SplashScreenManager.ShowForm(typeof(Pleasewait));
                            PreviewPrinting printing = new PreviewPrinting();
                            if (chkBarCode.Checked)
                                printing.BarCode = true;
                            var ds = ReadyPrinting();
                            // printing.dataSource = ds;
                            //Khi bấm In mới lưu xuống Database
                            if (DialogResult.OK == printing.ShowDialog())
                            {
                                int CustomerMoney = -1;
                                if (!string.IsNullOrEmpty(txtCustomerName.Text))
                                    CustomerName = txtCustomerName.EditValue.ToString();
                                PercentSale += txtDiscountPercent.Text.ToInt();
                                var ds1 = ((DataTable)gridControl1.DataSource);
                                int t = 0;
                                foreach (DataRow item in ds1.Rows)
                                {
                                    t += item["cTotal"].ToInt();
                                }
                                int discount = t * PercentSale / 100 + txtDiscountMoney.Text?.ToInt() ?? 0;
                                if (!string.IsNullOrEmpty(txtCustomerMoney.Text))
                                    CustomerMoney = txtCustomerMoney.EditValue.ToInt();
                                if (API.API_ReportBill<int>(Extension.GetAppSetting("API") + "Report/GetReport", API.Access_Token, gridControl1.Tag.ToInt(), discount, CustomerName, "0978.123.900", DateTime.Now, CustomerMoney, "Thu Ngân", DateTime.Now, (txtCustomerMoney.ToInt() - t + discount).ToVND(), t - discount, ds1, CustomerID, Delivery) != -1)
                                {
                                    LoadData(Floor, Table);
                                    //Reset lại text ban đầu
                                    txtCustomerMoney.Text = "0";
                                    txtDiscountPercent.Text = "0";
                                    txtDiscountMoney.Text = "0";
                                    cbTypeSale.SelectedIndex = 4;
                                    chkBarCode.Checked = false;
                                    CustomerID = null;
                                    txtCustomerName.Text = "Khách yêu ♥";
                                }
                                else
                                    UI.Warning("Lỗi! Chưa thêm dữ liệu vào doanh thu được!");
                            }
                        }
                        catch (Exception ex)
                        {
                            UI.Error(ex);
                        }
                        finally
                        {
                            if (SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                                SplashScreenManager.CloseForm();
                        }
                    }
                }
                else
                    UI.Warning("Bàn này chưa gọi món nào");
            }
        }
    }
}
