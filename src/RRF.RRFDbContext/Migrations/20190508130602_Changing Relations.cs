using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class ChangingRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XElementsModels_RssSettings_RssSettingId",
                table: "XElementsModels");

            migrationBuilder.DropIndex(
                name: "IX_XElementsModels_RssSettingId",
                table: "XElementsModels");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "9c4acb88-b0db-4672-b393-731e5dfa3b5e");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "RssElementSettingId",
                table: "XElementsModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f01dc844-a14f-4162-a2a9-2762edb57db6", new Guid("00000000-0000-0000-0000-000000000000"), 0, "c69613c5-5615-4e8f-a4f5-9509a3285b86", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEFRWfcoI8Z7So4FBjE0cS0NMTq0yjtDPHmA7fb1VhDwxBxbD7QuziADM3ljRDyq3aQ==", "+359359", true, "0691f0dc-131f-446d-9e03-a3a5ec402dc2", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c22fc821-2116-4ae8-958d-bf5db605382f");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4d22412e-1ce6-40bd-867f-eb2233b68195");

            migrationBuilder.CreateIndex(
                name: "IX_XElementsModels_RssElementSettingId",
                table: "XElementsModels",
                column: "RssElementSettingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_XElementsModels_RssSettings_RssElementSettingId",
                table: "XElementsModels",
                column: "RssElementSettingId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XElementsModels_RssSettings_RssElementSettingId",
                table: "XElementsModels");

            migrationBuilder.DropIndex(
                name: "IX_XElementsModels_RssElementSettingId",
                table: "XElementsModels");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "f01dc844-a14f-4162-a2a9-2762edb57db6");

            migrationBuilder.DropColumn(
                name: "RssElementSettingId",
                table: "XElementsModels");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9c4acb88-b0db-4672-b393-731e5dfa3b5e", new Guid("00000000-0000-0000-0000-000000000000"), 0, "1fb63314-2511-42b9-a6f5-7252ce40e5a8", "Client", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEPFCq1A5EINBG9RobTPIsLuU9Cmcl4gRBnuJXQtSQU6FXp509KEcqHyGx9Sdoi6wew==", "+359359", true, "62b85d5a-cb2d-4e1d-8778-fcdbb7d7fdaa", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "9d99bbc5-594b-4cdc-8ab2-35e6e42a0144");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "e2df2275-daaf-42a9-9fd6-e47a522533d6");

            migrationBuilder.CreateIndex(
                name: "IX_XElementsModels_RssSettingId",
                table: "XElementsModels",
                column: "RssSettingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_XElementsModels_RssSettings_RssSettingId",
                table: "XElementsModels",
                column: "RssSettingId",
                principalTable: "RssSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
