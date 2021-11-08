using Ji.Commons;
using Ji.Core;
using Ji.Model.CustomerModels;
using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services
{
    public class ProductServices : IProductServices
    {
        public List<Material> ListMenu()
        {
            var data = API.Get<ResultCustomModel<List<Material>>>(UrlApi.ListMenu);
            return data.Data;
        }
        public List<Material> ListCategory()
        {
            var data = API.Get<ResultCustomModel<List<Material>>>(UrlApi.ListCategory);
            return data.Data;
        }

        public List<Ji_GetAllMilkTeaOrderResult> ListMilkTea()
        {
            var data = API.Get<ResultCustomModel<List<Ji_GetAllMilkTeaOrderResult>>>(UrlApi.ListMilkTea);
            return data.Data;
        }

        public List<LTopping> ListTopping()
        {
            var data = API.Get<ResultCustomModel<List<LTopping>>>(UrlApi.ListTopping);
            return data.Data;
        }
    }
}
