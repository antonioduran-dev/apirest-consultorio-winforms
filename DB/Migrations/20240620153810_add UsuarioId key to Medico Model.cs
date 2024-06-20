using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class addUsuarioIdkeytoMedicoModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Medicos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_UsuarioId",
                table: "Medicos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Usuarios_UsuarioId",
                table: "Medicos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Usuarios_UsuarioId",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_UsuarioId",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Medicos");
        }
    }
}
