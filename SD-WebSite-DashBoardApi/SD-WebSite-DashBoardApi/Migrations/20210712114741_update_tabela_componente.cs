using Microsoft.EntityFrameworkCore.Migrations;

namespace SD_WebSite_DashBoardApi.Migrations
{
    public partial class update_tabela_componente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComponentePagina");

            migrationBuilder.AddColumn<long>(
                name: "PaginaId",
                table: "componente",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cor_botao_1",
                table: "componente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "cor_sub_titulo",
                table: "componente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "cor_titulo",
                table: "componente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "sub_titulo",
                table: "componente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "texto",
                table: "componente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "titulo",
                table: "componente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "txt_botao_1",
                table: "componente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "url_botao_1",
                table: "componente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "url_direcionamento_paginas",
                table: "componente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "url_imagem",
                table: "componente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "cor_botao_1",
                table: "componente");

            migrationBuilder.DropColumn(
                name: "cor_sub_titulo",
                table: "componente");

            migrationBuilder.DropColumn(
                name: "cor_titulo",
                table: "componente");

            migrationBuilder.DropColumn(
                name: "sub_titulo",
                table: "componente");

            migrationBuilder.DropColumn(
                name: "texto",
                table: "componente");

            migrationBuilder.DropColumn(
                name: "titulo",
                table: "componente");

            migrationBuilder.DropColumn(
                name: "txt_botao_1",
                table: "componente");

            migrationBuilder.DropColumn(
                name: "url_botao_1",
                table: "componente");

            migrationBuilder.DropColumn(
                name: "url_direcionamento_paginas",
                table: "componente");

            migrationBuilder.DropColumn(
                name: "url_imagem",
                table: "componente");

            migrationBuilder.CreateTable(
                name: "ComponentePagina",
                columns: table => new
                {
                    ComponenteId = table.Column<long>(type: "bigint", nullable: false),
                    PaginaIdId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentePagina", x => new { x.ComponenteId, x.PaginaIdId });
                    table.ForeignKey(
                        name: "FK_ComponentePagina_componente_ComponenteId",
                        column: x => x.ComponenteId,
                        principalTable: "componente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponentePagina_pagina_PaginaIdId",
                        column: x => x.PaginaIdId,
                        principalTable: "pagina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentePagina_PaginaIdId",
                table: "ComponentePagina",
                column: "PaginaIdId");
        }
    }
}
