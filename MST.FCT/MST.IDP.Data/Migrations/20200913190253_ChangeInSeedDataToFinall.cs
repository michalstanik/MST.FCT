using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MST.IDP.Data.Migrations
{
    public partial class ChangeInSeedDataToFinall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("4111c35f-fa1e-4be8-a966-524d54484042"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("5adaef20-18c3-4b5a-8013-72e315f4f723"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("5db22426-0331-4daf-94a9-b8c07b1c7270"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("6e12c274-d524-4039-bbd6-ab016c93d9b2"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("77d435c7-9170-49b1-bf6f-e78d57774a92"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("85209050-a184-40fa-9417-ac3709fdcc1d"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("a39cb934-a20a-4570-92d7-a63368879636"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("b54e370e-21a0-42a5-88fb-fbb246aae950"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("b7b1791b-d95e-4f30-86fc-50ab4b104829"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("bd11f918-ff87-4d46-b360-b64559296520"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Email", "LastLoginDate", "Password", "SecurityCode", "SecurityCodeExpirationDate", "Subject", "Username" },
                values: new object[] { new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"), true, "e65a0fd4-58e8-4f3b-88b0-4cc73c295ae5", "michal@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAELh/TFL1qtIL9+07j1JbNPk7VMrJQ07QMCQD6OdJxvl0l+lXaljbphhlZcfrlNM44w==", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2b6803d7-3983-4aae-a0c3-0feb52f699b6", "Michal" });

            migrationBuilder.InsertData(
                table: "UserClaim",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("39aae260-6fe9-4d73-b49a-13ca7af302ca"), "04e94174-fa16-442c-82de-50e21a43f9aa", "given_name", new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"), "Michal" });

            migrationBuilder.InsertData(
                table: "UserClaim",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("784afef1-de2b-4122-a04f-e70255f36a2f"), "a06d306f-887b-4c51-8b5e-b5efa89a1e9e", "family_name", new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"), "Stanik" });

            migrationBuilder.InsertData(
                table: "UserClaim",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("9e454555-f217-43ad-919e-185c1a43d5ae"), "be4f10e8-fb1a-418c-bb42-8531bcb18fc1", "country", new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"), "pl" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a98aab29-5807-4487-94f8-08d857fdd95f"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Email", "LastLoginDate", "Password", "SecurityCode", "SecurityCodeExpirationDate", "Subject", "Username" },
                values: new object[] { new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), true, "3f12b280-95c7-4439-80b6-77f9ee9eb743", "frank@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Password", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d860efca-22d9-47fd-8249-791ba61b07c7", "Frank" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Email", "LastLoginDate", "Password", "SecurityCode", "SecurityCodeExpirationDate", "Subject", "Username" },
                values: new object[] { new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), true, "bf6cde81-e32a-4dc9-bd81-823321a03d99", "claire@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEAAP1QAc8J6Ri88b4+01i2M+u9amqIhA8Jo1pvdIWTO0Le3NPqPAyQzrbWYQHSD0WA==", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b7539694-97e7-4dfe-84da-b4256e1ff5c7", "Claire" });

            migrationBuilder.InsertData(
                table: "UserClaim",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("4111c35f-fa1e-4be8-a966-524d54484042"), "95768fa2-0eb3-48ed-83e1-3206bd6a5b5c", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("6e12c274-d524-4039-bbd6-ab016c93d9b2"), "656c7abd-53d0-43ee-b71e-07d3172ab346", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("a39cb934-a20a-4570-92d7-a63368879636"), "c582ef07-ada4-4ada-bd68-a42c24b67cc9", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("77d435c7-9170-49b1-bf6f-e78d57774a92"), "916ba3d4-f9d9-44ca-a25b-fe881e0e6b61", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("5db22426-0331-4daf-94a9-b8c07b1c7270"), "f08d4702-f562-458d-ad54-2a06be09f12e", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("b54e370e-21a0-42a5-88fb-fbb246aae950"), "3bb843bf-d49a-466b-8934-98c5a426877b", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("5adaef20-18c3-4b5a-8013-72e315f4f723"), "e6c0a6e8-e44b-4c45-995f-51e03fe4c739", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("bd11f918-ff87-4d46-b360-b64559296520"), "c8d90ad6-9204-4b23-84d0-e53d6a01ef18", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("85209050-a184-40fa-9417-ac3709fdcc1d"), "e6808b4d-3bff-4140-b07c-c78c802ffef1", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("b7b1791b-d95e-4f30-86fc-50ab4b104829"), "03180e33-a1cf-48b2-a5dd-805d4bc16417", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });
        }
    }
}
