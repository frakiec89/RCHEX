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
    
    public partial class Materials
    {
       
        public int Id { get; set; }
        public int Id_MaterialType { get; set; }
        public int Id_MaterialColor { get; set; }
        public int Id_MaterialStandart { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> MinCount { get; set; }
        public Nullable<int> CountPerPack { get; set; }
        public int Id_MaterialSI { get; set; }
        public string Name { get; set; }
        public string Discriptions { get; set; }
    
        public virtual MaterialColors MaterialColors { get; set; }
        public virtual MaterialSI MaterialSI { get; set; }
        public virtual MaterialStandarts MaterialStandarts { get; set; }
        public virtual MaterialTypes MaterialTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipts> Receipts { get; set; }
    }
}
