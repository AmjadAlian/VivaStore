using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Landing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addTotalAmountToCartTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fa94a3e8-d314-4096-afd3-c5fe1cd86f92", "4f5c9e94-30df-4059-991c-430714b54735" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fba03ddc-08ed-44cd-b297-a115b9118cd4", "7a6c082a-d3ac-4e69-81c5-bffb985c1a39" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80d92c9b-99db-4903-9f70-1b8171893384", "bd88bf6c-9793-4aaa-96a6-ff8dd506e96a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80d92c9b-99db-4903-9f70-1b8171893384");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa94a3e8-d314-4096-afd3-c5fe1cd86f92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fba03ddc-08ed-44cd-b297-a115b9118cd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5c9e94-30df-4059-991c-430714b54735");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a6c082a-d3ac-4e69-81c5-bffb985c1a39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd88bf6c-9793-4aaa-96a6-ff8dd506e96a");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "Carts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Carts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "80d92c9b-99db-4903-9f70-1b8171893384", null, "Admin", "ADMIN" },
                    { "fa94a3e8-d314-4096-afd3-c5fe1cd86f92", null, "User", "USER" },
                    { "fba03ddc-08ed-44cd-b297-a115b9118cd4", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "4f5c9e94-30df-4059-991c-430714b54735", 0, "184d0f28-1cb0-43fc-8c14-39318501d1ac", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEKs7GHLjH/otYxdVROKHmjPRrI3kuovtcHog6oMIAq3z/T1k/OmZam3+2DFVOSFI0g==", null, false, "6d063a4e-a76e-4384-8887-9e6a6c89e23f", false, null, "user@outlook.sa" },
                    { "7a6c082a-d3ac-4e69-81c5-bffb985c1a39", 0, "cf33e694-0674-4582-b628-e432dc593634", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEIifm98H/wpa6ZxbZALbLIVknhAmoSoVAR1277gTFYrkeUnbuWHjHx9DEyRjb2f67w==", null, false, "c634d2f3-89ec-4f51-9c53-edbde79ec527", false, null, "superadmin@outlook.com" },
                    { "bd88bf6c-9793-4aaa-96a6-ff8dd506e96a", 0, "2aa3838b-c715-4632-89db-a3748fc2d5e2", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEOdV+iq5Vxkixi5Bl4/StTqC+i8a54jJvhW4rI/2fECWuctAptuQzrBz/ZW6NG1f7Q==", null, false, "ddf0c7ad-c1c3-4cf3-a340-dd9647faf639", false, null, "admin@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fa94a3e8-d314-4096-afd3-c5fe1cd86f92", "4f5c9e94-30df-4059-991c-430714b54735" },
                    { "fba03ddc-08ed-44cd-b297-a115b9118cd4", "7a6c082a-d3ac-4e69-81c5-bffb985c1a39" },
                    { "80d92c9b-99db-4903-9f70-1b8171893384", "bd88bf6c-9793-4aaa-96a6-ff8dd506e96a" }
                });
        }
    }
}
