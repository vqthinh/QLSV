using QLSV.Entities.Models;
using System.Data.Entity;

namespace QLSV.Repositories
{
    // ReSharper disable once InconsistentNaming
    public class QLSVDbContext : DbContext
    {
        public QLSVDbContext() : base("QLSVDbContext")
        {

        }

        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<QLSVDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
