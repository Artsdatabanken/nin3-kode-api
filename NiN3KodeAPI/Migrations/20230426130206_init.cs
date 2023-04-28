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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Navn = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_domene", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ecosystnivå",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ecosystnivå", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maalestokk",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maalestokk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prosedyrekategori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prosedyrekategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Typekategori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typekategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Typekategori2",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typekategori2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Typekategori3",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typekategori3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grunntype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Hovedtype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Hovedtypegruppe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EcosystnivaaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypekategoriId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Typekategori2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                        name: "FK_Type_Ecosystnivå_EcosystnivaaId",
                        column: x => x.EcosystnivaaId,
                        principalTable: "Ecosystnivå",
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Undertype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HovedtypegruppeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HovedtypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GrunntypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Undertype_Hovedtype_HovedtypeId",
                        column: x => x.HovedtypeId,
                        principalTable: "Hovedtype",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Undertype_Hovedtypegruppe_HovedtypegruppeId",
                        column: x => x.HovedtypegruppeId,
                        principalTable: "Hovedtypegruppe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Ecosystnivå",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("11c7ada4-87df-41e2-97f7-98201c93a1ac"), "abiotisk", "A" },
                    { new Guid("8f4f79e4-4bc8-49ea-a491-176b4aa0b565"), "økodiversitet", "C" },
                    { new Guid("aa29179e-5055-4f62-b7ac-73dad8fa6330"), "biotisk", "B" }
                });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("106a357d-6ea6-4c36-aaff-66b6b397ccd0"), "grunntype", "G" },
                    { new Guid("4d978e1f-5922-48ad-92a5-1f00d38c452f"), "kartleggingsenhet tilpasset 1:100 000", "100K" },
                    { new Guid("4f462294-d679-40b5-9d4b-390f4ec5c9eb"), "kartleggingsenhet tilpasset 1:10 000", "010K" },
                    { new Guid("547c5e0b-186b-4f1b-bc3a-d842073be832"), "kartleggingsenhet tilpasset 1:20 000", "020K" },
                    { new Guid("810c297f-3173-45fb-812e-25fc31bbf285"), "kartleggingsenhet tilpasset 1:50 000", "050K" },
                    { new Guid("a8b5a81f-7ed6-43c9-8d2d-e25c957e5ae0"), "kartleggingsenhet tilpasset 1:5000", "005K" }
                });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("0905bb19-6d75-4c77-8fd1-3acef420dba9"), "O", "O" },
                    { new Guid("26838b8c-da4a-43b0-958e-bae954e33ae7"), "B", "B" },
                    { new Guid("6cd02757-f959-4347-98f6-c7cb78ba41b2"), "M", "M" },
                    { new Guid("762b2b1e-f204-42dc-bdd3-06b462cc52d8"), "G", "G" },
                    { new Guid("7c061b16-048e-4af9-9be9-8e1111bfe019"), "A", "A" },
                    { new Guid("8ac0b7b9-95f0-4fd4-bd3b-1deaaa9d22f6"), "I", "I" },
                    { new Guid("8ae20e55-181c-4cf2-8402-60b10c6dd54c"), "L", "L" },
                    { new Guid("8b8d6124-3281-401c-932b-087edd5cce4c"), "K", "K" },
                    { new Guid("ae5b4f06-c378-4470-8db8-e86534a31cf1"), "N", "N" },
                    { new Guid("b554a112-db5d-40e6-bf23-bf392afecc61"), "E", "E" },
                    { new Guid("c25a75c7-aa35-47be-90b4-e3faf3d69e07"), "C", "C" },
                    { new Guid("cdbf7ece-3dd9-4b49-bfd7-777327e3135e"), "F", "F" },
                    { new Guid("e72f3e05-20aa-4fb4-ae35-1537c74830e4"), "H", "H" },
                    { new Guid("f2db4103-5bc1-45e5-84b6-6c95eee7cb95"), "D", "D" },
                    { new Guid("f657ad4d-a0d5-4211-a1d2-f120b2aa4b9d"), "J", "J" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("09cb2cb3-42c5-4aca-8a0b-7b916ee749d6"), "primært økodiversitetsnivå", "PE" },
                    { new Guid("7b972e3c-f2c9-4ee6-a60e-d9ab9ca597f5"), "landformvariasjon", "LV" },
                    { new Guid("bc067a1b-756f-4141-8007-ef09e5942ef3"), "sekundært økodiversitetsnivå", "SE" },
                    { new Guid("cb1383be-2090-40b4-984a-7bc8ad8dada7"), "marine vannmasser", "MV" },
                    { new Guid("f6f4d140-7c8a-4720-8ae2-5a80e347ccf1"), "livsmedium", "LI" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("0de07b92-5d22-45a5-a607-b7ee3087ecdb"), "landformer i fast fjell og løsmasser", "FL" },
                    { new Guid("0e4388f7-00ea-4118-aa74-49dd87940914"), "natursystem", "NA" },
                    { new Guid("4e8416d0-8dca-45ee-88d0-6d5b6738686c"), "bremassiv", "BM" },
                    { new Guid("902b89c5-4b5a-4f6d-8a6f-ca077315e862"), "landskapstype", "LA" },
                    { new Guid("f24b611d-8cb9-4586-ab58-46aec19190ea"), "torvmarksmassiv", "TM" },
                    { new Guid("f938f305-7b43-44db-876d-d0ef171cd00c"), "elveløp", "EL" },
                    { new Guid("faaaae2d-a94e-4612-ac6c-3d8f8a9ec3cb"), "naturkompleks", "NK" },
                    { new Guid("faab5b3c-eb86-418a-9ec8-95415ba2ca15"), "innsjøbasseng", "IB" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("19713000-5712-4a91-8f87-0cb906e83004"), "vannmassesystemer", "VM" },
                    { new Guid("20c9b7ea-d683-4a3e-8fa9-87b40af1f724"), "mark- og bunnsystemer", "MB" }
                });

            migrationBuilder.InsertData(
                table: "domene",
                columns: new[] { "Id", "Navn" },
                values: new object[] { new Guid("3ce9268b-ea16-4185-a24c-44adf835e99d"), "3.0" });

            migrationBuilder.CreateIndex(
                name: "IX_Grunntype_VersionId",
                table: "Grunntype",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Hovedtype_VersionId",
                table: "Hovedtype",
                column: "VersionId");

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
                name: "IX_Undertype_HovedtypegruppeId",
                table: "Undertype",
                column: "HovedtypegruppeId");

            migrationBuilder.CreateIndex(
                name: "IX_Undertype_HovedtypeId",
                table: "Undertype",
                column: "HovedtypeId");

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
                name: "Prosedyrekategori");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropTable(
                name: "Typekategori3");

            migrationBuilder.DropTable(
                name: "Undertype");

            migrationBuilder.DropTable(
                name: "Ecosystnivå");

            migrationBuilder.DropTable(
                name: "Typekategori");

            migrationBuilder.DropTable(
                name: "Typekategori2");

            migrationBuilder.DropTable(
                name: "Grunntype");

            migrationBuilder.DropTable(
                name: "Hovedtype");

            migrationBuilder.DropTable(
                name: "Hovedtypegruppe");

            migrationBuilder.DropTable(
                name: "domene");
        }
    }
}
