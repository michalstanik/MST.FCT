using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MST.IDP.Data.Migrations
{
    public partial class ChangesInPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("00872b16-01f2-4640-98ba-afcaa9db7f1d"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("09d5a7f0-e8ac-4d97-b165-85da999f5cd9"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("0b9ebe9c-4c27-4a87-92ca-5c42f99b1a8b"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("7934e78e-8d9c-4f31-bfd1-d1e520155fb4"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("7fa134d2-26a5-4c87-b451-dce636107d15"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("85343414-e0b2-4378-a77c-bd860ba3f73f"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("aed4535d-e14d-455e-a056-a0cb06d87aa0"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("af00da52-7e24-4af2-a5ee-1082da61f556"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("b10f6492-59e1-4d19-af61-dbdf2da652e4"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("ded34eae-8ae7-4a41-8c01-8dc4442bb7d4"));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "7f2a4d47-ed83-4186-aca2-136541d57d1d", "AQAAAAEAACcQAAAAEAAP1QAc8J6Ri88b4+01i2M+u9amqIhA8Jo1pvdIWTO0Le3NPqPAyQzrbWYQHSD0WA==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "d4f092b7-8938-4828-bf5f-60e44dfd29b2", "AQAAAAEAACcQAAAAEAAP1QAc8J6Ri88b4+01i2M+u9amqIhA8Jo1pvdIWTO0Le3NPqPAyQzrbWYQHSD0WA==" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "80acc545-250b-440c-9feb-54530f81d48c", "password" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "dac3c3ea-1c90-4e06-9dfe-d9cc013b9df0", "password" });

            migrationBuilder.InsertData(
                table: "UserClaim",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("aed4535d-e14d-455e-a056-a0cb06d87aa0"), "f8a6349f-17e9-417b-8117-112789d56a7e", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("7934e78e-8d9c-4f31-bfd1-d1e520155fb4"), "6300d3d7-2cf6-4e99-8d60-73249e071508", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("af00da52-7e24-4af2-a5ee-1082da61f556"), "7ccba8a8-1d93-4f9f-bf13-51279960e9e1", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("00872b16-01f2-4640-98ba-afcaa9db7f1d"), "0ffa2197-490f-419d-ac38-701d3a52b40d", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("b10f6492-59e1-4d19-af61-dbdf2da652e4"), "8d1031cf-d9ae-474c-8dbe-81181f469675", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("7fa134d2-26a5-4c87-b451-dce636107d15"), "04dab306-3569-444f-83e7-558b27d08e6e", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("0b9ebe9c-4c27-4a87-92ca-5c42f99b1a8b"), "8d4a04c0-3e9f-4e95-8eba-9b9280557b6c", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("09d5a7f0-e8ac-4d97-b165-85da999f5cd9"), "2513c1bc-6333-4487-ba5a-79d8df9e651e", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("ded34eae-8ae7-4a41-8c01-8dc4442bb7d4"), "01aa1b34-0bd2-4aa5-9a01-26b7fd3dae10", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("85343414-e0b2-4378-a77c-bd860ba3f73f"), "0e4f88db-494a-4602-9e87-0ebdc84f167f", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });
        }
    }
}
