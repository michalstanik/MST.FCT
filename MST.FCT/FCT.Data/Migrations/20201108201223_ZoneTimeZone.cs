using Microsoft.EntityFrameworkCore.Migrations;

namespace FCT.Data.Migrations
{
    public partial class ZoneTimeZone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeZone_Zone_ZoneId",
                table: "TimeZone");

            migrationBuilder.DropIndex(
                name: "IX_TimeZone_ZoneId",
                table: "TimeZone");

            migrationBuilder.DropColumn(
                name: "ZoneId",
                table: "Zone");

            migrationBuilder.DropColumn(
                name: "Dst",
                table: "TimeZone");

            migrationBuilder.DropColumn(
                name: "GMTOffset",
                table: "TimeZone");

            migrationBuilder.DropColumn(
                name: "TimeStart",
                table: "TimeZone");

            migrationBuilder.DropColumn(
                name: "ZoneId",
                table: "TimeZone");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TimeZone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDst",
                table: "TimeZone",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TimeZone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Offset",
                table: "TimeZone",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ZoneTimeZone",
                columns: table => new
                {
                    ZoneId = table.Column<int>(nullable: false),
                    TimeZoneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoneTimeZone", x => new { x.ZoneId, x.TimeZoneId });
                    table.ForeignKey(
                        name: "FK_ZoneTimeZone_TimeZone_TimeZoneId",
                        column: x => x.TimeZoneId,
                        principalTable: "TimeZone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZoneTimeZone_Zone_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ZoneTimeZone_TimeZoneId",
                table: "ZoneTimeZone",
                column: "TimeZoneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZoneTimeZone");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TimeZone");

            migrationBuilder.DropColumn(
                name: "IsDst",
                table: "TimeZone");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TimeZone");

            migrationBuilder.DropColumn(
                name: "Offset",
                table: "TimeZone");

            migrationBuilder.AddColumn<int>(
                name: "ZoneId",
                table: "Zone",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dst",
                table: "TimeZone",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "GMTOffset",
                table: "TimeZone",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "TimeStart",
                table: "TimeZone",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "ZoneId",
                table: "TimeZone",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TimeZone_ZoneId",
                table: "TimeZone",
                column: "ZoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeZone_Zone_ZoneId",
                table: "TimeZone",
                column: "ZoneId",
                principalTable: "Zone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
