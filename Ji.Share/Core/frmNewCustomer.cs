using Ji.Model.Entities;
using Ji.Services.Interface;
using Ji.Views;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;

namespace Ji.Core
{
    public partial class frmNewCustomer : ClientForm
    {
        private readonly ICustomerServices _customerServices;
        public frmNewCustomer()
        {
            _customerServices=_customerServices.GetServices();
            InitializeComponent();
            txtPhone.Select();
        }

        public string CustomerName { get; set; }
        public int CustomerID { get; set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustomerName.Text))
            {
                if (!string.IsNullOrEmpty(txtAddress.Text) || !string.IsNullOrEmpty(txtPhone.Text))
                {
                    Customer customer = new Customer();
                    customer.Address = txtAddress.Text;
                    customer.Phone = txtPhone.Text;
                    customer.FullName = txtCustomerName.Text;
                    var result = _customerServices.AddCustomer(customer);
                    if (result.Success)
                    {
                        UI.SaveInformation();
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        CustomerName = txtCustomerName.Text;
                        CustomerID = result.Data;
                        Close();
                    }
                    else
                        UI.Warning("Chưa thêm vào được CSDL");
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
            if (txtPhone.Text.Length == 10)
            {
                var customer = _customerServices.GetCustomer(txtPhone.Text);
                if (customer != null)
                {
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    CustomerName = customer.FullName;
                    CustomerID = customer.Id;
                    Close();
                }
            }
        }
    }
}
