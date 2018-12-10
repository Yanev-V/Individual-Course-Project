using Microsoft.EntityFrameworkCore.Migrations;

namespace F1Cafe.Data.Migrations
{
    public partial class CarAndTeamModelsEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Cars",
                newName: "SideImage");

            migrationBuilder.AddColumn<string>(
                name: "TeamLogo",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FrontImage",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RearImage",
                table: "Cars",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamLogo",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "FrontImage",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "RearImage",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "SideImage",
                table: "Cars",
                newName: "ImageUrl");
        }
    }
}
