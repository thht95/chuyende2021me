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
    
    public partial class LichsuXuatNhapkho
    {
        public int ID { get; set; }
        public Nullable<int> NhanvienID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string Ghichu { get; set; }
        public Nullable<System.DateTime> Thoigian { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual Product Product { get; set; }
    }
}
