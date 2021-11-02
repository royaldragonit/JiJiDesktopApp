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
    
    public partial class Bills
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bills()
        {
            this.BillFood = new HashSet<BillFood>();
            this.BillDetail = new HashSet<BillDetail>();
        }
    
        public int ID { get; set; }
        public int TotalMoney { get; set; }
        public System.DateTime CreateOn { get; set; }
        public bool IsActive { get; set; }
        public int Discount { get; set; }
        public int CreateBy { get; set; }
        public int Table { get; set; }
        public int AffectFloor { get; set; }
        public System.DateTime DischargOn { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillFood> BillFood { get; set; }
        public virtual L_Users L_Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetail { get; set; }
    }
}
