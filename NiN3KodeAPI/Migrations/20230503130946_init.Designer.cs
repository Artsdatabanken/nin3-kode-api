﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NiN3KodeAPI.DbContexts;

#nullable disable

namespace NiN3KodeAPI.Migrations
{
    [DbContext(typeof(NiN3DbContext))]
    [Migration("20230503130946_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NiN3KodeAPI.Entities.Domene", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("domene");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c2eb1fdb-cb4b-48c4-a745-db8d60320897"),
                            Navn = "3.0"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Grunntype", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Delkode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HovedtypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProsedyrekategoriId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VersionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HovedtypeId");

                    b.HasIndex("ProsedyrekategoriId");

                    b.HasIndex("VersionId");

                    b.ToTable("Grunntype");
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Hovedtype", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Delkode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HovedtypegruppeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProsedyrekategoriId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VersionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HovedtypegruppeId");

                    b.HasIndex("ProsedyrekategoriId");

                    b.HasIndex("VersionId");

                    b.ToTable("Hovedtype");
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Hovedtypegruppe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Delkode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Typekategori2Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VersionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Typekategori2Id");

                    b.HasIndex("VersionId");

                    b.ToTable("Hovedtypegruppe");
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Ecosystnivaa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ecosystnivå");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3fc60e8e-f215-44b3-acf9-4045e79a604f"),
                            Beskrivelse = "abiotisk",
                            Kode = "A"
                        },
                        new
                        {
                            Id = new Guid("65316bb7-a9e7-4e15-8909-1296bc0f1382"),
                            Beskrivelse = "biotisk",
                            Kode = "B"
                        },
                        new
                        {
                            Id = new Guid("a9f6713b-7d73-400c-a25c-5f35c5e03b97"),
                            Beskrivelse = "økodiversitet",
                            Kode = "C"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Maalestokk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Maalestokk");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8991b2f8-2899-44b7-9bba-53533c93134b"),
                            Beskrivelse = "grunntype",
                            Kode = "G"
                        },
                        new
                        {
                            Id = new Guid("d85ef705-3c98-4718-be20-f759f1eddbd4"),
                            Beskrivelse = "kartleggingsenhet tilpasset 1:5000",
                            Kode = "005K"
                        },
                        new
                        {
                            Id = new Guid("0f6cce98-cff7-4316-a054-7b80b3ceec60"),
                            Beskrivelse = "kartleggingsenhet tilpasset 1:10 000",
                            Kode = "010K"
                        },
                        new
                        {
                            Id = new Guid("605e523d-addc-4e6e-96fa-ce891502f2ca"),
                            Beskrivelse = "kartleggingsenhet tilpasset 1:20 000",
                            Kode = "020K"
                        },
                        new
                        {
                            Id = new Guid("915920a6-8df0-4322-ad78-9951af8ff049"),
                            Beskrivelse = "kartleggingsenhet tilpasset 1:50 000",
                            Kode = "050K"
                        },
                        new
                        {
                            Id = new Guid("324367a8-5b5d-4f05-ac61-78dc08e176c0"),
                            Beskrivelse = "kartleggingsenhet tilpasset 1:100 000",
                            Kode = "100K"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Prosedyrekategori", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Prosedyrekategori");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c3b8bcd4-9c94-466f-b341-7eb732c3043d"),
                            Beskrivelse = "A",
                            Kode = "A"
                        },
                        new
                        {
                            Id = new Guid("65d2bb15-853f-4ad1-a78f-2500fa2323d2"),
                            Beskrivelse = "B",
                            Kode = "B"
                        },
                        new
                        {
                            Id = new Guid("e390b967-cb39-4b46-b9d5-c4fc6174c0a7"),
                            Beskrivelse = "C",
                            Kode = "C"
                        },
                        new
                        {
                            Id = new Guid("9aa46ce5-cad3-4520-a295-f9ecd3ee21cb"),
                            Beskrivelse = "D",
                            Kode = "D"
                        },
                        new
                        {
                            Id = new Guid("fc58bae4-6fd7-4d69-9886-52b9c89bc1cd"),
                            Beskrivelse = "E",
                            Kode = "E"
                        },
                        new
                        {
                            Id = new Guid("c1cd9cf6-b70a-44f4-90cb-13ae92a150d6"),
                            Beskrivelse = "F",
                            Kode = "F"
                        },
                        new
                        {
                            Id = new Guid("e2399727-b248-4968-9a1d-d73876fa40a8"),
                            Beskrivelse = "G",
                            Kode = "G"
                        },
                        new
                        {
                            Id = new Guid("2f3d31be-7906-4e7a-aa8e-820a197339fb"),
                            Beskrivelse = "H",
                            Kode = "H"
                        },
                        new
                        {
                            Id = new Guid("1e79f6d1-1edd-4e81-99ef-77be130fb84f"),
                            Beskrivelse = "I",
                            Kode = "I"
                        },
                        new
                        {
                            Id = new Guid("a41cbad7-114c-44dd-98d6-1b39bb4a0c17"),
                            Beskrivelse = "J",
                            Kode = "J"
                        },
                        new
                        {
                            Id = new Guid("8b817630-adb8-4bc8-8872-4f8a840185b1"),
                            Beskrivelse = "K",
                            Kode = "K"
                        },
                        new
                        {
                            Id = new Guid("ae292ccd-8ec2-4474-b2c0-f47bf1723581"),
                            Beskrivelse = "L",
                            Kode = "L"
                        },
                        new
                        {
                            Id = new Guid("0cd9da75-f9ed-4a62-9c68-01269a27bb4a"),
                            Beskrivelse = "M",
                            Kode = "M"
                        },
                        new
                        {
                            Id = new Guid("daae4551-4410-4bea-b83b-4c07bd8de804"),
                            Beskrivelse = "N",
                            Kode = "N"
                        },
                        new
                        {
                            Id = new Guid("8c59f2de-d978-4741-b5e2-a9fe063a3730"),
                            Beskrivelse = "O",
                            Kode = "O"
                        },
                        new
                        {
                            Id = new Guid("1317df3f-cdb3-457c-b4fe-fe2bf0725868"),
                            Beskrivelse = "Ikke angitt",
                            Kode = "0"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Typekategori", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Typekategori");

                    b.HasData(
                        new
                        {
                            Id = new Guid("37183c73-f06f-4859-a403-82398da916be"),
                            Beskrivelse = "livsmedium",
                            Kode = "LI"
                        },
                        new
                        {
                            Id = new Guid("a84ac00a-0c19-4ef5-b7d5-78dcc8fd6ce0"),
                            Beskrivelse = "landformvariasjon",
                            Kode = "LV"
                        },
                        new
                        {
                            Id = new Guid("0a831ba2-4e9a-4766-8aba-07c304f22ef0"),
                            Beskrivelse = "marine vannmasser",
                            Kode = "MV"
                        },
                        new
                        {
                            Id = new Guid("1267e7db-656c-49d8-b37b-4acf9ebe11ce"),
                            Beskrivelse = "primært økodiversitetsnivå",
                            Kode = "PE"
                        },
                        new
                        {
                            Id = new Guid("8b629cb6-8883-4266-9ffd-efd293ab90cf"),
                            Beskrivelse = "sekundært økodiversitetsnivå",
                            Kode = "SE"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Typekategori2", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Typekategori2");

                    b.HasData(
                        new
                        {
                            Id = new Guid("24d65a0e-2e52-4241-91b6-5f10105e55e2"),
                            Beskrivelse = "bremassiv",
                            Kode = "BM"
                        },
                        new
                        {
                            Id = new Guid("199be38d-bbf7-4b3a-b75a-0f91e985c0eb"),
                            Beskrivelse = "elveløp",
                            Kode = "EL"
                        },
                        new
                        {
                            Id = new Guid("6f7cbf26-aeea-4725-ae96-30f14d0f9110"),
                            Beskrivelse = "landformer i fast fjell og løsmasser",
                            Kode = "FL"
                        },
                        new
                        {
                            Id = new Guid("7e41c944-1f7a-4717-b426-1cbca2cf784e"),
                            Beskrivelse = "innsjøbasseng",
                            Kode = "IB"
                        },
                        new
                        {
                            Id = new Guid("35be949a-723c-48f9-a42e-2e0237db1912"),
                            Beskrivelse = "landskapstype",
                            Kode = "LA"
                        },
                        new
                        {
                            Id = new Guid("7ddc4f98-9757-4372-8c9e-f7d84729bd6b"),
                            Beskrivelse = "natursystem",
                            Kode = "NA"
                        },
                        new
                        {
                            Id = new Guid("eaee0faa-a8c3-41da-9e57-2d6d430ae7ec"),
                            Beskrivelse = "naturkompleks",
                            Kode = "NK"
                        },
                        new
                        {
                            Id = new Guid("4ce2b931-abc9-49f8-be7c-19557f173a70"),
                            Beskrivelse = "torvmarksmassiv",
                            Kode = "TM"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Typekategori3", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Typekategori3");

                    b.HasData(
                        new
                        {
                            Id = new Guid("51aa6253-3808-4dbe-bfc4-825624ebfdcd"),
                            Beskrivelse = "vannmassesystemer",
                            Kode = "VM"
                        },
                        new
                        {
                            Id = new Guid("3ce0276e-c5c0-472a-b3f0-e4e608c638b2"),
                            Beskrivelse = "mark- og bunnsystemer",
                            Kode = "MB"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Variabelkategori", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Variabelkategori");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a82759aa-0dc5-4335-81aa-20dd6d1258cc"),
                            Beskrivelse = "mennekebetinget",
                            Kode = "M"
                        },
                        new
                        {
                            Id = new Guid("3153234b-4c30-4959-8763-c8963b1bad0e"),
                            Beskrivelse = "naturgitt",
                            Kode = "N"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Type", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EcosystnivaaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Typekategori2Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TypekategoriId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VersionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EcosystnivaaId");

                    b.HasIndex("Typekategori2Id");

                    b.HasIndex("TypekategoriId");

                    b.HasIndex("VersionId");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Undertype", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GrunntypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VersionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GrunntypeId");

                    b.HasIndex("VersionId");

                    b.ToTable("Undertype");
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Grunntype", b =>
                {
                    b.HasOne("NiN3KodeAPI.Entities.Hovedtype", "Hovedtype")
                        .WithMany()
                        .HasForeignKey("HovedtypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NiN3KodeAPI.Entities.Lookupdata.Prosedyrekategori", "Prosedyrekategori")
                        .WithMany()
                        .HasForeignKey("ProsedyrekategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NiN3KodeAPI.Entities.Domene", "Version")
                        .WithMany()
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hovedtype");

                    b.Navigation("Prosedyrekategori");

                    b.Navigation("Version");
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Hovedtype", b =>
                {
                    b.HasOne("NiN3KodeAPI.Entities.Hovedtypegruppe", "Hovedtypegruppe")
                        .WithMany()
                        .HasForeignKey("HovedtypegruppeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NiN3KodeAPI.Entities.Lookupdata.Prosedyrekategori", "Prosedyrekategori")
                        .WithMany()
                        .HasForeignKey("ProsedyrekategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NiN3KodeAPI.Entities.Domene", "Version")
                        .WithMany()
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hovedtypegruppe");

                    b.Navigation("Prosedyrekategori");

                    b.Navigation("Version");
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Hovedtypegruppe", b =>
                {
                    b.HasOne("NiN3KodeAPI.Entities.Lookupdata.Typekategori2", "Typekategori2")
                        .WithMany()
                        .HasForeignKey("Typekategori2Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("NiN3KodeAPI.Entities.Domene", "Version")
                        .WithMany()
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Typekategori2");

                    b.Navigation("Version");
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Type", b =>
                {
                    b.HasOne("NiN3KodeAPI.Entities.Lookupdata.Ecosystnivaa", "Ecosystnivaa")
                        .WithMany()
                        .HasForeignKey("EcosystnivaaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NiN3KodeAPI.Entities.Lookupdata.Typekategori2", "Typekategori2")
                        .WithMany()
                        .HasForeignKey("Typekategori2Id");

                    b.HasOne("NiN3KodeAPI.Entities.Lookupdata.Typekategori", "Typekategori")
                        .WithMany()
                        .HasForeignKey("TypekategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NiN3KodeAPI.Entities.Domene", "Version")
                        .WithMany()
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ecosystnivaa");

                    b.Navigation("Typekategori");

                    b.Navigation("Typekategori2");

                    b.Navigation("Version");
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Undertype", b =>
                {
                    b.HasOne("NiN3KodeAPI.Entities.Grunntype", "Grunntype")
                        .WithMany()
                        .HasForeignKey("GrunntypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NiN3KodeAPI.Entities.Domene", "Version")
                        .WithMany()
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grunntype");

                    b.Navigation("Version");
                });
#pragma warning restore 612, 618
        }
    }
}
