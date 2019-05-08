using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class Configuringrelations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "8bf6781f-6148-461c-8aab-daf280dc6539");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aa9d79a1-208c-4872-b249-b7ebe4699a1c", new Guid("00000000-0000-0000-0000-000000000000"), 0, "5e73ca09-eeed-4037-a745-aaf7dfd55c6c", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEEA1+gRgAdej+lnXutOHfwMRnEQJaIhQoMNixhAZ2lS5GsxHdZdbkEQum6J2bzfHow==", "+359359", true, "1dbd7f42-f6dc-4042-a0cd-beb27228c777", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "662ecf97-edae-4b05-9948-5ba39547227f");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "38f0516a-0155-431a-a705-f8716590ef91");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "aa9d79a1-208c-4872-b249-b7ebe4699a1c");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8bf6781f-6148-461c-8aab-daf280dc6539", new Guid("00000000-0000-0000-0000-000000000000"), 0, "c91b4724-6e55-4360-9f03-ff5cb9d2aaf6", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEJiKHfhzeuEDZdgRf7NZvrcaTNQYLC4HZEsw9sgkHIiq3O5j7Wc6ngROJ1Jifgyc1Q==", "+359359", true, "50855045-51fe-4618-a6e2-ae991d56ae47", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "58589041-817e-444c-b947-f652a8f17128");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "86dec95b-d24b-4e57-937b-334480311de6");
        }
    }
}
