using Microsoft.EntityFrameworkCore.Migrations;

namespace SD_WebSite_DashBoardApi.Migrations
{
    public partial class addFKImag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagem_adminstrador_AdministradorId",
                table: "Imagem");

            migrationBuilder.DropIndex(
                name: "IX_Imagem_AdministradorId",
                table: "Imagem");

            migrationBuilder.DropColumn(
                name: "AdministradorId",
                table: "Imagem");

            migrationBuilder.AddColumn<long>(
                name: "AdministradorId",
                table: "contato",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_contato_AdministradorId",
                table: "contato",
                column: "AdministradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_contato_adminstrador_AdministradorId",
                table: "contato",
                column: "AdministradorId",
                principalTable: "adminstrador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contato_adminstrador_AdministradorId",
                table: "contato");

            migrationBuilder.DropIndex(
                name: "IX_contato_AdministradorId",
                table: "contato");

            migrationBuilder.DropColumn(
                name: "AdministradorId",
                table: "contato");

            migrationBuilder.AddColumn<long>(
                name: "AdministradorId",
                table: "Imagem",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Imagem_AdministradorId",
                table: "Imagem",
                column: "AdministradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagem_adminstrador_AdministradorId",
                table: "Imagem",
                column: "AdministradorId",
                principalTable: "adminstrador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
