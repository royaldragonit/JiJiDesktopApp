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
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using Ji.Services.Interface;
using Ji.Model.Entities;
using Ji.Model.OrderModels;
using Ji.Model.CustomModels;
using Ji.Commons;
using Ji.Model.Billing;
using System.Diagnostics;
using Ji.Views;

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
                    CheckedListBoxItem items = new CheckedListBoxItem(item.ToppingId, true);
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
            TabControlListTable.TabPages.Clear();
        }
        public void LoadControl()
        {
            RemoveAllChildControl();
            int NumberTableInRow = (TabControlListTable.Width - 6) / 7;
            int Width = (TabControlListTable.Width - 6) / (NumberTableInRow == 0 ? 1 : NumberTableInRow);
            if (initCashier.ListFloor != null)
            {
                foreach (var item in Configure.SetupFloor)
                {
                    XtraTabPage tp = new XtraTabPage();
                    tp.Name = "TabFloor" + item.Id;
                    tp.BackColor = Color.FromArgb(255, 192, 192);
                    tp.Click += Tp_Click;
                    tp.Tag = item.Id;
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
                if (tbx != null)
                {
                    tbx.Appearance.BackColor = Color.Yellow;
                    tbx.Appearance.ForeColor = Color.Black;
                }
            }
            chkBarCode.Visible = Configure.Setup.ShowBarCode.Value;
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
                    var dataPrint = _orderServices.GetListOrderByTable(Floor, Table);
                    if (dataPrint != null && dataPrint.Count > 0)
                    {
                        int discount = dataPrint.Sum(x => x.cTotal) * txtDiscountPercent.Text?.ToInt() ?? 0 / 100 - txtDiscountMoney.Text?.ToInt() ?? 0;
                        int totalMoney = dataPrint.Sum(x => x.cTotal) - discount;
                        int CustomerMoney = -1;
                        string CustomerName = "Khách yêu ♥";
                        if (!string.IsNullOrEmpty(txtCustomerName.EditValue.ToString()))
                            CustomerName = txtCustomerName.Text;
                        if (!string.IsNullOrEmpty(txtCustomerMoney.EditValue.ToString()))
                            CustomerMoney = txtCustomerMoney.Text.ToInt();
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
                                printTool.PrinterSettings.PrinterName = Configure.Setup.DefaultPrinter;
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
            UI.ShowSplashForm();
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
            UI.CloseSplashForm();
        }
        private void ucMiikTea_Load(object sender, EventArgs e)
        {
            CallPrintBill();
            UI.CloseSplashForm();
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
            OrderDeleteItem item = new OrderDeleteItem();
            item.FoodID = FoodID;
            item.OrderID = OrderID;
            item.ToppingID = ToppingID;
            if (UI.Question("Bạn có muốn xóa món này không?"))
            {
                if (!Extension.CheckInternet())
                {
                    UI.Warning(MessageConstant.CheckInternet);
                    return;
                }
                bool isRemoveSuccess = _orderServices.RemoveOrderItems(item);
                if (isRemoveSuccess)
                    LoadData(Floor, Table);
            }
        }

        public void BindingData()
        {

        }
        public void LoadData(int floor, int table, IEnumerable<Ji_GetDetailBillResult> lstData = null)
        {
            if (!Extension.CheckInternet())
            {
                UI.Warning(MessageConstant.CheckInternet);
                return;
            }
            //Nếu không truyền vào thì sẽ gọi API
            if (lstData == null)
            {
                OrderDetailRequest orderDetailRequest = new OrderDetailRequest();
                orderDetailRequest.Table = table;
                orderDetailRequest.Floor = floor;
                lstData = _orderServices.ListOrderDetail(orderDetailRequest);
            }
            gridControl1.DataSource = null;
            gridControl1.DataSource = lstData;
            int totalOrderMoney = _orderServices.CalculationTotalMoneyOrder();
            lblTotalMoneyOrder.Text = totalOrderMoney.ToVND();
            int total = lstData.Sum(x=>x.cTotal.Value);
            txtNote.Text = lstData.Count() > 0 ? lstData.FirstOrDefault()?.Note : "";
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
            if (lstData.Count() > 0)
                gridControl1.Tag = lstData.FirstOrDefault().cOrderID;
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
                    var ds = (List<Ji_GetDetailBillResult>)gridControl1.DataSource;
                    int total = ds.Sum(x => x.cTotal).ToInt();
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
                        var ds = (List<Ji_GetDetailBillResult>)gridControl1.DataSource;
                        int total = ds.Sum(x => x.cTotal).ToInt();
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
                UI.Warning(MessageConstant.TableNoOrder);
            else
            {
                UI.ShowSplashForm();
                PreviewPrinting printing = new PreviewPrinting();

                if (chkBarCode.Checked)
                {
                    printing.BarCode = false;
                    foreach (string item in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                    {
                        if(item == "BarCode")
                        {
                            printing.BarCode = true;
                        }
                    }
                    if (!printing.BarCode)
                    {
                        UI.Warning("Bạn phải có 1 máy in mã vạch đặt tên là \"BarCode\"");
                        var Process = new Process();
                        var ProcessStartInfo = new ProcessStartInfo("cmd", "/C control printers");
                        ProcessStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        Process.StartInfo = ProcessStartInfo;
                        Process.Start();
                        return;
                    }
                }
                var dataSource = ReadyPrinting();
                UI.CloseSplashForm();
                if (dataSource != null)
                {
                    printing.dataSource = dataSource;
                    printing.ShowDialog();
                }
            }
        }
        private List<ReportBillDetail> ReadyPrinting()
        {
            var ds = (List<Ji_GetDetailBillResult>)gridControl1.DataSource;
            int totalMoney = ds.Sum(x => x.cTotal).ToInt();
            //Tính tổng giảm giá        (%)                        và          tiền mặt
            int discount = totalMoney * txtDiscountPercent.Text.ToInt() / 100 + txtDiscountMoney.Text?.ToInt() ?? 0;
            int totalMoneyAfterDiscount = totalMoney - discount;
            if (ds != null)
            {
                int CustomerMoney = -1;
                string CustomerName = "Khách yêu ♥";
                if (!string.IsNullOrEmpty(txtCustomerName.EditValue.ToString()))
                    CustomerName = txtCustomerName.Text;
                if (!string.IsNullOrEmpty(txtCustomerMoney.EditValue.ToString()))
                    CustomerMoney = txtCustomerMoney.Text.ToInt();
                List<ReportBillDetail> lst = new List<ReportBillDetail>();
                foreach (var item in ds)
                {
                    ReportBillDetail rep = new ReportBillDetail();
                    rep.BillID = item.cOrderID.ToInt();
                    rep.Cashier = "Thu ngân";
                    rep.Topping = item.cPriceTopping.ToVND();
                    rep.cIndex = item.cIndex.ToInt();
                    rep.Quantity = item.cQuantity.ToInt();
                    rep.TimeCheckout = DateTime.Now;
                    rep.CustomerName = CustomerName;
                    rep.CustomerRefund = (CustomerMoney - totalMoney).ToVND();
                    rep.Discount = totalMoney;
                    rep.Floor = Floor;
                    rep.FoodName = item.cFood.ToString();
                    //Đơn giá tiền
                    rep.Money = item.cPrice.ToVND();
                    //Tiền khách đưa
                    rep.MoneyCustomer = CustomerMoney.ToVND();
                    //tổng tiền sau khi nhân với số lượng và Topping
                    rep.TotalMoney = item.cTotal.ToVND();
                    //Số tiền cần thanh toán
                    rep.Total = totalMoney.ToVND();
                    lst.Add(rep);
                }
                return lst;
            }
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
            var food = searchFood.EditValue as Food;
            string ListToppingID = string.Empty;
            int count = cbListTopping.Properties.Items.Count();
            List<int> vs =cbListTopping.Properties.Items.Select(x => x.Value.ToInt()).ToList();
            if (food != null)
            {
                var order = new AddListOrder
                {
                    Floor = Floor,
                    FoodID = food.Id,
                    ListTopping = vs,
                    Quantity = 1,
                    Table = Table
                };
                var rs = _orderServices.AddOrderItems(order);
                if (rs != null && rs.Count > 0)
                {
                    gridControl1.DataSource = null;
                    gridControl1.DataSource = rs;
                    gridControl1.Tag = rs[0].cOrderID;
                    string res = _orderServices.CalculationTotalMoneyOrder().ToVND();
                    lblTotalMoneyOrder.Text = res.VNDToNumber().ToVND();
                    int total = rs.Sum(x => x.cTotal).ToInt();
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
            UI.CloseSplashForm();
        }

        private void txtDiscountPercent_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TabControlListTable_Resize(object sender, EventArgs e)
        {
            if (SplashScreenManager.Default == null)
                SplashScreenManager.ShowForm(typeof(Pleasewait));
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
            if (gridControl1.DataSource == null && ((IEnumerable<Ji_GetDetailBillResult>)gridControl1.DataSource).Count() > 0)
            {
                if (UI.Question("Bạn có chắc muốn hủy đơn hàng này không?"))
                {
                    bool isRemoveSuccess = _orderServices.CancelOrder(Table, Floor);
                    if (isRemoveSuccess)
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
                frm._orderServices = _orderServices;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.Result)
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
                    var rs = _orderServices.SetNoteOrder(OrderID, txtNote.Text);
                    if (rs.Success)
                        UI.SaveInformation();
                    else
                        UI.Warning(MessageConstant.ErrorSaveNote);
                }
                else
                    UI.Warning(MessageConstant.OrderBeforeNote);
            }
            else
                UI.Warning(MessageConstant.InputNoteOrder);
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
                    UI.Warning(MessageConstant.SaleOffOverRange);
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
                    UI.Warning(MessageConstant.SaleOffOverRange);
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
                UI.Warning(MessageConstant.TableNoOrder);
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
                    if (!Configure.Setup.WarningCheckout || UI.Question("Xác nhận thanh toán?"))
                    {
                        try
                        {
                            UI.ShowSplashForm();
                            PreviewPrinting printing = new PreviewPrinting();
                            if (chkBarCode.Checked)
                                printing.BarCode = true;
                            printing.dataSource = ReadyPrinting();
                            //Khi bấm In mới lưu xuống Database
                            if (DialogResult.OK == printing.ShowDialog())
                            {
                                int CustomerMoney = -1;
                                if (!string.IsNullOrEmpty(txtCustomerName.Text))
                                    CustomerName = txtCustomerName.EditValue.ToString();
                                PercentSale += txtDiscountPercent.Text.ToInt();
                                var dataSource = (IEnumerable<Ji_GetDetailBillResult>)gridControl1.DataSource;
                                int total = dataSource.Sum(x => x.cTotal).ToInt();
                                int discount = total * PercentSale / 100 + txtDiscountMoney.Text?.ToInt() ?? 0;
                                if (!string.IsNullOrEmpty(txtCustomerMoney.Text))
                                    CustomerMoney = txtCustomerMoney.EditValue.ToInt();
                                CheckoutModel checkoutModel = new CheckoutModel();
                                checkoutModel.OrderId = gridControl1.Tag.ToInt();
                                checkoutModel.Discount = discount;
                                checkoutModel.CustomerName = CustomerName;
                                checkoutModel.Phone = "0978.123.900";
                                checkoutModel.DischargOn = DateTime.Now;
                                checkoutModel.CustomerMoney = CustomerMoney;
                                checkoutModel.Cashier = "Thu Ngân";
                                checkoutModel.TimeCheckout = DateTime.Now;
                                checkoutModel.CustomerRefund = (txtCustomerMoney.ToInt() - total + discount).ToVND();
                                checkoutModel.TotalMoney = total - discount;
                                checkoutModel.CustomerId = CustomerID;
                                checkoutModel.DeliveryType = Delivery;
                                checkoutModel.OrderDetail = dataSource;
                                bool isCheckoutSuccess = _orderServices.Checkout(checkoutModel);
                                if (isCheckoutSuccess)
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
                    UI.Warning(MessageConstant.TableNoOrder);
            }
        }
    }
}
