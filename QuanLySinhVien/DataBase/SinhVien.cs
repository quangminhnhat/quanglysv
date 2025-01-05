namespace QuanLySinhVien.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [StringLength(10)]
        public string MaSinhVien { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(12)]
        public string sdt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(100)]
        public string TenLop { get; set; }

        [StringLength(10)]
        public string MaKhoa { get; set; }

        public int? DiemQT { get; set; }

        public int? DiemTK { get; set; }

        public virtual Khoa Khoa { get; set; }
    }
}
