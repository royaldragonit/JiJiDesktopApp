using Ji;
using Ji.Core;
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
    public frmSignUp()
    {
      InitializeComponent();
    }

    private void btnLSignUp_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtShopName.Text) && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtEmail.Text))
      {
        if (txtEmail.Text.IsEmail() && txtPhone.Text.IsPhoneNumber())
        {
          UI.ShowSplashForm();
          var client = new RestClient(Extension.GetAppSetting("Server") + "/api/Fac/SignUpFacility");
          client.Timeout = -1;
          var request = new RestRequest(Method.POST);
          request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
          request.AddParameter("Phone", txtPhone.Text);
          request.AddParameter("Email", txtEmail.Text);
          request.AddParameter("ShopName", txtShopName.Text);
          request.AddParameter("Name", txtName.Text);
          var response = client.Post(request);
          if (response.StatusCode == HttpStatusCode.OK)
          {
            if (response.Content == "\"OK\"")
              UI.Information(string.Format("Chúng tôi đã nhận được yêu cầu đăng ký từ bạn, vui lòng kiểm tra Email: {0} để biết thêm thông tin chi tiết ạ", txtEmail.Text));
            else
              UI.ShowError("Đã xảy ra lỗi trong quá trình đăng ký, vui lòng gọi add Zalo: 0978.123.302 để được tư vấn nhanh nhất");
          }
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
