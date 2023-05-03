using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NiN3KodeAPI.Migrations
{
    public partial class test4 : Migration
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
                    { new Guid("05b1c2d5-5c6d-4919-bdaa-0aed6b7c523d"), "økodiversitet", "C" },
                    { new Guid("7d211287-77b6-4e23-9ac1-85f12d939dd6"), "biotisk", "B" },
                    { new Guid("abe83bd4-b9e1-4561-ba88-198baceb6188"), "abiotisk", "A" }
                });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("4da882f9-692a-4e0c-81e0-9ebe244436e8"), "kartleggingsenhet tilpasset 1:10 000", "010K" },
                    { new Guid("524ee6b6-47a8-4bc4-89e5-8fd82f9293cf"), "kartleggingsenhet tilpasset 1:100 000", "100K" },
                    { new Guid("5697e50b-9e7b-4601-855d-e29ddd262522"), "grunntype", "G" },
                    { new Guid("936ae6f6-e2eb-49df-9181-a1b01255ac2f"), "kartleggingsenhet tilpasset 1:50 000", "050K" },
                    { new Guid("cbfc9cde-b07d-4922-8337-8a3f5d085185"), "kartleggingsenhet tilpasset 1:5000", "005K" },
                    { new Guid("e64afe5c-7c1e-4e60-9285-c7d9e163a942"), "kartleggingsenhet tilpasset 1:20 000", "020K" }
                });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("0c5999af-8f5b-4883-bb3d-e01a5a991f02"), "F", "F" },
                    { new Guid("0f787d8d-248e-48cd-8ad8-aaa224e716b9"), "A", "A" },
                    { new Guid("192c59db-a338-4e28-9801-06dd62443cd5"), "E", "E" },
                    { new Guid("1fb7a0bc-01a7-453f-a337-e45398f5300e"), "B", "B" },
                    { new Guid("4e578132-63ff-43aa-bf68-31f4b565dea2"), "O", "O" },
                    { new Guid("6ac6ebcb-6226-4497-a045-9561a52a7ef0"), "C", "C" },
                    { new Guid("6be2303f-5f60-47b4-a7ec-71b91e755ab8"), "N", "N" },
                    { new Guid("801fd9a0-df9e-46c2-95f6-69b075381cb9"), "H", "H" },
                    { new Guid("8b450fd0-2815-461d-8af3-18f321592323"), "K", "K" },
                    { new Guid("a2dcd346-1d93-44cb-a704-6cbd7872ca51"), "J", "J" },
                    { new Guid("a75de8c9-aba5-42f0-bfc6-d59ae8630fd5"), "Ikke angitt", "0" },
                    { new Guid("aa11baaa-14ad-4efe-8836-3fb9b1ce9238"), "L", "L" },
                    { new Guid("acae9bca-e174-4f09-a42b-e313ee88c051"), "I", "I" },
                    { new Guid("d192c26b-0262-4dda-941f-2d54dd44b1ad"), "G", "G" },
                    { new Guid("d2a4de0a-c220-4624-80a0-45875fd1329e"), "M", "M" },
                    { new Guid("f4569193-4ff0-4a38-bb7b-217bdb376fee"), "D", "D" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("1bd2bf18-f8ef-440d-a258-502b8758dfa6"), "landformvariasjon", "LV" },
                    { new Guid("2ccb0411-602e-4c67-86d9-d02d4f04ead6"), "primært økodiversitetsnivå", "PE" },
                    { new Guid("492aed69-3515-4da0-9361-11d404cb2ef7"), "marine vannmasser", "MV" },
                    { new Guid("c1c4c007-137c-4130-b466-c3ffc007d7de"), "livsmedium", "LI" },
                    { new Guid("db7f7db8-0580-4483-aadf-4dbabf28f3b8"), "sekundært økodiversitetsnivå", "SE" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("5df8ef12-64fa-4139-b938-4a2717fb8bd7"), "innsjøbasseng", "IB" },
                    { new Guid("6aae4bfb-14b4-45ef-bca8-d9a0f12f9940"), "landskapstype", "LA" },
                    { new Guid("73c1cf3c-7434-4916-9ef7-8d30cb6664a8"), "landformer i fast fjell og løsmasser", "FL" },
                    { new Guid("80669b12-ce4d-4af3-b64f-0f9c0a4930ea"), "torvmarksmassiv", "TM" },
                    { new Guid("b15b33b7-cc10-4939-bf88-affd6aef8342"), "naturkompleks", "NK" },
                    { new Guid("d63a2cf8-d283-441b-9b4a-adcf99a5ee5a"), "elveløp", "EL" },
                    { new Guid("dfd6c72d-b3b4-43f0-87d8-aa73aca830cb"), "bremassiv", "BM" },
                    { new Guid("ec15e224-e848-4364-a80c-1ffdd5c876ec"), "natursystem", "NA" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("85a33672-b9e0-4987-9343-26c67587fd5a"), "mark- og bunnsystemer", "MB" },
                    { new Guid("a7e1088b-3dd6-4f35-b3e3-36484c7321b1"), "vannmassesystemer", "VM" }
                });

            migrationBuilder.InsertData(
                table: "domene",
                columns: new[] { "Id", "Navn" },
                values: new object[] { new Guid("65e16959-3031-4e19-b692-f2f875bbf4e5"), "3.0" });

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
