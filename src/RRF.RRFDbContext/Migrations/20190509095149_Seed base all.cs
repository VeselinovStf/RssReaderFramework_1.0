using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class Seedbaseall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "20b6b257-0052-4196-8b77-498ddf03853c");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "baa0d4c2-1589-4378-be1c-238612953ae1", new Guid("00000000-0000-0000-0000-000000000000"), 0, "88166ac2-cb87-452f-9ab6-b26ab263c4af", "client@mail.com", true, false, null, "CLIENT@MAIL.COM", "CLIENT@MAIL.COM", null, "+359359", true, "17cfabbd-325a-4a13-ac86-6ac0efc20d60", false, "Client" },
                    { "d91fa742-a57f-433e-a656-7671ea14141e", new Guid("00000000-0000-0000-0000-000000000000"), 0, "40137215-b7ac-47dc-a8a9-255da02e255a", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEHE3mVyR7U/AQxiw3FeQpjSF/f0aeUncPzu5rMf4y55k2s0i0/AcBREoh78cZnOwxg==", "+359359", true, "7460bf21-eee5-4e3a-a169-1e769a8f165d", false, "Admin" }
                });

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

            migrationBuilder.InsertData(
                table: "RssChannels",
                columns: new[] { "Id", "ClientId", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "Name", "URL" },
                values: new object[] { 1, "baa0d4c2-1589-4378-be1c-238612953ae1", new DateTime(2019, 5, 9, 12, 51, 47, 426, DateTimeKind.Local).AddTicks(5833), null, false, null, "testRssChannel", "https://www.vesti.bg/rss.php" });

            migrationBuilder.InsertData(
                table: "RssSettings",
                columns: new[] { "Id", "ClientId", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "RssChanel_Id" },
                values: new object[] { 1, "baa0d4c2-1589-4378-be1c-238612953ae1", new DateTime(2019, 5, 9, 12, 51, 47, 427, DateTimeKind.Local).AddTicks(2709), null, false, null, 1 });

            migrationBuilder.InsertData(
                table: "DescendingElements",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "Name", "RssSettingDescendantElement_Id" },
                values: new object[] { 1, new DateTime(2019, 5, 9, 12, 51, 47, 427, DateTimeKind.Local).AddTicks(8611), null, false, new DateTime(2019, 5, 9, 12, 51, 47, 428, DateTimeKind.Local).AddTicks(143), "item", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "d91fa742-a57f-433e-a656-7671ea14141e");

            migrationBuilder.DeleteData(
                table: "DescendingElements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RssSettings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RssChannels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "baa0d4c2-1589-4378-be1c-238612953ae1");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "20b6b257-0052-4196-8b77-498ddf03853c", new Guid("00000000-0000-0000-0000-000000000000"), 0, "e06cd901-2cea-4c25-be98-dcfce029f35e", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEBoMMpVNUlPq1/sjIe1z+T5wrki//HJZcVBwDh4Vw+ILN+MltSrYRhXv9zrKs4uiXw==", "+359359", true, "50e9a036-9697-4202-8a66-3d245b56b004", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "448a5d5c-e409-4d5e-9a38-ee6cba11e258");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b22464cf-b436-444f-9a08-e1f89ad4ae11");
        }
    }
}
