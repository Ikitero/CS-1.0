using Microsoft.EntityFrameworkCore.Migrations;

namespace CS_1._0.Migrations
{
    public partial class refresh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RecordTypes",
                columns: new[] { "RecordTypeId", "RecordTypeName" },
                values: new object[,]
                {
                    { 1, "Slider" },
                    { 2, "Header and text" },
                    { 3, "Text and image on the left" },
                    { 4, "Text and image on the right" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "RecordTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "RecordTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "RecordTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "RecordTypeId",
                keyValue: 4);
        }
    }
}
