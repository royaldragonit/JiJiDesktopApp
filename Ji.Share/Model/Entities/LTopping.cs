using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public  class LTopping
    {

        public int Id { get; set; }
        public string ToppingName { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateOn { get; set; }
        public bool? Active { get; set; }
        public int PriceInput { get; set; }
        public int FacId { get; set; }
    }
}
