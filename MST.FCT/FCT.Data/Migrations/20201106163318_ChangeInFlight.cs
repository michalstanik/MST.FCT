using Microsoft.EntityFrameworkCore.Migrations;

namespace FCT.Data.Migrations
{
    public partial class ChangeInFlight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlightTime",
                table: "Flight");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "FlightTime",
                table: "Flight",
                type: "bigint",
                nullable: true);
        }
    }
}
