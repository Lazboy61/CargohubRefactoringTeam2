using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Practicum3.Migrations
{
    /// <inheritdoc />
    public partial class removedrelationstry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_ItemGroups_ItemGroupId",
                table: "items");

            migrationBuilder.DropForeignKey(
                name: "FK_items_itemLines_ItemLineId",
                table: "items");

            migrationBuilder.DropForeignKey(
                name: "FK_items_itemTypes_ItemTypeId",
                table: "items");

            migrationBuilder.DropForeignKey(
                name: "FK_locations_warehouses_WarehouseId",
                table: "locations");

            migrationBuilder.DropForeignKey(
                name: "FK_orderItems_orders_Id",
                table: "orderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_shipments_ShipmentId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_shipmentItems_shipments_Id",
                table: "shipmentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_transferItems_transfers_Id",
                table: "transferItems");

            migrationBuilder.DropIndex(
                name: "IX_orders_ShipmentId",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_locations_WarehouseId",
                table: "locations");

            migrationBuilder.DropIndex(
                name: "IX_items_ItemGroupId",
                table: "items");

            migrationBuilder.DropIndex(
                name: "IX_items_ItemLineId",
                table: "items");

            migrationBuilder.DropIndex(
                name: "IX_items_ItemTypeId",
                table: "items");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "transferItems",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "TransferId",
                table: "transferItems",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "shipmentItems",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "ShipmentId",
                table: "shipmentItems",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "orderItems",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "orderItems",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_transferItems_TransferId",
                table: "transferItems",
                column: "TransferId");

            migrationBuilder.CreateIndex(
                name: "IX_shipmentItems_ShipmentId",
                table: "shipmentItems",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_orderItems_OrderId",
                table: "orderItems",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_orderItems_orders_OrderId",
                table: "orderItems",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_shipmentItems_shipments_ShipmentId",
                table: "shipmentItems",
                column: "ShipmentId",
                principalTable: "shipments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_transferItems_transfers_TransferId",
                table: "transferItems",
                column: "TransferId",
                principalTable: "transfers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderItems_orders_OrderId",
                table: "orderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_shipmentItems_shipments_ShipmentId",
                table: "shipmentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_transferItems_transfers_TransferId",
                table: "transferItems");

            migrationBuilder.DropIndex(
                name: "IX_transferItems_TransferId",
                table: "transferItems");

            migrationBuilder.DropIndex(
                name: "IX_shipmentItems_ShipmentId",
                table: "shipmentItems");

            migrationBuilder.DropIndex(
                name: "IX_orderItems_OrderId",
                table: "orderItems");

            migrationBuilder.DropColumn(
                name: "TransferId",
                table: "transferItems");

            migrationBuilder.DropColumn(
                name: "ShipmentId",
                table: "shipmentItems");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "orderItems");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "transferItems",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "shipmentItems",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "orderItems",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_orders_ShipmentId",
                table: "orders",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_locations_WarehouseId",
                table: "locations",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_items_ItemGroupId",
                table: "items",
                column: "ItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_items_ItemLineId",
                table: "items",
                column: "ItemLineId");

            migrationBuilder.CreateIndex(
                name: "IX_items_ItemTypeId",
                table: "items",
                column: "ItemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_items_ItemGroups_ItemGroupId",
                table: "items",
                column: "ItemGroupId",
                principalTable: "ItemGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_items_itemLines_ItemLineId",
                table: "items",
                column: "ItemLineId",
                principalTable: "itemLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_items_itemTypes_ItemTypeId",
                table: "items",
                column: "ItemTypeId",
                principalTable: "itemTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_locations_warehouses_WarehouseId",
                table: "locations",
                column: "WarehouseId",
                principalTable: "warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderItems_orders_Id",
                table: "orderItems",
                column: "Id",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_shipments_ShipmentId",
                table: "orders",
                column: "ShipmentId",
                principalTable: "shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_shipmentItems_shipments_Id",
                table: "shipmentItems",
                column: "Id",
                principalTable: "shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transferItems_transfers_Id",
                table: "transferItems",
                column: "Id",
                principalTable: "transfers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
