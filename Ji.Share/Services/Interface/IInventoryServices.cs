using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Model.InventoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services.Interface
{
    public interface IInventoryServices
    {
        List<Resource> ListResources();
        HistoryImportResource LastImport(int resourceID);
        bool AddResourceToInventory(AddResourceInput input);
        ResultCustomModel<bool> AddResource(Resource resource);
        IEnumerable<Resource> GetResources();
    }
}
