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
    //"index":1,"id":4,"foodName":"B�nh tr�ng","price":12000
    public class Food
    {
        public int Index { get; set; }
        public int ID { get; set; }
        public string FoodName { get; set; }
        public int Price { get; set; }
    }
    public partial class L_Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public L_Food()
        {
            this.BillFood = new HashSet<BillFood>();
            this.HistoryDeleteItemOrder = new HashSet<HistoryDeleteItemOrder>();
            this.OrdersFood = new HashSet<OrdersFood>();
        }
    
        public int ID { get; set; }
        public int Price { get; set; }
        public int Index { get; set; }
        public string FoodName { get; set; }
        public int FacID { get; set; }
        public string Unit { get; set; }
        public string Image { get; set; }
        public int SaleOff { get; set; }
        public int CreateBy { get; set; }
        public System.DateTime CreateOn { get; set; }
        public bool Active { get; set; }
        public int PriceInput { get; set; }
        public Nullable<int> CategoryID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillFood> BillFood { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryDeleteItemOrder> HistoryDeleteItemOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersFood> OrdersFood { get; set; }
        public virtual Category Category { get; set; }
    }
}
