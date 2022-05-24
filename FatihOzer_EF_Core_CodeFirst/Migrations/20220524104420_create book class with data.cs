using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FatihOzer_EF_Core_CodeFirst.Migrations
{
    public partial class createbookclasswithdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Published = table.Column<DateTime>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Published", "StudentId", "Title" },
                values: new object[] { 1, new DateTime(1980, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "basics of maths" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Published", "StudentId", "Title" },
                values: new object[] { 2, new DateTime(2010, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "csharp examples" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Published", "StudentId", "Title" },
                values: new object[] { 3, new DateTime(2015, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "dependency injection in dotnet" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_StudentId",
                table: "Books",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
