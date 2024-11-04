using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Landing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addTitleAndSubTitleToCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d8b895ac-e273-4ad4-bb66-5aab299576ab", "70660ae1-492f-418b-b4b1-1b0a3620c4e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1129519b-58af-4ba8-8a62-3290d44fc672", "74e6fe9b-fd4c-4292-8468-18e8119ec322" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2ff9380f-341e-4c74-9539-17bcc6fc9e92", "fe707ee4-8352-4b6a-a4a7-ff0135d01771" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1129519b-58af-4ba8-8a62-3290d44fc672");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ff9380f-341e-4c74-9539-17bcc6fc9e92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8b895ac-e273-4ad4-bb66-5aab299576ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70660ae1-492f-418b-b4b1-1b0a3620c4e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74e6fe9b-fd4c-4292-8468-18e8119ec322");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe707ee4-8352-4b6a-a4a7-ff0135d01771");

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1129519b-58af-4ba8-8a62-3290d44fc672", null, "User", "USER" },
                    { "2ff9380f-341e-4c74-9539-17bcc6fc9e92", null, "SuperAdmin", "SUPERADMIN" },
                    { "d8b895ac-e273-4ad4-bb66-5aab299576ab", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "70660ae1-492f-418b-b4b1-1b0a3620c4e5", 0, "f90ad730-f5ff-499e-9fca-7f99b32a1b61", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEBkTQi7sgJgrESeRc/kYV/nSMhrkVKU4V+IPgT59zo6s3GIBTbwTxrIi+StkXFkRww==", null, false, "a4a5cbf5-ce69-4d48-9777-747146135822", false, null, "admin@outlook.com" },
                    { "74e6fe9b-fd4c-4292-8468-18e8119ec322", 0, "fe747f84-e85c-4872-8057-8b176ad0b4aa", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEOAUz6u6h0Dh7rKGZJyzkKsYe4Nu6853O6DsAL8RXMEyH4V1OScTc3gaX4Sxe1YgWQ==", null, false, "cce55a9c-102d-48c9-96ef-856b383f631e", false, null, "user@outlook.sa" },
                    { "fe707ee4-8352-4b6a-a4a7-ff0135d01771", 0, "395ec334-2b8d-45b3-9a38-6db987c5380d", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEEzDxSxU7tVk+Ev0nsdVmIv+TB4928QiTLz16AIbGONBC3PQRojAtsR7qFFho2TPrA==", null, false, "9656e397-ff8b-4f93-8fc4-269bd5b3ab0b", false, null, "superadmin@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d8b895ac-e273-4ad4-bb66-5aab299576ab", "70660ae1-492f-418b-b4b1-1b0a3620c4e5" },
                    { "1129519b-58af-4ba8-8a62-3290d44fc672", "74e6fe9b-fd4c-4292-8468-18e8119ec322" },
                    { "2ff9380f-341e-4c74-9539-17bcc6fc9e92", "fe707ee4-8352-4b6a-a4a7-ff0135d01771" }
                });
        }
    }
}
