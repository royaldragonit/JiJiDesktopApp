//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ji
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdersFood
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int FoodID { get; set; }
        public int Quantity { get; set; }
        public string Topping { get; set; }
        public Nullable<int> ToppingID { get; set; }
    
        public virtual L_Food L_Food { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
