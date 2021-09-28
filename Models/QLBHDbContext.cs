using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLBH.Models
{
    public partial class QLBHDbContext : DbContext
    {
        public QLBHDbContext()
            : base("name=QLBHDbContext")
        {
        }

        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Id)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
               .Property(e => e.Id)
               .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.TenStudent)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
