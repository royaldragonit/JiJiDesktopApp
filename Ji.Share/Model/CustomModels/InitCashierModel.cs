using Ji.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.CustomModels
{
    public class InitCashierModel
    {
        public List<LFloor> ListFloor { get; set; }
        public List<Ji_GetAllMilkTeaOrderResult> ListMilkTea { get; set; }
        public List<LTopping> ListTopping { get; set; }
        public List<Orders> ListOrder { get; set; }
        public List<Ji_GetDetailBillResult> ListOrderDetail { get; set; }

    }
}
