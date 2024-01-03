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
        public IEnumerable<Floor> ListFloor { get; set; }
        public IEnumerable<Food> ListMilkTea { get; set; }
        public IEnumerable<ToppingCustom> ListTopping { get; set; }
        public IEnumerable<Orders> ListOrder { get; set; }
        public IEnumerable<Ji_GetDetailBillResult> ListOrderDetail { get; set; }

    }
}
