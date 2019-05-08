using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class Configuringrelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModelElements_RssSettings_RssSettingsId",
                table: "ModelElements");

            migrationBuilder.DropForeignKey(
                name: "FK_XElementsModels_RssSettings_RssElementSettingId",
                table: "XElementsModels");

            migrationBuilder.DropIndex(
                name: "IX_XElementsModels_RssElementSettingId",
                table: "XElementsModels");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "631b5397-e331-4138-8b86-719cde1e79d2");

            migrationBuilder.DropColumn(
                name: "RssElementSettingId",
                table: "XElementsModels");

            migrationBuilder.RenameColumn(
                name: "RssSettingsId",
                table: "ModelElements",
                newName: "ModelRssSettingsId");

            migrationBuilder.RenameIndex(
                name: "IX_ModelElements_RssSettingsId",
                table: "ModelElements",
                newName: "IX_ModelElements_ModelRssSettingsId");

            migrationBuilder.AddColumn<int>(
                name: "MainElementId",
                table: "RssSettings",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_RssSettings_MainElementId",
                table: "RssSettings",
                column: "MainElementId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ModelElements_RssSettings_ModelRssSettingsId",
                table: "ModelElements",
                column: "ModelRssSettingsId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RssSettings_XElementsModels_MainElementId",
                table: "RssSettings",
                column: "MainElementId",
                principalTable: "XElementsModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModelElements_RssSettings_ModelRssSettingsId",
                table: "ModelElements");

            migrationBuilder.DropForeignKey(
                name: "FK_RssSettings_XElementsModels_MainElementId",
                table: "RssSettings");

            migrationBuilder.DropIndex(
                name: "IX_RssSettings_MainElementId",
                table: "RssSettings");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "8bf6781f-6148-461c-8aab-daf280dc6539");

            migrationBuilder.DropColumn(
                name: "MainElementId",
                table: "RssSettings");

            migrationBuilder.RenameColumn(
                name: "ModelRssSettingsId",
                table: "ModelElements",
                newName: "RssSettingsId");

            migrationBuilder.RenameIndex(
                name: "IX_ModelElements_ModelRssSettingsId",
                table: "ModelElements",
                newName: "IX_ModelElements_RssSettingsId");

            migrationBuilder.AddColumn<int>(
                name: "RssElementSettingId",
                table: "XElementsModels",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_XElementsModels_RssElementSettingId",
                table: "XElementsModels",
                column: "RssElementSettingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ModelElements_RssSettings_RssSettingsId",
                table: "ModelElements",
                column: "RssSettingsId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XElementsModels_RssSettings_RssElementSettingId",
                table: "XElementsModels",
                column: "RssElementSettingId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
