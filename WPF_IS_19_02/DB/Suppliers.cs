//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_IS_19_02.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Suppliers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Suppliers()
        {
            this.Receipts = new HashSet<Receipts>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Id_SupplierType { get; set; }
        public string INN { get; set; }
        public Nullable<int> RatingNumber { get; set; }
        public string DateStartWork { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipts> Receipts { get; set; }
        public virtual SupplierTypes SupplierTypes { get; set; }
    }
}
