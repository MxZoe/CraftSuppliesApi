using Microsoft.EntityFrameworkCore.Migrations;

namespace craftSupplies.Migrations
{
    public partial class fixStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hex",
                table: "EmbroideryThreads");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "EmbroideryThreads");
        }
    }
}
