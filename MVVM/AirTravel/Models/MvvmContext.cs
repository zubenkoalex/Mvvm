using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Mvvm.Models.Entities;

namespace Mvvm.Models;

public partial class MvvmContext : DbContext
{
    public MvvmContext()
    {
    }

    public MvvmContext(DbContextOptions<MvvmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CarEntity> CarEntities { get; set; }

    public virtual DbSet<GenerationEntity> GenerationEntities { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<MarkEntity> MarkEntities { get; set; }

    public virtual DbSet<ModelEntity> ModelEntities { get; set; }

    public virtual DbSet<PacageEntity> PacageEntities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=zubenkoag;Database=MVVM;User=user1;Password=sa;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true;encrypt=false");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CarEntit__3214EC07EBDBAC32");

            entity.ToTable("CarEntity");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.GenerationId).HasColumnName("GenerationID");
            entity.Property(e => e.MarkId).HasColumnName("MarkID");
            entity.Property(e => e.ModelId).HasColumnName("ModelID");
            entity.Property(e => e.PacageId).HasColumnName("PacageID");
            entity.Property(e => e.Picture).HasMaxLength(255);

            entity.HasOne(d => d.Generation).WithMany(p => p.CarEntities)
                .HasForeignKey(d => d.GenerationId)
                .HasConstraintName("FK__CarEntity__Gener__6D0D32F4");

            entity.HasOne(d => d.Mark).WithMany(p => p.CarEntities)
                .HasForeignKey(d => d.MarkId)
                .HasConstraintName("FK__CarEntity__MarkI__6B24EA82");

            entity.HasOne(d => d.Model).WithMany(p => p.CarEntities)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("FK__CarEntity__Model__6C190EBB");

            entity.HasOne(d => d.Pacage).WithMany(p => p.CarEntities)
                .HasForeignKey(d => d.PacageId)
                .HasConstraintName("FK__CarEntity__Pacag__6E01572D");
        });

        modelBuilder.Entity<GenerationEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Generati__3214EC07D8791B49");

            entity.ToTable("GenerationEntity");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NameGeneration).HasMaxLength(22);
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__logins__3214EC27C4277C0C");

            entity.ToTable("logins");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Logins).HasMaxLength(20);
            entity.Property(e => e.Pass)
                .HasMaxLength(20)
                .HasColumnName("pass");
            entity.Property(e => e.Roles)
                .HasMaxLength(20)
                .HasColumnName("roles");
        });

        modelBuilder.Entity<MarkEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MarkEnti__3214EC0788753415");

            entity.ToTable("MarkEntity");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NameModelCar).HasMaxLength(22);
        });

        modelBuilder.Entity<ModelEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ModelEnt__3214EC07949F7CCA");

            entity.ToTable("ModelEntity");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.НазваниеМодели)
                .IsRequired()
                .HasMaxLength(22)
                .HasColumnName("Название_модели");
        });

        modelBuilder.Entity<PacageEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PacageEn__3214EC07037E7C4B");

            entity.ToTable("PacageEntity");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CallColor).HasMaxLength(20);
            entity.Property(e => e.CallType).HasMaxLength(20);
            entity.Property(e => e.DriveType).HasMaxLength(20);
            entity.Property(e => e.EngineVolume).HasMaxLength(6);
            entity.Property(e => e.FuelType).HasMaxLength(20);
            entity.Property(e => e.Kpptype)
                .HasMaxLength(20)
                .HasColumnName("KPPType");
            entity.Property(e => e.NamePacage).HasMaxLength(20);
            entity.Property(e => e.Rudder).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
