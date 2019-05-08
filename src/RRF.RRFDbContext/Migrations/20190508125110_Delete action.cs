using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class Deleteaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageFormats_RssSettings_RssSettingId",
                table: "ImageFormats");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemModels_RssSettings_RssSettingId",
                table: "ItemModels");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelElements_RssSettings_RssSettingsId",
                table: "ModelElements");

            migrationBuilder.DropForeignKey(
                name: "FK_XElementsModels_RssSettings_RssSettingId",
                table: "XElementsModels");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "58d9138e-1137-40ba-9faf-41260bcc48ec");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Clients");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a1bb3551-f8e7-49de-98cb-2484e7bce7bc", new Guid("00000000-0000-0000-0000-000000000000"), 0, "2d57778b-08dd-48c4-bfab-f75f3e6be535", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEDEYLBeXS7US4dsSaOi6MAomEezHJg6GGgNee5YpNYPrXrqc6vMFQpNFfPfj7nZGVw==", "+359359", true, "427f81b9-f210-4353-b57b-b2ad98fd67d3", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1dfe40f0-6223-4d33-9859-2985bb9f9698");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "342a168e-5e4e-412d-8cb6-dc9ffd128a8b");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ModelElements_RssSettings_RssSettingsId",
                table: "ModelElements",
                column: "RssSettingsId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XElementsModels_RssSettings_RssSettingId",
                table: "XElementsModels",
                column: "RssSettingId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageFormats_RssSettings_RssSettingId",
                table: "ImageFormats");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemModels_RssSettings_RssSettingId",
                table: "ItemModels");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelElements_RssSettings_RssSettingsId",
                table: "ModelElements");

            migrationBuilder.DropForeignKey(
                name: "FK_XElementsModels_RssSettings_RssSettingId",
                table: "XElementsModels");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "a1bb3551-f8e7-49de-98cb-2484e7bce7bc");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "58d9138e-1137-40ba-9faf-41260bcc48ec", new Guid("00000000-0000-0000-0000-000000000000"), 0, "e3086729-c249-4a0a-ba3c-3cd525455316", "Client", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEJb4vMk0k6m4kpIezYsGsHNbtib0UJc2fL8rwPwMXaqj5zOwWMRegUF53knUQiskkQ==", "+359359", true, "53fc441a-1631-42c2-aae3-82d55390bd1e", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ac440d00-26ed-4751-ba02-626a2a814b80");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f09d8327-b61f-4efd-ae01-8ee924876b73");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFormats_RssSettings_RssSettingId",
                table: "ImageFormats",
                column: "RssSettingId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemModels_RssSettings_RssSettingId",
                table: "ItemModels",
                column: "RssSettingId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModelElements_RssSettings_RssSettingsId",
                table: "ModelElements",
                column: "RssSettingsId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_XElementsModels_RssSettings_RssSettingId",
                table: "XElementsModels",
                column: "RssSettingId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}