//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MainProject.Model
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class BILL : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BILL()
        {
            this.DETAILBILLs = new  ObservableCollection<DETAILBILL>();
        }
    
        public long ID { get; set; }
        public long TotalPrice { get; set; }
        public System.DateTime CheckoutDay { get; set; }
        public Nullable<long> ID_Table { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<DETAILBILL> DETAILBILLs { get; set; }
        public virtual TABLE TABLE { get; set; }
    }
}
