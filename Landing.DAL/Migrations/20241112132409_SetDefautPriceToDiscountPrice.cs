using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Landing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SetDefautPriceToDiscountPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<bool>(
                name: "IsNew",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c01cd14-0ae4-48de-bbba-ca753b0e18d1", null, "User", "USER" },
                    { "50e671b5-1399-469d-9d48-8185d296e3c8", null, "SuperAdmin", "SUPERADMIN" },
                    { "e251129a-d0c0-4bff-a1b5-3a2e9014ff6d", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "84928c44-57e3-4527-abbf-ab6ce23c71aa", 0, "1f8d957d-0eb9-4ae3-8814-9687f7e23a33", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEPb6dZsSRFHLr8fEEt7laRHvhifPbhgYiuTuH6B/nUnBePTozKutW7VW3o5HuYCx1Q==", null, false, "2ca9a50f-b58a-49af-bc30-aa052dfe73d4", false, null, "superadmin@outlook.com" },
                    { "a2e9d598-a2ab-4e64-aa34-1eebfded1da4", 0, "e00ea1e7-c6f5-43f2-a240-228287e21479", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEDJnKrK9HnnUQbT+CWG9Sj+PBj/Fwu73tujAaTsfzeqZjgSBgG2LZmqZmzekwX606g==", null, false, "62738442-ea52-403c-b180-21cd08319345", false, null, "user@outlook.sa" },
                    { "ea6e0ea8-12df-481a-8170-5cff54bf66fa", 0, "1ddac2a1-04e1-40c3-b542-e70aad59faac", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEFOIkBzD+X4UUxkEqzntzNAlKeKpzb8piobuiPJQXRkqHhgL/hZEwpKmh48uyurnSg==", null, false, "8abc73e3-7a0b-43b1-bedb-4a9964141b8e", false, null, "admin@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "50e671b5-1399-469d-9d48-8185d296e3c8", "84928c44-57e3-4527-abbf-ab6ce23c71aa" },
                    { "0c01cd14-0ae4-48de-bbba-ca753b0e18d1", "a2e9d598-a2ab-4e64-aa34-1eebfded1da4" },
                    { "e251129a-d0c0-4bff-a1b5-3a2e9014ff6d", "ea6e0ea8-12df-481a-8170-5cff54bf66fa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "50e671b5-1399-469d-9d48-8185d296e3c8", "84928c44-57e3-4527-abbf-ab6ce23c71aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0c01cd14-0ae4-48de-bbba-ca753b0e18d1", "a2e9d598-a2ab-4e64-aa34-1eebfded1da4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e251129a-d0c0-4bff-a1b5-3a2e9014ff6d", "ea6e0ea8-12df-481a-8170-5cff54bf66fa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c01cd14-0ae4-48de-bbba-ca753b0e18d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50e671b5-1399-469d-9d48-8185d296e3c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e251129a-d0c0-4bff-a1b5-3a2e9014ff6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84928c44-57e3-4527-abbf-ab6ce23c71aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2e9d598-a2ab-4e64-aa34-1eebfded1da4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea6e0ea8-12df-481a-8170-5cff54bf66fa");

            migrationBuilder.AlterColumn<bool>(
                name: "IsNew",
                table: "Products",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

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
    }
}
