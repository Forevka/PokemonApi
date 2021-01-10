using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PokemonApi
{
    public partial class PokemonDbContext : DbContext
    {
        public PokemonDbContext(DbContextOptions<PokemonDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Pokemon> Pokemon { get; set; }
        public virtual DbSet<PokemonStat> PokemonStat { get; set; }
        public virtual DbSet<PokemonType> PokemonType { get; set; }
        public virtual DbSet<Stat> Stat { get; set; }
        public virtual DbSet<Type> Type { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasColumnType("text");
            });

            modelBuilder.Entity<PokemonStat>(entity =>
            {
                entity.HasKey(e => new { e.PokemonId, e.StatId })
                    .HasName("PK__PokemonS__9A658BF0DC40A2B3");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonStat)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PokemonSt__Pokem__3E52440B");

                entity.HasOne(d => d.Stat)
                    .WithMany(p => p.PokemonStat)
                    .HasForeignKey(d => d.StatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PokemonSt__StatI__403A8C7D");
            });

            modelBuilder.Entity<PokemonType>(entity =>
            {
                entity.HasKey(e => new { e.PokemonId, e.SlotId })
                    .HasName("PK__PokemonT__8965CD89D0822EDD");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonType)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PokemonTy__Pokem__3F466844");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PokemonType)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__PokemonTy__TypeI__412EB0B6");
            });

            modelBuilder.Entity<Stat>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnType("text");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnType("text");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
