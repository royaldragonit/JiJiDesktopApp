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
    
    public partial class L_HistoryPoached
    {
        public int ID { get; set; }
        public int PoachedID { get; set; }
        public int UserID { get; set; }
        public int PriceIn { get; set; }
        public int PriceSell { get; set; }
        public int Income { get; set; }
        public int CreateBy { get; set; }
        public string Type { get; set; }
        public System.DateTime CreateOn { get; set; }
    
        public virtual L_Poached L_Poached { get; set; }
        public virtual L_Users L_Users { get; set; }
    }
}
