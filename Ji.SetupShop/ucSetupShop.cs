using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ji.Sales;
using Ji.Model;
using Ji.Core;
using Newtonsoft.Json.Linq;
using Ji.Model.Billing;
using Ji.Commons;
using Ji.Services.Interface;
using Ji.Model.Entities;
using Ji.SetupShop.Views.Frm;

namespace Ji.SetupShop
{
    public partial class ucSetupShop : ClientControl, IClientControl
    {
        private string Logo { get; set; }
        private readonly ISystemServices _systemServices;
        public ucSetupShop()
        {
            InitializeComponent();
            _systemServices = _systemServices.GetServices();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                ListPrinter.Properties.Items.Add(printer);
            ListPrinter.SelectedIndex = 0;
            if (ListPrinter.Properties.Items.Contains(Configure.Setup.DefaultPrinter))
                ListPrinter.SelectedItem = Configure.Setup.DefaultPrinter;
            LoadControl();
            BindingData();
        }


        public void LoadControl()
        {
            if (Configure.SetupFloor != null)
            {
                cbFloor.DataSource = Configure.SetupFloor;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            SampleDataPrint();
        }
        /// <summary>
        /// Dữ liệu mẫu để in thử
        /// </summary>
        private void SampleDataPrint()
        {
            PreviewPrinting preview = new PreviewPrinting();
            List<ReportBillDetail> lst = new List<ReportBillDetail>();
            ReportBillDetail rep = new ReportBillDetail();
            rep.BillID = 99999;
            rep.Cashier = "Thu ngân";
            rep.cIndex = 1;
            rep.CustomerName = "Khách yêu ♥";
            rep.CustomerRefund = "33.000đ";
            rep.Discount = 0;
            rep.Floor = 1;
            rep.FoodName = "Trà sữa ABCD";
            rep.Money = "12.000đ";
            rep.MoneyCustomer = "100.000đ";
            rep.Quantity = 1;
            rep.Table = 1;
            rep.TimeCheckout = DateTime.Now;
            rep.Topping = "Trân châu đen (10.000đ)";
            rep.Total = "67.000đ";
            rep.TotalMoney = "22.000đ";
            lst.Add(rep);
            rep = new ReportBillDetail();
            rep.BillID = 99999;
            rep.Cashier = "Thu ngân";
            rep.cIndex = 1;
            rep.CustomerName = "Khách yêu ♥";
            rep.CustomerRefund = "33.000đ";
            rep.Discount = 0;
            rep.Floor = 1;
            rep.FoodName = "Trà sữa ÈGHHHHH";
            rep.Money = "15.000đ";
            rep.MoneyCustomer = "100.000đ";
            rep.Quantity = 3;
            rep.Table = 1;
            rep.TimeCheckout = DateTime.Now;
            rep.Topping = "(0đ)";
            rep.Total = "67.000đ";
            rep.TotalMoney = "45.000đ";
            lst.Add(rep);
            var dataSource = lst;
            preview.dataSource = dataSource;
            preview.ShowDialog();
        }
        public void BindingData()
        {
            if (Configure.Setup != null)
            {
                txtAbbreviation.Text = Configure.Setup.Abbreviation;
                txtAddress.Text = Configure.Setup.Address;
                txtPhone.Text = Configure.Setup.Hotline;
                txtNameShop.Text = Configure.Setup.ShopName;
                txtSlogan.Text = Configure.Setup.Slogan;
                txtFaceBook.Text = Configure.Setup.FaceBook;
                chkWaringcheckout.Checked = Configure.Setup.WarningCheckout;
                chkBarCode.Checked = Configure.Setup.ShowBarCode.Value;
                if (!string.IsNullOrEmpty(Configure.Setup.Logo))
                {
                    imgLogo.Image = Configure.Setup.Logo.Base64ToImage().Resize(250, 250);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtAbbreviation.Text) && !string.IsNullOrEmpty(txtAddress.Text) && !string.IsNullOrEmpty(txtNameShop.Text))
            {
                if (UI.Question("Bạn có chắc muốn thiết lập " + ListPrinter.SelectedItem.ToString() + " làm máy in mặc định in Bill?"))
                {

                    Configure.Setup.Abbreviation = txtAbbreviation.Text;
                    Configure.Setup.ShopName = txtNameShop.Text;
                    Configure.Setup.Hotline = txtPhone.Text;
                    Configure.Setup.Address = txtAddress.Text;
                    Configure.Setup.Slogan = txtSlogan.Text;
                    Configure.Setup.ShowBarCode = chkBarCode.Checked;
                    Configure.Setup.DefaultPrinter = ListPrinter.SelectedItem.ToString();
                    Configure.Setup.FaceBook = txtFaceBook.Text;
                    Configure.Setup.Logo = Logo;
                    Configure.Setup.NumberPrintBill = ChooseType.Properties.Items[ChooseType.SelectedIndex].Value.ToInt();
                    Configure.Setup.WarningCheckout = chkWaringcheckout.Checked;
                    bool isSuccess = _systemServices.ConfigureStore(Configure.Setup);
                    if (isSuccess)
                        UI.SaveInformation();
                    else
                        UI.ShowError(MessageConstant.ConfigureStoreError);
                }
            }
            else
                UI.Warning("Bạn phải nhập đầy đủ thông tin");
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = Extension.ChooseFile("Tệp hình ảnh (*.PNG, *.JPG, *.ICO, *.JPEG)  | *.png;*.jpg;*.ico;*.jpeg", false);
            if (file != null)
            {
                Logo = file.FileName.ConvertFileToBase64();
                imgLogo.Image = Image.FromFile(file.FileName).Resize(250, 250);
            }
        }

        private void btnConfigureFloor_Click(object sender, EventArgs e)
        {
            using (frmConfigureFloor frm = new frmConfigureFloor())
            {
                frm.ShowDialog();
            }
        }

        private void cbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
           var selectedZone= cbFloor.SelectedItem as LFloor;
            if (selectedZone != null)
            {
                txtTable.Text = selectedZone.CountTable.ToString();
            }
        }
    }
}
