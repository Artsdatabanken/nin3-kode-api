using Microsoft.EntityFrameworkCore;
using NiN3.Core.Models;
using System.Reflection.Metadata;

namespace NiN3.Infrastructure.DbContexts
{
    public class NiN3DbContext : DbContext
    {
        public NiN3DbContext(DbContextOptions<NiN3DbContext> options)
    : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Versjon>()
            .Property(v => v.Id)
            .HasDefaultValueSql("newid()");
            //modelBuilder.Entity<Versjon>()
            //    .HasMany(v => v.Typer);

            //modelBuilder.Entity<NiN3.Core.Models.Type>()
            //    .HasOne(t => t.Versjon);
            // tell modelbuilder that version has many v.Typer

            //modelBuilder.Entity<Oppslagstype>()
            //.Property(b => b.Id)
            //.HasDefaultValueSql("NEWID()");

            /********* SEEDING ***********/

            // Versjon
            modelBuilder.Entity<Versjon>().HasData(
                new Versjon() { Id = Guid.NewGuid(), Navn = "3.0" }
            );
            modelBuilder.Entity<Hovedtype>()
                .HasOne(e => e.Hovedtypegruppe)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            /*           modelBuilder.Entity<Hovedtypegruppe>()
                           .HasOne(e => e.Typekategori2)
                           .WithMany()
                           .OnDelete(DeleteBehavior.Restrict);*/
            /*           modelBuilder.Entity<Undertype>()
                           .HasOne(e => e.Hovedtype)
                           .WithMany()
                           .OnDelete(DeleteBehavior.Restrict);
                       modelBuilder.Entity<Undertype>()
                       .HasOne(e => e.Hovedtypegruppe)
                       .WithMany()
                       .OnDelete(DeleteBehavior.Restrict);*/
            modelBuilder.Entity<Grunntype>()
            .HasOne(e => e.Hovedtype)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

        // TYPER
        //  public DbSet<Ecosystnivaa> Ecosystnivaa { get; set; }
        //public DbSet<Maalestokk> Maalestokk { get; set; }
        //public DbSet<Typekategori> Typekategori { get; set; }
        //public DbSet<Typekategori2> Typekategori2 { get; set; }
        //public DbSet<Prosedyrekategori> Prosedyrekategori { get; set; }
        public DbSet<Versjon> Versjon { get; set; }
        public DbSet<NiN3.Core.Models.Type> Type { get; set; }
        public DbSet<Hovedtypegruppe> Hovedtypegruppe { get; set; }
        public DbSet<Hovedtype> Hovedtype { get; set; }
        public DbSet<Grunntype> Grunntype { get; set; }
        //public DbSet<Undertype> Undertype { get; set; }

        //public DbSet<Variabeltype> Variabeltype { get; set;}
        //public DbSet<Variabelkategori2> Variabelkategori2 { get;set; }
        //public DbSet<Variabelgruppe> Variabelgruppe { get; set; }   

        //VARIABLER
        // ...

        //ANDRE
        // ...

    }
}
