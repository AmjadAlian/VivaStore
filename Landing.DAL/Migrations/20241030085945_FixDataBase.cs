using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Landing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FixDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0bd3d32-749e-455a-aae0-166949b3d56d", "405b1fab-6750-42b5-bb0d-781c9cf07ff2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef623b30-0c04-4355-88da-ec863400a6bb", "a2e684f1-2f5e-46c7-9e81-0098c410e6f1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "434cae65-0a56-46e4-9d45-f362c645aeb0", "a305e55c-2f76-4877-bbb0-18e84bd723a3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "434cae65-0a56-46e4-9d45-f362c645aeb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0bd3d32-749e-455a-aae0-166949b3d56d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef623b30-0c04-4355-88da-ec863400a6bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "405b1fab-6750-42b5-bb0d-781c9cf07ff2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2e684f1-2f5e-46c7-9e81-0098c410e6f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a305e55c-2f76-4877-bbb0-18e84bd723a3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52d3281e-a731-4b7b-8a06-91b6a8226b21", null, "User", "USER" },
                    { "6f0fa17a-3717-492e-9763-5035f837b375", null, "Admin", "ADMIN" },
                    { "f98e9f46-9b36-4cdd-875c-4f2bc0fd840f", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "474dc51b-fa1b-44a1-863e-d494c46bda52", 0, "91a864b1-918b-478d-9bed-2cbb9e129a0b", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEMEslpISb07zxjRe6X30i8fwYaAcGF8cVoWOeW7Unm0Ya+aw/uKq2Pm3Ckb1mq4slw==", null, false, "70ff9c8d-c8f7-497b-bcda-fcd4cb1c3753", false, null, "user@outlook.sa" },
                    { "d6e02f74-2705-4f53-b79c-fa240ed0ead6", 0, "826b0268-cfdb-4be3-8bf2-74463d87a1eb", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAECsa+BRFO5RaJDyR8uVvHg2dJ1xkyNAtxfwUGuxWgy4kVCj87YeH8QjSjxnIFl0SkQ==", null, false, "e66a7a6c-ee7d-494d-88aa-79a3b5d455e9", false, null, "admin@outlook.com" },
                    { "df996d3e-8b6f-412d-8e01-6f22fe1aa616", 0, "3c0c7219-d6f1-48c4-8bc9-533bc884b01f", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEBrWmuIG27VV5HLhhGZM1hvWqTRUkTMAUmeFY43/1jYPnBRonYDYkA5ntClk1z440Q==", null, false, "72ca3300-a8fc-44e9-b277-b3adf03a1fe8", false, null, "superadmin@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "52d3281e-a731-4b7b-8a06-91b6a8226b21", "474dc51b-fa1b-44a1-863e-d494c46bda52" },
                    { "6f0fa17a-3717-492e-9763-5035f837b375", "d6e02f74-2705-4f53-b79c-fa240ed0ead6" },
                    { "f98e9f46-9b36-4cdd-875c-4f2bc0fd840f", "df996d3e-8b6f-412d-8e01-6f22fe1aa616" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "52d3281e-a731-4b7b-8a06-91b6a8226b21", "474dc51b-fa1b-44a1-863e-d494c46bda52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f0fa17a-3717-492e-9763-5035f837b375", "d6e02f74-2705-4f53-b79c-fa240ed0ead6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f98e9f46-9b36-4cdd-875c-4f2bc0fd840f", "df996d3e-8b6f-412d-8e01-6f22fe1aa616" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52d3281e-a731-4b7b-8a06-91b6a8226b21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f0fa17a-3717-492e-9763-5035f837b375");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f98e9f46-9b36-4cdd-875c-4f2bc0fd840f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "474dc51b-fa1b-44a1-863e-d494c46bda52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6e02f74-2705-4f53-b79c-fa240ed0ead6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df996d3e-8b6f-412d-8e01-6f22fe1aa616");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "434cae65-0a56-46e4-9d45-f362c645aeb0", null, "User", "USER" },
                    { "c0bd3d32-749e-455a-aae0-166949b3d56d", null, "Admin", "ADMIN" },
                    { "ef623b30-0c04-4355-88da-ec863400a6bb", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "405b1fab-6750-42b5-bb0d-781c9cf07ff2", 0, "d865580b-7bc0-4ed2-99dc-28991400a944", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEBrPMcEP+ngAe5xKc2JeSAKV6Ikd6KsZf3hRyY788UJOCZbQEHmLmQlzfaFf/OuAVw==", null, false, "d483288d-c884-435f-8ba2-e60bd79f0855", false, null, "admin@outlook.com" },
                    { "a2e684f1-2f5e-46c7-9e81-0098c410e6f1", 0, "358ed37c-ea14-4cf6-9a7e-4bdc093e0d41", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEOhENOyIwORzqB22waD0ssyce++dgScmIrZ8PKzacuAkr3LgPLkCgkoWq0zaD4KpWg==", null, false, "4da6b390-bfbe-4ac1-8afe-5713034e3c6d", false, null, "superadmin@outlook.com" },
                    { "a305e55c-2f76-4877-bbb0-18e84bd723a3", 0, "93d8849e-9358-436d-aad2-aa7fddd319f1", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEC8/01BVfgrB4DMGrEpgG658SobZ7DSd1eEx3SLWZfB35iWgjRQTCk6E9J6gHi/xAw==", null, false, "eca9bbef-fec5-4823-9387-cd3d88d4a9df", false, null, "user@outlook.sa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c0bd3d32-749e-455a-aae0-166949b3d56d", "405b1fab-6750-42b5-bb0d-781c9cf07ff2" },
                    { "ef623b30-0c04-4355-88da-ec863400a6bb", "a2e684f1-2f5e-46c7-9e81-0098c410e6f1" },
                    { "434cae65-0a56-46e4-9d45-f362c645aeb0", "a305e55c-2f76-4877-bbb0-18e84bd723a3" }
                });
        }
    }
}
