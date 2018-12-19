using Microsoft.EntityFrameworkCore.Migrations;

namespace F1Cafe.Data.Migrations
{
    public partial class RaceImgAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Races",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Races");
        }
    }
}
