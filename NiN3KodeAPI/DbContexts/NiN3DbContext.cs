using Microsoft.EntityFrameworkCore;
using NiN3KodeAPI.Entities;
using NiN3KodeAPI.Entities.Lookupdata;
using System.Reflection.Metadata;

namespace NiN3KodeAPI.DbContexts
{
    public class NiN3DbContext : DbContext
    {
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
            modelBuilder.Entity<BaseIdEntity>()
            .Property(b => b.Id)
            .HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Domene>()
            .Property(b => b.Id)
            .HasDefaultValueSql("NEWID()");
            
            /********* SEEDING ***********/
            
            // Domene
            //modelBuilder.Entity<Domene>().HasData(
            //    new Domene() { /* Id = Guid.NewGuid(), */ Navn = "3.0" }
            //    );
            
            //// Ecosystnivaa
            //modelBuilder.Entity<Ecosystnivaa>().HasData(
            //    new Ecosystnivaa() { /* Id = Guid.NewGuid(), */ Kode = "A", Beskrivelse = "abiotisk" },
            //    new Ecosystnivaa() { /* Id = Guid.NewGuid(), */ Kode = "B", Beskrivelse = "biotisk" },
            //    new Ecosystnivaa() { /* Id = Guid.NewGuid(), */ Kode = "C", Beskrivelse = "økodiversitet" }
            //);
            ////Typekategori
           
            //modelBuilder.Entity<Typekategori>().HasData(
            //    new Typekategori() { /* Id = Guid.NewGuid(), */ Kode = "LI", Beskrivelse = "livsmedium" },
            //    new Typekategori() { /* Id = Guid.NewGuid(), */ Kode = "LV", Beskrivelse = "landformvariasjon" },
            //    new Typekategori() { /* Id = Guid.NewGuid(), */ Kode = "MV", Beskrivelse = "marine vannmasser" },
            //    new Typekategori() { /* Id = Guid.NewGuid(), */ Kode = "PE", Beskrivelse = "primært økodiversitetsnivå" },
            //    new Typekategori() { /* Id = Guid.NewGuid(), */ Kode = "SE", Beskrivelse = "sekundært økodiversitetsnivå" }
            //);
            //// ...
            //modelBuilder.Entity<Typekategori2>().HasData(
            //    new Typekategori2() { /* Id = Guid.NewGuid(), */ Kode = "BM", Beskrivelse = "bremassiv" },
            //    new Typekategori2() { /* Id = Guid.NewGuid(), */ Kode = "EL", Beskrivelse = "elveløp" },
            //    new Typekategori2() { /* Id = Guid.NewGuid(), */ Kode = "FL", Beskrivelse = "landformer i fast fjell og løsmasser" },
            //    new Typekategori2() { /* Id = Guid.NewGuid(), */ Kode = "IB", Beskrivelse = "innsjøbasseng" },
            //    new Typekategori2() { /* Id = Guid.NewGuid(), */ Kode = "LA", Beskrivelse = "landskapstype" },
            //    new Typekategori2() { /* Id = Guid.NewGuid(), */ Kode = "NA", Beskrivelse = "natursystem" },
            //    new Typekategori2() { /* Id = Guid.NewGuid(), */ Kode = "NK", Beskrivelse = "naturkompleks" },
            //    new Typekategori2() { /* Id = Guid.NewGuid(), */ Kode = "TM", Beskrivelse = "torvmarksmassiv" }
            //    );
            //modelBuilder.Entity<Typekategori3>().HasData(
            //    new Typekategori3() { /* Id = Guid.NewGuid(), */ Kode = "VM", Beskrivelse = "vannmassesystemer" },
            //    new Typekategori3() { /* Id = Guid.NewGuid(), */ Kode = "MB", Beskrivelse = "mark- og bunnsystemer" }
            //    );
            //modelBuilder.Entity<Maalestokk>().HasData(
            //    new Maalestokk() { /* Id = Guid.NewGuid(), */ Kode = "G", Beskrivelse = "grunntype" },
            //    new Maalestokk() { /* Id = Guid.NewGuid(), */ Kode = "005K", Beskrivelse = "kartleggingsenhet tilpasset 1:5000" },
            //    new Maalestokk() { /* Id = Guid.NewGuid(), */ Kode = "010K", Beskrivelse = "kartleggingsenhet tilpasset 1:10 000" },
            //    new Maalestokk() { /* Id = Guid.NewGuid(), */ Kode = "020K", Beskrivelse = "kartleggingsenhet tilpasset 1:20 000" },
            //    new Maalestokk() { /* Id = Guid.NewGuid(), */ Kode = "050K", Beskrivelse = "kartleggingsenhet tilpasset 1:50 000" },
            //    new Maalestokk() { /* Id = Guid.NewGuid(), */ Kode = "100K", Beskrivelse = "kartleggingsenhet tilpasset 1:100 000" }
            //    );
            //modelBuilder.Entity<Prosedyrekategori>().HasData(
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "A", Beskrivelse = "A" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "B", Beskrivelse = "B" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "C", Beskrivelse = "C" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "D", Beskrivelse = "D" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "E", Beskrivelse = "E" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "F", Beskrivelse = "F" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "G", Beskrivelse = "G" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "H", Beskrivelse = "H" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "I", Beskrivelse = "I" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "J", Beskrivelse = "J" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "K", Beskrivelse = "K" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "L", Beskrivelse = "L" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "M", Beskrivelse = "M" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "N", Beskrivelse = "N" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "O", Beskrivelse = "O" },
            //    new Prosedyrekategori() { /* Id = Guid.NewGuid(), */ Kode = "0", Beskrivelse = "Ikke angitt" }
            //    );


