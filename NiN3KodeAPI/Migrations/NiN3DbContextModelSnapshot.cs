﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NiN3KodeAPI.DbContexts;

#nullable disable

namespace NiN3KodeAPI.Migrations
{
    [DbContext(typeof(NiN3DbContext))]
    partial class NiN3DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.15");

            modelBuilder.Entity("NiN3KodeAPI.Entities.Domene", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Domene");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8024a183-9cce-4d61-bea2-6fec9c207ec9"),
                            Navn = "3.0"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Grunntype", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Delkode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("HovedtypeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProsedyrekategoriId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("VersionId")
                        .HasColumnType("TEXT");

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
                        .HasColumnType("TEXT");

                    b.Property<string>("Delkode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("HovedtypegruppeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProsedyrekategoriId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("VersionId")
                        .HasColumnType("TEXT");

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
                        .HasColumnType("TEXT");

                    b.Property<string>("Delkode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Typekategori2Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("VersionId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Typekategori2Id");

                    b.HasIndex("VersionId");

                    b.ToTable("Hovedtypegruppe");
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Ecosystnivaa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Ecosystnivaa");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4fe545c7-17a7-4f10-83e3-244c65307a23"),
                            Beskrivelse = "abiotisk",
                            Kode = "A"
                        },
                        new
                        {
                            Id = new Guid("503bd8e4-d781-48b9-b227-21e005a29af6"),
                            Beskrivelse = "biotisk",
                            Kode = "B"
                        },
                        new
                        {
                            Id = new Guid("3b1dab44-8562-41bf-a4b6-22f89c0824a2"),
                            Beskrivelse = "økodiversitet",
                            Kode = "C"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Maalestokk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Maalestokk");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a302a814-e5e7-4c36-a609-efb83b52ea29"),
                            Beskrivelse = "grunntype",
                            Kode = "G"
                        },
                        new
                        {
                            Id = new Guid("e5a04723-6a38-4867-b7ab-6d97701b8dd1"),
                            Beskrivelse = "kartleggingsenhet tilpasset 1:5000",
                            Kode = "005K"
                        },
                        new
                        {
                            Id = new Guid("7c6c6c11-2d99-4b64-a645-67043c2a3628"),
                            Beskrivelse = "kartleggingsenhet tilpasset 1:10 000",
                            Kode = "010K"
                        },
                        new
                        {
                            Id = new Guid("9f11090a-a415-49b7-89ea-4f213661227e"),
                            Beskrivelse = "kartleggingsenhet tilpasset 1:20 000",
                            Kode = "020K"
                        },
                        new
                        {
                            Id = new Guid("41a1bd99-d666-49e2-ac31-1f1bb7207705"),
                            Beskrivelse = "kartleggingsenhet tilpasset 1:50 000",
                            Kode = "050K"
                        },
                        new
                        {
                            Id = new Guid("a2afc6ca-6d2f-4bcb-8bfc-ba7450ed7b37"),
                            Beskrivelse = "kartleggingsenhet tilpasset 1:100 000",
                            Kode = "100K"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Prosedyrekategori", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Prosedyrekategori");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8b6bf6f2-3f34-4fb2-b618-ea1e8a560785"),
                            Beskrivelse = "A",
                            Kode = "A"
                        },
                        new
                        {
                            Id = new Guid("21dbd023-f1a8-4dba-8de8-1c846779c106"),
                            Beskrivelse = "B",
                            Kode = "B"
                        },
                        new
                        {
                            Id = new Guid("07f6cbd4-77c6-43af-a3d7-6ee24b1126ea"),
                            Beskrivelse = "C",
                            Kode = "C"
                        },
                        new
                        {
                            Id = new Guid("c96ea63a-a34c-4b9c-93e6-9fd4b11adbc8"),
                            Beskrivelse = "D",
                            Kode = "D"
                        },
                        new
                        {
                            Id = new Guid("f53e33d5-44ad-4415-9555-da15b951af56"),
                            Beskrivelse = "E",
                            Kode = "E"
                        },
                        new
                        {
                            Id = new Guid("afc5cbfe-2f87-4f6f-b337-7b75bbeda21b"),
                            Beskrivelse = "F",
                            Kode = "F"
                        },
                        new
                        {
                            Id = new Guid("7a4ebba8-037d-4738-a30a-eb5ac910d1b9"),
                            Beskrivelse = "G",
                            Kode = "G"
                        },
                        new
                        {
                            Id = new Guid("e724609a-b036-4119-b5ba-3f583316d01b"),
                            Beskrivelse = "H",
                            Kode = "H"
                        },
                        new
                        {
                            Id = new Guid("f36d6f31-dc4c-46d8-a366-e0cb80d92f8f"),
                            Beskrivelse = "I",
                            Kode = "I"
                        },
                        new
                        {
                            Id = new Guid("dd2db91f-9bab-41bf-896e-2bc897d56b33"),
                            Beskrivelse = "J",
                            Kode = "J"
                        },
                        new
                        {
                            Id = new Guid("ae93b65b-f246-43f8-b625-889f06adfaaf"),
                            Beskrivelse = "K",
                            Kode = "K"
                        },
                        new
                        {
                            Id = new Guid("8e077c5c-a072-47a6-8c1c-66a0f8856cb2"),
                            Beskrivelse = "L",
                            Kode = "L"
                        },
                        new
                        {
                            Id = new Guid("e4678e8d-4e8c-4c6f-beae-9251734f648e"),
                            Beskrivelse = "M",
                            Kode = "M"
                        },
                        new
                        {
                            Id = new Guid("5af5138f-4e08-4288-ac6d-9efc76ae7940"),
                            Beskrivelse = "N",
                            Kode = "N"
                        },
                        new
                        {
                            Id = new Guid("f5d32d52-8e66-42b5-bf66-2faacfe8c0c4"),
                            Beskrivelse = "O",
                            Kode = "O"
                        },
                        new
                        {
                            Id = new Guid("97b86afb-73f0-4a9a-b7db-6d97c9e949ca"),
                            Beskrivelse = "Ikke angitt",
                            Kode = "0"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Typekategori", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Typekategori");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e6ba9540-d33c-4313-a1f2-2c52ecd384a6"),
                            Beskrivelse = "livsmedium",
                            Kode = "LI"
                        },
                        new
                        {
                            Id = new Guid("087daf6d-1df2-4d46-bdac-d5269c7880dd"),
                            Beskrivelse = "landformvariasjon",
                            Kode = "LV"
                        },
                        new
                        {
                            Id = new Guid("a9dc5d91-98cd-4dc1-b9c9-0dc7d3c6c2ce"),
                            Beskrivelse = "marine vannmasser",
                            Kode = "MV"
                        },
                        new
                        {
                            Id = new Guid("7635a7db-9895-4429-b304-88ed1e1821ec"),
                            Beskrivelse = "primært økodiversitetsnivå",
                            Kode = "PE"
                        },
                        new
                        {
                            Id = new Guid("6943b4e3-2cfd-4303-bd3c-d5bd938aab01"),
                            Beskrivelse = "sekundært økodiversitetsnivå",
                            Kode = "SE"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Typekategori2", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Typekategori2");

                    b.HasData(
                        new
                        {
                            Id = new Guid("636fafbb-fa09-42d6-9eea-5eb521971323"),
                            Beskrivelse = "bremassiv",
                            Kode = "BM"
                        },
                        new
                        {
                            Id = new Guid("d8c3357c-af29-4fc0-b03c-b9daade3857b"),
                            Beskrivelse = "elveløp",
                            Kode = "EL"
                        },
                        new
                        {
                            Id = new Guid("ae9e496b-b044-4ef5-8cce-d8a8a2b027d0"),
                            Beskrivelse = "landformer i fast fjell og løsmasser",
                            Kode = "FL"
                        },
                        new
                        {
                            Id = new Guid("2b37ebfc-befa-40e7-91cf-903af973eda6"),
                            Beskrivelse = "innsjøbasseng",
                            Kode = "IB"
                        },
                        new
                        {
                            Id = new Guid("eaa20eeb-981f-4abc-9182-47a2ad8b6623"),
                            Beskrivelse = "landskapstype",
                            Kode = "LA"
                        },
                        new
                        {
                            Id = new Guid("e33a6d9e-fff1-4d5a-8141-e71451ac2f39"),
                            Beskrivelse = "natursystem",
                            Kode = "NA"
                        },
                        new
                        {
                            Id = new Guid("b0c55c5f-2d66-4449-acae-0069d7400d0b"),
                            Beskrivelse = "naturkompleks",
                            Kode = "NK"
                        },
                        new
                        {
                            Id = new Guid("a1389c5d-76a3-4b71-8fd3-d147b6ac961d"),
                            Beskrivelse = "torvmarksmassiv",
                            Kode = "TM"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Typekategori3", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Typekategori3");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b2c048cd-ff92-4b2d-a0f8-e2a8a03146a7"),
                            Beskrivelse = "vannmassesystemer",
                            Kode = "VM"
                        },
                        new
                        {
                            Id = new Guid("d26897b7-6628-4143-943a-387e98b368e8"),
                            Beskrivelse = "mark- og bunnsystemer",
                            Kode = "MB"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Variabelkategori", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Variabelkategori");

                    b.HasData(
                        new
                        {
                            Id = new Guid("485f8f84-cefd-4caa-a2dd-51edb30f93ff"),
                            Beskrivelse = "mennekebetinget",
                            Kode = "M"
                        },
                        new
                        {
                            Id = new Guid("56cf49b5-a7a9-4e40-82f6-66a5f7dd3a3d"),
                            Beskrivelse = "naturgitt",
                            Kode = "N"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Variabelkategori2", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Variabelkategori2");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1b241896-a567-4435-b390-2131e846cf9e"),
                            Beskrivelse = "artssammensetningsdynamikk",
                            Kode = "AD"
                        },
                        new
                        {
                            Id = new Guid("9f7024b5-c500-4196-8c85-a5a0be8b4908"),
                            Beskrivelse = "bergarter",
                            Kode = "BE"
                        },
                        new
                        {
                            Id = new Guid("7c8ff245-4e96-4962-94fd-afccb6ecaf08"),
                            Beskrivelse = "korttidsmiljøvariabel",
                            Kode = "KM"
                        },
                        new
                        {
                            Id = new Guid("ce8c5e16-4d81-45c1-a948-4c82061bad4d"),
                            Beskrivelse = "lokal miljøvariabel",
                            Kode = "LM"
                        },
                        new
                        {
                            Id = new Guid("9d85f563-c5c5-443b-b76a-949a085739cd"),
                            Beskrivelse = "landform-objekter",
                            Kode = "LO"
                        },
                        new
                        {
                            Id = new Guid("9370e320-b34b-4d6b-938b-53f8a295eb2b"),
                            Beskrivelse = "miljødynamikk",
                            Kode = "MD"
                        },
                        new
                        {
                            Id = new Guid("d55c97bf-8ae0-4947-a0b2-7b6f2ee46c13"),
                            Beskrivelse = "menneskeskapt objekt",
                            Kode = "MO"
                        },
                        new
                        {
                            Id = new Guid("940a9985-e4cb-4686-a783-0fc3c9ea7fe1"),
                            Beskrivelse = "naturgitt objekt",
                            Kode = "NO"
                        },
                        new
                        {
                            Id = new Guid("6bf7bb8a-bb0b-4535-a52a-e44835e0c888"),
                            Beskrivelse = "romlig artsfordelingsmønster",
                            Kode = "RA"
                        },
                        new
                        {
                            Id = new Guid("965fc22e-07a3-4f1a-a7d1-dacd98f7d3d5"),
                            Beskrivelse = "regional miljøvariabel",
                            Kode = "RM"
                        },
                        new
                        {
                            Id = new Guid("260b09b0-fb0f-4974-9c95-9fc73fa0b3c8"),
                            Beskrivelse = "romlig strukturvariasjon",
                            Kode = "RS"
                        },
                        new
                        {
                            Id = new Guid("19d2c01c-627e-4166-94dc-9d058b228ca6"),
                            Beskrivelse = "strukturerende og funksjonelle artsgrupper",
                            Kode = "SA"
                        },
                        new
                        {
                            Id = new Guid("8ac3b854-c67f-4d70-8a8e-d02a9d9eae34"),
                            Beskrivelse = "terrengformvariasjon",
                            Kode = "TF"
                        },
                        new
                        {
                            Id = new Guid("c2f51e8e-0285-4256-a6ff-a451067a3800"),
                            Beskrivelse = "vertikal struktur",
                            Kode = "VS"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Lookupdata.Variabeltype", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Variabeltype");

                    b.HasData(
                        new
                        {
                            Id = new Guid("16fbff5b-5af3-4796-ab13-b9a7faa3c5dd"),
                            Beskrivelse = "enkel, ikke-ordnet faktorvariabel",
                            Kode = "FE"
                        },
                        new
                        {
                            Id = new Guid("bbf1dc54-94e8-4213-8993-f65bd0e7c143"),
                            Beskrivelse = "kompleks, ikke-ordnet faktorvariabel",
                            Kode = "FK"
                        },
                        new
                        {
                            Id = new Guid("e01545d2-20c8-47b9-b88d-e6b42a7a465e"),
                            Beskrivelse = "enkel gradient",
                            Kode = "GE"
                        },
                        new
                        {
                            Id = new Guid("31d28776-c8df-42b0-b55d-a51b79175358"),
                            Beskrivelse = "kompleks gradient",
                            Kode = "GK"
                        });
                });

            modelBuilder.Entity("NiN3KodeAPI.Entities.Type", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EcosystnivaaId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Typekategori2Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TypekategoriId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("VersionId")
                        .HasColumnType("TEXT");

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
                        .HasColumnType("TEXT");

                    b.Property<Guid>("GrunntypeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("VersionId")
                        .HasColumnType("TEXT");

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
