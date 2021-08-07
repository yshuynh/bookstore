using Microsoft.EntityFrameworkCore.Migrations;

namespace book.Migrations
{
    public partial class CoverForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cover_form",
                table: "book_meta",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cover_form",
                table: "book_meta");
        }
    }
}
