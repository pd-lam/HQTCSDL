//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HQTCSDL.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nhan_Vien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nhan_Vien()
        {
            this.Dang_Nhap = new HashSet<Dang_Nhap>();
            this.Don_Hang = new HashSet<Don_Hang>();
            this.Nhan_Vien1 = new HashSet<Nhan_Vien>();
        }
    
        public int Ma_Nhan_Vien { get; set; }
        public string Ten { get; set; }
        public string Ho { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public byte Trang_Thai_HD { get; set; }
        public int Ma_Cua_Hang { get; set; }
        public Nullable<int> Ma_Nguoi_Quan_Ly { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dang_Nhap> Dang_Nhap { get; set; }
        public virtual Cua_Hang Cua_Hang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Don_Hang> Don_Hang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nhan_Vien> Nhan_Vien1 { get; set; }
        public virtual Nhan_Vien Nhan_Vien2 { get; set; }
    }
}