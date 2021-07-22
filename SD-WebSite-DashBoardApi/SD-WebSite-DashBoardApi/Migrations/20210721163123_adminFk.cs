using Microsoft.EntityFrameworkCore.Migrations;

namespace SD_WebSite_DashBoardApi.Migrations
{
    public partial class adminFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AdministradorId",
                table: "pagina",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_pagina_AdministradorId",
                table: "pagina",
                column: "AdministradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_pagina_adminstrador_AdministradorId",
                table: "pagina",
                column: "AdministradorId",
                principalTable: "adminstrador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pagina_adminstrador_AdministradorId",
                table: "pagina");

            migrationBuilder.DropIndex(
                name: "IX_pagina_AdministradorId",
                table: "pagina");

            migrationBuilder.DropColumn(
                name: "AdministradorId",
                table: "pagina");
        }
    }
}
