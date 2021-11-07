using Ji.Model.CustomModels;
using Ji.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services.Interface
{
    public interface ICustomerServices
    {
        ResultCustomModel<int> AddCustomer(LCustomer customer);
        LCustomer GetCustomer(string phone);
        List<LCustomer> ListCustomer();
    }
}
