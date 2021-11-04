using Ji.Commons;
using Ji.Core;
using Ji.Model;
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
        public List<Ji_GetDetailBillResult> AddOrderItems(List<AddListOrder> listOrders)
        {
            var data = API.Post<ResultCustomModel<List<Ji_GetDetailBillResult>>>(UrlApi.AddOrderItem, listOrders);
            return data.Data;
        }

        public int CalculationTotalMoneyOrder()
        {
            var data = API.Get<ResultCustomModel<int>>(UrlApi.CalculationTotalMoneyOrder);
            return data.Data;
        }

        public List<Orders> ListOrder()
        {
            var data = API.Get<ResultCustomModel<List<Orders>>>(UrlApi.ListOrder);
            return data.Data;
        }
        public List<Ji_GetDetailBillResult> ListOrderDetail(OrderDetailRequest orderDetailRequest)
        {
            var data = API.Post<ResultCustomModel<List<Ji_GetDetailBillResult>>>(UrlApi.ListOrderDetail, orderDetailRequest);
            return data.Data;
        }
        public bool RemoveOrderItems(OrderDeleteItem item)
        {
            var data = API.Post<ResultCustomModel<bool>>(UrlApi.RemoveOrderItems, item);
            return data.Data;
        }
    }
}
