using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MST.IDP.Data.Migrations
{
    public partial class ChangeInSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "3f12b280-95c7-4439-80b6-77f9ee9eb743", "Password" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "bf6cde81-e32a-4dc9-bd81-823321a03d99");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "c8d1c3a2-699e-4082-a62d-89d11ebea562", "AQAAAAEAACcQAAAAEAAP1QAc8J6Ri88b4+01i2M+u9amqIhA8Jo1pvdIWTO0Le3NPqPAyQzrbWYQHSD0WA==" });

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
    }
}
