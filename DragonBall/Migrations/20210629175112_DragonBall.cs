using Microsoft.EntityFrameworkCore.Migrations;

namespace DragonBall.Migrations
{
    public partial class DragonBall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classe",
                columns: table => new
                {
                    ClasseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoClasse = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classe", x => x.ClasseId);
                });

            migrationBuilder.CreateTable(
                name: "Raca",
                columns: table => new
                {
                    RacaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raca", x => x.RacaId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "InfoRaca",
                columns: table => new
                {
                    InfoRacaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoInfoRaca = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    RacaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoRaca", x => x.InfoRacaId);
                    table.ForeignKey(
                        name: "FK_InfoRaca_Raca_RacaId",
                        column: x => x.RacaId,
                        principalTable: "Raca",
                        principalColumn: "RacaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personagem",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PowerLevel = table.Column<int>(type: "int", nullable: false),
                    RacaId = table.Column<int>(type: "int", nullable: false),
                    ClasseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagem", x => x.PersonagemId);
                    table.ForeignKey(
                        name: "FK_Personagem_Classe_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classe",
                        principalColumn: "ClasseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personagem_Raca_RacaId",
                        column: x => x.RacaId,
                        principalTable: "Raca",
                        principalColumn: "RacaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InfoRaca_RacaId",
                table: "InfoRaca",
                column: "RacaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_ClasseId",
                table: "Personagem",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_RacaId",
                table: "Personagem",
                column: "RacaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InfoRaca");

            migrationBuilder.DropTable(
                name: "Personagem");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Classe");

            migrationBuilder.DropTable(
                name: "Raca");
        }
    }
}
