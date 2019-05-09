using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    APIKey = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RssChannels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    ClientId = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RssChannels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RssChannels_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RssSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RssChanel_Id = table.Column<int>(nullable: true),
                    ClientId = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RssSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RssSettings_RssChannels_RssChanel_Id",
                        column: x => x.RssChanel_Id,
                        principalTable: "RssChannels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DescendingElements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    RssSettingDescendantElement_Id = table.Column<int>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescendingElements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DescendingElements_RssSettings_RssSettingDescendantElement_Id",
                        column: x => x.RssSettingDescendantElement_Id,
                        principalTable: "RssSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageElements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ElementSubName = table.Column<string>(nullable: true),
                    RssSettingImageFormatElement_Id = table.Column<int>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageElements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageElements_RssSettings_RssSettingImageFormatElement_Id",
                        column: x => x.RssSettingImageFormatElement_Id,
                        principalTable: "RssSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModelElements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LinkToCurrentElement = table.Column<string>(nullable: true),
                    ImageSRC = table.Column<string>(nullable: true),
                    PubDate = table.Column<DateTime>(nullable: false),
                    RssSettingDisplayModelElementId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelElements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelElements_RssSettings_RssSettingDisplayModelElementId",
                        column: x => x.RssSettingDisplayModelElementId,
                        principalTable: "RssSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "XElementsModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    UseName = table.Column<string>(nullable: true),
                    RssSettingFormatElements_Id = table.Column<int>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XElementsModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_XElementsModels_RssSettings_RssSettingFormatElements_Id",
                        column: x => x.RssSettingFormatElements_Id,
                        principalTable: "RssSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "baa0d4c2-1589-4378-be1c-238612953ae0", new Guid("00000000-0000-0000-0000-000000000000"), 0, "39fdce33-caea-4c21-bb57-21520ce17e74", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEBSDDwKAK13kd4iy1GduBaZWBYhxoC7hBEVltFfDMFbYIs4C1zEw0HuMC8kuOj8+pA==", "+359359", true, "40667f44-4629-4f69-b402-bfece4ff9b8a", false, "Admin" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2", "60a9b667-900f-4177-81e4-5888c6af8396", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "d3a7ede8-7d40-4b97-adf3-2f9a5949fde0", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_DescendingElements_RssSettingDescendantElement_Id",
                table: "DescendingElements",
                column: "RssSettingDescendantElement_Id",
                unique: true,
                filter: "[RssSettingDescendantElement_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ImageElements_RssSettingImageFormatElement_Id",
                table: "ImageElements",
                column: "RssSettingImageFormatElement_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ModelElements_RssSettingDisplayModelElementId",
                table: "ModelElements",
                column: "RssSettingDisplayModelElementId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RssChannels_ClientId",
                table: "RssChannels",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_RssSettings_RssChanel_Id",
                table: "RssSettings",
                column: "RssChanel_Id",
                unique: true,
                filter: "[RssChanel_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_XElementsModels_RssSettingFormatElements_Id",
                table: "XElementsModels",
                column: "RssSettingFormatElements_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DescendingElements");

            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "ImageElements");

            migrationBuilder.DropTable(
                name: "ModelElements");

            migrationBuilder.DropTable(
                name: "XElementsModels");

            migrationBuilder.DropTable(
                name: "RssSettings");

            migrationBuilder.DropTable(
                name: "RssChannels");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
