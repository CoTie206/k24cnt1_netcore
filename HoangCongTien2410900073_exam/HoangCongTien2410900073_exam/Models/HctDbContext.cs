using Microsoft.EntityFrameworkCore;

namespace HoangCongTien2410900073_exam.Models
{
    public class HctDbContext : DbContext
    {
        public HctDbContext(DbContextOptions<HctDbContext> options)
            : base(options)
        {
        }

        public DbSet<HctStudent> HctStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HctStudent>(entity =>
            {
                entity.ToTable("HctStudent");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.HctName)
                    .HasMaxLength(100);

                entity.Property(e => e.HctBirthDay)
                    .HasColumnType("date");

                entity.Property(e => e.HctEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HctPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });
        }
    }
}