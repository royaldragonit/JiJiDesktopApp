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
        public const  string Login = "Login";
        public const  string ListSystemMenu = "api/System/ListSystemMenu";
        public const  string ListFloor = "api/System/ListFloor";
        public const  string InitCashier = "api/System/InitCashier";
        public const  string ListMilkTea = "api/Product/ListMilkTea";
        public const  string ListOrder = "api/Order/ListOrder";
        public const  string CalculationTotalMoneyOrder = "api/Order/CalculationTotalMoneyOrder";
        public const  string ListOrderDetail = "api/Order/ListOrderDetail";
        public const  string ListTopping = "api/Product/ListTopping";
        public static string BackEnd = "api/Deployment/BackEnd";
        public static string FrontEnd = "api/Deployment/FrontEnd";
        public static string Database = "api/Deployment/Database";
        public static string TokenType = "Bearer ";
    }
}
