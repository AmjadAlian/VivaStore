using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Landing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNameForCartsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_AspNetUsers_UserId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Cart_CartId",
                table: "CartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

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

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "Carts");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_UserId",
                table: "Carts",
                newName: "IX_Carts_UserId");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "CartItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "80d92c9b-99db-4903-9f70-1b8171893384", null, "Admin", "ADMIN" },
                    { "fa94a3e8-d314-4096-afd3-c5fe1cd86f92", null, "User", "USER" },
                    { "fba03ddc-08ed-44cd-b297-a115b9118cd4", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserAddress", "UserName" },
                values: new object[,]
                {
                    { "4f5c9e94-30df-4059-991c-430714b54735", 0, "184d0f28-1cb0-43fc-8c14-39318501d1ac", null, "user@outlook.sa", true, null, false, null, "USER@OUTLOOK.SA", "USER@OUTLOOK.SA", "AQAAAAIAAYagAAAAEKs7GHLjH/otYxdVROKHmjPRrI3kuovtcHog6oMIAq3z/T1k/OmZam3+2DFVOSFI0g==", null, false, "6d063a4e-a76e-4384-8887-9e6a6c89e23f", false, null, "user@outlook.sa" },
                    { "7a6c082a-d3ac-4e69-81c5-bffb985c1a39", 0, "cf33e694-0674-4582-b628-e432dc593634", null, "superadmin@outlook.com", true, null, false, null, "SUPERADMIN@OUTLOOK.COM", "SUPERADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEIifm98H/wpa6ZxbZALbLIVknhAmoSoVAR1277gTFYrkeUnbuWHjHx9DEyRjb2f67w==", null, false, "c634d2f3-89ec-4f51-9c53-edbde79ec527", false, null, "superadmin@outlook.com" },
                    { "bd88bf6c-9793-4aaa-96a6-ff8dd506e96a", 0, "2aa3838b-c715-4632-89db-a3748fc2d5e2", null, "admin@outlook.com", true, null, false, null, "ADMIN@OUTLOOK.COM", "ADMIN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEOdV+iq5Vxkixi5Bl4/StTqC+i8a54jJvhW4rI/2fECWuctAptuQzrBz/ZW6NG1f7Q==", null, false, "ddf0c7ad-c1c3-4cf3-a340-dd9647faf639", false, null, "admin@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fa94a3e8-d314-4096-afd3-c5fe1cd86f92", "4f5c9e94-30df-4059-991c-430714b54735" },
                    { "fba03ddc-08ed-44cd-b297-a115b9118cd4", "7a6c082a-d3ac-4e69-81c5-bffb985c1a39" },
                    { "80d92c9b-99db-4903-9f70-1b8171893384", "bd88bf6c-9793-4aaa-96a6-ff8dd506e96a" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fa94a3e8-d314-4096-afd3-c5fe1cd86f92", "4f5c9e94-30df-4059-991c-430714b54735" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fba03ddc-08ed-44cd-b297-a115b9118cd4", "7a6c082a-d3ac-4e69-81c5-bffb985c1a39" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80d92c9b-99db-4903-9f70-1b8171893384", "bd88bf6c-9793-4aaa-96a6-ff8dd506e96a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80d92c9b-99db-4903-9f70-1b8171893384");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa94a3e8-d314-4096-afd3-c5fe1cd86f92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fba03ddc-08ed-44cd-b297-a115b9118cd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5c9e94-30df-4059-991c-430714b54735");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a6c082a-d3ac-4e69-81c5-bffb985c1a39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd88bf6c-9793-4aaa-96a6-ff8dd506e96a");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CartItems");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "Cart");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_UserId",
                table: "Cart",
                newName: "IX_Cart_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_AspNetUsers_UserId",
                table: "Cart",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Cart_CartId",
                table: "CartItems",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
