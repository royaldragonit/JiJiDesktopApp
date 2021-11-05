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

namespace Ji.SetupShop
{
    public partial class ucSetupShop : ClientControl,IClientControl
    {
        private string Logo { get; set; }
        public ucSetupShop()
        {
            InitializeComponent();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                ListPrinter.Properties.Items.Add(printer);
            ListPrinter.SelectedIndex = 0;
            var setup = Extension.Setup;
            if (ListPrinter.Properties.Items.Contains(setup["defaultPrinter"]))
                ListPrinter.SelectedItem = setup["defaultPrinter"];
            BindingData();
        }


        public void LoadControl()
        {
            throw new NotImplementedException();
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
            var setup = Extension.Setup;
            if (setup != null)
            {
                txtAbbreviation.Text = setup["abbreviation"].ToString();
                txtAddress.Text = setup["shopAddress"].ToString();
                txtPhone.Text = setup["hotline"].ToString();
                txtNameShop.Text = setup["shopName"].ToString();
                txtSlogan.Text = setup["slogan"].ToString();
                txtFaceBook.Text = setup["faceBook"].ToString();
                chkWaringcheckout.Checked = setup["warningCheckout"].ToString().ToBoolean();
                chkBarCode.Checked = setup["showBarCode"].ToString().ToBoolean();
                if (!string.IsNullOrEmpty(setup["logo"].ToString()))
                {
                    imgLogo.Image = setup["logo"].ToString().Base64ToImage().Resize(250, 250);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtAbbreviation.Text) && !string.IsNullOrEmpty(txtAddress.Text) && !string.IsNullOrEmpty(txtNameShop.Text))
            {
                if (UI.Question("Bạn có chắc muốn thiết lập " + ListPrinter.SelectedItem.ToString() + " làm máy in mặc định in Bill?"))
                {

                    int rs = API.SetSetup(txtNameShop.Text, txtAbbreviation.Text, txtPhone.Text, txtAddress.Text, txtSlogan.Text, chkBarCode.Checked, ListPrinter.SelectedItem.ToString(), txtFaceBook.Text, Logo, ChooseType.Properties.Items[ChooseType.SelectedIndex].Value.ToInt(),chkWaringcheckout.Checked);
                    if (rs > 0)
                    {
                        JObject setup = new JObject();
                        setup["abbreviation"] = txtAbbreviation.Text;
                        setup["shopName"] = txtNameShop.Text;
                        setup["hotline"] = txtPhone.Text;
                        setup["address"] = txtAddress.Text;
                        setup["slogan"] = txtSlogan.Text;
                        setup["showBarCode"] = chkBarCode.Checked;
                        setup["defaultPrinter"] = ListPrinter.SelectedItem.ToString();
                        setup["faceBook"] = txtFaceBook.Text;
                        setup["logo"] = Logo;
                        setup["numberPrintBill"] = ChooseType.Properties.Items[ChooseType.SelectedIndex].Value.ToInt();
                        setup["warningCheckout"] = chkWaringcheckout.Checked;
                        setup["id"] = Extension.Setup["id"];
                        setup["facID"] = Extension.Setup["facID"];
                        Extension.Setup = setup;
                        UI.SaveInformation();
                    }

                    else
                        UI.Warning("Đã xảy ra lỗi, vui lòng kiểm tra lại");
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
                imgLogo.Image = Image.FromFile(file.FileName).Resize(250,250);
            }
        }
    }
}
