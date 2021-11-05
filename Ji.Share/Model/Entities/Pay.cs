using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public class Pay
    {
        public int Id { get; set; }
        public string Reason { get; set; }
        public DateTime Time { get; set; }
        public string CreateBy { get; set; }
        public int Money { get; set; }
        public string FacId { get; set; }
        public string CTypePay { get; set; }
    }
}
