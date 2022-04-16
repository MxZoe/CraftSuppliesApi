using Microsoft.EntityFrameworkCore.Migrations;

namespace craftSupplies.Migrations
{
    public partial class ChangingItUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Blue",
                table: "EmbroideryThreads");

            migrationBuilder.DropColumn(
                name: "Green",
                table: "EmbroideryThreads");

            migrationBuilder.DropColumn(
                name: "Hex",
                table: "EmbroideryThreads");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "EmbroideryThreads");

            migrationBuilder.DropColumn(
                name: "Red",
                table: "EmbroideryThreads");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Blue",
                table: "EmbroideryThreads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Green",
                table: "EmbroideryThreads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Hex",
                table: "EmbroideryThreads",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "EmbroideryThreads",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Red",
                table: "EmbroideryThreads",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
