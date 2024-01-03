using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Model.StaffModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services.Interface
{
    public interface IStaffServices
    {
        List<User> ListStaff();
        List<int> GetUserPermissionId(int userID);
        ResultCustomModel<bool> CreateStaff(StaffInput staff);
        ResultCustomModel<bool> ModifyStaff(StaffInput staff);
    }
}
