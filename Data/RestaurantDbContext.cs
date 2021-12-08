using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormQuanLyNhaHang.Data.Entities;

namespace WinFormQuanLyNhaHang.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext() : base("name=con") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users").HasKey(e => e.Id);
            modelBuilder.Entity<User>().HasRequired(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId).WillCascadeOnDelete(true);

            modelBuilder.Entity<Role>().ToTable("Roles").HasKey(e => e.Id);

            modelBuilder.Entity<Category>().ToTable("Categories").HasKey(e => e.Id);

            modelBuilder.Entity<Good>().ToTable("Goods").HasKey(e => e.Id);
            modelBuilder.Entity<Good>().HasRequired(g => g.Category).WithMany(c => c.Goods).HasForeignKey(g => g.CategoryId).WillCascadeOnDelete(true);

            modelBuilder.Entity<Table>().ToTable("Tables").HasKey(e => e.Id);

            modelBuilder.Entity<Bill>().ToTable("Bills").HasKey(e => e.Id);
            modelBuilder.Entity<Bill>().HasRequired(b => b.Table).WithMany(t => t.Bills).HasForeignKey(b => b.TableId).WillCascadeOnDelete(true);
            modelBuilder.Entity<Bill>().HasRequired(b => b.User).WithMany(u => u.Bills).HasForeignKey(b => b.UserId).WillCascadeOnDelete(true);

            modelBuilder.Entity<BillDetail>().ToTable("BillDetails").HasKey(e => e.Id);
            modelBuilder.Entity<BillDetail>().HasRequired(bd => bd.Bill).WithMany(b => b.BillDetails).HasForeignKey(bd => bd.BillId).WillCascadeOnDelete(true);
            //modelBuilder.Entity<BillDetail>().HasRequired(bd => bd.Bill).
        }
    }
}
