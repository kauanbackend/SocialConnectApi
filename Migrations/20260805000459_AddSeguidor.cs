using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialConnectApi.Migrations
{
    /// <inheritdoc />
    public partial class AddSeguidor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seguidores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeguidorId = table.Column<int>(type: "int", nullable: false),
                    SeguindoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguidores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seguidores_Usuarios_SeguidorId",
                        column: x => x.SeguidorId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Seguidores_Usuarios_SeguindoId",
                        column: x => x.SeguindoId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seguidores_SeguidorId",
                table: "Seguidores",
                column: "SeguidorId");

            migrationBuilder.CreateIndex(
                name: "IX_Seguidores_SeguindoId",
                table: "Seguidores",
                column: "SeguindoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seguidores");
        }
    }
}
