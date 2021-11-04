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
        #endregion
        #region Product API
        public const string ListMilkTea = "api/Product/ListMilkTea";
        public const string ListTopping = "api/Product/ListTopping";
        #endregion
        #region Customer API
        public const string AddCustomer = "api/Customer/AddCustomer";
        public const string GetCustomer = "api/Customer/GetCustomer";
        #endregion
        #region Order API
        public const string ListOrder = "api/Order/ListOrder";
        public const string CalculationTotalMoneyOrder = "api/Order/CalculationTotalMoneyOrder";
        public const string ListOrderDetail = "api/Order/ListOrderDetail";
        #endregion
        public static string BackEnd = "api/Deployment/BackEnd";
        public static string FrontEnd = "api/Deployment/FrontEnd";
        public static string Database = "api/Deployment/Database";
        public static string TokenType = "Bearer ";
    }
}
