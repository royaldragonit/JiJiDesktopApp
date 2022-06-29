using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.CustomerModels
{
    public class Material
    {
        public int cCategoryID { get; set; }
        public int cFoodID { get; set; }
        public int cIndex { get; set; }
        public string cFoodName { get; set; }
        public string cImage { get; set; }
        public string cPrice { get; set; }
        public string Unit { get; set; }
        public int cSaleOff { get; set; }
        public string cCategory { get; set; }
        public bool cStatus { get; set; }
        public int FacId { get; set; }
    }
}
