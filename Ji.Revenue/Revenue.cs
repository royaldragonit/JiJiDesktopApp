using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Revenue
{
  public partial class Revenue
  {
    public int cOrderID { get; set; }
    public string cTotalMoney { get; set; }
    public System.DateTime cCreateOn { get; set; }
    public string cFoodName { get; set; }
    public Nullable<int> cPriceFood { get; set; }
    public string ToppingName { get; set; }
    public Nullable<int> PriceTopping { get; set; }
    public int Quantity { get; set; }
    public int cQuantity { get; set; }
    public string CustomerName { get; set; }
    public int Table { get; set; }
    public int cDiscount { get; set; }
    public int cTotal { get; set; }
    public string cCustomerName { get; set; }
    public string Delivery { get; set; }
  }
}
