using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class Seedbase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "baa0d4c2-1589-4378-be1c-238612953ae0");

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "RssSettings",
                nullable: true,
                oldClrType: typeof(Guid));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "20b6b257-0052-4196-8b77-498ddf03853c");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "RssSettings",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "baa0d4c2-1589-4378-be1c-238612953ae0", new Guid("00000000-0000-0000-0000-000000000000"), 0, "39fdce33-caea-4c21-bb57-21520ce17e74", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEBSDDwKAK13kd4iy1GduBaZWBYhxoC7hBEVltFfDMFbYIs4C1zEw0HuMC8kuOj8+pA==", "+359359", true, "40667f44-4629-4f69-b402-bfece4ff9b8a", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d3a7ede8-7d40-4b97-adf3-2f9a5949fde0");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "60a9b667-900f-4177-81e4-5888c6af8396");
        }
    }
}
