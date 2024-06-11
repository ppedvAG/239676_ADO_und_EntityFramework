using System;
using System.Collections.Generic;
using EfCoreDbFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreDbFirst.Data;

public partial class HalloEfCoreContext : DbContext
{
    public HalloEfCoreContext()
    {
    }

    public HalloEfCoreContext(DbContextOptions<HalloEfCoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Abteilungen> Abteilungens { get; set; }

    public virtual DbSet<Kunden> Kundens { get; set; }

    public virtual DbSet<Mitarbeiter> Mitarbeiters { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HalloEfCore;Trusted_Connection=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Abteilungen>(entity =>
        {
            entity.ToTable("Abteilungen");

            entity.HasMany(d => d.Mitarbeiters).WithMany(p => p.Abteilungens)
                .UsingEntity<Dictionary<string, object>>(
                    "AbteilungMitarbeiter",
                    r => r.HasOne<Mitarbeiter>().WithMany().HasForeignKey("MitarbeiterId"),
                    l => l.HasOne<Abteilungen>().WithMany().HasForeignKey("AbteilungenId"),
                    j =>
                    {
                        j.HasKey("AbteilungenId", "MitarbeiterId");
                        j.ToTable("AbteilungMitarbeiter");
                        j.HasIndex(new[] { "MitarbeiterId" }, "IX_AbteilungMitarbeiter_MitarbeiterId");
                    });
        });

        modelBuilder.Entity<Kunden>(entity =>
        {
            entity.ToTable("Kunden");

            entity.HasIndex(e => e.AnsprechpartnerId, "IX_Kunden_AnsprechpartnerId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Aaaa).HasColumnName("aaaa");
            entity.Property(e => e.KundenNummer).HasMaxLength(12);

            entity.HasOne(d => d.Ansprechpartner).WithMany(p => p.Kundens).HasForeignKey(d => d.AnsprechpartnerId);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Kunden).HasForeignKey<Kunden>(d => d.Id);
        });

        modelBuilder.Entity<Mitarbeiter>(entity =>
        {
            entity.ToTable("Mitarbeiter");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Mitarbeiter).HasForeignKey<Mitarbeiter>(d => d.Id);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.Property(e => e.DerName).HasMaxLength(99);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
