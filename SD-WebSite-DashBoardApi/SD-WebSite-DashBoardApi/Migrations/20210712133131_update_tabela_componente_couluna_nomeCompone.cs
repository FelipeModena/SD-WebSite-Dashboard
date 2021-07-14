using Microsoft.EntityFrameworkCore.Migrations;

namespace SD_WebSite_DashBoardApi.Migrations
{
    public partial class update_tabela_componente_couluna_nomeCompone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_componente_pagina_PaginaId",
                table: "componente");

            migrationBuilder.RenameColumn(
                name: "PaginaId",
                table: "componente",
                newName: "pagina_id");

            migrationBuilder.RenameIndex(
                name: "IX_componente_PaginaId",
                table: "componente",
                newName: "IX_componente_pagina_id");

            migrationBuilder.AlterColumn<long>(
                name: "pagina_id",
                table: "componente",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_componente_pagina_pagina_id",
                table: "componente",
                column: "pagina_id",
                principalTable: "pagina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_componente_pagina_pagina_id",
                table: "componente");

            migrationBuilder.RenameColumn(
                name: "pagina_id",
                table: "componente",
                newName: "PaginaId");

            migrationBuilder.RenameIndex(
                name: "IX_componente_pagina_id",
                table: "componente",
                newName: "IX_componente_PaginaId");

            migrationBuilder.AlterColumn<long>(
                name: "PaginaId",
                table: "componente",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

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
