using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalAgain.Migrations
{
    public partial class BigUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseType_Classes_ClassId",
                table: "CourseType");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseType_Type_TypeId",
                table: "CourseType");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseType",
                table: "CourseType");

            migrationBuilder.DropIndex(
                name: "IX_CourseType_TypeId",
                table: "CourseType");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "CourseType");

            migrationBuilder.RenameTable(
                name: "CourseType",
                newName: "CourseTypes");

            migrationBuilder.RenameIndex(
                name: "IX_CourseType_ClassId",
                table: "CourseTypes",
                newName: "IX_CourseTypes_ClassId");

            migrationBuilder.AddColumn<int>(
                name: "TypeOfCourseId",
                table: "CourseTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseTypes",
                table: "CourseTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "typeOfCourses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typeOfCourses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseTypes_TypeOfCourseId",
                table: "CourseTypes",
                column: "TypeOfCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTypes_Classes_ClassId",
                table: "CourseTypes",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTypes_typeOfCourses_TypeOfCourseId",
                table: "CourseTypes",
                column: "TypeOfCourseId",
                principalTable: "typeOfCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTypes_Classes_ClassId",
                table: "CourseTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTypes_typeOfCourses_TypeOfCourseId",
                table: "CourseTypes");

            migrationBuilder.DropTable(
                name: "typeOfCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseTypes",
                table: "CourseTypes");

            migrationBuilder.DropIndex(
                name: "IX_CourseTypes_TypeOfCourseId",
                table: "CourseTypes");

            migrationBuilder.DropColumn(
                name: "TypeOfCourseId",
                table: "CourseTypes");

            migrationBuilder.RenameTable(
                name: "CourseTypes",
                newName: "CourseType");

            migrationBuilder.RenameIndex(
                name: "IX_CourseTypes_ClassId",
                table: "CourseType",
                newName: "IX_CourseType_ClassId");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "CourseType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseType",
                table: "CourseType",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseType_TypeId",
                table: "CourseType",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseType_Classes_ClassId",
                table: "CourseType",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseType_Type_TypeId",
                table: "CourseType",
                column: "TypeId",
                principalTable: "Type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
