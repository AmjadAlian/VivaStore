using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Landing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class setDiscountPriceRequeird : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6675e3af-233b-4fc2-a443-fd18babb3020", null, "User", "USER" },
                    { "add95ad3-3a8c-438e-9f0a-f20b878491e2", null, "Admin", "ADMIN" },
                    { "b14c4944-27bd-4d3f-b897-692b4e607287", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "471e92fc-92f8-49cc-a87f-e776109dbcd2", 0, "3bbba01d-330c-4255-80fe-80458bc754aa", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEPFaXzMCaMdjsF6CwRUt892Cst9v15EZN6dwj4mREOCobG8FbGmpwfFaL3nA3K+yzg==", null, false, "5e1a9f68-bdbe-4b90-b2ea-6b5104750c7f", false, null, "user@outlook.sa" },
                    { "7f587113-598f-435d-8449-c33cd94902d7", 0, "a5170606-66ee-4e8a-9155-87cd0b3bfdc1", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAENKDeVHVUZDQfndMfwD7qVOWmt0TQh7Ngyzz1ANOb8K2IheuasU6WuocHHKz5Bo/9Q==", null, false, "62bd04a7-be3a-4930-8d2c-429c9b0912c9", false, null, "superadmin@outlook.com" },
                    { "de177380-f4e0-44ff-8999-8a2b4138df85", 0, "838ba6a1-6aa3-4da5-99f2-b7e356c4f542", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEKwh9Jn9V3+/HdJ3/qM9QFHpIYiMVfKTo/7s1OcGu/CynUfXDiZE5dokP9DGMKbb2g==", null, false, "7c952d78-c737-4841-b8c5-34d6cfb7e489", false, null, "admin@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6675e3af-233b-4fc2-a443-fd18babb3020", "471e92fc-92f8-49cc-a87f-e776109dbcd2" },
                    { "b14c4944-27bd-4d3f-b897-692b4e607287", "7f587113-598f-435d-8449-c33cd94902d7" },
                    { "add95ad3-3a8c-438e-9f0a-f20b878491e2", "de177380-f4e0-44ff-8999-8a2b4138df85" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6675e3af-233b-4fc2-a443-fd18babb3020", "471e92fc-92f8-49cc-a87f-e776109dbcd2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b14c4944-27bd-4d3f-b897-692b4e607287", "7f587113-598f-435d-8449-c33cd94902d7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "add95ad3-3a8c-438e-9f0a-f20b878491e2", "de177380-f4e0-44ff-8999-8a2b4138df85" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6675e3af-233b-4fc2-a443-fd18babb3020");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "add95ad3-3a8c-438e-9f0a-f20b878491e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b14c4944-27bd-4d3f-b897-692b4e607287");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "471e92fc-92f8-49cc-a87f-e776109dbcd2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f587113-598f-435d-8449-c33cd94902d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de177380-f4e0-44ff-8999-8a2b4138df85");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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
    }
}
