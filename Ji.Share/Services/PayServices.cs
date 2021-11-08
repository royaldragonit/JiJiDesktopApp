using Ji.Commons;
using Ji.Core;
using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services
{
    public class PayServices : IPayServices
    {
        public bool AddPay(Pay p)
        {
            var data = API.Post<ResultCustomModel<bool>>(UrlApi.AddPay,p);
            return data.Data;
        }

        public List<Pay> ListPay(DateTime now1, DateTime now2)
        {
            var data = API.Get<ResultCustomModel<List<Pay>>>(UrlApi.ListPay+ "?fromDate="+now1+"&toDate="+now2);
            return data.Data;
        }
    }
}
