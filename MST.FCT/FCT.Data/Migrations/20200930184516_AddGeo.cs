using Microsoft.EntityFrameworkCore.Migrations;

namespace FCT.Data.Migrations
{
    public partial class AddGeo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Continent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CountryCount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CountriesCount = table.Column<int>(nullable: true),
                    MaxLongitude = table.Column<double>(nullable: false),
                    MinLongitude = table.Column<double>(nullable: false),
                    MaxLatitude = table.Column<double>(nullable: false),
                    MinLatitude = table.Column<double>(nullable: false),
                    ContinentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Region_Continent_ContinentId",
                        column: x => x.ContinentId,
                        principalTable: "Continent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    OfficialName = table.Column<string>(nullable: true),
                    Alpha2Code = table.Column<string>(nullable: true),
                    Alpha3Code = table.Column<string>(nullable: true),
                    Area = table.Column<long>(nullable: false),
                    RegionId = table.Column<int>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Country_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Airport_CountryId",
                table: "Airport",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Airline_AirlineCountryId",
                table: "Airline",
                column: "AirlineCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftFactory_AircraftFactoryCountryId",
                table: "AircraftFactory",
                column: "AircraftFactoryCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Country_RegionId",
                table: "Country",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Region_ContinentId",
                table: "Region",
                column: "ContinentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AircraftFactory_Country_AircraftFactoryCountryId",
                table: "AircraftFactory",
                column: "AircraftFactoryCountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Airline_Country_AirlineCountryId",
                table: "Airline",
                column: "AirlineCountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Airport_Country_CountryId",
                table: "Airport",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AircraftFactory_Country_AircraftFactoryCountryId",
                table: "AircraftFactory");

            migrationBuilder.DropForeignKey(
                name: "FK_Airline_Country_AirlineCountryId",
                table: "Airline");

            migrationBuilder.DropForeignKey(
                name: "FK_Airport_Country_CountryId",
                table: "Airport");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Continent");

            migrationBuilder.DropIndex(
                name: "IX_Airport_CountryId",
                table: "Airport");

            migrationBuilder.DropIndex(
                name: "IX_Airline_AirlineCountryId",
                table: "Airline");

            migrationBuilder.DropIndex(
                name: "IX_AircraftFactory_AircraftFactoryCountryId",
                table: "AircraftFactory");
        }
    }
}
