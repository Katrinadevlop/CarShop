using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CarShopWpf.Models;

public partial class CarShopWpfContext : DbContext
{
    public CarShopWpfContext()
    {
    }

    public CarShopWpfContext(DbContextOptions<CarShopWpfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Basket> Baskets { get; set; }

    public virtual DbSet<Registration> Registrations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=C:\\\\\\\\SQLite\\\\\\\\CarShopWpf.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Basket>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Registration>(entity =>
        {
            entity.HasKey(e => e.IdPerson);

            entity.HasIndex(e => e.IdPerson, "IX_Registrations_id_person").IsUnique();

            entity.Property(e => e.IdPerson).HasColumnName("id_person");
            entity.Property(e => e.Avatar).HasColumnName("avatar");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.NumberProne).HasColumnName("number_prone");
            entity.Property(e => e.Password)
                .IsRequired()
                .HasColumnName("password");
            entity.Property(e => e.Patronymic)
                .HasColumnType("NUMERIC")
                .HasColumnName("patronymic");
            entity.Property(e => e.Surname).HasColumnName("surname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
