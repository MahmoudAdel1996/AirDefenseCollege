using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nozom.Data.Migrations
{
    public partial class rearangeColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Daragat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daragat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceState",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Serial = table.Column<string>(maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaragaId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persons_Daragat_DaragaId",
                        column: x => x.DaragaId,
                        principalTable: "Daragat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceName = table.Column<string>(maxLength: 50, nullable: false),
                    DeviceTypeId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    StoredBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_DeviceTypes_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "DeviceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnterDate = table.Column<DateTime>(nullable: false),
                    ExitDate = table.Column<DateTime>(nullable: true),
                    OwnerDaragaId = table.Column<int>(nullable: false),
                    OwnerName = table.Column<string>(maxLength: 50, nullable: false),
                    ReciverDaragaId = table.Column<int>(nullable: false),
                    ReciverName = table.Column<string>(maxLength: 50, nullable: false),
                    HandOverToDaragaId = table.Column<int>(nullable: true),
                    HandOverToName = table.Column<string>(maxLength: 50, nullable: true),
                    DeviceTypeId = table.Column<int>(nullable: false),
                    DeviceName = table.Column<string>(maxLength: 50, nullable: true),
                    DeviceBranchId = table.Column<int>(nullable: false),
                    DeviceStateId = table.Column<int>(nullable: false),
                    ProblemDeescription = table.Column<string>(maxLength: 255, nullable: true),
                    Notes = table.Column<string>(maxLength: 255, nullable: true),
                    DeviceSrialNumber = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Branches_DeviceBranchId",
                        column: x => x.DeviceBranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_DeviceState_DeviceStateId",
                        column: x => x.DeviceStateId,
                        principalTable: "DeviceState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_DeviceTypes_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "DeviceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Daragat_HandOverToDaragaId",
                        column: x => x.HandOverToDaragaId,
                        principalTable: "Daragat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_Daragat_OwnerDaragaId",
                        column: x => x.OwnerDaragaId,
                        principalTable: "Daragat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Daragat_ReciverDaragaId",
                        column: x => x.ReciverDaragaId,
                        principalTable: "Daragat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    HandOverPersonId = table.Column<int>(nullable: false),
                    ReciverPersonId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Paid = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemTransactions_Persons_HandOverPersonId",
                        column: x => x.HandOverPersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemTransactions_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemTransactions_Persons_ReciverPersonId",
                        column: x => x.ReciverPersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeviceTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceReciverName = table.Column<string>(maxLength: 50, nullable: false),
                    DeviceId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceTransactions_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_DeviceTypeId",
                table: "Devices",
                column: "DeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceTransactions_DeviceId",
                table: "DeviceTransactions",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTransactions_HandOverPersonId",
                table: "ItemTransactions",
                column: "HandOverPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTransactions_ItemId",
                table: "ItemTransactions",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTransactions_ReciverPersonId",
                table: "ItemTransactions",
                column: "ReciverPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_BranchId",
                table: "Persons",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_DaragaId",
                table: "Persons",
                column: "DaragaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_DeviceBranchId",
                table: "Transactions",
                column: "DeviceBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_DeviceStateId",
                table: "Transactions",
                column: "DeviceStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_DeviceTypeId",
                table: "Transactions",
                column: "DeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_HandOverToDaragaId",
                table: "Transactions",
                column: "HandOverToDaragaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_OwnerDaragaId",
                table: "Transactions",
                column: "OwnerDaragaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ReciverDaragaId",
                table: "Transactions",
                column: "ReciverDaragaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceTransactions");

            migrationBuilder.DropTable(
                name: "ItemTransactions");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "DeviceState");

            migrationBuilder.DropTable(
                name: "DeviceTypes");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Daragat");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
