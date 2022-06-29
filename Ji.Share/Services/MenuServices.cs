using Ji.Commons;
using Ji.Core;
using Ji.Model;
using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Model.LoginModels;
using Ji.Model.OrderModels;
using Ji.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services
{
    public class MenuServices : IMenuServices
    {
        public bool AddMenu(Menus menus)
        {
            var data = API.Post<bool>(UrlApi.AddMenu, menus);
            return data;
        }

        public bool SetActiveMenu(int foodId)
        {
            var data = API.Get<bool>(UrlApi.SetActiveMenu + "?foodId=" + foodId);
            return data;
        }

        public bool UpdateMenu(Menus menus)
        {
            var data = API.Post<bool>(UrlApi.UpdateMenu ,menus);
            return data;
        }
    }
    public interface IMenuServices
    {
        bool SetActiveMenu(int foodId);
        bool AddMenu(Menus menus);
        bool UpdateMenu(Menus menus);
    }
}
