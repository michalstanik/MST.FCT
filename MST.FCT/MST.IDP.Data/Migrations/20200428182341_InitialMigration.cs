using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MST.IDP.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Subject = table.Column<string>(maxLength: 200, nullable: false),
                    Username = table.Column<string>(maxLength: 200, nullable: true),
                    Password = table.Column<string>(maxLength: 200, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(maxLength: 250, nullable: false),
                    Value = table.Column<string>(maxLength: 250, nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaim_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Password", "Subject", "Username" },
                values: new object[] { new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), true, "cd7b7b40-24aa-49ba-a610-d43ced70a6e6", "password", "d860efca-22d9-47fd-8249-791ba61b07c7", "Frank" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Password", "Subject", "Username" },
                values: new object[] { new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), true, "368e5a27-1745-44e1-bbd4-3824c8a754e6", "password", "b7539694-97e7-4dfe-84da-b4256e1ff5c7", "Claire" });

            migrationBuilder.InsertData(
                table: "UserClaim",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("ad0508d4-ba50-466d-9097-9d4fd8ba9252"), "a2447bbb-52d6-46c0-899e-92cfea3cd2f9", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("0ae619b9-b1cf-4a57-b8c4-4a4517af8a2c"), "968d9af0-d782-499b-9c31-3c0973f83443", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("1bf6d9d6-8f3a-464e-9302-c9860708ad87"), "20be0712-d9ea-4152-863d-850d3d233e90", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("33d2d82b-f8ab-42c4-8099-079e4c4228de"), "d4187022-92fc-4c3d-b2a3-2950d0933398", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("70575ebb-e594-4984-9dee-eb66e1abf816"), "b61f54ef-bcf9-4f38-a89c-ed83bfaf2cdb", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("4e19a0fc-d8b9-4928-8e88-b850b900ab92"), "0761e43a-29d4-4666-a998-32dc3236edd9", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("df679bde-36ab-4552-8b02-96893b8dc114"), "b34ddf90-ad7d-4edf-8c97-d77f092a1c29", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("9ff6af49-6f87-4a67-ae5e-ce9b44980afd"), "ee178f90-ce85-454f-bc9e-32fd68788c80", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("414206d1-54da-4726-a71d-877788aa7684"), "76ea9051-06fb-4734-a0ef-25694ac3d362", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("8784e9b3-c09f-40b4-ac1b-fbf3cb3e74cb"), "f16cadb1-37b5-4891-bc7f-86439d96f0c7", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Subject",
                table: "User",
                column: "Subject",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Username",
                table: "User",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaim_UserId",
                table: "UserClaim",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserClaim");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
