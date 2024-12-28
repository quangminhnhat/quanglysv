namespace QuanLySinhVien.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [StringLength(100)]
        public string TEN { get; set; }

        [Required]
        [StringLength(50)]
        public string MK { get; set; }

        [StringLength(10)]
        public string MaTK { get; set; }

        public virtual LOAITTAIKHOAN LOAITTAIKHOAN { get; set; }
    }
}
