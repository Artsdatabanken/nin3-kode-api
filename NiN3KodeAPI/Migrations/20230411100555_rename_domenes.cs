using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NiN3KodeAPI.Migrations
{
    public partial class rename_domenes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_domenes",
                table: "domenes");

            migrationBuilder.RenameTable(
                name: "domenes",
                newName: "domene");

            migrationBuilder.AddPrimaryKey(
                name: "PK_domene",
                table: "domene",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_domene",
                table: "domene");

            migrationBuilder.RenameTable(
                name: "domene",
                newName: "domenes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_domenes",
                table: "domenes",
                column: "Id");
        }
    }
}
