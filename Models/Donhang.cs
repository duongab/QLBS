//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Donhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donhang()
        {
            this.Chitietdonhangs = new HashSet<Chitietdonhang>();
        }
    
        public string madh { get; set; }
        public string tinhtrangdonhang { get; set; }
        public string ngaydat { get; set; }
        public string ngaygiao { get; set; }
        public string makh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; }
        public virtual Khachhang Khachhang { get; set; }
    }
}
