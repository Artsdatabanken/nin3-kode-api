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
                name: "domene",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Navn = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_domene", x => x.Id);
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
                        name: "FK_Hovedtypegruppe_domene_VersionId",
                        column: x => x.VersionId,
                        principalTable: "domene",
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
                        name: "FK_Type_domene_VersionId",
                        column: x => x.VersionId,
                        principalTable: "domene",
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
                        name: "FK_Hovedtype_domene_VersionId",
                        column: x => x.VersionId,
                        principalTable: "domene",
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
                        name: "FK_Grunntype_domene_VersionId",
                        column: x => x.VersionId,
                        principalTable: "domene",
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
                        name: "FK_Undertype_domene_VersionId",
                        column: x => x.VersionId,
                        principalTable: "domene",
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
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d48cf3ac-8509-4ab6-8ecb-f29025d40bd8"), "biotisk", "B" });

            migrationBuilder.InsertData(
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e47dd8c9-16df-42a6-a248-320bbc307f79"), "abiotisk", "A" });

            migrationBuilder.InsertData(
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e9170f42-4d3f-44e2-b631-5dbea4e1f973"), "økodiversitet", "C" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("31bc692b-644b-414b-9c0b-217d74138012"), "kartleggingsenhet tilpasset 1:20 000", "020K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("51ef03cc-4320-4b9b-9dfc-08e9f261bc6f"), "grunntype", "G" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("704c6421-a973-4c5c-abc7-cb45fc809a34"), "kartleggingsenhet tilpasset 1:10 000", "010K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("88fb5aa2-318f-4a9d-a985-9d1cd629fcdd"), "kartleggingsenhet tilpasset 1:5000", "005K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a6fc6e66-d97a-4d74-ad48-cdcf7e6f1352"), "kartleggingsenhet tilpasset 1:100 000", "100K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d5c512b6-6bee-4ee6-89c5-a8ebb383b9b0"), "kartleggingsenhet tilpasset 1:50 000", "050K" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("025a6f8d-7740-4795-90c0-7a0f04365312"), "L", "L" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("15c975ef-3c89-4d52-ae04-8356a3e71f34"), "I", "I" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("1bb17250-3ce9-4904-90e7-c1237aa0b68f"), "N", "N" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("24764e8b-467f-44e7-9a6a-ae251a4ff387"), "C", "C" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("2e078b40-e753-4593-a107-bf95839c19c6"), "F", "F" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("5124b361-30d5-4b8c-a12b-72b187e380d3"), "A", "A" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("68993acf-8a65-488b-8c68-61d625b3485a"), "D", "D" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("735c34bc-4e74-456c-ab0b-4ff0c7686e3c"), "B", "B" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("767234ce-7ed3-4b7e-950b-8c3854638843"), "J", "J" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("8007299d-d8a5-4359-8f05-2e3015bbbfb7"), "H", "H" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b0874293-81c6-4035-95d5-ce1eeee09301"), "G", "G" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("c6b92a64-d5a0-477f-ac7a-3eafbeee4c7b"), "E", "E" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("c8442a83-01e3-47c2-bc67-7557b4ce1c7a"), "Ikke angitt", "0" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d06af615-9017-487d-9844-be7dc180b71b"), "K", "K" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e8392a15-ca81-4242-88cd-6fc6ec5dff09"), "O", "O" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("edba2ec1-16ba-473d-b8d7-afc636f97988"), "M", "M" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("44cddbb8-5b24-43f9-83ad-87257efdbc7c"), "landformvariasjon", "LV" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("4aa41be6-612c-438d-9bcf-ddfbd01ff3ae"), "marine vannmasser", "MV" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("6fcffe91-e73f-49e4-9eb8-beb1a5063e48"), "livsmedium", "LI" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a367c676-1a23-41cf-9b48-0ce373f70aa5"), "primært økodiversitetsnivå", "PE" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("fec80991-2205-4ce7-9a62-93f266240d32"), "sekundært økodiversitetsnivå", "SE" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("1e950f1c-ab51-4626-8690-09804f41ac2f"), "innsjøbasseng", "IB" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("2cb13d3a-14da-4d73-9993-0b51ec5635f8"), "naturkompleks", "NK" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("56206b1b-cc21-4ac4-b0dd-1f73259842d4"), "natursystem", "NA" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9648dbb0-54b8-4f33-b925-de1c35a9d417"), "bremassiv", "BM" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b3e9ef52-9ea0-4177-9863-10609d155812"), "landformer i fast fjell og løsmasser", "FL" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e865b5d9-bdfb-4e84-b102-df87717a2a92"), "landskapstype", "LA" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e91f0f29-8cdb-4db3-a781-c9495b70ac8a"), "elveløp", "EL" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("fca9ee03-37c3-4a44-ba61-2938c52dc879"), "torvmarksmassiv", "TM" });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("55dc7fd4-23eb-4e7c-bf3f-e8af86a8facf"), "mark- og bunnsystemer", "MB" });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("57e2b88f-60f2-4f20-b656-2746314d52dd"), "vannmassesystemer", "VM" });

            migrationBuilder.InsertData(
                table: "Variabelkategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a6695c02-e64e-47ad-88fe-cd5da328cd49"), "naturgitt", "N" });

            migrationBuilder.InsertData(
                table: "Variabelkategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a9136dcc-b3e7-442e-8450-e6473bec3818"), "mennekebetinget", "M" });

            migrationBuilder.InsertData(
                table: "domene",
                columns: new[] { "Id", "Navn" },
                values: new object[] { new Guid("fcf22bae-136a-4ad5-812e-faf5bf93ae9c"), "3.0" });

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
                name: "Variabelkategori");

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
                name: "domene");

            migrationBuilder.DropTable(
                name: "Typekategori2");
        }
    }
}
