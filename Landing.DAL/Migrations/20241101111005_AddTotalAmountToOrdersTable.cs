using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Landing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddTotalAmountToOrdersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0700153e-4700-4e70-94a2-780b9afc76f6", null, "Admin", "ADMIN" },
                    { "b3428777-fadb-479f-9dc1-a85a8285d4c2", null, "SuperAdmin", "SUPERADMIN" },
                    { "dadd8984-d04d-4711-95d3-5c83a6951cb3", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "0a6fcb40-b270-4b7c-8081-f736c9632541", 0, "35f00f3d-d78e-42eb-a632-87386298bee6", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEE7uBa2GGcg4Qx9ZbnDOJgrYxEEd/ZgZdBKeEAorLxQ5G5bGcJNmCyuVGETEDiWKxg==", null, false, "8b2acceb-c159-44b9-99b3-a8a5e36b4ce3", false, null, "superadmin@outlook.com" },
                    { "4ea62f8c-66c5-46d9-844b-928b516d25cf", 0, "c884b392-b268-4c6b-aac0-9b2c4bcfc57e", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEJRUOwDZWx0Bifw7UrBl+WT2NWJnbIRg52eBbRxeEez88vBJrRooyQoOhmAOtSUUSA==", null, false, "c37d16d7-4b5f-4bd6-8ae5-f47b00df5df4", false, null, "user@outlook.sa" },
                    { "8b8bf528-94c1-4ceb-806d-5627aaed3f48", 0, "561fa6c2-6551-4b1d-8bbf-60ec540f5bd6", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEMlv/Yv0gcl0Dy2XJ13cT+9KTzS/U1RQ4SFFdIDLMfs0iPni4acgr3IkUAX4hvnT5g==", null, false, "3e8a3e1c-26bc-4f2f-b0e1-1695785be6e2", false, null, "admin@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b3428777-fadb-479f-9dc1-a85a8285d4c2", "0a6fcb40-b270-4b7c-8081-f736c9632541" },
                    { "dadd8984-d04d-4711-95d3-5c83a6951cb3", "4ea62f8c-66c5-46d9-844b-928b516d25cf" },
                    { "0700153e-4700-4e70-94a2-780b9afc76f6", "8b8bf528-94c1-4ceb-806d-5627aaed3f48" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b3428777-fadb-479f-9dc1-a85a8285d4c2", "0a6fcb40-b270-4b7c-8081-f736c9632541" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dadd8984-d04d-4711-95d3-5c83a6951cb3", "4ea62f8c-66c5-46d9-844b-928b516d25cf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0700153e-4700-4e70-94a2-780b9afc76f6", "8b8bf528-94c1-4ceb-806d-5627aaed3f48" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0700153e-4700-4e70-94a2-780b9afc76f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3428777-fadb-479f-9dc1-a85a8285d4c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dadd8984-d04d-4711-95d3-5c83a6951cb3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a6fcb40-b270-4b7c-8081-f736c9632541");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ea62f8c-66c5-46d9-844b-928b516d25cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b8bf528-94c1-4ceb-806d-5627aaed3f48");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Orders");

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
    }
}
