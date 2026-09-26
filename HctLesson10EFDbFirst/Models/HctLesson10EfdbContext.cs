using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HctLesson10EFDbFirst.Models;

public partial class HctLesson10EfdbContext : DbContext
{
    public HctLesson10EfdbContext()
    {
    }

    public HctLesson10EfdbContext(DbContextOptions<HctLesson10EfdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HctMember> HctMembers { get; set; }

    // Chuỗi kết nối được đọc từ appsettings.json và đăng ký tại Program.cs.

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HctMember>(entity =>
        {
            entity.ToTable("HctMember");

            entity.Property(e => e.HctEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HctFullName).HasMaxLength(50);
            entity.Property(e => e.HctPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HctPhone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HctUserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
