using Ji.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Commons
{
    public static class Configure
    {
        public static SetupShop Setup { get; set; }
        public static List<LFloor> SetupFloor { get; set; }
        public static List<ji_GetApplicationResult> ListSystemMenu { get; set; }
    }
}
