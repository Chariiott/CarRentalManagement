using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class wewewef : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "6f3575d7-972f-4e94-bfc8-76ec01868da5", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENV8gvwDeXgEaK4kucrUVonRShyWPyQCrendCsb2RCshHhzQIBcR+PyLeViiVE0e6Q==", null, false, "ec603bed-3dd7-4c1f-8719-66cde1180e40", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(8995), new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9012), new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9311), new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9315), new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9448), new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9451), new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9453), new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9456), new DateTime(2024, 11, 20, 11, 11, 16, 778, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3315), new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3328), new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3514), new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3516), new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3620), new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3623), new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3624), new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3626), new DateTime(2024, 11, 18, 11, 12, 23, 112, DateTimeKind.Local).AddTicks(3626) });
        }
    }
}
