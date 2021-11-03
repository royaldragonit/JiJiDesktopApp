using Ji.Commons;
using Ji.Core;
using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Model.OrderModels;
using Ji.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services
{
    public class OrderServices: IOrderServices
    {
        public List<Orders> ListOrder()
        {
            var data = API.Get<ResultCustomModel<List<Orders>>>(UrlApi.Url + UrlApi.ListOrder);
            return data.Data;
        }
        public List<Ji_GetDetailBillResult> ListOrderDetail(OrderDetailRequest orderDetailRequest)
        {
            var data = API.Post<ResultCustomModel<List<Ji_GetDetailBillResult>>>(UrlApi.Url + UrlApi.ListOrderDetail, orderDetailRequest);
            return data.Data;
        }
    }
}
