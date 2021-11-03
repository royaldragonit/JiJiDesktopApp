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
        public static string BackEnd = "api/Deployment/BackEnd";
        public static string FrontEnd = "api/Deployment/FrontEnd";
        public static string Database = "api/Deployment/Database";
        public static string TokenType = "Bearer ";
    }
}
