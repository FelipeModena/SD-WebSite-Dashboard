using Microsoft.EntityFrameworkCore.Migrations;

namespace SD_WebSite_DashBoardApi.Migrations
{
    public partial class addURLIMAGEMOBILE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "url_imagem",
                table: "componente",
                newName: "url_imagem_web");

            migrationBuilder.AddColumn<string>(
                name: "url_imagem_mobile",
                table: "componente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "url_imagem_mobile",
                table: "componente");

            migrationBuilder.RenameColumn(
                name: "url_imagem_web",
                table: "componente",
                newName: "url_imagem");
        }
    }
}
