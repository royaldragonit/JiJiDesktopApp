using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model
{
    public class Pays
    {
        public int ID { get; set; }
        public string Reason { get; set; }
        public DateTime Time { get; set; }
        public string CreateBy { get; set; }
        public int Money { get; set; }
        public string cTypePay { get; set; }
    }
}
