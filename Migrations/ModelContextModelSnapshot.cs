﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Practicum3.Migrations
{
    [DbContext(typeof(ModelContext))]
    partial class ModelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("text");

                    b.Property<string>("ContactName")
                        .HasColumnType("text");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ZipCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ItemReference")
                        .HasColumnType("text");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.Property<int>("TotalAllocated")
                        .HasColumnType("integer");

                    b.Property<int>("TotalAvailable")
                        .HasColumnType("integer");

                    b.Property<int>("TotalExpected")
                        .HasColumnType("integer");

                    b.Property<int>("TotalOnHand")
                        .HasColumnType("integer");

                    b.Property<int>("TotalOrdered")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("inventories");
                });

            modelBuilder.Entity("Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("CommodityCode")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("ItemGroupId")
                        .HasColumnType("integer");

                    b.Property<int>("ItemLineId")
                        .HasColumnType("integer");

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("ModelNumber")
                        .HasColumnType("text");

                    b.Property<int>("PackOrderQuantity")
                        .HasColumnType("integer");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("text");

                    b.Property<string>("SupplierCode")
                        .HasColumnType("text");

                    b.Property<int>("SupplierId")
                        .HasColumnType("integer");

                    b.Property<string>("SupplierPartNumber")
                        .HasColumnType("text");

                    b.Property<int>("UnitOrderQuantity")
                        .HasColumnType("integer");

                    b.Property<int>("UnitPurchaseQuantity")
                        .HasColumnType("integer");

                    b.Property<string>("UpcCode")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("items");
                });

            modelBuilder.Entity("ItemGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("ItemGroups");
                });

            modelBuilder.Entity("ItemLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("itemLines");
                });

            modelBuilder.Entity("ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("itemTypes");
                });

            modelBuilder.Entity("Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("locations");
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BillTo")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("text");

                    b.Property<string>("PickingNotes")
                        .HasColumnType("text");

                    b.Property<string>("Reference")
                        .HasColumnType("text");

                    b.Property<string>("ReferenceExtra")
                        .HasColumnType("text");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ShipTo")
                        .HasColumnType("integer");

                    b.Property<int>("ShipmentId")
                        .HasColumnType("integer");

                    b.Property<string>("ShippingNotes")
                        .HasColumnType("text");

                    b.Property<int>("SourceId")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TotalDiscount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TotalSurcharge")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TotalTax")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("orderItems");
                });

            modelBuilder.Entity("Shipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CarrierCode")
                        .HasColumnType("text");

                    b.Property<string>("CarrierDescription")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<string>("PaymentType")
                        .HasColumnType("text");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ServiceCode")
                        .HasColumnType("text");

                    b.Property<DateTime>("ShipmentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ShipmentStatus")
                        .HasColumnType("text");

                    b.Property<string>("ShipmentType")
                        .HasColumnType("text");

                    b.Property<int>("SourceId")
                        .HasColumnType("integer");

                    b.Property<int>("TotalPackageCount")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalPackageWeight")
                        .HasColumnType("numeric");

                    b.Property<string>("TransferMode")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("shipments");
                });

            modelBuilder.Entity("ShipmentItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int?>("ShipmentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ShipmentId");

                    b.ToTable("shipmentItems");
                });

            modelBuilder.Entity("Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("AddressExtra")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("ContactName")
                        .HasColumnType("text");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.Property<string>("Reference")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ZipCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("suppliers");
                });

            modelBuilder.Entity("Transfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Reference")
                        .HasColumnType("text");

                    b.Property<int>("TransferFrom")
                        .HasColumnType("integer");

                    b.Property<string>("TransferStatus")
                        .HasColumnType("text");

                    b.Property<int>("TransferTo")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("transfers");
                });

            modelBuilder.Entity("TransferItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int?>("TransferId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TransferId");

                    b.ToTable("transferItems");
                });

            modelBuilder.Entity("Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("text");

                    b.Property<string>("ContactName")
                        .HasColumnType("text");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Province")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ZipCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("warehouses");
                });

            modelBuilder.Entity("OrderItem", b =>
                {
                    b.HasOne("Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("ShipmentItem", b =>
                {
                    b.HasOne("Shipment", null)
                        .WithMany("Items")
                        .HasForeignKey("ShipmentId");
                });

            modelBuilder.Entity("TransferItem", b =>
                {
                    b.HasOne("Transfer", null)
                        .WithMany("Items")
                        .HasForeignKey("TransferId");
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Shipment", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Transfer", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
