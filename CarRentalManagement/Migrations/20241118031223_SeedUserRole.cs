using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1139), new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1152), new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1352), new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1355), new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1445), new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1447), new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1448), new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1450), new DateTime(2024, 11, 18, 10, 55, 57, 156, DateTimeKind.Local).AddTicks(1451) });
        }
    }
}
