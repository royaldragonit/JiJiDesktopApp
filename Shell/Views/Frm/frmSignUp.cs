using Ji;
using Ji.Core;
using Ji.Model.FacModels;
using Ji.Services.Interface;
using Ji.Views;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shell.Views.Frm
{
    public partial class frmSignUp : ClientForm
    {
        private readonly IFacServices _facServices;
        public frmSignUp()
        {
            InitializeComponent();
            _facServices = _facServices.GetServices();
        }

        private void btnLSignUp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtShopName.Text) && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                if (txtEmail.Text.IsEmail() && txtPhone.Text.IsPhoneNumber())
                {
                    UI.ShowSplashForm();
                    RegisterFacility facility = new RegisterFacility();
                    facility.Mail = txtEmail.Text;
                    facility.Phone = txtPhone.Text;
                    facility.Name = txtName.Text;
                    facility.ShopName = txtShopName.Text;
                    var register = _facServices.Register(facility);
                    if (register.Success)
                    {
                        UI.Information(string.Format("Đăng ký thành công Vui lòng điền thông tin bên dưới để đăng nhập.\r\nTài khoản: {0}.\r\nMật khẩu:{1}", register.Data.Username, register.Data.Password));
                    }
                    //UI.Information(string.Format("Chúng tôi đã nhận được yêu cầu đăng ký từ bạn, vui lòng kiểm tra Email: {0} để biết thêm thông tin chi tiết ạ", txtEmail.Text));
                    else
                        UI.ShowError("Đã xảy ra lỗi trong quá trình đăng ký, vui lòng gọi add Zalo: 0978.123.302 để được tư vấn nhanh nhất");
                    UI.CloseSplashForm();
                }
                else
                    UI.Warning("Email hoặc SĐT không đúng định dạng, vui lòng thử lại");
            }
            else
                UI.Warning("Bạn phải nhập đầy đủ thông tin");
        }
    }
}
