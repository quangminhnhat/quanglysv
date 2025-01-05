namespace QuanLySinhVien.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAITTAIKHOAN")]
    public partial class LOAITTAIKHOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAITTAIKHOAN()
        {
            TAIKHOANs = new HashSet<TAIKHOAN>();
        }

        [Key]
        [StringLength(10)]
        public string MaTK { get; set; }

        [Required]
        [StringLength(100)]
        public string TenTK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOAN> TAIKHOANs { get; set; }
    }
}
