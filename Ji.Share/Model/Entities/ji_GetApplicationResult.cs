using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public class ji_GetApplicationResult
    {
        public int? ID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string DLL { get; set; }
        public string ClassName { get; set; }
        public string Image { get; set; }
        public string CategoryNonUnicode { get; set; }
        public string NameNonUnicode { get; set; }
        public bool DefaultDLL { get; set; }
        public bool? PermissionBasic { get; set; }
    }
}
