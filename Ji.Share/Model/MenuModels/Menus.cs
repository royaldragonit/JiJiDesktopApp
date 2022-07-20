using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.MenuModels
{
    public class Menus
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public int SaleOff { get; set; }
        public string Unit { get; set; }
        public string cCategory { get; set; }
        public int CategoryID { get; set; }
        public int CreateBy { get; set; }
        public bool Active { get; set; }

        public string FileName { get; set; }
    }
}
