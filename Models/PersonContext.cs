using Microsoft.EntityFrameworkCore;


    public class ModelContext : DbContext
    {
        // DbSets for your entities

        public DbSet<Client> Clients { get; set; }
        public DbSet<Inventory> inventories {get;set;}
        public DbSet<ItemGroup> ItemGroups {get;set;}
        public DbSet<ItemLine> itemLines {get;set;}
        public DbSet<ItemType> itemTypes {get;set;}
        public DbSet<Item> items {get;set;}
        public DbSet<Location> locations {get;set;}
        public DbSet<Order> orders {get;set;}
        public DbSet<OrderItem> orderItems {get;set;}
        public DbSet<Shipment> shipments {get;set;}
        public DbSet<ShipmentItem> shipmentItems {get;set;}
        public DbSet<Supplier> suppliers {get;set;}
        public DbSet<Transfer> transfers {get;set;}
        public DbSet<TransferItem> transferItems {get;set;}
        public DbSet<Warehouse> warehouses {get;set;}



        public ModelContext(DbContextOptions<ModelContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        //     // Item
        //    modelBuilder.Entity<Item>()
        //     .HasOne<ItemLine>()  
        //     .WithMany()          
        //     .HasForeignKey(i => i.ItemLineId);

        // modelBuilder.Entity<Item>()
        //     .HasOne<ItemGroup>() 
        //     .WithMany()          
        //     .HasForeignKey(i => i.ItemGroupId);

        // modelBuilder.Entity<Item>()
        //     .HasOne<ItemType>()  
        //     .WithMany()         
        //     .HasForeignKey(i => i.ItemTypeId);

        //             // Order and OrderItem (One-to-Many)
        // modelBuilder.Entity<Order>()
        //     .HasMany(o => o.Items)
        //     .WithOne()
        //     .HasForeignKey(oi => oi.Id);

        // // Shipment and ShipmentItem (One-to-Many)
        // modelBuilder.Entity<Shipment>()
        //     .HasMany(s => s.Items)
        //     .WithOne()
        //     .HasForeignKey(si => si.Id);

        // // Transfer and TransferItem (One-to-Many)
        // modelBuilder.Entity<Transfer>()
        //     .HasMany(t => t.Items)
        //     .WithOne()
        //     .HasForeignKey(ti => ti.Id);

        // // Warehouse and Location (One-to-Many)
        // modelBuilder.Entity<Location>()
        //     .HasOne<Warehouse>()
        //     .WithMany()
        //     .HasForeignKey(l => l.WarehouseId);

        // // Order and Warehouse (Many-to-One)
        // modelBuilder.Entity<Order>()
        //     .HasOne<Warehouse>()
        //     .WithMany()
        //     .HasForeignKey(o => o.WarehouseId);

        // // Order and Shipment (One-to-One)
        // modelBuilder.Entity<Order>()
        //     .HasOne(o => o.Shipment)
        //     .WithOne()
        //     .HasForeignKey<Order>(o => o.ShipmentId);

        // }
        // Item Relationships
    // modelBuilder.Entity<Item>()
    //     .HasOne<ItemGroup>()
    //     .WithMany()
    //     .HasForeignKey(i => i.ItemGroupId);

    // modelBuilder.Entity<Item>()
    //     .HasOne<ItemLine>()
    //     .WithMany()
    //     .HasForeignKey(i => i.ItemLineId);

    // modelBuilder.Entity<Item>()
    //     .HasOne<ItemType>()
    //     .WithMany()
    //     .HasForeignKey(i => i.ItemTypeId);

    // // Order and OrderItem (One-to-Many)
    // modelBuilder.Entity<Order>()
    //     .HasMany(o => o.Items)
    //     .WithOne()
    //     .HasForeignKey(oi => oi.Id);

    // // Shipment and ShipmentItem (One-to-Many)
    // modelBuilder.Entity<Shipment>()
    //     .HasMany(s => s.Items)
    //     .WithOne()
    //     .HasForeignKey(si => si.Id);

    // // Transfer and TransferItem (One-to-Many)
    // modelBuilder.Entity<Transfer>()
    //     .HasMany(t => t.Items)
    //     .WithOne()
    //     .HasForeignKey(ti => ti.Id);

    // // Warehouse and Location (One-to-Many)
    // modelBuilder.Entity<Location>()
    //     .HasOne<Warehouse>()
    //     .WithMany()
    //     .HasForeignKey(l => l.WarehouseId);

    // // Order and Shipment (One-to-One) using Foreign Key
    // modelBuilder.Entity<Order>()
    //     .HasOne<Shipment>()
    //     .WithMany()
    //     .HasForeignKey(o => o.ShipmentId);

    // Other configurations can go here
        }
    }

