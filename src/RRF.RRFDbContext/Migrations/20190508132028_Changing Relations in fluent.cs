using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class ChangingRelationsinfluent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RssSettings_RssChannels_RssChannelId",
                table: "RssSettings");

            migrationBuilder.DropTable(
                name: "BaseIdentityModel");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "f01dc844-a14f-4162-a2a9-2762edb57db6");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Clients");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RssSettings_RssChannels_RssChannelId",
                table: "RssSettings",
                column: "RssChannelId",
                principalTable: "RssChannels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RssSettings_RssChannels_RssChannelId",
                table: "RssSettings");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "44fed7ae-7502-4867-949c-a9b9bbb8cb60");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "BaseIdentityModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseIdentityModel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f01dc844-a14f-4162-a2a9-2762edb57db6", new Guid("00000000-0000-0000-0000-000000000000"), 0, "c69613c5-5615-4e8f-a4f5-9509a3285b86", "Client", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEFRWfcoI8Z7So4FBjE0cS0NMTq0yjtDPHmA7fb1VhDwxBxbD7QuziADM3ljRDyq3aQ==", "+359359", true, "0691f0dc-131f-446d-9e03-a3a5ec402dc2", false, "Admin" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_RssSettings_RssChannels_RssChannelId",
                table: "RssSettings",
                column: "RssChannelId",
                principalTable: "RssChannels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
