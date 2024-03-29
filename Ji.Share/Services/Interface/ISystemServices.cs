﻿using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Model.OrderModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services.Interface
{
    public interface ISystemServices
    {
        List<ji_GetApplicationResult> ListSystemMenu();
        List<Floor> ListFloor();
        InitCashierModel InitCashier(OrderDetailRequest orderDetailRequest);
        bool SetDefaultDLL(string dll, string className);
        SetupShop GetConfigureStore();
        bool ConfigureStore(SetupShop setup);
        bool DeleteFloor(int floorId);
        bool ModifyFloor(string floorName,int table,int floorId);
        ResultCustomModel<int> AddFloor(string floorName, int table);
    }
}
