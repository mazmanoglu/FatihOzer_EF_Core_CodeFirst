using Microsoft.EntityFrameworkCore.Migrations;

namespace FatihOzer_EF_Core_CodeFirst.Migrations
{
    public partial class createauthorclasswithdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    SurName = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name", "SurName" },
                values: new object[] { 1, "Kenan", "Kurda" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name", "SurName" },
                values: new object[] { 2, "Pearl", "De Smet" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name", "SurName" },
                values: new object[] { 3, "Ruud", "Marks" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
