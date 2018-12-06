using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace F1Cafe.Data.Migrations
{
    public partial class ExceptionLogModelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbExceptionLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExeptionType = table.Column<string>(nullable: false),
                    Message = table.Column<string>(nullable: false),
                    StackTrace = table.Column<string>(nullable: false),
                    ControllerName = table.Column<string>(nullable: false),
                    ActionName = table.Column<string>(nullable: false),
                    LogTime = table.Column<DateTime>(nullable: false),
                    User = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbExceptionLogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbExceptionLogs");
        }
    }
}
