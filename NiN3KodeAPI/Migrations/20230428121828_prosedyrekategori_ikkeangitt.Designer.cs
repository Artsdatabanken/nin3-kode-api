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
    [Migration("20230428121828_prosedyrekategori_ikkeangitt")]
    partial class prosedyrekategori_ikkeangitt
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
                            Id = new Guid("7c3a6b96-7c1e-4fe6-a37e-b0e2b5508a9d"),
                            Navn = "3.0"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Grunntype", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
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
                            Id = new Guid("18619862-f23d-4ea6-9a0b-8613bc8bb3a8"),
                            Beskrivelse = "abiotisk",
                            Kode = "A"
                        },
                        new
                        {
                            Id = new Guid("1aa8a7c5-9e0d-4236-940e-508f3712f087"),
                            Beskrivelse = "biotisk",
                            Kode = "B"
                        },
                        new
                        {
                            Id = new Guid("c5ac0705-165a-40df-b562-bf21c92f718c"),
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
                            Id = new Guid("706c753a-d36a-4ad8-a7d1-c84759414385"),
                            Beskrivelse = "grunntype",
                            Kode = "G"
                        },
                        new
                        {
                            Id = new Guid("88b4da0c-6498-40b8-81e5-c731efa5adea"),
                            Beskrivelse = "kartleggingsenhet tilpasset 1:5000",
                            Kode = "005K"
                        },
                        new
                        {
                            Id = new Guid("24748039-e822-4727-a036-5801a9e18f4b"),
                            Beskrivelse = "kartleggingsenhet tilpasset 1:10 000",
                            Kode = "010K"
                        },
                        new
                        {
                            Id = new Guid("db367a0b-5e80-482c-98de-0e81f24efd9a"),
                            Beskrivelse = "kartleggingsenhet tilpasset 1:20 000",
                            Kode = "020K"
                        },
                        new
                        {
                            Id = new Guid("78218321-2042-41d5-b741-684f03253da5"),
                            Beskrivelse = "kartleggingsenhet tilpasset 1:50 000",
                            Kode = "050K"
                        },
                        new
                        {
                            Id = new Guid("c91d1a12-5ac8-4584-94b1-9bdc9afda97b"),
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
                            Id = new Guid("cb3512b1-efdb-4550-a341-ffe42745370a"),
                            Beskrivelse = "A",
                            Kode = "A"
                        },
                        new
                        {
                            Id = new Guid("7280367e-01e1-4af5-ba04-d0794f0879ff"),
                            Beskrivelse = "B",
                            Kode = "B"
                        },
                        new
                        {
                            Id = new Guid("c7ddab9f-72a0-4d11-84f4-2d488de08998"),
                            Beskrivelse = "C",
                            Kode = "C"
                        },
                        new
                        {
                            Id = new Guid("87131520-621b-4193-903d-8130598cdce4"),
                            Beskrivelse = "D",
                            Kode = "D"
                        },
                        new
                        {
                            Id = new Guid("8c04df41-8a4a-4f74-b8f4-e038b21bf434"),
                            Beskrivelse = "E",
                            Kode = "E"
                        },
                        new
                        {
                            Id = new Guid("282f35cf-1b68-4dba-8f5f-8e51db9d9c34"),
                            Beskrivelse = "F",
                            Kode = "F"
                        },
                        new
                        {
                            Id = new Guid("7ef37913-2761-47f2-99ef-5fe84a080e99"),
                            Beskrivelse = "G",
                            Kode = "G"
                        },
                        new
                        {
                            Id = new Guid("9a08a760-bba7-4ce3-8f30-dea2df3141e3"),
                            Beskrivelse = "H",
                            Kode = "H"
                        },
                        new
                        {
                            Id = new Guid("150ebeca-a6d6-4d32-90f2-97fdd5405d08"),
                            Beskrivelse = "I",
                            Kode = "I"
                        },
                        new
                        {
                            Id = new Guid("2ad7d981-af77-4ad2-bd10-68a53f5853bb"),
                            Beskrivelse = "J",
                            Kode = "J"
                        },
                        new
                        {
                            Id = new Guid("58689ef8-720f-408c-8ba5-eb0e0ebd6b4c"),
                            Beskrivelse = "K",
                            Kode = "K"
                        },
                        new
                        {
                            Id = new Guid("8f13edc6-a1a4-41ef-ab4c-a0814e680c90"),
                            Beskrivelse = "L",
                            Kode = "L"
                        },
                        new
                        {
                            Id = new Guid("ba15dc3a-217e-4562-8181-39d51bc3a7c6"),
                            Beskrivelse = "M",
                            Kode = "M"
                        },
                        new
                        {
                            Id = new Guid("c0bcb511-0de7-4be7-9b52-ad69474400e9"),
                            Beskrivelse = "N",
                            Kode = "N"
                        },
                        new
                        {
                            Id = new Guid("477f07bf-350c-4df6-81d1-ec92db9c01dc"),
                            Beskrivelse = "O",
                            Kode = "O"
                        },
                        new
                        {
                            Id = new Guid("5c6b2e05-df37-4f3a-b7ca-502fa7896b50"),
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
                            Id = new Guid("ef3bb61c-4473-4615-bf89-1b96ff622be2"),
                            Beskrivelse = "livsmedium",
                            Kode = "LI"
                        },
                        new
                        {
                            Id = new Guid("e75459d5-d151-4c26-9bdc-5b3a17c507ca"),
                            Beskrivelse = "landformvariasjon",
                            Kode = "LV"
                        },
                        new
                        {
                            Id = new Guid("dd55f2ba-96ea-4e5a-a3fb-28b8b6e6e803"),
                            Beskrivelse = "marine vannmasser",
                            Kode = "MV"
                        },
                        new
                        {
                            Id = new Guid("adf409a3-e6d6-4407-976c-dacaa7a6edd8"),
                            Beskrivelse = "primært økodiversitetsnivå",
                            Kode = "PE"
                        },
                        new
                        {
                            Id = new Guid("83a8ca1a-3ed1-47c3-818a-7587b0dde56d"),
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
                            Id = new Guid("8ee0afdb-571a-4ef5-b067-f97223b0315e"),
                            Beskrivelse = "bremassiv",
                            Kode = "BM"
                        },
                        new
                        {
                            Id = new Guid("c903111f-60ad-480f-be3b-b38eced3a530"),
                            Beskrivelse = "elveløp",
                            Kode = "EL"
                        },
                        new
                        {
                            Id = new Guid("74524f6d-404c-4f49-b45c-d47807080d51"),
                            Beskrivelse = "landformer i fast fjell og løsmasser",
                            Kode = "FL"
                        },
                        new
                        {
                            Id = new Guid("79b477e8-f2dd-4ed7-805b-97a817a3e3d3"),
                            Beskrivelse = "innsjøbasseng",
                            Kode = "IB"
                        },
                        new
                        {
                            Id = new Guid("41c5f0cf-16a1-4516-a248-0551fb629096"),
                            Beskrivelse = "landskapstype",
                            Kode = "LA"
                        },
                        new
                        {
                            Id = new Guid("fcb54a2b-b03a-4d8f-958d-fa59c2af6c9d"),
                            Beskrivelse = "natursystem",
                            Kode = "NA"
                        },
                        new
                        {
                            Id = new Guid("29c5c871-049a-4cca-960d-eafa0638bf3b"),
                            Beskrivelse = "naturkompleks",
                            Kode = "NK"
                        },
                        new
                        {
                            Id = new Guid("54277011-251a-4ed6-898d-506c04e8f789"),
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
                            Id = new Guid("17d5dcd8-d92f-4d3c-8993-5382deedc578"),
                            Beskrivelse = "vannmassesystemer",
                            Kode = "VM"
                        },
                        new
                        {
                            Id = new Guid("20f18cd7-07ca-407d-9fc0-7bad9fd7042d"),
                            Beskrivelse = "mark- og bunnsystemer",
                            Kode = "MB"
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

                    b.Property<Guid>("HovedtypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HovedtypegruppeId")
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

                    b.HasIndex("HovedtypeId");

                    b.HasIndex("HovedtypegruppeId");

                    b.HasIndex("VersionId");

                    b.ToTable("Undertype");
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Grunntype", b =>
                {
                    b.HasOne("NiN3KodeAPI.Entities.Domene", "Version")
                        .WithMany()
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

                    b.HasOne("NiN3KodeAPI.Entities.Hovedtype", "Hovedtype")
                        .WithMany()
                        .HasForeignKey("HovedtypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NiN3KodeAPI.Entities.Hovedtypegruppe", "Hovedtypegruppe")
                        .WithMany()
                        .HasForeignKey("HovedtypegruppeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NiN3KodeAPI.Entities.Domene", "Version")
                        .WithMany()
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grunntype");

                    b.Navigation("Hovedtype");

                    b.Navigation("Hovedtypegruppe");

                    b.Navigation("Version");
                });
#pragma warning restore 612, 618
        }
    }
}
