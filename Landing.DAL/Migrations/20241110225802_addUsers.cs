using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Landing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
