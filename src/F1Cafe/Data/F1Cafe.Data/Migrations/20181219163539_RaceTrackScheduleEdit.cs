using Microsoft.EntityFrameworkCore.Migrations;

namespace F1Cafe.Data.Migrations
{
    public partial class RaceTrackScheduleEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Races_Schedules_ScheduleId",
                table: "Races");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Tracks_TrackId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_ScheduleId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_TrackId",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "RaceDistance",
                table: "Races");

            migrationBuilder.CreateIndex(
                name: "IX_Races_ScheduleId",
                table: "Races",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_TrackId",
                table: "Races",
                column: "TrackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Schedules_ScheduleId",
                table: "Races",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Tracks_TrackId",
                table: "Races",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Races_Schedules_ScheduleId",
                table: "Races");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Tracks_TrackId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_ScheduleId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_TrackId",
                table: "Races");

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Tracks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Schedules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "RaceDistance",
                table: "Races",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Races_ScheduleId",
                table: "Races",
                column: "ScheduleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Races_TrackId",
                table: "Races",
                column: "TrackId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Schedules_ScheduleId",
                table: "Races",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Tracks_TrackId",
                table: "Races",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
