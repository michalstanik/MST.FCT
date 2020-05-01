using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MST.IDP.Data.Migrations
{
    public partial class AddEmialFieldToTheUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("0ae619b9-b1cf-4a57-b8c4-4a4517af8a2c"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("1bf6d9d6-8f3a-464e-9302-c9860708ad87"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("33d2d82b-f8ab-42c4-8099-079e4c4228de"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("414206d1-54da-4726-a71d-877788aa7684"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("4e19a0fc-d8b9-4928-8e88-b850b900ab92"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("70575ebb-e594-4984-9dee-eb66e1abf816"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("8784e9b3-c09f-40b4-ac1b-fbf3cb3e74cb"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("9ff6af49-6f87-4a67-ae5e-ce9b44980afd"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("ad0508d4-ba50-466d-9097-9d4fd8ba9252"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("df679bde-36ab-4552-8b02-96893b8dc114"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                maxLength: 200,
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "cd7b7b40-24aa-49ba-a610-d43ced70a6e6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "368e5a27-1745-44e1-bbd4-3824c8a754e6");

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
        }
    }
}
