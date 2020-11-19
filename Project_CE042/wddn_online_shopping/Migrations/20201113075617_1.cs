using Microsoft.EntityFrameworkCore.Migrations;

namespace wddn_online_shopping.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_confirm_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_mobile_no = table.Column<int>(type: "int", nullable: false),
                    customer_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "sellers",
                columns: table => new
                {
                    seller_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seller_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    seller_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    seller_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    seller_confirm_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    seller_mobile_no = table.Column<int>(type: "int", nullable: false),
                    seller_shop_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    seller_image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sellers", x => x.seller_id);
                });

            migrationBuilder.CreateTable(
                name: "item_Details",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_quantity = table.Column<int>(type: "int", nullable: false),
                    product_price = table.Column<int>(type: "int", nullable: false),
                    product_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    seller_detailseller_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_Details", x => x.product_id);
                    table.ForeignKey(
                        name: "FK_item_Details_sellers_seller_detailseller_id",
                        column: x => x.seller_detailseller_id,
                        principalTable: "sellers",
                        principalColumn: "seller_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cart_Items",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    customer_id1 = table.Column<int>(type: "int", nullable: true),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    item_Detailproduct_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cart_Items", x => x.id);
                    table.ForeignKey(
                        name: "FK_cart_Items_customers_customer_id1",
                        column: x => x.customer_id1,
                        principalTable: "customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cart_Items_item_Details_item_Detailproduct_id",
                        column: x => x.item_Detailproduct_id,
                        principalTable: "item_Details",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "customeritem_detail",
                columns: table => new
                {
                    buyers_listcustomer_id = table.Column<int>(type: "int", nullable: false),
                    customer_orederproduct_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customeritem_detail", x => new { x.buyers_listcustomer_id, x.customer_orederproduct_id });
                    table.ForeignKey(
                        name: "FK_customeritem_detail_customers_buyers_listcustomer_id",
                        column: x => x.buyers_listcustomer_id,
                        principalTable: "customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_customeritem_detail_item_Details_customer_orederproduct_id",
                        column: x => x.customer_orederproduct_id,
                        principalTable: "item_Details",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cart_Items_customer_id1",
                table: "cart_Items",
                column: "customer_id1");

            migrationBuilder.CreateIndex(
                name: "IX_cart_Items_item_Detailproduct_id",
                table: "cart_Items",
                column: "item_Detailproduct_id");

            migrationBuilder.CreateIndex(
                name: "IX_customeritem_detail_customer_orederproduct_id",
                table: "customeritem_detail",
                column: "customer_orederproduct_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_Details_seller_detailseller_id",
                table: "item_Details",
                column: "seller_detailseller_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cart_Items");

            migrationBuilder.DropTable(
                name: "customeritem_detail");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "item_Details");

            migrationBuilder.DropTable(
                name: "sellers");
        }
    }
}
