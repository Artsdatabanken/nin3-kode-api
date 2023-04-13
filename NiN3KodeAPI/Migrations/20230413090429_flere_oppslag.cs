using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NiN3KodeAPI.Migrations
{
    public partial class flere_oppslag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("0d726161-8f77-4996-aca2-68a084264fbe"));

            migrationBuilder.CreateTable(
                name: "Maalestokk",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maalestokk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Typekategori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typekategori3", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ecosystnivå",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("39b00dca-832c-4080-87a0-91641fde4809"), "biotisk", "B" },
                    { new Guid("3e5b2f89-f342-4f9d-9bf2-ef2e75813fb2"), "abiotisk", "A" },
                    { new Guid("9426f1de-9338-4744-b28e-2b7f714edca9"), "økodiversitet", "C" }
                });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("1f0da409-df30-494e-8040-eb81444d5606"), "grunntype", "G" },
                    { new Guid("216684c2-fc8e-4e8b-9c7a-d688d9c8d80e"), "kartleggingsenhet tilpasset 1:20 000", "020K" },
                    { new Guid("4a4e3322-ebc3-459f-8c92-d6d3678b76ce"), "kartleggingsenhet tilpasset 1:10 000", "010K" },
                    { new Guid("79277913-ce54-48a2-8cfb-63566b4e87b3"), "kartleggingsenhet tilpasset 1:5000", "005K" },
                    { new Guid("c55fc55a-ec9b-4efa-879a-f7b9eb3405f4"), "kartleggingsenhet tilpasset 1:100 000", "100K" },
                    { new Guid("f78301ec-ab54-4881-8729-ebd36752fa80"), "kartleggingsenhet tilpasset 1:50 000", "050K" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("030efa28-8688-4b72-8446-dfbf9ae51edb"), "primært økodiversitetsnivå", "PE" },
                    { new Guid("19eba271-545c-4b49-bb3d-c5d03945115f"), "sekundært økodiversitetsnivå", "SE" },
                    { new Guid("3267624e-c215-41a8-b1b4-74348ae8b206"), "landformvariasjon", "LV" },
                    { new Guid("88d8e35e-ccbc-42b4-9b07-f8bc642658d6"), "livsmedium", "LI" },
                    { new Guid("b71ba442-98a7-4541-adc0-d235a8ec2421"), "marine vannmasser", "MV" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("21aa90b4-c63b-455a-9a8b-8476ec23be76"), "innsjøbasseng", "IB" },
                    { new Guid("2c6d9f9b-752a-44f1-9eb0-d1171ccca59f"), "landformer i fast fjell og løsmasser", "FL" },
                    { new Guid("4169fa44-1dad-49f4-b0b7-671ef53658a0"), "naturkompleks", "NK" },
                    { new Guid("5bf5523e-7f89-4f94-8812-4e2381688cec"), "torvmarksmassiv", "TM" },
                    { new Guid("65167df5-a6e7-4b25-b786-5051d710d9df"), "bremassiv", "BM" },
                    { new Guid("6f7ba3d6-bbfb-498f-875f-5270b049238e"), "landskapstype", "LA" },
                    { new Guid("aceb93d0-f514-4096-bcd4-5b988703b687"), "elveløp", "EL" },
                    { new Guid("cdf32f3b-9d0c-4b6d-874a-b537fe221c7b"), "natursystem", "NA" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("1397ac2d-0783-4353-a3ca-86212a2f2be7"), "vannmassesystemer", "VM" },
                    { new Guid("1f843e64-ab7e-449b-b4bc-bce4f5d838c1"), "mark- og bunnsystemer", "MB" }
                });

            migrationBuilder.InsertData(
                table: "domene",
                columns: new[] { "Id", "Navn" },
                values: new object[] { new Guid("c87ce346-72b8-47b9-8fc9-9fc7b8588455"), "3.0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maalestokk");

            migrationBuilder.DropTable(
                name: "Typekategori");

            migrationBuilder.DropTable(
                name: "Typekategori2");

            migrationBuilder.DropTable(
                name: "Typekategori3");

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("39b00dca-832c-4080-87a0-91641fde4809"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("3e5b2f89-f342-4f9d-9bf2-ef2e75813fb2"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("9426f1de-9338-4744-b28e-2b7f714edca9"));

            migrationBuilder.DeleteData(
                table: "domene",
                keyColumn: "Id",
                keyValue: new Guid("c87ce346-72b8-47b9-8fc9-9fc7b8588455"));

            migrationBuilder.InsertData(
                table: "Ecosystnivå",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("0d726161-8f77-4996-aca2-68a084264fbe"), "bobfisk", "BO" });
        }
    }
}
