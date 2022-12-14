using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZH3_CH4CMP.Models;

public partial class context : DbContext
{
    public context()
    {
    }

    public context(DbContextOptions<context> options)
        : base(options)
    {
    }

    public virtual DbSet<CarData> CarData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ch4cmp3zh.database.windows.net;Initial Catalog=car_dbo;Persist Security Info=True;User ID=kristof.biro@stud.uni-corvinus.hu;Password=Lovag2002;Authentication=Active Directory Password");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarData>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PK__car_data__4C9A0DB3076D7BB8");

            entity.ToTable("car_data");

            entity.Property(e => e.CarId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("car_id");
            entity.Property(e => e.CarDate)
                .HasColumnType("date")
                .HasColumnName("car_date");
            entity.Property(e => e.CarMake)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("car_make");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
