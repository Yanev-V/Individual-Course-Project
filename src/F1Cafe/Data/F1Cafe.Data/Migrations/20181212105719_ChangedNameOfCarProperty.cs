using Microsoft.EntityFrameworkCore.Migrations;

namespace F1Cafe.Data.Migrations
{
    public partial class ChangedNameOfCarProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RearImage",
                table: "Cars",
                newName: "TopImage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TopImage",
                table: "Cars",
                newName: "RearImage");
        }
    }
}
