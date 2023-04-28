using Microsoft.EntityFrameworkCore;
using NiN3KodeAPI.Entities;
using NiN3KodeAPI.Entities.Lookupdata;
using System.Reflection.Metadata;

namespace NiN3KodeAPI.DbContexts
{
    public class NiN3DbContext : DbContext
    {
        private DataImportHelper _dataImportHelper;
        public NiN3DbContext(DbContextOptions<NiN3DbContext> options)
    : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<Blog>()
                .Property(b => b.Url)
                .HasColumnName("Url");

            modelBuilder.Entity<RssBlog>()
                .Property(b => b.Url)
                .HasColumnName("Url");
            */

            /********* SEEDING ***********/
            // Domene
            modelBuilder.Entity<Domene>().HasData(
                new Domene() { Id = Guid.NewGuid(), Navn = "3.0" }
                );

            // Ecosystnivaa
            modelBuilder.Entity<Ecosystnivaa>().HasData(
                new Ecosystnivaa() { Id = Guid.NewGuid(), Kode = "A", Beskrivelse = "abiotisk" },
                new Ecosystnivaa() { Id = Guid.NewGuid(), Kode = "B", Beskrivelse = "biotisk" },
                new Ecosystnivaa() { Id = Guid.NewGuid(), Kode = "C", Beskrivelse = "økodiversitet" }
            );
            //Typekategori
            modelBuilder.Entity<Typekategori>().HasData(
                new Typekategori() { Id = Guid.NewGuid(), Kode = "LI", Beskrivelse = "livsmedium" },
                new Typekategori() { Id = Guid.NewGuid(), Kode = "LV", Beskrivelse = "landformvariasjon" },
                new Typekategori() { Id = Guid.NewGuid(), Kode = "MV", Beskrivelse = "marine vannmasser" },
                new Typekategori() { Id = Guid.NewGuid(), Kode = "PE", Beskrivelse = "primært økodiversitetsnivå" },
                new Typekategori() { Id = Guid.NewGuid(), Kode = "SE", Beskrivelse = "sekundært økodiversitetsnivå" }
            );
            // ...
            modelBuilder.Entity<Typekategori2>().HasData(
                new Typekategori2() { Id = Guid.NewGuid(), Kode = "BM", Beskrivelse = "bremassiv" },
                new Typekategori2() { Id = Guid.NewGuid(), Kode = "EL", Beskrivelse = "elveløp" },
                new Typekategori2() { Id = Guid.NewGuid(), Kode = "FL", Beskrivelse = "landformer i fast fjell og løsmasser" },
                new Typekategori2() { Id = Guid.NewGuid(), Kode = "IB", Beskrivelse = "innsjøbasseng" },
                new Typekategori2() { Id = Guid.NewGuid(), Kode = "LA", Beskrivelse = "landskapstype" },
                new Typekategori2() { Id = Guid.NewGuid(), Kode = "NA", Beskrivelse = "natursystem" },
                new Typekategori2() { Id = Guid.NewGuid(), Kode = "NK", Beskrivelse = "naturkompleks" },
                new Typekategori2() { Id = Guid.NewGuid(), Kode = "TM", Beskrivelse = "torvmarksmassiv" }
                );
            modelBuilder.Entity<Typekategori3>().HasData(
                new Typekategori3() { Id = Guid.NewGuid(), Kode = "VM", Beskrivelse = "vannmassesystemer" },
                new Typekategori3() { Id = Guid.NewGuid(), Kode = "MB", Beskrivelse = "mark- og bunnsystemer" }
                );
            modelBuilder.Entity<Maalestokk>().HasData(
                new Maalestokk() { Id = Guid.NewGuid(), Kode = "G", Beskrivelse = "grunntype" },
                new Maalestokk() { Id = Guid.NewGuid(), Kode = "005K", Beskrivelse = "kartleggingsenhet tilpasset 1:5000" },
                new Maalestokk() { Id = Guid.NewGuid(), Kode = "010K", Beskrivelse = "kartleggingsenhet tilpasset 1:10 000" },
                new Maalestokk() { Id = Guid.NewGuid(), Kode = "020K", Beskrivelse = "kartleggingsenhet tilpasset 1:20 000" },
                new Maalestokk() { Id = Guid.NewGuid(), Kode = "050K", Beskrivelse = "kartleggingsenhet tilpasset 1:50 000" },
                new Maalestokk() { Id = Guid.NewGuid(), Kode = "100K", Beskrivelse = "kartleggingsenhet tilpasset 1:100 000" }
                );
            modelBuilder.Entity<Prosedyrekategori>().HasData(
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "A", Beskrivelse = "A" },
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "B", Beskrivelse = "B" },
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "C", Beskrivelse = "C" },
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "D", Beskrivelse = "D" },
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "E", Beskrivelse = "E" },
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "F", Beskrivelse = "F" },
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "G", Beskrivelse = "G" },
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "H", Beskrivelse = "H" },
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "I", Beskrivelse = "I" },
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "J", Beskrivelse = "J" },
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "K", Beskrivelse = "K" },
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "L", Beskrivelse = "L" },
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "M", Beskrivelse = "M" },
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "N", Beskrivelse = "N" },
                new Prosedyrekategori() { Id = Guid.NewGuid(), Kode = "O", Beskrivelse = "O" }
                );



            /*
                // variabeltyper
                new Variabeltype() {Id = Guid.NewGuid(), Kode = "FE", Beskrivelse="enkel, ikke-ordnet faktorvariabel"},
                new Variabeltype() {Id = Guid.NewGuid(), Kode = "FK", Beskrivelse="kompleks, ikke-ordnet faktorvariabel"},
                new Variabeltype() {Id = Guid.NewGuid(), Kode = "GE", Beskrivelse="enkel gradient"},
                new Variabeltype() {Id = Guid.NewGuid(), Kode = "GK", Beskrivelse="kompleks gradient"}*/

            /*
             // variabelkategori
             new Variabelkategori() {Id = Guid.NewGuid(), Kode = "M", Beskrivelse="mennekebetinget"},
             new Variabelkategori() {Id = Guid.NewGuid(), Kode = "N", Beskrivelse="naturgitt"}
             */

            /*
             new Variabelkategori2() {Id = Guid.NewGuid(), Kode = "AD", Beskrivelse="artssammensetningsdynamikk"},
            new Variabelkategori2() {Id = Guid.NewGuid(), Kode = "BE", Beskrivelse="bergarter"},
            new Variabelkategori2() {Id = Guid.NewGuid(), Kode = "KM", Beskrivelse="korttidsmiljøvariabel"},
            new Variabelkategori2() {Id = Guid.NewGuid(), Kode = "LM", Beskrivelse="lokal miljøvariabel"},
            new Variabelkategori2() {Id = Guid.NewGuid(), Kode = "LO", Beskrivelse="landform-objekter"},
            new Variabelkategori2() {Id = Guid.NewGuid(), Kode = "MD", Beskrivelse="miljødynamikk"},
            new Variabelkategori2() {Id = Guid.NewGuid(), Kode = "MO", Beskrivelse="menneskeskapt objekt"},
            new Variabelkategori2() {Id = Guid.NewGuid(), Kode = "NO", Beskrivelse="naturgitt objekt"},
            new Variabelkategori2() {Id = Guid.NewGuid(), Kode = "RA", Beskrivelse="romlig artsfordelingsmønster"},
            new Variabelkategori2() {Id = Guid.NewGuid(), Kode = "RM", Beskrivelse="regional miljøvariabel"},
            new Variabelkategori2() {Id = Guid.NewGuid(), Kode = "RS", Beskrivelse="romlig strukturvariasjon"},
            new Variabelkategori2() {Id = Guid.NewGuid(), Kode = "SA", Beskrivelse="strukturerende og funksjonelle artsgrupper"},
            new Variabelkategori2() {Id = Guid.NewGuid(), Kode = "TF", Beskrivelse="terrengformvariasjon"},
            new Variabelkategori2() {Id = Guid.NewGuid(), Kode = "VS", Beskrivelse="vertikal struktur"}
             */
            modelBuilder.Entity<Hovedtype>()
                .HasOne(e => e.Hovedtypegruppe)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Hovedtypegruppe>()
                .HasOne(e => e.Typekategori2)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Undertype>()
                .HasOne(e => e.Hovedtype)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Undertype>()
            .HasOne(e => e.Hovedtypegruppe)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Undertype>()
            .HasOne(e => e.Grunntype)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Ecosystnivaa> Ecosystnivaa { get; set; }
        public DbSet<Typekategori> Typekategori { get; set; }
        public DbSet<Typekategori2> Typekategori2 { get; set; }

        public DbSet<Prosedyrekategori> Prosedyrekategori { get; set; }
        public DbSet<Domene> domene { get; set; }
        public DbSet<Entities.Type> type { get; set; }
        public DbSet<Hovedtypegruppe> hovedtypegruppe { get; set; }
        public DbSet<Hovedtype> hovedtype { get; set; }
        public DbSet<Grunntype> grunntype { get; set; }
        public DbSet<Undertype> undertype { get; set; }

    }
}
