using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.OrderModels
{
    public class OrderDetailRequest
    {
        public int Table { get; set; }
        public int Floor { get; set; } = 1;
    }
}
