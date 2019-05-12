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
                name: "IdentityUserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserClaim", x => new { x.UserId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserRole",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole", x => new { x.RoleId, x.UserId });
                    table.UniqueConstraint("AK_IdentityUserRole_UserId_RoleId", x => new { x.UserId, x.RoleId });
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
                    ClientId = table.Column<string>(nullable: true),
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
                    PubDate = table.Column<string>(nullable: true),
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
                values: new object[,]
                {
                    { "baa0d4c2-1589-4378-be1c-238612953ae1", new Guid("00000000-0000-0000-0000-000000000000"), 0, "08c1fed7-67b3-4985-b01c-f3b2f45efb00", "client@mail.com", true, false, null, "CLIENT@MAIL.COM", "CLIENT@MAIL.COM", null, "+359359", true, "a0ab8c8f-965e-43d8-bf84-4950d01773f4", false, "Client" },
                    { "2ef977b2-1343-497d-87e6-8f2062dbeaf8", new Guid("00000000-0000-0000-0000-000000000000"), 0, "a4cba234-89ed-4ec5-aebb-771fb1631d15", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEAqgqzUh49o7Livac4VQQHBO8cm76xhjt0w/Qcen86+y8TcILsfPTDnn/YoGXa6/qA==", "+359359", true, "cb1e401b-c2d8-4fcc-b978-d60b09a612fc", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "36de089f-57ae-4834-ae84-1c179af5dff7", "Administrator", "ADMINISTRATOR" },
                    { "2", "7c664dd4-bb2e-40fb-aaa9-6c5b109ef0e7", "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "RssChannels",
                columns: new[] { "Id", "ClientId", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "Name", "URL" },
                values: new object[] { 1, "baa0d4c2-1589-4378-be1c-238612953ae1", new DateTime(2019, 5, 12, 10, 48, 17, 948, DateTimeKind.Local).AddTicks(2673), null, false, null, "testRssChannel", "https://www.vesti.bg/rss.php" });

            migrationBuilder.InsertData(
                table: "RssSettings",
                columns: new[] { "Id", "ClientId", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "RssChanel_Id" },
                values: new object[] { 1, "baa0d4c2-1589-4378-be1c-238612953ae1", new DateTime(2019, 5, 12, 10, 48, 17, 948, DateTimeKind.Local).AddTicks(7710), null, false, null, 1 });

            migrationBuilder.InsertData(
                table: "DescendingElements",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "Name", "RssSettingDescendantElement_Id" },
                values: new object[] { 1, new DateTime(2019, 5, 12, 10, 48, 17, 949, DateTimeKind.Local).AddTicks(2886), null, false, new DateTime(2019, 5, 12, 10, 48, 17, 949, DateTimeKind.Local).AddTicks(4326), "item", 1 });

            migrationBuilder.InsertData(
                table: "ModelElements",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageSRC", "IsDeleted", "LinkToCurrentElement", "ModifiedOn", "PubDate", "RssSettingDisplayModelElementId", "Title" },
                values: new object[] { 1, new DateTime(2019, 5, 12, 10, 48, 17, 949, DateTimeKind.Local).AddTicks(9444), null, "description", "image", false, "link", new DateTime(2019, 5, 12, 10, 48, 17, 950, DateTimeKind.Local).AddTicks(847), "pubDate", 1, "title" });

            migrationBuilder.InsertData(
                table: "XElementsModels",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "Name", "RssSettingFormatElements_Id", "UseName" },
                values: new object[,]
                {
                    { 1, null, null, false, null, "<p>", 1, null },
                    { 2, null, null, false, null, "</p>", 1, null }
                });

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
                name: "IdentityUserClaim");

            migrationBuilder.DropTable(
                name: "IdentityUserRole");

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
