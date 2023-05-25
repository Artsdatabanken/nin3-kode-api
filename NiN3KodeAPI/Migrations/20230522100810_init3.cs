using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NiN3KodeAPI.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Domene",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Navn = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domene", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oppslagstype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Kode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oppslagstype", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaseIdEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    VersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseIdEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseIdEntity_Domene_VersionId",
                        column: x => x.VersionId,
                        principalTable: "Domene",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ecosystnivaa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ecosystnivaa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ecosystnivaa_Oppslagstype_Id",
                        column: x => x.Id,
                        principalTable: "Oppslagstype",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Maalestokk",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maalestokk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maalestokk_Oppslagstype_Id",
                        column: x => x.Id,
                        principalTable: "Oppslagstype",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Prosedyrekategori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prosedyrekategori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prosedyrekategori_Oppslagstype_Id",
                        column: x => x.Id,
                        principalTable: "Oppslagstype",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Typekategori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typekategori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Typekategori_Oppslagstype_Id",
                        column: x => x.Id,
                        principalTable: "Oppslagstype",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Typekategori2Enum",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typekategori2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Typekategori2_Oppslagstype_Id",
                        column: x => x.Id,
                        principalTable: "Oppslagstype",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Variabelgruppe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variabelgruppe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variabelgruppe_Oppslagstype_Id",
                        column: x => x.Id,
                        principalTable: "Oppslagstype",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Variabelkategori2",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variabelkategori2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variabelkategori2_Oppslagstype_Id",
                        column: x => x.Id,
                        principalTable: "Oppslagstype",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Variabeltype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variabeltype", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variabeltype_Oppslagstype_Id",
                        column: x => x.Id,
                        principalTable: "Oppslagstype",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hovedtypegruppe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Typekategori2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Delkode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hovedtypegruppe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hovedtypegruppe_BaseIdEntity_Id",
                        column: x => x.Id,
                        principalTable: "BaseIdEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Hovedtypegruppe_Typekategori2_Typekategori2Id",
                        column: x => x.Typekategori2Id,
                        principalTable: "Typekategori2Enum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    EcosystnivaaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypekategoriId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Typekategori2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Kode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Type_BaseIdEntity_Id",
                        column: x => x.Id,
                        principalTable: "BaseIdEntity",
                        principalColumn: "Id");
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
                        principalTable: "Typekategori2Enum",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hovedtype",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Delkode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsedyrekategoriId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HovedtypegruppeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hovedtype", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hovedtype_BaseIdEntity_Id",
                        column: x => x.Id,
                        principalTable: "BaseIdEntity",
                        principalColumn: "Id");
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Delkode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProsedyrekategoriId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HovedtypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grunntype", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grunntype_BaseIdEntity_Id",
                        column: x => x.Id,
                        principalTable: "BaseIdEntity",
                        principalColumn: "Id");
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    GrunntypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Undertype", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Undertype_BaseIdEntity_Id",
                        column: x => x.Id,
                        principalTable: "BaseIdEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Undertype_Grunntype_GrunntypeId",
                        column: x => x.GrunntypeId,
                        principalTable: "Grunntype",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseIdEntity_VersionId",
                table: "BaseIdEntity",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Grunntype_HovedtypeId",
                table: "Grunntype",
                column: "HovedtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Grunntype_ProsedyrekategoriId",
                table: "Grunntype",
                column: "ProsedyrekategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Hovedtype_HovedtypegruppeId",
                table: "Hovedtype",
                column: "HovedtypegruppeId");

            migrationBuilder.CreateIndex(
                name: "IX_Hovedtype_ProsedyrekategoriId",
                table: "Hovedtype",
                column: "ProsedyrekategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Hovedtypegruppe_Typekategori2Id",
                table: "Hovedtypegruppe",
                column: "Typekategori2Id");

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
                name: "IX_Undertype_GrunntypeId",
                table: "Undertype",
                column: "GrunntypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maalestokk");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropTable(
                name: "Undertype");

            migrationBuilder.DropTable(
                name: "Variabelgruppe");

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
                name: "BaseIdEntity");

            migrationBuilder.DropTable(
                name: "Typekategori2Enum");

            migrationBuilder.DropTable(
                name: "Domene");

            migrationBuilder.DropTable(
                name: "Oppslagstype");
        }
    }
}
