using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLBS.Models
{
    public partial class QLBSDbContext : DbContext
    {
        public QLBSDbContext()
            : base("name=QLBSDbContext")
        {
        }

        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }

        public virtual DbSet<Nhaxuatban> Nhaxuatbans { get; set; }

        public virtual DbSet<Tacgia> Tacgias { get; set; }

        public virtual DbSet<Chude> Chudes { get; set; }

        public virtual DbSet<Donhang> Donhangs { get; set; }

        public virtual DbSet<Chitietdonhang> Chitietdonhangs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sach>()
                .Property(e => e.masach)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.tensach)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
               .Property(e => e.mota)
               .IsUnicode(false);

            modelBuilder.Entity<Sach>()
               .Property(e => e.soluongton)
               .IsUnicode(false);

            modelBuilder.Entity<Sach>()
               .Property(e => e.manxb)
               .IsUnicode(false);

            modelBuilder.Entity<Sach>()
               .Property(e => e.machude)
               .IsUnicode(false);

            modelBuilder.Entity<Khachhang>()
              .Property(e => e.makh)
              .IsUnicode(false);

            modelBuilder.Entity<Khachhang>()
              .Property(e => e.tenkh)
              .IsUnicode(false);

            modelBuilder.Entity<Khachhang>()
              .Property(e => e.taikhoan)
              .IsUnicode(false);

            modelBuilder.Entity<Khachhang>()
              .Property(e => e.matkhau)
              .IsUnicode(false);

            modelBuilder.Entity<Khachhang>()
              .Property(e => e.email)
              .IsUnicode(false);

            modelBuilder.Entity<Khachhang>()
              .Property(e => e.diachi)
              .IsUnicode(false);

            modelBuilder.Entity<Khachhang>()
              .Property(e => e.dienthoai)
              .IsUnicode(false);


            modelBuilder.Entity<Nhaxuatban>()
              .Property(e => e.manxb)
              .IsUnicode(false);

            modelBuilder.Entity<Nhaxuatban>()
              .Property(e => e.tennxb)
              .IsUnicode(false);

            modelBuilder.Entity<Nhaxuatban>()
              .Property(e => e.dienthoai)
              .IsUnicode(false);

            modelBuilder.Entity<Nhaxuatban>()
              .Property(e => e.diachi)
              .IsUnicode(false);

            modelBuilder.Entity<Tacgia>()
             .Property(e => e.matacgia)
             .IsUnicode(false);

            modelBuilder.Entity<Tacgia>()
             .Property(e => e.tentacgia)
             .IsUnicode(false);

            modelBuilder.Entity<Tacgia>()
             .Property(e => e.diachi)
             .IsUnicode(false);

            modelBuilder.Entity<Tacgia>()
             .Property(e => e.dienthoai)
             .IsUnicode(false);

            modelBuilder.Entity<Chude>()
            .Property(e => e.machude)
            .IsUnicode(false);

            modelBuilder.Entity<Chude>()
            .Property(e => e.tenchude)
            .IsUnicode(false);

            modelBuilder.Entity<Donhang>()
            .Property(e => e.madh)
            .IsUnicode(false);

            modelBuilder.Entity<Donhang>()
                        .Property(e => e.tinhtrangdonhang)
                        .IsUnicode(false);

            modelBuilder.Entity<Donhang>()
            .Property(e => e.ngaydat)
            .IsUnicode(false);

            modelBuilder.Entity<Donhang>()
            .Property(e => e.ngaygiao)
            .IsUnicode(false);

            modelBuilder.Entity<Chitietdonhang>()
           .Property(e => e.soluong)
           .IsUnicode(false);

            modelBuilder.Entity<Chitietdonhang>()
           .Property(e => e.dongia)
           .IsUnicode(false);
        }
    }
    }

