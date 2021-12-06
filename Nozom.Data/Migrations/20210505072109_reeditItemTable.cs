using Microsoft.EntityFrameworkCore.Migrations;

namespace Nozom.Data.Migrations
{
    public partial class reeditItemTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Item");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Items",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Items");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Item",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
