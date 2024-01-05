using Ji.Model.CustomerModels;
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
        ResultCustomModel<int> AddCustomer(Customer customer);
        Customer GetCustomer(string phone);
        List<Customer> ListCustomer();
        List<Supporter> ListSupporter();
        List<MessageResponse> GetMessenger(int customerId,int supporterId);
    }
}
