using Microsoft.EntityFrameworkCore.Migrations;

namespace FCT.Data.Migrations
{
    public partial class ChangesInAirport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AirportId",
                table: "Airport");

            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "Airport");

            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "Airport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Elevation",
                table: "Airport",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Airport",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "Airport");

            migrationBuilder.DropColumn(
                name: "Elevation",
                table: "Airport");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Airport");

            migrationBuilder.AddColumn<string>(
                name: "AirportId",
                table: "Airport",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "Airport",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
