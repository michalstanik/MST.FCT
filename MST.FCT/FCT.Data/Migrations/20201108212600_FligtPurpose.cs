using Microsoft.EntityFrameworkCore.Migrations;

namespace FCT.Data.Migrations
{
    public partial class FligtPurpose : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FlightPurposeAssessment",
                table: "Flight",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlightPurposeAssessment",
                table: "Flight");
        }
    }
}
