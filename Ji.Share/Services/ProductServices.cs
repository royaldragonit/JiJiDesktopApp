﻿using Ji.Commons;
using Ji.Core;
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
        public List<Ji_GetAllMilkTeaOrderResult> ListMilkTea()
        {
            var data = API.Get<ResultCustomModel<List<Ji_GetAllMilkTeaOrderResult>>>(UrlApi.Url + UrlApi.ListMilkTea);
            return data.Data;
        }

        public List<LTopping> ListTopping()
        {
            var data = API.Get<ResultCustomModel<List<LTopping>>>(UrlApi.Url + UrlApi.ListTopping);
            return data.Data;
        }
    }
}