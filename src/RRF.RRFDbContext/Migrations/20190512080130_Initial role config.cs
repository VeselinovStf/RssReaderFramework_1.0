using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class Initialroleconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "2ef977b2-1343-497d-87e6-8f2062dbeaf8");

            migrationBuilder.CreateTable(
                name: "IdentityRoleChain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRoleChain", x => new { x.Id, x.RoleId });
                });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "baa0d4c2-1589-4378-be1c-238612953ae1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b5f5cde-8785-45a0-aab0-fa67b7f33096", "66fba0e5-0967-406c-9fed-d86483cff10a" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e3a958db-ec09-4afd-87c1-1197fec81617", new Guid("00000000-0000-0000-0000-000000000000"), 0, "1814e1b2-9321-4476-92f2-54a86f296128", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEFleHp6vKM9aWJhpAoH84r0l20KCvOYw7G5csKXrK6wWoFF3ikR6lne9XukxUkF+2g==", "+359359", true, "8b96073c-378f-4c68-8d40-4e0abd74df18", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "DescendingElements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 12, 11, 1, 28, 119, DateTimeKind.Local).AddTicks(1693), new DateTime(2019, 5, 12, 11, 1, 28, 119, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5ef2fca0-238d-4f9a-bcb6-d8657264e785");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1ddcd1c9-feeb-406e-8bf7-25a0f9e436f3");

            migrationBuilder.UpdateData(
                table: "ModelElements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 12, 11, 1, 28, 120, DateTimeKind.Local).AddTicks(8666), new DateTime(2019, 5, 12, 11, 1, 28, 121, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "RssChannels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 12, 11, 1, 28, 85, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "RssSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 12, 11, 1, 28, 118, DateTimeKind.Local).AddTicks(6072));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRoleChain");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "e3a958db-ec09-4afd-87c1-1197fec81617");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "baa0d4c2-1589-4378-be1c-238612953ae1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08c1fed7-67b3-4985-b01c-f3b2f45efb00", "a0ab8c8f-965e-43d8-bf84-4950d01773f4" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2ef977b2-1343-497d-87e6-8f2062dbeaf8", new Guid("00000000-0000-0000-0000-000000000000"), 0, "a4cba234-89ed-4ec5-aebb-771fb1631d15", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEAqgqzUh49o7Livac4VQQHBO8cm76xhjt0w/Qcen86+y8TcILsfPTDnn/YoGXa6/qA==", "+359359", true, "cb1e401b-c2d8-4fcc-b978-d60b09a612fc", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "DescendingElements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 12, 10, 48, 17, 949, DateTimeKind.Local).AddTicks(2886), new DateTime(2019, 5, 12, 10, 48, 17, 949, DateTimeKind.Local).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "36de089f-57ae-4834-ae84-1c179af5dff7");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7c664dd4-bb2e-40fb-aaa9-6c5b109ef0e7");

            migrationBuilder.UpdateData(
                table: "ModelElements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 12, 10, 48, 17, 949, DateTimeKind.Local).AddTicks(9444), new DateTime(2019, 5, 12, 10, 48, 17, 950, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "RssChannels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 12, 10, 48, 17, 948, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "RssSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 12, 10, 48, 17, 948, DateTimeKind.Local).AddTicks(7710));
        }
    }
}
