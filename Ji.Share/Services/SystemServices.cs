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
            var data = API.Get<ResultCustomModel<List<ji_GetApplicationResult>>>(UrlApi.ListSystemMenu);
            return data.Data;
        }
        public List<LFloor> ListFloor()
        {
            var data = API.Get<ResultCustomModel<List<LFloor>>>(UrlApi.ListFloor);
            return data.Data;
        }

        public InitCashierModel InitCashier(OrderDetailRequest orderDetailRequest)
        {
            var data = API.Post<ResultCustomModel<InitCashierModel>>(UrlApi.InitCashier, orderDetailRequest);
            return data.Data;
        }

        public bool SetDefaultDLL(string dll, string className)
        {
            var data = API.Get<ResultCustomModel<bool>>(UrlApi.SetDefaultDLL+"?dll="+ dll+"&className="+className);
            return data.Data;
        }

        public SetupShop GetConfigureStore()
        {
            var data = API.Get<ResultCustomModel<SetupShop>>(UrlApi.GetConfigureStore);
            return data.Data;
        }
    }
}
