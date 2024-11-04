using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Landing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddAdditionalImagesToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf5968c4-6f1f-4c6e-9c97-19ff8134062c", "26ffa1a0-a7d9-4a72-8ca2-885884dbd20c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f8a9f89a-2299-4859-877a-6741c8c462fa", "8b9bc37d-dd98-4fc1-9899-2b14fc91e759" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "25ea4031-6b14-4fab-9518-f74cc3da8db9", "cdcbaa1d-8575-443f-aae5-43f69d11190b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25ea4031-6b14-4fab-9518-f74cc3da8db9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf5968c4-6f1f-4c6e-9c97-19ff8134062c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8a9f89a-2299-4859-877a-6741c8c462fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26ffa1a0-a7d9-4a72-8ca2-885884dbd20c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b9bc37d-dd98-4fc1-9899-2b14fc91e759");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdcbaa1d-8575-443f-aae5-43f69d11190b");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalImgNames",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5b23b8bb-fb7c-4ab3-8078-311e71f531af", null, "User", "USER" },
                    { "7f2ea060-2217-4ea7-8f5d-0647cf62f097", null, "Admin", "ADMIN" },
                    { "9488aa82-35d0-407c-9249-cd6f35e2c6c0", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "3eaac499-73ce-4f14-a931-88574d329675", 0, "d6d80b1b-9620-439c-8da1-629fdd39a1a3", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEK24E1NH4gSqIclCnVXeBc5L5lgJLKESgKZAKc0BODwrMuPTDmpRkjPwa+9GLxnirA==", null, false, "9a7cbd0b-e0be-4e40-8b10-79949d4ae4b0", false, null, "admin@outlook.com" },
                    { "a1454190-5614-46b7-a0e4-5a3c39acdf0a", 0, "6cee1f58-c9a5-423d-b71b-73cf8fc881da", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEDNF/2zi9PPMYB3oJ0xwu1R7cAyq8OWWZc1AqVIHqOiJ7jFFSFUQCX+0ZG+YaJ32hQ==", null, false, "464ffa30-6ad5-459f-8445-1148d61e152e", false, null, "user@outlook.sa" },
                    { "a9bb0e7f-7cb3-4b27-82f6-35989c3f4ea5", 0, "75b7cf95-ac24-45de-861e-40baa30752fa", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEIl4+1aE8yGzPRlxT9pRFz7WC6fKhMTk5GEua/1a1AIVR+sF4wshqAtPTxJyOYNEVw==", null, false, "219c5521-22de-4ece-b4af-16393d21101d", false, null, "superadmin@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7f2ea060-2217-4ea7-8f5d-0647cf62f097", "3eaac499-73ce-4f14-a931-88574d329675" },
                    { "5b23b8bb-fb7c-4ab3-8078-311e71f531af", "a1454190-5614-46b7-a0e4-5a3c39acdf0a" },
                    { "9488aa82-35d0-407c-9249-cd6f35e2c6c0", "a9bb0e7f-7cb3-4b27-82f6-35989c3f4ea5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7f2ea060-2217-4ea7-8f5d-0647cf62f097", "3eaac499-73ce-4f14-a931-88574d329675" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b23b8bb-fb7c-4ab3-8078-311e71f531af", "a1454190-5614-46b7-a0e4-5a3c39acdf0a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9488aa82-35d0-407c-9249-cd6f35e2c6c0", "a9bb0e7f-7cb3-4b27-82f6-35989c3f4ea5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b23b8bb-fb7c-4ab3-8078-311e71f531af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f2ea060-2217-4ea7-8f5d-0647cf62f097");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9488aa82-35d0-407c-9249-cd6f35e2c6c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3eaac499-73ce-4f14-a931-88574d329675");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1454190-5614-46b7-a0e4-5a3c39acdf0a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9bb0e7f-7cb3-4b27-82f6-35989c3f4ea5");

            migrationBuilder.DropColumn(
                name: "AdditionalImgNames",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25ea4031-6b14-4fab-9518-f74cc3da8db9", null, "User", "USER" },
                    { "bf5968c4-6f1f-4c6e-9c97-19ff8134062c", null, "Admin", "ADMIN" },
                    { "f8a9f89a-2299-4859-877a-6741c8c462fa", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "26ffa1a0-a7d9-4a72-8ca2-885884dbd20c", 0, "3977d190-617b-4d53-a6f1-545e04187298", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEHOfBAZF0GyiwOK3Q59Em6iQ1lNrQ6BuMHdMEOt0EjwXQC0Nm5yv7bBJjNjAYEtDfw==", null, false, "e57fad94-06b4-46c7-97b5-abd7f9720f00", false, null, "admin@outlook.com" },
                    { "8b9bc37d-dd98-4fc1-9899-2b14fc91e759", 0, "fb2bfa6b-f244-480f-be1a-1f7c7e0f8901", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEEVo7ovSfmHqjQEaba+hrSgEUnSVMy0PUi7aBTNOOAgxwDpXyjj7qaTKomSRhN8vbA==", null, false, "8a752086-ea2a-4b0b-9b54-c95254a443ee", false, null, "superadmin@outlook.com" },
                    { "cdcbaa1d-8575-443f-aae5-43f69d11190b", 0, "4a56bfe3-ed41-4b53-9ed4-a0d43a1e6b13", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEP8jxTznf0lCC1ACOKMnv7FG7xu8E7ZGBIzCC4pQyrX270DypNjAPBu0L4aghiASGg==", null, false, "31df92ea-2712-449f-ab42-77561a822f88", false, null, "user@outlook.sa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bf5968c4-6f1f-4c6e-9c97-19ff8134062c", "26ffa1a0-a7d9-4a72-8ca2-885884dbd20c" },
                    { "f8a9f89a-2299-4859-877a-6741c8c462fa", "8b9bc37d-dd98-4fc1-9899-2b14fc91e759" },
                    { "25ea4031-6b14-4fab-9518-f74cc3da8db9", "cdcbaa1d-8575-443f-aae5-43f69d11190b" }
                });
        }
    }
}
