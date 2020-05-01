using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MST.IDP.Data.Migrations
{
    public partial class ChangesInEmails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("0e65ed21-ed56-4b20-95e4-84c6e1690ebb"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("17f1bb4d-5411-43a9-b6d4-bac5159f5d45"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("58cd1b23-87d9-45e8-baad-ecdc484ddb37"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("9a379a12-7eb6-4a57-ad87-fbe2e3ba85a2"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("a5116722-a6ef-46ab-9bc0-9d2e6878aa2f"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("e957aad1-ae24-4e8f-afba-5a16f2b9cf58"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("e9ab84e8-ef32-4b69-88bf-6b36257ff5df"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("f6566ce4-7f59-46cd-b332-9cd47ed4e330"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("fc93f894-63a1-43c3-bdee-aff59f24386e"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("fd06745d-67e3-4594-b476-70add3140735"));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Email" },
                values: new object[] { "e482d91d-7a39-4c47-8aa0-6107f0a3c2fb", "frank@gmail.com" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Email" },
                values: new object[] { "ddd9d4ac-979d-4726-966f-a9e380615169", "claire@gmail.com" });

            migrationBuilder.InsertData(
                table: "UserClaim",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("e8578525-28f9-41a7-b63d-117527789eec"), "8ca441c7-408e-4852-8e13-19bafad37ed1", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("be285eea-b5c8-462b-84ff-e15be7c795ee"), "ffba5bd2-7f02-4d71-9357-2911b25709ce", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("cb25b9b3-3502-4f7d-b760-3beda05fa874"), "97436ddd-b9b6-432a-aa85-aa5a235d6168", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("49aa1e8f-51db-448a-a329-0e577c71acf6"), "b8b63c89-7ea8-480e-8804-0877d44b1f69", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("1bca7927-a861-4bc2-a6fd-f9a5453ff887"), "1776efcb-1fd0-4caf-8ffd-2a588154cccf", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("cc79ad27-8024-490d-8929-625d0e07e131"), "2f488b87-2408-4932-a2ee-dc9be20a5c69", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("5ee1d1c1-3335-4bda-ac2f-9d4e569f3cd3"), "e7e66072-42e8-4ae6-9c6b-25e2fa6ddbb4", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("6a529168-fc9c-46a2-ac4c-aebc066f2100"), "3ec792e2-c698-4e5a-9a57-77a9bfafd5d1", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("5bd73156-eb49-44a7-b843-fb7c4340d981"), "e6274c47-1918-4e68-bd8d-c407295c7d85", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("c4ce9eee-e6d8-4af1-846b-7ba3115efd78"), "19cabb61-f5e1-4b7c-992e-28415937f126", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("1bca7927-a861-4bc2-a6fd-f9a5453ff887"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("49aa1e8f-51db-448a-a329-0e577c71acf6"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("5bd73156-eb49-44a7-b843-fb7c4340d981"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("5ee1d1c1-3335-4bda-ac2f-9d4e569f3cd3"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("6a529168-fc9c-46a2-ac4c-aebc066f2100"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("be285eea-b5c8-462b-84ff-e15be7c795ee"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("c4ce9eee-e6d8-4af1-846b-7ba3115efd78"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("cb25b9b3-3502-4f7d-b760-3beda05fa874"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("cc79ad27-8024-490d-8929-625d0e07e131"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("e8578525-28f9-41a7-b63d-117527789eec"));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Email" },
                values: new object[] { "7f2a4d47-ed83-4186-aca2-136541d57d1d", null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Email" },
                values: new object[] { "d4f092b7-8938-4828-bf5f-60e44dfd29b2", null });

            migrationBuilder.InsertData(
                table: "UserClaim",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("fd06745d-67e3-4594-b476-70add3140735"), "1b233027-e474-4e3e-aa42-e8fc871a92ad", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("f6566ce4-7f59-46cd-b332-9cd47ed4e330"), "0b2893ef-8229-43b0-86e9-ae32ce289531", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("a5116722-a6ef-46ab-9bc0-9d2e6878aa2f"), "eadd3d3c-9ac1-4bd1-846b-347145b3a502", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("9a379a12-7eb6-4a57-ad87-fbe2e3ba85a2"), "bd72d7fe-7de5-4835-ab7d-c29bb761689f", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("58cd1b23-87d9-45e8-baad-ecdc484ddb37"), "8fd450c4-46b9-4150-90eb-941429412d1f", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("e9ab84e8-ef32-4b69-88bf-6b36257ff5df"), "709b8de7-4975-4ffd-b9f8-c97253128107", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("17f1bb4d-5411-43a9-b6d4-bac5159f5d45"), "2e4d6c02-3b6f-475c-afee-5db4ac653ce3", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("0e65ed21-ed56-4b20-95e4-84c6e1690ebb"), "c29ea2d1-2322-47c4-aa77-baa6ccbb465e", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("e957aad1-ae24-4e8f-afba-5a16f2b9cf58"), "cb769620-90b5-4ac7-9ee9-71454b70be46", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("fc93f894-63a1-43c3-bdee-aff59f24386e"), "230a33e5-6b2e-4632-9872-d98d8c23bd91", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });
        }
    }
}
