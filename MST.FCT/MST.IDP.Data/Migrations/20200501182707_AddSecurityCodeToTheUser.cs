using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MST.IDP.Data.Migrations
{
    public partial class AddSecurityCodeToTheUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("06a6001a-4461-4a82-a36b-a3ba11bd871b"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("1af2ce04-0b10-4c75-b228-dfdd0dc21f40"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("2cf91826-d959-4bcd-b663-de071c07f452"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("30101bb8-cc4f-40ad-aa3b-50a21aa814db"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("3ea59b7e-1029-454e-b480-9ec3e6f32495"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("53155efa-4de5-47f6-bad1-a2f277be5d96"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("6ad8c297-07e6-48c5-b779-aef5bae65fce"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("a8836546-b644-4611-92f8-0c68e5343b00"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("dddb0e55-d034-4338-ad60-c9dd82b25d55"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("e0b199bc-0615-4d44-bccc-f067694a58fc"));

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "User",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "80acc545-250b-440c-9feb-54530f81d48c");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "dac3c3ea-1c90-4e06-9dfe-d9cc013b9df0");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "User");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "User");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "04eeed7c-e2f7-4e69-8ebb-f6b27792a5f4");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "576b2421-343b-4c7d-979e-13edb43f2694");

            migrationBuilder.InsertData(
                table: "UserClaim",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("6ad8c297-07e6-48c5-b779-aef5bae65fce"), "de2f0c90-7b4f-48ce-8256-b1f0e63b27cb", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("dddb0e55-d034-4338-ad60-c9dd82b25d55"), "e4436777-1ea7-431e-bd46-0e3aaa4dc35c", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("30101bb8-cc4f-40ad-aa3b-50a21aa814db"), "726d5290-ee0f-4ed4-8ac4-58b9ae30e56d", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("e0b199bc-0615-4d44-bccc-f067694a58fc"), "8abaa01f-9406-45b9-9452-81b8ca8a2990", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("3ea59b7e-1029-454e-b480-9ec3e6f32495"), "f027759d-4938-4407-b9fc-ce5ee57a2502", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("06a6001a-4461-4a82-a36b-a3ba11bd871b"), "5456288c-3067-4006-9ed3-dd0aa11efb59", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("53155efa-4de5-47f6-bad1-a2f277be5d96"), "84bde5d3-ed43-45fd-b5a5-47e8fbab5453", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("1af2ce04-0b10-4c75-b228-dfdd0dc21f40"), "9673efd3-e9e2-4a76-9c9f-b248dc48214b", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("2cf91826-d959-4bcd-b663-de071c07f452"), "4d0bef56-94f9-432f-878d-e0bc785aabd2", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("a8836546-b644-4611-92f8-0c68e5343b00"), "2f7616cc-0f2b-4cfc-b090-9b337a06dcff", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });
        }
    }
}