            //// variabelkategori
            //modelBuilder.Entity<Variabelkategori>().HasData(
            //    new Variabelkategori() { /* Id = Guid.NewGuid(), */ Kode = "M", Beskrivelse = "mennekebetinget" },
            //    new Variabelkategori() { /* Id = Guid.NewGuid(), */ Kode = "N", Beskrivelse = "naturgitt" }
            //);





            //// variabeltyper
            //modelBuilder.Entity<Variabeltype>().HasData(
            //    new Variabeltype() { /* Id = Guid.NewGuid(), */ Kode = "FE", Beskrivelse = "enkel, ikke-ordnet faktorvariabel" },
            //        new Variabeltype() { /* Id = Guid.NewGuid(), */ Kode = "FK", Beskrivelse = "kompleks, ikke-ordnet faktorvariabel" },
            //        new Variabeltype() { /* Id = Guid.NewGuid(), */ Kode = "GE", Beskrivelse = "enkel gradient" },
            //        new Variabeltype() { /* Id = Guid.NewGuid(), */ Kode = "GK", Beskrivelse = "kompleks gradient" }
            //        );



            //modelBuilder.Entity<Variabelkategori2>().HasData(
            // new Variabelkategori2() { /* Id = Guid.NewGuid(), */ Kode = "AD", Beskrivelse = "artssammensetningsdynamikk" },
            //new Variabelkategori2() { /* Id = Guid.NewGuid(), */ Kode = "BE", Beskrivelse = "bergarter" },
            //new Variabelkategori2() { /* Id = Guid.NewGuid(), */ Kode = "KM", Beskrivelse = "korttidsmiljøvariabel" },
            //new Variabelkategori2() { /* Id = Guid.NewGuid(), */ Kode = "LM", Beskrivelse = "lokal miljøvariabel" },
            //new Variabelkategori2() { /* Id = Guid.NewGuid(), */ Kode = "LO", Beskrivelse = "landform-objekter" },
            //new Variabelkategori2() { /* Id = Guid.NewGuid(), */ Kode = "MD", Beskrivelse = "miljødynamikk" },
            //new Variabelkategori2() { /* Id = Guid.NewGuid(), */ Kode = "MO", Beskrivelse = "menneskeskapt objekt" },
            //new Variabelkategori2() { /* Id = Guid.NewGuid(), */ Kode = "NO", Beskrivelse = "naturgitt objekt" },
            //new Variabelkategori2() { /* Id = Guid.NewGuid(), */ Kode = "RA", Beskrivelse = "romlig artsfordelingsmønster" },
            //new Variabelkategori2() { /* Id = Guid.NewGuid(), */ Kode = "RM", Beskrivelse = "regional miljøvariabel" },
            //new Variabelkategori2() { /* Id = Guid.NewGuid(), */ Kode = "RS", Beskrivelse = "romlig strukturvariasjon" },
            //new Variabelkategori2() { /* Id = Guid.NewGuid(), */ Kode = "SA", Beskrivelse = "strukturerende og funksjonelle artsgrupper" },
            //new Variabelkategori2() { /* Id = Guid.NewGuid(), */ Kode = "TF", Beskrivelse = "terrengformvariasjon" },
            //new Variabelkategori2() { /* Id = Guid.NewGuid(), */ Kode = "VS", Beskrivelse = "vertikal struktur" }
            // );

