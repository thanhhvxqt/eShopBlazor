using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopShare.Migrations
{
    public partial class udb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DayOfBirth", "Email", "EmailConfirmed", "HomeAddress", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "089e1ea7-20b8-46f8-9d4d-2b0718851438", 0, "11e0b648-825a-48ec-b0ee-f18979242e95", new DateTime(2002, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "hovanthanh12102002@gmail.com", true, "Lam Dong", false, null, "hovanthanh12102002@gmail.com", "thanhhv", "AQAAAAEAACcQAAAAEKYcarNi+T4lIiSzfl1pwi6/sDjWyIg3Wjaxv8ygToscYjecM0ovTsGS3eslHY/vJg==", null, false, "a5a1ac60-f6dd-440e-9ac8-a523d50ac957", false, "thanhhv" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "089e1ea7-20b8-46f8-9d4d-2b0718851438");
        }
    }
}
