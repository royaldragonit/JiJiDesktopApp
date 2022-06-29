using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.CustomerModels
{
    public class MessageResponse
    {
        public int CustomerId { get; set; }
        public int SupporterId { get; set; }
        public string Message { get; set; }
        public bool SupporterSend { get; set; }
        public string SupporterName { get; set; }
    }
}
