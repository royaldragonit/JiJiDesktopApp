using Ji.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services.Interface
{
    public interface IPayServices
    {
        List<Pay> ListPay(DateTime now1, DateTime now2);
        bool AddPay(Pay p);
    }
}
