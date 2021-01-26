using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marvin.IDP.Migrations
{
    public partial class UserEmailAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("1f6f22ec-b846-47e2-ad24-465cf5f9ca1e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3208ba76-f850-455c-be25-4f609a869b42"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4325cfe1-954f-4d49-acd4-e53ed3d4e5d3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4b784a02-acb7-4d4c-b84e-30b4f6a9acc3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("5c3d60a8-b734-47b1-ac85-9ac3c0b5d322"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7b40324f-bfb9-487e-8999-2e50284239f7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7dd562f6-28c5-4b15-8c49-baff91c2f9e6"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("90e60f97-c6f9-475a-aded-085116bbfb41"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("915c7bd4-ccf7-4243-8622-1d038a4508d7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d22cb986-34f8-4e8b-bb04-2c0135185e3d"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("c2cc8de8-f516-4555-9be1-a6e3601c8ede"), "d8ff0bf0-eec7-431f-a211-de00cdd42998", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("917cab83-2cfc-4169-8e7d-c546e86e5b63"), "2eadca28-e44d-4a95-9465-936c0a6d2fbe", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("74b80e5b-3aa1-4639-887b-970c99a5edf3"), "1324a726-7159-49bc-9679-8b8fdb4e4373", "email", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "frank@someprovider.com" },
                    { new Guid("37df5ba7-df09-43d9-82de-44f9e6a0914e"), "2c241aa8-f58f-44d7-89fc-cbe3e2dba13e", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("6ec781e3-498c-41b0-ba11-b05a4571b841"), "74af3199-2593-469f-bc04-ef2bad8092c5", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("fa16b3ff-4a21-414a-a4db-0774e7852157"), "32096cf1-aeb4-4339-8d0a-e2786bf72a23", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("edb39dc4-33e9-4e71-8c88-32550ebda26c"), "271f07b1-f81e-4ea1-9813-67f0f729fe97", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("9e331734-4fa5-4875-aaf2-e7490494ed4a"), "0bf22381-964f-47d8-a642-75891d376203", "email", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "claire@someprovider.com" },
                    { new Guid("a0ea107a-c7c4-4f2c-9340-c6f1b5e38475"), "eb68f017-b10d-423c-b0c0-9b87f518581a", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("19ebbc0c-7d41-485e-ac56-a63f35871150"), "bcec4bf5-9e26-4184-ae5d-ab4161ee1497", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "d0f3c149-3bdb-47d1-a0f3-622c8ecc5176");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "c5b45bb1-6ee1-428f-bccc-74a5630ef5a9");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("19ebbc0c-7d41-485e-ac56-a63f35871150"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("37df5ba7-df09-43d9-82de-44f9e6a0914e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6ec781e3-498c-41b0-ba11-b05a4571b841"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("74b80e5b-3aa1-4639-887b-970c99a5edf3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("917cab83-2cfc-4169-8e7d-c546e86e5b63"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9e331734-4fa5-4875-aaf2-e7490494ed4a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a0ea107a-c7c4-4f2c-9340-c6f1b5e38475"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c2cc8de8-f516-4555-9be1-a6e3601c8ede"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("edb39dc4-33e9-4e71-8c88-32550ebda26c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("fa16b3ff-4a21-414a-a4db-0774e7852157"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("4b784a02-acb7-4d4c-b84e-30b4f6a9acc3"), "7cd1ca54-2448-4ad9-aebf-eea4e31c8a10", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("5c3d60a8-b734-47b1-ac85-9ac3c0b5d322"), "6160ab95-758f-411f-8da0-5e48dd2a612a", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("7dd562f6-28c5-4b15-8c49-baff91c2f9e6"), "04cf2ff2-0565-41fe-90cc-e07b531a7dba", "email", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "frank@someprovider.com" },
                    { new Guid("90e60f97-c6f9-475a-aded-085116bbfb41"), "9a337e99-02dd-420b-af7c-93aa326e4f8e", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("4325cfe1-954f-4d49-acd4-e53ed3d4e5d3"), "418eadd7-c8ed-4988-a5ec-98690eeb8ebf", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("3208ba76-f850-455c-be25-4f609a869b42"), "76e8f3ca-6e78-407f-83d3-9e644d1b8dd5", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("7b40324f-bfb9-487e-8999-2e50284239f7"), "35da816b-9c8f-43b9-8fb4-4c32820a2721", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("915c7bd4-ccf7-4243-8622-1d038a4508d7"), "710cc64f-24a2-4448-a9ad-99b9f4008e57", "email", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "claire@someprovider.com" },
                    { new Guid("d22cb986-34f8-4e8b-bb04-2c0135185e3d"), "effb6b1b-8f17-4d10-8844-c5665e3d3384", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("1f6f22ec-b846-47e2-ad24-465cf5f9ca1e"), "c582e014-b491-4767-a5e3-dc3e46b01f28", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "f8702749-6d75-47de-b24b-42a1e763cbfc");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "765d4a55-2de1-4acb-91f4-50a091caaf93");
        }
    }
}
