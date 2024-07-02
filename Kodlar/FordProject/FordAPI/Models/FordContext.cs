using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FordAPI.Models
{
    public partial class FordContext : DbContext
    {
        public FordContext()
        {
        }

        public FordContext(DbContextOptions<FordContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Araba> Arabas { get; set; } = null!;
        public virtual DbSet<Destek> Desteks { get; set; } = null!;
        public virtual DbSet<Servi> Servis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-V4PRQL1\\SQLEXPRESS;Initial Catalog=Ford;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False\n");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Araba>(entity =>
            {
                entity.ToTable("Araba");

                entity.Property(e => e.ArabaModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Destek>(entity =>
            {
                entity.HasKey(e => e.MusteriId);

                entity.ToTable("Destek");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Araba)
                    .WithMany(p => p.Desteks)
                    .HasForeignKey(d => d.ArabaId)
                    .HasConstraintName("FK_Destek_Araba");
            });

            modelBuilder.Entity<Servi>(entity =>
            {
                entity.HasKey(e => e.MusteriId);

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Araba)
                    .WithMany(p => p.Servis)
                    .HasForeignKey(d => d.ArabaId)
                    .HasConstraintName("FK_Servis_Araba");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
