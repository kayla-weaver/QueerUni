using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueerUni.Migrations
{
    public partial class UpdateStudentTrackRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Track_Student_StudentId",
                table: "Track");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Track",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Student_StudentId",
                table: "Track",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Track_Student_StudentId",
                table: "Track");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Track",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Student_StudentId",
                table: "Track",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId");
        }
    }
}
