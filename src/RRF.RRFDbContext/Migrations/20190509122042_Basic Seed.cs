using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRF.RRFDbContext.Migrations
{
    public partial class BasicSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "4bd970d2-acec-4b89-a28f-1fce4470d0cc");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "baa0d4c2-1589-4378-be1c-238612953ae1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f5293c2-730f-43d5-b19b-858140548fb3", "470080ec-4d5d-4fa2-abe0-32981be9d610" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f2916468-bfc0-4746-a227-58acc9c943d2", new Guid("00000000-0000-0000-0000-000000000000"), 0, "73153bae-0ef6-4762-bd18-45089d4767ea", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEH4nuNBhB3FtyQJyBPm8A7gYm0whJq4siaRv2cAxme+2qyp7utQN3pm9dlD0ijW/KA==", "+359359", true, "1ac81dcb-2e60-4ae2-ab89-7252ac05854a", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "DescendingElements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 9, 15, 20, 40, 621, DateTimeKind.Local).AddTicks(9398), new DateTime(2019, 5, 9, 15, 20, 40, 622, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8a139774-c379-47e1-8341-18aed8775fd2");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a1a25ac6-9d71-411a-9daf-d139fe85efe0");

            migrationBuilder.UpdateData(
                table: "ModelElements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Description", "ImageSRC", "LinkToCurrentElement", "ModifiedOn", "PubDate", "Title" },
                values: new object[] { new DateTime(2019, 5, 9, 15, 20, 40, 622, DateTimeKind.Local).AddTicks(5891), "description", "image", "link", new DateTime(2019, 5, 9, 15, 20, 40, 622, DateTimeKind.Local).AddTicks(7308), "pubDate", "title" });

            migrationBuilder.UpdateData(
                table: "RssChannels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 9, 15, 20, 40, 620, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "RssSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 9, 15, 20, 40, 621, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "XElementsModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "<p>");

            migrationBuilder.UpdateData(
                table: "XElementsModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "</p>");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "f2916468-bfc0-4746-a227-58acc9c943d2");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "baa0d4c2-1589-4378-be1c-238612953ae1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f235063-8eed-407d-8725-1fb27435286b", "4fd32f88-a531-4db1-a4d2-46a40d7e8c52" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "APIKey", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4bd970d2-acec-4b89-a28f-1fce4470d0cc", new Guid("00000000-0000-0000-0000-000000000000"), 0, "ebba9600-40a5-4aab-ae52-d2ea3d599f61", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEKnfOToMUyhvaH5tiqH6w1GuuvuqFthYUJb38f1UM41pk8XlYH9Efm2s62mzJD9W5g==", "+359359", true, "b8ae5176-4c72-446f-a52a-49da1af1acf2", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "DescendingElements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 5, 9, 14, 51, 34, 402, DateTimeKind.Local).AddTicks(3211), new DateTime(2019, 5, 9, 14, 51, 34, 402, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d5595627-e7bf-43c7-9fb2-cf2a7f0f34a6");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f4470ff3-cb5b-458d-9c7f-54938eafc866");

            migrationBuilder.UpdateData(
                table: "ModelElements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Description", "ImageSRC", "LinkToCurrentElement", "ModifiedOn", "PubDate", "Title" },
                values: new object[] { new DateTime(2019, 5, 9, 14, 51, 34, 402, DateTimeKind.Local).AddTicks(9623), "<description>", "<image>", "<link>", new DateTime(2019, 5, 9, 14, 51, 34, 403, DateTimeKind.Local).AddTicks(1111), "<pubDate>", "<title>" });

            migrationBuilder.UpdateData(
                table: "RssChannels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 9, 14, 51, 34, 401, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "RssSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 5, 9, 14, 51, 34, 401, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "XElementsModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "<description>");

            migrationBuilder.UpdateData(
                table: "XElementsModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "<title>");
        }
    }
}
