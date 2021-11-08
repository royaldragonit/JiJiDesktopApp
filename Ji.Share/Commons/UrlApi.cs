using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Commons
{
    public static class UrlApi
    {
        public static string Url { get; set; }
        public const string Login = "Login";
        #region System API
        public const string ListSystemMenu = "api/System/ListSystemMenu";
        public const string ListFloor = "api/System/ListFloor";
        public const string InitCashier = "api/System/InitCashier";
        public const string SetDefaultDLL = "api/System/SetDefaultDLL";
        public const string GetConfigureStore = "api/System/GetConfigureStore";
        public const string DeleteFloor = "api/System/DeleteFloor";
        public const string ModifyFloor = "api/System/ModifyFloor";
        public const string AddFloor = "api/System/AddFloor";
        #endregion
        #region Product API
        public const string ListMilkTea = "api/Product/ListMilkTea";
        public const string ListTopping = "api/Product/ListTopping";
        public const string ListCategory = "api/Product/ListCategory";
        public const string ListMenu = "api/Product/ListMenu";
        #endregion
        #region Customer API
        public const string AddCustomer = "api/Customer/AddCustomer";
        public const string GetCustomer = "api/Customer/GetCustomer";
        public const string ListCustomer = "api/Customer/ListCustomer";
        #endregion
        #region Order API
        public const string ListOrder = "api/Order/ListOrder";
        public const string CancelOrder = "api/Order/CancelOrder";
        public const string AddOrderItem = "api/Order/AddOrderItem";
        public const string CalculationTotalMoneyOrder = "api/Order/CalculationTotalMoneyOrder";
        public const string ListOrderDetail = "api/Order/ListOrderDetail";
        public const string RemoveOrderItems = "api/Order/RemoveOrderItems";
        public const string Checkout = "api/Order/Checkout";
        #endregion
        #region Revenue API
        public const string InitRevenue = "api/Revenue/InitRevenue";
        public const string RevenueDistance = "api/Revenue/RevenueDistance";
        public const string RevenueDetail = "api/Revenue/RevenueDetail";
        public const string ReprintRevenue = "api/Revenue/ReprintRevenue";
        #endregion
        #region Staff API
        public static string ListStaff = "api/Staff/ListStaff";
        public static string CreateStaff = "api/Staff/CreateStaff";
        public static string ModifyStaff = "api/Staff/ModifyStaff";
        public static string GetUserPermissionId = "api/Staff/GetUserPermissionId";
        #endregion
        #region Recipe API
        public static string ListRecipe = "api/Recipe/ListRecipe";
        public static string ListResourceRecipe = "api/Recipe/ListResourceRecipe";     
        #endregion
        #region Pay API
        public static string ListPay = "api/Pay/ListPay";
        public static string AddPay = "api/Pay/AddPay";
        #endregion
        public static string BackEnd = "api/Deployment/BackEnd";
        public static string FrontEnd = "api/Deployment/FrontEnd";
        public static string Database = "api/Deployment/Database";
        public static string TokenType = "Bearer ";
    }
}
