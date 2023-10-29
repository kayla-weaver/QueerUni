using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueerUni.Migrations
{
    public partial class UpdateTrackzModelz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Track1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Track2",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Track3",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "TrackName",
                table: "Tracks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TrackName",
                table: "Tracks",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "Track1",
                table: "Students",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Track2",
                table: "Students",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Track3",
                table: "Students",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
