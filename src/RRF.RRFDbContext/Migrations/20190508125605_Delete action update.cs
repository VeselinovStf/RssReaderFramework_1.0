using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class Deleteactionupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XElementsModels_ImageFormats_ImageFormatId",
                table: "XElementsModels");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "a1bb3551-f8e7-49de-98cb-2484e7bce7bc");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Clients");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9c4acb88-b0db-4672-b393-731e5dfa3b5e", new Guid("00000000-0000-0000-0000-000000000000"), 0, "1fb63314-2511-42b9-a6f5-7252ce40e5a8", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEPFCq1A5EINBG9RobTPIsLuU9Cmcl4gRBnuJXQtSQU6FXp509KEcqHyGx9Sdoi6wew==", "+359359", true, "62b85d5a-cb2d-4e1d-8778-fcdbb7d7fdaa", false, "Admin" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_XElementsModels_ImageFormats_ImageFormatId",
                table: "XElementsModels",
                column: "ImageFormatId",
                principalTable: "ImageFormats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XElementsModels_ImageFormats_ImageFormatId",
                table: "XElementsModels");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "9c4acb88-b0db-4672-b393-731e5dfa3b5e");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a1bb3551-f8e7-49de-98cb-2484e7bce7bc", new Guid("00000000-0000-0000-0000-000000000000"), 0, "2d57778b-08dd-48c4-bfab-f75f3e6be535", "Client", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEDEYLBeXS7US4dsSaOi6MAomEezHJg6GGgNee5YpNYPrXrqc6vMFQpNFfPfj7nZGVw==", "+359359", true, "427f81b9-f210-4353-b57b-b2ad98fd67d3", false, "Admin" });

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
                name: "FK_XElementsModels_ImageFormats_ImageFormatId",
                table: "XElementsModels",
                column: "ImageFormatId",
                principalTable: "ImageFormats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
