using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FCT.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AircraftFactory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AircraftFactoryCountryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftFactory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirLineAlliance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirLineAlliance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Airport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirportId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CountryName = table.Column<string>(nullable: true),
                    IATA = table.Column<string>(nullable: true),
                    ICAO = table.Column<string>(nullable: true),
                    Latitude = table.Column<long>(nullable: false),
                    Longitude = table.Column<long>(nullable: false),
                    CountryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AircraftModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    AircraftFactoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AircraftModel_AircraftFactory_AircraftFactoryId",
                        column: x => x.AircraftFactoryId,
                        principalTable: "AircraftFactory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Airline",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IATA = table.Column<string>(nullable: true),
                    ICAO = table.Column<string>(nullable: true),
                    AirlineCountryId = table.Column<int>(nullable: true),
                    AirLineAllianceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Airline_AirLineAlliance_AirLineAllianceId",
                        column: x => x.AirLineAllianceId,
                        principalTable: "AirLineAlliance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aircraft",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TailNumber = table.Column<string>(nullable: true),
                    AircraftModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircraft", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aircraft_AircraftModel_AircraftModelId",
                        column: x => x.AircraftModelId,
                        principalTable: "AircraftModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNumber = table.Column<string>(nullable: true),
                    DepartureDate = table.Column<DateTime>(nullable: true),
                    ArrivialDate = table.Column<DateTime>(nullable: true),
                    ScheduleDepartureDate = table.Column<DateTime>(nullable: true),
                    ScheduleArrivialDate = table.Column<DateTime>(nullable: true),
                    DepartureAirportId = table.Column<int>(nullable: true),
                    ArrivalAirportId = table.Column<int>(nullable: true),
                    Distance = table.Column<long>(nullable: true),
                    FlightTime = table.Column<long>(nullable: true),
                    AircraftId = table.Column<int>(nullable: true),
                    AirlineId = table.Column<int>(nullable: true),
                    FlightTypeAssessment = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flight_Aircraft_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircraft",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Flight_Airline_AirlineId",
                        column: x => x.AirlineId,
                        principalTable: "Airline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Flight_Airport_ArrivalAirportId",
                        column: x => x.ArrivalAirportId,
                        principalTable: "Airport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Flight_Airport_DepartureAirportId",
                        column: x => x.DepartureAirportId,
                        principalTable: "Airport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aircraft_AircraftModelId",
                table: "Aircraft",
                column: "AircraftModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftModel_AircraftFactoryId",
                table: "AircraftModel",
                column: "AircraftFactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Airline_AirLineAllianceId",
                table: "Airline",
                column: "AirLineAllianceId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_AircraftId",
                table: "Flight",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_AirlineId",
                table: "Flight",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_ArrivalAirportId",
                table: "Flight",
                column: "ArrivalAirportId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_DepartureAirportId",
                table: "Flight",
                column: "DepartureAirportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "Aircraft");

            migrationBuilder.DropTable(
                name: "Airline");

            migrationBuilder.DropTable(
                name: "Airport");

            migrationBuilder.DropTable(
                name: "AircraftModel");

            migrationBuilder.DropTable(
                name: "AirLineAlliance");

            migrationBuilder.DropTable(
                name: "AircraftFactory");
        }
    }
}
