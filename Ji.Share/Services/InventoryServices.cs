using Ji.Commons;
using Ji.Core;
using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Model.InventoryModels;
using Ji.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services
{
    public class InventoryServices : IInventoryServices
    {
        public bool AddResourceToInventory(AddResourceInput input)
        {
            var data = API.Post<ResultCustomModel<bool>>(UrlApi.AddResourceToInventory, input);
            return data.Data;
        }

        public HistoryImportResource LastImport(int resourceID)
        {
            var data = API.Get<ResultCustomModel<HistoryImportResource>>(UrlApi.LastImport);
            return data.Data;
        }

        public List<Resource> ListResources()
        {
            var data = API.Get<ResultCustomModel<List<Resource>>>(UrlApi.ListResources);
            return data.Data;
        }

        public ResultCustomModel<bool> AddResource(Resource resource)
        {
            var data = API.Post<ResultCustomModel<bool>>(UrlApi.AddResource,resource);
            return data;
        }

        public IEnumerable<Resource> GetResources()
        {
            var data = API.Get<IEnumerable<Resource>>(UrlApi.GetResources);
            return data;
        }
    }
}
