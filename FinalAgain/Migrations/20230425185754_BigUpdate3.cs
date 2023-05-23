using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalAgain.Migrations
{
    public partial class BigUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseTypes");

            migrationBuilder.AddColumn<int>(
                name: "TypeOfCourseId",
                table: "Classes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TypeOfCourseId",
                table: "Classes",
                column: "TypeOfCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_typeOfCourses_TypeOfCourseId",
                table: "Classes",
                column: "TypeOfCourseId",
                principalTable: "typeOfCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_typeOfCourses_TypeOfCourseId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_TypeOfCourseId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TypeOfCourseId",
                table: "Classes");

            migrationBuilder.CreateTable(
                name: "CourseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    TypeOfCourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseTypes_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTypes_typeOfCourses_TypeOfCourseId",
                        column: x => x.TypeOfCourseId,
                        principalTable: "typeOfCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseTypes_ClassId",
                table: "CourseTypes",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTypes_TypeOfCourseId",
                table: "CourseTypes",
                column: "TypeOfCourseId");
        }
    }
}