            //modelBuilder.Entity<Variabelgruppe>().HasData(
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "W W", Beskrivelse = "W W" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "EE elveløpsegenskaper", Beskrivelse = "EE elveløpsegenskaper" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "SB skogbruksrelaterte egeskaper", Beskrivelse = "SB skogbruksrelaterte egeskaper" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "DL liggende død ved (læger)", Beskrivelse = "DL liggende død ved (læger)" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "W artsforekomst/-mengde", Beskrivelse = "W artsforekomst/-mengde" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "AG artsgruppesammensetning", Beskrivelse = "AG artsgruppesammensetning" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "AR relativ del-artsgruppesammensetning", Beskrivelse = "AR relativ del-artsgruppesammensetning" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "BO naturgitte breobjekter", Beskrivelse = "BO naturgitte breobjekter" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "EB elvebanker", Beskrivelse = "EB elvebanker" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "EO andre naturgitte elveløpsobjekter", Beskrivelse = "EO andre naturgitte elveløpsobjekter" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "IO naturgitte innsjøobjekter", Beskrivelse = "IO naturgitte innsjøobjekter" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "TA torvmarksmassiv: myrsegment", Beskrivelse = "TA torvmarksmassiv: myrsegment" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "TB torvmarksmassiv: myrstruktur", Beskrivelse = "TB torvmarksmassiv: myrstruktur" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "TC torvmarksmassiv: mikrostruktur", Beskrivelse = "TC torvmarksmassiv: mikrostruktur" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "SE skogegenskaper", Beskrivelse = "SE skogegenskaper" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "IE innsjøbassengegenskaper", Beskrivelse = "IE innsjøbassengegenskaper" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "GE generelle egenskaper", Beskrivelse = "GE generelle egenskaper" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "GT generelle terrengegenskaper", Beskrivelse = "GT generelle terrengegenskaper" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "HE havegenskaper", Beskrivelse = "HE havegenskaper" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "BE bremassivegenskaper", Beskrivelse = "BE bremassivegenskaper" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "OE menneskeskapt objekt i elv", Beskrivelse = "OE menneskeskapt objekt i elv" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "OI menneskeskapt objekt i innsjø eller til havs", Beskrivelse = "OI menneskeskapt objekt i innsjø eller til havs" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "OT menneskeskapt terrestrisk objekt", Beskrivelse = "OT menneskeskapt terrestrisk objekt" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "SU suksesjonsrelaterte egenskaper", Beskrivelse = "SU suksesjonsrelaterte egenskaper" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "JB jordbruksrelaterte egenskaper", Beskrivelse = "JB jordbruksrelaterte egenskaper" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "SB skogbruksrelaterte egenskaper", Beskrivelse = "SB skogbruksrelaterte egenskaper" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "SB skogbruksegenskaper", Beskrivelse = "SB skogbruksegenskaper" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "DG stående død ved (gadder)", Beskrivelse = "DG stående død ved (gadder)" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "DR relativ sammensetning av død ved", Beskrivelse = "DR relativ sammensetning av død ved" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "TE generelle treegenskaper", Beskrivelse = "TE generelle treegenskaper" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "TG gammelt tre", Beskrivelse = "TG gammelt tre" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "TL tre med spesielt livsmedium", Beskrivelse = "TL tre med spesielt livsmedium" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "TM trær med gitt minstestørrelse", Beskrivelse = "TM trær med gitt minstestørrelse" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "TS trær med gitt størrelse", Beskrivelse = "TS trær med gitt størrelse" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "AM artsforekomst/-mengde", Beskrivelse = "AM artsforekomst/-mengde" },
            //    new Variabelgruppe() { /* Id = Guid.NewGuid(), */ Kode = "FA fremmedartsegenskaper", Beskrivelse = "FA fremmedartsegenskaper" }
            //    );

            modelBuilder.Entity<Hovedtype>()
                .HasOne(e => e.Hovedtypegruppe)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Hovedtypegruppe>()
                .HasOne(e => e.Typekategori2)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            /*           modelBuilder.Entity<Undertype>()
                           .HasOne(e => e.Hovedtype)
                           .WithMany()
                           .OnDelete(DeleteBehavior.Restrict);
                       modelBuilder.Entity<Undertype>()
                       .HasOne(e => e.Hovedtypegruppe)
                       .WithMany()
                       .OnDelete(DeleteBehavior.Restrict);*/
            modelBuilder.Entity<Undertype>()
            .HasOne(e => e.Grunntype)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Grunntype>()
            .HasOne(e => e.Hovedtype)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

        // TYPER
        public DbSet<Ecosystnivaa> Ecosystnivaa { get; set; }
        public DbSet<Maalestokk> Maalestokk { get; set; }
        public DbSet<Typekategori> Typekategori { get; set; }
        public DbSet<Typekategori2> Typekategori2 { get; set; }
        public DbSet<Prosedyrekategori> Prosedyrekategori { get; set; }
        public DbSet<Domene> Domene { get; set; }
        public DbSet<Entities.Type> Type { get; set; }
        public DbSet<Hovedtypegruppe> Hovedtypegruppe { get; set; }
        public DbSet<Hovedtype> Hovedtype { get; set; }
        public DbSet<Grunntype> Grunntype { get; set; }
        public DbSet<Undertype> Undertype { get; set; }

        public DbSet<Variabeltype> Variabeltype { get; set;}
        public DbSet<Variabelkategori2> Variabelkategori2 { get;set; }
        public DbSet<Variabelgruppe> Variabelgruppe { get; set; }   
        
        //VARIABLER
        // ...

        //ANDRE
        // ...

    }
}
