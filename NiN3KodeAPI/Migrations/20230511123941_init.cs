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
                values: new object[] { new Guid("8024a183-9cce-4d61-bea2-6fec9c207ec9"), "3.0" });

            migrationBuilder.InsertData(
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("3b1dab44-8562-41bf-a4b6-22f89c0824a2"), "økodiversitet", "C" });

            migrationBuilder.InsertData(
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("4fe545c7-17a7-4f10-83e3-244c65307a23"), "abiotisk", "A" });

            migrationBuilder.InsertData(
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("503bd8e4-d781-48b9-b227-21e005a29af6"), "biotisk", "B" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("41a1bd99-d666-49e2-ac31-1f1bb7207705"), "kartleggingsenhet tilpasset 1:50 000", "050K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("7c6c6c11-2d99-4b64-a645-67043c2a3628"), "kartleggingsenhet tilpasset 1:10 000", "010K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9f11090a-a415-49b7-89ea-4f213661227e"), "kartleggingsenhet tilpasset 1:20 000", "020K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a2afc6ca-6d2f-4bcb-8bfc-ba7450ed7b37"), "kartleggingsenhet tilpasset 1:100 000", "100K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a302a814-e5e7-4c36-a609-efb83b52ea29"), "grunntype", "G" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e5a04723-6a38-4867-b7ab-6d97701b8dd1"), "kartleggingsenhet tilpasset 1:5000", "005K" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("07f6cbd4-77c6-43af-a3d7-6ee24b1126ea"), "C", "C" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("21dbd023-f1a8-4dba-8de8-1c846779c106"), "B", "B" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("5af5138f-4e08-4288-ac6d-9efc76ae7940"), "N", "N" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("7a4ebba8-037d-4738-a30a-eb5ac910d1b9"), "G", "G" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("8b6bf6f2-3f34-4fb2-b618-ea1e8a560785"), "A", "A" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("8e077c5c-a072-47a6-8c1c-66a0f8856cb2"), "L", "L" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("97b86afb-73f0-4a9a-b7db-6d97c9e949ca"), "Ikke angitt", "0" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("ae93b65b-f246-43f8-b625-889f06adfaaf"), "K", "K" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("afc5cbfe-2f87-4f6f-b337-7b75bbeda21b"), "F", "F" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("c96ea63a-a34c-4b9c-93e6-9fd4b11adbc8"), "D", "D" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("dd2db91f-9bab-41bf-896e-2bc897d56b33"), "J", "J" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e4678e8d-4e8c-4c6f-beae-9251734f648e"), "M", "M" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e724609a-b036-4119-b5ba-3f583316d01b"), "H", "H" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f36d6f31-dc4c-46d8-a366-e0cb80d92f8f"), "I", "I" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f53e33d5-44ad-4415-9555-da15b951af56"), "E", "E" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f5d32d52-8e66-42b5-bf66-2faacfe8c0c4"), "O", "O" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("087daf6d-1df2-4d46-bdac-d5269c7880dd"), "landformvariasjon", "LV" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("6943b4e3-2cfd-4303-bd3c-d5bd938aab01"), "sekundært økodiversitetsnivå", "SE" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("7635a7db-9895-4429-b304-88ed1e1821ec"), "primært økodiversitetsnivå", "PE" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a9dc5d91-98cd-4dc1-b9c9-0dc7d3c6c2ce"), "marine vannmasser", "MV" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e6ba9540-d33c-4313-a1f2-2c52ecd384a6"), "livsmedium", "LI" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("2b37ebfc-befa-40e7-91cf-903af973eda6"), "innsjøbasseng", "IB" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("636fafbb-fa09-42d6-9eea-5eb521971323"), "bremassiv", "BM" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a1389c5d-76a3-4b71-8fd3-d147b6ac961d"), "torvmarksmassiv", "TM" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("ae9e496b-b044-4ef5-8cce-d8a8a2b027d0"), "landformer i fast fjell og løsmasser", "FL" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b0c55c5f-2d66-4449-acae-0069d7400d0b"), "naturkompleks", "NK" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d8c3357c-af29-4fc0-b03c-b9daade3857b"), "elveløp", "EL" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e33a6d9e-fff1-4d5a-8141-e71451ac2f39"), "natursystem", "NA" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("eaa20eeb-981f-4abc-9182-47a2ad8b6623"), "landskapstype", "LA" });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b2c048cd-ff92-4b2d-a0f8-e2a8a03146a7"), "vannmassesystemer", "VM" });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d26897b7-6628-4143-943a-387e98b368e8"), "mark- og bunnsystemer", "MB" });

            migrationBuilder.InsertData(
                table: "Variabelkategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("485f8f84-cefd-4caa-a2dd-51edb30f93ff"), "mennekebetinget", "M" });

            migrationBuilder.InsertData(
                table: "Variabelkategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("56cf49b5-a7a9-4e40-82f6-66a5f7dd3a3d"), "naturgitt", "N" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("19d2c01c-627e-4166-94dc-9d058b228ca6"), "strukturerende og funksjonelle artsgrupper", "SA" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("1b241896-a567-4435-b390-2131e846cf9e"), "artssammensetningsdynamikk", "AD" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("260b09b0-fb0f-4974-9c95-9fc73fa0b3c8"), "romlig strukturvariasjon", "RS" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("6bf7bb8a-bb0b-4535-a52a-e44835e0c888"), "romlig artsfordelingsmønster", "RA" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("7c8ff245-4e96-4962-94fd-afccb6ecaf08"), "korttidsmiljøvariabel", "KM" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("8ac3b854-c67f-4d70-8a8e-d02a9d9eae34"), "terrengformvariasjon", "TF" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9370e320-b34b-4d6b-938b-53f8a295eb2b"), "miljødynamikk", "MD" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("940a9985-e4cb-4686-a783-0fc3c9ea7fe1"), "naturgitt objekt", "NO" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("965fc22e-07a3-4f1a-a7d1-dacd98f7d3d5"), "regional miljøvariabel", "RM" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9d85f563-c5c5-443b-b76a-949a085739cd"), "landform-objekter", "LO" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9f7024b5-c500-4196-8c85-a5a0be8b4908"), "bergarter", "BE" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("c2f51e8e-0285-4256-a6ff-a451067a3800"), "vertikal struktur", "VS" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("ce8c5e16-4d81-45c1-a948-4c82061bad4d"), "lokal miljøvariabel", "LM" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d55c97bf-8ae0-4947-a0b2-7b6f2ee46c13"), "menneskeskapt objekt", "MO" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("16fbff5b-5af3-4796-ab13-b9a7faa3c5dd"), "enkel, ikke-ordnet faktorvariabel", "FE" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("31d28776-c8df-42b0-b55d-a51b79175358"), "kompleks gradient", "GK" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("bbf1dc54-94e8-4213-8993-f65bd0e7c143"), "kompleks, ikke-ordnet faktorvariabel", "FK" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e01545d2-20c8-47b9-b88d-e6b42a7a465e"), "enkel gradient", "GE" });

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
