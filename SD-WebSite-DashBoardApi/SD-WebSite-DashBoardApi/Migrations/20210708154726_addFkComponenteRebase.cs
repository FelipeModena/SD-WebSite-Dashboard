using Microsoft.EntityFrameworkCore.Migrations;

namespace SD_WebSite_DashBoardApi.Migrations
{
    public partial class addFkComponenteRebase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentePagina_pagina_PaginasIdId",
                table: "ComponentePagina");

            migrationBuilder.RenameColumn(
                name: "PaginasIdId",
                table: "ComponentePagina",
                newName: "PaginaIdId");

            migrationBuilder.RenameIndex(
                name: "IX_ComponentePagina_PaginasIdId",
                table: "ComponentePagina",
                newName: "IX_ComponentePagina_PaginaIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentePagina_pagina_PaginaIdId",
                table: "ComponentePagina",
                column: "PaginaIdId",
                principalTable: "pagina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentePagina_pagina_PaginaIdId",
                table: "ComponentePagina");

            migrationBuilder.RenameColumn(
                name: "PaginaIdId",
                table: "ComponentePagina",
                newName: "PaginasIdId");

            migrationBuilder.RenameIndex(
                name: "IX_ComponentePagina_PaginaIdId",
                table: "ComponentePagina",
                newName: "IX_ComponentePagina_PaginasIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentePagina_pagina_PaginasIdId",
                table: "ComponentePagina",
                column: "PaginasIdId",
                principalTable: "pagina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
