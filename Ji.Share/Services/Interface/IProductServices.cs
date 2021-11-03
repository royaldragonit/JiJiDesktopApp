using Ji.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services.Interface
{
    public interface IProductServices
    {
        List<Ji_GetAllMilkTeaOrderResult> ListMilkTea();
        List<LTopping> ListTopping();
    }
}
