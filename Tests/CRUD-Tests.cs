using Xunit;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
public class CRUDTest
{
    private ModelContext Context;
    public CRUDTest()
    {
        
        var options = new DbContextOptionsBuilder<ModelContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
       
        Context = new ModelContext(options);
        
    }
    
    [Fact]
    public void GetTest()
    {
       
        Context.ItemGroups.Add(new ItemGroup { Id = 1, Name = "Group 1" });
        Context.ItemGroups.Add(new ItemGroup { Id = 2, Name = "Group 2" });
        Context.ItemGroups.Add(new ItemGroup { Id = 9, Name = "Group 2" });
        Context.locations.Add(new Location { Id = 1, Name = "Location 1" });
        Context.locations.Add(new Location { Id = 2, Name = "Location 2" });
        Context.locations.Add(new Location { Id = 9, Name = "Location 3" });
        Context.Clients.Add(new Client { Id = 9, Name = "Location 3" });
    
        Context.SaveChanges(); // heel raar hoe dit werkt ik kan dit niet op de constructor 
        //zetten zonder dat dingen breken op een niet logische volgorde
        
        
        // var CheckClient = new ClientService(Context);
        var CheckServiceitemGroup = new CrudService<ItemGroup>(Context);
        var CheckServiceitemLocation= new CrudService<Location>(Context);
        ItemGroup itemGroup = CheckServiceitemGroup.Get(9);
        Location location = CheckServiceitemLocation.Get(9);
        // Client client = CheckClient.Get(9);
        // Assert.Equal("Location 3",client.Name);
        Assert.Equal("Group 2",itemGroup.Name);
        Assert.Equal("Location 3",location.Name);
    }
    [Fact]
    public void AnotherGetTestWithListInClass()
    {
        // Given
        var testOrder = new Order
        {
            Id = 1,
            SourceId = 1001,
            OrderDate = DateTime.UtcNow,
            RequestDate = DateTime.UtcNow.AddDays(7),
            Reference = "REF12345",
            ReferenceExtra = "Extra details",
            OrderStatus = "Pending",
            Notes = "This is a test order",
            ShippingNotes = "Handle with care",
            PickingNotes = "Prioritize fragile items",
            WarehouseId = 2,
            ShipTo = 10,
            BillTo = 20,
            ShipmentId = 30,
            TotalAmount = 500.00m,
            TotalDiscount = 50.00m,
            TotalTax = 25.00m,
            TotalSurcharge = 10.00m,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            Items = new List<OrderItem>
            {
                new OrderItem
                {
                    Id = 1,
                    ItemId = 101,
                    OrderId = 1, 
                    Amount = 5
                },
                new OrderItem
                {
                    Id = 2,
                    ItemId = 102,
                    OrderId = 1,
                    Amount = 3
                }
            }
        };
        Context.orders.Add(testOrder);
        Context.SaveChanges();
        var OrderService = new CrudService<Order>(Context);
        // When
        var checkOrderItem  = OrderService.Get(1);

    
        // Then
        Assert.Equal(101,checkOrderItem.Items[0].ItemId);
    }
    [Fact]
    public void GetAllTest()
    {
        // Given

        Context.warehouses.Add(new Warehouse { Id = 1, Name = "Location 1" });
        Context.warehouses.Add(new Warehouse { Id = 2, Name = "Location 2" });
        Context.warehouses.Add(new Warehouse { Id = 9, Name = "Location 3" });
        Context.SaveChanges();
        var WarehouseService = new CrudService<Warehouse>(Context);

        // When
        

        int amount = WarehouseService.GetAll().Count;
        // Then
        Assert.Equal(3,amount);
    }
    [Fact]
    public void DeleteTest()
    {
        // Given
            
        // When
        var CheckServiceitemGroup = new CrudService<ItemGroup>(Context);
        var CheckServiceitemLocation= new CrudService<Location>(Context);
        bool check = CheckServiceitemGroup.Delete(1);
        bool check2 = CheckServiceitemLocation.Delete(1);
        // Then
        Assert.True(check);
        Assert.True(check2);
    }
    [Fact]
    public void Update() // can be both put and/or patch 
    {
        // Given
        Context.suppliers.Add(new Supplier{Id=1, Code ="jewbaka"});
        Context.SaveChanges();
    
        // When
        var SupplierService = new CrudService<Supplier>(Context);
        SupplierService.Put(new Supplier{Id = 1, Code = "baka"});
        SupplierService.Put(new Supplier{Id = 1, Code = "sigaar"});

        // Then
        Supplier check = SupplierService.Get(1);
        Assert.Equal("sigaar",check.Code);
    }
    
    
}
// alles word gerunt voordat de check word gedaan of iets goed is of niet