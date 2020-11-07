using Microsoft.EntityFrameworkCore.Migrations;

namespace FCT.Data.Migrations
{
    public partial class AddZoneEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ZoneId",
                table: "Airport",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Zone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false),
                    ZoneName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zone_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Airport_ZoneId",
                table: "Airport",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Zone_CountryId",
                table: "Zone",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Airport_Zone_ZoneId",
                table: "Airport",
                column: "ZoneId",
                principalTable: "Zone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airport_Zone_ZoneId",
                table: "Airport");

            migrationBuilder.DropTable(
                name: "Zone");

            migrationBuilder.DropIndex(
                name: "IX_Airport_ZoneId",
                table: "Airport");

            migrationBuilder.DropColumn(
                name: "ZoneId",
                table: "Airport");
        }
    }
}
