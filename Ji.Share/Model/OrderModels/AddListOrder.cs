using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.OrderModels
{
    public class AddListOrder
    {
        [Range(1, int.MaxValue, ErrorMessage = "Giá trị của tầng (Floor) phải lớn hơn 1")]
        public int Floor { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Giá trị của bàn (Table) phải lớn hơn 1")]
        public int Table { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Giá trị của số lượng (Quantity) phải lớn hơn 1")]
        public int Quantity { get; set; }
        public string Query { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Giá trị của mã thực phẩm (FoodID) phải lớn hơn 1")]
        public int FoodID { get; set; }
        public List<int> ListTopping { get; set; }

    }
}
