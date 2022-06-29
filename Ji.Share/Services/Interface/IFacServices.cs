using Ji.Model.CustomModels;
using Ji.Model.FacModels;
using Ji.Model.LoginModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services.Interface
{
    public interface IFacServices
    {
        ResultCustomModel<LoginRequest> Register(RegisterFacility facility);
        ResultCustomModel<bool> ListFacility();
    }
}
