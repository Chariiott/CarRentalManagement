using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8305), new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8315), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8317), new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8318), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8642), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8644), new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8645), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8807), new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8808), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8809), new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8810), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8811), new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8811), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8813), new DateTime(2024, 11, 18, 10, 33, 8, 150, DateTimeKind.Local).AddTicks(8813), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
