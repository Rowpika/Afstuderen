using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Afstuderen.Domain.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bedrijven",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bedrijven", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Studenten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenten", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Opdrachten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Omschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Afstudeerder1Id = table.Column<int>(type: "int", nullable: false),
                    Afstudeerder2Id = table.Column<int>(type: "int", nullable: false),
                    OpdrachtgeverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opdrachten", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Opdrachten_Bedrijven_OpdrachtgeverId",
                        column: x => x.OpdrachtgeverId,
                        principalTable: "Bedrijven",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Opdrachten_Studenten_Afstudeerder1Id",
                        column: x => x.Afstudeerder1Id,
                        principalTable: "Studenten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opdrachten_Studenten_Afstudeerder2Id",
                        column: x => x.Afstudeerder2Id,
                        principalTable: "Studenten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Begeleiders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<int>(type: "int", nullable: false),
                    OpdrachtId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Begeleiders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Begeleiders_Opdrachten_OpdrachtId",
                        column: x => x.OpdrachtId,
                        principalTable: "Opdrachten",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Begeleiders_OpdrachtId",
                table: "Begeleiders",
                column: "OpdrachtId");

            migrationBuilder.CreateIndex(
                name: "IX_Opdrachten_Afstudeerder1Id",
                table: "Opdrachten",
                column: "Afstudeerder1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opdrachten_Afstudeerder2Id",
                table: "Opdrachten",
                column: "Afstudeerder2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opdrachten_OpdrachtgeverId",
                table: "Opdrachten",
                column: "OpdrachtgeverId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Begeleiders");

            migrationBuilder.DropTable(
                name: "Opdrachten");

            migrationBuilder.DropTable(
                name: "Bedrijven");

            migrationBuilder.DropTable(
                name: "Studenten");
        }
    }
}
