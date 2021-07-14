using Microsoft.EntityFrameworkCore.Migrations;

namespace SD_WebSite_DashBoardApi.Migrations
{
    public partial class update_tabela_componente_couluna_nomeCompon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_adminstrador_componente_ComponenteId",
                table: "adminstrador");

            migrationBuilder.DropIndex(
                name: "IX_adminstrador_ComponenteId",
                table: "adminstrador");

            migrationBuilder.DropColumn(
                name: "ComponenteId",
                table: "adminstrador");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ComponenteId",
                table: "adminstrador",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_adminstrador_ComponenteId",
                table: "adminstrador",
                column: "ComponenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_adminstrador_componente_ComponenteId",
                table: "adminstrador",
                column: "ComponenteId",
                principalTable: "componente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
