using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public class Floor
    {
        public string Name { get; set; }
        public int CountFloor { get; set; }
        public int? CountTable { get; set; }
        public int Affect { get; set; }
        public bool? Active { get; set; }
        public int Id { get; set; }
        public int FacId { get; set; }
    }
}
