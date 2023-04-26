using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MegaCasting2022.DBLib.Class
{
    public partial class MegaCastingSymfonyContext : DbContext
    {
        public MegaCastingSymfonyContext()
        {
        }

        public MegaCastingSymfonyContext(DbContextOptions<MegaCastingSymfonyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Civilite> Civilites { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Conseil> Conseils { get; set; } = null!;
        public virtual DbSet<DoctrineMigrationVersion> DoctrineMigrationVersions { get; set; } = null!;
        public virtual DbSet<DomaineMetier> DomaineMetiers { get; set; } = null!;
        public virtual DbSet<Interview> Interviews { get; set; } = null!;
        public virtual DbSet<Metier> Metiers { get; set; } = null!;
        public virtual DbSet<OffreCasting> OffreCastings { get; set; } = null!;
        public virtual DbSet<Pack> Packs { get; set; } = null!;
        public virtual DbSet<PartenaireDiffusion> PartenaireDiffusions { get; set; } = null!;
        public virtual DbSet<TypeContrat> TypeContrats { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=MegaCastingSymfony;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Civilite>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__Civilite__DD380E4E01EAD5A6");

                entity.ToTable("Civilite");

                entity.Property(e => e.LibelLong).HasMaxLength(255);

                entity.Property(e => e.LibelShort).HasMaxLength(255);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__Client__DD380E4E9D67E92C");

                entity.ToTable("Client");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Login).HasMaxLength(255);

                entity.Property(e => e.Nom).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.Ville).HasMaxLength(255);
            });

            modelBuilder.Entity<Conseil>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__Conseil__DD380E4E157B2F5C");

                entity.ToTable("Conseil");

                entity.Property(e => e.Contenu).HasMaxLength(3000);

                entity.Property(e => e.Libel).HasMaxLength(255);
            });

            modelBuilder.Entity<DoctrineMigrationVersion>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK__doctrine__79B5C94C76A55E6D");

                entity.ToTable("doctrine_migration_versions");

                entity.Property(e => e.Version)
                    .HasMaxLength(191)
                    .HasColumnName("version");

                entity.Property(e => e.ExecutedAt)
                    .HasPrecision(6)
                    .HasColumnName("executed_at");

                entity.Property(e => e.ExecutionTime).HasColumnName("execution_time");
            });

            modelBuilder.Entity<DomaineMetier>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__DomaineM__DD380E4E999C6DDE");

                entity.ToTable("DomaineMetier");

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.Libel).HasMaxLength(255);
            });

            modelBuilder.Entity<Interview>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__Intervie__DD380E4E652293D6");

                entity.ToTable("Interview");

                entity.Property(e => e.Libel).HasMaxLength(255);

                entity.Property(e => e.Url).HasMaxLength(255);
            });

            modelBuilder.Entity<Metier>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__Metier__DD380E4E094284A5");

                entity.ToTable("Metier");

                entity.HasIndex(e => e.IdentifiantDomaineMetier, "IDX_560C08BAE52D612A");

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.Libel).HasMaxLength(255);

                entity.HasOne(d => d.IdentifiantDomaineMetierNavigation)
                    .WithMany(p => p.Metiers)
                    .HasForeignKey(d => d.IdentifiantDomaineMetier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_560C08BAE52D612A");
            });

            modelBuilder.Entity<OffreCasting>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__OffreCas__DD380E4E203ACBC3");

                entity.ToTable("OffreCasting");

                entity.HasIndex(e => e.IdentifiantTypeContrat, "IDX_982EDF9C9251261A");

                entity.HasIndex(e => e.IdentifiantClient, "IDX_982EDF9C93C1B089");

                entity.Property(e => e.Libel).HasMaxLength(255);

                entity.Property(e => e.Localisation).HasMaxLength(255);

                entity.Property(e => e.Nivurgence)
                    .HasMaxLength(255)
                    .HasColumnName("nivurgence");

                entity.Property(e => e.OffreDateEnd).HasPrecision(6);

                entity.Property(e => e.OffreDateStart).HasPrecision(6);

                entity.Property(e => e.ParutionDateTime).HasPrecision(6);

                entity.Property(e => e.Reference).HasMaxLength(3000);

                entity.Property(e => e.Sponso).HasColumnName("sponso");

                entity.HasOne(d => d.IdentifiantClientNavigation)
                    .WithMany(p => p.OffreCastings)
                    .HasForeignKey(d => d.IdentifiantClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_982EDF9C93C1B089");

                entity.HasOne(d => d.IdentifiantTypeContratNavigation)
                    .WithMany(p => p.OffreCastings)
                    .HasForeignKey(d => d.IdentifiantTypeContrat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_982EDF9C9251261A");

                entity.HasMany(d => d.IdentifiantOffreCastings)
                    .WithMany(p => p.IdentifiantCivilites)
                    .UsingEntity<Dictionary<string, object>>(
                        "CiviliteOffreCasting",
                        l => l.HasOne<Civilite>().WithMany().HasForeignKey("IdentifiantOffreCasting").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_5CC7CA8DB196B681"),
                        r => r.HasOne<OffreCasting>().WithMany().HasForeignKey("IdentifiantCivilite").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_5CC7CA8DCDCDB2D5"),
                        j =>
                        {
                            j.HasKey("IdentifiantCivilite", "IdentifiantOffreCasting").HasName("PK__Civilite__0ECB1DAEFBB8978A");

                            j.ToTable("CiviliteOffreCasting");

                            j.HasIndex(new[] { "IdentifiantOffreCasting" }, "IDX_5CC7CA8DB196B681");

                            j.HasIndex(new[] { "IdentifiantCivilite" }, "IDX_5CC7CA8DCDCDB2D5");
                        });

                entity.HasMany(d => d.IdentifiantOffreCastingsNavigation)
                    .WithMany(p => p.IdentifiantMetiers)
                    .UsingEntity<Dictionary<string, object>>(
                        "MetierOffreCasting",
                        l => l.HasOne<Metier>().WithMany().HasForeignKey("IdentifiantOffreCasting").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_A740572EB196B681"),
                        r => r.HasOne<OffreCasting>().WithMany().HasForeignKey("IdentifiantMetier").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_A740572E525B950"),
                        j =>
                        {
                            j.HasKey("IdentifiantMetier", "IdentifiantOffreCasting").HasName("PK__MetierOf__45F38DB504ABBE02");

                            j.ToTable("MetierOffreCasting");

                            j.HasIndex(new[] { "IdentifiantMetier" }, "IDX_A740572E525B950");

                            j.HasIndex(new[] { "IdentifiantOffreCasting" }, "IDX_A740572EB196B681");
                        });
            });

            modelBuilder.Entity<Pack>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__Pack__DD380E4E21F50E1A");

                entity.ToTable("Pack");

                entity.Property(e => e.Libel).HasMaxLength(255);
            });

            modelBuilder.Entity<PartenaireDiffusion>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__Partenai__DD380E4EC3719D87");

                entity.ToTable("PartenaireDiffusion");

                entity.Property(e => e.Login).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);
            });

            modelBuilder.Entity<TypeContrat>(entity =>
            {
                entity.HasKey(e => e.Identifiant)
                    .HasName("PK__TypeCont__DD380E4E12219398");

                entity.ToTable("TypeContrat");

                entity.Property(e => e.Libel).HasMaxLength(255);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.Email, "UNIQ_8D93D649E7927C74")
                    .IsUnique()
                    .HasFilter("([email] IS NOT NULL)");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(180)
                    .HasColumnName("email");

                entity.Property(e => e.IsVerified).HasColumnName("is_verified");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.Numtel)
                    .HasMaxLength(255)
                    .HasColumnName("numtel");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Roles)
                    .IsUnicode(false)
                    .HasColumnName("roles")
                    .HasComment("(DC2Type:json)");

                entity.Property(e => e.Ville)
                    .HasMaxLength(255)
                    .HasColumnName("ville");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
