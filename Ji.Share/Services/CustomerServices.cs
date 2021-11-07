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
    public class CustomerServices : ICustomerServices
    {
        public ResultCustomModel<int> AddCustomer(LCustomer customer)
        {
            var data = API.Post<ResultCustomModel<int>>(UrlApi.AddCustomer);
            return data;
        }
        public LCustomer GetCustomer(string phone)
        {
            var data = API.Get<ResultCustomModel<LCustomer>>(UrlApi.GetCustomer + "?phone=" + phone);
            return data.Data;
        }

        public List<LCustomer> ListCustomer()
        {
            var data = API.Get<ResultCustomModel<List<LCustomer>>>(UrlApi.ListCustomer);
            return data.Data;
        }
    }
}
