using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAmenity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Amenities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "Amenities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Amenities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DisplayOrder", "UpdatedDate" },
                values: new object[] { null, 0, null });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DisplayOrder", "UpdatedDate" },
                values: new object[] { null, 0, null });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DisplayOrder", "UpdatedDate" },
                values: new object[] { null, 0, null });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DisplayOrder", "UpdatedDate" },
                values: new object[] { null, 0, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Amenities");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Amenities");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Amenities");
        }
    }
}
