using GestImmo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Data.DAL
{
    internal class GestImmoContext : DbContext
    {
        public DbSet<Appartement> Appartements { get; set; }
        public DbSet<Bail> Bails { get; set; }
        public DbSet<Bien> Biens { get; set; }
        public DbSet<Box> Boxs { get; set; }
        public DbSet<Habitable> Habitables { get; set; }
        public DbSet<Intervention> Interventitons { get; set; }
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Maison> Maisons { get; set; }
        public DbSet<Prestataire> Prestataires { get; set; }
        public DbSet<Pret> Prets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=gestimmo;Username=un;Password=pw");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Habitable>().ToTable("Habitable");
            modelBuilder.Entity<Maison>().ToTable("Maison");
            modelBuilder.Entity<Box>().ToTable("Box");
            modelBuilder.Entity<Appartement>().ToTable("Appartement");
        }
    }
}
