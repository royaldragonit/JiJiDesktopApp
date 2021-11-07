using Ji.Commons;
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
    public class StaffServices : IStaffServices
    {
        public List<int> GetUserPermissionId(int userID)
        {
            var data = API.Get<ResultCustomModel<List<int>>>(UrlApi.GetUserPermissionId+ "?userID="+ userID);
            return data.Data;
        }

        public List<LUsers> ListStaff()
        {
            var data = API.Get<ResultCustomModel<List<LUsers>>>(UrlApi.ListStaff);
            return data.Data;
        }
    }
}
