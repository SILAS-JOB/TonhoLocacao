using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TonhoLocacao.Migrations
{
    /// <inheritdoc />
    public partial class orderssetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Orders",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrdersDate",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Orders",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OrdersDate",
                table: "AspNetUsers");
        }
    }
}
