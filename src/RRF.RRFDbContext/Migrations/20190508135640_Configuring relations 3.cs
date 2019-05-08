using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class Configuringrelations3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RssSettings_XElementsModels_MainElementId",
                table: "RssSettings");

            migrationBuilder.DropIndex(
                name: "IX_RssSettings_MainElementId",
                table: "RssSettings");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "aa9d79a1-208c-4872-b249-b7ebe4699a1c");

            migrationBuilder.DropColumn(
                name: "MainElementId",
                table: "RssSettings");

            migrationBuilder.AddColumn<int>(
                name: "RssElementsSettingId",
                table: "XElementsModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e3e966c9-5b0c-4f1c-974f-848837ffde93", new Guid("00000000-0000-0000-0000-000000000000"), 0, "20890dfb-dbc1-4d42-a91e-f4d813eff801", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEGLgGpmSeCfwWdMqDpwQBJVX8NUlRpOjX1LMrpIbhY5ZnqO+g67My/orSGX5qkT0+g==", "+359359", true, "a0d6109f-4c5c-4d64-b015-13d5c0472144", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "17c5f8e2-e3db-4c4a-9d5e-195033e2e15f");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "fda3b7bb-9aed-48f5-a3d2-00fe18453e5e");

            migrationBuilder.CreateIndex(
                name: "IX_XElementsModels_RssElementsSettingId",
                table: "XElementsModels",
                column: "RssElementsSettingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_XElementsModels_RssSettings_RssElementsSettingId",
                table: "XElementsModels",
                column: "RssElementsSettingId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XElementsModels_RssSettings_RssElementsSettingId",
                table: "XElementsModels");

            migrationBuilder.DropIndex(
                name: "IX_XElementsModels_RssElementsSettingId",
                table: "XElementsModels");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "e3e966c9-5b0c-4f1c-974f-848837ffde93");

            migrationBuilder.DropColumn(
                name: "RssElementsSettingId",
                table: "XElementsModels");

            migrationBuilder.AddColumn<int>(
                name: "MainElementId",
                table: "RssSettings",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_RssSettings_MainElementId",
                table: "RssSettings",
                column: "MainElementId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RssSettings_XElementsModels_MainElementId",
                table: "RssSettings",
                column: "MainElementId",
                principalTable: "XElementsModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
