using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MST.IDP.Data.Migrations
{
    public partial class AddRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("39aae260-6fe9-4d73-b49a-13ca7af302ca"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("784afef1-de2b-4122-a04f-e70255f36a2f"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("9e454555-f217-43ad-919e-185c1a43d5ae"));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"),
                column: "ConcurrencyStamp",
                value: "66466c6e-c1df-4ae5-96fd-0cf2e5334c56");

            migrationBuilder.InsertData(
                table: "UserClaim",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("f581489d-7efb-4abe-8629-c3738f4d0d1f"), "3357f381-5819-414b-a3d8-0b8e8d935c2f", "given_name", new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"), "Michal" },
                    { new Guid("31c26452-a94d-47c6-9880-83b2afa614c6"), "b1e0b2b2-5091-4088-93ba-5d1eca174dc5", "family_name", new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"), "Stanik" },
                    { new Guid("cdd1521a-833b-4fea-a84c-d926b2d801e2"), "528f2124-429c-4e4b-92ee-2bec9b4a2926", "country", new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"), "pl" },
                    { new Guid("849d8138-763f-45c1-9d3e-2c42e0529f3d"), "dab93d6c-4d5c-425d-99b0-4ba10323a5c7", "role", new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"), "admin_aviation" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("31c26452-a94d-47c6-9880-83b2afa614c6"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("849d8138-763f-45c1-9d3e-2c42e0529f3d"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("cdd1521a-833b-4fea-a84c-d926b2d801e2"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("f581489d-7efb-4abe-8629-c3738f4d0d1f"));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"),
                column: "ConcurrencyStamp",
                value: "e65a0fd4-58e8-4f3b-88b0-4cc73c295ae5");

            migrationBuilder.InsertData(
                table: "UserClaim",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("39aae260-6fe9-4d73-b49a-13ca7af302ca"), "04e94174-fa16-442c-82de-50e21a43f9aa", "given_name", new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"), "Michal" },
                    { new Guid("784afef1-de2b-4122-a04f-e70255f36a2f"), "a06d306f-887b-4c51-8b5e-b5efa89a1e9e", "family_name", new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"), "Stanik" },
                    { new Guid("9e454555-f217-43ad-919e-185c1a43d5ae"), "be4f10e8-fb1a-418c-bb42-8531bcb18fc1", "country", new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"), "pl" }
                });
        }
    }
}
