using Microsoft.EntityFrameworkCore.Migrations;

namespace Nozom.Data.Migrations
{
    public partial class editItemTansactionDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemTransactions_Item_ItemId",
                table: "ItemTransactions");

            migrationBuilder.DropIndex(
                name: "IX_ItemTransactions_ItemId",
                table: "ItemTransactions");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "ItemTransactions");

            migrationBuilder.AddColumn<int>(
                name: "ItemsId",
                table: "ItemTransactions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ItemTransactions_ItemsId",
                table: "ItemTransactions",
                column: "ItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTransactions_Items_ItemsId",
                table: "ItemTransactions",
                column: "ItemsId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemTransactions_Items_ItemsId",
                table: "ItemTransactions");

            migrationBuilder.DropIndex(
                name: "IX_ItemTransactions_ItemsId",
                table: "ItemTransactions");

            migrationBuilder.DropColumn(
                name: "ItemsId",
                table: "ItemTransactions");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "ItemTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ItemTransactions_ItemId",
                table: "ItemTransactions",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTransactions_Item_ItemId",
                table: "ItemTransactions",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
