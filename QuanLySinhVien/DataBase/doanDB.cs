using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLySinhVien.DataBase
{
    public partial class doanDB : DbContext
    {
        public doanDB()
            : base("name=doanDB")
        {
        }

        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<LOAITTAIKHOAN> LOAITTAIKHOANs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khoa>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<LOAITTAIKHOAN>()
                .Property(e => e.MaTK)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaSinhVien)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MK)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MaTK)
                .IsUnicode(false);
        }
    }
}
