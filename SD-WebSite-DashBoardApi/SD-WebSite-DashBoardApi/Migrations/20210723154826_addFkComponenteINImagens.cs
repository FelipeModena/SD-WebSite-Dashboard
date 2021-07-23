using Microsoft.EntityFrameworkCore.Migrations;

namespace SD_WebSite_DashBoardApi.Migrations
{
    public partial class addFkComponenteINImagens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagem_componente_ComponenteId",
                table: "Imagem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Imagem",
                table: "Imagem");

            migrationBuilder.RenameTable(
                name: "Imagem",
                newName: "imagem");

            migrationBuilder.RenameColumn(
                name: "ComponenteId",
                table: "imagem",
                newName: "componente");

            migrationBuilder.RenameIndex(
                name: "IX_Imagem_ComponenteId",
                table: "imagem",
                newName: "IX_imagem_componente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_imagem",
                table: "imagem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_imagem_componente_componente",
                table: "imagem",
                column: "componente",
                principalTable: "componente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_imagem_componente_componente",
                table: "imagem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_imagem",
                table: "imagem");

            migrationBuilder.RenameTable(
                name: "imagem",
                newName: "Imagem");

            migrationBuilder.RenameColumn(
                name: "componente",
                table: "Imagem",
                newName: "ComponenteId");

            migrationBuilder.RenameIndex(
                name: "IX_imagem_componente",
                table: "Imagem",
                newName: "IX_Imagem_ComponenteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Imagem",
                table: "Imagem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagem_componente_ComponenteId",
                table: "Imagem",
                column: "ComponenteId",
                principalTable: "componente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
