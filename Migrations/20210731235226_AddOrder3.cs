using Microsoft.EntityFrameworkCore.Migrations;

namespace book.Migrations
{
    public partial class AddOrder3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_book_user_id",
                table: "Orders");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_user_user_id",
                table: "Orders",
                column: "user_id",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_user_user_id",
                table: "Orders");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_book_user_id",
                table: "Orders",
                column: "user_id",
                principalTable: "book",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
