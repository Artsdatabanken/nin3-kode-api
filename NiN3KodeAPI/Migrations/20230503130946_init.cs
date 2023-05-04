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
                name: "Variabelkategori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variabelkategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hovedtypegruppe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Typekategori2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Delkode = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EcosystnivaaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypekategoriId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Typekategori2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hovedtype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Delkode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsedyrekategoriId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HovedtypegruppeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Delkode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsedyrekategoriId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HovedtypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                });

            migrationBuilder.InsertData(
                table: "Ecosystnivå",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("3fc60e8e-f215-44b3-acf9-4045e79a604f"), "abiotisk", "A" },
                    { new Guid("65316bb7-a9e7-4e15-8909-1296bc0f1382"), "biotisk", "B" },
                    { new Guid("a9f6713b-7d73-400c-a25c-5f35c5e03b97"), "økodiversitet", "C" }
                });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("0f6cce98-cff7-4316-a054-7b80b3ceec60"), "kartleggingsenhet tilpasset 1:10 000", "010K" },
                    { new Guid("324367a8-5b5d-4f05-ac61-78dc08e176c0"), "kartleggingsenhet tilpasset 1:100 000", "100K" },
                    { new Guid("605e523d-addc-4e6e-96fa-ce891502f2ca"), "kartleggingsenhet tilpasset 1:20 000", "020K" },
                    { new Guid("8991b2f8-2899-44b7-9bba-53533c93134b"), "grunntype", "G" },
                    { new Guid("915920a6-8df0-4322-ad78-9951af8ff049"), "kartleggingsenhet tilpasset 1:50 000", "050K" },
                    { new Guid("d85ef705-3c98-4718-be20-f759f1eddbd4"), "kartleggingsenhet tilpasset 1:5000", "005K" }
                });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("0cd9da75-f9ed-4a62-9c68-01269a27bb4a"), "M", "M" },
                    { new Guid("1317df3f-cdb3-457c-b4fe-fe2bf0725868"), "Ikke angitt", "0" },
                    { new Guid("1e79f6d1-1edd-4e81-99ef-77be130fb84f"), "I", "I" },
                    { new Guid("2f3d31be-7906-4e7a-aa8e-820a197339fb"), "H", "H" },
                    { new Guid("65d2bb15-853f-4ad1-a78f-2500fa2323d2"), "B", "B" },
                    { new Guid("8b817630-adb8-4bc8-8872-4f8a840185b1"), "K", "K" },
                    { new Guid("8c59f2de-d978-4741-b5e2-a9fe063a3730"), "O", "O" },
                    { new Guid("9aa46ce5-cad3-4520-a295-f9ecd3ee21cb"), "D", "D" },
                    { new Guid("a41cbad7-114c-44dd-98d6-1b39bb4a0c17"), "J", "J" },
                    { new Guid("ae292ccd-8ec2-4474-b2c0-f47bf1723581"), "L", "L" },
                    { new Guid("c1cd9cf6-b70a-44f4-90cb-13ae92a150d6"), "F", "F" },
                    { new Guid("c3b8bcd4-9c94-466f-b341-7eb732c3043d"), "A", "A" },
                    { new Guid("daae4551-4410-4bea-b83b-4c07bd8de804"), "N", "N" },
                    { new Guid("e2399727-b248-4968-9a1d-d73876fa40a8"), "G", "G" },
                    { new Guid("e390b967-cb39-4b46-b9d5-c4fc6174c0a7"), "C", "C" },
                    { new Guid("fc58bae4-6fd7-4d69-9886-52b9c89bc1cd"), "E", "E" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("0a831ba2-4e9a-4766-8aba-07c304f22ef0"), "marine vannmasser", "MV" },
                    { new Guid("1267e7db-656c-49d8-b37b-4acf9ebe11ce"), "primært økodiversitetsnivå", "PE" },
                    { new Guid("37183c73-f06f-4859-a403-82398da916be"), "livsmedium", "LI" },
                    { new Guid("8b629cb6-8883-4266-9ffd-efd293ab90cf"), "sekundært økodiversitetsnivå", "SE" },
                    { new Guid("a84ac00a-0c19-4ef5-b7d5-78dcc8fd6ce0"), "landformvariasjon", "LV" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("199be38d-bbf7-4b3a-b75a-0f91e985c0eb"), "elveløp", "EL" },
                    { new Guid("24d65a0e-2e52-4241-91b6-5f10105e55e2"), "bremassiv", "BM" },
                    { new Guid("35be949a-723c-48f9-a42e-2e0237db1912"), "landskapstype", "LA" },
                    { new Guid("4ce2b931-abc9-49f8-be7c-19557f173a70"), "torvmarksmassiv", "TM" },
                    { new Guid("6f7cbf26-aeea-4725-ae96-30f14d0f9110"), "landformer i fast fjell og løsmasser", "FL" },
                    { new Guid("7ddc4f98-9757-4372-8c9e-f7d84729bd6b"), "natursystem", "NA" },
                    { new Guid("7e41c944-1f7a-4717-b426-1cbca2cf784e"), "innsjøbasseng", "IB" },
                    { new Guid("eaee0faa-a8c3-41da-9e57-2d6d430ae7ec"), "naturkompleks", "NK" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("3ce0276e-c5c0-472a-b3f0-e4e608c638b2"), "mark- og bunnsystemer", "MB" },
                    { new Guid("51aa6253-3808-4dbe-bfc4-825624ebfdcd"), "vannmassesystemer", "VM" }
                });

            migrationBuilder.InsertData(
                table: "Variabelkategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("3153234b-4c30-4959-8763-c8963b1bad0e"), "naturgitt", "N" },
                    { new Guid("a82759aa-0dc5-4335-81aa-20dd6d1258cc"), "mennekebetinget", "M" }
                });

            migrationBuilder.InsertData(
                table: "domene",
                columns: new[] { "Id", "Navn" },
                values: new object[] { new Guid("c2eb1fdb-cb4b-48c4-a745-db8d60320897"), "3.0" });

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
                name: "Ecosystnivå");

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
