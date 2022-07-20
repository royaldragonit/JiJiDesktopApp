using Ji.Commons;
using Ji.Core;
using Ji.Model.CustomModels;
using Ji.Model.LoginModels;
using Ji.Services.Interface;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services
{
    public class LoginServices : ILoginServices
    {
        public ResultCustomModel<LoginResultModel> UserLogin(LoginRequest login)
        {
            var data = API.Post<ResultCustomModel<LoginResultModel>>(UrlApi.Login, login);
            return data;
        }
        public ResultCustomModel<LoginResultModel> SupporterLogin(LoginRequest login)
        {
            var data = API.Post<ResultCustomModel<LoginResultModel>>(UrlApi.SupporterLogin, login);
            return data;
        }
        public ResultCustomModel<LoginResultModel> BHXHLogin(LoginRequest login)
        {
            var data = API.Post<ResultCustomModel<LoginResultModel>>(UrlApi.BHXHLogin, login);
            return data;
        }
    }
}
