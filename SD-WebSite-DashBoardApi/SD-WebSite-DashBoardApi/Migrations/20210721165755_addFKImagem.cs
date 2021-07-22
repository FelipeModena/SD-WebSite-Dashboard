using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SD_WebSite_DashBoardApi.Migrations
{
    public partial class addFKImagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Imagem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AdministradorId = table.Column<long>(type: "bigint", nullable: true),
                    img_url = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rota_pagina = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ComponenteId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imagem_adminstrador_AdministradorId",
                        column: x => x.AdministradorId,
                        principalTable: "adminstrador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Imagem_componente_ComponenteId",
                        column: x => x.ComponenteId,
                        principalTable: "componente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Imagem_AdministradorId",
                table: "Imagem",
                column: "AdministradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Imagem_ComponenteId",
                table: "Imagem",
                column: "ComponenteId");

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

            migrationBuilder.DropTable(
                name: "Imagem");

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
    }
}
