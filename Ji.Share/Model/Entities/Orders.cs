using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime CreateOn { get; set; }
        public int Table { get; set; }
        public int AffectFloor { get; set; }
        public string FacId { get; set; }
        public string Note { get; set; }
    }
}
