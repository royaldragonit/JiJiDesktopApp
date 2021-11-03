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
            var data = API.Post<ResultCustomModel<LoginResultModel>>(UrlApi.Url + UrlApi.Login, login);
            return data;
        }
    }
}
