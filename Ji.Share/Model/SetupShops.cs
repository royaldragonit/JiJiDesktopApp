using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model
{
  public class SetupShops
  {
    public int ID { get; set; }
    public string ShopName { get; set; }
    public string Slogan { get; set; }
    public string Bye1 { get; set; }
    public string Bye2 { get; set; }
    public int NumberPrintBill { get; set; }
    public string Logo { get; set; }
    public string DefaultPrinter { get; set; }
    public string FacID { get; set; }
    public string FaceBook { get; set; }
    public string Address { get; set; }
    public string Hotline { get; set; }
    public string Abbreviation { get; set; }
    public bool ShowBarCode { get; set; }
    public bool WarningCheckout { get; set; }
    public bool Active { get; set; }
    public DateTime Lisence { get; set; }

  }
}
