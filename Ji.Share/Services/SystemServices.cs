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
            var data = API.Get<ResultCustomModel<bool>>(UrlApi.SetDefaultDLL + "?dll=" + dll + "&className=" + className);
            return data.Data;
        }

        public SetupShop GetConfigureStore()
        {   
            var data =  API.Get<ResultCustomModel<SetupShop>>(UrlApi.GetConfigureStore);          
            return data.Data;
        }

        public bool ConfigureStore(SetupShop setup)
        {
            var data = API.Post<ResultCustomModel<bool>>(UrlApi.GetConfigureStore, setup);
            return data.Data;
        }

        public bool DeleteFloor(int floorId)
        {
            var data = API.Get<ResultCustomModel<bool>>(UrlApi.DeleteFloor);
            return data.Data;
        }

        public bool ModifyFloor(string floorName, int table, int floorId)
        {
            var data = API.Get<ResultCustomModel<bool>>(UrlApi.ModifyFloor + "?floorName=" + floorName + "&table=" + table + "&floorId=" + floorId);
            return data.Data;
        }

        public ResultCustomModel<int> AddFloor(string floorName, int table)
        {
            var data = API.Get<ResultCustomModel<int>>(UrlApi.AddFloor + "?floorName=" + floorName + "&table=" + table);
            return data;
        }
    }
}
