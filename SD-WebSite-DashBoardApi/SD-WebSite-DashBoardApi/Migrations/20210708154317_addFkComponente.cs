using Microsoft.EntityFrameworkCore.Migrations;

namespace SD_WebSite_DashBoardApi.Migrations
{
    public partial class addFkComponente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_componente_pagina_PaginaId",
                table: "componente");

            migrationBuilder.DropIndex(
                name: "IX_componente_PaginaId",
                table: "componente");

            migrationBuilder.DropColumn(
                name: "PaginaId",
                table: "componente");

            migrationBuilder.AddColumn<long>(
                name: "ComponenteId",
                table: "adminstrador",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ComponentePagina",
                columns: table => new
                {
                    ComponenteId = table.Column<long>(type: "bigint", nullable: false),
                    PaginasIdId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentePagina", x => new { x.ComponenteId, x.PaginasIdId });
                    table.ForeignKey(
                        name: "FK_ComponentePagina_componente_ComponenteId",
                        column: x => x.ComponenteId,
                        principalTable: "componente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponentePagina_pagina_PaginasIdId",
                        column: x => x.PaginasIdId,
                        principalTable: "pagina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_adminstrador_ComponenteId",
                table: "adminstrador",
                column: "ComponenteId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentePagina_PaginasIdId",
                table: "ComponentePagina",
                column: "PaginasIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_adminstrador_componente_ComponenteId",
                table: "adminstrador",
                column: "ComponenteId",
                principalTable: "componente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_adminstrador_componente_ComponenteId",
                table: "adminstrador");

            migrationBuilder.DropTable(
                name: "ComponentePagina");

            migrationBuilder.DropIndex(
                name: "IX_adminstrador_ComponenteId",
                table: "adminstrador");

            migrationBuilder.DropColumn(
                name: "ComponenteId",
                table: "adminstrador");

            migrationBuilder.AddColumn<long>(
                name: "PaginaId",
                table: "componente",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_componente_PaginaId",
                table: "componente",
                column: "PaginaId");

            migrationBuilder.AddForeignKey(
                name: "FK_componente_pagina_PaginaId",
                table: "componente",
                column: "PaginaId",
                principalTable: "pagina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
