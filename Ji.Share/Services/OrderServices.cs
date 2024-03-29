﻿using Ji.Commons;
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
    public class OrderServices : IOrderServices
    {
        public List<Ji_GetDetailBillResult> AddOrderItems(AddListOrder order)
        {
            var data = API.Post<ResultCustomModel<List<Ji_GetDetailBillResult>>>(UrlApi.AddOrderItem, order);
            return data.Data;
        }

        public int CalculationTotalMoneyOrder()
        {
            var data = API.Get<ResultCustomModel<int>>(UrlApi.CalculationTotalMoneyOrder);
            return data.Data;
        }

        public bool CancelOrder(int table, int floor)
        {
            var data = API.Get<ResultCustomModel<bool>>(UrlApi.CancelOrder + "?table=" + table + "&floor=" + floor);
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
        public bool RemoveOrderItem(int orderFoodId)
        {
            var data = API.Get<ResultCustomModel<bool>>(UrlApi.RemoveOrderItem+ "?orderFoodId="+ orderFoodId);
            return data.Data;
        }
        public bool Checkout(CheckoutModel item)
        {
            var data = API.Post<ResultCustomModel<bool>>(UrlApi.Checkout, item);
            return data.Data;
        }

        public bool ConvertTable(int fromFloor, int fromTable, int toTable)
        {
            var data = API.Get<ResultCustomModel<bool>>(UrlApi.ConvertTable + "?FromFloor=" + fromFloor + "&FromTable=" + fromTable + "&ToTable=" + toTable);
            return data.Data;
        }
        public List<OrderDetail> GetListOrderByTable(int table, int floor)
        {
            var data = API.Get<List<OrderDetail>>(UrlApi.GetListOrderByTable + "?table=" + table + "&floor=" + floor);
            return data;
        }

        public ResultCustomModel<bool> SetNoteOrder(int orderId, string note)
        {
            var data = API.Get<ResultCustomModel<bool>>(UrlApi.SetNoteOrder + "?orderId=" + orderId + "&note=" + note);
            return data;
        }
    }
}
