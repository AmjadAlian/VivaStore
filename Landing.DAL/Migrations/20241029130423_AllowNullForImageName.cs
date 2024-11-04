using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Landing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AllowNullForImageName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "AdditionalImgNames",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "954fff8b-a193-4850-87bc-c7086c2d21f1", null, "Admin", "ADMIN" },
                    { "b465fad0-66ec-4f34-839f-88d6148d397d", null, "User", "USER" },
                    { "e6fe9968-d973-4a7a-bd02-ffc5a6f55283", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "7a334436-4920-48ad-8d26-7334cbdcb7c2", 0, "6d5a5501-7de1-4aae-b9c5-c84d76dd87e0", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEG2/iQdEKOGxK3BHA+/pA12iA+DmHck6XNBIch7CQQ0D0437fpuPH26M/2dm+KrCRw==", null, false, "edf16ae8-948d-45bd-9cc6-398dda6acd9e", false, null, "user@outlook.sa" },
                    { "ee1b1fdd-f7aa-40ee-9d9e-72b922574c42", 0, "10ddebbe-4304-4338-a592-97e441e0a453", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEP7UXkuFQf/j+etVEh6rEY3N/t7quuLZXsdARPEBH6Yo7waHxL0CTAGXkm32vENZUw==", null, false, "81654d7d-db33-442c-a2f1-8d7e62dadb4d", false, null, "admin@outlook.com" },
                    { "fa557a6a-4bf7-4b61-9129-3b15f7974f08", 0, "f6bcec90-a490-4100-a73f-f5510970d645", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEH3EnsnaYq1OMWoOIS8pfItUl8ylhLwR3v7b1muwEJwqFaPdEa70XBb1nVLivlvbFA==", null, false, "28b38433-db32-4c8f-9d43-0e2747c2d364", false, null, "superadmin@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b465fad0-66ec-4f34-839f-88d6148d397d", "7a334436-4920-48ad-8d26-7334cbdcb7c2" },
                    { "954fff8b-a193-4850-87bc-c7086c2d21f1", "ee1b1fdd-f7aa-40ee-9d9e-72b922574c42" },
                    { "e6fe9968-d973-4a7a-bd02-ffc5a6f55283", "fa557a6a-4bf7-4b61-9129-3b15f7974f08" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b465fad0-66ec-4f34-839f-88d6148d397d", "7a334436-4920-48ad-8d26-7334cbdcb7c2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "954fff8b-a193-4850-87bc-c7086c2d21f1", "ee1b1fdd-f7aa-40ee-9d9e-72b922574c42" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e6fe9968-d973-4a7a-bd02-ffc5a6f55283", "fa557a6a-4bf7-4b61-9129-3b15f7974f08" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "954fff8b-a193-4850-87bc-c7086c2d21f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b465fad0-66ec-4f34-839f-88d6148d397d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6fe9968-d973-4a7a-bd02-ffc5a6f55283");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a334436-4920-48ad-8d26-7334cbdcb7c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee1b1fdd-f7aa-40ee-9d9e-72b922574c42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa557a6a-4bf7-4b61-9129-3b15f7974f08");

            migrationBuilder.AlterColumn<string>(
                name: "AdditionalImgNames",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
