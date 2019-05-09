using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class Modelchangeandseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "c2247e87-76a3-453a-9c41-5d5536b60b44");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "baa0d4c2-1589-4378-be1c-238612953ae1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eac5fb6e-00c3-4d9b-ac88-201b20cb1d03", "da48c608-d990-454a-8002-1c02db830e92" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f05a7130-28fe-4a4f-9688-706ef78ad6ab", new Guid("00000000-0000-0000-0000-000000000000"), 0, "16cbd487-628d-4c64-b97a-7d8ee544033c", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEP4SH5wXQ9SEvzVTd5FwCONsKj9WYXbfuxzMBeBK5XOEaG10YrZLvsroK5X+SzT7Yw==", "+359359", true, "cf7f4807-c63b-4226-b391-7b489cf9427f", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "DescendingElements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 9, 14, 43, 23, 887, DateTimeKind.Local).AddTicks(2731), new DateTime(2019, 5, 9, 14, 43, 23, 887, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "17418759-3857-4fc7-b552-11e3c42bd4ec");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "bd62219a-6b42-42f9-a74e-11c0407ec080");

            migrationBuilder.InsertData(
                table: "ModelElements",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageSRC", "IsDeleted", "LinkToCurrentElement", "ModifiedOn", "PubDate", "RssSettingDisplayModelElementId", "Title" },
                values: new object[] { 1, new DateTime(2019, 5, 9, 14, 43, 23, 887, DateTimeKind.Local).AddTicks(9539), null, "<description>", "<image>", false, "<link>", new DateTime(2019, 5, 9, 14, 43, 23, 888, DateTimeKind.Local).AddTicks(979), "<pubDate>", 1, "<title>" });

            migrationBuilder.UpdateData(
                table: "RssChannels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 9, 14, 43, 23, 885, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "RssSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 9, 14, 43, 23, 886, DateTimeKind.Local).AddTicks(2241));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "f05a7130-28fe-4a4f-9688-706ef78ad6ab");

            migrationBuilder.DeleteData(
                table: "ModelElements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "baa0d4c2-1589-4378-be1c-238612953ae1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f2b5242-a2ef-44fb-b874-a0b57cfd8c46", "27150715-a7a8-4d4f-ac18-69545db034aa" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c2247e87-76a3-453a-9c41-5d5536b60b44", new Guid("00000000-0000-0000-0000-000000000000"), 0, "df3e38ba-9d05-48a2-9508-fed3ec8de91b", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEMEhZZVfdABBC0tdQXfdQzVdglLk3u22OVmavgS0jazmuAJ41HXF9zWFywnGCQvYHQ==", "+359359", true, "4f876ab7-553d-46b2-8b49-f64cf7e780c2", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "DescendingElements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 9, 14, 22, 4, 801, DateTimeKind.Local).AddTicks(8646), new DateTime(2019, 5, 9, 14, 22, 4, 802, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5dc460a3-4b07-4474-a55f-f9fe80e9061f");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f2dec772-4405-4cc5-8183-d85a8620b449");

            migrationBuilder.UpdateData(
                table: "RssChannels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 9, 14, 22, 4, 800, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "RssSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 9, 14, 22, 4, 801, DateTimeKind.Local).AddTicks(3689));
        }
    }
}
