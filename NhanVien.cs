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
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.Hoadons = new HashSet<Hoadon>();
            this.LichsuXuatNhapkhoes = new HashSet<LichsuXuatNhapkho>();
            this.TimeLogins = new HashSet<TimeLogin>();
        }
    
        public int ID { get; set; }
        public string HoTen { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string SDT { get; set; }
        public string Diachi { get; set; }
        public Nullable<bool> Trangthai { get; set; }
        public Nullable<bool> IsAdmin { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<System.DateTime> LastLoginAt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hoadon> Hoadons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichsuXuatNhapkho> LichsuXuatNhapkhoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeLogin> TimeLogins { get; set; }
    }
}
