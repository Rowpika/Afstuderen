using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Afstuderen.Domain.Migrations
{
    /// <inheritdoc />
    public partial class telefoon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefoon",
                table: "Bedrijven",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Vestigingsplaats",
                table: "Bedrijven",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefoon",
                table: "Bedrijven");

            migrationBuilder.DropColumn(
                name: "Vestigingsplaats",
                table: "Bedrijven");
        }
    }
}
