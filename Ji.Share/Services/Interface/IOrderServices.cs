using Ji.Commons;
using Ji.Core;
using Ji.Model;
using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Model.OrderModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services.Interface
{
    public interface IOrderServices
    {
        List<Orders> ListOrder();
        List<Ji_GetDetailBillResult> ListOrderDetail(OrderDetailRequest orderDetailRequest);
        int CalculationTotalMoneyOrder();
        ResultCustomModel<bool> SetNoteOrder(int orderId, string note);
        bool RemoveOrderItem(int orderFoodId);
        List<Ji_GetDetailBillResult> AddOrderItems(AddListOrder listOrders);
        bool CancelOrder(int table, int floor);
        List<OrderDetail> GetListOrderByTable(int table, int floor);
        bool Checkout(CheckoutModel request);
        bool ConvertTable(int fromFloor, int fromTable, int toTable);
    }
}
