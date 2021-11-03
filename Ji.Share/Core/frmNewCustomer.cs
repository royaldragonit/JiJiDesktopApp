using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;

namespace Ji.Core
{
    public partial class frmNewCustomer : ClientForm
    {
        public frmNewCustomer()
        {
            InitializeComponent();
            txtPhone.Select();
        }

        public string CustomerName { get; set; }
        public int CustomerID { get; set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustomerName.Text))
            {
                if (!string.IsNullOrEmpty(txtEmail.Text) || !string.IsNullOrEmpty(txtPhone.Text))
                {
                    var client = new RestClient(Extension.GetAppSetting("API") + "Application/AddCustomer");
                    client.Timeout = -1;
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Authorization", API.Token_Type + API.Access_Token);
                    request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                    request.AddParameter("Email", txtEmail.Text);
                    request.AddParameter("Phone", txtPhone.Text);
                    request.AddParameter("Name", txtCustomerName.Text);
                    var response = client.Post<int>(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        if (response.Data > 0)
                        {
                            UI.SaveInformation();
                            DialogResult = System.Windows.Forms.DialogResult.OK;
                            CustomerName = txtCustomerName.Text;
                            CustomerID = response.Data;
                            Close();
                        }
                        else
                            UI.Warning("Chưa thêm vào được CSDL");
                    }
                }
                else
                    UI.Warning("Email hoặc SĐT phải có ít nhất 1 thông tin");
            }
            else
                UI.Warning("Không được để trống tên khách hàng");
        }

        private void txtPhone_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!e.NewValue.ToString().IsNumber())
                e.Cancel = true;
        }

        private void txtPhone_EditValueChanged(object sender, EventArgs e)
        {
            //Kiểm tra số điện thoại
            if (txtPhone.Text.Length == 10)
            {
                var client = new RestClient(Extension.GetAppSetting("API") + "Application/CheckCustomer");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", API.Token_Type + API.Access_Token);
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("Phone", txtPhone.Text);
                //var response = client.Post<L_Customer>(request);
                //if (response.StatusCode == HttpStatusCode.OK)
                //{
                //    //Nếu khách hàng đã tồn tại
                //    if (response.Data != null)
                //    {
                //        DialogResult = System.Windows.Forms.DialogResult.OK;
                //        CustomerName = response.Data.FullName;
                //        CustomerID = response.Data.ID;
                //        Close();
                //    }
                //}
            }
        }
    }
}
