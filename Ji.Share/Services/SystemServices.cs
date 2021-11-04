using Ji.Commons;
using Ji.Core;
using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Model.LoginModels;
using Ji.Model.OrderModels;
using Ji.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services
{
    public class SystemServices : ISystemServices
    {
        public List<ji_GetApplicationResult> ListSystemMenu()
        {
            var data = API.Get<ResultCustomModel<List<ji_GetApplicationResult>>>(UrlApi.ListSystemMenu).Data;
            return data;
        }
        public List<LFloor> ListFloor()
        {
            var data = API.Get<ResultCustomModel<List<LFloor>>>(UrlApi.ListFloor).Data;
            return data;
        }

        public InitCashierModel InitCashier(OrderDetailRequest orderDetailRequest)
        {
            var data = API.Post<InitCashierModel>(UrlApi.InitCashier, orderDetailRequest);
            return data;
        }
    }
}
