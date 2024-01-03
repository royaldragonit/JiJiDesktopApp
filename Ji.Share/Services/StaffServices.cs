using Ji.Commons;
using Ji.Core;
using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Model.StaffModels;
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
        public ResultCustomModel<bool> CreateStaff(StaffInput staff)
        {
            var data = API.Post<ResultCustomModel<bool>>(UrlApi.CreateStaff,staff);
            return data;
        }
        public ResultCustomModel<bool> ModifyStaff(StaffInput staff)
        {
            var data = API.Post<ResultCustomModel<bool>>(UrlApi.ModifyStaff, staff);
            return data;
        }

        public List<int> GetUserPermissionId(int userID)
        {
            var data = API.Get<ResultCustomModel<List<int>>>(UrlApi.GetUserPermissionId+ "?userID="+ userID);
            return data.Data;
        }

        public List<User> ListStaff()
        {
            var data = API.Get<ResultCustomModel<List<User>>>(UrlApi.ListStaff);
            return data.Data;
        }
    }
}
