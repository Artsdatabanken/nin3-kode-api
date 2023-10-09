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
                new Versjon() { Id = 1, Navn = "3.0" }
            );
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
        public DbSet<Kartleggingsenhet> Kartleggingsenhet { get; set; }
        public DbSet<Hovedtype_Kartleggingsenhet> Hovedtype_Kartleggingsenhet { get; set; }
        //public DbSet<Undertype> Undertype { get; set; }

        //public DbSet<Variabeltype> Variabeltype { get; set;}
        //public DbSet<Variabelkategori2> Variabelkategori2 { get;set; }
        //public DbSet<Variabelgruppe> Variabelgruppe { get; set; }   

        //VARIABLER
        public DbSet<Variabel> Variabel { get; set; }
        public DbSet<Variabelnavn> Variabelnavn { get; set; }
        public DbSet<Hovedtypegruppe_Hovedoekosystem> Hovedtypegruppe_Hovedoekosystem { get; set; }

        public DbSet<VariabelnavnMaaleskalaTrinn> VariabelnavnMaaleskalaTrinn { get; set; }

        public DbSet<Maaleskala> Maaleskala { get; set; }
        public DbSet<Trinn> Trinn { get; set; }

        public DbSet<AlleKortkoder> AlleKortkoder { get; set; }
        public DbSet<Enumoppslag> Enumoppslag { get; set;}

        //ANDRE
        // ...

    }
}
