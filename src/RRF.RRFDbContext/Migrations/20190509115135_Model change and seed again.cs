using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class Modelchangeandseedagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "f05a7130-28fe-4a4f-9688-706ef78ad6ab");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "baa0d4c2-1589-4378-be1c-238612953ae1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f235063-8eed-407d-8725-1fb27435286b", "4fd32f88-a531-4db1-a4d2-46a40d7e8c52" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4bd970d2-acec-4b89-a28f-1fce4470d0cc", new Guid("00000000-0000-0000-0000-000000000000"), 0, "ebba9600-40a5-4aab-ae52-d2ea3d599f61", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEKnfOToMUyhvaH5tiqH6w1GuuvuqFthYUJb38f1UM41pk8XlYH9Efm2s62mzJD9W5g==", "+359359", true, "b8ae5176-4c72-446f-a52a-49da1af1acf2", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "DescendingElements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 9, 14, 51, 34, 402, DateTimeKind.Local).AddTicks(3211), new DateTime(2019, 5, 9, 14, 51, 34, 402, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d5595627-e7bf-43c7-9fb2-cf2a7f0f34a6");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f4470ff3-cb5b-458d-9c7f-54938eafc866");

            migrationBuilder.UpdateData(
                table: "ModelElements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 9, 14, 51, 34, 402, DateTimeKind.Local).AddTicks(9623), new DateTime(2019, 5, 9, 14, 51, 34, 403, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "RssChannels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 9, 14, 51, 34, 401, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "RssSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 9, 14, 51, 34, 401, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.InsertData(
                table: "XElementsModels",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "Name", "RssSettingFormatElements_Id", "UseName" },
                values: new object[,]
                {
                    { 1, null, null, false, null, "<description>", 1, null },
                    { 2, null, null, false, null, "<title>", 1, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "4bd970d2-acec-4b89-a28f-1fce4470d0cc");

            migrationBuilder.DeleteData(
                table: "XElementsModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "XElementsModels",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.UpdateData(
                table: "ModelElements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 9, 14, 43, 23, 887, DateTimeKind.Local).AddTicks(9539), new DateTime(2019, 5, 9, 14, 43, 23, 888, DateTimeKind.Local).AddTicks(979) });

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
    }
}
