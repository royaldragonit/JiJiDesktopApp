using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model
{
    public class Formula
    {
        public Guid CongThucID { get; set; }
        public int? CategoryID { get; set; }
        public string ThanhPhan { get; set; }
        public string CongThuc { get; set; }
        public int? Createdby { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string FoodName { get; set; }
        public string FacID { get; set; }
        public string Unit { get; set; }
        public int? Price { get; set; }
        public int? PriceInput { get; set; }
    }
}
