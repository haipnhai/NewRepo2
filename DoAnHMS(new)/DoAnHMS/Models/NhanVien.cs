//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnHMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.HoaDon = new HashSet<HoaDon>();
            this.PhieuDatPhong = new HashSet<PhieuDatPhong>();
            this.PhieuThuePhong = new HashSet<PhieuThuePhong>();
            this.QuanTri = new HashSet<QuanTri>();
        }
    
        public string maNV { get; set; }
        public string tenNV { get; set; }
        public bool gioiTinh { get; set; }
        public System.DateTime ngaySinh { get; set; }
        public string diaChi { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }
        public string hinhAnh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDatPhong> PhieuDatPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuThuePhong> PhieuThuePhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuanTri> QuanTri { get; set; }
    }
}
