using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NiN3KodeAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Domene",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Navn = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domene", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ecosystnivaa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", nullable: false),
                    Beskrivelse = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ecosystnivaa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maalestokk",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", nullable: false),
                    Beskrivelse = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maalestokk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prosedyrekategori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", nullable: false),
                    Beskrivelse = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prosedyrekategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Typekategori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", nullable: false),
                    Beskrivelse = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typekategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Typekategori2",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", nullable: false),
                    Beskrivelse = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typekategori2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Typekategori3",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", nullable: false),
                    Beskrivelse = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typekategori3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Variabelgruppe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", nullable: false),
                    Beskrivelse = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variabelgruppe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Variabelkategori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", nullable: false),
                    Beskrivelse = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variabelkategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Variabelkategori2",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", nullable: false),
                    Beskrivelse = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variabelkategori2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Variabeltype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", nullable: false),
                    Beskrivelse = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variabeltype", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hovedtypegruppe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Typekategori2Id = table.Column<Guid>(type: "TEXT", nullable: true),
                    Delkode = table.Column<string>(type: "TEXT", nullable: false),
                    VersionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Navn = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hovedtypegruppe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hovedtypegruppe_Domene_VersionId",
                        column: x => x.VersionId,
                        principalTable: "Domene",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hovedtypegruppe_Typekategori2_Typekategori2Id",
                        column: x => x.Typekategori2Id,
                        principalTable: "Typekategori2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EcosystnivaaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TypekategoriId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Typekategori2Id = table.Column<Guid>(type: "TEXT", nullable: true),
                    Kode = table.Column<string>(type: "TEXT", nullable: false),
                    VersionId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Type_Domene_VersionId",
                        column: x => x.VersionId,
                        principalTable: "Domene",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Type_Ecosystnivaa_EcosystnivaaId",
                        column: x => x.EcosystnivaaId,
                        principalTable: "Ecosystnivaa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Type_Typekategori_TypekategoriId",
                        column: x => x.TypekategoriId,
                        principalTable: "Typekategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Type_Typekategori2_Typekategori2Id",
                        column: x => x.Typekategori2Id,
                        principalTable: "Typekategori2",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hovedtype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Delkode = table.Column<string>(type: "TEXT", nullable: false),
                    ProsedyrekategoriId = table.Column<Guid>(type: "TEXT", nullable: false),
                    HovedtypegruppeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    VersionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Navn = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hovedtype", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hovedtype_Domene_VersionId",
                        column: x => x.VersionId,
                        principalTable: "Domene",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hovedtype_Hovedtypegruppe_HovedtypegruppeId",
                        column: x => x.HovedtypegruppeId,
                        principalTable: "Hovedtypegruppe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hovedtype_Prosedyrekategori_ProsedyrekategoriId",
                        column: x => x.ProsedyrekategoriId,
                        principalTable: "Prosedyrekategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grunntype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Delkode = table.Column<string>(type: "TEXT", nullable: false),
                    ProsedyrekategoriId = table.Column<Guid>(type: "TEXT", nullable: false),
                    HovedtypeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    VersionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Navn = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grunntype", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grunntype_Domene_VersionId",
                        column: x => x.VersionId,
                        principalTable: "Domene",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grunntype_Hovedtype_HovedtypeId",
                        column: x => x.HovedtypeId,
                        principalTable: "Hovedtype",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grunntype_Prosedyrekategori_ProsedyrekategoriId",
                        column: x => x.ProsedyrekategoriId,
                        principalTable: "Prosedyrekategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Undertype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    GrunntypeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    VersionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Navn = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Undertype", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Undertype_Domene_VersionId",
                        column: x => x.VersionId,
                        principalTable: "Domene",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Undertype_Grunntype_GrunntypeId",
                        column: x => x.GrunntypeId,
                        principalTable: "Grunntype",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Domene",
                columns: new[] { "Id", "Navn" },
                values: new object[] { new Guid("c7eec7d9-b13e-406c-aa3b-3b198adb41aa"), "3.0" });

            migrationBuilder.InsertData(
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("0fec972d-77b0-426f-91a0-df4d17dd3dbe"), "biotisk", "B" });

            migrationBuilder.InsertData(
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("96b20e46-a278-44c1-9e3e-8abb9932be94"), "abiotisk", "A" });

            migrationBuilder.InsertData(
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b55b37b4-2ea0-4f28-b1c5-c1aee6c61214"), "økodiversitet", "C" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("089c7579-e025-41cd-a035-5e546d82568e"), "grunntype", "G" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("6f8c8872-d333-407c-957d-279cc89c6158"), "kartleggingsenhet tilpasset 1:5000", "005K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("8125ce97-80ab-4558-bb82-99c8c0c62fd9"), "kartleggingsenhet tilpasset 1:100 000", "100K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("97eddcd8-ca72-4c96-a5af-79e5f5a8ddaa"), "kartleggingsenhet tilpasset 1:50 000", "050K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e4296af2-40f4-43c4-9511-5f3b644ce0fc"), "kartleggingsenhet tilpasset 1:20 000", "020K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f1cbec47-1ab7-429d-9300-bd9762011ff1"), "kartleggingsenhet tilpasset 1:10 000", "010K" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("054c7941-1064-4a15-b12d-406ed982dafe"), "E", "E" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("05bb298a-2b05-4c03-8fae-868f3611bff9"), "I", "I" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("263da5c0-868c-4e9d-8d80-bf076a76137a"), "H", "H" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("28a16dac-0aa0-4705-afb7-d294e9846271"), "L", "L" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("4db99215-08af-4b7a-a045-da827951e46c"), "J", "J" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9dfa8a3c-e6b5-4d61-8c7b-59e39d589906"), "K", "K" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("add2f130-5ba5-4b66-81e4-d8f7fd323bbd"), "B", "B" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b7aaac85-b733-45ab-ba2d-e6f18c3180ae"), "O", "O" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b9aa37b7-c6d1-40d8-bc57-3150d3001106"), "Ikke angitt", "0" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("be81020b-74c9-4500-beda-f2f9938132ad"), "N", "N" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("c38dd757-b54e-4df4-9dc7-c01f579b9e9a"), "D", "D" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d80479bf-f693-4fc3-a799-b39aa512b900"), "M", "M" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d82e90f3-ce71-46e9-87ef-845a295c8235"), "A", "A" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d98dcc37-46b0-480d-9c11-11145fb2a548"), "G", "G" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e0132d0c-f315-4ceb-b59c-54c3a524d66b"), "F", "F" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f95841ab-8a63-451e-b474-fd0020a85b60"), "C", "C" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("87bda7d2-7bd6-41a7-9e0d-216c0b836758"), "marine vannmasser", "MV" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9ec64afd-f939-4987-ba17-22e3bab0da01"), "livsmedium", "LI" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b0dbbb22-f713-4610-a949-1723e1932285"), "sekundært økodiversitetsnivå", "SE" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("de3acdcf-703b-41eb-810a-373eb449f95f"), "primært økodiversitetsnivå", "PE" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f78d8f6f-89b2-4287-bb10-826d4f469ab3"), "landformvariasjon", "LV" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("16ae3bdf-2e3e-41fd-bd89-d14c4a1c09d0"), "torvmarksmassiv", "TM" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("361536c4-9fc4-450d-97b1-f98d264475e2"), "landformer i fast fjell og løsmasser", "FL" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("367422ec-6b17-412d-9faa-585c0c30b68b"), "landskapstype", "LA" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("3a1b3bf4-4874-4ccf-9fe4-768a3bbd614c"), "natursystem", "NA" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("3b27d436-9812-42aa-a35b-c78f8741b58e"), "naturkompleks", "NK" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("62e7845e-3712-4fa5-9dec-71a7b9435a92"), "innsjøbasseng", "IB" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("63b4c148-db25-4728-b99b-b2bdde86bb32"), "bremassiv", "BM" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("70ea6a19-31e4-41dc-8cd7-1cd10015d189"), "elveløp", "EL" });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("24c92a7f-51fe-4899-8aaf-b3693971150f"), "mark- og bunnsystemer", "MB" });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("7223d990-511d-4b36-a70a-d9910256a499"), "vannmassesystemer", "VM" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("0114751d-f3ce-45eb-b076-443870b39489"), "JB jordbruksrelaterte egenskaper", "JB jordbruksrelaterte egenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("01b45ec5-66e7-45d9-af2d-f19ccda58138"), "TL tre med spesielt livsmedium", "TL tre med spesielt livsmedium" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("04754c88-f97a-40d5-8231-fb3ea9cc2869"), "SB skogbruksrelaterte egeskaper", "SB skogbruksrelaterte egeskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("088f8c59-5208-44cb-9969-9b73cd769c72"), "GE generelle egenskaper", "GE generelle egenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("13a752a7-bc6f-4870-bd74-c9f4e94d2b79"), "OT menneskeskapt terrestrisk objekt", "OT menneskeskapt terrestrisk objekt" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("15c28f3e-e858-4c3b-8cc1-a4f2289c1ec0"), "EO andre naturgitte elveløpsobjekter", "EO andre naturgitte elveløpsobjekter" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("20d8984b-f8d3-4d25-aca9-5c393cb24ae2"), "AM artsforekomst/-mengde", "AM artsforekomst/-mengde" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("22063ae1-bc94-4dec-941d-3d010a2daf10"), "DR relativ sammensetning av død ved", "DR relativ sammensetning av død ved" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("42b2d6da-b5e1-415d-9fac-b184ed19a4e5"), "SB skogbruksegenskaper", "SB skogbruksegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("46527856-dbb9-45b3-bf87-30c9bc242689"), "TC torvmarksmassiv: mikrostruktur", "TC torvmarksmassiv: mikrostruktur" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("4bfb6464-e18a-4c59-9684-41bab4df8492"), "TE generelle treegenskaper", "TE generelle treegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("4efa5e5a-ba54-4a8b-bfb7-e73bc24e42b0"), "TG gammelt tre", "TG gammelt tre" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("564e10db-ef2e-48e3-bdc7-4a9f8d39752b"), "DL liggende død ved (læger)", "DL liggende død ved (læger)" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("5b28eec2-897c-4f6f-8fd4-576a0e2f3664"), "AG artsgruppesammensetning", "AG artsgruppesammensetning" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("60b93bef-0f4c-4b38-884c-665f894527d7"), "GT generelle terrengegenskaper", "GT generelle terrengegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("79712a28-2240-4e8b-8f51-2e86844d3c38"), "BE bremassivegenskaper", "BE bremassivegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("829adb46-c246-461d-b2b7-e5b485b68b30"), "SB skogbruksrelaterte egenskaper", "SB skogbruksrelaterte egenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("829c32cd-0bb9-44bb-8787-cf80881388cb"), "TS trær med gitt størrelse", "TS trær med gitt størrelse" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("85cdbdae-f373-4944-830a-99942e3b681a"), "SE skogegenskaper", "SE skogegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("8625ae4c-d982-4810-adad-148baabb9d1c"), "BO naturgitte breobjekter", "BO naturgitte breobjekter" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("87c91243-0880-4ccf-8d0f-d1313e3aa826"), "IO naturgitte innsjøobjekter", "IO naturgitte innsjøobjekter" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("94cf4a08-85c6-4683-a6c5-a59e8cadabd1"), "SU suksesjonsrelaterte egenskaper", "SU suksesjonsrelaterte egenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9b0713e8-bd89-4e59-a7c8-fea65aac1e0f"), "IE innsjøbassengegenskaper", "IE innsjøbassengegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9fd78342-24b1-4305-9cf0-5655d3914c45"), "FA fremmedartsegenskaper", "FA fremmedartsegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a10c51bb-e390-445a-94e8-b514ebb73970"), "AR relativ del-artsgruppesammensetning", "AR relativ del-artsgruppesammensetning" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a28d4c7c-0791-4060-9d78-516d3194c1e0"), "DG stående død ved (gadder)", "DG stående død ved (gadder)" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a93d07a6-8ed8-49f5-a03b-36cb3d7ae22d"), "HE havegenskaper", "HE havegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a99ea446-e8df-4b4d-a041-f8f3c14e1207"), "W W", "W W" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("c52f584f-4f6c-45b6-8af5-0c8df1ec9eca"), "EE elveløpsegenskaper", "EE elveløpsegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("c55dbb6b-3e50-408e-809f-8fe3f3d2efe6"), "OE menneskeskapt objekt i elv", "OE menneskeskapt objekt i elv" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("ca7b711a-e303-457a-8778-434e9a8d7466"), "W artsforekomst/-mengde", "W artsforekomst/-mengde" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d56e69ef-8c8a-4db3-9050-2b09c30c6cf5"), "EB elvebanker", "EB elvebanker" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d58d296c-31d5-4112-88e1-d5d7050091d5"), "TM trær med gitt minstestørrelse", "TM trær med gitt minstestørrelse" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("dd40a005-33a3-4ccd-a832-52c2bb711d18"), "OI menneskeskapt objekt i innsjø eller til havs", "OI menneskeskapt objekt i innsjø eller til havs" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e461f3ac-c531-434c-9e6a-77982684899b"), "TA torvmarksmassiv: myrsegment", "TA torvmarksmassiv: myrsegment" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f4f94927-f09d-45ea-b217-6204d74b7183"), "TB torvmarksmassiv: myrstruktur", "TB torvmarksmassiv: myrstruktur" });

            migrationBuilder.InsertData(
                table: "Variabelkategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("1eeebb71-c29f-4065-a7de-205d5126b78b"), "mennekebetinget", "M" });

            migrationBuilder.InsertData(
                table: "Variabelkategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("cc0bf7f2-c01f-46ef-965f-9b6c3d454fc5"), "naturgitt", "N" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("15483961-5c64-4e44-90c4-d39d89debf3a"), "menneskeskapt objekt", "MO" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("15c8dd28-c9c6-404c-a8be-b7a8ebdbea5a"), "bergarter", "BE" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("25af7df3-0b40-4e35-a81d-a64f9a933b72"), "lokal miljøvariabel", "LM" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("26f6c558-67bb-4b70-95d2-a1cff40089f3"), "terrengformvariasjon", "TF" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("2ecf332b-f870-4255-a51f-5af6c696b575"), "romlig artsfordelingsmønster", "RA" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("314f0a2c-ec2b-42c6-b109-7b8dbfa5b910"), "vertikal struktur", "VS" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("56d69a76-c974-4d42-9062-f2b2f439d48a"), "romlig strukturvariasjon", "RS" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("64bdb6f3-0966-40d0-96e9-deb88d3270ac"), "artssammensetningsdynamikk", "AD" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("704c2155-cd00-462a-941c-fa4277b3b697"), "miljødynamikk", "MD" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b3e1ee81-752b-4f3a-9269-94449db3bd18"), "landform-objekter", "LO" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("c1d5bb3b-c0a9-4e1d-9ccf-c0c772a11b0e"), "strukturerende og funksjonelle artsgrupper", "SA" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("cc9a1c46-5883-4f55-b7bd-b0590dd3af7c"), "regional miljøvariabel", "RM" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("de9f9a88-9efc-40c1-9b76-acf353349afc"), "korttidsmiljøvariabel", "KM" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("ec46a7db-2d35-4f74-aec1-6040537a6d53"), "naturgitt objekt", "NO" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("29831898-1e63-43b0-b8d8-6efea6e3747b"), "enkel gradient", "GE" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("397eee3e-3a4f-43e6-9c34-ab3d8cc11107"), "kompleks, ikke-ordnet faktorvariabel", "FK" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a27a16c7-cccb-4e25-92f9-5b88c0b5202c"), "enkel, ikke-ordnet faktorvariabel", "FE" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("df99195e-e463-4151-9ed7-48d8edb04cbe"), "kompleks gradient", "GK" });

            migrationBuilder.CreateIndex(
                name: "IX_Grunntype_HovedtypeId",
                table: "Grunntype",
                column: "HovedtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Grunntype_ProsedyrekategoriId",
                table: "Grunntype",
                column: "ProsedyrekategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Grunntype_VersionId",
                table: "Grunntype",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Hovedtype_HovedtypegruppeId",
                table: "Hovedtype",
                column: "HovedtypegruppeId");

            migrationBuilder.CreateIndex(
                name: "IX_Hovedtype_ProsedyrekategoriId",
                table: "Hovedtype",
                column: "ProsedyrekategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Hovedtype_VersionId",
                table: "Hovedtype",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Hovedtypegruppe_Typekategori2Id",
                table: "Hovedtypegruppe",
                column: "Typekategori2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hovedtypegruppe_VersionId",
                table: "Hovedtypegruppe",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Type_EcosystnivaaId",
                table: "Type",
                column: "EcosystnivaaId");

            migrationBuilder.CreateIndex(
                name: "IX_Type_Typekategori2Id",
                table: "Type",
                column: "Typekategori2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Type_TypekategoriId",
                table: "Type",
                column: "TypekategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Type_VersionId",
                table: "Type",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Undertype_GrunntypeId",
                table: "Undertype",
                column: "GrunntypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Undertype_VersionId",
                table: "Undertype",
                column: "VersionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maalestokk");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropTable(
                name: "Typekategori3");

            migrationBuilder.DropTable(
                name: "Undertype");

            migrationBuilder.DropTable(
                name: "Variabelgruppe");

            migrationBuilder.DropTable(
                name: "Variabelkategori");

            migrationBuilder.DropTable(
                name: "Variabelkategori2");

            migrationBuilder.DropTable(
                name: "Variabeltype");

            migrationBuilder.DropTable(
                name: "Ecosystnivaa");

            migrationBuilder.DropTable(
                name: "Typekategori");

            migrationBuilder.DropTable(
                name: "Grunntype");

            migrationBuilder.DropTable(
                name: "Hovedtype");

            migrationBuilder.DropTable(
                name: "Hovedtypegruppe");

            migrationBuilder.DropTable(
                name: "Prosedyrekategori");

            migrationBuilder.DropTable(
                name: "Domene");

            migrationBuilder.DropTable(
                name: "Typekategori2");
        }
    }
}
