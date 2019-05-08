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
                    UserId = table.Column<Guid>(nullable: false),
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
                    RssChannelId = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RssSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RssSettings_RssChannels_RssChannelId",
                        column: x => x.RssChannelId,
                        principalTable: "RssChannels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageFormats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageRssSettingId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageFormats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageFormats_RssSettings_ImageRssSettingId",
                        column: x => x.ImageRssSettingId,
                        principalTable: "RssSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LinkToCurrentElement = table.Column<string>(nullable: true),
                    ImageSRC = table.Column<string>(nullable: true),
                    PubDate = table.Column<DateTime>(nullable: false),
                    ItemRssSettingId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemModels_RssSettings_ItemRssSettingId",
                        column: x => x.ItemRssSettingId,
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
                    BuildName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsProcessed = table.Column<bool>(nullable: false),
                    ModelRssSettingsId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelElements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelElements_RssSettings_ModelRssSettingsId",
                        column: x => x.ModelRssSettingsId,
                        principalTable: "RssSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "XElementsModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    RssElementsSettingId = table.Column<int>(nullable: false),
                    ImageFormatId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XElementsModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_XElementsModels_ImageFormats_ImageFormatId",
                        column: x => x.ImageFormatId,
                        principalTable: "ImageFormats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_XElementsModels_RssSettings_RssElementsSettingId",
                        column: x => x.RssElementsSettingId,
                        principalTable: "RssSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d6cfdf8f-cb6b-4c07-9808-017c267c3fe7", new Guid("00000000-0000-0000-0000-000000000000"), 0, "aad45d26-3aa5-47c3-afee-6d39e8d147cc", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEHL++sNtd//BehZAucDWIKH25jDBoLauwT023uMMsLwa5JBNZEU0x/TtWZe+eottxQ==", "+359359", true, "24410815-e608-4898-bb4e-df22a05f4173", false, "Admin" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2", "d1346382-f3d0-42fd-a8e6-4168fa73f6ad", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "1cb4606d-5de8-4767-9a25-d4e7d8e7d772", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_ImageFormats_ImageRssSettingId",
                table: "ImageFormats",
                column: "ImageRssSettingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemModels_ItemRssSettingId",
                table: "ItemModels",
                column: "ItemRssSettingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModelElements_ModelRssSettingsId",
                table: "ModelElements",
                column: "ModelRssSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_RssChannels_ClientId",
                table: "RssChannels",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_RssSettings_RssChannelId",
                table: "RssSettings",
                column: "RssChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_XElementsModels_ImageFormatId",
                table: "XElementsModels",
                column: "ImageFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_XElementsModels_RssElementsSettingId",
                table: "XElementsModels",
                column: "RssElementsSettingId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "ItemModels");

            migrationBuilder.DropTable(
                name: "ModelElements");

            migrationBuilder.DropTable(
                name: "XElementsModels");

            migrationBuilder.DropTable(
                name: "ImageFormats");

            migrationBuilder.DropTable(
                name: "RssSettings");

            migrationBuilder.DropTable(
                name: "RssChannels");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
