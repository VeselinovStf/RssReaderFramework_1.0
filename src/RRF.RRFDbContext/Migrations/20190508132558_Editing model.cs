using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class Editingmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "44fed7ae-7502-4867-949c-a9b9bbb8cb60");

            migrationBuilder.DropColumn(
                name: "RssSettingId",
                table: "XElementsModels");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6dcdb249-be7c-4185-bf01-694d3edb9193", new Guid("00000000-0000-0000-0000-000000000000"), 0, "29360bc8-c671-4fa4-abb9-5b6af6f5ec05", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEFr0kV6k7Z6TGtDDpoWqUPwUDvOD4baeZpsUoxAIqOtwet7+MC38fVp5L+ezfa+BnQ==", "+359359", true, "62aa7275-4b1b-43d3-bbda-1e75483ebc28", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "aa8fd7af-83ab-4b52-967b-3ebd8209a8be");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6bd4e795-9a12-43ed-abb7-84b3d2851a62");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "6dcdb249-be7c-4185-bf01-694d3edb9193");

            migrationBuilder.AddColumn<int>(
                name: "RssSettingId",
                table: "XElementsModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "44fed7ae-7502-4867-949c-a9b9bbb8cb60", new Guid("00000000-0000-0000-0000-000000000000"), 0, "3a1538d9-2056-4ae5-8f02-86382d13a27a", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEI8NqdassFWA30EqKL/UcgZ+aaNf2h5ERCmQMXooMNBaAZoE2Fy8z9uHJTodnt3hMw==", "+359359", true, "2a88bb4d-7d35-4f9f-b88e-c5dabe291510", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5eb8a401-04a6-4e50-b8b9-d65eb3709e39");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2328b4f3-3f20-4443-8975-b20485d6f1a6");
        }
    }
}
