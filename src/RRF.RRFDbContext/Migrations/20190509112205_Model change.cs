using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class Modelchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "d91fa742-a57f-433e-a656-7671ea14141e");

            migrationBuilder.AlterColumn<string>(
                name: "PubDate",
                table: "ModelElements",
                nullable: true,
                oldClrType: typeof(DateTime));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "c2247e87-76a3-453a-9c41-5d5536b60b44");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PubDate",
                table: "ModelElements",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "baa0d4c2-1589-4378-be1c-238612953ae1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88166ac2-cb87-452f-9ab6-b26ab263c4af", "17cfabbd-325a-4a13-ac86-6ac0efc20d60" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d91fa742-a57f-433e-a656-7671ea14141e", new Guid("00000000-0000-0000-0000-000000000000"), 0, "40137215-b7ac-47dc-a8a9-255da02e255a", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEHE3mVyR7U/AQxiw3FeQpjSF/f0aeUncPzu5rMf4y55k2s0i0/AcBREoh78cZnOwxg==", "+359359", true, "7460bf21-eee5-4e3a-a169-1e769a8f165d", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "DescendingElements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 9, 12, 51, 47, 427, DateTimeKind.Local).AddTicks(8611), new DateTime(2019, 5, 9, 12, 51, 47, 428, DateTimeKind.Local).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "de8b9442-862d-462e-af19-9a9886e00a87");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "18f74838-7913-4467-9549-c7f585f23224");

            migrationBuilder.UpdateData(
                table: "RssChannels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 9, 12, 51, 47, 426, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "RssSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 9, 12, 51, 47, 427, DateTimeKind.Local).AddTicks(2709));
        }
    }
}
