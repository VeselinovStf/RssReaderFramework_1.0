using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class Renamingmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageFormats_RssSettings_RssSettingId",
                table: "ImageFormats");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemModels_RssSettings_RssSettingId",
                table: "ItemModels");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "6dcdb249-be7c-4185-bf01-694d3edb9193");

            migrationBuilder.RenameColumn(
                name: "RssSettingId",
                table: "ItemModels",
                newName: "ItemRssSettingId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemModels_RssSettingId",
                table: "ItemModels",
                newName: "IX_ItemModels_ItemRssSettingId");

            migrationBuilder.RenameColumn(
                name: "RssSettingId",
                table: "ImageFormats",
                newName: "ImageRssSettingId");

            migrationBuilder.RenameIndex(
                name: "IX_ImageFormats_RssSettingId",
                table: "ImageFormats",
                newName: "IX_ImageFormats_ImageRssSettingId");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "631b5397-e331-4138-8b86-719cde1e79d2", new Guid("00000000-0000-0000-0000-000000000000"), 0, "a5ae0910-bf1d-450a-a8f7-395408436926", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEAjs1aYIEQZQCloFa9reK2fu6TvlQoyWVwpyXrBffox4z28fL1I8TZEDsJKcxQ4v+A==", "+359359", true, "182f876c-8cf7-4814-96d0-95f27f527a47", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "50ded076-07f1-4ee4-9806-69ada7d366b5");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "094fbed6-e11f-47d9-becf-527b086fe898");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFormats_RssSettings_ImageRssSettingId",
                table: "ImageFormats",
                column: "ImageRssSettingId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemModels_RssSettings_ItemRssSettingId",
                table: "ItemModels",
                column: "ItemRssSettingId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageFormats_RssSettings_ImageRssSettingId",
                table: "ImageFormats");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemModels_RssSettings_ItemRssSettingId",
                table: "ItemModels");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "631b5397-e331-4138-8b86-719cde1e79d2");

            migrationBuilder.RenameColumn(
                name: "ItemRssSettingId",
                table: "ItemModels",
                newName: "RssSettingId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemModels_ItemRssSettingId",
                table: "ItemModels",
                newName: "IX_ItemModels_RssSettingId");

            migrationBuilder.RenameColumn(
                name: "ImageRssSettingId",
                table: "ImageFormats",
                newName: "RssSettingId");

            migrationBuilder.RenameIndex(
                name: "IX_ImageFormats_ImageRssSettingId",
                table: "ImageFormats",
                newName: "IX_ImageFormats_RssSettingId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFormats_RssSettings_RssSettingId",
                table: "ImageFormats",
                column: "RssSettingId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemModels_RssSettings_RssSettingId",
                table: "ItemModels",
                column: "RssSettingId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
