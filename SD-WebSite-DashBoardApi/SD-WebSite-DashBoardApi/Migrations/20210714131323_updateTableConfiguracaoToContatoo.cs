using Microsoft.EntityFrameworkCore.Migrations;

namespace SD_WebSite_DashBoardApi.Migrations
{
    public partial class updateTableConfiguracaoToContatoo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_configuracao",
                table: "configuracao");

            migrationBuilder.RenameTable(
                name: "configuracao",
                newName: "contato");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contato",
                table: "contato",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_contato",
                table: "contato");

            migrationBuilder.RenameTable(
                name: "contato",
                newName: "configuracao");

            migrationBuilder.AddPrimaryKey(
                name: "PK_configuracao",
                table: "configuracao",
                column: "Id");
        }
    }
}
