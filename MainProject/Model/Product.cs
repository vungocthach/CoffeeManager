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
    
    public partial class PRODUCT : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            this.DETAILBILLs = new  ObservableCollection<DETAILBILL>();
            this.DETAILREPORTSALES = new  ObservableCollection<DETAILREPORTSALE>();
        }
    
        public long ID { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public byte[] Image { get; set; }
        public long Price { get; set; }
        public Nullable<long> ID_Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<DETAILBILL> DETAILBILLs { get; set; }
        public virtual TYPE_PRODUCT TYPE_PRODUCT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<DETAILREPORTSALE> DETAILREPORTSALES { get; set; }
    }
}
