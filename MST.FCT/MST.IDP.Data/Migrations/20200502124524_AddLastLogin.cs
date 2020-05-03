using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MST.IDP.Data.Migrations
{
    public partial class AddLastLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("013decaa-b3f2-416e-a8fe-187460888e60"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("1f7050e7-9f46-41d7-bed3-1c94d597f106"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("254b52a2-5bca-4678-bd56-0017c9026218"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("3fe8ad04-62ef-42e0-a97f-1bddb9859abf"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("6310a2ea-6ab3-4979-956c-da548fb30667"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("7acbd194-fba0-4404-a6f3-1d6c32810633"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("adb65c8d-1b39-4801-bce5-3bb2f9904be8"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("cb3515da-adfb-48b5-a42e-aebbc2778192"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("e693a44e-80f9-42d4-b3fa-b524f699e326"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("f86a431f-742f-49e6-8604-edbcbcddc1c4"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLoginDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "c8d1c3a2-699e-4082-a62d-89d11ebea562");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "897f8b1c-9ffe-4978-8ea7-a7b906f82076");

            migrationBuilder.InsertData(
                table: "UserClaim",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("4b0ed040-2d69-4803-8a6f-42f1ee636cdd"), "9aa3b5bd-c49a-474e-968a-1be987ddead9", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("b3bdd8e1-9e8a-4612-b20f-e1d39f0d81fd"), "0b4dde2d-e069-465f-8ef1-14d9b5d42fb8", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("675532aa-9e36-478f-ad5c-01fa41451fa9"), "158c8493-8217-4b79-83cb-adf5bffbfdb5", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("d1ca0315-4141-49fb-bb81-c6aef781064a"), "041577ab-c468-4417-9624-587b6f0a299f", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("6d1f22bd-0c40-4fcf-9489-975036703d12"), "a880b25e-a1f2-4f55-81c9-e8b8ebcbcb1b", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("27a2615b-6736-4e74-9d59-265c12f79c50"), "fa825ad6-4651-436c-9c9e-371ba3c57295", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("9dded54b-e8eb-4523-bf5b-b03d16c0add5"), "8ad737d7-9558-412f-8bfc-b2f3fce4f5f2", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("2d442102-d540-4fb7-9bb7-82d15b792eae"), "ad98f96d-6e39-47e2-b301-cd0d34640e5b", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("848c03d7-7292-4260-83db-1eb5c978eb6b"), "d1ced850-7272-4cd2-b7bd-e97d0f6281cc", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("52b91d43-d43e-44b7-93b5-19a5f7937525"), "dce201bb-8fd5-482d-82b8-3371c6743d53", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("27a2615b-6736-4e74-9d59-265c12f79c50"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("2d442102-d540-4fb7-9bb7-82d15b792eae"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("4b0ed040-2d69-4803-8a6f-42f1ee636cdd"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("52b91d43-d43e-44b7-93b5-19a5f7937525"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("675532aa-9e36-478f-ad5c-01fa41451fa9"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("6d1f22bd-0c40-4fcf-9489-975036703d12"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("848c03d7-7292-4260-83db-1eb5c978eb6b"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("9dded54b-e8eb-4523-bf5b-b03d16c0add5"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("b3bdd8e1-9e8a-4612-b20f-e1d39f0d81fd"));

            migrationBuilder.DeleteData(
                table: "UserClaim",
                keyColumn: "Id",
                keyValue: new Guid("d1ca0315-4141-49fb-bb81-c6aef781064a"));

            migrationBuilder.DropColumn(
                name: "LastLoginDate",
                table: "User");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "ba56542f-0239-4699-a04a-d33e66f5bb6b");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "1fc3ff8c-5f72-4ae4-873a-a06ad1dc5d27");

            migrationBuilder.InsertData(
                table: "UserClaim",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("adb65c8d-1b39-4801-bce5-3bb2f9904be8"), "ba89bb72-47da-4086-89d8-ba6b76804656", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("1f7050e7-9f46-41d7-bed3-1c94d597f106"), "48ccf48d-20ca-4450-80cb-fd18765b5e26", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("3fe8ad04-62ef-42e0-a97f-1bddb9859abf"), "f22634d2-6ad6-4e16-8b70-36e569267034", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("e693a44e-80f9-42d4-b3fa-b524f699e326"), "cad4c509-90ad-431e-ba96-0f7f93a3d3aa", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("254b52a2-5bca-4678-bd56-0017c9026218"), "d9e63a55-4ba7-40df-9b58-07be58263002", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("cb3515da-adfb-48b5-a42e-aebbc2778192"), "1ea614f8-575c-450a-9c77-ddd400891bf1", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("6310a2ea-6ab3-4979-956c-da548fb30667"), "f9bedee6-149e-4e3a-94fd-f3c46623974c", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("7acbd194-fba0-4404-a6f3-1d6c32810633"), "0b3bd34e-edec-496b-9445-f0717d2a03aa", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("f86a431f-742f-49e6-8604-edbcbcddc1c4"), "7e09b52a-5d56-4148-a437-cc9834930855", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("013decaa-b3f2-416e-a8fe-187460888e60"), "e86ac9df-680e-44a4-a86a-86f196609e4f", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });
        }
    }
}
