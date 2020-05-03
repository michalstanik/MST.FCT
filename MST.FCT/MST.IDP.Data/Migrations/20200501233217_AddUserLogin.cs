using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MST.IDP.Data.Migrations
{
    public partial class AddUserLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Provider = table.Column<string>(maxLength: 200, nullable: false),
                    ProviderIdentityKey = table.Column<string>(maxLength: 200, nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogin_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_UserId",
                table: "UserLogin",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLogin");

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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "e482d91d-7a39-4c47-8aa0-6107f0a3c2fb");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "ddd9d4ac-979d-4726-966f-a9e380615169");

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
    }
}
