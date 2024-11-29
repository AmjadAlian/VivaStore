using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Landing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddIsNewAndDiscountPriceToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsNew",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "054106b4-72bd-402c-8d6a-3354009c3c24", null, "SuperAdmin", "SUPERADMIN" },
                    { "1c435d63-7883-4d82-889c-4c6316ac2c0b", null, "User", "USER" },
                    { "ecf4e6da-af96-414c-b03c-c924b3ca3084", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "338bfdc8-4be9-4a19-9c60-a65bfae6d124", 0, "8bd9f362-de8e-424d-887b-010fcf280646", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEH79qUwe1MW6RbieN7KnSROMQvgH8YueCxw0BsvXnBxpzLkPhI4QjQqLLS71r9QayA==", null, false, "71c4454d-108f-47d8-ae82-e4b91a823b40", false, null, "admin@outlook.com" },
                    { "9ee6a8eb-8586-49fd-826f-5c2ff6b42b09", 0, "b6674983-0f9a-46aa-be17-ed840baa5c36", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEDmdu8RURudNxsQhzFkduanS4RSMPp+Q8Wf98n6s+9ZEQPH2M6H/nwDo/FnveBf4Fw==", null, false, "4fdd751e-4b63-4b85-8352-f890567617e8", false, null, "superadmin@outlook.com" },
                    { "fa6f6992-c95b-47a4-ac6f-9e341eb40049", 0, "59880dab-8dd7-4057-a0a8-3918286f3c97", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEMlJbHCXB5uwqD6RABkfwoyxPSYBbbVl+nM9RSzw9wUvJgzsttbRgN8WulRwpsQ6Ag==", null, false, "4f2e0515-08d3-4670-84dc-07fb77ee26c5", false, null, "user@outlook.sa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ecf4e6da-af96-414c-b03c-c924b3ca3084", "338bfdc8-4be9-4a19-9c60-a65bfae6d124" },
                    { "054106b4-72bd-402c-8d6a-3354009c3c24", "9ee6a8eb-8586-49fd-826f-5c2ff6b42b09" },
                    { "1c435d63-7883-4d82-889c-4c6316ac2c0b", "fa6f6992-c95b-47a4-ac6f-9e341eb40049" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecf4e6da-af96-414c-b03c-c924b3ca3084", "338bfdc8-4be9-4a19-9c60-a65bfae6d124" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "054106b4-72bd-402c-8d6a-3354009c3c24", "9ee6a8eb-8586-49fd-826f-5c2ff6b42b09" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1c435d63-7883-4d82-889c-4c6316ac2c0b", "fa6f6992-c95b-47a4-ac6f-9e341eb40049" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "054106b4-72bd-402c-8d6a-3354009c3c24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c435d63-7883-4d82-889c-4c6316ac2c0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecf4e6da-af96-414c-b03c-c924b3ca3084");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "338bfdc8-4be9-4a19-9c60-a65bfae6d124");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ee6a8eb-8586-49fd-826f-5c2ff6b42b09");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa6f6992-c95b-47a4-ac6f-9e341eb40049");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsNew",
                table: "Products");

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
    }
}
