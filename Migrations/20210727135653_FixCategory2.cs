using Microsoft.EntityFrameworkCore.Migrations;

namespace book.Migrations
{
    public partial class FixCategory2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "category_id",
                table: "SubCategory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_category_id",
                table: "SubCategory",
                column: "category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategory_category_category_id",
                table: "SubCategory",
                column: "category_id",
                principalTable: "category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategory_category_category_id",
                table: "SubCategory");

            migrationBuilder.DropIndex(
                name: "IX_SubCategory_category_id",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "category_id",
                table: "SubCategory");
        }
    }
}
