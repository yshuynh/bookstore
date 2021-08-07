using Microsoft.EntityFrameworkCore.Migrations;

namespace book.Migrations
{
    public partial class FixCartItemOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Orders_order_id",
                table: "CartItem");

            migrationBuilder.AlterColumn<int>(
                name: "order_id",
                table: "CartItem",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Orders_order_id",
                table: "CartItem",
                column: "order_id",
                principalTable: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Orders_order_id",
                table: "CartItem");

            migrationBuilder.AlterColumn<int>(
                name: "order_id",
                table: "CartItem",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Orders_order_id",
                table: "CartItem",
                column: "order_id",
                principalTable: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
