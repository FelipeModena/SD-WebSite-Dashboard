using Microsoft.EntityFrameworkCore.Migrations;

namespace SD_WebSite_DashBoardApi.Migrations
{
    public partial class ImgCompleta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "url_imagem_mobile",
                table: "componente");

            migrationBuilder.DropColumn(
                name: "url_imagem_web",
                table: "componente");

            migrationBuilder.AddColumn<string>(
                name: "compatibilidade",
                table: "Imagem",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "compatibilidade",
                table: "Imagem");

            migrationBuilder.AddColumn<string>(
                name: "url_imagem_mobile",
                table: "componente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "url_imagem_web",
                table: "componente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
