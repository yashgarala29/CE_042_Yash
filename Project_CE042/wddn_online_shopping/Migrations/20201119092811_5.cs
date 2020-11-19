using Microsoft.EntityFrameworkCore.Migrations;

namespace wddn_online_shopping.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "customer_cart_id",
                table: "cart_Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "product_cart_id",
                table: "cart_Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customer_cart_id",
                table: "cart_Items");

            migrationBuilder.DropColumn(
                name: "product_cart_id",
                table: "cart_Items");
        }
    }
}
