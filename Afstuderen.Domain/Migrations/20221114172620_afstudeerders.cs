using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Afstuderen.Domain.Migrations
{
    /// <inheritdoc />
    public partial class afstudeerders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studenten_Opdrachten_OpdrachtId",
                table: "Studenten");

            migrationBuilder.DropIndex(
                name: "IX_Studenten_OpdrachtId",
                table: "Studenten");

            migrationBuilder.DropColumn(
                name: "OpdrachtId",
                table: "Studenten");

            migrationBuilder.AddColumn<int>(
                name: "Afstudeerder1Id",
                table: "Opdrachten",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Afstudeerder2Id",
                table: "Opdrachten",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Opdrachten_Afstudeerder1Id",
                table: "Opdrachten",
                column: "Afstudeerder1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Opdrachten_Afstudeerder2Id",
                table: "Opdrachten",
                column: "Afstudeerder2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Opdrachten_Studenten_Afstudeerder1Id",
                table: "Opdrachten",
                column: "Afstudeerder1Id",
                principalTable: "Studenten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Opdrachten_Studenten_Afstudeerder2Id",
                table: "Opdrachten",
                column: "Afstudeerder2Id",
                principalTable: "Studenten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opdrachten_Studenten_Afstudeerder1Id",
                table: "Opdrachten");

            migrationBuilder.DropForeignKey(
                name: "FK_Opdrachten_Studenten_Afstudeerder2Id",
                table: "Opdrachten");

            migrationBuilder.DropIndex(
                name: "IX_Opdrachten_Afstudeerder1Id",
                table: "Opdrachten");

            migrationBuilder.DropIndex(
                name: "IX_Opdrachten_Afstudeerder2Id",
                table: "Opdrachten");

            migrationBuilder.DropColumn(
                name: "Afstudeerder1Id",
                table: "Opdrachten");

            migrationBuilder.DropColumn(
                name: "Afstudeerder2Id",
                table: "Opdrachten");

            migrationBuilder.AddColumn<int>(
                name: "OpdrachtId",
                table: "Studenten",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Studenten_OpdrachtId",
                table: "Studenten",
                column: "OpdrachtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Studenten_Opdrachten_OpdrachtId",
                table: "Studenten",
                column: "OpdrachtId",
                principalTable: "Opdrachten",
                principalColumn: "Id");
        }
    }
}
