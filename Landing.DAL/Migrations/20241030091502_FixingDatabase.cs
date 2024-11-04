using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Landing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FixingDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Carts",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d1df68b-7d60-41f9-a63b-1771687bf9a5", null, "Admin", "ADMIN" },
                    { "88f218dc-babd-4e11-8a34-434d998c1814", null, "SuperAdmin", "SUPERADMIN" },
                    { "ebd6a14e-c422-4ef4-b99b-464e5f50f03f", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "2ad72a3a-99be-4773-b6a3-9a4959c7ef83", 0, "b4192dc5-2f71-4115-967e-bf47c43dc9c2", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEG1sG746WZVzZ8LGcdie6YSQqwk7nRsYKfie8mL1v0s4+Ol7qD9oMUQbO7tMF+yK4Q==", null, false, "8f60e27d-9060-4cee-a95a-726c22e585c0", false, null, "user@outlook.sa" },
                    { "46e3c072-b974-43e5-912c-a5581eaeda5a", 0, "b90c1257-3301-4d28-819c-f2d91d00ccaa", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEMxgoGH2wYpuX2+sscrhJ0AX0LTE2hHTg4el3K4ikC8hT0t0bQ6Q8bRaQwSm0SnbHw==", null, false, "c8bcffad-7b49-49bd-a0ef-ffb782805583", false, null, "superadmin@outlook.com" },
                    { "617829d1-1f3c-4713-bb02-8c094dbbcd8e", 0, "dad4b3c1-2e76-487c-94b0-e46d5bb215a5", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAECr2GDz8yEKKmTyY5dGzWph3ba5VeqsK0zWWtuydaqTOxfGg+VRfCFjSJLHj3uWNIA==", null, false, "c9e16c03-8b61-4d02-a2f6-25ec332eb7bd", false, null, "admin@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ebd6a14e-c422-4ef4-b99b-464e5f50f03f", "2ad72a3a-99be-4773-b6a3-9a4959c7ef83" },
                    { "88f218dc-babd-4e11-8a34-434d998c1814", "46e3c072-b974-43e5-912c-a5581eaeda5a" },
                    { "0d1df68b-7d60-41f9-a63b-1771687bf9a5", "617829d1-1f3c-4713-bb02-8c094dbbcd8e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebd6a14e-c422-4ef4-b99b-464e5f50f03f", "2ad72a3a-99be-4773-b6a3-9a4959c7ef83" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88f218dc-babd-4e11-8a34-434d998c1814", "46e3c072-b974-43e5-912c-a5581eaeda5a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0d1df68b-7d60-41f9-a63b-1771687bf9a5", "617829d1-1f3c-4713-bb02-8c094dbbcd8e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d1df68b-7d60-41f9-a63b-1771687bf9a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88f218dc-babd-4e11-8a34-434d998c1814");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebd6a14e-c422-4ef4-b99b-464e5f50f03f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ad72a3a-99be-4773-b6a3-9a4959c7ef83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46e3c072-b974-43e5-912c-a5581eaeda5a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "617829d1-1f3c-4713-bb02-8c094dbbcd8e");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Carts",
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
    }
}
