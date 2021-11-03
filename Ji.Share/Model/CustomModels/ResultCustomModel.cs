using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.CustomModels
{
    public class ResultCustomModel<T>
    {
        public bool Success { get; set; }
        public Dictionary<string, string> Message { get; set; }
        public T Data { get; set; }
        public int? Code { get; set; }
    }
}
