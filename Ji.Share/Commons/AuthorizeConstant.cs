using Ji.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Commons
{
    public static class AuthorizeConstant
    {
        public static User Users { get; set; }
        public static Bhxh BHXH { get; set; }
        public static Supporter Supporter { get; set; }
        public static string Token { get; set; } = "";
    }
}
