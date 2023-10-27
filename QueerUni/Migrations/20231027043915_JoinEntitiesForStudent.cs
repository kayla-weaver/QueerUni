using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueerUni.Migrations
{
    public partial class JoinEntitiesForStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_AspNetUsers_UserId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Track_Student_StudentId",
                table: "Track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Track",
                table: "Track");

            migrationBuilder.DropIndex(
                name: "IX_Track_StudentId",
                table: "Track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.RenameTable(
                name: "Track",
                newName: "Tracks");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameIndex(
                name: "IX_Student_UserId",
                table: "Students",
                newName: "IX_Students_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks",
                column: "TrackId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "StudentId");

            migrationBuilder.CreateTable(
                name: "StudentTracks",
                columns: table => new
                {
                    StudentTrackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    TrackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTracks", x => x.StudentTrackId);
                    table.ForeignKey(
                        name: "FK_StudentTracks_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTracks_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "TrackId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_StudentId",
                table: "Tracks",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentTracks_StudentId",
                table: "StudentTracks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTracks_TrackId",
                table: "StudentTracks",
                column: "TrackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_UserId",
                table: "Students",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Students_StudentId",
                table: "Tracks",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_UserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Students_StudentId",
                table: "Tracks");

            migrationBuilder.DropTable(
                name: "StudentTracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_StudentId",
                table: "Tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Tracks",
                newName: "Track");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameIndex(
                name: "IX_Students_UserId",
                table: "Student",
                newName: "IX_Student_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Track",
                table: "Track",
                column: "TrackId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Track_StudentId",
                table: "Track",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_AspNetUsers_UserId",
                table: "Student",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Student_StudentId",
                table: "Track",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
