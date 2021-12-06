using Microsoft.EntityFrameworkCore.Migrations;

namespace Nozom.Data.Migrations
{
    public partial class editItemTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemTransactions_Items_ItemId",
                table: "ItemTransactions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Serial",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Items");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Items",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Serial = table.Column<string>(maxLength: 50, nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    ItemsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_CategoryId",
                table: "Item",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemsId",
                table: "Item",
                column: "ItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTransactions_Item_ItemId",
                table: "ItemTransactions",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemTransactions_Item_ItemId",
                table: "ItemTransactions");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Items",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Items",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Serial",
                table: "Items",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTransactions_Items_ItemId",
                table: "ItemTransactions",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
