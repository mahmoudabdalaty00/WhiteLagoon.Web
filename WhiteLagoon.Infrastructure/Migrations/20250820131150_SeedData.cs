using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A villa with a stunning beach view.", "https://www.bing.com/ck/a?!&&p=43cdb6ccfa1f7379d23e4a02b9154bf2e7e9c51281e99b698f5cf6ead584a3f5JmltdHM9MTc1NTY0ODAwMA&ptn=3&ver=2&hsh=4&fclid=2c66945a-1217-6b5c-2159-84b9136b6a71&u=a1L2ltYWdlcy9zZWFyY2g_cT12aWxsYStpbWFnZXMmaWQ9QjkzRkZGNjUwRDQxMDU4QTAzN0U4QUVEQTc5MkVENUJGQzZBNzNCOCZGT1JNPUlBQ0ZJUg&ntb=1", "Luxury Beach Villa", 4, 500.0, 1200, null },
                    { 2, new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quiet villa in the mountains.", "https://www.bing.com/ck/a?!&&p=43cdb6ccfa1f7379d23e4a02b9154bf2e7e9c51281e99b698f5cf6ead584a3f5JmltdHM9MTc1NTY0ODAwMA&ptn=3&ver=2&hsh=4&fclid=2c66945a-1217-6b5c-2159-84b9136b6a71&u=a1L2ltYWdlcy9zZWFyY2g_cT12aWxsYStpbWFnZXMmaWQ9QjkzRkZGNjUwRDQxMDU4QTAzN0U4QUVEQTc5MkVENUJGQzZBNzNCOCZGT1JNPUlBQ0ZJUg&ntb=1", "Mountain Retreat", 3, 350.0, 950, null },
                    { 3, new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Located in the heart of the city.", "https://s-media-cache-ak0.pinimg.com/originals/22/80/13/228013d23c2ca5ed80a74c6bfd6da3e2.jpg", "City Center Villa", 5, 600.0, 1500, null },
                    { 4, new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Experience the desert lifestyle.", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/07/0b/fa/c1/diana-hotel.jpg?w=900&h=500&s=1", "Desert Escape", 4, 400.0, 1100, null },
                    { 5, new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Villa with a relaxing lake view.", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/11/3b/a0/70/diana-hotel.jpg?w=300&h=200&s=1", "Lake House Villa", 4, 450.0, 1300, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
