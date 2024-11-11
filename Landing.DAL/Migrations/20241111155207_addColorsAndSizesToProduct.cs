using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Landing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addColorsAndSizesToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4bf8018-b5f6-4d14-abf8-65e10cb01a83", "556f9674-bc54-4217-90ed-9a628c1aa5d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de40f5e6-0799-4677-af9e-28b45fe45ba4", "c0b9f84f-8288-4b0b-98eb-a652a0ab9e90" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ab128be-c899-4151-8623-468e46ffdca8", "f6be4e2d-b6da-497e-b09e-4088f2bb45ce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ab128be-c899-4151-8623-468e46ffdca8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de40f5e6-0799-4677-af9e-28b45fe45ba4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4bf8018-b5f6-4d14-abf8-65e10cb01a83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "556f9674-bc54-4217-90ed-9a628c1aa5d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0b9f84f-8288-4b0b-98eb-a652a0ab9e90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6be4e2d-b6da-497e-b09e-4088f2bb45ce");

            migrationBuilder.AddColumn<string>(
                name: "Colors",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sizes",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b2e4e7c-190e-4342-9e92-fc706624e801", null, "User", "USER" },
                    { "45c0af36-a3bd-438d-bde2-09ac5f4a587a", null, "Admin", "ADMIN" },
                    { "a9ada7ed-04bb-4769-b915-25beb8693637", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "5cec6c18-44b8-4eb0-9e50-5db9846ce691", 0, "ec2fa73d-753d-4a9b-b50e-a1cfdff92a52", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEEqvFuNW4+Ew5yFcNiUHhN3+qUieTHnEJsmmTzq2wAbjCsFJhDFxLWHIoj8CwDd1tA==", null, false, "f1f0013e-7d0d-4ff4-9199-b495f6b43226", false, null, "user@outlook.sa" },
                    { "7d50ce81-1d5c-426d-b759-52767fc83c9b", 0, "27d88e2c-d5e7-4190-b63a-a97fc74ac256", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEH1Vvp8ryE5Bb7Jy/AaV4G/rJBkayvUYnJYhjK3bq4S1jVXuU45pbyJJFfmoPcwiJQ==", null, false, "45b7f663-b183-4af0-9810-b47c9e316aa7", false, null, "superadmin@outlook.com" },
                    { "b4cb21d1-3739-4005-afd0-34ea12e97980", 0, "60d8a620-6f6a-4486-8c9d-50d2988d954b", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEIg1D6ubYttC6rfgLDB/2JFCqijzL1IqmA65M4qIrAwvHGfKj6jGw9vE9Pntm5tz2w==", null, false, "1a28c259-a1b0-4ad9-94d1-457de73f8396", false, null, "admin@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1b2e4e7c-190e-4342-9e92-fc706624e801", "5cec6c18-44b8-4eb0-9e50-5db9846ce691" },
                    { "a9ada7ed-04bb-4769-b915-25beb8693637", "7d50ce81-1d5c-426d-b759-52767fc83c9b" },
                    { "45c0af36-a3bd-438d-bde2-09ac5f4a587a", "b4cb21d1-3739-4005-afd0-34ea12e97980" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1b2e4e7c-190e-4342-9e92-fc706624e801", "5cec6c18-44b8-4eb0-9e50-5db9846ce691" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a9ada7ed-04bb-4769-b915-25beb8693637", "7d50ce81-1d5c-426d-b759-52767fc83c9b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "45c0af36-a3bd-438d-bde2-09ac5f4a587a", "b4cb21d1-3739-4005-afd0-34ea12e97980" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b2e4e7c-190e-4342-9e92-fc706624e801");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45c0af36-a3bd-438d-bde2-09ac5f4a587a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9ada7ed-04bb-4769-b915-25beb8693637");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cec6c18-44b8-4eb0-9e50-5db9846ce691");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d50ce81-1d5c-426d-b759-52767fc83c9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4cb21d1-3739-4005-afd0-34ea12e97980");

            migrationBuilder.DropColumn(
                name: "Colors",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Sizes",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "CartItems");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8ab128be-c899-4151-8623-468e46ffdca8", null, "SuperAdmin", "SUPERADMIN" },
                    { "de40f5e6-0799-4677-af9e-28b45fe45ba4", null, "User", "USER" },
                    { "f4bf8018-b5f6-4d14-abf8-65e10cb01a83", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "556f9674-bc54-4217-90ed-9a628c1aa5d4", 0, "5b96c652-8c51-4a99-af8a-3de9bd2a60a1", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEPIxCx93nMDaOOpn+CSbRcv2afshmYliPtFMk7cNEoNJsBfPQT4OTjONg87YFvq3YQ==", null, false, "ed322223-8f12-4a7b-90a6-fa809185f365", false, null, "admin@outlook.com" },
                    { "c0b9f84f-8288-4b0b-98eb-a652a0ab9e90", 0, "b47ef8d9-9602-450e-a6bf-11aeea5eb6b2", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEOm6ZQHJ071tHewsvCfXH1njRpzCTqDbzC/LvAKaA8MtqOQr8LV7Dah0YHVVrS6m2A==", null, false, "583460a4-e4b2-46fc-b78f-52461a631d4f", false, null, "user@outlook.sa" },
                    { "f6be4e2d-b6da-497e-b09e-4088f2bb45ce", 0, "bcb93629-6c86-4c50-abd5-a2d1061c68c5", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEB8uTvvqyCfx3kk2SYeOKUyvZ6revFllrk9/r4DuaCfBsVO/ZAvT9mb2ise6xP1PDw==", null, false, "1cbe66fa-5ea8-4a11-a605-e87a4a215580", false, null, "superadmin@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f4bf8018-b5f6-4d14-abf8-65e10cb01a83", "556f9674-bc54-4217-90ed-9a628c1aa5d4" },
                    { "de40f5e6-0799-4677-af9e-28b45fe45ba4", "c0b9f84f-8288-4b0b-98eb-a652a0ab9e90" },
                    { "8ab128be-c899-4151-8623-468e46ffdca8", "f6be4e2d-b6da-497e-b09e-4088f2bb45ce" }
                });
        }
    }
}
