using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gorev7P013.Migrations
{
    /// <inheritdoc />
    public partial class Brandcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 23, 47, 32, 581, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 23, 47, 32, 581, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 23, 47, 32, 581, DateTimeKind.Local).AddTicks(8099));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 22, 12, 58, 411, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 22, 12, 58, 411, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 14, 22, 12, 58, 411, DateTimeKind.Local).AddTicks(333));
        }
    }
}
