//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLPH
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ChitietHoadons = new HashSet<ChitietHoadon>();
            this.LichsuXuatNhapkhoes = new HashSet<LichsuXuatNhapkho>();
        }
    
        public int ID { get; set; }
        public string TenHang { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string Donvi { get; set; }
        public Nullable<int> Dongia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChitietHoadon> ChitietHoadons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichsuXuatNhapkho> LichsuXuatNhapkhoes { get; set; }
    }
}
