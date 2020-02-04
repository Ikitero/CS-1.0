using Microsoft.EntityFrameworkCore.Migrations;

namespace CS_1._0.Migrations
{
    public partial class InitRecordTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecordTypeId",
                table: "Records",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "RecordTypes",
                columns: table => new
                {
                    RecordTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordTypes", x => x.RecordTypeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecordTypes");

            migrationBuilder.DropColumn(
                name: "RecordTypeId",
                table: "Records");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryName",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
