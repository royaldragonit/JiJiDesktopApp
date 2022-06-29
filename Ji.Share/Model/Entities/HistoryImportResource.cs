using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public class HistoryImportResource
    {
        public int ID { get; set; }
        public int ResourceID { get; set; }
        public int PriceOld { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime? CreateBy { get; set; }
        public int FacId { get; set; }
    }
}
