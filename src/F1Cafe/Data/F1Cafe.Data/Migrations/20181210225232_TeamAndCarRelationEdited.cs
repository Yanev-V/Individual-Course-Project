using Microsoft.EntityFrameworkCore.Migrations;

namespace F1Cafe.Data.Migrations
{
    public partial class TeamAndCarRelationEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cars_TeamId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Teams");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_TeamId",
                table: "Cars",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cars_TeamId",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_TeamId",
                table: "Cars",
                column: "TeamId",
                unique: true);
        }
    }
}
