using Microsoft.EntityFrameworkCore.Migrations;

namespace SD_WebSite_DashBoardApi.Migrations
{
    public partial class ComponenteAddOrdem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ordem",
                table: "componente",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ordem",
                table: "componente");
        }
    }
}
